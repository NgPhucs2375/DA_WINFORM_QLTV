namespace QLTV
{
    partial class FormDG
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnNavCaNhan = new System.Windows.Forms.Button();
            this.btnNavLichSu = new System.Windows.Forms.Button();
            this.btnNavTraCuu = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblXinChao = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTraCuu = new System.Windows.Forms.TabPage();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabLichSu = new System.Windows.Forms.TabPage();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.lblTitleLichSu = new System.Windows.Forms.Label();
            this.tabCaNhan = new System.Windows.Forms.TabPage();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.lblHanThe = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTitleCaNhan = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTraCuu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.tabLichSu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.tabCaNhan.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar (MENU TRÁI)
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlSidebar.Controls.Add(this.btnDangXuat);
            this.pnlSidebar.Controls.Add(this.btnNavCaNhan);
            this.pnlSidebar.Controls.Add(this.btnNavLichSu);
            this.pnlSidebar.Controls.Add(this.btnNavTraCuu);
            this.pnlSidebar.Controls.Add(this.panelLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 600);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.Silver;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 550);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(220, 50);
            this.btnDangXuat.TabIndex = 4;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnNavCaNhan
            // 
            this.btnNavCaNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavCaNhan.FlatAppearance.BorderSize = 0;
            this.btnNavCaNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCaNhan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNavCaNhan.ForeColor = System.Drawing.Color.White;
            this.btnNavCaNhan.Location = new System.Drawing.Point(0, 180);
            this.btnNavCaNhan.Name = "btnNavCaNhan";
            this.btnNavCaNhan.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavCaNhan.Size = new System.Drawing.Size(220, 50);
            this.btnNavCaNhan.TabIndex = 3;
            this.btnNavCaNhan.Text = "Thông tin cá nhân";
            this.btnNavCaNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCaNhan.UseVisualStyleBackColor = true;
            this.btnNavCaNhan.Click += new System.EventHandler(this.btnNavCaNhan_Click);
            // 
            // btnNavLichSu
            // 
            this.btnNavLichSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavLichSu.FlatAppearance.BorderSize = 0;
            this.btnNavLichSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavLichSu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNavLichSu.ForeColor = System.Drawing.Color.White;
            this.btnNavLichSu.Location = new System.Drawing.Point(0, 130);
            this.btnNavLichSu.Name = "btnNavLichSu";
            this.btnNavLichSu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavLichSu.Size = new System.Drawing.Size(220, 50);
            this.btnNavLichSu.TabIndex = 2;
            this.btnNavLichSu.Text = "Lịch sử mượn";
            this.btnNavLichSu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLichSu.UseVisualStyleBackColor = true;
            this.btnNavLichSu.Click += new System.EventHandler(this.btnNavLichSu_Click);
            // 
            // btnNavTraCuu
            // 
            this.btnNavTraCuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnNavTraCuu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavTraCuu.FlatAppearance.BorderSize = 0;
            this.btnNavTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTraCuu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNavTraCuu.ForeColor = System.Drawing.Color.White;
            this.btnNavTraCuu.Location = new System.Drawing.Point(0, 80);
            this.btnNavTraCuu.Name = "btnNavTraCuu";
            this.btnNavTraCuu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavTraCuu.Size = new System.Drawing.Size(220, 50);
            this.btnNavTraCuu.TabIndex = 1;
            this.btnNavTraCuu.Text = "Tra cứu sách";
            this.btnNavTraCuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavTraCuu.UseVisualStyleBackColor = false;
            this.btnNavTraCuu.Click += new System.EventHandler(this.btnNavTraCuu_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(40, 22);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(132, 37);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "E-Reader";
            // 
            // pnlHeader (HEADER TRÊN)
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblXinChao);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(220, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(780, 60);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblXinChao
            // 
            this.lblXinChao.AutoSize = true;
            this.lblXinChao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblXinChao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblXinChao.Location = new System.Drawing.Point(20, 18);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(173, 28);
            this.lblXinChao.TabIndex = 0;
            this.lblXinChao.Text = "Xin chào, Độc giả";
            // 
            // tabControl1 (MAIN CONTENT)
            // 
            this.tabControl1.Controls.Add(this.tabTraCuu);
            this.tabControl1.Controls.Add(this.tabLichSu);
            this.tabControl1.Controls.Add(this.tabCaNhan);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Location = new System.Drawing.Point(220, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 540);
            this.tabControl1.TabIndex = 2;
            // 
            // tabTraCuu
            // 
            this.tabTraCuu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabTraCuu.Controls.Add(this.dgvSach);
            this.tabTraCuu.Controls.Add(this.panelSearch);
            this.tabTraCuu.Location = new System.Drawing.Point(4, 32);
            this.tabTraCuu.Name = "tabTraCuu";
            this.tabTraCuu.Padding = new System.Windows.Forms.Padding(20);
            this.tabTraCuu.Size = new System.Drawing.Size(772, 504);
            this.tabTraCuu.TabIndex = 0;
            this.tabTraCuu.Text = "Tra cứu";
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.White;
            this.panelSearch.Controls.Add(this.txtTimKiem);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(20, 20);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(732, 60);
            this.panelSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên sách/tác giả:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTimKiem.Location = new System.Drawing.Point(190, 15);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(400, 32);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSach.ColumnHeadersHeight = 40;
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.EnableHeadersVisualStyles = false;
            this.dgvSach.GridColor = System.Drawing.Color.LightGray;
            this.dgvSach.Location = new System.Drawing.Point(20, 80);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.RowHeadersVisible = false;
            this.dgvSach.RowTemplate.Height = 30;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(732, 404);
            this.dgvSach.TabIndex = 1;
            // 
            // tabLichSu
            // 
            this.tabLichSu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabLichSu.Controls.Add(this.dgvLichSu);
            this.tabLichSu.Controls.Add(this.lblTitleLichSu);
            this.tabLichSu.Location = new System.Drawing.Point(4, 32);
            this.tabLichSu.Name = "tabLichSu";
            this.tabLichSu.Padding = new System.Windows.Forms.Padding(20);
            this.tabLichSu.Size = new System.Drawing.Size(772, 504);
            this.tabLichSu.TabIndex = 1;
            this.tabLichSu.Text = "Lịch sử";
            // 
            // lblTitleLichSu
            // 
            this.lblTitleLichSu.AutoSize = true;
            this.lblTitleLichSu.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitleLichSu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitleLichSu.Location = new System.Drawing.Point(20, 20);
            this.lblTitleLichSu.Name = "lblTitleLichSu";
            this.lblTitleLichSu.Size = new System.Drawing.Size(264, 37);
            this.lblTitleLichSu.TabIndex = 0;
            this.lblTitleLichSu.Text = "Lịch sử mượn sách";
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.AllowUserToAddRows = false;
            this.dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSu.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichSu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLichSu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLichSu.ColumnHeadersHeight = 40;
            this.dgvLichSu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLichSu.EnableHeadersVisualStyles = false;
            this.dgvLichSu.Location = new System.Drawing.Point(20, 80);
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.ReadOnly = true;
            this.dgvLichSu.RowHeadersVisible = false;
            this.dgvLichSu.RowTemplate.Height = 30;
            this.dgvLichSu.Size = new System.Drawing.Size(732, 404);
            this.dgvLichSu.TabIndex = 1;
            // 
            // tabCaNhan
            // 
            this.tabCaNhan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCaNhan.Controls.Add(this.groupBoxInfo);
            this.tabCaNhan.Controls.Add(this.lblTitleCaNhan);
            this.tabCaNhan.Location = new System.Drawing.Point(4, 32);
            this.tabCaNhan.Name = "tabCaNhan";
            this.tabCaNhan.Padding = new System.Windows.Forms.Padding(40);
            this.tabCaNhan.Size = new System.Drawing.Size(772, 504);
            this.tabCaNhan.TabIndex = 2;
            this.tabCaNhan.Text = "Cá nhân";
            // 
            // lblTitleCaNhan
            // 
            this.lblTitleCaNhan.AutoSize = true;
            this.lblTitleCaNhan.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitleCaNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitleCaNhan.Location = new System.Drawing.Point(40, 40);
            this.lblTitleCaNhan.Name = "lblTitleCaNhan";
            this.lblTitleCaNhan.Size = new System.Drawing.Size(247, 37);
            this.lblTitleCaNhan.TabIndex = 0;
            this.lblTitleCaNhan.Text = "Thông tin cá nhân";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.BackColor = System.Drawing.Color.White;
            this.groupBoxInfo.Controls.Add(this.btnDoiMatKhau);
            this.groupBoxInfo.Controls.Add(this.lblHanThe);
            this.groupBoxInfo.Controls.Add(this.lblEmail);
            this.groupBoxInfo.Location = new System.Drawing.Point(47, 100);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(600, 250);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEmail.Location = new System.Drawing.Point(40, 50);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 28);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // lblHanThe
            // 
            this.lblHanThe.AutoSize = true;
            this.lblHanThe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblHanThe.Location = new System.Drawing.Point(40, 100);
            this.lblHanThe.Name = "lblHanThe";
            this.lblHanThe.Size = new System.Drawing.Size(84, 28);
            this.lblHanThe.TabIndex = 1;
            this.lblHanThe.Text = "Hạn thẻ:";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(45, 160);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(180, 45);
            this.btnDoiMatKhau.TabIndex = 2;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // FormDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "FormDG";
            this.Text = "E-Reader Dashboard";
            this.Load += new System.EventHandler(this.FormDG_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabTraCuu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.tabLichSu.ResumeLayout(false);
            this.tabLichSu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.tabCaNhan.ResumeLayout(false);
            this.tabCaNhan.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnNavTraCuu;
        private System.Windows.Forms.Button btnNavLichSu;
        private System.Windows.Forms.Button btnNavCaNhan;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblXinChao;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTraCuu;
        private System.Windows.Forms.TabPage tabLichSu;
        private System.Windows.Forms.TabPage tabCaNhan;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Label lblTitleLichSu;
        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.Label lblTitleCaNhan;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblHanThe;
        private System.Windows.Forms.Button btnDoiMatKhau;
    }
}