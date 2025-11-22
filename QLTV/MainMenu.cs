using QLTV.Database.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLTV
{
    public partial class MainMenu : Form
    {
        public string userRole;

        // Constructor mặc định (tránh lỗi khi gọi new MainMenu() không tham số)
        public MainMenu() : this("guest") { }

        public MainMenu(string role)
        {
            InitializeComponent();
            userRole = role?.ToLower() ?? "guest";

            SetupMDI();      // Cấu hình nền MDI
            SetUpMenuRole(); // Phân quyền
        }

        // --- CẤU HÌNH MDI ĐỂ HIỆN ẢNH NỀN ---
        private void SetupMDI()
        {
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

            // Hack: Tìm control MdiClient và gán ảnh nền cho nó
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient)
                {
                    ctl.BackColor = Color.White; // Màu nền dự phòng
                    try
                    {
                        // Gán ảnh từ Resource của bạn
                        ctl.BackgroundImage = global::QLTV.Properties.Resources.bookstorebg2;
                        ctl.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    catch { } // Bỏ qua nếu không tìm thấy ảnh
                    break;
                }
            }
        }

        // --- PHÂN QUYỀN ---
        public void SetUpMenuRole()
        {
            bool isAdmin = (userRole == "admin");
            // Ẩn/Hiện nút Quản lý nhân viên trên Sidebar
            if (btnQLNhanVien != null) btnQLNhanVien.Visible = isAdmin;

            // Hiển thị thông tin người dùng trên Header
            lblUserInfo.Text = $"Xin chào: {userRole.ToUpper()}";
        }

        // --- HÀM MỞ FORM CON (Singleton) ---
        private void OpenChildForm(Type formType)
        {
            // 1. Nếu form đã mở -> Activate nó
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formType)
                {
                    f.Activate();
                    return;
                }
            }

            // 2. Nếu chưa -> Tạo mới
            Form form = (Form)Activator.CreateInstance(formType);
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        // --- SỰ KIỆN CLICK SIDEBAR ---
        private void btnQLSach_Click(object sender, EventArgs e) => OpenChildForm(typeof(QuanLySach));

        private void btnQLDocGia_Click(object sender, EventArgs e) => OpenChildForm(typeof(QuanLyDG));

        private void btnQLMuonTra_Click(object sender, EventArgs e) => OpenChildForm(typeof(QLMuonTra));

        private void btnBaoCao_Click(object sender, EventArgs e) => OpenChildForm(typeof(BaoCao_ThongKe));

        private void btnQLNhanVien_Click(object sender, EventArgs e) => OpenChildForm(typeof(QuanLyNV));

        // --- SỰ KIỆN TÀI KHOẢN ---
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau f = new FormDoiMatKhau();
            f.ShowDialog(); // Hiện dạng Dialog đè lên MainMenu
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Program.CurrentUserId = 0;
                this.Hide();
                new FormDangNhap().Show();
            }
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.ExitThread();
                }
            }
        }
    }
}