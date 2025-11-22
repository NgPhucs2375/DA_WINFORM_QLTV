namespace QLTV
{
    partial class FormDangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.cboVaiTro = new System.Windows.Forms.ComboBox();
            this.txtMaCapQuyen_DangKy = new System.Windows.Forms.TextBox();
            this.lalMaCapQuyen = new System.Windows.Forms.Label(); // Đã sửa về lal
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
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlLeft.Controls.Add(this.label1);
            this.pnlLeft.Controls.Add(this.lblTitle);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(350, 550);
            this.pnlLeft.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hệ thống quản lý\r\nThư viện thông minh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(55, 150);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 74);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LIBRARY";
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.lblHeader);
            this.pnlRight.Controls.Add(this.cboVaiTro);
            this.pnlRight.Controls.Add(this.txtMaCapQuyen_DangKy);
            this.pnlRight.Controls.Add(this.lalMaCapQuyen); // Dùng biến lal
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
            this.pnlRight.Size = new System.Drawing.Size(550, 550);
            this.pnlRight.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblHeader.Location = new System.Drawing.Point(30, 30);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(323, 48);
            this.lblHeader.TabIndex = 28;
            this.lblHeader.Text = "Đăng ký tài khoản";
            // 
            // cboVaiTro
            // 
            this.cboVaiTro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVaiTro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboVaiTro.FormattingEnabled = true;
            this.cboVaiTro.Location = new System.Drawing.Point(190, 300);
            this.cboVaiTro.Name = "cboVaiTro";
            this.cboVaiTro.Size = new System.Drawing.Size(300, 36);
            this.cboVaiTro.TabIndex = 27;
            this.cboVaiTro.SelectedIndexChanged += new System.EventHandler(this.cboVaiTro_SelectedIndexChanged);
            // 
            // txtMaCapQuyen_DangKy
            // 
            this.txtMaCapQuyen_DangKy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaCapQuyen_DangKy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaCapQuyen_DangKy.Location = new System.Drawing.Point(190, 345);
            this.txtMaCapQuyen_DangKy.Name = "txtMaCapQuyen_DangKy";
            this.txtMaCapQuyen_DangKy.Size = new System.Drawing.Size(300, 34);
            this.txtMaCapQuyen_DangKy.TabIndex = 26;
            this.txtMaCapQuyen_DangKy.UseSystemPasswordChar = true;
            // 
            // lalMaCapQuyen
            // 
            this.lalMaCapQuyen.AutoSize = true;
            this.lalMaCapQuyen.ForeColor = System.Drawing.Color.DimGray;
            this.lalMaCapQuyen.Location = new System.Drawing.Point(30, 348);
            this.lalMaCapQuyen.Name = "lalMaCapQuyen";
            this.lalMaCapQuyen.Size = new System.Drawing.Size(138, 28);
            this.lalMaCapQuyen.TabIndex = 25;
            this.lalMaCapQuyen.Text = "Mã xác thực:";
            // 
            // txtEmail_DangKy
            // 
            this.txtEmail_DangKy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail_DangKy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail_DangKy.Location = new System.Drawing.Point(190, 135);
            this.txtEmail_DangKy.Name = "txtEmail_DangKy";
            this.txtEmail_DangKy.Size = new System.Drawing.Size(300, 34);
            this.txtEmail_DangKy.TabIndex = 21;
            // 
            // txtNhaplaiMatKhau_DangKy
            // 
            this.txtNhaplaiMatKhau_DangKy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNhaplaiMatKhau_DangKy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNhaplaiMatKhau_DangKy.Location = new System.Drawing.Point(190, 260);
            this.txtNhaplaiMatKhau_DangKy.Name = "txtNhaplaiMatKhau_DangKy";
            this.txtNhaplaiMatKhau_DangKy.Size = new System.Drawing.Size(300, 34);
            this.txtNhaplaiMatKhau_DangKy.TabIndex = 19;
            this.txtNhaplaiMatKhau_DangKy.UseSystemPasswordChar = true;
            // 
            // txtSDT_DangKy
            // 
            this.txtSDT_DangKy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSDT_DangKy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT_DangKy.Location = new System.Drawing.Point(190, 175);
            this.txtSDT_DangKy.Name = "txtSDT_DangKy";
            this.txtSDT_DangKy.Size = new System.Drawing.Size(300, 34);
            this.txtSDT_DangKy.TabIndex = 18;
            // 
            // txtMatKhau_DangKy
            // 
            this.txtMatKhau_DangKy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMatKhau_DangKy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau_DangKy.Location = new System.Drawing.Point(190, 218);
            this.txtMatKhau_DangKy.Name = "txtMatKhau_DangKy";
            this.txtMatKhau_DangKy.Size = new System.Drawing.Size(300, 34);
            this.txtMatKhau_DangKy.TabIndex = 17;
            this.txtMatKhau_DangKy.UseSystemPasswordChar = true;
            // 
            // lalVT
            // 
            this.lalVT.AutoSize = true;
            this.lalVT.ForeColor = System.Drawing.Color.DimGray;
            this.lalVT.Location = new System.Drawing.Point(30, 305);
            this.lalVT.Name = "lalVT";
            this.lalVT.Size = new System.Drawing.Size(74, 28);
            this.lalVT.TabIndex = 14;
            this.lalVT.Text = "Vai trò:";
            // 
            // lalSDT
            // 
            this.lalSDT.AutoSize = true;
            this.lalSDT.ForeColor = System.Drawing.Color.DimGray;
            this.lalSDT.Location = new System.Drawing.Point(30, 178);
            this.lalSDT.Name = "lalSDT";
            this.lalSDT.Size = new System.Drawing.Size(133, 28);
            this.lalSDT.TabIndex = 13;
            this.lalSDT.Text = "Số điện thoại:";
            // 
            // lalNhapLaiMatKhau
            // 
            this.lalNhapLaiMatKhau.AutoSize = true;
            this.lalNhapLaiMatKhau.ForeColor = System.Drawing.Color.DimGray;
            this.lalNhapLaiMatKhau.Location = new System.Drawing.Point(30, 263);
            this.lalNhapLaiMatKhau.Name = "lalNhapLaiMatKhau";
            this.lalNhapLaiMatKhau.Size = new System.Drawing.Size(138, 28);
            this.lalNhapLaiMatKhau.TabIndex = 12;
            this.lalNhapLaiMatKhau.Text = "Nhập lại MK:";
            // 
            // lalMatKhau
            // 
            this.lalMatKhau.AutoSize = true;
            this.lalMatKhau.ForeColor = System.Drawing.Color.DimGray;
            this.lalMatKhau.Location = new System.Drawing.Point(30, 220);
            this.lalMatKhau.Name = "lalMatKhau";
            this.lalMatKhau.Size = new System.Drawing.Size(99, 28);
            this.lalMatKhau.TabIndex = 9;
            this.lalMatKhau.Text = "Mật khẩu:";
            // 
            // lalEmail
            // 
            this.lalEmail.AutoSize = true;
            this.lalEmail.ForeColor = System.Drawing.Color.DimGray;
            this.lalEmail.Location = new System.Drawing.Point(30, 138);
            this.lalEmail.Name = "lalEmail";
            this.lalEmail.Size = new System.Drawing.Size(64, 28);
            this.lalEmail.TabIndex = 8;
            this.lalEmail.Text = "Email:";
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(35, 420);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(455, 50);
            this.btnDangKy.TabIndex = 5;
            this.btnDangKy.Text = "ĐĂNG KÝ NGAY";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline);
            this.btnThoat.ForeColor = System.Drawing.Color.DimGray;
            this.btnThoat.Location = new System.Drawing.Point(35, 480);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(455, 40);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Quay lại màn hình chính";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtNameNguoiDung_DangKy
            // 
            this.txtNameNguoiDung_DangKy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNameNguoiDung_DangKy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameNguoiDung_DangKy.Location = new System.Drawing.Point(190, 95);
            this.txtNameNguoiDung_DangKy.Name = "txtNameNguoiDung_DangKy";
            this.txtNameNguoiDung_DangKy.Size = new System.Drawing.Size(300, 34);
            this.txtNameNguoiDung_DangKy.TabIndex = 2;
            // 
            // lalNameNguoiDung
            // 
            this.lalNameNguoiDung.AutoSize = true;
            this.lalNameNguoiDung.ForeColor = System.Drawing.Color.DimGray;
            this.lalNameNguoiDung.Location = new System.Drawing.Point(30, 98);
            this.lalNameNguoiDung.Name = "lalNameNguoiDung";
            this.lalNameNguoiDung.Size = new System.Drawing.Size(100, 28);
            this.lalNameNguoiDung.TabIndex = 1;
            this.lalNameNguoiDung.Text = "Họ và tên:";
            // 
            // FormDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tài khoản mới";
            this.Load += new System.EventHandler(this.FormDangKy_Load);
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
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtNameNguoiDung_DangKy;
        private System.Windows.Forms.Label lalNameNguoiDung;
        private System.Windows.Forms.TextBox txtEmail_DangKy;
        private System.Windows.Forms.TextBox txtNhaplaiMatKhau_DangKy;
        private System.Windows.Forms.TextBox txtSDT_DangKy;
        private System.Windows.Forms.TextBox txtMatKhau_DangKy;
        private System.Windows.Forms.Label lalSDT;
        private System.Windows.Forms.Label lalNhapLaiMatKhau;
        private System.Windows.Forms.Label lalMatKhau;
        private System.Windows.Forms.Label lalEmail;
        private System.Windows.Forms.ComboBox cboVaiTro;
        private System.Windows.Forms.TextBox txtMaCapQuyen_DangKy;
        private System.Windows.Forms.Label lalMaCapQuyen; // Đã sửa thành lal
        private System.Windows.Forms.Label lalVT;
    }
}