using QLTV.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class QuanLyNV : Form
    {
        public QuanLyNV()
        {
            InitializeComponent();
        }

        private void btnHTDanhSach_Click(object sender, EventArgs e)
        {
            using (var db = new QLTVDataContext())
            {
                var listNV = from nv in db.NhanViens
                             join nd in db.NguoiDungs
                          on nv.IDNguoiDung_NhanVien equals nd.IDNguoiDung
                             select new
                             {
                                 MaNhanVien = nv.IDNhanVien,
                                 HoTen = nd.HoTen_NguoiDung,
                                 Email = nd.Email_NguoiDung,
                                 MatKhau = nd.MatKhau_NguoiDung,
                                 SDT = nd.SDT_NguoiDung,
                                 ChucVu = nv.ChucVu,
                                 NgayVaoLam = nv.NgayVaoLam,
                                 VaiTro = nd.VaiTro_NguoiDung,
                                 TrangThai = nd.TrangThai_NguoiDung
                             };

                dgvNhanVien.DataSource = listNV.ToList();

                // Thiết lập lại tiêu đề cột (header text)
                dgvNhanVien.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
                dgvNhanVien.Columns["HoTen"].HeaderText = "Họ tên";
                dgvNhanVien.Columns["Email"].HeaderText = "Email";
                dgvNhanVien.Columns["MatKhau"].HeaderText = "Mật khẩu";
                dgvNhanVien.Columns["SDT"].HeaderText = "Số điện thoại";
                dgvNhanVien.Columns["ChucVu"].HeaderText = "Chức vụ";
                dgvNhanVien.Columns["NgayVaoLam"].HeaderText = "Ngày vào làm";
                dgvNhanVien.Columns["VaiTro"].HeaderText = "Vai trò";
                dgvNhanVien.Columns["TrangThai"].HeaderText = "Trạng thái";

                // Tự động co dãn cột cho đẹp hơn
                dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void QuanLyTG_Load(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
