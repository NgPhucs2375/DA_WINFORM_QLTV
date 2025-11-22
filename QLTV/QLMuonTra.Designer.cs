namespace QLTV
{
    partial class QLMuonTra
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
            this.btnTabTra = new System.Windows.Forms.Button();
            this.btnTabMuon = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlMuonContent = new System.Windows.Forms.Panel();
            this.dgvDSMuon = new System.Windows.Forms.DataGridView();
            this.pnlMuonAction = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnThemPhieu = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlTraContent = new System.Windows.Forms.Panel();
            this.dgvDSTra = new System.Windows.Forms.DataGridView();
            this.pnlTraAction = new System.Windows.Forms.Panel();
            this.btnLapPhieuTra = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlMuonContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMuon)).BeginInit();
            this.pnlMuonAction.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlTraContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTra)).BeginInit();
            this.pnlTraAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader (THANH ĐIỀU HƯỚNG TRÊN CÙNG)
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100))))); // Đen trong suốt
            this.pnlHeader.Controls.Add(this.btnTabTra);
            this.pnlHeader.Controls.Add(this.btnTabMuon);
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
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(333, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ MƯỢN - TRẢ";
            // 
            // btnTabMuon
            // 
            this.btnTabMuon.BackColor = System.Drawing.Color.Transparent;
            this.btnTabMuon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabMuon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTabMuon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTabMuon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTabMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabMuon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTabMuon.ForeColor = System.Drawing.Color.White;
            this.btnTabMuon.Location = new System.Drawing.Point(400, 15);
            this.btnTabMuon.Name = "btnTabMuon";
            this.btnTabMuon.Size = new System.Drawing.Size(200, 40);
            this.btnTabMuon.TabIndex = 1;
            this.btnTabMuon.Text = "DANH SÁCH MƯỢN";
            this.btnTabMuon.UseVisualStyleBackColor = false;
            this.btnTabMuon.Click += new System.EventHandler(this.btnTabMuon_Click);
            // 
            // btnTabTra
            // 
            this.btnTabTra.BackColor = System.Drawing.Color.Transparent;
            this.btnTabTra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabTra.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTabTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabTra.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTabTra.ForeColor = System.Drawing.Color.White;
            this.btnTabTra.Location = new System.Drawing.Point(620, 15);
            this.btnTabTra.Name = "btnTabTra";
            this.btnTabTra.Size = new System.Drawing.Size(200, 40);
            this.btnTabTra.TabIndex = 2;
            this.btnTabTra.Text = "LỊCH SỬ TRẢ";
            this.btnTabTra.UseVisualStyleBackColor = false;
            this.btnTabTra.Click += new System.EventHandler(this.btnTabTra_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1100, 530);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1 (TAB QUẢN LÝ MƯỢN)
            // 
            this.tabPage1.BackgroundImage = global::QLTV.Properties.Resources.bookstorebg2; // Sử dụng lại ảnh nền
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.pnlMuonContent);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(20);
            this.tabPage1.Size = new System.Drawing.Size(1092, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Muon";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlMuonContent (Container trong suốt chứa nội dung)
            // 
            this.pnlMuonContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))); // Màu trắng hơi trong suốt
            this.pnlMuonContent.Controls.Add(this.dgvDSMuon);
            this.pnlMuonContent.Controls.Add(this.pnlMuonAction);
            this.pnlMuonContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMuonContent.Location = new System.Drawing.Point(20, 20);
            this.pnlMuonContent.Name = "pnlMuonContent";
            this.pnlMuonContent.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMuonContent.Size = new System.Drawing.Size(1052, 461);
            this.pnlMuonContent.TabIndex = 0;
            // 
            // pnlMuonAction
            // 
            this.pnlMuonAction.BackColor = System.Drawing.Color.White;
            this.pnlMuonAction.Controls.Add(this.btnTimKiem);
            this.pnlMuonAction.Controls.Add(this.txtTimKiem);
            this.pnlMuonAction.Controls.Add(this.btnThemPhieu);
            this.pnlMuonAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMuonAction.Location = new System.Drawing.Point(10, 10);
            this.pnlMuonAction.Name = "pnlMuonAction";
            this.pnlMuonAction.Size = new System.Drawing.Size(1032, 60);
            this.pnlMuonAction.TabIndex = 0;
            // 
            // btnThemPhieu
            // 
            this.btnThemPhieu.BackColor = System.Drawing.Color.SeaGreen;
            this.btnThemPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPhieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemPhieu.ForeColor = System.Drawing.Color.White;
            this.btnThemPhieu.Location = new System.Drawing.Point(10, 10);
            this.btnThemPhieu.Name = "btnThemPhieu";
            this.btnThemPhieu.Size = new System.Drawing.Size(180, 40);
            this.btnThemPhieu.TabIndex = 0;
            this.btnThemPhieu.Text = "+ LẬP PHIẾU MƯỢN";
            this.btnThemPhieu.UseVisualStyleBackColor = false;
            this.btnThemPhieu.Click += new System.EventHandler(this.btnThemPhieu_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTimKiem.Location = new System.Drawing.Point(650, 13);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(250, 34);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(910, 13);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 34);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvDSMuon
            // 
            this.dgvDSMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSMuon.Location = new System.Drawing.Point(10, 70);
            this.dgvDSMuon.Name = "dgvDSMuon";
            this.dgvDSMuon.Size = new System.Drawing.Size(1032, 381);
            this.dgvDSMuon.TabIndex = 1;
            // 
            // tabPage2 (TAB QUẢN LÝ TRẢ)
            // 
            this.tabPage2.BackgroundImage = global::QLTV.Properties.Resources.bookstorebg2;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.pnlTraContent);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(20);
            this.tabPage2.Size = new System.Drawing.Size(1092, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tra";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlTraContent
            // 
            this.pnlTraContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlTraContent.Controls.Add(this.dgvDSTra);
            this.pnlTraContent.Controls.Add(this.pnlTraAction);
            this.pnlTraContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTraContent.Location = new System.Drawing.Point(20, 20);
            this.pnlTraContent.Name = "pnlTraContent";
            this.pnlTraContent.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTraContent.Size = new System.Drawing.Size(1052, 461);
            this.pnlTraContent.TabIndex = 0;
            // 
            // pnlTraAction
            // 
            this.pnlTraAction.BackColor = System.Drawing.Color.White;
            this.pnlTraAction.Controls.Add(this.btnLapPhieuTra);
            this.pnlTraAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTraAction.Location = new System.Drawing.Point(10, 10);
            this.pnlTraAction.Name = "pnlTraAction";
            this.pnlTraAction.Size = new System.Drawing.Size(1032, 60);
            this.pnlTraAction.TabIndex = 0;
            // 
            // btnLapPhieuTra
            // 
            this.btnLapPhieuTra.BackColor = System.Drawing.Color.Chocolate;
            this.btnLapPhieuTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapPhieuTra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLapPhieuTra.ForeColor = System.Drawing.Color.White;
            this.btnLapPhieuTra.Location = new System.Drawing.Point(10, 10);
            this.btnLapPhieuTra.Name = "btnLapPhieuTra";
            this.btnLapPhieuTra.Size = new System.Drawing.Size(180, 40);
            this.btnLapPhieuTra.TabIndex = 0;
            this.btnLapPhieuTra.Text = "LẬP PHIẾU TRẢ";
            this.btnLapPhieuTra.UseVisualStyleBackColor = false;
            this.btnLapPhieuTra.Click += new System.EventHandler(this.btnLapPhieuTra_Click);
            // 
            // dgvDSTra
            // 
            this.dgvDSTra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSTra.Location = new System.Drawing.Point(10, 70);
            this.dgvDSTra.Name = "dgvDSTra";
            this.dgvDSTra.Size = new System.Drawing.Size(1032, 381);
            this.dgvDSTra.TabIndex = 1;
            // 
            // QLMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLTV.Properties.Resources.bookstorebg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlHeader);
            this.DoubleBuffered = true;
            this.Name = "QLMuonTra";
            this.Text = "Quản lý Mượn Trả";
            this.Load += new System.EventHandler(this.QLMuonTra_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlMuonContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMuon)).EndInit();
            this.pnlMuonAction.ResumeLayout(false);
            this.pnlMuonAction.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pnlTraContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTra)).EndInit();
            this.pnlTraAction.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnTabMuon;
        private System.Windows.Forms.Button btnTabTra;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlMuonContent;
        private System.Windows.Forms.DataGridView dgvDSMuon;
        private System.Windows.Forms.Panel pnlMuonAction;
        private System.Windows.Forms.Button btnThemPhieu;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel pnlTraContent;
        private System.Windows.Forms.DataGridView dgvDSTra;
        private System.Windows.Forms.Panel pnlTraAction;
        private System.Windows.Forms.Button btnLapPhieuTra;
    }
}