using QLTV.Database;
using QLTV.Database.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using QLTV.Database.DTO;

namespace QLTV
{
    public partial class BaoCao_ThongKe : Form
    {
        public BaoCao_ThongKe()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            // Date Picker setup
            dtpTuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDenNgay.Value = DateTime.Now;
            lblTongTien.Visible = false;

            // Load Report List
            Dictionary<string, string> reports = new Dictionary<string, string>()
            {
                { "BOOKS_AVAILABLE", "1. Sách đang có sẵn trong kho" },
                { "BOOKS_BORROWED", "2. Sách đang được mượn (Chưa trả)" },
                { "OVERDUE_LOANS", "3. Danh sách quá hạn & Tiền phạt" },
                { "TOP_READERS", "4. Top 10 Độc giả tích cực nhất" },
                { "REVENUE_FINES", "5. Doanh thu tiền phạt (Chi tiết)" },
                { "TREND_YEAR", "6. Xu hướng mượn sách (Theo tháng)" },
                { "STATS_GENRE", "7. Thống kê theo Thể loại" },
                { "STATS_AUTHOR", "8. Thống kê theo Tác giả" }
            };
            cboLoaiThongKe.DataSource = new BindingSource(reports, null);
            cboLoaiThongKe.DisplayMember = "Value";
            cboLoaiThongKe.ValueMember = "Key";
            cboLoaiThongKe.SelectedIndex = 0;

            // Load Dashboard Data ngay khi mở
            LoadDashboardAsync();
        }

        // ================== LOGIC DASHBOARD (TAB 1) ==================
        private async void LoadDashboardAsync()
        {
            try
            {
                using (var db = new QLTVDataContext())
                {
                    // 1. Load 4 KPI Cards
                    var totalBooks = await db.Sachs.SumAsync(s => (int?)s.SoLuong_Sach) ?? 0;
                    var activeLoans = await db.PhieuMuons.CountAsync(p => p.TrangThai_PhieuMuon == "Đang mượn");
                    var overdue = await db.PhieuMuons.CountAsync(p => p.TrangThai_PhieuMuon == "Đang mượn" && p.HanTra_PhieuMuon < DateTime.Now);

                    // Doanh thu tháng này
                    var startMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    var revenueMonth = await db.Phats
                        .Where(p => p.DaThanhToan && p.NgayPhat >= startMonth)
                        .SumAsync(p => (decimal?)p.SoTien_Phat) ?? 0;

                    // Update UI (Cards)
                    lblCard1Value.Text = totalBooks.ToString("N0");
                    lblCard2Value.Text = activeLoans.ToString("N0");
                    lblCard3Value.Text = overdue.ToString("N0");
                    lblCard4Value.Text = revenueMonth.ToString("N0");

                    // 2. Chart Xu Hướng Mượn (Năm nay)
                    var yearData = await db.PhieuMuons
                        .Where(p => p.NgayMuon_Sach.Year == DateTime.Now.Year)
                        .GroupBy(p => p.NgayMuon_Sach.Month)
                        .Select(g => new { Month = g.Key, Count = g.Count() })
                        .ToListAsync();

                    chartTrend.Series[0].Points.Clear();
                    for (int i = 1; i <= 12; i++)
                    {
                        var data = yearData.FirstOrDefault(x => x.Month == i);
                        chartTrend.Series[0].Points.AddXY("T" + i, data?.Count ?? 0);
                    }

                    // 3. Chart Tròn (Thể loại) - Top 5
                    var genreData = db.Sachs // Cần load về client để group string
                        .GroupBy(s => s.TheLoai_Sach)
                        .Select(g => new { Name = g.Key, Count = g.Count() })
                        .OrderByDescending(x => x.Count)
                        .Take(5)
                        .ToList();

                    chartPieCategory.Series[0].Points.Clear();
                    foreach (var item in genreData)
                    {
                        chartPieCategory.Series[0].Points.AddXY(item.Name, item.Count);
                    }
                }
            }
            catch (Exception ex)
            {
                // Silent fail or log
                MessageBox.Show("Lỗi tải Dashboard: " + ex.Message);
            }
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab == tabDashboard)
                LoadDashboardAsync(); // Refresh dashboard khi quay lại
        }

        // ================== LOGIC BÁO CÁO (TAB 2) ==================

        private void cboLoaiThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cboLoaiThongKe.SelectedValue?.ToString();
            bool hasDateFilter = (type == "REVENUE_FINES" || type == "TREND_YEAR");
            dtpTuNgay.Enabled = hasDateFilter;
            dtpDenNgay.Enabled = hasDateFilter;
            lblTongTien.Visible = (type == "REVENUE_FINES");

            // Reset Grid
            dgvKetQua.DataSource = null;
            chartThongKe.Series.Clear();
        }

        private async void btnThongKe_Click(object sender, EventArgs e)
        {
            string type = cboLoaiThongKe.SelectedValue.ToString();
            DateTime from = dtpTuNgay.Value.Date;
            DateTime to = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);

            btnThongKe.Text = "Đang tải...";
            btnThongKe.Enabled = false;

            try
            {
                object result = null;
                decimal totalRev = 0;

                await Task.Run(() => {
                    using (var db = new QLTVDataContext())
                    {
                        db.Configuration.LazyLoadingEnabled = false;
                        switch (type)
                        {
                            case "BOOKS_AVAILABLE":
                                result = db.Sachs.Where(s => s.SoLuong_Sach > 0).Select(s => new { ID = s.IDSach, Ten = s.Name_Sach, SL = s.SoLuong_Sach, TL = s.TheLoai_Sach }).ToList();
                                break;
                            case "BOOKS_BORROWED":
                                result = db.PhieuMuons.Where(p => p.TrangThai_PhieuMuon == "Đang mượn")
                                    .Include(p => p.SACHDATA).Include(p => p.DOCGIADATA.NGUOIDUNGDATA)
                                    .Select(p => new { MaPhieu = p.IDPhieuMuon, Sach = p.SACHDATA.Name_Sach, DocGia = p.DOCGIADATA.NGUOIDUNGDATA.HoTen_NguoiDung, NgayMuon = p.NgayMuon_Sach }).ToList();
                                break;
                            case "OVERDUE_LOANS":
                                result = db.PhieuMuons.Where(p => p.TrangThai_PhieuMuon == "Đang mượn" && p.HanTra_PhieuMuon < DateTime.Now)
                                    .Include(p => p.SACHDATA).Include(p => p.DOCGIADATA.NGUOIDUNGDATA)
                                    .ToList() // Client side calc
                                    .Select(p => new { Phieu = p.IDPhieuMuon, Sach = p.SACHDATA.Name_Sach, DG = p.DOCGIADATA.NGUOIDUNGDATA.HoTen_NguoiDung, Han = p.HanTra_PhieuMuon, Tre = (DateTime.Now - p.HanTra_PhieuMuon).Days, Phat = (DateTime.Now - p.HanTra_PhieuMuon).Days * 5000 }).ToList();
                                break;
                            case "TOP_READERS":
                                result = db.PhieuMuons.GroupBy(p => p.DOCGIADATA.NGUOIDUNGDATA.HoTen_NguoiDung)
                                    .Select(g => new { DocGia = g.Key, SoLan = g.Count() }).OrderByDescending(x => x.SoLan).Take(10).ToList();
                                break;
                            case "REVENUE_FINES":
                                var list = db.Phats.Where(p => p.DaThanhToan && p.NgayPhat >= from && p.NgayPhat <= to)
                                    .Select(p => new RevenueDTO { MaPhat = p.IDPhat, SoTien = p.SoTien_Phat, NgayPhat = p.NgayPhat, LyDo = p.LyDo_Phat }).ToList();
                                totalRev = list.Sum(x => x.SoTien);
                                result = list;
                                break;
                            case "STATS_GENRE":
                                result = db.Sachs.GroupBy(s => s.TheLoai_Sach).Select(g => new { TheLoai = g.Key, SoLuong = g.Count() }).ToList();
                                break;
                            case "STATS_AUTHOR":
                                result = db.Sachs.GroupBy(s => s.TacGia_Sach).Select(g => new { TacGia = g.Key, SoLuong = g.Count() }).OrderByDescending(x => x.SoLuong).Take(20).ToList();
                                break;
                        }
                    }
                });

                dgvKetQua.DataSource = result;
                if (type == "REVENUE_FINES") lblTongTien.Text = $"Tổng: {totalRev:N0} VNĐ";

                // Vẽ biểu đồ chi tiết (Basic mapping)
                DrawDetailChart(type, result);
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            finally { btnThongKe.Enabled = true; btnThongKe.Text = "XEM BÁO CÁO"; }
        }

        private void DrawDetailChart(string type, object data)
        {
            chartThongKe.Series.Clear();
            chartThongKe.Series.Add("Data");
            chartThongKe.Series[0].IsValueShownAsLabel = true;

            var list = data as IEnumerable<dynamic>;
            if (list == null) return;

            if (type == "STATS_GENRE" || type == "STATS_AUTHOR" || type == "TOP_READERS")
            {
                chartThongKe.Series[0].ChartType = SeriesChartType.Bar;
                foreach (var item in list)
                {
                    // Reflection dynamic properties
                    string label = "";
                    double val = 0;
                    if (type == "STATS_GENRE") { label = item.TheLoai; val = item.SoLuong; }
                    else if (type == "STATS_AUTHOR") { label = item.TacGia; val = item.SoLuong; }
                    else { label = item.DocGia; val = item.SoLan; }

                    chartThongKe.Series[0].Points.AddXY(label, val);
                }
            }
            else if (type == "REVENUE_FINES")
            {
                chartThongKe.Series[0].ChartType = SeriesChartType.Column;
                var revList = data as List<RevenueDTO>;
                var grouped = revList.GroupBy(x => x.NgayPhat.Date).Select(g => new { D = g.Key, V = g.Sum(k => k.SoTien) }).OrderBy(x => x.D);
                foreach (var item in grouped) chartThongKe.Series[0].Points.AddXY(item.D.ToString("dd/MM"), item.V);
            }
        }

        // === CHỨC NĂNG XUẤT EXCEL MỚI ===
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            // Gọi hàm helper để xuất file
            ExcelHelper.ExportToExcel(dgvKetQua, "Báo cáo thống kê");
        }
    }
}