using QLTV.Database;
using QLTV.Database.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity; // Cần thiết cho .Include()
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices; // Cần thiết để giải phóng Excel
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

// Alias để ngắn gọn hơn khi gọi Excel
using Excel = Microsoft.Office.Interop.Excel;

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
            this.StartPosition = FormStartPosition.CenterScreen;

            // Cấu hình DateTimePicker: Mặc định là đầu tháng và cuối tháng hiện tại
            dtpTuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDenNgay.Value = dtpTuNgay.Value.AddMonths(1).AddDays(-1);
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Format = DateTimePickerFormat.Short;

            // Cấu hình Label tổng tiền
            lblTongTien.Text = "Tổng doanh thu: 0 VNĐ";
            lblTongTien.Font = new Font("Arial", 12, FontStyle.Bold);
            lblTongTien.ForeColor = Color.DarkRed;
            lblTongTien.Visible = false; // Chỉ hiện khi chọn báo cáo doanh thu

            ConfigDataGridView();
            LoadComboBoxData();
        }

        private void ConfigDataGridView()
        {
            dgvKetQua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKetQua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKetQua.ReadOnly = true;
            dgvKetQua.AllowUserToAddRows = false;
            dgvKetQua.BackgroundColor = SystemColors.ControlLight;

            // Tối ưu hiệu năng vẽ (Double Buffered)
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.SetProperty,
                null, dgvKetQua, new object[] { true });
        }

        private void LoadComboBoxData()
        {
            Dictionary<string, string> reports = new Dictionary<string, string>()
            {
                { "BOOKS_AVAILABLE", "1. Sách đang có sẵn trong kho" },
                { "BOOKS_BORROWED", "2. Sách đang được mượn (Chưa trả)" },
                { "OVERDUE_LOANS", "3. Danh sách quá hạn & Tiền phạt dự kiến" },
                { "TOP_READERS", "4. Top 10 Độc giả tích cực nhất" },
                { "REVENUE_FINES", "5. Doanh thu tiền phạt (Theo ngày)" }
            };

            cboLoaiThongKe.DataSource = new BindingSource(reports, null);
            cboLoaiThongKe.DisplayMember = "Value";
            cboLoaiThongKe.ValueMember = "Key";
            cboLoaiThongKe.SelectedIndex = 0;
        }

        // Sự kiện khi thay đổi loại báo cáo
        private void cboLoaiThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Chỉ hiện chọn ngày khi báo cáo là Doanh thu
            bool isRevenue = cboLoaiThongKe.SelectedValue?.ToString() == "REVENUE_FINES";
            dtpTuNgay.Enabled = isRevenue;
            dtpDenNgay.Enabled = isRevenue;
            lblTongTien.Visible = isRevenue;

            // Reset Grid khi đổi loại báo cáo
            dgvKetQua.DataSource = null;
            lblTongTien.Text = "";
            lalThongKe.Text = "Kết quả: ...";
        }

        // Sự kiện Click nút Thống Kê
        private async void btnThongKe_Click(object sender, EventArgs e)
        {
            if (cboLoaiThongKe.SelectedValue == null) return;

            string type = cboLoaiThongKe.SelectedValue.ToString();

            // Lấy ngày từ UI (cho báo cáo doanh thu)
            DateTime fromDate = dtpTuNgay.Value.Date; // 00:00:00
            DateTime toDate = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1); // 23:59:59

            btnThongKe.Enabled = false;
            btnThongKe.Text = "Đang tải...";

            try
            {
                object resultData = null;
                decimal totalRevenue = 0;

                // Chạy Query ở Background Thread để không đơ máy
                await Task.Run(() =>
                {
                    using (var db = new QLTVDataContext())
                    {
                        db.Configuration.LazyLoadingEnabled = false;

                        switch (type)
                        {
                            case "BOOKS_AVAILABLE":
                                resultData = GetBooksAvailable(db);
                                break;
                            case "BOOKS_BORROWED":
                                resultData = GetBooksBorrowed(db);
                                break;
                            case "OVERDUE_LOANS":
                                resultData = GetOverdueLoans(db);
                                break;
                            case "TOP_READERS":
                                resultData = GetTopReaders(db);
                                break;
                            case "REVENUE_FINES":
                                var revenueData = GetRevenueFines(db, fromDate, toDate);
                                resultData = revenueData;
                                // Tính tổng tiền ngay trong luồng phụ
                                totalRevenue = revenueData.Sum(x => x.SoTien);
                                break;
                        }
                    }
                });

                // Binding dữ liệu (Quay về UI Thread)
                if (resultData != null)
                {
                    dgvKetQua.DataSource = resultData;
                    lalThongKe.Text = $"Tìm thấy: {dgvKetQua.Rows.Count} bản ghi.";
                    FormatGridColumns(type); // Format tiền tệ và ngày tháng

                    if (type == "REVENUE_FINES")
                    {
                        lblTongTien.Text = $"Tổng doanh thu: {totalRevenue:N0} VNĐ";
                        lblTongTien.Visible = true;
                    }
                    DrawChart(type, resultData);
                }
                else
                {
                    dgvKetQua.DataSource = null;
                    lalThongKe.Text = "Không có dữ liệu.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnThongKe.Enabled = true;
                btnThongKe.Text = "Thống kê";
            }
        }

        // --- HÀM FORMAT GIAO DIỆN ---
        private void FormatGridColumns(string type)
        {
            // Format cột Tiền
            if (dgvKetQua.Columns["SoTien"] != null)
            {
                dgvKetQua.Columns["SoTien"].DefaultCellStyle.Format = "N0"; // Định dạng số 100,000
                dgvKetQua.Columns["SoTien"].HeaderText = "Số tiền (VNĐ)";
                dgvKetQua.Columns["SoTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            // Format các cột Ngày tháng
            foreach (DataGridViewColumn col in dgvKetQua.Columns)
            {
                if (col.Name.Contains("Ngay") || col.Name.Contains("Han"))
                {
                    col.DefaultCellStyle.Format = "dd/MM/yyyy";
                }
            }
        }

        // --- CÁC HÀM TRUY VẤN LINQ ---

        private object GetBooksAvailable(QLTVDataContext db)
        {
            return db.Sachs
                .Where(s => s.SoLuong_Sach > 0 && s.TrangThai_Sach != "Ngưng hoạt động")
                .Select(s => new {
                    ID = s.IDSach,
                    TenSach = s.Name_Sach,
                    TacGia = s.TacGia_Sach,
                    TheLoai = s.TheLoai_Sach,
                    TonKho = s.SoLuong_Sach,
                    ViTri = s.ViTriSach
                }).ToList();
        }

        private object GetBooksBorrowed(QLTVDataContext db)
        {
            return db.PhieuMuons
                .Include(pm => pm.DOCGIADATA.NGUOIDUNGDATA)
                .Include(pm => pm.SACHDATA)
                .Where(pm => pm.TrangThai_PhieuMuon == "Đang mượn")
                .Select(pm => new {
                    MaPhieu = pm.IDPhieuMuon,
                    DocGia = pm.DOCGIADATA.NGUOIDUNGDATA.HoTen_NguoiDung,
                    TenSach = pm.SACHDATA.Name_Sach,
                    NgayMuon = pm.NgayMuon_Sach,
                    HanTra = pm.HanTra_PhieuMuon
                }).ToList();
        }

        private object GetOverdueLoans(QLTVDataContext db)
        {
            var today = DateTime.Now;
            return db.PhieuMuons
                .Include(pm => pm.DOCGIADATA.NGUOIDUNGDATA)
                .Where(pm => pm.TrangThai_PhieuMuon == "Đang mượn" && pm.HanTra_PhieuMuon < today)
                .ToList() // Chuyển về List Client-side để dùng hàm tính ngày của C#
                .Select(pm => new {
                    MaPhieu = pm.IDPhieuMuon,
                    DocGia = pm.DOCGIADATA.NGUOIDUNGDATA.HoTen_NguoiDung,
                    SDT = pm.DOCGIADATA.NGUOIDUNGDATA.SDT_NguoiDung,
                    HanTra = pm.HanTra_PhieuMuon,
                    SoNgayQua = (today - pm.HanTra_PhieuMuon).Days,
                    TienPhatDuKien = (today - pm.HanTra_PhieuMuon).Days * 5000 // Giả sử phạt 5k/ngày
                }).ToList();
        }

        private object GetTopReaders(QLTVDataContext db)
        {
            return db.PhieuMuons
                .GroupBy(pm => new { pm.DOCGIADATA.IDDocGia, pm.DOCGIADATA.NGUOIDUNGDATA.HoTen_NguoiDung })
                .Select(g => new {
                    MaDG = g.Key.IDDocGia,
                    HoTen = g.Key.HoTen_NguoiDung,
                    SoLanMuon = g.Count()
                })
                .OrderByDescending(x => x.SoLanMuon)
                .Take(10)
                .ToList();
        }

        private List<RevenueDTO> GetRevenueFines(QLTVDataContext db, DateTime from, DateTime to)
        {
            return db.Phats
                .Include(p => p.PHIEUMUONDATA.DOCGIADATA.NGUOIDUNGDATA)
                .Where(p => p.DaThanhToan == true && p.NgayPhat >= from && p.NgayPhat <= to)
                .Select(p => new RevenueDTO
                {
                    MaPhat = p.IDPhat,
                    DocGia = p.PHIEUMUONDATA.DOCGIADATA.NGUOIDUNGDATA.HoTen_NguoiDung,
                    LyDo = p.LyDo_Phat,
                    NgayPhat = p.NgayPhat,
                    SoTien = p.SoTien_Phat
                })
                .ToList();
        }

        // --- SỰ KIỆN XUẤT EXCEL ---
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvKetQua.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo");
                return;
            }

            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                excelApp = new Excel.Application();
                workbook = excelApp.Workbooks.Add(Type.Missing);
                worksheet = (Excel.Worksheet)workbook.Sheets[1];
                worksheet.Name = "ThongKe";

                // 1. Xuất tiêu đề cột
                for (int i = 1; i < dgvKetQua.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvKetQua.Columns[i - 1].HeaderText;
                    // Format tiêu đề
                    Excel.Range cell = worksheet.Cells[1, i];
                    cell.Font.Bold = true;
                    cell.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
                }

                // 2. Xuất dữ liệu
                for (int i = 0; i < dgvKetQua.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvKetQua.Columns.Count; j++)
                    {
                        var value = dgvKetQua.Rows[i].Cells[j].Value;
                        // Thêm dấu ' đằng trước để Excel hiểu là text, tránh lỗi format ngày tháng
                        if (value is DateTime)
                        {
                            worksheet.Cells[i + 2, j + 1] = ((DateTime)value).ToString("dd/MM/yyyy");
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = value != null ? value.ToString() : "";
                        }
                    }
                }

                // 3. Auto fit cột
                worksheet.Columns.AutoFit();

                // 4. Hiển thị Excel
                excelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Excel: " + ex.Message);
            }
            finally
            {
                // BẮT BUỘC: Giải phóng tài nguyên COM để tránh Excel chạy ngầm
                if (worksheet != null) Marshal.ReleaseComObject(worksheet);
                if (workbook != null) Marshal.ReleaseComObject(workbook);
                if (excelApp != null) Marshal.ReleaseComObject(excelApp);

                worksheet = null;
                workbook = null;
                excelApp = null;

                GC.Collect(); // Dọn dẹp rác bộ nhớ ngay lập tức
            }
        }

        private void DrawChart(string type, object dataSource)
        {
            // 1. Reset biểu đồ cũ
            chartThongKe.Series.Clear();
            chartThongKe.Titles.Clear();

            // 2. Cấu hình tiêu đề
            string titleText = cboLoaiThongKe.Text;
            chartThongKe.Titles.Add(titleText);
            chartThongKe.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);

            // 3. Xử lý vẽ theo từng loại báo cáo
            if (type == "REVENUE_FINES") // Biểu đồ Cột: Doanh thu
            {
                var list = dataSource as List<RevenueDTO>;
                if (list == null || list.Count == 0) return;

                // Gom nhóm theo ngày để vẽ (Ví dụ: Ngày 20 thu được 100k, Ngày 21 thu được 200k)
                var chartData = list.GroupBy(x => x.NgayPhat.Date)
                                    .Select(g => new { Ngay = g.Key, TongTien = g.Sum(x => x.SoTien) })
                                    .OrderBy(x => x.Ngay)
                                    .ToList();

                Series series = new Series("Doanh Thu");
                series.ChartType = SeriesChartType.Column; // Loại biểu đồ cột
                series.IsValueShownAsLabel = true; // Hiện số tiền trên đầu cột

                foreach (var item in chartData)
                {
                    series.Points.AddXY(item.Ngay.ToString("dd/MM"), item.TongTien);
                }
                chartThongKe.Series.Add(series);
            }
            else if (type == "TOP_READERS") // Biểu đồ Tròn: Top độc giả
            {
                // Bạn cần sửa lại hàm GetTopReaders trả về List class cụ thể thay vì anonymous object để cast được ở đây
                // Đây là ví dụ giả định logic
                Series series = new Series("TopDocGia");
                series.ChartType = SeriesChartType.Pie;
                // ... logic add points tương tự
                chartThongKe.Series.Add(series);
            }

            // Tắt lưới cho đẹp
            chartThongKe.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartThongKe.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

    }



    // Class DTO để hứng dữ liệu Doanh thu
    public class RevenueDTO
    {
        public int MaPhat { get; set; }
        public string DocGia { get; set; }
        public string LyDo { get; set; }
        public DateTime NgayPhat { get; set; }
        public decimal SoTien { get; set; }
    }
}

