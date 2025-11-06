namespace QLTV
{
    partial class LapPhieuMuon
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDocGia;
        private System.Windows.Forms.ComboBox cboDocGia;
        private System.Windows.Forms.Label lblSach;
        private System.Windows.Forms.ComboBox cboSach;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label lblHanTra;
        private System.Windows.Forms.DateTimePicker dtpHanTra;
        private System.Windows.Forms.Button btnLapPhieuMuon;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
    protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDocGia = new System.Windows.Forms.Label();
            this.cboDocGia = new System.Windows.Forms.ComboBox();
            this.lblSach = new System.Windows.Forms.Label();
            this.cboSach = new System.Windows.Forms.ComboBox();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.lblHanTra = new System.Windows.Forms.Label();
            this.dtpHanTra = new System.Windows.Forms.DateTimePicker();
            this.btnLapPhieuMuon = new System.Windows.Forms.Button();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(60, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(380, 40);
            this.lblTitle.Text = "LẬP PHIẾU MƯỢN SÁCH";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDocGia
            // 
            this.lblDocGia.AutoSize = true;
            this.lblDocGia.Location = new System.Drawing.Point(60, 90);
            this.lblDocGia.Name = "lblDocGia";
            this.lblDocGia.Size = new System.Drawing.Size(67, 20);
            this.lblDocGia.Text = "Độc giả:";
            // 
            // cboDocGia
            // 
            this.cboDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocGia.Location = new System.Drawing.Point(180, 87);
            this.cboDocGia.Name = "cboDocGia";
            this.cboDocGia.Size = new System.Drawing.Size(250, 28);
            // 
            // lblSach
            // 
            this.lblSach.AutoSize = true;
            this.lblSach.Location = new System.Drawing.Point(60, 130);
            this.lblSach.Name = "lblSach";
            this.lblSach.Size = new System.Drawing.Size(47, 20);
            this.lblSach.Text = "Sách:";
            // 
            // cboSach
            // 
            this.cboSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSach.Location = new System.Drawing.Point(180, 127);
            this.cboSach.Name = "cboSach";
            this.cboSach.Size = new System.Drawing.Size(250, 28);
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.Location = new System.Drawing.Point(60, 170);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Size = new System.Drawing.Size(94, 20);
            this.lblNgayMuon.Text = "Ngày mượn:";
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(180, 167);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(250, 27);
            // 
            // lblHanTra
            // 
            this.lblHanTra.AutoSize = true;
            this.lblHanTra.Location = new System.Drawing.Point(60, 210);
            this.lblHanTra.Name = "lblHanTra";
            this.lblHanTra.Size = new System.Drawing.Size(65, 20);
            this.lblHanTra.Text = "Hạn trả:";
            // 
            // dtpHanTra
            // 
            this.dtpHanTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanTra.Location = new System.Drawing.Point(180, 207);
            this.dtpHanTra.Name = "dtpHanTra";
            this.dtpHanTra.Size = new System.Drawing.Size(250, 27);
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(60, 250);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(85, 20);
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Location = new System.Drawing.Point(180, 247);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(250, 28);
            // 
            // btnLapPhieuMuon
            // 
            this.btnLapPhieuMuon.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLapPhieuMuon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLapPhieuMuon.ForeColor = System.Drawing.Color.White;
            this.btnLapPhieuMuon.Location = new System.Drawing.Point(150, 310);
            this.btnLapPhieuMuon.Name = "btnLapPhieuMuon";
            this.btnLapPhieuMuon.Size = new System.Drawing.Size(190, 45);
            this.btnLapPhieuMuon.Text = "LẬP PHIẾU MƯỢN";
            this.btnLapPhieuMuon.UseVisualStyleBackColor = false;
            this.btnLapPhieuMuon.Click += new System.EventHandler(this.btnLapPhieuMuon_Click);
            // 
            // LapPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 390);
            this.Controls.Add(this.btnLapPhieuMuon);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.dtpHanTra);
            this.Controls.Add(this.lblHanTra);
            this.Controls.Add(this.dtpNgayMuon);
            this.Controls.Add(this.lblNgayMuon);
            this.Controls.Add(this.cboSach);
            this.Controls.Add(this.lblSach);
            this.Controls.Add(this.cboDocGia);
            this.Controls.Add(this.lblDocGia);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LapPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Phiếu Mượn Sách";
            this.Load += new System.EventHandler(this.LapPhieuMuon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
