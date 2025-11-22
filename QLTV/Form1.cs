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
            SetupUI(); // Gọi hàm trang trí giao diện
        }

        // Hàm trang trí giao diện (Code thuần, không cần sửa Designer)
        private void SetupUI()
        {
            // Căn giữa màn hình
            this.StartPosition = FormStartPosition.CenterScreen;

            // Trang trí nút Đăng ký
            StyleButton(btnDangKy, Color.White, Color.SeaGreen); // Chữ xanh, nền trắng

            // Trang trí nút Đăng nhập
            StyleButton(btnDangNhap, Color.SeaGreen, Color.White); // Nền xanh, chữ trắng
        }

        // Hàm phụ trợ để làm đẹp nút bấm
        private void StyleButton(Button btn, Color backColor, Color foreColor)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.SeaGreen;
            btn.BackColor = backColor;
            btn.ForeColor = foreColor;
            btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // 1. Ẩn form hiện tại
            this.Hide();

            // 2. Tạo form đăng ký
            FormDangKy f = new FormDangKy();

            // 3. QUAN TRỌNG: Đăng ký sự kiện FormClosed
            // Khi FormDangKy đóng lại (dù là Đăng ký xong hay bấm X), Form1 sẽ hiện lại
            f.FormClosed += (s, args) => this.Show();

            // 4. Hiển thị form
            f.ShowDialog();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap f = new FormDangNhap();

            // Logic đặc biệt cho Đăng nhập:
            // Nếu đăng nhập thành công -> Vào MainMenu -> Form1 vẫn ẩn (hoặc đóng).
            // Nếu người dùng bấm Hủy/Đóng form đăng nhập -> Form1 hiện lại.

            f.ShowDialog();

            // Kiểm tra biến static UserId (nếu bạn có dùng như bài trước) hoặc check trạng thái form
            // Nếu form Đăng nhập đóng mà chưa vào được MainMenu (User chưa login), ta hiện lại Form1
            if (Program.CurrentUserId == 0)
            {
                this.Show();
            }
            else
            {
                // Nếu đã đăng nhập thành công và vào MainMenu rồi, ta ẩn luôn Form1
                // MainMenu sẽ chịu trách nhiệm đóng ứng dụng
            }
        }
    }
}