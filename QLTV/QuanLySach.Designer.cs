namespace QLTV
{
    partial class QuanLySach
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
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.cbTTChuDe = new System.Windows.Forms.CheckBox();
            this.cbTTheoTacGia = new System.Windows.Forms.CheckBox();
            this.cbTTheoMa = new System.Windows.Forms.CheckBox();
            this.cbTTheoTen = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgwhowList = new System.Windows.Forms.DataGridView();
            this.btnHTDanhSach = new System.Windows.Forms.Button();
            this.grbSearch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwhowList)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.btnHTDanhSach);
            this.grbSearch.Controls.Add(this.cbTTChuDe);
            this.grbSearch.Controls.Add(this.cbTTheoTacGia);
            this.grbSearch.Controls.Add(this.cbTTheoMa);
            this.grbSearch.Controls.Add(this.cbTTheoTen);
            this.grbSearch.Controls.Add(this.txtSearch);
            this.grbSearch.Controls.Add(this.btnSearch);
            this.grbSearch.Controls.Add(this.label1);
            this.grbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSearch.Location = new System.Drawing.Point(12, 12);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(501, 368);
            this.grbSearch.TabIndex = 0;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Tìm kiếm sách";
            // 
            // cbTTChuDe
            // 
            this.cbTTChuDe.AutoSize = true;
            this.cbTTChuDe.Location = new System.Drawing.Point(240, 178);
            this.cbTTChuDe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTTChuDe.Name = "cbTTChuDe";
            this.cbTTChuDe.Size = new System.Drawing.Size(212, 33);
            this.cbTTChuDe.TabIndex = 6;
            this.cbTTChuDe.Text = "Tìm theo chủ đề";
            this.cbTTChuDe.UseVisualStyleBackColor = true;
            // 
            // cbTTheoTacGia
            // 
            this.cbTTheoTacGia.AutoSize = true;
            this.cbTTheoTacGia.Location = new System.Drawing.Point(240, 120);
            this.cbTTheoTacGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTTheoTacGia.Name = "cbTTheoTacGia";
            this.cbTTheoTacGia.Size = new System.Drawing.Size(210, 33);
            this.cbTTheoTacGia.TabIndex = 5;
            this.cbTTheoTacGia.Text = "Tìm theo tác giả";
            this.cbTTheoTacGia.UseVisualStyleBackColor = true;
            // 
            // cbTTheoMa
            // 
            this.cbTTheoMa.AutoSize = true;
            this.cbTTheoMa.Location = new System.Drawing.Point(10, 178);
            this.cbTTheoMa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTTheoMa.Name = "cbTTheoMa";
            this.cbTTheoMa.Size = new System.Drawing.Size(229, 33);
            this.cbTTheoMa.TabIndex = 4;
            this.cbTTheoMa.Text = "Tìm theo mã sách";
            this.cbTTheoMa.UseVisualStyleBackColor = true;
            // 
            // cbTTheoTen
            // 
            this.cbTTheoTen.AutoSize = true;
            this.cbTTheoTen.Location = new System.Drawing.Point(12, 120);
            this.cbTTheoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTTheoTen.Name = "cbTTheoTen";
            this.cbTTheoTen.Size = new System.Drawing.Size(173, 33);
            this.cbTTheoTen.TabIndex = 3;
            this.cbTTheoTen.Text = "Tìm theo tên";
            this.cbTTheoTen.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(10, 72);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(308, 35);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(326, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(147, 38);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.txtTrangThai);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtChuDe);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtNamXB);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNXB);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTacGia);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNameSach);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtIDSach);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(519, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 352);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sách";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(600, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 38);
            this.button4.TabIndex = 18;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(328, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 38);
            this.button2.TabIndex = 17;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(28, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "Thêm";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThai.Location = new System.Drawing.Point(538, 134);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(224, 30);
            this.txtTrangThai.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(424, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Trạng thái:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(538, 88);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(224, 30);
            this.txtSoLuong.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(424, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Số lượng:";
            // 
            // txtChuDe
            // 
            this.txtChuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuDe.Location = new System.Drawing.Point(538, 52);
            this.txtChuDe.Name = "txtChuDe";
            this.txtChuDe.Size = new System.Drawing.Size(224, 30);
            this.txtChuDe.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(424, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "Chủ đề:";
            // 
            // txtNamXB
            // 
            this.txtNamXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamXB.Location = new System.Drawing.Point(138, 195);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(224, 30);
            this.txtNamXB.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Năm XB:";
            // 
            // txtNXB
            // 
            this.txtNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNXB.Location = new System.Drawing.Point(138, 160);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(224, 30);
            this.txtNXB.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "NXB:";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTacGia.Location = new System.Drawing.Point(138, 125);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(224, 30);
            this.txtTacGia.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tác giả:";
            // 
            // txtNameSach
            // 
            this.txtNameSach.AcceptsTab = true;
            this.txtNameSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSach.Location = new System.Drawing.Point(138, 88);
            this.txtNameSach.Name = "txtNameSach";
            this.txtNameSach.Size = new System.Drawing.Size(224, 30);
            this.txtNameSach.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên sách:";
            // 
            // txtIDSach
            // 
            this.txtIDSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDSach.Location = new System.Drawing.Point(138, 52);
            this.txtIDSach.Name = "txtIDSach";
            this.txtIDSach.Size = new System.Drawing.Size(224, 30);
            this.txtIDSach.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sách:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgwhowList);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 405);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1284, 369);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sách";
            // 
            // dgwhowList
            // 
            this.dgwhowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwhowList.Location = new System.Drawing.Point(9, 31);
            this.dgwhowList.MultiSelect = false;
            this.dgwhowList.Name = "dgwhowList";
            this.dgwhowList.RowHeadersWidth = 62;
            this.dgwhowList.RowTemplate.Height = 28;
            this.dgwhowList.Size = new System.Drawing.Size(1269, 338);
            this.dgwhowList.TabIndex = 0;
            this.dgwhowList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwhowList_CellClick);
            this.dgwhowList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwhowList_CellContentClick);
            // 
            // btnHTDanhSach
            // 
            this.btnHTDanhSach.Location = new System.Drawing.Point(0, 318);
            this.btnHTDanhSach.Name = "btnHTDanhSach";
            this.btnHTDanhSach.Size = new System.Drawing.Size(169, 44);
            this.btnHTDanhSach.TabIndex = 7;
            this.btnHTDanhSach.Text = "Hiển thị danh sách";
            this.btnHTDanhSach.UseVisualStyleBackColor = true;
            this.btnHTDanhSach.Click += new System.EventHandler(this.btnHTDanhSach_Click);
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 749);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbSearch);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuanLySach";
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.QuanLySach_Load);
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwhowList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIDSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtChuDe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgwhowList;
        private System.Windows.Forms.CheckBox cbTTChuDe;
        private System.Windows.Forms.CheckBox cbTTheoTacGia;
        private System.Windows.Forms.CheckBox cbTTheoMa;
        private System.Windows.Forms.CheckBox cbTTheoTen;
        private System.Windows.Forms.Button btnHTDanhSach;
    }
}