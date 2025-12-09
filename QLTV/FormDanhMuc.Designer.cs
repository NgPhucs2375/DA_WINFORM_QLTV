namespace QLTV
{
    partial class FormDanhMuc
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

            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNavNXB = new System.Windows.Forms.Button();
            this.btnNavTacGia = new System.Windows.Forms.Button();
            this.btnNavTheLoai = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            
            // --- Tab Thể Loại ---
            this.tabTheLoai = new System.Windows.Forms.TabPage();
            this.dgvTheLoai = new System.Windows.Forms.DataGridView();
            this.pnlTLInput = new System.Windows.Forms.Panel();
            this.txtSearchTL = new System.Windows.Forms.TextBox();
            this.labelSearchTL = new System.Windows.Forms.Label();
            this.btnHuyTL = new System.Windows.Forms.Button();
            this.btnXoaTL = new System.Windows.Forms.Button();
            this.btnSuaTL = new System.Windows.Forms.Button();
            this.btnThemTL = new System.Windows.Forms.Button();
            this.txtTenTL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();

            // --- Tab Tác Giả ---
            this.tabTacGia = new System.Windows.Forms.TabPage();
            this.dgvTacGia = new System.Windows.Forms.DataGridView();
            this.pnlTGInput = new System.Windows.Forms.Panel();
            this.txtSearchTG = new System.Windows.Forms.TextBox();
            this.labelSearchTG = new System.Windows.Forms.Label();
            this.btnHuyTG = new System.Windows.Forms.Button();
            this.btnXoaTG = new System.Windows.Forms.Button();
            this.btnSuaTG = new System.Windows.Forms.Button();
            this.btnThemTG = new System.Windows.Forms.Button();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();

            // --- Tab NXB ---
            this.tabNXB = new System.Windows.Forms.TabPage();
            this.dgvNXB = new System.Windows.Forms.DataGridView();
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

            this.pnlSidebar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTheLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).BeginInit();
            this.pnlTLInput.SuspendLayout();
            this.tabTacGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).BeginInit();
            this.pnlTGInput.SuspendLayout();
            this.tabNXB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            this.pnlNXBInput.SuspendLayout();
            this.SuspendLayout();

            // --- STYLE CHUNG ---
            headerStyle.BackColor = System.Drawing.Color.SeaGreen;
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            headerStyle.SelectionBackColor = System.Drawing.Color.SeaGreen;
            
            cellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            cellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(220, 230, 240);
            cellStyle.SelectionForeColor = System.Drawing.Color.Black;

            // 1. Sidebar
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(45, 50, 60);
            this.pnlSidebar.Controls.Add(this.btnNavNXB);
            this.pnlSidebar.Controls.Add(this.btnNavTacGia);
            this.pnlSidebar.Controls.Add(this.btnNavTheLoai);
            this.pnlSidebar.Controls.Add(this.lblTitle);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Size = new System.Drawing.Size(200, 600);

            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Size = new System.Drawing.Size(200, 80);
            this.lblTitle.Text = "DANH MỤC";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Nav Buttons
            this.btnNavTheLoai.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavTheLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTheLoai.ForeColor = System.Drawing.Color.White;
            this.btnNavTheLoai.Size = new System.Drawing.Size(200, 60);
            this.btnNavTheLoai.Text = "Thể Loại Sách";
            this.btnNavTheLoai.Click += new System.EventHandler(this.btnNavTheLoai_Click);

            this.btnNavTacGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavTacGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTacGia.ForeColor = System.Drawing.Color.White;
            this.btnNavTacGia.Size = new System.Drawing.Size(200, 60);
            this.btnNavTacGia.Text = "Tác Giả";
            this.btnNavTacGia.Click += new System.EventHandler(this.btnNavTacGia_Click);

            this.btnNavNXB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavNXB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavNXB.ForeColor = System.Drawing.Color.White;
            this.btnNavNXB.Size = new System.Drawing.Size(200, 60);
            this.btnNavNXB.Text = "Nhà Xuất Bản";
            this.btnNavNXB.Click += new System.EventHandler(this.btnNavNXB_Click);

            // 2. TabControl (Main Content)
            this.tabControl1.Controls.Add(this.tabTheLoai);
            this.tabControl1.Controls.Add(this.tabTacGia);
            this.tabControl1.Controls.Add(this.tabNXB);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(200, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 600);

            // === TAB THỂ LOẠI ===
            this.tabTheLoai.Controls.Add(this.dgvTheLoai);
            this.tabTheLoai.Controls.Add(this.pnlTLInput);
            this.tabTheLoai.Text = "Thể Loại";
            this.tabTheLoai.BackColor = System.Drawing.Color.WhiteSmoke;

            // Panel Input Thể Loại
            this.pnlTLInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTLInput.Height = 160;
            this.pnlTLInput.BackColor = System.Drawing.Color.White;
            this.pnlTLInput.Controls.Add(this.txtSearchTL);
            this.pnlTLInput.Controls.Add(this.labelSearchTL);
            this.pnlTLInput.Controls.Add(this.btnHuyTL);
            this.pnlTLInput.Controls.Add(this.btnXoaTL);
            this.pnlTLInput.Controls.Add(this.btnSuaTL);
            this.pnlTLInput.Controls.Add(this.btnThemTL);
            this.pnlTLInput.Controls.Add(this.txtTenTL);
            this.pnlTLInput.Controls.Add(this.label1);

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Text = "Tên thể loại:";
            this.txtTenTL.Location = new System.Drawing.Point(120, 27);
            this.txtTenTL.Size = new System.Drawing.Size(300, 25);

            // Buttons TL
            this.btnThemTL.Location = new System.Drawing.Point(450, 20); this.btnThemTL.Size = new System.Drawing.Size(80, 35); this.btnThemTL.Text = "Thêm"; this.btnThemTL.BackColor = System.Drawing.Color.SeaGreen; this.btnThemTL.ForeColor = System.Drawing.Color.White; this.btnThemTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnThemTL.Click += new System.EventHandler(this.btnThemTL_Click);
            this.btnSuaTL.Location = new System.Drawing.Point(540, 20); this.btnSuaTL.Size = new System.Drawing.Size(80, 35); this.btnSuaTL.Text = "Sửa"; this.btnSuaTL.BackColor = System.Drawing.Color.Orange; this.btnSuaTL.ForeColor = System.Drawing.Color.White; this.btnSuaTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnSuaTL.Click += new System.EventHandler(this.btnSuaTL_Click);
            this.btnXoaTL.Location = new System.Drawing.Point(630, 20); this.btnXoaTL.Size = new System.Drawing.Size(80, 35); this.btnXoaTL.Text = "Xóa"; this.btnXoaTL.BackColor = System.Drawing.Color.Crimson; this.btnXoaTL.ForeColor = System.Drawing.Color.White; this.btnXoaTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnXoaTL.Click += new System.EventHandler(this.btnXoaTL_Click);
            this.btnHuyTL.Location = new System.Drawing.Point(720, 20); this.btnHuyTL.Size = new System.Drawing.Size(60, 35); this.btnHuyTL.Text = "Hủy"; this.btnHuyTL.BackColor = System.Drawing.Color.Gray; this.btnHuyTL.ForeColor = System.Drawing.Color.White; this.btnHuyTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnHuyTL.Click += new System.EventHandler(this.btnHuyTL_Click);

            this.labelSearchTL.AutoSize = true; this.labelSearchTL.Location = new System.Drawing.Point(20, 100); this.labelSearchTL.Text = "Tìm kiếm:";
            this.txtSearchTL.Location = new System.Drawing.Point(120, 97); this.txtSearchTL.Size = new System.Drawing.Size(300, 25); this.txtSearchTL.TextChanged += new System.EventHandler(this.txtSearchTL_TextChanged);

            this.dgvTheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTheLoai.BackgroundColor = System.Drawing.Color.White;
            this.dgvTheLoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTheLoai.AllowUserToAddRows = false;
            this.dgvTheLoai.RowHeadersVisible = false;
            this.dgvTheLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTheLoai.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvTheLoai.DefaultCellStyle = cellStyle;
            this.dgvTheLoai.EnableHeadersVisualStyles = false;
            this.dgvTheLoai.ColumnHeadersHeight = 40;
            this.dgvTheLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTheLoai_CellClick);

            // === TAB TÁC GIẢ (Copy logic tương tự) ===
            this.tabTacGia.Controls.Add(this.dgvTacGia);
            this.tabTacGia.Controls.Add(this.pnlTGInput);
            this.tabTacGia.Text = "Tác Giả";
            this.tabTacGia.BackColor = System.Drawing.Color.WhiteSmoke;

            this.pnlTGInput.Dock = System.Windows.Forms.DockStyle.Top; this.pnlTGInput.Height = 160; this.pnlTGInput.BackColor = System.Drawing.Color.White;
            this.pnlTGInput.Controls.AddRange(new System.Windows.Forms.Control[] { this.txtSearchTG, this.labelSearchTG, this.btnHuyTG, this.btnXoaTG, this.btnSuaTG, this.btnThemTG, this.txtTenTG, this.label2 });

            this.label2.AutoSize = true; this.label2.Location = new System.Drawing.Point(20, 30); this.label2.Text = "Tên tác giả:";
            this.txtTenTG.Location = new System.Drawing.Point(120, 27); this.txtTenTG.Size = new System.Drawing.Size(300, 25);

            this.btnThemTG.Location = new System.Drawing.Point(450, 20); this.btnThemTG.Size = new System.Drawing.Size(80, 35); this.btnThemTG.Text = "Thêm"; this.btnThemTG.BackColor = System.Drawing.Color.SeaGreen; this.btnThemTG.ForeColor = System.Drawing.Color.White; this.btnThemTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnThemTG.Click += new System.EventHandler(this.btnThemTG_Click);
            this.btnSuaTG.Location = new System.Drawing.Point(540, 20); this.btnSuaTG.Size = new System.Drawing.Size(80, 35); this.btnSuaTG.Text = "Sửa"; this.btnSuaTG.BackColor = System.Drawing.Color.Orange; this.btnSuaTG.ForeColor = System.Drawing.Color.White; this.btnSuaTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnSuaTG.Click += new System.EventHandler(this.btnSuaTG_Click);
            this.btnXoaTG.Location = new System.Drawing.Point(630, 20); this.btnXoaTG.Size = new System.Drawing.Size(80, 35); this.btnXoaTG.Text = "Xóa"; this.btnXoaTG.BackColor = System.Drawing.Color.Crimson; this.btnXoaTG.ForeColor = System.Drawing.Color.White; this.btnXoaTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnXoaTG.Click += new System.EventHandler(this.btnXoaTG_Click);
            this.btnHuyTG.Location = new System.Drawing.Point(720, 20); this.btnHuyTG.Size = new System.Drawing.Size(60, 35); this.btnHuyTG.Text = "Hủy"; this.btnHuyTG.BackColor = System.Drawing.Color.Gray; this.btnHuyTG.ForeColor = System.Drawing.Color.White; this.btnHuyTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnHuyTG.Click += new System.EventHandler(this.btnHuyTG_Click);

            this.labelSearchTG.AutoSize = true; this.labelSearchTG.Location = new System.Drawing.Point(20, 100); this.labelSearchTG.Text = "Tìm kiếm:";
            this.txtSearchTG.Location = new System.Drawing.Point(120, 97); this.txtSearchTG.Size = new System.Drawing.Size(300, 25); this.txtSearchTG.TextChanged += new System.EventHandler(this.txtSearchTG_TextChanged);

            this.dgvTacGia.Dock = System.Windows.Forms.DockStyle.Fill; this.dgvTacGia.BackgroundColor = System.Drawing.Color.White; this.dgvTacGia.BorderStyle = System.Windows.Forms.BorderStyle.None; this.dgvTacGia.AllowUserToAddRows = false; this.dgvTacGia.RowHeadersVisible = false; this.dgvTacGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; this.dgvTacGia.ColumnHeadersDefaultCellStyle = headerStyle; this.dgvTacGia.DefaultCellStyle = cellStyle; this.dgvTacGia.EnableHeadersVisualStyles = false; this.dgvTacGia.ColumnHeadersHeight = 40;
            this.dgvTacGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTacGia_CellClick);

            // === TAB NXB ===
            this.tabNXB.Controls.Add(this.dgvNXB);
            this.tabNXB.Controls.Add(this.pnlNXBInput);
            this.tabNXB.Text = "Nhà Xuất Bản";
            this.tabNXB.BackColor = System.Drawing.Color.WhiteSmoke;

            this.pnlNXBInput.Dock = System.Windows.Forms.DockStyle.Top; this.pnlNXBInput.Height = 160; this.pnlNXBInput.BackColor = System.Drawing.Color.White;
            this.pnlNXBInput.Controls.AddRange(new System.Windows.Forms.Control[] { this.txtSearchNXB, this.labelSearchNXB, this.btnHuyNXB, this.btnXoaNXB, this.btnSuaNXB, this.btnThemNXB, this.txtSdtNXB, this.label4, this.txtTenNXB, this.label3 });

            this.label3.AutoSize = true; this.label3.Location = new System.Drawing.Point(20, 30); this.label3.Text = "Tên NXB:";
            this.txtTenNXB.Location = new System.Drawing.Point(120, 27); this.txtTenNXB.Size = new System.Drawing.Size(300, 25);
            this.label4.AutoSize = true; this.label4.Location = new System.Drawing.Point(20, 70); this.label4.Text = "Số ĐT:";
            this.txtSdtNXB.Location = new System.Drawing.Point(120, 67); this.txtSdtNXB.Size = new System.Drawing.Size(300, 25);

            this.btnThemNXB.Location = new System.Drawing.Point(450, 20); this.btnThemNXB.Size = new System.Drawing.Size(80, 35); this.btnThemNXB.Text = "Thêm"; this.btnThemNXB.BackColor = System.Drawing.Color.SeaGreen; this.btnThemNXB.ForeColor = System.Drawing.Color.White; this.btnThemNXB.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnThemNXB.Click += new System.EventHandler(this.btnThemNXB_Click);
            this.btnSuaNXB.Location = new System.Drawing.Point(540, 20); this.btnSuaNXB.Size = new System.Drawing.Size(80, 35); this.btnSuaNXB.Text = "Sửa"; this.btnSuaNXB.BackColor = System.Drawing.Color.Orange; this.btnSuaNXB.ForeColor = System.Drawing.Color.White; this.btnSuaNXB.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnSuaNXB.Click += new System.EventHandler(this.btnSuaNXB_Click);
            this.btnXoaNXB.Location = new System.Drawing.Point(630, 20); this.btnXoaNXB.Size = new System.Drawing.Size(80, 35); this.btnXoaNXB.Text = "Xóa"; this.btnXoaNXB.BackColor = System.Drawing.Color.Crimson; this.btnXoaNXB.ForeColor = System.Drawing.Color.White; this.btnXoaNXB.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnXoaNXB.Click += new System.EventHandler(this.btnXoaNXB_Click);
            this.btnHuyNXB.Location = new System.Drawing.Point(720, 20); this.btnHuyNXB.Size = new System.Drawing.Size(60, 35); this.btnHuyNXB.Text = "Hủy"; this.btnHuyNXB.BackColor = System.Drawing.Color.Gray; this.btnHuyNXB.ForeColor = System.Drawing.Color.White; this.btnHuyNXB.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnHuyNXB.Click += new System.EventHandler(this.btnHuyNXB_Click);

            this.labelSearchNXB.AutoSize = true; this.labelSearchNXB.Location = new System.Drawing.Point(20, 115); this.labelSearchNXB.Text = "Tìm kiếm:";
            this.txtSearchNXB.Location = new System.Drawing.Point(120, 112); this.txtSearchNXB.Size = new System.Drawing.Size(300, 25); this.txtSearchNXB.TextChanged += new System.EventHandler(this.txtSearchNXB_TextChanged);

            this.dgvNXB.Dock = System.Windows.Forms.DockStyle.Fill; this.dgvNXB.BackgroundColor = System.Drawing.Color.White; this.dgvNXB.BorderStyle = System.Windows.Forms.BorderStyle.None; this.dgvNXB.AllowUserToAddRows = false; this.dgvNXB.RowHeadersVisible = false; this.dgvNXB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; this.dgvNXB.ColumnHeadersDefaultCellStyle = headerStyle; this.dgvNXB.DefaultCellStyle = cellStyle; this.dgvNXB.EnableHeadersVisualStyles = false; this.dgvNXB.ColumnHeadersHeight = 40;
            this.dgvNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNXB_CellClick);

            // Form Config
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "FormDanhMuc";
            this.Text = "Quản Lý Danh Mục";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.pnlSidebar.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabTheLoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).EndInit();
            this.pnlTLInput.ResumeLayout(false);
            this.pnlTLInput.PerformLayout();
            this.tabTacGia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).EndInit();
            this.pnlTGInput.ResumeLayout(false);
            this.pnlTGInput.PerformLayout();
            this.tabNXB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
            this.pnlNXBInput.ResumeLayout(false);
            this.pnlNXBInput.PerformLayout();
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