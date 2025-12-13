namespace QLTV
{
    partial class FormChao
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            // --- PALETTE MÀU (EARTH TONE LUXURY) ---
            System.Drawing.Color colorRice = System.Drawing.Color.FromArgb(248, 245, 242);     // Nền sáng
            System.Drawing.Color colorDeepEarth = System.Drawing.Color.FromArgb(61, 52, 50);   // Sidebar tối
            System.Drawing.Color colorClay = System.Drawing.Color.FromArgb(141, 110, 99);      // Accent (Thanh loading)
            System.Drawing.Color colorTextGray = System.Drawing.Color.FromArgb(117, 117, 117); // Chữ phụ

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblLogoIcon = new System.Windows.Forms.Label();
            this.lblAppVersion = new System.Windows.Forms.Label();
            this.pnlProgressTrack = new System.Windows.Forms.Panel(); // Thay thế ProgressBar
            this.pnlProgressBar = new System.Windows.Forms.Panel();   // Thanh chạy tuỳ chỉnh
            this.lblQuote = new System.Windows.Forms.Label(); // Thêm câu danh ngôn để tăng giá trị tri thức

            this.pnlLeft.SuspendLayout();
            this.pnlProgressTrack.SuspendLayout();
            this.SuspendLayout();

            // 
            // 1. Sidebar Trái (Màu Đất Đậm - Tạo chiều sâu)
            // 
            this.pnlLeft.BackColor = colorDeepEarth;
            this.pnlLeft.Controls.Add(this.lblLogoIcon);
            this.pnlLeft.Controls.Add(this.lblAppVersion);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Size = new System.Drawing.Size(250, 400); // Tỷ lệ ~1/3
            
            // Logo Icon: Dùng chữ cái cách điệu thay vì hình ảnh pixel vỡ
            this.lblLogoIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogoIcon.Font = new System.Drawing.Font("Segoe UI Light", 72F); // Font siêu lớn, mảnh
            this.lblLogoIcon.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200); // Màu bạc
            this.lblLogoIcon.Text = "Lb"; // Viết tắt Library
            this.lblLogoIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogoIcon.Size = new System.Drawing.Size(250, 250);

            // Version: Nhỏ, tinh tế ở góc dưới trái
            this.lblAppVersion.AutoSize = true;
            this.lblAppVersion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAppVersion.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblAppVersion.Location = new System.Drawing.Point(20, 360);
            this.lblAppVersion.Text = "v2.0 Professional";

            // 
            // 2. Nội dung chính (Bên phải - Nền Gạo)
            // 
            // Title: Font to, đậm nhưng màu xám đen sang trọng (không dùng đen tuyền)
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40); 
            this.lblTitle.Location = new System.Drawing.Point(290, 80);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "QUẢN LÝ THƯ VIỆN";

            // Subtitle: Mô tả ngắn gọn
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSubtitle.ForeColor = colorClay; // Màu nâu đất tạo điểm nhấn
            this.lblSubtitle.Location = new System.Drawing.Point(295, 130);
            this.lblSubtitle.Text = "Hệ thống quản lý tri thức toàn diện";

            // Quote: Thêm giá trị cảm xúc (Emotional Design)
            this.lblQuote.AutoSize = false;
            this.lblQuote.Size = new System.Drawing.Size(400, 60);
            this.lblQuote.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblQuote.ForeColor = colorTextGray;
            this.lblQuote.Location = new System.Drawing.Point(295, 180);
            this.lblQuote.Text = "\"Một cuốn sách thực sự hay nên đọc trong tuổi trẻ, rồi đọc lại khi đã trưởng thành.\"";
            
            // Loading Text
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoading.ForeColor = System.Drawing.Color.Gray;
            this.lblLoading.Location = new System.Drawing.Point(295, 320);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Text = "Đang khởi tạo dữ liệu...";

            // 
            // 3. Custom Progress Bar (Phẳng & Mỏng)
            // 
            // Track (Đường ray nền)
            this.pnlProgressTrack.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.pnlProgressTrack.Controls.Add(this.pnlProgressBar); // Panel con nằm trong panel cha
            this.pnlProgressTrack.Location = new System.Drawing.Point(300, 350);
            this.pnlProgressTrack.Size = new System.Drawing.Size(400, 4); // Siêu mỏng (Ultra-thin)
            this.pnlProgressTrack.Name = "pnlProgressTrack";

            // Bar (Thanh chạy thực tế)
            this.pnlProgressBar.BackColor = colorClay; // Màu chủ đạo
            this.pnlProgressBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProgressBar.Size = new System.Drawing.Size(0, 4); // Bắt đầu từ 0
            this.pnlProgressBar.Name = "pnlProgressBar"; // Tên để gọi trong code logic

            // Timer
            this.timer1.Enabled = true;
            this.timer1.Interval = 30; // Mượt hơn
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // 
            // Form Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = colorRice; // Nền tổng thể
            this.ClientSize = new System.Drawing.Size(750, 400); // Kích thước chữ nhật vàng
            this.Controls.Add(this.pnlProgressTrack);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.lblQuote);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; // Không viền
            this.Name = "FormChao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChao";
            
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlProgressTrack.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblLogoIcon;
        private System.Windows.Forms.Label lblAppVersion;
        private System.Windows.Forms.Label lblQuote;
        
        // Custom Progress Bar components
        public System.Windows.Forms.Panel pnlProgressTrack; 
        public System.Windows.Forms.Panel pnlProgressBar; // Public để truy cập từ code logic
    }
}