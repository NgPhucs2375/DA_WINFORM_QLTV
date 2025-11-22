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
            this.pnlHeader.BackColor = System.Drawing.Color.Teal;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(500, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LẬP PHIẾU MƯỢN";
            // 
            // grbInfo
            // 
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
            this.grbInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grbInfo.Location = new System.Drawing.Point(20, 80);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(460, 280);
            this.grbInfo.TabIndex = 1;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Thông tin phiếu";
            // 
            // lblDocGia
            // 
            this.lblDocGia.AutoSize = true;
            this.lblDocGia.Location = new System.Drawing.Point(30, 40);
            this.lblDocGia.Name = "lblDocGia";
            this.lblDocGia.Size = new System.Drawing.Size(73, 23);
            this.lblDocGia.TabIndex = 0;
            this.lblDocGia.Text = "Độc giả:";
            // 
            // cboDocGia
            // 
            this.cboDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocGia.FormattingEnabled = true;
            this.cboDocGia.Location = new System.Drawing.Point(140, 37);
            this.cboDocGia.Name = "cboDocGia";
            this.cboDocGia.Size = new System.Drawing.Size(290, 31);
            this.cboDocGia.TabIndex = 1;
            // 
            // lblSach
            // 
            this.lblSach.AutoSize = true;
            this.lblSach.Location = new System.Drawing.Point(30, 85);
            this.lblSach.Name = "lblSach";
            this.lblSach.Size = new System.Drawing.Size(50, 23);
            this.lblSach.TabIndex = 2;
            this.lblSach.Text = "Sách:";
            // 
            // cboSach
            // 
            this.cboSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSach.FormattingEnabled = true;
            this.cboSach.Location = new System.Drawing.Point(140, 82);
            this.cboSach.Name = "cboSach";
            this.cboSach.Size = new System.Drawing.Size(290, 31);
            this.cboSach.TabIndex = 3;
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.Location = new System.Drawing.Point(30, 130);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Size = new System.Drawing.Size(104, 23);
            this.lblNgayMuon.TabIndex = 4;
            this.lblNgayMuon.Text = "Ngày mượn:";
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(140, 127);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(290, 30);
            this.dtpNgayMuon.TabIndex = 5;
            this.dtpNgayMuon.ValueChanged += new System.EventHandler(this.dtpNgayMuon_ValueChanged);
            // 
            // lblHanTra
            // 
            this.lblHanTra.AutoSize = true;
            this.lblHanTra.Location = new System.Drawing.Point(30, 175);
            this.lblHanTra.Name = "lblHanTra";
            this.lblHanTra.Size = new System.Drawing.Size(70, 23);
            this.lblHanTra.TabIndex = 6;
            this.lblHanTra.Text = "Hạn trả:";
            // 
            // dtpHanTra
            // 
            this.dtpHanTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanTra.Location = new System.Drawing.Point(140, 172);
            this.dtpHanTra.Name = "dtpHanTra";
            this.dtpHanTra.Size = new System.Drawing.Size(290, 30);
            this.dtpHanTra.TabIndex = 7;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(30, 220);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(91, 23);
            this.lblTrangThai.TabIndex = 8;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Enabled = false;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(140, 217);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(290, 31);
            this.cboTrangThai.TabIndex = 9;
            // 
            // btnLapPhieuMuon
            // 
            this.btnLapPhieuMuon.BackColor = System.Drawing.Color.Teal;
            this.btnLapPhieuMuon.FlatAppearance.BorderSize = 0;
            this.btnLapPhieuMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapPhieuMuon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLapPhieuMuon.ForeColor = System.Drawing.Color.White;
            this.btnLapPhieuMuon.Location = new System.Drawing.Point(80, 380);
            this.btnLapPhieuMuon.Name = "btnLapPhieuMuon";
            this.btnLapPhieuMuon.Size = new System.Drawing.Size(150, 45);
            this.btnLapPhieuMuon.TabIndex = 2;
            this.btnLapPhieuMuon.Text = "XÁC NHẬN";
            this.btnLapPhieuMuon.UseVisualStyleBackColor = false;
            this.btnLapPhieuMuon.Click += new System.EventHandler(this.btnLapPhieuMuon_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnHuy.ForeColor = System.Drawing.Color.DimGray;
            this.btnHuy.Location = new System.Drawing.Point(250, 380);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(150, 45);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // LapPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLapPhieuMuon);
            this.Controls.Add(this.grbInfo);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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