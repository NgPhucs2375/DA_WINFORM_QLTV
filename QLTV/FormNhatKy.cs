using QLTV.Database;
using System;
using System.Data;
using System.Data.Entity; // Cần cho Include, TruncateTime
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLTV
{
    public partial class FormNhatKy : Form
    {
        public FormNhatKy()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            dtpNgay.Value = DateTime.Now; // Mặc định xem hôm nay
        }

        private void FormNhatKy_Load(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void LoadLogs()
        {
            try
            {
                using (var db = new QLTVDataContext())
                {
                    DateTime selectedDate = dtpNgay.Value.Date;

                    // Truy vấn khớp với tên biến trong Entity của bạn
                    var list = db.HoatDongLogs
                        .Include(l => l.NGUOIDUNGDATA5) // Include bảng người dùng
                        .Where(l => DbFunctions.TruncateTime(l.ThoiGian_DHG) == selectedDate)
                        .OrderByDescending(l => l.ThoiGian_DHG) // Mới nhất lên đầu
                        .Select(l => new
                        {
                            ThoiGian = l.ThoiGian_DHG,
                            NguoiThucHien = l.NGUOIDUNGDATA5 != null ? l.NGUOIDUNGDATA5.HoTen_NguoiDung : "Hệ thống",
                            HanhDong = l.HangDong_DHG,
                            DoiTuong = l.DoiTuong,
                            ChiTiet = l.NoiDung_DHG
                        })
                        .ToList();

                    dgvLogs.DataSource = list;

                    // Đặt tên cột tiếng Việt cho dễ đọc
                    if (dgvLogs.Columns["ThoiGian"] != null)
                    {
                        dgvLogs.Columns["ThoiGian"].HeaderText = "Thời gian";
                        dgvLogs.Columns["ThoiGian"].DefaultCellStyle.Format = "HH:mm:ss dd/MM/yyyy";
                        dgvLogs.Columns["ThoiGian"].Width = 180;
                    }
                    if (dgvLogs.Columns["NguoiThucHien"] != null) dgvLogs.Columns["NguoiThucHien"].HeaderText = "Người thực hiện";
                    if (dgvLogs.Columns["HanhDong"] != null) dgvLogs.Columns["HanhDong"].HeaderText = "Hành động";
                    if (dgvLogs.Columns["DoiTuong"] != null) dgvLogs.Columns["DoiTuong"].HeaderText = "Đối tượng";
                    if (dgvLogs.Columns["ChiTiet"] != null) dgvLogs.Columns["ChiTiet"].HeaderText = "Chi tiết nội dung";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải nhật ký: " + ex.Message);
            }
        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadLogs();
        }
    }
}