using QLTV.Database;
using QLTV.Database.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        //Hàm check email bằng regex      // Hàm check Tên người dùng chỉ chứa chữ cái và khoảng trắng
        private bool CheckName(string name)
        {
            if (string.IsNullOrEmpty(name)) return false;
            string pattern = @"^[a-zA-Z\s]+$";
            return Regex.IsMatch(name, pattern);
        }

        //Hàm check mật khẩu mạnh phải chứa ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường, số 
        private bool CheckPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$"; // Mật khẩu mạnh
            return Regex.IsMatch(password, pattern);
        }
        private bool CheckEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return false;

            string pattern = @"^((?!\.)[\w\-_.]*[^.])(@\w+)(\.\w+(\.\w+)?[^.\W])$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);

        }


        private void btnAccesLogin_Click(object sender, EventArgs e)
        {
            string name = txtTenDangNhap.Text.Trim();
            string email = txtEmail_DangNhap.Text.Trim();
            string pass = txtMatKhau_DangNhap.Text.Trim();
            if (string.IsNullOrEmpty(name)|| string.IsNullOrEmpty(email)||string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if (!CheckName(name))
            {
                MessageBox.Show("Tên không hợp lệ! ");
                return;
            }
            if (!CheckEmail(email))
            {
                MessageBox.Show("Email không hợp lệ!");
                return;
            }
            if (!CheckPassword(pass))
            {
                MessageBox.Show("Mật khẩu không hợp lệ! Mật khẩu phải chứa ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường và số.");
                return;
            }

            using (var db = new QLTVDataContext())
            {
                var user = db.NguoiDungs.FirstOrDefault(u => u.Email_NguoiDung == email);

                if (user == null) {
                    MessageBox.Show("Email chưa đăng ký !");
                    return;
                }


                string passInput = txtMatKhau_DangNhap.Text.Trim(); // mật khẩu người dùng nhập

                // Mã hóa Base64 mật khẩu nhập
                string passInputBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(passInput));

                // So sánh với mật khẩu trong DB (đã là Base64)
                if (passInputBase64 != user.MatKhau_NguoiDung?.Trim())
                {
                    MessageBox.Show("Mật khẩu không đúng!");
                    return;
                }
                Program.CurrentUserId = user.IDNguoiDung;
                MessageBox.Show($"Đăng nhập thành công! Vai trò: {user.VaiTro_NguoiDung}");

                // Mở form chính, có thể truyền vai trò
                string role = user.VaiTro_NguoiDung?.Trim().ToLower();

                if (role == "nhanvien" || role == "admin")
                {
                    this.Hide();
                    MainMenu mainmenu = new MainMenu(role);
                    mainmenu.Show();
                }
                else if (role == "docgia")
                {
                    this.Hide();
                    FormDG formDG = new FormDG();
                    formDG.Show();
                }
                

            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
