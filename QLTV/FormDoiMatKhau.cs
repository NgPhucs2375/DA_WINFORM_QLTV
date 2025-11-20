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
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_DangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_DangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtXacNhanMK_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            string email = txtEmail_DangNhap.Text.Trim();
            string currentPass = txtMatKhau_DangNhap.Text.Trim();
            string newPass = txtMKMoi.Text.Trim();
            string confirmPass = txtMKMoi.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(currentPass) ||
                string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new QLTVDataContext())
            {
                var user = db.NguoiDungs.FirstOrDefault(u => u.Email_NguoiDung == email);
                if (user == null)
                {
                    MessageBox.Show("Email không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Mã hóa Base64 mật khẩu hiện tại nhập vào để so sánh
                string currentPassBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(currentPass));
                if (currentPassBase64 != user.MatKhau_NguoiDung)
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Mã hóa Base64 mật khẩu mới để lưu
                string newPassBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(newPass));
                user.MatKhau_NguoiDung = newPassBase64;

                db.SaveChanges();

                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                FormDangNhap f = new FormDangNhap();
                f.Show();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
