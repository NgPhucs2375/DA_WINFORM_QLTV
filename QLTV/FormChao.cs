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

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Tăng giá trị progress bar
            progressBar1.Increment(2);

            // Cập nhật text
            lblLoading.Text = $"Đang khởi động hệ thống... {progressBar1.Value}%";

            // Nếu chạy xong
            if (progressBar1.Value >= 100)
            {
                timer1.Stop();
                this.Hide();

                // Mở Form1 (Form chào mừng cũ của bạn)
                Form1 f = new Form1();
                f.Closed += (s, args) => this.Close(); // Khi Form1 tắt thì tắt luôn app
                f.Show();
            }
        }
    }
}