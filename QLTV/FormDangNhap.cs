using QLTV.Database;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace QLTV
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.txtMatKhau_DangNhap.UseSystemPasswordChar = true; // Ẩn mật khẩu
        }

        // Hàm mã hóa MD5 (Phải giống hệt bên FormDangKy)
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

        private void btnAccesLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail_DangNhap.Text.Trim();
            string passRaw = txtMatKhau_DangNhap.Text;

            // 1. Validation
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(passRaw))
            {
                MessageBox.Show("Vui lòng nhập Email và Mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Xử lý đăng nhập
            try
            {
                using (var db = new QLTVDataContext())
                {
                    // Tìm user theo email
                    var user = db.NguoiDungs.FirstOrDefault(u => u.Email_NguoiDung == email);

                    if (user == null)
                    {
                        MessageBox.Show("Email này chưa được đăng ký!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Kiểm tra mật khẩu (So sánh Hash MD5)
                    string passHash = CalculateMD5Hash(passRaw);

                    // Lưu ý: Nếu dữ liệu cũ của bạn đang lưu Base64 thì code này sẽ báo sai mật khẩu.
                    // Bạn cần đăng ký tài khoản mới để test logic MD5 này.
                    if (passHash != user.MatKhau_NguoiDung)
                    {
                        MessageBox.Show("Mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 3. Đăng nhập thành công
                    Program.CurrentUserId = user.IDNguoiDung; // Lưu session
                    string role = user.VaiTro_NguoiDung?.Trim().ToLower();

                    // Mở form tương ứng
                    this.Hide(); // Ẩn form đăng nhập đi

                    if (role == "admin" || role == "nhanvien")
                    {
                        MainMenu main = new MainMenu(role);
                        main.FormClosed += (s, args) => Application.Exit(); // Đóng MainMenu là tắt app luôn
                        main.Show();
                    }
                    else // Độc giả
                    {
                        FormDG docGiaForm = new FormDG();
                        docGiaForm.FormClosed += (s, args) => Application.Exit();
                        docGiaForm.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            // Đóng form này -> Form1 sẽ tự hiện lại (do sự kiện FormClosed bên Form1)
            this.Close();
        }

        // Event thừa
        private void FormDangNhap_Load(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
    }
}