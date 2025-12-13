namespace QLTV
{
    partial class FormDanhMuc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // --- KHAI BÁO MÀU SẮC (EARTH TONE) ---
            System.Drawing.Color colorRice = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            System.Drawing.Color colorDeepEarth = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(52)))), ((int)(((byte)(50)))));
            System.Drawing.Color colorClay = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(110)))), ((int)(((byte)(99)))));
            System.Drawing.Color colorWhite = System.Drawing.Color.White;
            System.Drawing.Color colorRust = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(136)))), ((int)(((byte)(127)))));
            System.Drawing.Color colorGrayText = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            System.Drawing.Color colorTextDark = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            System.Drawing.Color colorSelection = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(233)))));

            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle altRowStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnNavNXB = new System.Windows.Forms.Button();
            this.btnNavTacGia = new System.Windows.Forms.Button();
            this.btnNavTheLoai = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTheLoai = new System.Windows.Forms.TabPage();
            this.pnlTLInput = new System.Windows.Forms.Panel();
            this.txtSearchTL = new System.Windows.Forms.TextBox();
            this.labelSearchTL = new System.Windows.Forms.Label();
            this.btnHuyTL = new System.Windows.Forms.Button();
            this.btnXoaTL = new System.Windows.Forms.Button();
            this.btnSuaTL = new System.Windows.Forms.Button();
            this.btnThemTL = new System.Windows.Forms.Button();
            this.txtTenTL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTheLoai = new System.Windows.Forms.DataGridView();
            this.tabTacGia = new System.Windows.Forms.TabPage();
            this.pnlTGInput = new System.Windows.Forms.Panel();
            this.txtSearchTG = new System.Windows.Forms.TextBox();
            this.labelSearchTG = new System.Windows.Forms.Label();
            this.btnHuyTG = new System.Windows.Forms.Button();
            this.btnXoaTG = new System.Windows.Forms.Button();
            this.btnSuaTG = new System.Windows.Forms.Button();
            this.btnThemTG = new System.Windows.Forms.Button();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTacGia = new System.Windows.Forms.DataGridView();
            this.tabNXB = new System.Windows.Forms.TabPage();
            this.pnlNXBInput = new System.Windows.Forms.Panel();
            this.txtSearchNXB = new System.Windows.Forms.TextBox();
            this.labelSearchNXB = new System.Windows.Forms.Label();
            this.btnHuyNXB = new System.Windows.Forms.Button();
            this.btnXoaNXB = new System.Windows.Forms.Button();
            this.btnSuaNXB = new System.Windows.Forms.Button();
            this.btnThemNXB = new System.Windows.Forms.Button();
            this.txtSdtNXB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvNXB = new System.Windows.Forms.DataGridView();
            this.pnlSidebar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTheLoai.SuspendLayout();
            this.pnlTLInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).BeginInit();
            this.tabTacGia.SuspendLayout();
            this.pnlTGInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).BeginInit();
            this.tabNXB.SuspendLayout();
            this.pnlNXBInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            this.SuspendLayout();

            // 
            // CẤU HÌNH STYLE CHO GRIDVIEW (CHUNG)
            // 
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = colorClay;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            headerStyle.SelectionBackColor = colorClay;
            headerStyle.SelectionForeColor = System.Drawing.Color.White;
            headerStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

            cellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = colorWhite;
            cellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            cellStyle.ForeColor = colorTextDark;
            cellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            cellStyle.SelectionBackColor = colorSelection;
            cellStyle.SelectionForeColor = System.Drawing.Color.Black;
            cellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;

            altRowStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));

            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = colorDeepEarth;
            this.pnlSidebar.Controls.Add(this.btnNavNXB);
            this.pnlSidebar.Controls.Add(this.btnNavTacGia);
            this.pnlSidebar.Controls.Add(this.btnNavTheLoai);
            this.pnlSidebar.Controls.Add(this.lblTitle);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(240, 650);
            this.pnlSidebar.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(240, 100);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THƯ VIỆN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // btnNavTheLoai
            // 
            this.btnNavTheLoai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavTheLoai.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavTheLoai.FlatAppearance.BorderSize = 0;
            this.btnNavTheLoai.FlatAppearance.MouseOverBackColor = colorClay;
            this.btnNavTheLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTheLoai.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNavTheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNavTheLoai.Location = new System.Drawing.Point(0, 100);
            this.btnNavTheLoai.Name = "btnNavTheLoai";
            this.btnNavTheLoai.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNavTheLoai.Size = new System.Drawing.Size(240, 60);
            this.btnNavTheLoai.TabIndex = 1;
            this.btnNavTheLoai.Text = "Thể Loại Sách";
            this.btnNavTheLoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavTheLoai.UseVisualStyleBackColor = true;
            this.btnNavTheLoai.Click += new System.EventHandler(this.btnNavTheLoai_Click);

            // 
            // btnNavTacGia
            // 
            this.btnNavTacGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavTacGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavTacGia.FlatAppearance.BorderSize = 0;
            this.btnNavTacGia.FlatAppearance.MouseOverBackColor = colorClay;
            this.btnNavTacGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTacGia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNavTacGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNavTacGia.Location = new System.Drawing.Point(0, 160);
            this.btnNavTacGia.Name = "btnNavTacGia";
            this.btnNavTacGia.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNavTacGia.Size = new System.Drawing.Size(240, 60);
            this.btnNavTacGia.TabIndex = 2;
            this.btnNavTacGia.Text = "Tác Giả";
            this.btnNavTacGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavTacGia.UseVisualStyleBackColor = true;
            this.btnNavTacGia.Click += new System.EventHandler(this.btnNavTacGia_Click);

            // 
            // btnNavNXB
            // 
            this.btnNavNXB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavNXB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavNXB.FlatAppearance.BorderSize = 0;
            this.btnNavNXB.FlatAppearance.MouseOverBackColor = colorClay;
            this.btnNavNXB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavNXB.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNavNXB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNavNXB.Location = new System.Drawing.Point(0, 220);
            this.btnNavNXB.Name = "btnNavNXB";
            this.btnNavNXB.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNavNXB.Size = new System.Drawing.Size(240, 60);
            this.btnNavNXB.TabIndex = 3;
            this.btnNavNXB.Text = "Nhà Xuất Bản";
            this.btnNavNXB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavNXB.UseVisualStyleBackColor = true;
            this.btnNavNXB.Click += new System.EventHandler(this.btnNavNXB_Click);

            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTheLoai);
            this.tabControl1.Controls.Add(this.tabTacGia);
            this.tabControl1.Controls.Add(this.tabNXB);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(240, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 650);
            this.tabControl1.TabIndex = 1;

            // 
            // === TAB 1: THỂ LOẠI ===
            // 
            this.tabTheLoai.BackColor = colorRice;
            this.tabTheLoai.Controls.Add(this.pnlTLInput);
            this.tabTheLoai.Controls.Add(this.dgvTheLoai);
            this.tabTheLoai.Location = new System.Drawing.Point(4, 25);
            this.tabTheLoai.Name = "tabTheLoai";
            this.tabTheLoai.Padding = new System.Windows.Forms.Padding(3);
            this.tabTheLoai.Size = new System.Drawing.Size(952, 621);
            this.tabTheLoai.TabIndex = 0;
            this.tabTheLoai.Text = "Thể Loại";

            // pnlTLInput
            this.pnlTLInput.BackColor = colorRice;
            this.pnlTLInput.Controls.Add(this.txtSearchTL);
            this.pnlTLInput.Controls.Add(this.labelSearchTL);
            this.pnlTLInput.Controls.Add(this.btnHuyTL);
            this.pnlTLInput.Controls.Add(this.btnXoaTL);
            this.pnlTLInput.Controls.Add(this.btnSuaTL);
            this.pnlTLInput.Controls.Add(this.btnThemTL);
            this.pnlTLInput.Controls.Add(this.txtTenTL);
            this.pnlTLInput.Controls.Add(this.label1);
            this.pnlTLInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTLInput.Height = 180;
            this.pnlTLInput.Location = new System.Drawing.Point(3, 3);
            this.pnlTLInput.Name = "pnlTLInput";
            this.pnlTLInput.TabIndex = 0;

            // Controls Inside TL Input
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = colorTextDark;
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên thể loại";

            this.txtTenTL.BackColor = colorWhite;
            this.txtTenTL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenTL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenTL.Location = new System.Drawing.Point(140, 37);
            this.txtTenTL.Name = "txtTenTL";
            this.txtTenTL.Size = new System.Drawing.Size(350, 30);
            this.txtTenTL.TabIndex = 1;

            this.btnThemTL.BackColor = colorClay;
            this.btnThemTL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemTL.FlatAppearance.BorderSize = 0;
            this.btnThemTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTL.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnThemTL.ForeColor = System.Drawing.Color.White;
            this.btnThemTL.Location = new System.Drawing.Point(520, 30);
            this.btnThemTL.Name = "btnThemTL";
            this.btnThemTL.Size = new System.Drawing.Size(100, 38);
            this.btnThemTL.TabIndex = 2;
            this.btnThemTL.Text = "Thêm Mới";
            this.btnThemTL.UseVisualStyleBackColor = false;
            this.btnThemTL.Click += new System.EventHandler(this.btnThemTL_Click);

            this.btnSuaTL.BackColor = colorClay;
            this.btnSuaTL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaTL.FlatAppearance.BorderSize = 0;
            this.btnSuaTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaTL.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnSuaTL.ForeColor = System.Drawing.Color.White;
            this.btnSuaTL.Location = new System.Drawing.Point(630, 30);
            this.btnSuaTL.Name = "btnSuaTL";
            this.btnSuaTL.Size = new System.Drawing.Size(100, 38);
            this.btnSuaTL.TabIndex = 3;
            this.btnSuaTL.Text = "Cập Nhật";
            this.btnSuaTL.UseVisualStyleBackColor = false;
            this.btnSuaTL.Click += new System.EventHandler(this.btnSuaTL_Click);

            this.btnXoaTL.BackColor = colorRust;
            this.btnXoaTL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaTL.FlatAppearance.BorderSize = 0;
            this.btnXoaTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTL.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnXoaTL.ForeColor = System.Drawing.Color.White;
            this.btnXoaTL.Location = new System.Drawing.Point(740, 30);
            this.btnXoaTL.Name = "btnXoaTL";
            this.btnXoaTL.Size = new System.Drawing.Size(100, 38);
            this.btnXoaTL.TabIndex = 4;
            this.btnXoaTL.Text = "Xóa";
            this.btnXoaTL.UseVisualStyleBackColor = false;
            this.btnXoaTL.Click += new System.EventHandler(this.btnXoaTL_Click);

            this.btnHuyTL.BackColor = colorGrayText;
            this.btnHuyTL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyTL.FlatAppearance.BorderSize = 0;
            this.btnHuyTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyTL.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnHuyTL.ForeColor = System.Drawing.Color.White;
            this.btnHuyTL.Location = new System.Drawing.Point(850, 30);
            this.btnHuyTL.Name = "btnHuyTL";
            this.btnHuyTL.Size = new System.Drawing.Size(60, 38);
            this.btnHuyTL.TabIndex = 5;
            this.btnHuyTL.Text = "Hủy";
            this.btnHuyTL.UseVisualStyleBackColor = false;
            this.btnHuyTL.Click += new System.EventHandler(this.btnHuyTL_Click);

            this.labelSearchTL.AutoSize = true;
            this.labelSearchTL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSearchTL.ForeColor = colorTextDark;
            this.labelSearchTL.Location = new System.Drawing.Point(40, 110);
            this.labelSearchTL.Name = "labelSearchTL";
            this.labelSearchTL.Size = new System.Drawing.Size(79, 23);
            this.labelSearchTL.TabIndex = 6;
            this.labelSearchTL.Text = "Tìm kiếm";

            this.txtSearchTL.BackColor = colorWhite;
            this.txtSearchTL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchTL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchTL.Location = new System.Drawing.Point(140, 107);
            this.txtSearchTL.Name = "txtSearchTL";
            this.txtSearchTL.Size = new System.Drawing.Size(350, 30);
            this.txtSearchTL.TabIndex = 7;
            this.txtSearchTL.TextChanged += new System.EventHandler(this.txtSearchTL_TextChanged);

            // 
            // dgvTheLoai
            // 
            this.dgvTheLoai.AllowUserToAddRows = false;
            this.dgvTheLoai.AlternatingRowsDefaultCellStyle = altRowStyle;
            this.dgvTheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; // FIX: Lấp đầy khoảng trống
            this.dgvTheLoai.BackgroundColor = colorRice;
            this.dgvTheLoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTheLoai.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTheLoai.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvTheLoai.ColumnHeadersHeight = 50;
            this.dgvTheLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "MaTheLoai", HeaderText = "Mã TL", Width = 100 },
                new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "TenTheLoai", HeaderText = "Tên Thể Loại" } // AutoFill
            });
            this.dgvTheLoai.DefaultCellStyle = cellStyle;
            this.dgvTheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTheLoai.EnableHeadersVisualStyles = false;
            this.dgvTheLoai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTheLoai.Location = new System.Drawing.Point(3, 3);
            this.dgvTheLoai.Name = "dgvTheLoai";
            this.dgvTheLoai.RowHeadersVisible = false; // FIX: Ẩn cột xám bên trái
            this.dgvTheLoai.RowTemplate.Height = 35;
            this.dgvTheLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTheLoai.Size = new System.Drawing.Size(946, 615);
            this.dgvTheLoai.TabIndex = 1;
            this.dgvTheLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTheLoai_CellClick);

            // 
            // === TAB 2: TÁC GIẢ ===
            // 
            this.tabTacGia.BackColor = colorRice;
            this.tabTacGia.Controls.Add(this.pnlTGInput);
            this.tabTacGia.Controls.Add(this.dgvTacGia);
            this.tabTacGia.Location = new System.Drawing.Point(4, 25);
            this.tabTacGia.Name = "tabTacGia";
            this.tabTacGia.Padding = new System.Windows.Forms.Padding(3);
            this.tabTacGia.Size = new System.Drawing.Size(952, 621);
            this.tabTacGia.TabIndex = 1;
            this.tabTacGia.Text = "Tác Giả";

            // pnlTGInput
            this.pnlTGInput.BackColor = colorRice;
            this.pnlTGInput.Controls.Add(this.txtSearchTG);
            this.pnlTGInput.Controls.Add(this.labelSearchTG);
            this.pnlTGInput.Controls.Add(this.btnHuyTG);
            this.pnlTGInput.Controls.Add(this.btnXoaTG);
            this.pnlTGInput.Controls.Add(this.btnSuaTG);
            this.pnlTGInput.Controls.Add(this.btnThemTG);
            this.pnlTGInput.Controls.Add(this.txtTenTG);
            this.pnlTGInput.Controls.Add(this.label2);
            this.pnlTGInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTGInput.Height = 180;
            this.pnlTGInput.Location = new System.Drawing.Point(3, 3);
            this.pnlTGInput.Name = "pnlTGInput";
            this.pnlTGInput.TabIndex = 0;

            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = colorTextDark;
            this.label2.Location = new System.Drawing.Point(40, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên tác giả";

            this.txtTenTG.BackColor = colorWhite;
            this.txtTenTG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenTG.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenTG.Location = new System.Drawing.Point(140, 37);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(350, 30);
            this.txtTenTG.TabIndex = 1;

            this.btnThemTG.BackColor = colorClay;
            this.btnThemTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTG.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnThemTG.ForeColor = System.Drawing.Color.White;
            this.btnThemTG.Location = new System.Drawing.Point(520, 30);
            this.btnThemTG.Name = "btnThemTG";
            this.btnThemTG.Size = new System.Drawing.Size(100, 38);
            this.btnThemTG.TabIndex = 2;
            this.btnThemTG.Text = "Thêm Mới";
            this.btnThemTG.UseVisualStyleBackColor = false;
            this.btnThemTG.Click += new System.EventHandler(this.btnThemTG_Click);

            this.btnSuaTG.BackColor = colorClay;
            this.btnSuaTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaTG.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnSuaTG.ForeColor = System.Drawing.Color.White;
            this.btnSuaTG.Location = new System.Drawing.Point(630, 30);
            this.btnSuaTG.Name = "btnSuaTG";
            this.btnSuaTG.Size = new System.Drawing.Size(100, 38);
            this.btnSuaTG.TabIndex = 3;
            this.btnSuaTG.Text = "Cập Nhật";
            this.btnSuaTG.UseVisualStyleBackColor = false;
            this.btnSuaTG.Click += new System.EventHandler(this.btnSuaTG_Click);

            this.btnXoaTG.BackColor = colorRust;
            this.btnXoaTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTG.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnXoaTG.ForeColor = System.Drawing.Color.White;
            this.btnXoaTG.Location = new System.Drawing.Point(740, 30);
            this.btnXoaTG.Name = "btnXoaTG";
            this.btnXoaTG.Size = new System.Drawing.Size(100, 38);
            this.btnXoaTG.TabIndex = 4;
            this.btnXoaTG.Text = "Xóa";
            this.btnXoaTG.UseVisualStyleBackColor = false;
            this.btnXoaTG.Click += new System.EventHandler(this.btnXoaTG_Click);

            this.btnHuyTG.BackColor = colorGrayText;
            this.btnHuyTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyTG.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnHuyTG.ForeColor = System.Drawing.Color.White;
            this.btnHuyTG.Location = new System.Drawing.Point(850, 30);
            this.btnHuyTG.Name = "btnHuyTG";
            this.btnHuyTG.Size = new System.Drawing.Size(60, 38);
            this.btnHuyTG.TabIndex = 5;
            this.btnHuyTG.Text = "Hủy";
            this.btnHuyTG.UseVisualStyleBackColor = false;
            this.btnHuyTG.Click += new System.EventHandler(this.btnHuyTG_Click);

            this.labelSearchTG.AutoSize = true;
            this.labelSearchTG.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSearchTG.ForeColor = colorTextDark;
            this.labelSearchTG.Location = new System.Drawing.Point(40, 110);
            this.labelSearchTG.Name = "labelSearchTG";
            this.labelSearchTG.Size = new System.Drawing.Size(79, 23);
            this.labelSearchTG.TabIndex = 6;
            this.labelSearchTG.Text = "Tìm kiếm";

            this.txtSearchTG.BackColor = colorWhite;
            this.txtSearchTG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchTG.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchTG.Location = new System.Drawing.Point(140, 107);
            this.txtSearchTG.Name = "txtSearchTG";
            this.txtSearchTG.Size = new System.Drawing.Size(350, 30);
            this.txtSearchTG.TabIndex = 7;
            this.txtSearchTG.TextChanged += new System.EventHandler(this.txtSearchTG_TextChanged);

            // dgvTacGia
            this.dgvTacGia.AllowUserToAddRows = false;
            this.dgvTacGia.AlternatingRowsDefaultCellStyle = altRowStyle;
            this.dgvTacGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTacGia.BackgroundColor = colorRice;
            this.dgvTacGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTacGia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTacGia.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvTacGia.ColumnHeadersHeight = 50;
            this.dgvTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "MaTacGia", HeaderText = "Mã TG", Width = 100 },
                new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "TenTacGia", HeaderText = "Tên Tác Giả" }
            });
            this.dgvTacGia.DefaultCellStyle = cellStyle;
            this.dgvTacGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTacGia.EnableHeadersVisualStyles = false;
            this.dgvTacGia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTacGia.Location = new System.Drawing.Point(3, 3);
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.RowHeadersVisible = false;
            this.dgvTacGia.RowTemplate.Height = 35;
            this.dgvTacGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTacGia.Size = new System.Drawing.Size(946, 615);
            this.dgvTacGia.TabIndex = 1;
            this.dgvTacGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTacGia_CellClick);

            // 
            // === TAB 3: NXB ===
            // 
            this.tabNXB.BackColor = colorRice;
            this.tabNXB.Controls.Add(this.pnlNXBInput);
            this.tabNXB.Controls.Add(this.dgvNXB);
            this.tabNXB.Location = new System.Drawing.Point(4, 25);
            this.tabNXB.Name = "tabNXB";
            this.tabNXB.Padding = new System.Windows.Forms.Padding(3);
            this.tabNXB.Size = new System.Drawing.Size(952, 621);
            this.tabNXB.TabIndex = 2;
            this.tabNXB.Text = "Nhà Xuất Bản";

            // pnlNXBInput
            this.pnlNXBInput.BackColor = colorRice;
            this.pnlNXBInput.Controls.Add(this.txtSearchNXB);
            this.pnlNXBInput.Controls.Add(this.labelSearchNXB);
            this.pnlNXBInput.Controls.Add(this.btnHuyNXB);
            this.pnlNXBInput.Controls.Add(this.btnXoaNXB);
            this.pnlNXBInput.Controls.Add(this.btnSuaNXB);
            this.pnlNXBInput.Controls.Add(this.btnThemNXB);
            this.pnlNXBInput.Controls.Add(this.txtSdtNXB);
            this.pnlNXBInput.Controls.Add(this.label4);
            this.pnlNXBInput.Controls.Add(this.txtTenNXB);
            this.pnlNXBInput.Controls.Add(this.label3);
            this.pnlNXBInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNXBInput.Height = 180;
            this.pnlNXBInput.Location = new System.Drawing.Point(3, 3);
            this.pnlNXBInput.Name = "pnlNXBInput";
            this.pnlNXBInput.TabIndex = 0;

            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = colorTextDark;
            this.label3.Location = new System.Drawing.Point(40, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên NXB";

            this.txtTenNXB.BackColor = colorWhite;
            this.txtTenNXB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNXB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenNXB.Location = new System.Drawing.Point(140, 37);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(350, 30);
            this.txtTenNXB.TabIndex = 1;

            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = colorTextDark;
            this.label4.Location = new System.Drawing.Point(40, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số ĐT";

            this.txtSdtNXB.BackColor = colorWhite;
            this.txtSdtNXB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSdtNXB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSdtNXB.Location = new System.Drawing.Point(140, 77);
            this.txtSdtNXB.Name = "txtSdtNXB";
            this.txtSdtNXB.Size = new System.Drawing.Size(350, 30);
            this.txtSdtNXB.TabIndex = 3;

            this.btnThemNXB.BackColor = colorClay;
            this.btnThemNXB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNXB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnThemNXB.ForeColor = System.Drawing.Color.White;
            this.btnThemNXB.Location = new System.Drawing.Point(520, 30);
            this.btnThemNXB.Name = "btnThemNXB";
            this.btnThemNXB.Size = new System.Drawing.Size(100, 38);
            this.btnThemNXB.TabIndex = 4;
            this.btnThemNXB.Text = "Thêm Mới";
            this.btnThemNXB.UseVisualStyleBackColor = false;
            this.btnThemNXB.Click += new System.EventHandler(this.btnThemNXB_Click);

            this.btnSuaNXB.BackColor = colorClay;
            this.btnSuaNXB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaNXB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnSuaNXB.ForeColor = System.Drawing.Color.White;
            this.btnSuaNXB.Location = new System.Drawing.Point(630, 30);
            this.btnSuaNXB.Name = "btnSuaNXB";
            this.btnSuaNXB.Size = new System.Drawing.Size(100, 38);
            this.btnSuaNXB.TabIndex = 5;
            this.btnSuaNXB.Text = "Cập Nhật";
            this.btnSuaNXB.UseVisualStyleBackColor = false;
            this.btnSuaNXB.Click += new System.EventHandler(this.btnSuaNXB_Click);

            this.btnXoaNXB.BackColor = colorRust;
            this.btnXoaNXB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNXB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnXoaNXB.ForeColor = System.Drawing.Color.White;
            this.btnXoaNXB.Location = new System.Drawing.Point(740, 30);
            this.btnXoaNXB.Name = "btnXoaNXB";
            this.btnXoaNXB.Size = new System.Drawing.Size(100, 38);
            this.btnXoaNXB.TabIndex = 6;
            this.btnXoaNXB.Text = "Xóa";
            this.btnXoaNXB.UseVisualStyleBackColor = false;
            this.btnXoaNXB.Click += new System.EventHandler(this.btnXoaNXB_Click);

            this.btnHuyNXB.BackColor = colorGrayText;
            this.btnHuyNXB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyNXB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnHuyNXB.ForeColor = System.Drawing.Color.White;
            this.btnHuyNXB.Location = new System.Drawing.Point(850, 30);
            this.btnHuyNXB.Name = "btnHuyNXB";
            this.btnHuyNXB.Size = new System.Drawing.Size(60, 38);
            this.btnHuyNXB.TabIndex = 7;
            this.btnHuyNXB.Text = "Hủy";
            this.btnHuyNXB.UseVisualStyleBackColor = false;
            this.btnHuyNXB.Click += new System.EventHandler(this.btnHuyNXB_Click);

            this.labelSearchNXB.AutoSize = true;
            this.labelSearchNXB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSearchNXB.ForeColor = colorTextDark;
            this.labelSearchNXB.Location = new System.Drawing.Point(40, 130);
            this.labelSearchNXB.Name = "labelSearchNXB";
            this.labelSearchNXB.Size = new System.Drawing.Size(79, 23);
            this.labelSearchNXB.TabIndex = 8;
            this.labelSearchNXB.Text = "Tìm kiếm";

            this.txtSearchNXB.BackColor = colorWhite;
            this.txtSearchNXB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchNXB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchNXB.Location = new System.Drawing.Point(140, 127);
            this.txtSearchNXB.Name = "txtSearchNXB";
            this.txtSearchNXB.Size = new System.Drawing.Size(350, 30);
            this.txtSearchNXB.TabIndex = 9;
            this.txtSearchNXB.TextChanged += new System.EventHandler(this.txtSearchNXB_TextChanged);

            // dgvNXB
            this.dgvNXB.AllowUserToAddRows = false;
            this.dgvNXB.AlternatingRowsDefaultCellStyle = altRowStyle;
            this.dgvNXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNXB.BackgroundColor = colorRice;
            this.dgvNXB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNXB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNXB.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvNXB.ColumnHeadersHeight = 50;
            this.dgvNXB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "MaNXB", HeaderText = "Mã NXB", Width = 100 },
                new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "TenNXB", HeaderText = "Tên Nhà Xuất Bản" },
                new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "SDT", HeaderText = "Số Điện Thoại", Width = 150 }
            });
            this.dgvNXB.DefaultCellStyle = cellStyle;
            this.dgvNXB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNXB.EnableHeadersVisualStyles = false;
            this.dgvNXB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvNXB.Location = new System.Drawing.Point(3, 3);
            this.dgvNXB.Name = "dgvNXB";
            this.dgvNXB.RowHeadersVisible = false;
            this.dgvNXB.RowTemplate.Height = 35;
            this.dgvNXB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNXB.Size = new System.Drawing.Size(946, 615);
            this.dgvNXB.TabIndex = 1;
            this.dgvNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNXB_CellClick);

            // 
            // FIX LỖI Z-ORDER: Đảm bảo Panel Input luôn nằm trên GridView
            // 
            this.pnlTLInput.BringToFront();
            this.pnlTGInput.BringToFront();
            this.pnlNXBInput.BringToFront();

            // 
            // FormDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "FormDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Danh Mục";
            this.pnlSidebar.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabTheLoai.ResumeLayout(false);
            this.pnlTLInput.ResumeLayout(false);
            this.pnlTLInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).EndInit();
            this.tabTacGia.ResumeLayout(false);
            this.pnlTGInput.ResumeLayout(false);
            this.pnlTGInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).EndInit();
            this.tabNXB.ResumeLayout(false);
            this.pnlNXBInput.ResumeLayout(false);
            this.pnlNXBInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // Controls Declaration
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNavTheLoai;
        private System.Windows.Forms.Button btnNavTacGia;
        private System.Windows.Forms.Button btnNavNXB;
        private System.Windows.Forms.TabControl tabControl1;

        // The Loai
        private System.Windows.Forms.TabPage tabTheLoai;
        private System.Windows.Forms.DataGridView dgvTheLoai;
        private System.Windows.Forms.Panel pnlTLInput;
        private System.Windows.Forms.TextBox txtTenTL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemTL, btnSuaTL, btnXoaTL, btnHuyTL;
        private System.Windows.Forms.TextBox txtSearchTL;
        private System.Windows.Forms.Label labelSearchTL;

        // Tac Gia
        private System.Windows.Forms.TabPage tabTacGia;
        private System.Windows.Forms.DataGridView dgvTacGia;
        private System.Windows.Forms.Panel pnlTGInput;
        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemTG, btnSuaTG, btnXoaTG, btnHuyTG;
        private System.Windows.Forms.TextBox txtSearchTG;
        private System.Windows.Forms.Label labelSearchTG;

        // NXB
        private System.Windows.Forms.TabPage tabNXB;
        private System.Windows.Forms.DataGridView dgvNXB;
        private System.Windows.Forms.Panel pnlNXBInput;
        private System.Windows.Forms.TextBox txtTenNXB, txtSdtNXB;
        private System.Windows.Forms.Label label3, label4;
        private System.Windows.Forms.Button btnThemNXB, btnSuaNXB, btnXoaNXB, btnHuyNXB;
        private System.Windows.Forms.TextBox txtSearchNXB;
        private System.Windows.Forms.Label labelSearchNXB;
    }
}