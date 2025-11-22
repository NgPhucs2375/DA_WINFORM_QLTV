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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtEmail_DangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau_DangNhap = new System.Windows.Forms.TextBox();
            this.lalEmail = new System.Windows.Forms.Label();
            this.lalMatKhau = new System.Windows.Forms.Label();
            this.btnAccesLogin = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlLeft (Panel Xanh bên trái)
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlLeft.Controls.Add(this.label1);
            this.pnlLeft.Controls.Add(this.lblTitle);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(300, 450);
            this.pnlLeft.TabIndex = 0;
            // 
            // label1 (Slogan)
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng nhập để tiếp tục\r\nvào hệ thống";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle (Logo)
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(50, 150);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "WELCOME";
            // 
            // pnlRight (Panel Trắng bên phải)
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.lblHeader);
            this.pnlRight.Controls.Add(this.txtEmail_DangNhap);
            this.pnlRight.Controls.Add(this.txtMatKhau_DangNhap);
            this.pnlRight.Controls.Add(this.lalEmail);
            this.pnlRight.Controls.Add(this.lalMatKhau);
            this.pnlRight.Controls.Add(this.btnAccesLogin);
            this.pnlRight.Controls.Add(this.Exit);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlRight.Location = new System.Drawing.Point(300, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(450, 450);
            this.pnlRight.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblHeader.Location = new System.Drawing.Point(30, 40);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(172, 41);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Đăng nhập";
            // 
            // lalEmail
            // 
            this.lalEmail.AutoSize = true;
            this.lalEmail.ForeColor = System.Drawing.Color.DimGray;
            this.lalEmail.Location = new System.Drawing.Point(35, 120);
            this.lalEmail.Name = "lalEmail";
            this.lalEmail.Size = new System.Drawing.Size(55, 23);
            this.lalEmail.TabIndex = 1;
            this.lalEmail.Text = "Email:";
            // 
            // txtEmail_DangNhap
            // 
            this.txtEmail_DangNhap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail_DangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail_DangNhap.Location = new System.Drawing.Point(35, 150);
            this.txtEmail_DangNhap.Name = "txtEmail_DangNhap";
            this.txtEmail_DangNhap.Size = new System.Drawing.Size(380, 30);
            this.txtEmail_DangNhap.TabIndex = 2;
            // 
            // lalMatKhau
            // 
            this.lalMatKhau.AutoSize = true;
            this.lalMatKhau.ForeColor = System.Drawing.Color.DimGray;
            this.lalMatKhau.Location = new System.Drawing.Point(35, 200);
            this.lalMatKhau.Name = "lalMatKhau";
            this.lalMatKhau.Size = new System.Drawing.Size(86, 23);
            this.lalMatKhau.TabIndex = 3;
            this.lalMatKhau.Text = "Mật khẩu:";
            // 
            // txtMatKhau_DangNhap
            // 
            this.txtMatKhau_DangNhap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMatKhau_DangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau_DangNhap.Location = new System.Drawing.Point(35, 230);
            this.txtMatKhau_DangNhap.Name = "txtMatKhau_DangNhap";
            this.txtMatKhau_DangNhap.Size = new System.Drawing.Size(380, 30);
            this.txtMatKhau_DangNhap.TabIndex = 4;
            this.txtMatKhau_DangNhap.UseSystemPasswordChar = true;
            // 
            // btnAccesLogin
            // 
            this.btnAccesLogin.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAccesLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccesLogin.FlatAppearance.BorderSize = 0;
            this.btnAccesLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccesLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAccesLogin.ForeColor = System.Drawing.Color.White;
            this.btnAccesLogin.Location = new System.Drawing.Point(35, 300);
            this.btnAccesLogin.Name = "btnAccesLogin";
            this.btnAccesLogin.Size = new System.Drawing.Size(380, 45);
            this.btnAccesLogin.TabIndex = 5;
            this.btnAccesLogin.Text = "ĐĂNG NHẬP";
            this.btnAccesLogin.UseVisualStyleBackColor = false;
            this.btnAccesLogin.Click += new System.EventHandler(this.btnAccesLogin_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.White;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline);
            this.Exit.ForeColor = System.Drawing.Color.DimGray;
            this.Exit.Location = new System.Drawing.Point(35, 360);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(380, 35);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Quay lại màn hình chính";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtEmail_DangNhap;
        private System.Windows.Forms.TextBox txtMatKhau_DangNhap;
        private System.Windows.Forms.Label lalEmail;
        private System.Windows.Forms.Label lalMatKhau;
        private System.Windows.Forms.Button btnAccesLogin;
        private System.Windows.Forms.Button Exit;
    }
}