namespace QLTV
{
    partial class LapPhieuTra
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPhieuMuon;
        private System.Windows.Forms.ComboBox cboPhieuMuon;
        private System.Windows.Forms.Label lblDocGia;
        private System.Windows.Forms.Label lblTenDocGia;
        private System.Windows.Forms.Label lblSach;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Label lblSoTienPhatTitle;
        private System.Windows.Forms.Label lblSoTienPhat;
        private System.Windows.Forms.Button btnTraSach;

    protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPhieuMuon = new System.Windows.Forms.Label();
            this.cboPhieuMuon = new System.Windows.Forms.ComboBox();
            this.lblDocGia = new System.Windows.Forms.Label();
            this.lblTenDocGia = new System.Windows.Forms.Label();
            this.lblSach = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.lblSoTienPhatTitle = new System.Windows.Forms.Label();
            this.lblSoTienPhat = new System.Windows.Forms.Label();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(60, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(380, 40);
            this.lblTitle.Text = "LẬP PHIẾU TRẢ SÁCH";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhieuMuon
            // 
            this.lblPhieuMuon.AutoSize = true;
            this.lblPhieuMuon.Location = new System.Drawing.Point(60, 90);
            this.lblPhieuMuon.Name = "lblPhieuMuon";
            this.lblPhieuMuon.Size = new System.Drawing.Size(96, 20);
            this.lblPhieuMuon.Text = "Phiếu mượn:";
            // 
            // cboPhieuMuon
            // 
            this.cboPhieuMuon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhieuMuon.Location = new System.Drawing.Point(180, 87);
            this.cboPhieuMuon.Name = "cboPhieuMuon";
            this.cboPhieuMuon.Size = new System.Drawing.Size(250, 28);
            this.cboPhieuMuon.SelectedIndexChanged += new System.EventHandler(this.cboPhieuMuon_SelectedIndexChanged);
            // 
            // lblDocGia
            // 
            this.lblDocGia.AutoSize = true;
            this.lblDocGia.Location = new System.Drawing.Point(60, 140);
            this.lblDocGia.Name = "lblDocGia";
            this.lblDocGia.Size = new System.Drawing.Size(67, 20);
            this.lblDocGia.Text = "Độc giả:";
            // 
            // lblTenDocGia
            // 
            this.lblTenDocGia.AutoSize = true;
            this.lblTenDocGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenDocGia.Location = new System.Drawing.Point(180, 140);
            this.lblTenDocGia.Name = "lblTenDocGia";
            this.lblTenDocGia.Size = new System.Drawing.Size(15, 20);
            this.lblTenDocGia.Text = "-";
            // 
            // lblSach
            // 
            this.lblSach.AutoSize = true;
            this.lblSach.Location = new System.Drawing.Point(60, 180);
            this.lblSach.Name = "lblSach";
            this.lblSach.Size = new System.Drawing.Size(47, 20);
            this.lblSach.Text = "Sách:";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenSach.Location = new System.Drawing.Point(180, 180);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(15, 20);
            this.lblTenSach.Text = "-";
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Location = new System.Drawing.Point(60, 220);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(74, 20);
            this.lblNgayTra.Text = "Ngày trả:";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTra.Location = new System.Drawing.Point(180, 217);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(250, 27);
            // 
            // lblSoTienPhatTitle
            // 
            this.lblSoTienPhatTitle.AutoSize = true;
            this.lblSoTienPhatTitle.Location = new System.Drawing.Point(60, 260);
            this.lblSoTienPhatTitle.Name = "lblSoTienPhatTitle";
            this.lblSoTienPhatTitle.Size = new System.Drawing.Size(95, 20);
            this.lblSoTienPhatTitle.Text = "Tiền phạt:";
            // 
            // lblSoTienPhat
            // 
            this.lblSoTienPhat.AutoSize = true;
            this.lblSoTienPhat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSoTienPhat.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSoTienPhat.Location = new System.Drawing.Point(180, 260);
            this.lblSoTienPhat.Name = "lblSoTienPhat";
            this.lblSoTienPhat.Size = new System.Drawing.Size(38, 20);
            this.lblSoTienPhat.Text = "0 đ";
            // 
            // btnTraSach
            // 
            this.btnTraSach.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTraSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTraSach.ForeColor = System.Drawing.Color.White;
            this.btnTraSach.Location = new System.Drawing.Point(150, 310);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(190, 45);
            this.btnTraSach.Text = "XÁC NHẬN TRẢ";
            this.btnTraSach.UseVisualStyleBackColor = false;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // LapPhieuTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 390);
            this.Controls.Add(this.btnTraSach);
            this.Controls.Add(this.lblSoTienPhat);
            this.Controls.Add(this.lblSoTienPhatTitle);
            this.Controls.Add(this.dtpNgayTra);
            this.Controls.Add(this.lblNgayTra);
            this.Controls.Add(this.lblTenSach);
            this.Controls.Add(this.lblSach);
            this.Controls.Add(this.lblTenDocGia);
            this.Controls.Add(this.lblDocGia);
            this.Controls.Add(this.cboPhieuMuon);
            this.Controls.Add(this.lblPhieuMuon);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LapPhieuTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Phiếu Trả Sách";
            this.Load += new System.EventHandler(this.LapPhieuTra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
