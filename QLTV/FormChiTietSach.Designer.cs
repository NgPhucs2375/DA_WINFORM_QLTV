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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhBia)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabThongTin.SuspendLayout();
            this.tabDanhGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhGia)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // picAnhBia
            // 
            this.picAnhBia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picAnhBia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhBia.Location = new System.Drawing.Point(20, 20);
            this.picAnhBia.Name = "picAnhBia";
            this.picAnhBia.Size = new System.Drawing.Size(220, 320);
            this.picAnhBia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnhBia.TabIndex = 0;
            this.picAnhBia.TabStop = false;
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTenSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.lblTenSach.Location = new System.Drawing.Point(260, 15);
            this.lblTenSach.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(187, 46);
            this.lblTenSach.TabIndex = 1;
            this.lblTenSach.Text = "TÊN SÁCH";
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.lblTacGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTacGia.Location = new System.Drawing.Point(265, 65);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(77, 28);
            this.lblTacGia.TabIndex = 2;
            this.lblTacGia.Text = "Tác giả:";
            // 
            // lblNXB
            // 
            this.lblNXB.AutoSize = true;
            this.lblNXB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNXB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNXB.Location = new System.Drawing.Point(15, 20);
            this.lblNXB.Name = "lblNXB";
            this.lblNXB.Size = new System.Drawing.Size(117, 23);
            this.lblNXB.TabIndex = 0;
            this.lblNXB.Text = "Nhà xuất bản:";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTheLoai.Location = new System.Drawing.Point(15, 55);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(74, 23);
            this.lblTheLoai.TabIndex = 1;
            this.lblTheLoai.Text = "Thể loại:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(247)))));
            this.txtMoTa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMoTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMoTa.Location = new System.Drawing.Point(19, 90);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ReadOnly = true;
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTa.Size = new System.Drawing.Size(460, 160);
            this.txtMoTa.TabIndex = 2;
            this.txtMoTa.Text = "Mô tả sách...";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabThongTin);
            this.tabControl1.Controls.Add(this.tabDanhGia);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Location = new System.Drawing.Point(260, 140);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(500, 300);
            this.tabControl1.TabIndex = 4;
            // 
            // tabThongTin
            // 
            this.tabThongTin.BackColor = System.Drawing.Color.White;
            this.tabThongTin.Controls.Add(this.txtMoTa);
            this.tabThongTin.Controls.Add(this.lblNXB);
            this.tabThongTin.Controls.Add(this.lblTheLoai);
            this.tabThongTin.Location = new System.Drawing.Point(4, 32);
            this.tabThongTin.Name = "tabThongTin";
            this.tabThongTin.Padding = new System.Windows.Forms.Padding(10);
            this.tabThongTin.Size = new System.Drawing.Size(492, 264);
            this.tabThongTin.TabIndex = 0;
            this.tabThongTin.Text = "Thông tin chi tiết";
            // 
            // tabDanhGia
            // 
            this.tabDanhGia.BackColor = System.Drawing.Color.White;
            this.tabDanhGia.Controls.Add(this.dgvDanhGia);
            this.tabDanhGia.Location = new System.Drawing.Point(4, 32);
            this.tabDanhGia.Name = "tabDanhGia";
            this.tabDanhGia.Padding = new System.Windows.Forms.Padding(3);
            this.tabDanhGia.Size = new System.Drawing.Size(492, 264);
            this.tabDanhGia.TabIndex = 1;
            this.tabDanhGia.Text = "Đánh giá & Bình luận";
            // 
            // dgvDanhGia
            // 
            this.dgvDanhGia.AllowUserToAddRows = false;
            this.dgvDanhGia.AllowUserToResizeRows = false;
            this.dgvDanhGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhGia.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(82)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhGia.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhGia.EnableHeadersVisualStyles = false;
            this.dgvDanhGia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDanhGia.Location = new System.Drawing.Point(3, 3);
            this.dgvDanhGia.Name = "dgvDanhGia";
            this.dgvDanhGia.ReadOnly = true;
            this.dgvDanhGia.RowHeadersVisible = false;
            this.dgvDanhGia.RowHeadersWidth = 51;
            this.dgvDanhGia.RowTemplate.Height = 30;
            this.dgvDanhGia.Size = new System.Drawing.Size(486, 258);
            this.dgvDanhGia.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(658, 455);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 40);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblRating.ForeColor = System.Drawing.Color.Orange;
            this.lblRating.Location = new System.Drawing.Point(263, 98);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(90, 37);
            this.lblRating.TabIndex = 3;
            this.lblRating.Text = "★ 0.0";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(782, 50);
            this.pnlHeader.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT SÁCH";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.panelContent.Controls.Add(this.picAnhBia);
            this.panelContent.Controls.Add(this.lblTenSach);
            this.panelContent.Controls.Add(this.btnClose);
            this.panelContent.Controls.Add(this.lblTacGia);
            this.panelContent.Controls.Add(this.tabControl1);
            this.panelContent.Controls.Add(this.lblRating);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 50);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(782, 503);
            this.panelContent.TabIndex = 7;
            // 
            // FormChiTietSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContent;
    }
}