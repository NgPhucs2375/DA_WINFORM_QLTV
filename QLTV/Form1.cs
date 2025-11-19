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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnDangKy_Click(object sender, EventArgs e)
        {

            this.Hide(); // ẩn Form1
            FormDangKy f = new FormDangKy(); // tạo đối tượng FormDangKy
            f.ShowDialog(); // hiển thị form đăng ký
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide(); // ẩn Form chính
            FormDangNhap f = new FormDangNhap(); // tạo form đăng nhập
            f.ShowDialog(); // hiển thị form đăng nhập dưới dạng hộp thoại
        }

        
    }
}
