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
        public MainMenu() : this("guest") // Nếu không truyền gì, mặc định là "guest"
        {
        }
        public MainMenu(string role)
        {
            InitializeComponent();
            userRole = role?.ToLower() ?? "guest"; // Xử lý null an toàn
            SetUpMenuRole();

            // Cấu hình MDI
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

            // --- BẮT ĐẦU THÊM: Xử lý ảnh nền MDI ---
            // Tìm control MdiClient (lớp màu xám) và gán ảnh cho nó
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient)
                {
                    // 1. Gán ảnh từ Resource (giống như bạn đã set ở Designer)
                    ctl.BackgroundImage = global::QLTV.Properties.Resources.bookstorebg;

                    // 2. Chỉnh chế độ hiển thị (Stretch: Co giãn toàn màn hình)
                    ctl.BackgroundImageLayout = ImageLayout.Stretch;

                    // 3. (Nâng cao) Đổi màu nền mặc định nếu ảnh bị lỗi (tùy chọn)
                    ctl.BackColor = Color.White;

                    break; // Tìm thấy rồi thì dừng vòng lặp
                }
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Có thể thêm code chào mừng hoặc hiển thị thông tin người dùng ở đây
        }

        public void SetUpMenuRole()
        {
            // Phân quyền đơn giản
            bool isAdmin = (userRole == "admin");

            // Chỉ Admin mới thấy nút quản lý nhân viên
            btnQLNhanVienMN.Visible = isAdmin;

            // Ví dụ: Nếu muốn khóa thêm nút Báo cáo cho nhân viên thường
            // báoCáoThôngKêToolStripMenuItem.Visible = isAdmin; 
        }

        // --- HÀM DÙNG CHUNG: Mở Form con (QUAN TRỌNG) ---
        // Hàm này giúp: 
        // 1. Không mở trùng form (Singleton)
        // 2. Gắn form con vào trong form cha (MDI)
        private void OpenChildForm(Type formType)
        {
            // 1. Kiểm tra xem Form này đã mở chưa
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formType)
                {
                    f.Activate(); // Nếu mở rồi thì focus vào nó
                    return;
                }
            }

            // 2. Nếu chưa mở thì tạo mới
            Form form = (Form)Activator.CreateInstance(formType);
            form.MdiParent = this; // Gắn vào Form cha MainMenu
            form.StartPosition = FormStartPosition.CenterScreen; // Căn giữa màn hình cha
            form.Show();
        }

        // --- CÁC SỰ KIỆN CLICK MENU ---

        private void btnQLSachMN_Click(object sender, EventArgs e)
        {
            OpenChildForm(typeof(QuanLySach));
        }

        private void btnQLDGMN_Click(object sender, EventArgs e)
        {
            OpenChildForm(typeof(QuanLyDG));
        }

        private void btnQLMuonTraMN_Click(object sender, EventArgs e)
        {
            OpenChildForm(typeof(QLMuonTra));
        }

        private void btnQLNhanVienMN_Click(object sender, EventArgs e)
        {
            OpenChildForm(typeof(QuanLyNV));
        }

        // Sự kiện click menu Báo Cáo (Bạn cần gán sự kiện này trong Design)
        private void báoCáoThôngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(typeof(BaoCao_ThongKe));
        }

        // --- QUẢN LÝ TÀI KHOẢN ---

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            // Form đổi mật khẩu nên hiện dạng Dialog (Cửa sổ con bắt buộc xử lý xong mới được làm việc khác)
            FormDoiMatKhau f = new FormDoiMatKhau();
            f.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var logout = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (logout == DialogResult.Yes)
            {
                Program.CurrentUserId = 0; // Reset ID người dùng

                // Ẩn form hiện tại đi thay vì đóng hẳn để tránh tắt app đột ngột
                this.Hide();

                FormDangNhap loginForm = new FormDangNhap();
                // Đăng ký sự kiện: Khi form đăng nhập đóng lại thì tắt luôn chương trình (nếu cần)
                loginForm.FormClosed += (s, args) => this.Close();
                loginForm.Show();
            }
        }

        // Sự kiện khi bấm nút X đỏ trên góc phải màn hình
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show("Bạn có muốn thoát hoàn toàn chương trình?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Hủy lệnh đóng
                }
                else
                {
                    Application.ExitThread(); // Thoát sạch luồng
                }
            }
            base.OnFormClosing(e);
        }
    }
}