namespace QLTV
{
    partial class LapPhieuTra
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
            this.lblHanTra = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTenDocGia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPhieuMuon = new System.Windows.Forms.ComboBox();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.txtTienDenBu = new System.Windows.Forms.TextBox();
            this.chkMatSach = new System.Windows.Forms.CheckBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTienMuon = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSoTienPhat = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.grbInfo.SuspendLayout();
            this.groupBoxAction.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33))))); // Sienna
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
            this.lblTitle.Font = new System.Drawing.Font("Playfair Display", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(315, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "XÁC NHẬN TRẢ SÁCH";
            // 
            // grbInfo
            // 
            this.grbInfo.BackColor = System.Drawing.Color.White;
            this.grbInfo.Controls.Add(this.lblHanTra);
            this.grbInfo.Controls.Add(this.label8);
            this.grbInfo.Controls.Add(this.lblNgayMuon);
            this.grbInfo.Controls.Add(this.label6);
            this.grbInfo.Controls.Add(this.lblTenSach);
            this.grbInfo.Controls.Add(this.label4);
            this.grbInfo.Controls.Add(this.lblTenDocGia);
            this.grbInfo.Controls.Add(this.label2);
            this.grbInfo.Controls.Add(this.label1);
            this.grbInfo.Controls.Add(this.cboPhieuMuon);
            this.grbInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grbInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.grbInfo.Location = new System.Drawing.Point(20, 20);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(460, 200);
            this.grbInfo.TabIndex = 1;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Thông tin mượn";
            // 
            // lblHanTra
            // 
            this.lblHanTra.AutoSize = true;
            this.lblHanTra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHanTra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(92)))), ((int)(((byte)(92))))); // Indian Red
            this.lblHanTra.Location = new System.Drawing.Point(340, 150);
            this.lblHanTra.Name = "lblHanTra";
            this.lblHanTra.Size = new System.Drawing.Size(31, 23);
            this.lblHanTra.TabIndex = 9;
            this.lblHanTra.Text = "---";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(260, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Hạn trả:";
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.ForeColor = System.Drawing.Color.Black;
            this.lblNgayMuon.Location = new System.Drawing.Point(125, 150);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Size = new System.Drawing.Size(31, 23);
            this.lblNgayMuon.TabIndex = 7;
            this.lblNgayMuon.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(20, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày mượn:";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTenSach.ForeColor = System.Drawing.Color.Black;
            this.lblTenSach.Location = new System.Drawing.Point(125, 115);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(31, 23);
            this.lblTenSach.TabIndex = 5;
            this.lblTenSach.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(20, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sách:";
            // 
            // lblTenDocGia
            // 
            this.lblTenDocGia.AutoSize = true;
            this.lblTenDocGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTenDocGia.ForeColor = System.Drawing.Color.Black;
            this.lblTenDocGia.Location = new System.Drawing.Point(125, 80);
            this.lblTenDocGia.Name = "lblTenDocGia";
            this.lblTenDocGia.Size = new System.Drawing.Size(31, 23);
            this.lblTenDocGia.TabIndex = 3;
            this.lblTenDocGia.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Độc giả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn phiếu:";
            // 
            // cboPhieuMuon
            // 
            this.cboPhieuMuon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboPhieuMuon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPhieuMuon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboPhieuMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPhieuMuon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboPhieuMuon.FormattingEnabled = true;
            this.cboPhieuMuon.Location = new System.Drawing.Point(129, 37);
            this.cboPhieuMuon.Name = "cboPhieuMuon";
            this.cboPhieuMuon.Size = new System.Drawing.Size(310, 31);
            this.cboPhieuMuon.TabIndex = 0;
            this.cboPhieuMuon.SelectedIndexChanged += new System.EventHandler(this.cboPhieuMuon_SelectedIndexChanged);
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.BackColor = System.Drawing.Color.White;
            this.groupBoxAction.Controls.Add(this.txtTienDenBu);
            this.groupBoxAction.Controls.Add(this.chkMatSach);
            this.groupBoxAction.Controls.Add(this.lblTongTien);
            this.groupBoxAction.Controls.Add(this.label9);
            this.groupBoxAction.Controls.Add(this.lblTienMuon);
            this.groupBoxAction.Controls.Add(this.label5);
            this.groupBoxAction.Controls.Add(this.lblSoTienPhat);
            this.groupBoxAction.Controls.Add(this.label12);
            this.groupBoxAction.Controls.Add(this.dtpNgayTra);
            this.groupBoxAction.Controls.Add(this.label10);
            this.groupBoxAction.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.groupBoxAction.Location = new System.Drawing.Point(20, 240);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Size = new System.Drawing.Size(460, 220);
            this.groupBoxAction.TabIndex = 2;
            this.groupBoxAction.TabStop = false;
            this.groupBoxAction.Text = "Xử lý trả sách";
            // 
            // txtTienDenBu
            // 
            this.txtTienDenBu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTienDenBu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTienDenBu.Enabled = false;
            this.txtTienDenBu.Location = new System.Drawing.Point(300, 37);
            this.txtTienDenBu.Name = "txtTienDenBu";
            this.txtTienDenBu.Size = new System.Drawing.Size(140, 30);
            this.txtTienDenBu.TabIndex = 9;
            this.txtTienDenBu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTienDenBu.TextChanged += new System.EventHandler(this.txtTienDenBu_TextChanged);
            // 
            // chkMatSach
            // 
            this.chkMatSach.AutoSize = true;
            this.chkMatSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.chkMatSach.Location = new System.Drawing.Point(300, 0);
            this.chkMatSach.Name = "chkMatSach";
            this.chkMatSach.Size = new System.Drawing.Size(139, 27);
            this.chkMatSach.TabIndex = 8;
            this.chkMatSach.Text = "Làm mất sách";
            this.chkMatSach.UseVisualStyleBackColor = true;
            this.chkMatSach.CheckedChanged += new System.EventHandler(this.chkMatSach_CheckedChanged);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87))))); // Sea Green
            this.lblTongTien.Location = new System.Drawing.Point(125, 165);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(99, 37);
            this.lblTongTien.TabIndex = 7;
            this.lblTongTien.Text = "0 VNĐ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(20, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 28);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tổng:";
            // 
            // lblTienMuon
            // 
            this.lblTienMuon.AutoSize = true;
            this.lblTienMuon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTienMuon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.lblTienMuon.Location = new System.Drawing.Point(125, 80);
            this.lblTienMuon.Name = "lblTienMuon";
            this.lblTienMuon.Size = new System.Drawing.Size(73, 28);
            this.lblTienMuon.TabIndex = 5;
            this.lblTienMuon.Text = "0 VNĐ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(20, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tiền mượn:";
            // 
            // lblSoTienPhat
            // 
            this.lblSoTienPhat.AutoSize = true;
            this.lblSoTienPhat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoTienPhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.lblSoTienPhat.Location = new System.Drawing.Point(125, 120);
            this.lblSoTienPhat.Name = "lblSoTienPhat";
            this.lblSoTienPhat.Size = new System.Drawing.Size(73, 28);
            this.lblSoTienPhat.TabIndex = 3;
            this.lblSoTienPhat.Text = "0 VNĐ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(20, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 23);
            this.label12.TabIndex = 2;
            this.label12.Text = "Tiền phạt:";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTra.Location = new System.Drawing.Point(129, 37);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(150, 30);
            this.dtpNgayTra.TabIndex = 1;
            this.dtpNgayTra.ValueChanged += new System.EventHandler(this.dtpNgayTra_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(20, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ngày trả:";
            // 
            // btnTraSach
            // 
            this.btnTraSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(82)))), ((int)(((byte)(45))))); // Sienna
            this.btnTraSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraSach.FlatAppearance.BorderSize = 0;
            this.btnTraSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraSach.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTraSach.ForeColor = System.Drawing.Color.White;
            this.btnTraSach.Location = new System.Drawing.Point(80, 480);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(150, 45);
            this.btnTraSach.TabIndex = 3;
            this.btnTraSach.Text = "HOÀN TẤT";
            this.btnTraSach.UseVisualStyleBackColor = false;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnHuy.ForeColor = System.Drawing.Color.DimGray;
            this.btnHuy.Location = new System.Drawing.Point(270, 480);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(150, 45);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(224))))); // Cream
            this.pnlContent.Controls.Add(this.grbInfo);
            this.pnlContent.Controls.Add(this.btnHuy);
            this.pnlContent.Controls.Add(this.groupBoxAction);
            this.pnlContent.Controls.Add(this.btnTraSach);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(500, 540);
            this.pnlContent.TabIndex = 5;
            // 
            // LapPhieuTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LapPhieuTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập phiếu trả sách";
            this.Load += new System.EventHandler(this.LapPhieuTra_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.groupBoxAction.ResumeLayout(false);
            this.groupBoxAction.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.ComboBox cboPhieuMuon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTenDocGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblHanTra;
        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSoTienPhat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTienMuon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTienDenBu;
        private System.Windows.Forms.CheckBox chkMatSach;
        private System.Windows.Forms.Panel pnlContent;
    }
}