namespace QLTV
{
    partial class FormDangKy
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
            this.pnlRegisterCard = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.cboVaiTro = new System.Windows.Forms.ComboBox();
            this.txtMaCapQuyen_DangKy = new System.Windows.Forms.TextBox();
            this.lalMaCapQuyen = new System.Windows.Forms.Label();
            this.txtEmail_DangKy = new System.Windows.Forms.TextBox();
            this.txtNhaplaiMatKhau_DangKy = new System.Windows.Forms.TextBox();
            this.txtSDT_DangKy = new System.Windows.Forms.TextBox();
            this.txtMatKhau_DangKy = new System.Windows.Forms.TextBox();
            this.lalVT = new System.Windows.Forms.Label();
            this.lalSDT = new System.Windows.Forms.Label();
            this.lalNhapLaiMatKhau = new System.Windows.Forms.Label();
            this.lalMatKhau = new System.Windows.Forms.Label();
            this.lalEmail = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtNameNguoiDung_DangKy = new System.Windows.Forms.TextBox();
            this.lalNameNguoiDung = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pnlBackground.SuspendLayout();
            this.pnlRegisterCard.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackgroundImage = global::QLTV.Properties.Resources.bookstorebg2;
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBackground.Controls.Add(this.pnlRegisterCard);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1200, 750);
            this.pnlBackground.TabIndex = 0;
            // 
            // pnlRegisterCard
            // 
            this.pnlRegisterCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlRegisterCard.BackColor = System.Drawing.Color.White;
            this.pnlRegisterCard.Controls.Add(this.pnlRight);
            this.pnlRegisterCard.Controls.Add(this.pnlLeft);
            this.pnlRegisterCard.Location = new System.Drawing.Point(150, 75);
            this.pnlRegisterCard.Name = "pnlRegisterCard";
            this.pnlRegisterCard.Size = new System.Drawing.Size(900, 600);
            this.pnlRegisterCard.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(237))))); // Cream Paper
            this.pnlRight.Controls.Add(this.lblHeader);
            this.pnlRight.Controls.Add(this.cboVaiTro);
            this.pnlRight.Controls.Add(this.txtMaCapQuyen_DangKy);
            this.pnlRight.Controls.Add(this.lalMaCapQuyen);
            this.pnlRight.Controls.Add(this.txtEmail_DangKy);
            this.pnlRight.Controls.Add(this.txtNhaplaiMatKhau_DangKy);
            this.pnlRight.Controls.Add(this.txtSDT_DangKy);
            this.pnlRight.Controls.Add(this.txtMatKhau_DangKy);
            this.pnlRight.Controls.Add(this.lalVT);
            this.pnlRight.Controls.Add(this.lalSDT);
            this.pnlRight.Controls.Add(this.lalNhapLaiMatKhau);
            this.pnlRight.Controls.Add(this.lalMatKhau);
            this.pnlRight.Controls.Add(this.lalEmail);
            this.pnlRight.Controls.Add(this.btnDangKy);
            this.pnlRight.Controls.Add(this.btnThoat);
            this.pnlRight.Controls.Add(this.txtNameNguoiDung_DangKy);
            this.pnlRight.Controls.Add(this.lalNameNguoiDung);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlRight.Location = new System.Drawing.Point(350, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(30);
            this.pnlRight.Size = new System.Drawing.Size(550, 600);
            this.pnlRight.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Playfair Display", 22F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.lblHeader.Location = new System.Drawing.Point(30, 25);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(325, 53);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Tạo Tài Khoản Mới";
            // 
            // lalNameNguoiDung
            // 
            this.lalNameNguoiDung.AutoSize = true;
            this.lalNameNguoiDung.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lalNameNguoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lalNameNguoiDung.Location = new System.Drawing.Point(35, 95);
            this.lalNameNguoiDung.Name = "lalNameNguoiDung";
            this.lalNameNguoiDung.Size = new System.Drawing.Size(88, 23);
            this.lalNameNguoiDung.TabIndex = 1;
            this.lalNameNguoiDung.Text = "Họ và tên:";
            // 
            // txtNameNguoiDung_DangKy
            // 
            this.txtNameNguoiDung_DangKy.BackColor = System.Drawing.Color.White;
            this.txtNameNguoiDung_DangKy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameNguoiDung_DangKy.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNameNguoiDung_DangKy.Location = new System.Drawing.Point(180, 90);
            this.txtNameNguoiDung_DangKy.Name = "txtNameNguoiDung_DangKy";
            this.txtNameNguoiDung_DangKy.Size = new System.Drawing.Size(330, 32);
            this.txtNameNguoiDung_DangKy.TabIndex = 2;
            // 
            // lalEmail
            // 
            this.lalEmail.AutoSize = true;
            this.lalEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lalEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lalEmail.Location = new System.Drawing.Point(35, 145);
            this.lalEmail.Name = "lalEmail";
            this.lalEmail.Size = new System.Drawing.Size(55, 23);
            this.lalEmail.TabIndex = 8;
            this.lalEmail.Text = "Email:";
            // 
            // txtEmail_DangKy
            // 
            this.txtEmail_DangKy.BackColor = System.Drawing.Color.White;
            this.txtEmail_DangKy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail_DangKy.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail_DangKy.Location = new System.Drawing.Point(180, 140);
            this.txtEmail_DangKy.Name = "txtEmail_DangKy";
            this.txtEmail_DangKy.Size = new System.Drawing.Size(330, 32);
            this.txtEmail_DangKy.TabIndex = 3;
            // 
            // lalSDT
            // 
            this.lalSDT.AutoSize = true;
            this.lalSDT.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lalSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lalSDT.Location = new System.Drawing.Point(35, 195);
            this.lalSDT.Name = "lalSDT";
            this.lalSDT.Size = new System.Drawing.Size(115, 23);
            this.lalSDT.TabIndex = 13;
            this.lalSDT.Text = "Số điện thoại:";
            // 
            // txtSDT_DangKy
            // 
            this.txtSDT_DangKy.BackColor = System.Drawing.Color.White;
            this.txtSDT_DangKy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT_DangKy.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSDT_DangKy.Location = new System.Drawing.Point(180, 190);
            this.txtSDT_DangKy.Name = "txtSDT_DangKy";
            this.txtSDT_DangKy.Size = new System.Drawing.Size(330, 32);
            this.txtSDT_DangKy.TabIndex = 4;
            // 
            // lalMatKhau
            // 
            this.lalMatKhau.AutoSize = true;
            this.lalMatKhau.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lalMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lalMatKhau.Location = new System.Drawing.Point(35, 245);
            this.lalMatKhau.Name = "lalMatKhau";
            this.lalMatKhau.Size = new System.Drawing.Size(88, 23);
            this.lalMatKhau.TabIndex = 9;
            this.lalMatKhau.Text = "Mật khẩu:";
            // 
            // txtMatKhau_DangKy
            // 
            this.txtMatKhau_DangKy.BackColor = System.Drawing.Color.White;
            this.txtMatKhau_DangKy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau_DangKy.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMatKhau_DangKy.Location = new System.Drawing.Point(180, 240);
            this.txtMatKhau_DangKy.Name = "txtMatKhau_DangKy";
            this.txtMatKhau_DangKy.Size = new System.Drawing.Size(330, 32);
            this.txtMatKhau_DangKy.TabIndex = 5;
            this.txtMatKhau_DangKy.UseSystemPasswordChar = true;
            // 
            // lalNhapLaiMatKhau
            // 
            this.lalNhapLaiMatKhau.AutoSize = true;
            this.lalNhapLaiMatKhau.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lalNhapLaiMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lalNhapLaiMatKhau.Location = new System.Drawing.Point(35, 295);
            this.lalNhapLaiMatKhau.Name = "lalNhapLaiMatKhau";
            this.lalNhapLaiMatKhau.Size = new System.Drawing.Size(110, 23);
            this.lalNhapLaiMatKhau.TabIndex = 12;
            this.lalNhapLaiMatKhau.Text = "Nhập lại MK:";
            // 
            // txtNhaplaiMatKhau_DangKy
            // 
            this.txtNhaplaiMatKhau_DangKy.BackColor = System.Drawing.Color.White;
            this.txtNhaplaiMatKhau_DangKy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNhaplaiMatKhau_DangKy.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNhaplaiMatKhau_DangKy.Location = new System.Drawing.Point(180, 290);
            this.txtNhaplaiMatKhau_DangKy.Name = "txtNhaplaiMatKhau_DangKy";
            this.txtNhaplaiMatKhau_DangKy.Size = new System.Drawing.Size(330, 32);
            this.txtNhaplaiMatKhau_DangKy.TabIndex = 6;
            this.txtNhaplaiMatKhau_DangKy.UseSystemPasswordChar = true;
            // 
            // lalVT
            // 
            this.lalVT.AutoSize = true;
            this.lalVT.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lalVT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lalVT.Location = new System.Drawing.Point(35, 345);
            this.lalVT.Name = "lalVT";
            this.lalVT.Size = new System.Drawing.Size(64, 23);
            this.lalVT.TabIndex = 14;
            this.lalVT.Text = "Vai trò:";
            // 
            // cboVaiTro
            // 
            this.cboVaiTro.BackColor = System.Drawing.Color.White;
            this.cboVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVaiTro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboVaiTro.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboVaiTro.FormattingEnabled = true;
            this.cboVaiTro.Location = new System.Drawing.Point(180, 340);
            this.cboVaiTro.Name = "cboVaiTro";
            this.cboVaiTro.Size = new System.Drawing.Size(330, 33);
            this.cboVaiTro.TabIndex = 7;
            this.cboVaiTro.SelectedIndexChanged += new System.EventHandler(this.cboVaiTro_SelectedIndexChanged);
            // 
            // lalMaCapQuyen
            // 
            this.lalMaCapQuyen.AutoSize = true;
            this.lalMaCapQuyen.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lalMaCapQuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lalMaCapQuyen.Location = new System.Drawing.Point(35, 395);
            this.lalMaCapQuyen.Name = "lalMaCapQuyen";
            this.lalMaCapQuyen.Size = new System.Drawing.Size(109, 23);
            this.lalMaCapQuyen.TabIndex = 25;
            this.lalMaCapQuyen.Text = "Mã xác thực:";
            // 
            // txtMaCapQuyen_DangKy
            // 
            this.txtMaCapQuyen_DangKy.BackColor = System.Drawing.Color.White;
            this.txtMaCapQuyen_DangKy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaCapQuyen_DangKy.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMaCapQuyen_DangKy.Location = new System.Drawing.Point(180, 390);
            this.txtMaCapQuyen_DangKy.Name = "txtMaCapQuyen_DangKy";
            this.txtMaCapQuyen_DangKy.Size = new System.Drawing.Size(330, 32);
            this.txtMaCapQuyen_DangKy.TabIndex = 8;
            this.txtMaCapQuyen_DangKy.UseSystemPasswordChar = true;
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(82)))), ((int)(((byte)(45)))));
            this.btnDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(40, 460);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(470, 50);
            this.btnDangKy.TabIndex = 9;
            this.btnDangKy.Text = "ĐĂNG KÝ";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline);
            this.btnThoat.ForeColor = System.Drawing.Color.Gray;
            this.btnThoat.Location = new System.Drawing.Point(40, 520);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(470, 40);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Đã có tài khoản? Đăng nhập ngay";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(69)))), ((int)(((byte)(19))))); // Dark Leather Color
            this.pnlLeft.Controls.Add(this.lblSlogan);
            this.pnlLeft.Controls.Add(this.lblBrand);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(350, 600);
            this.pnlLeft.TabIndex = 0;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Playfair Display", 28F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.lblBrand.Location = new System.Drawing.Point(40, 200);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(262, 132);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "THE\r\nLIBRARY";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblSlogan.Location = new System.Drawing.Point(45, 350);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(248, 64);
            this.lblSlogan.TabIndex = 1;
            this.lblSlogan.Text = "Khởi đầu hành trình\r\nkhám phá tri thức mới.";
            // 
            // FormDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tài khoản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDangKy_Load);
            this.pnlBackground.ResumeLayout(false);
            this.pnlRegisterCard.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel pnlRegisterCard;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.TextBox txtNameNguoiDung_DangKy;
        private System.Windows.Forms.Label lalNameNguoiDung;
        private System.Windows.Forms.TextBox txtEmail_DangKy;
        private System.Windows.Forms.Label lalEmail;
        private System.Windows.Forms.TextBox txtSDT_DangKy;
        private System.Windows.Forms.Label lalSDT;
        private System.Windows.Forms.TextBox txtMatKhau_DangKy;
        private System.Windows.Forms.Label lalMatKhau;
        private System.Windows.Forms.TextBox txtNhaplaiMatKhau_DangKy;
        private System.Windows.Forms.Label lalNhapLaiMatKhau;
        private System.Windows.Forms.ComboBox cboVaiTro;
        private System.Windows.Forms.Label lalVT;
        private System.Windows.Forms.TextBox txtMaCapQuyen_DangKy;
        private System.Windows.Forms.Label lalMaCapQuyen;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnThoat;
    }
}