using QLTV.Database.Entities;
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
    public partial class MainMenu : Form
    {
        public string userRole;

        public MainMenu(string role)
        {
            InitializeComponent();
            userRole = role.ToLower();
            SetUpMenuRole();
        }
        public void SetUpMenuRole()
        {
            if(userRole == "admin")
            {
                btnQLNhanVienMN.Visible = true;
            }else if(userRole == "nhanvien")
            {
                btnQLNhanVienMN.Visible = false;

            }
            else
            {
                btnQLNhanVienMN.Visible = false;
            }
        }

        private void btnQLSachMN_Click(object sender, EventArgs e)
        {
            QuanLySach f = new QuanLySach();
            f.Show();
        }

        private void btnQLDGMN_Click(object sender, EventArgs e)
        {
            QuanLyDG f = new QuanLyDG();
            f.Show();
        }

        private void btnQLMuonTraMN_Click(object sender, EventArgs e)
        {
            QLMuonTra f = new QLMuonTra();
            f.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnQLNhanVienMN_Click(object sender, EventArgs e)
        {
            QuanLyNV f = new QuanLyNV();
            f.Show();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau f = new FormDoiMatKhau();
            f.Show();
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var logout = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (logout == DialogResult.Yes)
            {
                Program.CurrentUserId = 0;
                this.Close();
                FormDangNhap loginForm = new FormDangNhap();
                loginForm.Show();

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
