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
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyle = new System.Windows.Forms.DataGridViewCellStyle();

            // Init Controls
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
            
            // Tab Tra Cứu
            this.tabTraCuu = new System.Windows.Forms.TabPage();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            
            // Tab Lịch Sử
            this.tabLichSu = new System.Windows.Forms.TabPage();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.pnlHistoryHeader = new System.Windows.Forms.Panel();
            this.lblHistoryTitle = new System.Windows.Forms.Label();

            // Tab Cá Nhân
            this.tabCaNhan = new System.Windows.Forms.TabPage();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.lblHanThe = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
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
            this.pnlHistoryHeader.SuspendLayout();
            this.tabCaNhan.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();

            // --- STYLE CHUNG CHO DATAGRIDVIEW ---
            headerStyle.BackColor = System.Drawing.Color.FromArgb(46, 204, 113); // SeaGreen sáng
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            headerStyle.SelectionBackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            
            cellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            cellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(236, 240, 241); // Màu xám nhạt khi chọn
            cellStyle.SelectionForeColor = System.Drawing.Color.Black;

            // --- 1. SIDEBAR (TRÁI) ---
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(44, 62, 80); // Midnight Blue
            this.pnlSidebar.Controls.Add(this.btnDangXuat);
            this.pnlSidebar.Controls.Add(this.btnNavCaNhan);
            this.pnlSidebar.Controls.Add(this.btnNavLichSu);
            this.pnlSidebar.Controls.Add(this.btnNavTraCuu);
            this.pnlSidebar.Controls.Add(this.panelLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Size = new System.Drawing.Size(240, 650);

            // Logo Area
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(34, 49, 63);
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Size = new System.Drawing.Size(240, 80);

            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(45, 20);
            this.lblLogo.Text = "LIBRARY";

            // Buttons Navigation
            this.btnNavTraCuu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavTraCuu.FlatAppearance.BorderSize = 0;
            this.btnNavTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTraCuu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNavTraCuu.ForeColor = System.Drawing.Color.White;
            this.btnNavTraCuu.Location = new System.Drawing.Point(0, 80);
            this.btnNavTraCuu.Height = 60;
            this.btnNavTraCuu.Text = "   📖  Tra cứu sách";
            this.btnNavTraCuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavTraCuu.Click += new System.EventHandler(this.btnNavTraCuu_Click);

            this.btnNavLichSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavLichSu.FlatAppearance.BorderSize = 0;
            this.btnNavLichSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavLichSu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNavLichSu.ForeColor = System.Drawing.Color.White;
            this.btnNavLichSu.Location = new System.Drawing.Point(0, 140);
            this.btnNavLichSu.Height = 60;
            this.btnNavLichSu.Text = "   clock  Lịch sử & Yêu cầu";
            this.btnNavLichSu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLichSu.Click += new System.EventHandler(this.btnNavLichSu_Click);

            this.btnNavCaNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavCaNhan.FlatAppearance.BorderSize = 0;
            this.btnNavCaNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCaNhan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNavCaNhan.ForeColor = System.Drawing.Color.White;
            this.btnNavCaNhan.Location = new System.Drawing.Point(0, 200);
            this.btnNavCaNhan.Height = 60;
            this.btnNavCaNhan.Text = "   user  Thông tin cá nhân";
            this.btnNavCaNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCaNhan.Click += new System.EventHandler(this.btnNavCaNhan_Click);

            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDangXuat.ForeColor = System.Drawing.Color.Silver;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 590);
            this.btnDangXuat.Height = 60;
            this.btnDangXuat.Text = "   🚪  Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);

            // --- 2. HEADER (TRÊN) ---
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblXinChao);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 80;

            this.lblXinChao.AutoSize = true;
            this.lblXinChao.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblXinChao.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblXinChao.Location = new System.Drawing.Point(30, 25);
            this.lblXinChao.Text = "Xin chào, Độc giả";

            // --- 3. MAIN CONTENT (TABLESS) ---
            this.tabControl1.Controls.Add(this.tabTraCuu);
            this.tabControl1.Controls.Add(this.tabLichSu);
            this.tabControl1.Controls.Add(this.tabCaNhan);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(240, 80);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 570);

            // --- TAB 1: TRA CỨU ---
            this.tabTraCuu.Controls.Add(this.dgvSach);
            this.tabTraCuu.Controls.Add(this.panelSearch);
            this.tabTraCuu.Location = new System.Drawing.Point(4, 25);
            this.tabTraCuu.Padding = new System.Windows.Forms.Padding(20);
            this.tabTraCuu.Text = "Tra cứu";
            this.tabTraCuu.BackColor = System.Drawing.Color.WhiteSmoke;

            // Search Bar
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Height = 60;
            this.panelSearch.Controls.Add(this.txtTimKiem);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.BackColor = System.Drawing.Color.White;

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Text = "Tìm kiếm sách:";

            this.txtTimKiem.Location = new System.Drawing.Point(140, 15);
            this.txtTimKiem.Size = new System.Drawing.Size(400, 30);
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);

            // Grid Sách
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSach.ColumnHeadersHeight = 45;
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.RowHeadersVisible = false;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvSach.DefaultCellStyle = cellStyle;
            this.dgvSach.EnableHeadersVisualStyles = false;
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // --- TAB 2: LỊCH SỬ ---
            this.tabLichSu.Controls.Add(this.dgvLichSu);
            this.tabLichSu.Controls.Add(this.pnlHistoryHeader);
            this.tabLichSu.Location = new System.Drawing.Point(4, 25);
            this.tabLichSu.Text = "Lịch sử";
            this.tabLichSu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabLichSu.Padding = new System.Windows.Forms.Padding(20);

            this.pnlHistoryHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHistoryHeader.Height = 60;
            this.pnlHistoryHeader.BackColor = System.Drawing.Color.White;
            this.pnlHistoryHeader.Controls.Add(this.lblHistoryTitle);

            this.lblHistoryTitle.AutoSize = true;
            this.lblHistoryTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHistoryTitle.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblHistoryTitle.Location = new System.Drawing.Point(20, 15);
            this.lblHistoryTitle.Text = "Trạng thái yêu cầu & Lịch sử mượn";

            this.dgvLichSu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichSu.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichSu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLichSu.ColumnHeadersHeight = 45;
            this.dgvLichSu.AllowUserToAddRows = false;
            this.dgvLichSu.RowHeadersVisible = false;
            this.dgvLichSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichSu.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvLichSu.DefaultCellStyle = cellStyle;
            this.dgvLichSu.EnableHeadersVisualStyles = false;
            this.dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // --- TAB 3: CÁ NHÂN ---
            this.tabCaNhan.Controls.Add(this.groupBoxInfo);
            this.tabCaNhan.Controls.Add(this.lblTitleCaNhan);
            this.tabCaNhan.Location = new System.Drawing.Point(4, 25);
            this.tabCaNhan.Text = "Cá nhân";
            this.tabCaNhan.BackColor = System.Drawing.Color.White;
            this.tabCaNhan.Padding = new System.Windows.Forms.Padding(40);

            this.lblTitleCaNhan.AutoSize = true;
            this.lblTitleCaNhan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitleCaNhan.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitleCaNhan.Location = new System.Drawing.Point(40, 40);
            this.lblTitleCaNhan.Text = "HỒ SƠ CỦA TÔI";

            this.groupBoxInfo.Controls.Add(this.lblHanThe);
            this.groupBoxInfo.Controls.Add(this.lblEmail);
            this.groupBoxInfo.Controls.Add(this.lblPhone);
            this.groupBoxInfo.Location = new System.Drawing.Point(47, 100);
            this.groupBoxInfo.Size = new System.Drawing.Size(600, 300);
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.groupBoxInfo.Text = "Thông tin chi tiết";

            this.lblEmail.Location = new System.Drawing.Point(40, 60);
            this.lblEmail.AutoSize = true;
            this.lblEmail.Text = "Email: ...";

            this.lblPhone.Location = new System.Drawing.Point(40, 110);
            this.lblPhone.AutoSize = true;
            this.lblPhone.Text = "SĐT: ...";

            this.lblHanThe.Location = new System.Drawing.Point(40, 160);
            this.lblHanThe.AutoSize = true;
            this.lblHanThe.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblHanThe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHanThe.Text = "Hạn thẻ: ...";

            // --- FORM SETTINGS ---
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "FormDG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thư Viện Số - Độc Giả";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.pnlHistoryHeader.ResumeLayout(false);
            this.pnlHistoryHeader.PerformLayout();
            this.tabCaNhan.ResumeLayout(false);
            this.tabCaNhan.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        // Controls
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
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabLichSu;
        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.Panel pnlHistoryHeader;
        private System.Windows.Forms.Label lblHistoryTitle;
        private System.Windows.Forms.TabPage tabCaNhan;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label lblHanThe;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblTitleCaNhan;
    }
}