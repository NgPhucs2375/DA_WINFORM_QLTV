namespace QLTV
{
    partial class QuanLyNV
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
            this.radTenNV = new System.Windows.Forms.RadioButton();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.radMaNV = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchingNV = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSDTNV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpkNgayVLNV = new System.Windows.Forms.DateTimePicker();
            this.cboVaiTro = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMatKhauNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmailNV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnHTDanhSach = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radTenNV
            // 
            this.radTenNV.AutoSize = true;
            this.radTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenNV.Location = new System.Drawing.Point(57, 71);
            this.radTenNV.Name = "radTenNV";
            this.radTenNV.Size = new System.Drawing.Size(162, 29);
            this.radTenNV.TabIndex = 3;
            this.radTenNV.TabStop = true;
            this.radTenNV.Text = "Tên nhân viên";
            this.radTenNV.UseVisualStyleBackColor = true;
            this.radTenNV.CheckedChanged += new System.EventHandler(this.radTenNV_CheckedChanged);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(32, 103);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(598, 35);
            this.txtKeyword.TabIndex = 1;
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            // 
            // radMaNV
            // 
            this.radMaNV.AutoSize = true;
            this.radMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaNV.Location = new System.Drawing.Point(57, 40);
            this.radMaNV.Name = "radMaNV";
            this.radMaNV.Size = new System.Drawing.Size(155, 29);
            this.radMaNV.TabIndex = 2;
            this.radMaNV.TabStop = true;
            this.radMaNV.Text = "Mã nhân viên";
            this.radMaNV.UseVisualStyleBackColor = true;
            this.radMaNV.CheckedChanged += new System.EventHandler(this.radMaNV_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHTDanhSach);
            this.groupBox1.Controls.Add(this.radMaNV);
            this.groupBox1.Controls.Add(this.radTenNV);
            this.groupBox1.Controls.Add(this.txtKeyword);
            this.groupBox1.Controls.Add(this.btnSearchingNV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 478);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm nhân viên";
            // 
            // btnSearchingNV
            // 
            this.btnSearchingNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchingNV.Location = new System.Drawing.Point(89, 165);
            this.btnSearchingNV.Name = "btnSearchingNV";
            this.btnSearchingNV.Size = new System.Drawing.Size(462, 46);
            this.btnSearchingNV.TabIndex = 2;
            this.btnSearchingNV.Text = "Tìm kiếm";
            this.btnSearchingNV.UseVisualStyleBackColor = true;
            this.btnSearchingNV.Click += new System.EventHandler(this.btnSearchingNV_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 31);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 62;
            this.dgvNhanVien.RowTemplate.Height = 28;
            this.dgvNhanVien.Size = new System.Drawing.Size(1562, 538);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvNhanVien);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 478);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1568, 572);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã NV:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(138, 52);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(225, 30);
            this.txtMaNV.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên NV:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(138, 88);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(225, 30);
            this.txtTenNV.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Chức vụ:";
            // 
            // btnThemNV
            // 
            this.btnThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.Location = new System.Drawing.Point(29, 264);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(147, 38);
            this.btnThemNV.TabIndex = 3;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNV.Location = new System.Drawing.Point(234, 264);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(147, 38);
            this.btnSuaNV.TabIndex = 17;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = true;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNV.Location = new System.Drawing.Point(432, 264);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(147, 38);
            this.btnXoaNV.TabIndex = 18;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSDTNV);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dtpkNgayVLNV);
            this.groupBox2.Controls.Add(this.cboVaiTro);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtMatKhauNV);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtEmailNV);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnXoaNV);
            this.groupBox2.Controls.Add(this.btnSuaNV);
            this.groupBox2.Controls.Add(this.btnThemNV);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTenNV);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMaNV);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(791, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 478);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhân viên";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtSDTNV
            // 
            this.txtSDTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTNV.Location = new System.Drawing.Point(138, 129);
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.Size = new System.Drawing.Size(225, 30);
            this.txtSDTNV.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = "SDT:";
            // 
            // dtpkNgayVLNV
            // 
            this.dtpkNgayVLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayVLNV.Location = new System.Drawing.Point(533, 125);
            this.dtpkNgayVLNV.Name = "dtpkNgayVLNV";
            this.dtpkNgayVLNV.Size = new System.Drawing.Size(225, 26);
            this.dtpkNgayVLNV.TabIndex = 27;
            // 
            // cboVaiTro
            // 
            this.cboVaiTro.FormattingEnabled = true;
            this.cboVaiTro.Location = new System.Drawing.Point(138, 165);
            this.cboVaiTro.Name = "cboVaiTro";
            this.cboVaiTro.Size = new System.Drawing.Size(225, 37);
            this.cboVaiTro.TabIndex = 26;
            this.cboVaiTro.SelectedIndexChanged += new System.EventHandler(this.cboVaiTro_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(422, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "NGày vào:";
            // 
            // txtMatKhauNV
            // 
            this.txtMatKhauNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauNV.Location = new System.Drawing.Point(533, 86);
            this.txtMatKhauNV.Name = "txtMatKhauNV";
            this.txtMatKhauNV.Size = new System.Drawing.Size(225, 30);
            this.txtMatKhauNV.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(419, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Mật khẩu:";
            // 
            // txtEmailNV
            // 
            this.txtEmailNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailNV.Location = new System.Drawing.Point(533, 50);
            this.txtEmailNV.Name = "txtEmailNV";
            this.txtEmailNV.Size = new System.Drawing.Size(225, 30);
            this.txtEmailNV.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(422, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Email:";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(624, 264);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(147, 38);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnHTDanhSach
            // 
            this.btnHTDanhSach.Location = new System.Drawing.Point(24, 264);
            this.btnHTDanhSach.Name = "btnHTDanhSach";
            this.btnHTDanhSach.Size = new System.Drawing.Size(169, 44);
            this.btnHTDanhSach.TabIndex = 9;
            this.btnHTDanhSach.Text = "Hiển thị danh sách";
            this.btnHTDanhSach.UseVisualStyleBackColor = true;
            this.btnHTDanhSach.Click += new System.EventHandler(this.btnHTDanhSach_Click);
            // 
            // QuanLyNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1568, 1050);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.MinimizeBox = false;
            this.Name = "QuanLyNV";
            this.Text = "Quản lý tác giả";
            this.Load += new System.EventHandler(this.QuanLyTG_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radTenNV;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.RadioButton radMaNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSearchingNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHTDanhSach;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtMatKhauNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmailNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboVaiTro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpkNgayVLNV;
        private System.Windows.Forms.TextBox txtSDTNV;
        private System.Windows.Forms.Label label10;
    }
}