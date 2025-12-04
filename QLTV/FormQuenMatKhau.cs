using QLTV.Database;
using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace QLTV
{
    public partial class FormQuenMatKhau : Form
    {
        public FormQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(email)) { MessageBox.Show("Vui lòng nhập Email!"); return; }

            btnGui.Enabled = false;
            btnGui.Text = "Đang xử lý...";
            lblStatus.Text = "";

            try
            {
                using (var db = new QLTVDataContext())
                {
                    var user = db.NguoiDungs.FirstOrDefault(u => u.Email_NguoiDung == email);
                    if (user == null)
                    {
                        MessageBox.Show("Email này chưa được đăng ký trong hệ thống!");
                        btnGui.Enabled = true; btnGui.Text = "GỬI MẬT KHẨU MỚI";
                        return;
                    }

                    // 1. Tạo mật khẩu mới ngẫu nhiên (6 ký tự)
                    string newPass = Guid.NewGuid().ToString().Substring(0, 6).ToUpper();

                    // 2. Gửi Email
                    SendEmail(email, newPass);

                    // 3. Cập nhật vào DB (Mã hóa MD5)
                    user.MatKhau_NguoiDung = CalculateMD5Hash(newPass);
                    db.SaveChanges();

                    MessageBox.Show("Mật khẩu mới đã được gửi vào Email của bạn. Vui lòng kiểm tra hộp thư (cả mục Spam).", "Thành công");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi mail: " + ex.Message);
                btnGui.Enabled = true; btnGui.Text = "GỬI MẬT KHẨU MỚI";
            }
        }

        private void SendEmail(string toEmail, string newPass)
        {
            // CẤU HÌNH EMAIL GỬI (Bạn phải thay đổi cái này bằng mail thật của bạn)
            string fromEmail = "your_email@gmail.com";
            string password = "your_app_password"; // Mật khẩu ứng dụng (Không phải mật khẩu đăng nhập)

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromEmail, password)
            };

            using (var message = new MailMessage(fromEmail, toEmail)
            {
                Subject = "[QLTV] Khôi phục mật khẩu",
                Body = $"Chào bạn,\n\nMật khẩu mới của bạn là: {newPass}\n\nVui lòng đăng nhập và đổi lại mật khẩu ngay.\n\nTrân trọng,\nAdmin Thư Viện."
            })
            {
                smtp.Send(message);
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
                    sb.Append(hashBytes[i].ToString("X2"));
                return sb.ToString();
            }
        }
    }
}