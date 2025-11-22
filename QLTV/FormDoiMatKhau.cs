using QLTV.Database;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace QLTV
{
    public partial class FormDoiMatKhau : Form
    {
        private int _currentUserId;

        public FormDoiMatKhau()
        {
            InitializeComponent();
            _currentUserId = Program.CurrentUserId; // Lấy ID người dùng đang đăng nhập
            SetupUI();
            LoadUserInfo();
        }

        private void SetupUI()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            txtMatKhauHienTai.UseSystemPasswordChar = true;
            txtMatKhauMoi.UseSystemPasswordChar = true;
            txtXacNhanMK.UseSystemPasswordChar = true;
        }

        private void LoadUserInfo()
        {
            // Nếu chưa đăng nhập (Test mode) thì thôi
            if (_currentUserId == 0) return;

            using (var db = new QLTVDataContext())
            {
                var user = db.NguoiDungs.FirstOrDefault(u => u.IDNguoiDung == _currentUserId);
                if (user != null)
                {
                    txtEmail.Text = user.Email_NguoiDung;
                    txtHoTen.Text = user.HoTen_NguoiDung;
                }
            }
        }

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

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            string oldPass = txtMatKhauHienTai.Text;
            string newPass = txtMatKhauMoi.Text;
            string confirmPass = txtXacNhanMK.Text;

            // 1. Validate input
            if (string.IsNullOrEmpty(oldPass) || string.IsNullOrEmpty(newPass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 6 ký tự!", "Cảnh báo");
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Xử lý DB
            try
            {
                using (var db = new QLTVDataContext())
                {
                    var user = db.NguoiDungs.FirstOrDefault(u => u.IDNguoiDung == _currentUserId);

                    if (user == null)
                    {
                        MessageBox.Show("Không tìm thấy thông tin người dùng!", "Lỗi");
                        return;
                    }

                    // Kiểm tra mật khẩu cũ (MD5)
                    string oldPassHash = CalculateMD5Hash(oldPass);
                    if (oldPassHash != user.MatKhau_NguoiDung)
                    {
                        MessageBox.Show("Mật khẩu hiện tại không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Cập nhật mật khẩu mới (MD5)
                    user.MatKhau_NguoiDung = CalculateMD5Hash(newPass);
                    db.SaveChanges();

                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}