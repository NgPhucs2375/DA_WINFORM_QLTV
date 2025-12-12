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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgwhowList = new System.Windows.Forms.DataGridView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnRsFilter = new System.Windows.Forms.Button();
            this.cboTacGia = new System.Windows.Forms.ComboBox();
            this.cboChuDe = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbChiTiet = new System.Windows.Forms.GroupBox();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.labelISBN = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtChuDe = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwhowList)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.grbChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1437, 88);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(22, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(312, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ SÁCH";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 88);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgwhowList);
            this.splitContainer1.Panel1.Controls.Add(this.pnlSearch);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.grbChiTiet);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.splitContainer1.Size = new System.Drawing.Size(1437, 662);
            this.splitContainer1.SplitterDistance = 989;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgwhowList
            // 
            this.dgwhowList.AllowUserToAddRows = false;
            this.dgwhowList.ColumnHeadersHeight = 34;
            this.dgwhowList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwhowList.Location = new System.Drawing.Point(11, 87);
            this.dgwhowList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwhowList.Name = "dgwhowList";
            this.dgwhowList.ReadOnly = true;
            this.dgwhowList.RowHeadersVisible = false;
            this.dgwhowList.RowHeadersWidth = 62;
            this.dgwhowList.RowTemplate.Height = 30;
            this.dgwhowList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwhowList.Size = new System.Drawing.Size(967, 563);
            this.dgwhowList.TabIndex = 1;
            this.dgwhowList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwhowList_CellClick);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSearch.Controls.Add(this.btnRsFilter);
            this.pnlSearch.Controls.Add(this.cboTacGia);
            this.pnlSearch.Controls.Add(this.cboChuDe);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.label1);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(11, 12);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(967, 75);
            this.pnlSearch.TabIndex = 0;
            // 
            // btnRsFilter
            // 
            this.btnRsFilter.BackColor = System.Drawing.Color.Crimson;
            this.btnRsFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRsFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRsFilter.Location = new System.Drawing.Point(780, 11);
            this.btnRsFilter.Name = "btnRsFilter";
            this.btnRsFilter.Size = new System.Drawing.Size(109, 47);
            this.btnRsFilter.TabIndex = 4;
            this.btnRsFilter.Text = "Reset";
            this.btnRsFilter.UseVisualStyleBackColor = false;
            this.btnRsFilter.Click += new System.EventHandler(this.btnRsFilter_Click_1);
            // 
            // cboTacGia
            // 
            this.cboTacGia.FormattingEnabled = true;
            this.cboTacGia.Location = new System.Drawing.Point(613, 22);
            this.cboTacGia.Name = "cboTacGia";
            this.cboTacGia.Size = new System.Drawing.Size(151, 28);
            this.cboTacGia.TabIndex = 3;
            this.cboTacGia.SelectedIndexChanged += new System.EventHandler(this.cboTacGia_SelectedIndexChanged);
            // 
            // cboChuDe
            // 
            this.cboChuDe.FormattingEnabled = true;
            this.cboChuDe.Location = new System.Drawing.Point(448, 22);
            this.cboChuDe.Name = "cboChuDe";
            this.cboChuDe.Size = new System.Drawing.Size(159, 28);
            this.cboChuDe.TabIndex = 2;
            this.cboChuDe.SelectedIndexChanged += new System.EventHandler(this.cboChuDe_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Location = new System.Drawing.Point(124, 18);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(286, 37);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm:";
            // 
            // grbChiTiet
            // 
            this.grbChiTiet.Controls.Add(this.btnGetInfo);
            this.grbChiTiet.Controls.Add(this.txtISBN);
            this.grbChiTiet.Controls.Add(this.labelISBN);
            this.grbChiTiet.Controls.Add(this.btnReset);
            this.grbChiTiet.Controls.Add(this.btnXoa);
            this.grbChiTiet.Controls.Add(this.btnSua);
            this.grbChiTiet.Controls.Add(this.btnThem);
            this.grbChiTiet.Controls.Add(this.cboTrangThai);
            this.grbChiTiet.Controls.Add(this.label8);
            this.grbChiTiet.Controls.Add(this.txtSoLuong);
            this.grbChiTiet.Controls.Add(this.label10);
            this.grbChiTiet.Controls.Add(this.txtChuDe);
            this.grbChiTiet.Controls.Add(this.label11);
            this.grbChiTiet.Controls.Add(this.txtNamXB);
            this.grbChiTiet.Controls.Add(this.label6);
            this.grbChiTiet.Controls.Add(this.txtNXB);
            this.grbChiTiet.Controls.Add(this.label5);
            this.grbChiTiet.Controls.Add(this.txtTacGia);
            this.grbChiTiet.Controls.Add(this.label4);
            this.grbChiTiet.Controls.Add(this.txtNameSach);
            this.grbChiTiet.Controls.Add(this.label3);
            this.grbChiTiet.Controls.Add(this.txtIDSach);
            this.grbChiTiet.Controls.Add(this.label2);
            this.grbChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbChiTiet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grbChiTiet.Location = new System.Drawing.Point(11, 12);
            this.grbChiTiet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbChiTiet.Name = "grbChiTiet";
            this.grbChiTiet.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbChiTiet.Size = new System.Drawing.Size(422, 638);
            this.grbChiTiet.TabIndex = 0;
            this.grbChiTiet.TabStop = false;
            this.grbChiTiet.Text = "Thông tin sách";
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGetInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetInfo.ForeColor = System.Drawing.Color.White;
            this.btnGetInfo.Location = new System.Drawing.Point(315, 469);
            this.btnGetInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(90, 40);
            this.btnGetInfo.TabIndex = 18;
            this.btnGetInfo.Text = "Web";
            this.btnGetInfo.UseVisualStyleBackColor = false;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(135, 471);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(168, 34);
            this.txtISBN.TabIndex = 17;
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(22, 475);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(58, 28);
            this.labelISBN.TabIndex = 16;
            this.labelISBN.Text = "ISBN:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Gray;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(225, 600);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(169, 50);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "LÀM MỚI";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Crimson;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(28, 600);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(169, 50);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Orange;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(225, 538);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(169, 50);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SeaGreen;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(28, 538);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(169, 50);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(135, 425);
            this.cboTrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(258, 36);
            this.cboTrangThai.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 429);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "Trạng thái:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(135, 384);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(258, 34);
            this.txtSoLuong.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 28);
            this.label10.TabIndex = 12;
            this.label10.Text = "Số lượng:";
            // 
            // txtChuDe
            // 
            this.txtChuDe.Location = new System.Drawing.Point(135, 328);
            this.txtChuDe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChuDe.Name = "txtChuDe";
            this.txtChuDe.Size = new System.Drawing.Size(258, 34);
            this.txtChuDe.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 28);
            this.label11.TabIndex = 10;
            this.label11.Text = "Chủ đề:";
            // 
            // txtNamXB
            // 
            this.txtNamXB.Location = new System.Drawing.Point(135, 271);
            this.txtNamXB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(258, 34);
            this.txtNamXB.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Năm XB:";
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(135, 215);
            this.txtNXB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(258, 34);
            this.txtNXB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "NXB:";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(135, 159);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(258, 34);
            this.txtTacGia.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tác giả:";
            // 
            // txtNameSach
            // 
            this.txtNameSach.Location = new System.Drawing.Point(135, 102);
            this.txtNameSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNameSach.Name = "txtNameSach";
            this.txtNameSach.Size = new System.Drawing.Size(258, 34);
            this.txtNameSach.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sách:";
            // 
            // txtIDSach
            // 
            this.txtIDSach.Enabled = false;
            this.txtIDSach.Location = new System.Drawing.Point(135, 46);
            this.txtIDSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDSach.Name = "txtIDSach";
            this.txtIDSach.ReadOnly = true;
            this.txtIDSach.Size = new System.Drawing.Size(258, 34);
            this.txtIDSach.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sách:";
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 750);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuanLySach";
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.QuanLySach_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwhowList)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.grbChiTiet.ResumeLayout(false);
            this.grbChiTiet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgwhowList;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbChiTiet;
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
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGetInfo; // Mới
        private System.Windows.Forms.TextBox txtISBN; // Mới
        private System.Windows.Forms.Label labelISBN; // Mới
        private System.Windows.Forms.ComboBox cboTacGia;
        private System.Windows.Forms.ComboBox cboChuDe;
        private System.Windows.Forms.Button btnRsFilter;
    }
}