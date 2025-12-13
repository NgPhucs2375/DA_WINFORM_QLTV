namespace QLTV
{
    partial class FormChiTietSach
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
            this.picAnhBia = new System.Windows.Forms.PictureBox();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblNXB = new System.Windows.Forms.Label();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabThongTin = new System.Windows.Forms.TabPage();
            this.tabDanhGia = new System.Windows.Forms.TabPage();
            this.dgvDanhGia = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRating = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhBia)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabThongTin.SuspendLayout();
            this.tabDanhGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhGia)).BeginInit();
            this.SuspendLayout();
            // 
            // picAnhBia
            // 
            this.picAnhBia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhBia.Location = new System.Drawing.Point(20, 20);
            this.picAnhBia.Name = "picAnhBia";
            this.picAnhBia.Size = new System.Drawing.Size(200, 300);
            this.picAnhBia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnhBia.TabIndex = 0;
            this.picAnhBia.TabStop = false;
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTenSach.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTenSach.Location = new System.Drawing.Point(240, 20);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(152, 37);
            this.lblTenSach.TabIndex = 1;
            this.lblTenSach.Text = "TÊN SÁCH";
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTacGia.Location = new System.Drawing.Point(240, 70);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(76, 28);
            this.lblTacGia.TabIndex = 2;
            this.lblTacGia.Text = "Tác giả:";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblRating.ForeColor = System.Drawing.Color.Orange;
            this.lblRating.Location = new System.Drawing.Point(240, 110);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(86, 32);
            this.lblRating.TabIndex = 3;
            this.lblRating.Text = "★ 4.5";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabThongTin);
            this.tabControl1.Controls.Add(this.tabDanhGia);
            this.tabControl1.Location = new System.Drawing.Point(240, 160);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(530, 280);
            this.tabControl1.TabIndex = 4;
            // 
            // tabThongTin
            // 
            this.tabThongTin.Controls.Add(this.txtMoTa);
            this.tabThongTin.Controls.Add(this.lblNXB);
            this.tabThongTin.Controls.Add(this.lblTheLoai);
            this.tabThongTin.Location = new System.Drawing.Point(4, 25);
            this.tabThongTin.Name = "tabThongTin";
            this.tabThongTin.Padding = new System.Windows.Forms.Padding(10);
            this.tabThongTin.Size = new System.Drawing.Size(522, 251);
            this.tabThongTin.TabIndex = 0;
            this.tabThongTin.Text = "Thông tin chi tiết";
            this.tabThongTin.UseVisualStyleBackColor = true;
            // 
            // lblNXB
            // 
            this.lblNXB.AutoSize = true;
            this.lblNXB.Location = new System.Drawing.Point(10, 15);
            this.lblNXB.Name = "lblNXB";
            this.lblNXB.Size = new System.Drawing.Size(95, 17);
            this.lblNXB.TabIndex = 0;
            this.lblNXB.Text = "Nhà xuất bản:";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Location = new System.Drawing.Point(10, 45);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(63, 17);
            this.lblTheLoai.TabIndex = 1;
            this.lblTheLoai.Text = "Thể loại:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(10, 80);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ReadOnly = true;
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTa.Size = new System.Drawing.Size(500, 160);
            this.txtMoTa.TabIndex = 2;
            // 
            // tabDanhGia
            // 
            this.tabDanhGia.Controls.Add(this.dgvDanhGia);
            this.tabDanhGia.Location = new System.Drawing.Point(4, 25);
            this.tabDanhGia.Name = "tabDanhGia";
            this.tabDanhGia.Padding = new System.Windows.Forms.Padding(3);
            this.tabDanhGia.Size = new System.Drawing.Size(522, 251);
            this.tabDanhGia.TabIndex = 1;
            this.tabDanhGia.Text = "Đánh giá & Bình luận";
            this.tabDanhGia.UseVisualStyleBackColor = true;
            // 
            // dgvDanhGia
            // 
            this.dgvDanhGia.AllowUserToAddRows = false;
            this.dgvDanhGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhGia.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhGia.Location = new System.Drawing.Point(3, 3);
            this.dgvDanhGia.Name = "dgvDanhGia";
            this.dgvDanhGia.ReadOnly = true;
            this.dgvDanhGia.RowHeadersVisible = false;
            this.dgvDanhGia.RowTemplate.Height = 24;
            this.dgvDanhGia.Size = new System.Drawing.Size(516, 245);
            this.dgvDanhGia.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(670, 450);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormChiTietSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblTacGia);
            this.Controls.Add(this.lblTenSach);
            this.Controls.Add(this.picAnhBia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormChiTietSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết sách";
            this.Load += new System.EventHandler(this.FormChiTietSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAnhBia)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabThongTin.ResumeLayout(false);
            this.tabThongTin.PerformLayout();
            this.tabDanhGia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picAnhBia;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.Label lblNXB;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabThongTin;
        private System.Windows.Forms.TabPage tabDanhGia;
        private System.Windows.Forms.DataGridView dgvDanhGia;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRating;
    }
}