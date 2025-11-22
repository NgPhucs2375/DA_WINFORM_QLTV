using QLTV.Database;
using QLTV.Database.Entities;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Security.Cryptography; // Thêm thư viện để mã hóa mật khẩu chuẩn

namespace QLTV
{
    public partial class FormDangKy : Form
    {
        // Mã bí mật để tạo tài khoản Admin/Nhân viên (Trong thực tế nên lưu ở config server)
        private const string SECRET_ADMIN_KEY = "ADMIN123";
        private const string SECRET_STAFF_KEY = "STAFF123";

        public FormDangKy()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            // Ẩn mật khẩu
            txtMatKhau_DangKy.UseSystemPasswordChar = true;
            txtNhaplaiMatKhau_DangKy.UseSystemPasswordChar = true;

            // Init ComboBox
            cboVaiTro.Items.Clear();
            cboVaiTro.Items.Add("Độc giả");   // Index 0
            cboVaiTro.Items.Add("Nhân viên"); // Index 1
            cboVaiTro.Items.Add("Admin");     // Index 2
            cboVaiTro.SelectedIndex = 0;      // Mặc định là Độc giả

            // Ẩn mã cấp quyền mặc định
            lalMaCapQuyen.Visible = false;
            txtMaCapQuyen_DangKy.Visible = false;
        }

        // --- CÁC HÀM VALIDATION ---
        private bool CheckEmail(string email)
        {
            return !string.IsNullOrEmpty(email) &&
                   Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        }

        private bool CheckSDT(string sdt)
        {
            return !string.IsNullOrEmpty(sdt) && Regex.IsMatch(sdt, @"^\d{10,11}$");
        }

        private bool CheckPassword(string password)
        {
            // Ít nhất 6 ký tự cho dễ test (Bạn có thể tăng lên 8)
            return !string.IsNullOrEmpty(password) && password.Length >= 6;
        }

        // --- XỬ LÝ SỰ KIỆN ---

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string name = txtNameNguoiDung_DangKy.Text.Trim();
            string email = txtEmail_DangKy.Text.Trim();
            string sdt = txtSDT_DangKy.Text.Trim();
            string pass = txtMatKhau_DangKy.Text;
            string rePass = txtNhaplaiMatKhau_DangKy.Text;
            string roleSelect = cboVaiTro.SelectedItem.ToString();
            string roleDB = "DocGia"; // Giá trị lưu DB

            // 1. Validation cơ bản
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CheckEmail(email))
            {
                MessageBox.Show("Email không hợp lệ!", "Cảnh báo");
                return;
            }

            if (!CheckSDT(sdt))
            {
                MessageBox.Show("Số điện thoại phải là 10-11 số!", "Cảnh báo");
                return;
            }

            if (!CheckPassword(pass))
            {
                MessageBox.Show("Mật khẩu quá ngắn (tối thiểu 6 ký tự)!", "Cảnh báo");
                return;
            }

            if (pass != rePass)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Cảnh báo");
                return;
            }

            // 2. Kiểm tra Mã cấp quyền (Nếu đăng ký Admin/Nhân viên)
            if (roleSelect == "Admin")
            {
                if (txtMaCapQuyen_DangKy.Text != SECRET_ADMIN_KEY)
                {
                    MessageBox.Show("Mã cấp quyền Admin không đúng!", "Lỗi bảo mật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                roleDB = "admin";
            }
            else if (roleSelect == "Nhân viên")
            {
                if (txtMaCapQuyen_DangKy.Text != SECRET_STAFF_KEY)
                {
                    MessageBox.Show("Mã cấp quyền Nhân viên không đúng!", "Lỗi bảo mật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                roleDB = "nhanvien";
            }

            // 3. Lưu vào Database
            try
            {
                using (var db = new QLTVDataContext())
                {
                    if (db.NguoiDungs.Any(u => u.Email_NguoiDung == email))
                    {
                        MessageBox.Show("Email này đã được sử dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Tạo User
                    NguoiDung user = new NguoiDung()
                    {
                        HoTen_NguoiDung = name,
                        Email_NguoiDung = email,
                        SDT_NguoiDung = sdt,
                        // Nên dùng MD5 hoặc SHA256 thay vì Base64 đơn giản
                        MatKhau_NguoiDung = CalculateMD5Hash(pass),
                        VaiTro_NguoiDung = roleDB,
                        TrangThai_NguoiDung = "Active",
                        NgayTao_NguoiDung = DateTime.Now
                    };

                    db.NguoiDungs.Add(user);
                    db.SaveChanges(); // Save lần 1 để lấy ID

                    // Nếu là Độc giả -> Tạo thêm record trong bảng DocGia
                    if (roleDB == "DocGia")
                    {
                        DocGia dg = new DocGia()
                        {
                            IDNguoiDung_DocGia = user.IDNguoiDung,
                            TinhTrangThe = "Active",
                            NgayCap = DateTime.Now,
                            NgayHetHan = DateTime.Now.AddYears(1)
                        };
                        db.DocGias.Add(dg);
                    }
                    // Nếu là Nhân viên -> Tạo thêm record trong bảng NhanVien
                    else if (roleDB == "nhanvien" || roleDB == "admin")
                    {
                        NhanVien nv = new NhanVien()
                        {
                            IDNguoiDung_NhanVien = user.IDNguoiDung,
                            ChucVu = roleSelect,
                            NgayVaoLam = DateTime.Now
                        };
                        db.NhanViens.Add(nv);
                    }

                    db.SaveChanges(); // Save lần 2
                    MessageBox.Show("Đăng ký thành công! Vui lòng đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Đóng form đăng ký -> Form1 sẽ tự hiện lên
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Chỉ cần đóng form này, Form1 sẽ tự hiện (do sự kiện FormClosed bên Form1)
            this.Close();
        }

        // Xử lý ẩn hiện ô Mã cấp quyền
        private void cboVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = cboVaiTro.SelectedItem?.ToString();
            bool isAdminOrStaff = (selectedRole == "Admin" || selectedRole == "Nhân viên");

            lalMaCapQuyen.Visible = isAdminOrStaff;
            txtMaCapQuyen_DangKy.Visible = isAdminOrStaff;

            if (!isAdminOrStaff) txtMaCapQuyen_DangKy.Clear();
        }

        // Hàm mã hóa MD5 (đơn giản)
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

        // Các event thừa (có thể xóa hoặc để trống)
        private void FormDangKy_Load(object sender, EventArgs e) { }
        private void grbDangKy_Enter(object sender, EventArgs e) { }
    }
}