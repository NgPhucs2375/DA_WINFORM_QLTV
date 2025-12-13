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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnRsFilter = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabLichSu = new System.Windows.Forms.TabPage();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.pnlHistoryHeader = new System.Windows.Forms.Panel();
            this.lblHistoryTitle = new System.Windows.Forms.Label();
            this.tabCaNhan = new System.Windows.Forms.TabPage();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
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
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(20))))); // Dark Brown
            this.pnlSidebar.Controls.Add(this.btnDangXuat);
            this.pnlSidebar.Controls.Add(this.btnNavCaNhan);
            this.pnlSidebar.Controls.Add(this.btnNavLichSu);
            this.pnlSidebar.Controls.Add(this.btnNavTraCuu);
            this.pnlSidebar.Controls.Add(this.panelLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(280, 812);
            this.pnlSidebar.TabIndex = 2;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(15)))), ((int)(((byte)(10)))));
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.Salmon;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 737);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(280, 75);
            this.btnDangXuat.TabIndex = 0;
            this.btnDangXuat.Text = "  🚪  Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnNavCaNhan
            // 
            this.btnNavCaNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavCaNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavCaNhan.FlatAppearance.BorderSize = 0;
            this.btnNavCaNhan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(82)))), ((int)(((byte)(45)))));
            this.btnNavCaNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCaNhan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNavCaNhan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNavCaNhan.Location = new System.Drawing.Point(0, 250);
            this.btnNavCaNhan.Name = "btnNavCaNhan";
            this.btnNavCaNhan.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNavCaNhan.Size = new System.Drawing.Size(280, 75);
            this.btnNavCaNhan.TabIndex = 1;
            this.btnNavCaNhan.Text = "  👤  Thông tin cá nhân";
            this.btnNavCaNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCaNhan.UseVisualStyleBackColor = true;
            this.btnNavCaNhan.Click += new System.EventHandler(this.btnNavCaNhan_Click);
            // 
            // btnNavLichSu
            // 
            this.btnNavLichSu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavLichSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavLichSu.FlatAppearance.BorderSize = 0;
            this.btnNavLichSu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(82)))), ((int)(((byte)(45)))));
            this.btnNavLichSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavLichSu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNavLichSu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNavLichSu.Location = new System.Drawing.Point(0, 175);
            this.btnNavLichSu.Name = "btnNavLichSu";
            this.btnNavLichSu.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNavLichSu.Size = new System.Drawing.Size(280, 75);
            this.btnNavLichSu.TabIndex = 2;
            this.btnNavLichSu.Text = "  🕒  Lịch sử & Yêu cầu";
            this.btnNavLichSu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLichSu.UseVisualStyleBackColor = true;
            this.btnNavLichSu.Click += new System.EventHandler(this.btnNavLichSu_Click);
            // 
            // btnNavTraCuu
            // 
            this.btnNavTraCuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavTraCuu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavTraCuu.FlatAppearance.BorderSize = 0;
            this.btnNavTraCuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(82)))), ((int)(((byte)(45)))));
            this.btnNavTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTraCuu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNavTraCuu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNavTraCuu.Location = new System.Drawing.Point(0, 100);
            this.btnNavTraCuu.Name = "btnNavTraCuu";
            this.btnNavTraCuu.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNavTraCuu.Size = new System.Drawing.Size(280, 75);
            this.btnNavTraCuu.TabIndex = 3;
            this.btnNavTraCuu.Text = "  📖  Tra cứu sách";
            this.btnNavTraCuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavTraCuu.UseVisualStyleBackColor = true;
            this.btnNavTraCuu.Click += new System.EventHandler(this.btnNavTraCuu_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(20)))), ((int)(((byte)(10))))); // Darker Brown
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(280, 100);
            this.panelLogo.TabIndex = 4;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Playfair Display", 18F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(40, 30);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(180, 43);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "THE LIBRARY";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(224))))); // Cream
            this.pnlHeader.Controls.Add(this.lblXinChao);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(280, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1070, 80);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblXinChao
            // 
            this.lblXinChao.AutoSize = true;
            this.lblXinChao.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblXinChao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33))))); // Sienna Text
            this.lblXinChao.Location = new System.Drawing.Point(30, 25);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(212, 32);
            this.lblXinChao.TabIndex = 0;
            this.lblXinChao.Text = "Xin chào, Độc giả";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTraCuu);
            this.tabControl1.Controls.Add(this.tabLichSu);
            this.tabControl1.Controls.Add(this.tabCaNhan);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(280, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1070, 732);
            this.tabControl1.TabIndex = 0;
            // 
            // tabTraCuu
            // 
            this.tabTraCuu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabTraCuu.Controls.Add(this.dgvSach);
            this.tabTraCuu.Controls.Add(this.panelSearch);
            this.tabTraCuu.Location = new System.Drawing.Point(4, 25);
            this.tabTraCuu.Name = "tabTraCuu";
            this.tabTraCuu.Padding = new System.Windows.Forms.Padding(20);
            this.tabTraCuu.Size = new System.Drawing.Size(1062, 703);
            this.tabTraCuu.TabIndex = 0;
            this.tabTraCuu.Text = "Tra cứu";
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(82)))), ((int)(((byte)(45))))); // Sienna Header
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(82)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSach.ColumnHeadersHeight = 45;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(196))))); // Light Peach Selection
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSach.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.EnableHeadersVisualStyles = false;
            this.dgvSach.Location = new System.Drawing.Point(20, 95);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersVisible = false;
            this.dgvSach.RowHeadersWidth = 62;
            this.dgvSach.RowTemplate.Height = 35;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(1022, 588);
            this.dgvSach.TabIndex = 0;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.White;
            this.panelSearch.Controls.Add(this.btnRsFilter);
            this.panelSearch.Controls.Add(this.txtTimKiem);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(20, 20);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1022, 75);
            this.panelSearch.TabIndex = 1;
            // 
            // btnRsFilter
            // 
            this.btnRsFilter.BackColor = System.Drawing.Color.Silver;
            this.btnRsFilter.FlatAppearance.BorderSize = 0;
            this.btnRsFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRsFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRsFilter.ForeColor = System.Drawing.Color.Black;
            this.btnRsFilter.Location = new System.Drawing.Point(680, 20);
            this.btnRsFilter.Name = "btnRsFilter";
            this.btnRsFilter.Size = new System.Drawing.Size(100, 35);
            this.btnRsFilter.TabIndex = 7;
            this.btnRsFilter.Text = "⟳ Reset";
            this.btnRsFilter.UseVisualStyleBackColor = false;
            this.btnRsFilter.Click += new System.EventHandler(this.btnRsFilter_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTimKiem.Location = new System.Drawing.Point(300, 22);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(360, 32);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm sách, chủ đề, tác giả:";
            // 
            // tabLichSu
            // 
            this.tabLichSu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabLichSu.Controls.Add(this.dgvLichSu);
            this.tabLichSu.Controls.Add(this.pnlHistoryHeader);
            this.tabLichSu.Location = new System.Drawing.Point(4, 25);
            this.tabLichSu.Name = "tabLichSu";
            this.tabLichSu.Padding = new System.Windows.Forms.Padding(20);
            this.tabLichSu.Size = new System.Drawing.Size(1062, 703);
            this.tabLichSu.TabIndex = 1;
            this.tabLichSu.Text = "Lịch sử";
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.AllowUserToAddRows = false;
            this.dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSu.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichSu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(82)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichSu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLichSu.ColumnHeadersHeight = 45;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLichSu.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLichSu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichSu.EnableHeadersVisualStyles = false;
            this.dgvLichSu.Location = new System.Drawing.Point(20, 95);
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.RowHeadersVisible = false;
            this.dgvLichSu.RowHeadersWidth = 62;
            this.dgvLichSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichSu.Size = new System.Drawing.Size(1022, 588);
            this.dgvLichSu.TabIndex = 0;
            // 
            // pnlHistoryHeader
            // 
            this.pnlHistoryHeader.BackColor = System.Drawing.Color.White;
            this.pnlHistoryHeader.Controls.Add(this.lblHistoryTitle);
            this.pnlHistoryHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHistoryHeader.Location = new System.Drawing.Point(20, 20);
            this.pnlHistoryHeader.Name = "pnlHistoryHeader";
            this.pnlHistoryHeader.Size = new System.Drawing.Size(1022, 75);
            this.pnlHistoryHeader.TabIndex = 1;
            // 
            // lblHistoryTitle
            // 
            this.lblHistoryTitle.AutoSize = true;
            this.lblHistoryTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHistoryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.lblHistoryTitle.Location = new System.Drawing.Point(20, 20);
            this.lblHistoryTitle.Name = "lblHistoryTitle";
            this.lblHistoryTitle.Size = new System.Drawing.Size(404, 32);
            this.lblHistoryTitle.TabIndex = 0;
            this.lblHistoryTitle.Text = "Lịch sử mượn & Trạng thái yêu cầu";
            // 
            // tabCaNhan
            // 
            this.tabCaNhan.BackColor = System.Drawing.Color.White;
            this.tabCaNhan.Controls.Add(this.groupBoxInfo);
            this.tabCaNhan.Controls.Add(this.lblTitleCaNhan);
            this.tabCaNhan.Location = new System.Drawing.Point(4, 25);
            this.tabCaNhan.Name = "tabCaNhan";
            this.tabCaNhan.Padding = new System.Windows.Forms.Padding(50);
            this.tabCaNhan.Size = new System.Drawing.Size(1062, 703);
            this.tabCaNhan.TabIndex = 2;
            this.tabCaNhan.Text = "Cá nhân";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(237)))));
            this.groupBoxInfo.Controls.Add(this.lblName);
            this.groupBoxInfo.Controls.Add(this.lblHanThe);
            this.groupBoxInfo.Controls.Add(this.lblEmail);
            this.groupBoxInfo.Controls.Add(this.lblPhone);
            this.groupBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBoxInfo.Location = new System.Drawing.Point(50, 100);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(962, 553);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.lblName.Location = new System.Drawing.Point(50, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(109, 37);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Họ tên:";
            // 
            // lblHanThe
            // 
            this.lblHanThe.AutoSize = true;
            this.lblHanThe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHanThe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(92)))), ((int)(((byte)(92))))); // Indian Red
            this.lblHanThe.Location = new System.Drawing.Point(50, 230);
            this.lblHanThe.Name = "lblHanThe";
            this.lblHanThe.Size = new System.Drawing.Size(111, 32);
            this.lblHanThe.TabIndex = 0;
            this.lblHanThe.Text = "Hạn thẻ:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(50, 110);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(64, 28);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(50, 170);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(51, 28);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "SĐT:";
            // 
            // lblTitleCaNhan
            // 
            this.lblTitleCaNhan.AutoSize = true;
            this.lblTitleCaNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleCaNhan.Font = new System.Drawing.Font("Playfair Display", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitleCaNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.lblTitleCaNhan.Location = new System.Drawing.Point(50, 50);
            this.lblTitleCaNhan.Name = "lblTitleCaNhan";
            this.lblTitleCaNhan.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.lblTitleCaNhan.Size = new System.Drawing.Size(351, 77);
            this.lblTitleCaNhan.TabIndex = 1;
            this.lblTitleCaNhan.Text = "HỒ SƠ CỦA TÔI";
            // 
            // FormDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 812);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "FormDG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thư Viện Số - Độc Giả";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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

        // Controls giữ nguyên tên như cũ
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
        private System.Windows.Forms.Button btnRsFilter;
        private System.Windows.Forms.Label lblName;
    }
}