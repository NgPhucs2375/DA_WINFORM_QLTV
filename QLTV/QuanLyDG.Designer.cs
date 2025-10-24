namespace QLTV
{
    partial class QuanLyDG
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGVDSDocGia = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxVaiTroDG = new System.Windows.Forms.ComboBox();
            this.btnXoaDG = new System.Windows.Forms.Button();
            this.btnSuaDG = new System.Windows.Forms.Button();
            this.btnThemDG = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSDTDG = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPassDG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmailDG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textMaDG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radMaDG = new System.Windows.Forms.RadioButton();
            this.radTenDG = new System.Windows.Forms.RadioButton();
            this.txtSearchingDG = new System.Windows.Forms.TextBox();
            this.btnSearchingDG = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHTDanhSach = new System.Windows.Forms.Button();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNgayTao = new System.Windows.Forms.TextBox();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDSDocGia)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGVDSDocGia);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 485);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1284, 553);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách ĐG";
            // 
            // dataGVDSDocGia
            // 
            this.dataGVDSDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDSDocGia.Location = new System.Drawing.Point(6, 63);
            this.dataGVDSDocGia.Name = "dataGVDSDocGia";
            this.dataGVDSDocGia.RowHeadersWidth = 62;
            this.dataGVDSDocGia.RowTemplate.Height = 28;
            this.dataGVDSDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVDSDocGia.Size = new System.Drawing.Size(1269, 484);
            this.dataGVDSDocGia.TabIndex = 0;
            this.dataGVDSDocGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVDSDocGia_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpNgayHetHan);
            this.groupBox2.Controls.Add(this.txtNgayTao);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cboTrangThai);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbxVaiTroDG);
            this.groupBox2.Controls.Add(this.btnXoaDG);
            this.groupBox2.Controls.Add(this.btnSuaDG);
            this.groupBox2.Controls.Add(this.btnThemDG);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSDTDG);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtPassDG);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtEmailDG);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTenDG);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textMaDG);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(519, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 432);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin độc giả";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cbxVaiTroDG
            // 
            this.cbxVaiTroDG.FormattingEnabled = true;
            this.cbxVaiTroDG.Location = new System.Drawing.Point(543, 49);
            this.cbxVaiTroDG.Name = "cbxVaiTroDG";
            this.cbxVaiTroDG.Size = new System.Drawing.Size(225, 37);
            this.cbxVaiTroDG.TabIndex = 20;
            // 
            // btnXoaDG
            // 
            this.btnXoaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDG.Location = new System.Drawing.Point(595, 346);
            this.btnXoaDG.Name = "btnXoaDG";
            this.btnXoaDG.Size = new System.Drawing.Size(147, 38);
            this.btnXoaDG.TabIndex = 18;
            this.btnXoaDG.Text = "Xóa";
            this.btnXoaDG.UseVisualStyleBackColor = true;
            this.btnXoaDG.Click += new System.EventHandler(this.btnXoaDG_Click);
            // 
            // btnSuaDG
            // 
            this.btnSuaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDG.Location = new System.Drawing.Point(330, 346);
            this.btnSuaDG.Name = "btnSuaDG";
            this.btnSuaDG.Size = new System.Drawing.Size(147, 38);
            this.btnSuaDG.TabIndex = 17;
            this.btnSuaDG.Text = "Sửa";
            this.btnSuaDG.UseVisualStyleBackColor = true;
            this.btnSuaDG.Click += new System.EventHandler(this.btnSuaDG_Click);
            // 
            // btnThemDG
            // 
            this.btnThemDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDG.Location = new System.Drawing.Point(29, 346);
            this.btnThemDG.Name = "btnThemDG";
            this.btnThemDG.Size = new System.Drawing.Size(147, 38);
            this.btnThemDG.TabIndex = 3;
            this.btnThemDG.Text = "Thêm";
            this.btnThemDG.UseVisualStyleBackColor = true;
            this.btnThemDG.Click += new System.EventHandler(this.btnThemDG_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "SĐT:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(391, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ngày tạo:";
            // 
            // txtSDTDG
            // 
            this.txtSDTDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTDG.Location = new System.Drawing.Point(138, 224);
            this.txtSDTDG.Name = "txtSDTDG";
            this.txtSDTDG.Size = new System.Drawing.Size(225, 30);
            this.txtSDTDG.TabIndex = 10;
            this.txtSDTDG.TextChanged += new System.EventHandler(this.txtSDTDG_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(391, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "Vai trò:";
            // 
            // txtPassDG
            // 
            this.txtPassDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassDG.Location = new System.Drawing.Point(138, 179);
            this.txtPassDG.Name = "txtPassDG";
            this.txtPassDG.Size = new System.Drawing.Size(225, 30);
            this.txtPassDG.TabIndex = 8;
            this.txtPassDG.TextChanged += new System.EventHandler(this.txtPassDG_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mật khẩu:";
            // 
            // txtEmailDG
            // 
            this.txtEmailDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailDG.Location = new System.Drawing.Point(138, 133);
            this.txtEmailDG.Name = "txtEmailDG";
            this.txtEmailDG.Size = new System.Drawing.Size(225, 30);
            this.txtEmailDG.TabIndex = 6;
            this.txtEmailDG.TextChanged += new System.EventHandler(this.txtEmailDG_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // txtTenDG
            // 
            this.txtTenDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDG.Location = new System.Drawing.Point(138, 93);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.Size = new System.Drawing.Size(225, 30);
            this.txtTenDG.TabIndex = 4;
            this.txtTenDG.TextChanged += new System.EventHandler(this.txtTenDG_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên ĐG:";
            // 
            // textMaDG
            // 
            this.textMaDG.Enabled = false;
            this.textMaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMaDG.Location = new System.Drawing.Point(138, 52);
            this.textMaDG.Name = "textMaDG";
            this.textMaDG.Size = new System.Drawing.Size(225, 30);
            this.textMaDG.TabIndex = 2;
            this.textMaDG.TextChanged += new System.EventHandler(this.textMaDG_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã ĐG:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radMaDG);
            this.groupBox1.Controls.Add(this.radTenDG);
            this.groupBox1.Controls.Add(this.txtSearchingDG);
            this.groupBox1.Controls.Add(this.btnSearchingDG);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 268);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm độc giả";
            // 
            // radMaDG
            // 
            this.radMaDG.AutoSize = true;
            this.radMaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaDG.Location = new System.Drawing.Point(11, 149);
            this.radMaDG.Name = "radMaDG";
            this.radMaDG.Size = new System.Drawing.Size(213, 29);
            this.radMaDG.TabIndex = 2;
            this.radMaDG.TabStop = true;
            this.radMaDG.Text = "Tìm theo mã độc giả";
            this.radMaDG.UseVisualStyleBackColor = true;
            // 
            // radTenDG
            // 
            this.radTenDG.AutoSize = true;
            this.radTenDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenDG.Location = new System.Drawing.Point(11, 114);
            this.radTenDG.Name = "radTenDG";
            this.radTenDG.Size = new System.Drawing.Size(213, 29);
            this.radTenDG.TabIndex = 3;
            this.radTenDG.TabStop = true;
            this.radTenDG.Text = "Tìm theo tên độc giả";
            this.radTenDG.UseVisualStyleBackColor = true;
            // 
            // txtSearchingDG
            // 
            this.txtSearchingDG.Location = new System.Drawing.Point(11, 73);
            this.txtSearchingDG.Name = "txtSearchingDG";
            this.txtSearchingDG.Size = new System.Drawing.Size(309, 35);
            this.txtSearchingDG.TabIndex = 1;
            this.txtSearchingDG.TextChanged += new System.EventHandler(this.txtSearchingDG_TextChanged);
            // 
            // btnSearchingDG
            // 
            this.btnSearchingDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchingDG.Location = new System.Drawing.Point(326, 73);
            this.btnSearchingDG.Name = "btnSearchingDG";
            this.btnSearchingDG.Size = new System.Drawing.Size(147, 38);
            this.btnSearchingDG.TabIndex = 2;
            this.btnSearchingDG.Text = "Tìm kiếm";
            this.btnSearchingDG.UseVisualStyleBackColor = true;
            this.btnSearchingDG.Click += new System.EventHandler(this.btnSearchingDG_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin:";
            // 
            // btnHTDanhSach
            // 
            this.btnHTDanhSach.Location = new System.Drawing.Point(18, 416);
            this.btnHTDanhSach.Name = "btnHTDanhSach";
            this.btnHTDanhSach.Size = new System.Drawing.Size(169, 44);
            this.btnHTDanhSach.TabIndex = 1;
            this.btnHTDanhSach.Text = "Hiển thị danh sách";
            this.btnHTDanhSach.UseVisualStyleBackColor = true;
            this.btnHTDanhSach.Click += new System.EventHandler(this.btnHTDanhSach_Click);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(543, 137);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(225, 37);
            this.cboTrangThai.TabIndex = 22;
            this.cboTrangThai.SelectedIndexChanged += new System.EventHandler(this.cboTrangThai_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Trạng thái:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(391, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ngày hết hạn:";
            // 
            // txtNgayTao
            // 
            this.txtNgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayTao.Location = new System.Drawing.Point(543, 97);
            this.txtNgayTao.Name = "txtNgayTao";
            this.txtNgayTao.ReadOnly = true;
            this.txtNgayTao.Size = new System.Drawing.Size(225, 30);
            this.txtNgayTao.TabIndex = 25;
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.Location = new System.Drawing.Point(543, 195);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(225, 35);
            this.dtpNgayHetHan.TabIndex = 26;
            this.dtpNgayHetHan.ValueChanged += new System.EventHandler(this.dtpNgayHetHan_ValueChanged);
            // 
            // QuanLyDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 1050);
            this.Controls.Add(this.btnHTDanhSach);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuanLyDG";
            this.Text = "Quản lý độc giả";
            this.Load += new System.EventHandler(this.QuanLyDG_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDSDocGia)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGVDSDocGia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoaDG;
        private System.Windows.Forms.Button btnSuaDG;
        private System.Windows.Forms.Button btnThemDG;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSDTDG;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPassDG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmailDG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMaDG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radMaDG;
        private System.Windows.Forms.RadioButton radTenDG;
        private System.Windows.Forms.TextBox txtSearchingDG;
        private System.Windows.Forms.Button btnSearchingDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHTDanhSach;
        private System.Windows.Forms.ComboBox cbxVaiTroDG;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNgayTao;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHan;
    }
}