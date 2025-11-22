using QLTV.Database;
using QLTV.Database.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace QLTV
{
    public partial class QuanLyNV : Form
    {
        public QuanLyNV()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            // Init ComboBox
            cboVaiTro.Items.Clear();
            cboVaiTro.Items.Add("Quản lý (Admin)");
            cboVaiTro.Items.Add("Nhân viên (Thủ thư)");
            cboVaiTro.SelectedIndex = 1; // Mặc định là nhân viên

            // Style DataGridView
            dgvNhanVien.BorderStyle = BorderStyle.None;
            dgvNhanVien.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 250); // Lavender
            dgvNhanVien.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNhanVien.DefaultCellStyle.SelectionBackColor = Color.Indigo;
            dgvNhanVien.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.Indigo;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void QuanLyTG_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Hàm mã hóa MD5 (Đồng bộ với FormDangNhap/DangKy)
        private string CalculateMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private void LoadData()
        {
            using (var db = new QLTVDataContext())
            {
                var list = from nv in db.NhanViens
                           join nd in db.NguoiDungs on nv.IDNguoiDung_NhanVien equals nd.IDNguoiDung
                           select new
                           {
                               MaNV = nv.IDNhanVien,
                               HoTen = nd.HoTen_NguoiDung,
                               Email = nd.Email_NguoiDung,
                               SDT = nd.SDT_NguoiDung,
                               ChucVu = nv.ChucVu,
                               NgayVaoLam = nv.NgayVaoLam,
                               TrangThai = nd.TrangThai_NguoiDung
                           };
                dgvNhanVien.DataSource = list.ToList();
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
            txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
            txtTenNV.Text = row.Cells["HoTen"].Value.ToString();
            txtEmailNV.Text = row.Cells["Email"].Value.ToString();
            txtSDTNV.Text = row.Cells["SDT"].Value.ToString();

            string chucVu = row.Cells["ChucVu"].Value.ToString();
            if (chucVu.Contains("Admin") || chucVu.ToLower() == "admin") cboVaiTro.SelectedIndex = 0;
            else cboVaiTro.SelectedIndex = 1;

            if (row.Cells["NgayVaoLam"].Value != null)
                dtpkNgayVLNV.Value = Convert.ToDateTime(row.Cells["NgayVaoLam"].Value);

            // Không load mật khẩu lên textbox để bảo mật, và vì nó đã bị Hash
            txtMatKhauNV.PlaceholderText = "(Giữ nguyên)";
            txtMatKhauNV.Clear();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNV.Text) || string.IsNullOrWhiteSpace(txtEmailNV.Text) || string.IsNullOrWhiteSpace(txtMatKhauNV.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Cảnh báo");
                return;
            }

            try
            {
                using (var db = new QLTVDataContext())
                {
                    if (db.NguoiDungs.Any(u => u.Email_NguoiDung == txtEmailNV.Text.Trim()))
                    {
                        MessageBox.Show("Email này đã tồn tại!", "Lỗi");
                        return;
                    }

                    string roleDB = (cboVaiTro.SelectedIndex == 0) ? "admin" : "nhanvien";

                    // 1. Tạo User
                    NguoiDung nd = new NguoiDung
                    {
                        HoTen_NguoiDung = txtTenNV.Text.Trim(),
                        Email_NguoiDung = txtEmailNV.Text.Trim(),
                        SDT_NguoiDung = txtSDTNV.Text.Trim(),
                        MatKhau_NguoiDung = CalculateMD5Hash(txtMatKhauNV.Text), // Mã hóa MD5
                        VaiTro_NguoiDung = roleDB,
                        TrangThai_NguoiDung = "Active",
                        NgayTao_NguoiDung = DateTime.Now
                    };
                    db.NguoiDungs.Add(nd);
                    db.SaveChanges();

                    // 2. Tạo Nhân viên
                    NhanVien nv = new NhanVien
                    {
                        IDNguoiDung_NhanVien = nd.IDNguoiDung,
                        ChucVu = cboVaiTro.Text,
                        NgayVaoLam = dtpkNgayVLNV.Value
                    };
                    db.NhanViens.Add(nv);
                    db.SaveChanges();

                    MessageBox.Show("Thêm nhân viên thành công!");
                    LoadData();
                    ClearForm();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text)) return;
            int id = int.Parse(txtMaNV.Text);

            try
            {
                using (var db = new QLTVDataContext())
                {
                    var nv = db.NhanViens.FirstOrDefault(x => x.IDNhanVien == id);
                    if (nv == null) return;

                    var nd = db.NguoiDungs.FirstOrDefault(u => u.IDNguoiDung == nv.IDNguoiDung_NhanVien);

                    // Chặn sửa chính mình (tránh mất quyền Admin)
                    if (nd.IDNguoiDung == Program.CurrentUserId && cboVaiTro.SelectedIndex == 1) // Đang là admin mà tự hạ xuống nhân viên
                    {
                        MessageBox.Show("Bạn không thể tự hạ quyền của chính mình!", "Cảnh báo");
                        return;
                    }

                    nd.HoTen_NguoiDung = txtTenNV.Text.Trim();
                    nd.Email_NguoiDung = txtEmailNV.Text.Trim();
                    nd.SDT_NguoiDung = txtSDTNV.Text.Trim();

                    // Chỉ cập nhật mật khẩu nếu ô nhập không trống
                    if (!string.IsNullOrWhiteSpace(txtMatKhauNV.Text))
                    {
                        nd.MatKhau_NguoiDung = CalculateMD5Hash(txtMatKhauNV.Text);
                    }

                    string roleDB = (cboVaiTro.SelectedIndex == 0) ? "admin" : "nhanvien";
                    nd.VaiTro_NguoiDung = roleDB;
                    nv.ChucVu = cboVaiTro.Text;
                    nv.NgayVaoLam = dtpkNgayVLNV.Value;

                    db.SaveChanges();
                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text)) return;
            int id = int.Parse(txtMaNV.Text);

            try
            {
                using (var db = new QLTVDataContext())
                {
                    var nv = db.NhanViens.FirstOrDefault(x => x.IDNhanVien == id);
                    if (nv == null) return;
                    var nd = db.NguoiDungs.FirstOrDefault(u => u.IDNguoiDung == nv.IDNguoiDung_NhanVien);

                    if (nd.IDNguoiDung == Program.CurrentUserId)
                    {
                        MessageBox.Show("Không thể tự xóa chính mình!", "Cảnh báo");
                        return;
                    }

                    if (MessageBox.Show($"Xóa nhân viên {nd.HoTen_NguoiDung}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        db.NhanViens.Remove(nv);
                        db.NguoiDungs.Remove(nd);
                        db.SaveChanges();
                        LoadData();
                        ClearForm();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Không thể xóa nhân viên này (có thể do ràng buộc dữ liệu)."); }
        }

        private void btnReset_Click(object sender, EventArgs e) => ClearForm();

        private void ClearForm()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtEmailNV.Clear();
            txtSDTNV.Clear();
            txtMatKhauNV.Clear();
            cboVaiTro.SelectedIndex = 1;
            dtpkNgayVLNV.Value = DateTime.Now;
            txtMatKhauNV.PlaceholderText = "";
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            string key = txtKeyword.Text.ToLower();
            using (var db = new QLTVDataContext())
            {
                var list = from nv in db.NhanViens
                           join nd in db.NguoiDungs on nv.IDNguoiDung_NhanVien equals nd.IDNguoiDung
                           where nd.HoTen_NguoiDung.ToLower().Contains(key) || nd.Email_NguoiDung.Contains(key)
                           select new
                           {
                               MaNV = nv.IDNhanVien,
                               HoTen = nd.HoTen_NguoiDung,
                               Email = nd.Email_NguoiDung,
                               SDT = nd.SDT_NguoiDung,
                               ChucVu = nv.ChucVu,
                               NgayVaoLam = nv.NgayVaoLam,
                               TrangThai = nd.TrangThai_NguoiDung
                           };
                dgvNhanVien.DataSource = list.ToList();
            }
        }

        // Các sự kiện click thừa
        private void btnHTDanhSach_Click(object sender, EventArgs e) => LoadData();
        private void btnSearchingNV_Click(object sender, EventArgs e) { }
        private void radMaNV_CheckedChanged(object sender, EventArgs e) { }
        private void radTenNV_CheckedChanged(object sender, EventArgs e) { }
        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void cboVaiTro_SelectedIndexChanged(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
    }
}