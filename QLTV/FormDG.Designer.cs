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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblHanThe = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblTitleCaNhan = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
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
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlSidebar.Controls.Add(this.btnDangXuat);
            this.pnlSidebar.Controls.Add(this.btnNavCaNhan);
            this.pnlSidebar.Controls.Add(this.btnNavLichSu);
            this.pnlSidebar.Controls.Add(this.btnNavTraCuu);
            this.pnlSidebar.Controls.Add(this.panelLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(270, 812);
            this.pnlSidebar.TabIndex = 2;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDangXuat.ForeColor = System.Drawing.Color.Silver;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 737);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(270, 75);
            this.btnDangXuat.TabIndex = 0;
            this.btnDangXuat.Text = "   🚪  Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnNavCaNhan
            // 
            this.btnNavCaNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavCaNhan.FlatAppearance.BorderSize = 0;
            this.btnNavCaNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCaNhan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNavCaNhan.ForeColor = System.Drawing.Color.White;
            this.btnNavCaNhan.Location = new System.Drawing.Point(0, 250);
            this.btnNavCaNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNavCaNhan.Name = "btnNavCaNhan";
            this.btnNavCaNhan.Size = new System.Drawing.Size(270, 75);
            this.btnNavCaNhan.TabIndex = 1;
            this.btnNavCaNhan.Text = "   user  Thông tin cá nhân";
            this.btnNavCaNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCaNhan.Click += new System.EventHandler(this.btnNavCaNhan_Click);
            // 
            // btnNavLichSu
            // 
            this.btnNavLichSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavLichSu.FlatAppearance.BorderSize = 0;
            this.btnNavLichSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavLichSu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNavLichSu.ForeColor = System.Drawing.Color.White;
            this.btnNavLichSu.Location = new System.Drawing.Point(0, 175);
            this.btnNavLichSu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNavLichSu.Name = "btnNavLichSu";
            this.btnNavLichSu.Size = new System.Drawing.Size(270, 75);
            this.btnNavLichSu.TabIndex = 2;
            this.btnNavLichSu.Text = "   clock  Lịch sử & Yêu cầu";
            this.btnNavLichSu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLichSu.Click += new System.EventHandler(this.btnNavLichSu_Click);
            // 
            // btnNavTraCuu
            // 
            this.btnNavTraCuu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavTraCuu.FlatAppearance.BorderSize = 0;
            this.btnNavTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTraCuu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNavTraCuu.ForeColor = System.Drawing.Color.White;
            this.btnNavTraCuu.Location = new System.Drawing.Point(0, 100);
            this.btnNavTraCuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNavTraCuu.Name = "btnNavTraCuu";
            this.btnNavTraCuu.Size = new System.Drawing.Size(270, 75);
            this.btnNavTraCuu.TabIndex = 3;
            this.btnNavTraCuu.Text = "   📖  Tra cứu sách";
            this.btnNavTraCuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavTraCuu.Click += new System.EventHandler(this.btnNavTraCuu_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(270, 100);
            this.panelLogo.TabIndex = 4;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(51, 25);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(167, 48);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "LIBRARY";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblXinChao);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(270, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1080, 100);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblXinChao
            // 
            this.lblXinChao.AutoSize = true;
            this.lblXinChao.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblXinChao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblXinChao.Location = new System.Drawing.Point(34, 31);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(245, 38);
            this.lblXinChao.TabIndex = 0;
            this.lblXinChao.Text = "Xin chào, Độc giả";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTraCuu);
            this.tabControl1.Controls.Add(this.tabLichSu);
            this.tabControl1.Controls.Add(this.tabCaNhan);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(270, 100);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1080, 712);
            this.tabControl1.TabIndex = 0;
            // 
            // tabTraCuu
            // 
            this.tabTraCuu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabTraCuu.Controls.Add(this.dgvSach);
            this.tabTraCuu.Controls.Add(this.panelSearch);
            this.tabTraCuu.Location = new System.Drawing.Point(4, 29);
            this.tabTraCuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabTraCuu.Name = "tabTraCuu";
            this.tabTraCuu.Padding = new System.Windows.Forms.Padding(22, 25, 22, 25);
            this.tabTraCuu.Size = new System.Drawing.Size(1072, 679);
            this.tabTraCuu.TabIndex = 0;
            this.tabTraCuu.Text = "Tra cứu";
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.dgvSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSach.ColumnHeadersHeight = 45;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSach.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.EnableHeadersVisualStyles = false;
            this.dgvSach.Location = new System.Drawing.Point(22, 100);
            this.dgvSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersVisible = false;
            this.dgvSach.RowHeadersWidth = 62;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(1028, 554);
            this.dgvSach.TabIndex = 0;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.White;
            this.panelSearch.Controls.Add(this.btnRsFilter);
            this.panelSearch.Controls.Add(this.txtTimKiem);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(22, 25);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1028, 75);
            this.panelSearch.TabIndex = 1;
            // 
            // btnRsFilter
            // 
            this.btnRsFilter.BackColor = System.Drawing.Color.Crimson;
            this.btnRsFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRsFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRsFilter.Location = new System.Drawing.Point(680, 15);
            this.btnRsFilter.Name = "btnRsFilter";
            this.btnRsFilter.Size = new System.Drawing.Size(109, 47);
            this.btnRsFilter.TabIndex = 7;
            this.btnRsFilter.Text = "Reset";
            this.btnRsFilter.UseVisualStyleBackColor = false;
            this.btnRsFilter.Click += new System.EventHandler(this.btnRsFilter_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTimKiem.Location = new System.Drawing.Point(300, 19);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(374, 37);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm sách, chủ đề, tác giả:";
            // 
            // tabLichSu
            // 
            this.tabLichSu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabLichSu.Controls.Add(this.dgvLichSu);
            this.tabLichSu.Controls.Add(this.pnlHistoryHeader);
            this.tabLichSu.Location = new System.Drawing.Point(4, 29);
            this.tabLichSu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabLichSu.Name = "tabLichSu";
            this.tabLichSu.Padding = new System.Windows.Forms.Padding(22, 25, 22, 25);
            this.tabLichSu.Size = new System.Drawing.Size(1072, 679);
            this.tabLichSu.TabIndex = 1;
            this.tabLichSu.Text = "Lịch sử";
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.AllowUserToAddRows = false;
            this.dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSu.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichSu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLichSu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvLichSu.ColumnHeadersHeight = 45;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLichSu.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvLichSu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichSu.EnableHeadersVisualStyles = false;
            this.dgvLichSu.Location = new System.Drawing.Point(22, 100);
            this.dgvLichSu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.RowHeadersVisible = false;
            this.dgvLichSu.RowHeadersWidth = 62;
            this.dgvLichSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichSu.Size = new System.Drawing.Size(1028, 554);
            this.dgvLichSu.TabIndex = 0;
            // 
            // pnlHistoryHeader
            // 
            this.pnlHistoryHeader.BackColor = System.Drawing.Color.White;
            this.pnlHistoryHeader.Controls.Add(this.lblHistoryTitle);
            this.pnlHistoryHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHistoryHeader.Location = new System.Drawing.Point(22, 25);
            this.pnlHistoryHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHistoryHeader.Name = "pnlHistoryHeader";
            this.pnlHistoryHeader.Size = new System.Drawing.Size(1028, 75);
            this.pnlHistoryHeader.TabIndex = 1;
            // 
            // lblHistoryTitle
            // 
            this.lblHistoryTitle.AutoSize = true;
            this.lblHistoryTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHistoryTitle.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblHistoryTitle.Location = new System.Drawing.Point(22, 19);
            this.lblHistoryTitle.Name = "lblHistoryTitle";
            this.lblHistoryTitle.Size = new System.Drawing.Size(392, 32);
            this.lblHistoryTitle.TabIndex = 0;
            this.lblHistoryTitle.Text = "Trạng thái yêu cầu & Lịch sử mượn";
            // 
            // tabCaNhan
            // 
            this.tabCaNhan.BackColor = System.Drawing.Color.White;
            this.tabCaNhan.Controls.Add(this.groupBoxInfo);
            this.tabCaNhan.Controls.Add(this.lblTitleCaNhan);
            this.tabCaNhan.Location = new System.Drawing.Point(4, 29);
            this.tabCaNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCaNhan.Name = "tabCaNhan";
            this.tabCaNhan.Padding = new System.Windows.Forms.Padding(45, 50, 45, 50);
            this.tabCaNhan.Size = new System.Drawing.Size(1072, 679);
            this.tabCaNhan.TabIndex = 2;
            this.tabCaNhan.Text = "Cá nhân";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.lblName);
            this.groupBoxInfo.Controls.Add(this.lblHanThe);
            this.groupBoxInfo.Controls.Add(this.lblEmail);
            this.groupBoxInfo.Controls.Add(this.lblPhone);
            this.groupBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfo.Location = new System.Drawing.Point(45, 50);
            this.groupBoxInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxInfo.Size = new System.Drawing.Size(982, 579);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Thông tin chi tiết";
            // 
            // lblHanThe
            // 
            this.lblHanThe.AutoSize = true;
            this.lblHanThe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHanThe.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblHanThe.Location = new System.Drawing.Point(38, 242);
            this.lblHanThe.Name = "lblHanThe";
            this.lblHanThe.Size = new System.Drawing.Size(125, 30);
            this.lblHanThe.TabIndex = 0;
            this.lblHanThe.Text = "Hạn thẻ: ...";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(38, 117);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(147, 48);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email: ...";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(38, 180);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(125, 48);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "SĐT: ...";
            // 
            // lblTitleCaNhan
            // 
            this.lblTitleCaNhan.AutoSize = true;
            this.lblTitleCaNhan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitleCaNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitleCaNhan.Location = new System.Drawing.Point(45, 50);
            this.lblTitleCaNhan.Name = "lblTitleCaNhan";
            this.lblTitleCaNhan.Size = new System.Drawing.Size(284, 48);
            this.lblTitleCaNhan.TabIndex = 1;
            this.lblTitleCaNhan.Text = "HỒ SƠ CỦA TÔI";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(38, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(116, 48);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Tên: ...";
            // 
            // FormDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 812);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button btnRsFilter;
        private System.Windows.Forms.Label lblName;
    }
}