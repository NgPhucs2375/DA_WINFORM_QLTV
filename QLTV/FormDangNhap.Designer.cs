namespace QLTV
{
    partial class FormDangNhap
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
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.pnlLoginCard = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtEmail_DangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau_DangNhap = new System.Windows.Forms.TextBox();
            this.lalEmail = new System.Windows.Forms.Label();
            this.lalMatKhau = new System.Windows.Forms.Label();
            this.btnAccesLogin = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblQuote = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBackground.SuspendLayout();
            this.pnlLoginCard.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackgroundImage = global::QLTV.Properties.Resources.bookstorebg2;
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBackground.Controls.Add(this.pnlLoginCard);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1200, 750);
            this.pnlBackground.TabIndex = 0;
            // 
            // pnlLoginCard
            // 
            this.pnlLoginCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLoginCard.BackColor = System.Drawing.Color.White;
            this.pnlLoginCard.Controls.Add(this.pnlRight);
            this.pnlLoginCard.Controls.Add(this.pnlLeft);
            this.pnlLoginCard.Location = new System.Drawing.Point(200, 125);
            this.pnlLoginCard.Name = "pnlLoginCard";
            this.pnlLoginCard.Size = new System.Drawing.Size(800, 500);
            this.pnlLoginCard.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(237))))); // Cream Paper
            this.pnlRight.Controls.Add(this.lblHeader);
            this.pnlRight.Controls.Add(this.txtEmail_DangNhap);
            this.pnlRight.Controls.Add(this.txtMatKhau_DangNhap);
            this.pnlRight.Controls.Add(this.lalEmail);
            this.pnlRight.Controls.Add(this.lalMatKhau);
            this.pnlRight.Controls.Add(this.btnAccesLogin);
            this.pnlRight.Controls.Add(this.Exit);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlRight.Location = new System.Drawing.Point(320, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(40);
            this.pnlRight.Size = new System.Drawing.Size(480, 500);
            this.pnlRight.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Playfair Display", 24F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33))))); // Sienna
            this.lblHeader.Location = new System.Drawing.Point(40, 40);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(265, 57);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Đăng Nhập";
            // 
            // lalEmail
            // 
            this.lalEmail.AutoSize = true;
            this.lalEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lalEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lalEmail.Location = new System.Drawing.Point(45, 130);
            this.lalEmail.Name = "lalEmail";
            this.lalEmail.Size = new System.Drawing.Size(55, 23);
            this.lalEmail.TabIndex = 1;
            this.lalEmail.Text = "Email:";
            // 
            // txtEmail_DangNhap
            // 
            this.txtEmail_DangNhap.BackColor = System.Drawing.Color.White;
            this.txtEmail_DangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail_DangNhap.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail_DangNhap.Location = new System.Drawing.Point(45, 160);
            this.txtEmail_DangNhap.Name = "txtEmail_DangNhap";
            this.txtEmail_DangNhap.Size = new System.Drawing.Size(390, 32);
            this.txtEmail_DangNhap.TabIndex = 2;
            // 
            // lalMatKhau
            // 
            this.lalMatKhau.AutoSize = true;
            this.lalMatKhau.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lalMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lalMatKhau.Location = new System.Drawing.Point(45, 220);
            this.lalMatKhau.Name = "lalMatKhau";
            this.lalMatKhau.Size = new System.Drawing.Size(88, 23);
            this.lalMatKhau.TabIndex = 3;
            this.lalMatKhau.Text = "Mật khẩu:";
            // 
            // txtMatKhau_DangNhap
            // 
            this.txtMatKhau_DangNhap.BackColor = System.Drawing.Color.White;
            this.txtMatKhau_DangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau_DangNhap.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMatKhau_DangNhap.Location = new System.Drawing.Point(45, 250);
            this.txtMatKhau_DangNhap.Name = "txtMatKhau_DangNhap";
            this.txtMatKhau_DangNhap.Size = new System.Drawing.Size(390, 32);
            this.txtMatKhau_DangNhap.TabIndex = 4;
            this.txtMatKhau_DangNhap.UseSystemPasswordChar = true;
            // 
            // btnAccesLogin
            // 
            this.btnAccesLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(82)))), ((int)(((byte)(45))))); // Sienna
            this.btnAccesLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccesLogin.FlatAppearance.BorderSize = 0;
            this.btnAccesLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccesLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAccesLogin.ForeColor = System.Drawing.Color.White;
            this.btnAccesLogin.Location = new System.Drawing.Point(45, 340);
            this.btnAccesLogin.Name = "btnAccesLogin";
            this.btnAccesLogin.Size = new System.Drawing.Size(390, 50);
            this.btnAccesLogin.TabIndex = 5;
            this.btnAccesLogin.Text = "ĐĂNG NHẬP";
            this.btnAccesLogin.UseVisualStyleBackColor = false;
            this.btnAccesLogin.Click += new System.EventHandler(this.btnAccesLogin_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline);
            this.Exit.ForeColor = System.Drawing.Color.Gray;
            this.Exit.Location = new System.Drawing.Point(45, 410);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(390, 40);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Quay lại màn hình chính";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(69)))), ((int)(((byte)(19))))); // Dark Leather
            this.pnlLeft.Controls.Add(this.lblQuote);
            this.pnlLeft.Controls.Add(this.lblTitle);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(320, 500);
            this.pnlLeft.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Playfair Display", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 150);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(265, 66);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "WELCOME";
            // 
            // lblQuote
            // 
            this.lblQuote.AutoSize = true;
            this.lblQuote.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.lblQuote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblQuote.Location = new System.Drawing.Point(35, 230);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(235, 60);
            this.lblQuote.TabIndex = 1;
            this.lblQuote.Text = "Tiếp tục hành trình \r\nkhám phá tri thức.";
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.pnlBackground.ResumeLayout(false);
            this.pnlLoginCard.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel pnlLoginCard;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtEmail_DangNhap;
        private System.Windows.Forms.TextBox txtMatKhau_DangNhap;
        private System.Windows.Forms.Label lalEmail;
        private System.Windows.Forms.Label lalMatKhau;
        private System.Windows.Forms.Button btnAccesLogin;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblQuote;
    }
}