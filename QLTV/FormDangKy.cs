﻿using QLTV.Database;
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
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
            this.Load += FormDangKy_Load; // theem event load cho form
        }

        //Hàm check email bằng regex
        private bool CheckEmail(string email)
        {
            if(string.IsNullOrEmpty(email)) return false;

            string pattern = @"^((?!\.)[\w\-_.]*[^.])(@\w+)(\.\w+(\.\w+)?[^.\W])$";
            return Regex.IsMatch(email, pattern,RegexOptions.IgnoreCase);

        }

        // Hàm check Tên người dùng chỉ chứa chữ cái và khoảng trắng
        private bool CheckName(string name)
        {
            if (string.IsNullOrEmpty(name)) return false;
            string pattern = @"^[a-zA-Z\s]+$"; 
            return Regex.IsMatch(name, pattern);
        }

        //Hàm  check SĐT chỉ chứa số và có độ dài từ 10 ký tự
        private bool CheckSDT(string sdt)
        {
            if (string.IsNullOrEmpty(sdt)) return false;
            string pattern = @"^\d{10,}$"; // Chỉ chứa số và có độ dài từ 10 ký tự trở lên
            return Regex.IsMatch(sdt, pattern);
        }

        //Hàm check mật khẩu mạnh phải chứa ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường, số 
        private bool CheckPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$"; // Mật khẩu mạnh
            return Regex.IsMatch(password, pattern);
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string name = txtNameNguoiDung_DangKy.Text.Trim();
            string email = txtEmail_DangKy.Text.Trim();
            string sdt = txtSDT_DangKy.Text.Trim();
            string password = txtMatKhau_DangKy.Text.Trim();
            string repassword = txtNhaplaiMatKhau_DangKy.Text.Trim();
            string vaitro = cboVaiTro.SelectedItem.ToString();
            if (!CheckName(name))
            {
                MessageBox.Show("Tên không hợp lệ! Chỉ được phép chữ cái và khoảng trắng.");
                return;
            }

            if(!CheckSDT(sdt))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập lại.");
                return;
            }
            if (!CheckPassword(password))
            {
                MessageBox.Show("Mật khẩu không hợp lệ! Mật khẩu phải chứa ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường và số.");
                return;
            }

            if (password != repassword)
            {
                MessageBox.Show("Mật khẩu không khớp vui lòng nhập lại mật khẩu!");
                return;
            }

            if (vaitro == "Thủ Thư")
            {
                string capquyen = txtMaCapQuyen_DangKy.Text.Trim();
                const string MA_CAP_QUYEN = "ABC123";
                if (capquyen!=MA_CAP_QUYEN)
                {
                    MessageBox.Show("Mã cấp quyền không hợp lệ!");
                    return;
                }
            }

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(password)) 
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin người dùng!");
                return;
            }

            if (!CheckEmail(email))
            {
                MessageBox.Show("Email không hợp lệ vui lòng nhập lại !");
                return;
            }



            using (var db = new QLTVDataContext())
            {
                if (db.NguoiDungs.Any(u=>u.Email_NguoiDung == email)) 
                {
                    MessageBox.Show("Email đã tồn tại! ");
                    return;
                }
                NguoiDung user = new NguoiDung()
                {
                    HoTen_NguoiDung = txtNameNguoiDung_DangKy.Text.Trim(),
                    Email_NguoiDung = email,
                    SDT_NguoiDung = txtSDT_DangKy.Text.Trim(),
                    MatKhau_NguoiDung = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(txtMatKhau_DangKy.Text)),
                    VaiTro_NguoiDung = vaitro,
                    NgayTao_NguoiDung = DateTime.Now

                };
                db.NguoiDungs.Add(user);
                db.SaveChanges();
            }
            txtNameNguoiDung_DangKy.Clear();
            txtEmail_DangKy.Clear();
            txtSDT_DangKy.Clear();
            txtMatKhau_DangKy.Clear();
            txtNhaplaiMatKhau_DangKy.Clear();
            cboVaiTro.SelectedIndex = 0;
            txtMaCapQuyen_DangKy.Clear();

            MessageBox.Show("Đăng ký thành công!");
        }

        private void cboVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVaiTro.SelectedItem.ToString() == "Thủ Thư")
            {
                // Cap lai quyen kha dung cho Cap quyen nesu chon Dung Thu thu
                lalMaCapQuyen.Visible = true;
                txtMaCapQuyen_DangKy.Visible = true;
            }
            else
            {
                lalMaCapQuyen.Visible=false;
                txtMaCapQuyen_DangKy.Visible=false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide(); // ẩn form đăng ký
            Form1 main = new Form1();
            main.Show();
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {
            // Thêm các vai trò vào ComboBox
            cboVaiTro.Items.Clear(); // xóa trước nếu có dữ liệu cũ
            cboVaiTro.Items.Add("Độc Giả"); 
            cboVaiTro.Items.Add("Thủ Thư");

            // Mặc định chọn vai trò đầu tiên
            cboVaiTro.SelectedIndex = 0; // chon Độc Giả làm mặc định

        }
    }
}
