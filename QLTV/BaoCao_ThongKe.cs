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
            dtpTuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDenNgay.Value = DateTime.Now;
            lblTongTien.Visible = false;

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

            LoadDashboardAsync();
        }

        // ================== DASHBOARD ==================
        private async void LoadDashboardAsync()
        {
            try
            {
                using (var db = new QLTVDataContext())
                {
                    lblCard1Value.Text = (await db.Sachs.SumAsync(s => (int?)s.SoLuong_Sach) ?? 0).ToString("N0");
                    lblCard2Value.Text = (await db.PhieuMuons.CountAsync(p => p.TrangThai_PhieuMuon == "Đang mượn")).ToString("N0");
                    lblCard3Value.Text = (await db.PhieuMuons.CountAsync(p =>
                        p.TrangThai_PhieuMuon == "Đang mượn" && p.HanTra_PhieuMuon < DateTime.Now)).ToString("N0");

                    var startMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    lblCard4Value.Text = (await db.Phats
                        .Where(p => p.DaThanhToan && p.NgayPhat >= startMonth)
                        .SumAsync(p => (decimal?)p.SoTien_Phat) ?? 0).ToString("N0");

                    var yearData = await db.PhieuMuons
                        .Where(p => p.NgayMuon_Sach.Year == DateTime.Now.Year)
                        .GroupBy(p => p.NgayMuon_Sach.Month)
                        .Select(g => new { Thang = g.Key, SoLuong = g.Count() })
                        .ToListAsync();

                    chartTrend.Series[0].Points.Clear();
                    for (int i = 1; i <= 12; i++)
                    {
                        var d = yearData.FirstOrDefault(x => x.Thang == i);
                        chartTrend.Series[0].Points.AddXY("T" + i, d?.SoLuong ?? 0);
                    }

                    var genreData = db.Sachs
                        .GroupBy(s => s.TheLoai_Sach)
                        .Select(g => new { g.Key, Count = g.Count() })
                        .OrderByDescending(x => x.Count)
                        .Take(5)
                        .ToList();

                    chartPieCategory.Series[0].Points.Clear();
                    foreach (var g in genreData)
                        chartPieCategory.Series[0].Points.AddXY(g.Key, g.Count);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Dashboard: " + ex.Message);
            }
        }

        private void cboLoaiThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cboLoaiThongKe.SelectedValue?.ToString();
            bool hasDate = (type == "REVENUE_FINES" || type == "TREND_YEAR");

            dtpTuNgay.Enabled = hasDate;
            dtpDenNgay.Enabled = hasDate;
            lblTongTien.Visible = (type == "REVENUE_FINES");

            dgvKetQua.DataSource = null;
            chartThongKe.Series.Clear();
        }

        private async void btnThongKe_Click(object sender, EventArgs e)
        {
            string type = cboLoaiThongKe.SelectedValue.ToString();
            DateTime from = dtpTuNgay.Value.Date;
            DateTime to = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);

            btnThongKe.Enabled = false;
            btnThongKe.Text = "Đang tải...";

            try
            {
                object result = null;
                decimal totalRev = 0;

                await Task.Run(() =>
                {
                    using (var db = new QLTVDataContext())
                    {
                        switch (type)
                        {
                            case "BOOKS_AVAILABLE":
                                result = db.Sachs.Where(s => s.SoLuong_Sach > 0)
                                    .Select(s => new { Ten = s.Name_Sach, SL = s.SoLuong_Sach })
                                    .ToList();
                                break;

                            case "BOOKS_BORROWED":
                                result = db.PhieuMuons.Where(p => p.TrangThai_PhieuMuon == "Đang mượn")
                                    .Select(p => new { Sach = p.SACHDATA.Name_Sach })
                                    .ToList();
                                break;

                            case "OVERDUE_LOANS":
                                result = db.PhieuMuons
                                    .Where(p => p.TrangThai_PhieuMuon == "Đang mượn" && p.HanTra_PhieuMuon < DateTime.Now)
                                    .ToList()
                                    .Select(p => new
                                    {
                                        Tre = (DateTime.Now - p.HanTra_PhieuMuon).Days
                                    }).ToList();
                                break;

                            case "TOP_READERS":
                                result = db.PhieuMuons
                                    .GroupBy(p => p.DOCGIADATA.NGUOIDUNGDATA.HoTen_NguoiDung)
                                    .Select(g => new { DocGia = g.Key, SoLan = g.Count() })
                                    .OrderByDescending(x => x.SoLan)
                                    .Take(10)
                                    .ToList();
                                break;

                            case "REVENUE_FINES":
                                var list = db.Phats
                                    .Where(p => p.DaThanhToan && p.NgayPhat >= from && p.NgayPhat <= to)
                                    .Select(p => new RevenueDTO
                                    {
                                        SoTien = p.SoTien_Phat,
                                        NgayPhat = p.NgayPhat
                                    }).ToList();
                                totalRev = list.Sum(x => x.SoTien);
                                result = list;
                                break;

                            case "TREND_YEAR": // ✅ FIX QUAN TRỌNG
                                result = db.PhieuMuons
                                    .Where(p => p.NgayMuon_Sach.Year == DateTime.Now.Year)
                                    .GroupBy(p => p.NgayMuon_Sach.Month)
                                    .Select(g => new { Thang = g.Key, SoLuong = g.Count() })
                                    .OrderBy(x => x.Thang)
                                    .ToList();
                                break;

                            case "STATS_GENRE":
                                result = db.Sachs.GroupBy(s => s.TheLoai_Sach)
                                    .Select(g => new { TheLoai = g.Key, SoLuong = g.Count() })
                                    .ToList();
                                break;

                            case "STATS_AUTHOR":
                                result = db.Sachs.GroupBy(s => s.TacGia_Sach)
                                    .Select(g => new { TacGia = g.Key, SoLuong = g.Count() })
                                    .OrderByDescending(x => x.SoLuong)
                                    .Take(10)
                                    .ToList();
                                break;
                        }
                    }
                });

                dgvKetQua.DataSource = result;
                if (type == "REVENUE_FINES")
                    lblTongTien.Text = $"Tổng: {totalRev:N0} VNĐ";

                DrawDetailChart(type, result);
            }
            finally
            {
                btnThongKe.Enabled = true;
                btnThongKe.Text = "XEM BÁO CÁO";
            }
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab == tabDashboard)
            {
                LoadDashboardAsync();
            }
        }

        private void DrawDetailChart(string type, object data)
        {
            chartThongKe.Series.Clear();
            chartThongKe.Titles.Clear();

            var list = (data as IEnumerable<dynamic>)?.ToList();
            if (list == null || list.Count == 0) return;

            var series = new Series("Data");
            series.ChartArea = "ChartArea1"; // 🔥 FIX QUAN TRỌNG
            series.IsValueShownAsLabel = true;
            series.Points.Clear();

            chartThongKe.Series.Add(series);

            switch (type)
            {
                case "BOOKS_AVAILABLE":
                    series.ChartType = SeriesChartType.Pie;
                    foreach (var x in list.Take(10))
                        series.Points.AddXY(x.Ten, x.SL);
                    chartThongKe.Titles.Add("Top 10 sách trong kho");
                    break;

                case "BOOKS_BORROWED":
                    series.ChartType = SeriesChartType.Column;
                    foreach (var g in list.GroupBy(x => x.Sach))
                        series.Points.AddXY(g.Key, g.Count());
                    break;

                case "OVERDUE_LOANS":
                    series.ChartType = SeriesChartType.Column;
                    foreach (var g in list.GroupBy(x => x.Tre))
                        series.Points.AddXY(g.Key + " ngày", g.Count());
                    break;

                case "TOP_READERS":
                    series.ChartType = SeriesChartType.Bar;
                    foreach (var x in list)
                        series.Points.AddXY(x.DocGia, x.SoLan);
                    break;

                case "REVENUE_FINES":
                    series.ChartType = SeriesChartType.Column;
                    foreach (var g in list.GroupBy(x => x.NgayPhat.Date))
                        series.Points.AddXY(g.Key.ToString("dd/MM"), g.Sum(x => x.SoTien));
                    break;

                case "TREND_YEAR":
                    series.ChartType = SeriesChartType.Line;
                    for (int i = 1; i <= 12; i++)
                    {
                        var item = list.FirstOrDefault(x => x.Thang == i);
                        series.Points.AddXY("T" + i, item?.SoLuong ?? 0);
                    }
                    chartThongKe.Titles.Add("Xu hướng mượn sách theo tháng");
                    break;

                case "STATS_GENRE":
                    series.ChartType = SeriesChartType.Pie;
                    foreach (var x in list)
                        series.Points.AddXY(x.TheLoai, x.SoLuong);
                    break;

                case "STATS_AUTHOR":
                    series.ChartType = SeriesChartType.Bar;
                    foreach (var x in list.Take(10))
                        series.Points.AddXY(x.TacGia, x.SoLuong);
                    break;
            }

            if (series.ChartType == SeriesChartType.Pie)
            {
                series["PieLabelStyle"] = "Outside";
                series["PieLineColor"] = "Black";
            }

            chartThongKe.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartThongKe.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }


        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ExcelHelper.ExportToExcel(dgvKetQua, "Báo cáo thống kê");
        }
    }
}
