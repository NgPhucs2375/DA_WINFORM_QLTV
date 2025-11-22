namespace QLTV
{
    partial class QuanLyNV
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.grbChiTiet = new System.Windows.Forms.GroupBox();
            this.txtMatKhauNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.dtpkNgayVLNV = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cboVaiTro = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSDTNV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmailNV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.grbChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Indigo;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(363, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 70);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvNhanVien);
            this.splitContainer1.Panel1.Controls.Add(this.pnlSearch);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.grbChiTiet);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Size = new System.Drawing.Size(1100, 530);
            this.splitContainer1.SplitterDistance = 700;
            this.splitContainer1.TabIndex = 1;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSearch.Controls.Add(this.txtKeyword);
            this.pnlSearch.Controls.Add(this.label1);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(10, 10);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(680, 60);
            this.pnlSearch.TabIndex = 0;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtKeyword.Location = new System.Drawing.Point(110, 14);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(400, 32);
            this.txtKeyword.TabIndex = 1;
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm:";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(10, 70);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowTemplate.Height = 30;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(680, 450);
            this.dgvNhanVien.TabIndex = 1;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // grbChiTiet
            // 
            this.grbChiTiet.Controls.Add(this.txtMatKhauNV);
            this.grbChiTiet.Controls.Add(this.label7);
            this.grbChiTiet.Controls.Add(this.btnReset);
            this.grbChiTiet.Controls.Add(this.btnXoaNV);
            this.grbChiTiet.Controls.Add(this.btnSuaNV);
            this.grbChiTiet.Controls.Add(this.btnThemNV);
            this.grbChiTiet.Controls.Add(this.dtpkNgayVLNV);
            this.grbChiTiet.Controls.Add(this.label9);
            this.grbChiTiet.Controls.Add(this.cboVaiTro);
            this.grbChiTiet.Controls.Add(this.label6);
            this.grbChiTiet.Controls.Add(this.txtSDTNV);
            this.grbChiTiet.Controls.Add(this.label10);
            this.grbChiTiet.Controls.Add(this.txtEmailNV);
            this.grbChiTiet.Controls.Add(this.label8);
            this.grbChiTiet.Controls.Add(this.txtTenNV);
            this.grbChiTiet.Controls.Add(this.label3);
            this.grbChiTiet.Controls.Add(this.txtMaNV);
            this.grbChiTiet.Controls.Add(this.label2);
            this.grbChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbChiTiet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grbChiTiet.Location = new System.Drawing.Point(10, 10);
            this.grbChiTiet.Name = "grbChiTiet";
            this.grbChiTiet.Size = new System.Drawing.Size(376, 510);
            this.grbChiTiet.TabIndex = 0;
            this.grbChiTiet.TabStop = false;
            this.grbChiTiet.Text = "Thông tin chi tiết";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(120, 37);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(230, 30);
            this.txtMaNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã NV:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(120, 82);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(230, 30);
            this.txtTenNV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên:";
            // 
            // txtEmailNV
            // 
            this.txtEmailNV.Location = new System.Drawing.Point(120, 127);
            this.txtEmailNV.Name = "txtEmailNV";
            this.txtEmailNV.Size = new System.Drawing.Size(230, 30);
            this.txtEmailNV.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Email:";
            // 
            // txtSDTNV
            // 
            this.txtSDTNV.Location = new System.Drawing.Point(120, 172);
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.Size = new System.Drawing.Size(230, 30);
            this.txtSDTNV.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 23);
            this.label10.TabIndex = 6;
            this.label10.Text = "SĐT:";
            // 
            // cboVaiTro
            // 
            this.cboVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVaiTro.FormattingEnabled = true;
            this.cboVaiTro.Location = new System.Drawing.Point(120, 217);
            this.cboVaiTro.Name = "cboVaiTro";
            this.cboVaiTro.Size = new System.Drawing.Size(230, 31);
            this.cboVaiTro.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Vai trò:";
            // 
            // dtpkNgayVLNV
            // 
            this.dtpkNgayVLNV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgayVLNV.Location = new System.Drawing.Point(120, 262);
            this.dtpkNgayVLNV.Name = "dtpkNgayVLNV";
            this.dtpkNgayVLNV.Size = new System.Drawing.Size(230, 30);
            this.dtpkNgayVLNV.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Vào làm:";
            // 
            // txtMatKhauNV
            // 
            this.txtMatKhauNV.Location = new System.Drawing.Point(120, 307);
            this.txtMatKhauNV.Name = "txtMatKhauNV";
            this.txtMatKhauNV.Size = new System.Drawing.Size(230, 30);
            this.txtMatKhauNV.TabIndex = 13;
            this.txtMatKhauNV.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mật khẩu:";
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.SeaGreen;
            this.btnThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemNV.ForeColor = System.Drawing.Color.White;
            this.btnThemNV.Location = new System.Drawing.Point(25, 370);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(150, 40);
            this.btnThemNV.TabIndex = 14;
            this.btnThemNV.Text = "THÊM";
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.BackColor = System.Drawing.Color.Orange;
            this.btnSuaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaNV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSuaNV.ForeColor = System.Drawing.Color.White;
            this.btnSuaNV.Location = new System.Drawing.Point(200, 370);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(150, 40);
            this.btnSuaNV.TabIndex = 15;
            this.btnSuaNV.Text = "SỬA";
            this.btnSuaNV.UseVisualStyleBackColor = false;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackColor = System.Drawing.Color.Crimson;
            this.btnXoaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaNV.ForeColor = System.Drawing.Color.White;
            this.btnXoaNV.Location = new System.Drawing.Point(25, 430);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(150, 40);
            this.btnXoaNV.TabIndex = 16;
            this.btnXoaNV.Text = "XÓA";
            this.btnXoaNV.UseVisualStyleBackColor = false;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Gray;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(200, 430);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 40);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "LÀM MỚI";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // QuanLyNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "QuanLyNV";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.QuanLyTG_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.grbChiTiet.ResumeLayout(false);
            this.grbChiTiet.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbChiTiet;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSDTNV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboVaiTro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpkNgayVLNV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMatKhauNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnReset;
    }
}