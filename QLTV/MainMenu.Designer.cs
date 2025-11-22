namespace QLTV
{
    partial class MainMenu
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.panelMenuBottom = new System.Windows.Forms.Panel();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnQLNhanVien = new System.Windows.Forms.Button();
            this.btnQLMuonTra = new System.Windows.Forms.Button();
            this.btnQLDocGia = new System.Windows.Forms.Button();
            this.btnQLSach = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar (MENU BÊN TRÁI)
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlSidebar.Controls.Add(this.btnBaoCao);
            this.pnlSidebar.Controls.Add(this.btnQLNhanVien);
            this.pnlSidebar.Controls.Add(this.btnQLMuonTra);
            this.pnlSidebar.Controls.Add(this.btnQLDocGia);
            this.pnlSidebar.Controls.Add(this.btnQLSach);
            this.pnlSidebar.Controls.Add(this.panelMenuBottom);
            this.pnlSidebar.Controls.Add(this.btnDoiMatKhau);
            this.pnlSidebar.Controls.Add(this.btnDangXuat);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(250, 600);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlLogo (LOGO APP)
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(250, 80);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(45, 22);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(156, 37);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "QUẢN LÝ TV";
            // 
            // btnQLSach
            // 
            this.btnQLSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLSach.FlatAppearance.BorderSize = 0;
            this.btnQLSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLSach.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnQLSach.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQLSach.Location = new System.Drawing.Point(0, 80);
            this.btnQLSach.Name = "btnQLSach";
            this.btnQLSach.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnQLSach.Size = new System.Drawing.Size(250, 60);
            this.btnQLSach.TabIndex = 1;
            this.btnQLSach.Text = "  Quản lý Sách";
            this.btnQLSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSach.UseVisualStyleBackColor = true;
            this.btnQLSach.Click += new System.EventHandler(this.btnQLSach_Click);
            // 
            // btnQLDocGia
            // 
            this.btnQLDocGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLDocGia.FlatAppearance.BorderSize = 0;
            this.btnQLDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDocGia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnQLDocGia.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQLDocGia.Location = new System.Drawing.Point(0, 140);
            this.btnQLDocGia.Name = "btnQLDocGia";
            this.btnQLDocGia.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnQLDocGia.Size = new System.Drawing.Size(250, 60);
            this.btnQLDocGia.TabIndex = 2;
            this.btnQLDocGia.Text = "  Quản lý Độc giả";
            this.btnQLDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDocGia.UseVisualStyleBackColor = true;
            this.btnQLDocGia.Click += new System.EventHandler(this.btnQLDocGia_Click);
            // 
            // btnQLMuonTra
            // 
            this.btnQLMuonTra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLMuonTra.FlatAppearance.BorderSize = 0;
            this.btnQLMuonTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLMuonTra.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnQLMuonTra.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQLMuonTra.Location = new System.Drawing.Point(0, 200);
            this.btnQLMuonTra.Name = "btnQLMuonTra";
            this.btnQLMuonTra.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnQLMuonTra.Size = new System.Drawing.Size(250, 60);
            this.btnQLMuonTra.TabIndex = 3;
            this.btnQLMuonTra.Text = "  Quản lý Mượn - Trả";
            this.btnQLMuonTra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLMuonTra.UseVisualStyleBackColor = true;
            this.btnQLMuonTra.Click += new System.EventHandler(this.btnQLMuonTra_Click);
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNhanVien.FlatAppearance.BorderSize = 0;
            this.btnQLNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNhanVien.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnQLNhanVien.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQLNhanVien.Location = new System.Drawing.Point(0, 260);
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnQLNhanVien.Size = new System.Drawing.Size(250, 60);
            this.btnQLNhanVien.TabIndex = 4;
            this.btnQLNhanVien.Text = "  Quản lý Nhân viên";
            this.btnQLNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNhanVien.UseVisualStyleBackColor = true;
            this.btnQLNhanVien.Click += new System.EventHandler(this.btnQLNhanVien_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBaoCao.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBaoCao.Location = new System.Drawing.Point(0, 320);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBaoCao.Size = new System.Drawing.Size(250, 60);
            this.btnBaoCao.TabIndex = 5;
            this.btnBaoCao.Text = "  Báo cáo & Thống kê";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // panelMenuBottom (Đẩy các nút dưới xuống đáy)
            // 
            this.panelMenuBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuBottom.Location = new System.Drawing.Point(0, 380);
            this.panelMenuBottom.Name = "panelMenuBottom";
            this.panelMenuBottom.Size = new System.Drawing.Size(250, 100);
            this.panelMenuBottom.TabIndex = 6;
            this.panelMenuBottom.Visible = false; // Chỉ dùng để padding nếu cần
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.Silver;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(0, 500);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(250, 50);
            this.btnDoiMatKhau.TabIndex = 7;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 550);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(250, 50);
            this.btnDangXuat.TabIndex = 8;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // pnlHeader (HEADER TRÊN CÙNG)
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnlHeader.Controls.Add(this.lblUserInfo);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(250, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(850, 80);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(25, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(204, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TRANG CHỦ";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblUserInfo.ForeColor = System.Drawing.Color.White;
            this.lblUserInfo.Location = new System.Drawing.Point(600, 30);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(120, 25);
            this.lblUserInfo.TabIndex = 1;
            this.lblUserInfo.Text = "User: Guest";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.IsMdiContainer = true;
            this.Name = "MainMenu";
            this.Text = "Hệ thống Quản lý Thư viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnQLSach;
        private System.Windows.Forms.Button btnQLDocGia;
        private System.Windows.Forms.Button btnQLMuonTra;
        private System.Windows.Forms.Button btnQLNhanVien;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel panelMenuBottom;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUserInfo;
    }
}