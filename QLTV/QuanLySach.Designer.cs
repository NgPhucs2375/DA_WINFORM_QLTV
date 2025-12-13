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
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.labelQR = new System.Windows.Forms.Label();
            this.txtScanQR = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbChiTiet = new System.Windows.Forms.GroupBox();
            this.picAnhBia = new System.Windows.Forms.PictureBox();
            this.btnUploadAnh = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.picAnhBia)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(377, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ SÁCH & KHO";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 70);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgwhowList);
            this.splitContainer1.Panel1.Controls.Add(this.pnlSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grbChiTiet);
            this.splitContainer1.Size = new System.Drawing.Size(1200, 630);
            this.splitContainer1.SplitterDistance = 800;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgwhowList
            // 
            this.dgwhowList.AllowUserToAddRows = false;
            this.dgwhowList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwhowList.Location = new System.Drawing.Point(0, 100);
            this.dgwhowList.Name = "dgwhowList";
            this.dgwhowList.ReadOnly = true;
            this.dgwhowList.RowHeadersVisible = false;
            this.dgwhowList.RowTemplate.Height = 30;
            this.dgwhowList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwhowList.Size = new System.Drawing.Size(800, 530);
            this.dgwhowList.TabIndex = 1;
            this.dgwhowList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwhowList_CellClick);
            this.dgwhowList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwhowList_CellDoubleClick);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSearch.Controls.Add(this.btnImportExcel);
            this.pnlSearch.Controls.Add(this.labelQR);
            this.pnlSearch.Controls.Add(this.txtScanQR);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.label1);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(800, 100);
            this.pnlSearch.TabIndex = 0;
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.BackColor = System.Drawing.Color.DarkGreen;
            this.btnImportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportExcel.ForeColor = System.Drawing.Color.White;
            this.btnImportExcel.Location = new System.Drawing.Point(450, 55);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(150, 30);
            this.btnImportExcel.TabIndex = 4;
            this.btnImportExcel.Text = "NHẬP TỪ EXCEL";
            this.btnImportExcel.UseVisualStyleBackColor = false;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // labelQR
            // 
            this.labelQR.AutoSize = true;
            this.labelQR.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelQR.ForeColor = System.Drawing.Color.Red;
            this.labelQR.Location = new System.Drawing.Point(20, 60);
            this.labelQR.Name = "labelQR";
            this.labelQR.Size = new System.Drawing.Size(127, 23);
            this.labelQR.TabIndex = 3;
            this.labelQR.Text = "SCAN QR/ISBN:";
            // 
            // txtScanQR
            // 
            this.txtScanQR.BackColor = System.Drawing.Color.LightYellow;
            this.txtScanQR.Location = new System.Drawing.Point(160, 57);
            this.txtScanQR.Name = "txtScanQR";
            this.txtScanQR.Size = new System.Drawing.Size(260, 22);
            this.txtScanQR.TabIndex = 2;
            this.txtScanQR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScanQR_KeyDown);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Location = new System.Drawing.Point(100, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 32);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm:";
            // 
            // grbChiTiet
            // 
            this.grbChiTiet.BackColor = System.Drawing.Color.White;
            this.grbChiTiet.Controls.Add(this.picAnhBia);
            this.grbChiTiet.Controls.Add(this.btnUploadAnh);
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
            this.grbChiTiet.Location = new System.Drawing.Point(0, 0);
            this.grbChiTiet.Name = "grbChiTiet";
            this.grbChiTiet.Size = new System.Drawing.Size(396, 630);
            this.grbChiTiet.TabIndex = 0;
            this.grbChiTiet.TabStop = false;
            this.grbChiTiet.Text = "Thông tin sách";
            // 
            // picAnhBia
            // 
            this.picAnhBia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhBia.Location = new System.Drawing.Point(240, 30);
            this.picAnhBia.Name = "picAnhBia";
            this.picAnhBia.Size = new System.Drawing.Size(120, 160);
            this.picAnhBia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnhBia.TabIndex = 20;
            this.picAnhBia.TabStop = false;
            // 
            // btnUploadAnh
            // 
            this.btnUploadAnh.Location = new System.Drawing.Point(240, 200);
            this.btnUploadAnh.Name = "btnUploadAnh";
            this.btnUploadAnh.Size = new System.Drawing.Size(120, 30);
            this.btnUploadAnh.TabIndex = 19;
            this.btnUploadAnh.Text = "Chọn ảnh...";
            this.btnUploadAnh.UseVisualStyleBackColor = true;
            this.btnUploadAnh.Click += new System.EventHandler(this.btnUploadAnh_Click);
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGetInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetInfo.ForeColor = System.Drawing.Color.White;
            this.btnGetInfo.Location = new System.Drawing.Point(280, 375);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(80, 32);
            this.btnGetInfo.TabIndex = 18;
            this.btnGetInfo.Text = "Web";
            this.btnGetInfo.UseVisualStyleBackColor = false;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(120, 377);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(150, 30);
            this.txtISBN.TabIndex = 17;
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(20, 380);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(50, 23);
            this.labelISBN.TabIndex = 16;
            this.labelISBN.Text = "ISBN:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Gray;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(200, 480);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 40);
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
            this.btnXoa.Location = new System.Drawing.Point(25, 480);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 40);
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
            this.btnSua.Location = new System.Drawing.Point(200, 430);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(150, 40);
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
            this.btnThem.Location = new System.Drawing.Point(25, 430);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 40);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(120, 340);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(230, 31);
            this.cboTrangThai.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Trạng thái:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(120, 307);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(230, 30);
            this.txtSoLuong.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Số lượng:";
            // 
            // txtChuDe
            // 
            this.txtChuDe.Location = new System.Drawing.Point(120, 262);
            this.txtChuDe.Name = "txtChuDe";
            this.txtChuDe.Size = new System.Drawing.Size(230, 30);
            this.txtChuDe.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "Chủ đề:";
            // 
            // txtNamXB
            // 
            this.txtNamXB.Location = new System.Drawing.Point(120, 217);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(110, 30);
            this.txtNamXB.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Năm XB:";
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(120, 172);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(230, 30);
            this.txtNXB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "NXB:";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(120, 127);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(230, 30);
            this.txtTacGia.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tác giả:";
            // 
            // txtNameSach
            // 
            this.txtNameSach.Location = new System.Drawing.Point(120, 82);
            this.txtNameSach.Name = "txtNameSach";
            this.txtNameSach.Size = new System.Drawing.Size(230, 30);
            this.txtNameSach.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sách:";
            // 
            // txtIDSach
            // 
            this.txtIDSach.Enabled = false;
            this.txtIDSach.Location = new System.Drawing.Point(120, 37);
            this.txtIDSach.Name = "txtIDSach";
            this.txtIDSach.ReadOnly = true;
            this.txtIDSach.Size = new System.Drawing.Size(110, 30);
            this.txtIDSach.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sách:";
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "QuanLySach";
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.QuanLySach_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwhowList)).EndInit();
            this.grbChiTiet.ResumeLayout(false);
            this.grbChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhBia)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // Controls
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgwhowList;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbChiTiet;
        // New Controls
        private System.Windows.Forms.TextBox txtScanQR;
        private System.Windows.Forms.Label labelQR;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.PictureBox picAnhBia;
        private System.Windows.Forms.Button btnUploadAnh;
        // Existing Controls
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
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label labelISBN;
    }
}