namespace QLTV
{
    partial class LapPhieuMuon
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
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.lblDocGia = new System.Windows.Forms.Label();
            this.cboDocGia = new System.Windows.Forms.ComboBox();
            this.lblSach = new System.Windows.Forms.Label();
            this.cboSach = new System.Windows.Forms.ComboBox();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.lblHanTra = new System.Windows.Forms.Label();
            this.dtpHanTra = new System.Windows.Forms.DateTimePicker();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnLapPhieuMuon = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.grbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(52)))), ((int)(((byte)(50)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(481, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(268, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LẬP PHIẾU MƯỢN";
            // 
            // grbInfo
            // 
            this.grbInfo.BackColor = System.Drawing.Color.White;
            this.grbInfo.Controls.Add(this.lblDocGia);
            this.grbInfo.Controls.Add(this.cboDocGia);
            this.grbInfo.Controls.Add(this.lblSach);
            this.grbInfo.Controls.Add(this.cboSach);
            this.grbInfo.Controls.Add(this.lblNgayMuon);
            this.grbInfo.Controls.Add(this.dtpNgayMuon);
            this.grbInfo.Controls.Add(this.lblHanTra);
            this.grbInfo.Controls.Add(this.dtpHanTra);
            this.grbInfo.Controls.Add(this.lblTrangThai);
            this.grbInfo.Controls.Add(this.cboTrangThai);
            this.grbInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.grbInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(52)))), ((int)(((byte)(50)))));
            this.grbInfo.Location = new System.Drawing.Point(22, 81);
            this.grbInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.grbInfo.Size = new System.Drawing.Size(429, 284);
            this.grbInfo.TabIndex = 1;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Thông tin chi tiết";
            // 
            // lblDocGia
            // 
            this.lblDocGia.AutoSize = true;
            this.lblDocGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDocGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDocGia.Location = new System.Drawing.Point(30, 41);
            this.lblDocGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDocGia.Name = "lblDocGia";
            this.lblDocGia.Size = new System.Drawing.Size(58, 19);
            this.lblDocGia.TabIndex = 0;
            this.lblDocGia.Text = "Độc giả:";
            // 
            // cboDocGia
            // 
            this.cboDocGia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDocGia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboDocGia.FormattingEnabled = true;
            this.cboDocGia.Location = new System.Drawing.Point(139, 38);
            this.cboDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.cboDocGia.Name = "cboDocGia";
            this.cboDocGia.Size = new System.Drawing.Size(256, 28);
            this.cboDocGia.TabIndex = 1;
            // 
            // lblSach
            // 
            this.lblSach.AutoSize = true;
            this.lblSach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSach.Location = new System.Drawing.Point(30, 85);
            this.lblSach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSach.Name = "lblSach";
            this.lblSach.Size = new System.Drawing.Size(77, 19);
            this.lblSach.TabIndex = 2;
            this.lblSach.Text = "Chọn Sách:";
            // 
            // cboSach
            // 
            this.cboSach.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSach.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboSach.FormattingEnabled = true;
            this.cboSach.Location = new System.Drawing.Point(139, 80);
            this.cboSach.Margin = new System.Windows.Forms.Padding(2);
            this.cboSach.Name = "cboSach";
            this.cboSach.Size = new System.Drawing.Size(256, 28);
            this.cboSach.TabIndex = 3;
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNgayMuon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNgayMuon.Location = new System.Drawing.Point(30, 130);
            this.lblNgayMuon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Size = new System.Drawing.Size(84, 19);
            this.lblNgayMuon.TabIndex = 4;
            this.lblNgayMuon.Text = "Ngày mượn:";
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dtpNgayMuon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(139, 123);
            this.dtpNgayMuon.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(256, 27);
            this.dtpNgayMuon.TabIndex = 5;
            this.dtpNgayMuon.ValueChanged += new System.EventHandler(this.dtpNgayMuon_ValueChanged);
            // 
            // lblHanTra
            // 
            this.lblHanTra.AutoSize = true;
            this.lblHanTra.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHanTra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHanTra.Location = new System.Drawing.Point(30, 175);
            this.lblHanTra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHanTra.Name = "lblHanTra";
            this.lblHanTra.Size = new System.Drawing.Size(117, 19);
            this.lblHanTra.TabIndex = 6;
            this.lblHanTra.Text = "Hạn trả (Dự kiến):";
            // 
            // dtpHanTra
            // 
            this.dtpHanTra.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dtpHanTra.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpHanTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanTra.Location = new System.Drawing.Point(139, 168);
            this.dtpHanTra.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHanTra.Name = "dtpHanTra";
            this.dtpHanTra.Size = new System.Drawing.Size(256, 27);
            this.dtpHanTra.TabIndex = 7;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTrangThai.Location = new System.Drawing.Point(30, 219);
            this.lblTrangThai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(73, 19);
            this.lblTrangThai.TabIndex = 8;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Enabled = false;
            this.cboTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(139, 214);
            this.cboTrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(256, 28);
            this.cboTrangThai.TabIndex = 9;
            // 
            // btnLapPhieuMuon
            // 
            this.btnLapPhieuMuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(110)))), ((int)(((byte)(99)))));
            this.btnLapPhieuMuon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLapPhieuMuon.FlatAppearance.BorderSize = 0;
            this.btnLapPhieuMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapPhieuMuon.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnLapPhieuMuon.ForeColor = System.Drawing.Color.White;
            this.btnLapPhieuMuon.Location = new System.Drawing.Point(142, 390);
            this.btnLapPhieuMuon.Margin = new System.Windows.Forms.Padding(2);
            this.btnLapPhieuMuon.Name = "btnLapPhieuMuon";
            this.btnLapPhieuMuon.Size = new System.Drawing.Size(135, 41);
            this.btnLapPhieuMuon.TabIndex = 2;
            this.btnLapPhieuMuon.Text = "XÁC NHẬN";
            this.btnLapPhieuMuon.UseVisualStyleBackColor = false;
            this.btnLapPhieuMuon.Click += new System.EventHandler(this.btnLapPhieuMuon_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHuy.Location = new System.Drawing.Point(292, 390);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(135, 41);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // LapPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(481, 462);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLapPhieuMuon);
            this.Controls.Add(this.grbInfo);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LapPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập phiếu mượn";
            this.Load += new System.EventHandler(this.LapPhieuMuon_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.Label lblDocGia;
        private System.Windows.Forms.ComboBox cboDocGia;
        private System.Windows.Forms.Label lblSach;
        private System.Windows.Forms.ComboBox cboSach;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label lblHanTra;
        private System.Windows.Forms.DateTimePicker dtpHanTra;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Button btnLapPhieuMuon;
        private System.Windows.Forms.Button btnHuy;
    }
}