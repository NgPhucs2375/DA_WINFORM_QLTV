using System;
using System.Windows.Forms;

namespace QLTV
{
    public partial class FormChao : Form
    {
        public FormChao()
        {
            InitializeComponent();
        }

        // Sự kiện Timer chạy mỗi đợt (Interval)
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Logic tăng độ dài thanh panel con (pnlProgressBar) 
            // để giả lập hiệu ứng loading chạy trên thanh ray (pnlProgressTrack)

            if (pnlProgressBar.Width < pnlProgressTrack.Width)
            {
                // Mỗi lần tick tăng thêm 10 đơn vị độ rộng (tăng tốc độ lên chút cho mượt)
                pnlProgressBar.Width += 10;

                // Tính phần trăm để hiện ra label
                // Ép kiểu double để chia ra số thập phân, sau đó nhân 100
                int percent = (int)(((double)pnlProgressBar.Width / pnlProgressTrack.Width) * 100);

                // Giới hạn max là 100% để không bị lố số
                if (percent > 100) percent = 100;

                lblLoading.Text = $"Đang khởi tạo dữ liệu... {percent}%";
            }
            else
            {
                // Khi chạy xong
                timer1.Stop();

                // --- SỬA LẠI ĐÚNG YÊU CẦU CỦA BẠN ---
                Form1 frm = new Form1();
                frm.Show(); // Hiện Form1

                this.Hide(); // Ẩn Form Chào đi
            }
        }
    }
}