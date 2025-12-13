namespace QLTV
{
    partial class QuanLySach
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgwhowList = new System.Windows.Forms.DataGridView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRsFilter = new System.Windows.Forms.Button();
            this.cboTacGia = new System.Windows.Forms.ComboBox();
            this.cboChuDe = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.labelQR = new System.Windows.Forms.Label();
            this.txtScanQR = new System.Windows.Forms.TextBox();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.pnlButtonContainer = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.picAnhBia = new System.Windows.Forms.PictureBox();
            this.btnUploadAnh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameSach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtChuDe = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.labelISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwhowList)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.groupBoxAction.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            this.pnlButtonContainer.SuspendLayout();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhBia)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1028, 57);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.lblTitle.Location = new System.Drawing.Point(15, 7);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(385, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📖 QUẢN LÝ KHO SÁCH";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 57);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgwhowList);
            this.splitContainer1.Panel1.Controls.Add(this.pnlSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.splitContainer1.Panel2.Controls.Add(this.pnlDetail);
            this.splitContainer1.Size = new System.Drawing.Size(1028, 552);
            this.splitContainer1.SplitterDistance = 668;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgwhowList
            // 
            this.dgwhowList.AllowUserToAddRows = false;
            this.dgwhowList.AllowUserToResizeRows = false;
            this.dgwhowList.BackgroundColor = System.Drawing.Color.White;
            this.dgwhowList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwhowList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(82)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(82)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwhowList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwhowList.ColumnHeadersHeight = 40;
            this.dgwhowList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwhowList.EnableHeadersVisualStyles = false;
            this.dgwhowList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgwhowList.Location = new System.Drawing.Point(0, 114);
            this.dgwhowList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgwhowList.Name = "dgwhowList";
            this.dgwhowList.ReadOnly = true;
            this.dgwhowList.RowHeadersVisible = false;
            this.dgwhowList.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgwhowList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwhowList.RowTemplate.Height = 35;
            this.dgwhowList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwhowList.Size = new System.Drawing.Size(668, 438);
            this.dgwhowList.TabIndex = 1;
            this.dgwhowList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwhowList_CellClick);
            this.dgwhowList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwhowList_CellDoubleClick);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(247)))));
            this.pnlSearch.Controls.Add(this.groupBoxFilter);
            this.pnlSearch.Controls.Add(this.groupBoxAction);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(668, 114);
            this.pnlSearch.TabIndex = 0;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.label9);
            this.groupBoxFilter.Controls.Add(this.label7);
            this.groupBoxFilter.Controls.Add(this.btnRsFilter);
            this.groupBoxFilter.Controls.Add(this.cboTacGia);
            this.groupBoxFilter.Controls.Add(this.cboChuDe);
            this.groupBoxFilter.Controls.Add(this.txtSearch);
            this.groupBoxFilter.Controls.Add(this.label1);
            this.groupBoxFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.groupBoxFilter.Location = new System.Drawing.Point(9, 10);
            this.groupBoxFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxFilter.Size = new System.Drawing.Size(420, 93);
            this.groupBoxFilter.TabIndex = 8;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "TÌM KIẾM & BỘ LỌC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(174, 65);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tác giả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(13, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Thể loại";
            // 
            // btnRsFilter
            // 
            this.btnRsFilter.BackColor = System.Drawing.Color.Silver;
            this.btnRsFilter.FlatAppearance.BorderSize = 0;
            this.btnRsFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRsFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRsFilter.ForeColor = System.Drawing.Color.Black;
            this.btnRsFilter.Location = new System.Drawing.Point(345, 61);
            this.btnRsFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRsFilter.Name = "btnRsFilter";
            this.btnRsFilter.Size = new System.Drawing.Size(64, 24);
            this.btnRsFilter.TabIndex = 4;
            this.btnRsFilter.Text = "⟳ Reset";
            this.btnRsFilter.UseVisualStyleBackColor = false;
            this.btnRsFilter.Click += new System.EventHandler(this.btnRsFilter_Click_1);
            // 
            // cboTacGia
            // 
            this.cboTacGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTacGia.FormattingEnabled = true;
            this.cboTacGia.Location = new System.Drawing.Point(220, 61);
            this.cboTacGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTacGia.Name = "cboTacGia";
            this.cboTacGia.Size = new System.Drawing.Size(114, 25);
            this.cboTacGia.TabIndex = 3;
            this.cboTacGia.SelectedIndexChanged += new System.EventHandler(this.cboTacGia_SelectedIndexChanged);
            // 
            // cboChuDe
            // 
            this.cboChuDe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboChuDe.FormattingEnabled = true;
            this.cboChuDe.Location = new System.Drawing.Point(64, 61);
            this.cboChuDe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboChuDe.Name = "cboChuDe";
            this.cboChuDe.Size = new System.Drawing.Size(98, 25);
            this.cboChuDe.TabIndex = 2;
            this.cboChuDe.SelectedIndexChanged += new System.EventHandler(this.cboChuDe_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Location = new System.Drawing.Point(79, 24);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(330, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ khóa :";
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAction.Controls.Add(this.btnImportExcel);
            this.groupBoxAction.Controls.Add(this.labelQR);
            this.groupBoxAction.Controls.Add(this.txtScanQR);
            this.groupBoxAction.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.groupBoxAction.Location = new System.Drawing.Point(435, 10);
            this.groupBoxAction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAction.Size = new System.Drawing.Size(224, 93);
            this.groupBoxAction.TabIndex = 9;
            this.groupBoxAction.TabStop = false;
            this.groupBoxAction.Text = "NHẬP NHANH";
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.BackColor = System.Drawing.Color.ForestGreen;
            this.btnImportExcel.FlatAppearance.BorderSize = 0;
            this.btnImportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnImportExcel.ForeColor = System.Drawing.Color.White;
            this.btnImportExcel.Location = new System.Drawing.Point(90, 58);
            this.btnImportExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(120, 28);
            this.btnImportExcel.TabIndex = 7;
            this.btnImportExcel.Text = "📥 Nhập Excel";
            this.btnImportExcel.UseVisualStyleBackColor = false;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // labelQR
            // 
            this.labelQR.AutoSize = true;
            this.labelQR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelQR.ForeColor = System.Drawing.Color.Firebrick;
            this.labelQR.Location = new System.Drawing.Point(11, 28);
            this.labelQR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQR.Name = "labelQR";
            this.labelQR.Size = new System.Drawing.Size(61, 15);
            this.labelQR.TabIndex = 6;
            this.labelQR.Text = "SCAN QR:";
            // 
            // txtScanQR
            // 
            this.txtScanQR.BackColor = System.Drawing.Color.LightYellow;
            this.txtScanQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScanQR.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtScanQR.Location = new System.Drawing.Point(90, 24);
            this.txtScanQR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtScanQR.Name = "txtScanQR";
            this.txtScanQR.Size = new System.Drawing.Size(120, 25);
            this.txtScanQR.TabIndex = 5;
            this.txtScanQR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScanQR_KeyDown);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.pnlButtonContainer);
            this.pnlDetail.Controls.Add(this.grbThongTin);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Location = new System.Drawing.Point(0, 0);
            this.pnlDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.pnlDetail.Size = new System.Drawing.Size(357, 552);
            this.pnlDetail.TabIndex = 0;
            // 
            // pnlButtonContainer
            // 
            this.pnlButtonContainer.Controls.Add(this.btnThem);
            this.pnlButtonContainer.Controls.Add(this.btnSua);
            this.pnlButtonContainer.Controls.Add(this.btnXoa);
            this.pnlButtonContainer.Controls.Add(this.btnReset);
            this.pnlButtonContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtonContainer.Location = new System.Drawing.Point(8, 479);
            this.pnlButtonContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlButtonContainer.Name = "pnlButtonContainer";
            this.pnlButtonContainer.Size = new System.Drawing.Size(341, 65);
            this.pnlButtonContainer.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(82)))), ((int)(((byte)(45)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(8, 12);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 41);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(105)))), ((int)(((byte)(30)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(90, 12);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 41);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(172, 12);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 41);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Gray;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(255, 12);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 41);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "LÀM MỚI";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.label12);
            this.grbThongTin.Controls.Add(this.txtViTri);
            this.grbThongTin.Controls.Add(this.picAnhBia);
            this.grbThongTin.Controls.Add(this.btnUploadAnh);
            this.grbThongTin.Controls.Add(this.label2);
            this.grbThongTin.Controls.Add(this.txtIDSach);
            this.grbThongTin.Controls.Add(this.label3);
            this.grbThongTin.Controls.Add(this.txtNameSach);
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Controls.Add(this.txtTacGia);
            this.grbThongTin.Controls.Add(this.label5);
            this.grbThongTin.Controls.Add(this.txtNXB);
            this.grbThongTin.Controls.Add(this.label6);
            this.grbThongTin.Controls.Add(this.txtNamXB);
            this.grbThongTin.Controls.Add(this.label11);
            this.grbThongTin.Controls.Add(this.txtChuDe);
            this.grbThongTin.Controls.Add(this.label10);
            this.grbThongTin.Controls.Add(this.txtSoLuong);
            this.grbThongTin.Controls.Add(this.label8);
            this.grbThongTin.Controls.Add(this.cboTrangThai);
            this.grbThongTin.Controls.Add(this.labelISBN);
            this.grbThongTin.Controls.Add(this.txtISBN);
            this.grbThongTin.Controls.Add(this.btnGetInfo);
            this.grbThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbThongTin.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.grbThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.grbThongTin.Location = new System.Drawing.Point(8, 8);
            this.grbThongTin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbThongTin.Size = new System.Drawing.Size(341, 536);
            this.grbThongTin.TabIndex = 1;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "THÔNG TIN CHI TIẾT";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label12.Location = new System.Drawing.Point(15, 494);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 19);
            this.label12.TabIndex = 22;
            this.label12.Text = "Vị trí sách:";
            // 
            // txtViTri
            // 
            this.txtViTri.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtViTri.Location = new System.Drawing.Point(105, 492);
            this.txtViTri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(211, 25);
            this.txtViTri.TabIndex = 23;
            // 
            // picAnhBia
            // 
            this.picAnhBia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picAnhBia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhBia.Location = new System.Drawing.Point(105, 28);
            this.picAnhBia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picAnhBia.Name = "picAnhBia";
            this.picAnhBia.Size = new System.Drawing.Size(120, 179);
            this.picAnhBia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnhBia.TabIndex = 20;
            this.picAnhBia.TabStop = false;
            // 
            // btnUploadAnh
            // 
            this.btnUploadAnh.BackColor = System.Drawing.Color.Tan;
            this.btnUploadAnh.FlatAppearance.BorderSize = 0;
            this.btnUploadAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadAnh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUploadAnh.ForeColor = System.Drawing.Color.White;
            this.btnUploadAnh.Location = new System.Drawing.Point(232, 183);
            this.btnUploadAnh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUploadAnh.Name = "btnUploadAnh";
            this.btnUploadAnh.Size = new System.Drawing.Size(82, 24);
            this.btnUploadAnh.TabIndex = 19;
            this.btnUploadAnh.Text = "📁 Chọn ảnh";
            this.btnUploadAnh.UseVisualStyleBackColor = false;
            this.btnUploadAnh.Click += new System.EventHandler(this.btnUploadAnh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(15, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sách:";
            // 
            // txtIDSach
            // 
            this.txtIDSach.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIDSach.Enabled = false;
            this.txtIDSach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIDSach.Location = new System.Drawing.Point(105, 221);
            this.txtIDSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIDSach.Name = "txtIDSach";
            this.txtIDSach.ReadOnly = true;
            this.txtIDSach.Size = new System.Drawing.Size(84, 25);
            this.txtIDSach.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(15, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sách:";
            // 
            // txtNameSach
            // 
            this.txtNameSach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNameSach.Location = new System.Drawing.Point(105, 255);
            this.txtNameSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNameSach.Name = "txtNameSach";
            this.txtNameSach.Size = new System.Drawing.Size(211, 25);
            this.txtNameSach.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(15, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tác giả:";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTacGia.Location = new System.Drawing.Point(105, 289);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(211, 25);
            this.txtTacGia.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(15, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "NXB:";
            // 
            // txtNXB
            // 
            this.txtNXB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNXB.Location = new System.Drawing.Point(105, 323);
            this.txtNXB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(211, 25);
            this.txtNXB.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(15, 360);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Năm XB:";
            // 
            // txtNamXB
            // 
            this.txtNamXB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNamXB.Location = new System.Drawing.Point(105, 358);
            this.txtNamXB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(91, 25);
            this.txtNamXB.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label11.Location = new System.Drawing.Point(15, 394);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Chủ đề:";
            // 
            // txtChuDe
            // 
            this.txtChuDe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtChuDe.Location = new System.Drawing.Point(105, 392);
            this.txtChuDe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChuDe.Name = "txtChuDe";
            this.txtChuDe.Size = new System.Drawing.Size(211, 25);
            this.txtChuDe.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.Location = new System.Drawing.Point(15, 428);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSoLuong.Location = new System.Drawing.Point(105, 426);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(211, 25);
            this.txtSoLuong.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.Location = new System.Drawing.Point(15, 462);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(105, 460);
            this.cboTrangThai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(211, 25);
            this.cboTrangThai.TabIndex = 15;
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelISBN.Location = new System.Drawing.Point(15, 528);
            this.labelISBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(41, 19);
            this.labelISBN.TabIndex = 16;
            this.labelISBN.Text = "ISBN:";
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtISBN.Location = new System.Drawing.Point(105, 526);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(136, 25);
            this.txtISBN.TabIndex = 17;
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGetInfo.FlatAppearance.BorderSize = 0;
            this.btnGetInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGetInfo.ForeColor = System.Drawing.Color.White;
            this.btnGetInfo.Location = new System.Drawing.Point(248, 524);
            this.btnGetInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(68, 28);
            this.btnGetInfo.TabIndex = 18;
            this.btnGetInfo.Text = "🌐 Web";
            this.btnGetInfo.UseVisualStyleBackColor = false;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QuanLySach";
            this.Text = "Quản lý thư viện - Danh mục sách";
            this.Load += new System.EventHandler(this.QuanLySach_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwhowList)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.groupBoxAction.ResumeLayout(false);
            this.groupBoxAction.PerformLayout();
            this.pnlDetail.ResumeLayout(false);
            this.pnlButtonContainer.ResumeLayout(false);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhBia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // Controls chính
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgwhowList;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRsFilter;
        private System.Windows.Forms.ComboBox cboTacGia;
        private System.Windows.Forms.ComboBox cboChuDe;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.Label labelQR;
        private System.Windows.Forms.TextBox txtScanQR;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.PictureBox picAnhBia;
        private System.Windows.Forms.Button btnUploadAnh;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.TextBox txtIDSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChuDe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlButtonContainer;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtViTri;
    }
}