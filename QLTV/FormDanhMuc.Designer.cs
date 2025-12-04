namespace QLTV
{
    partial class FormDanhMuc
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTheLoai = new System.Windows.Forms.TabPage();
            this.dgvTheLoai = new System.Windows.Forms.DataGridView();
            this.pnlTLAction = new System.Windows.Forms.Panel();
            this.btnXoaTL = new System.Windows.Forms.Button();
            this.btnLuuTL = new System.Windows.Forms.Button();
            this.txtTenTL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabTacGia = new System.Windows.Forms.TabPage();
            this.dgvTacGia = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaTG = new System.Windows.Forms.Button();
            this.btnLuuTG = new System.Windows.Forms.Button();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabNXB = new System.Windows.Forms.TabPage();
            this.dgvNXB = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSdtNXB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoaNXB = new System.Windows.Forms.Button();
            this.btnLuuNXB = new System.Windows.Forms.Button();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabTheLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).BeginInit();
            this.pnlTLAction.SuspendLayout();
            this.tabTacGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabNXB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTheLoai);
            this.tabControl1.Controls.Add(this.tabTacGia);
            this.tabControl1.Controls.Add(this.tabNXB);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabTheLoai
            // 
            this.tabTheLoai.Controls.Add(this.dgvTheLoai);
            this.tabTheLoai.Controls.Add(this.pnlTLAction);
            this.tabTheLoai.Location = new System.Drawing.Point(4, 32);
            this.tabTheLoai.Name = "tabTheLoai";
            this.tabTheLoai.Padding = new System.Windows.Forms.Padding(3);
            this.tabTheLoai.Size = new System.Drawing.Size(792, 414);
            this.tabTheLoai.TabIndex = 0;
            this.tabTheLoai.Text = "Thể Loại";
            this.tabTheLoai.UseVisualStyleBackColor = true;
            // 
            // dgvTheLoai
            // 
            this.dgvTheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTheLoai.Location = new System.Drawing.Point(3, 73);
            this.dgvTheLoai.Name = "dgvTheLoai";
            this.dgvTheLoai.RowHeadersWidth = 51;
            this.dgvTheLoai.RowTemplate.Height = 24;
            this.dgvTheLoai.Size = new System.Drawing.Size(786, 338);
            this.dgvTheLoai.TabIndex = 1;
            // 
            // pnlTLAction
            // 
            this.pnlTLAction.Controls.Add(this.btnXoaTL);
            this.pnlTLAction.Controls.Add(this.btnLuuTL);
            this.pnlTLAction.Controls.Add(this.txtTenTL);
            this.pnlTLAction.Controls.Add(this.label1);
            this.pnlTLAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTLAction.Location = new System.Drawing.Point(3, 3);
            this.pnlTLAction.Name = "pnlTLAction";
            this.pnlTLAction.Size = new System.Drawing.Size(786, 70);
            this.pnlTLAction.TabIndex = 0;
            // 
            // btnXoaTL
            // 
            this.btnXoaTL.BackColor = System.Drawing.Color.Crimson;
            this.btnXoaTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTL.ForeColor = System.Drawing.Color.White;
            this.btnXoaTL.Location = new System.Drawing.Point(500, 17);
            this.btnXoaTL.Name = "btnXoaTL";
            this.btnXoaTL.Size = new System.Drawing.Size(100, 35);
            this.btnXoaTL.TabIndex = 3;
            this.btnXoaTL.Text = "Xóa";
            this.btnXoaTL.UseVisualStyleBackColor = false;
            this.btnXoaTL.Click += new System.EventHandler(this.btnXoaTL_Click);
            // 
            // btnLuuTL
            // 
            this.btnLuuTL.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLuuTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuTL.ForeColor = System.Drawing.Color.White;
            this.btnLuuTL.Location = new System.Drawing.Point(380, 17);
            this.btnLuuTL.Name = "btnLuuTL";
            this.btnLuuTL.Size = new System.Drawing.Size(100, 35);
            this.btnLuuTL.TabIndex = 2;
            this.btnLuuTL.Text = "Thêm/Lưu";
            this.btnLuuTL.UseVisualStyleBackColor = false;
            this.btnLuuTL.Click += new System.EventHandler(this.btnLuuTL_Click);
            // 
            // txtTenTL
            // 
            this.txtTenTL.Location = new System.Drawing.Point(100, 20);
            this.txtTenTL.Name = "txtTenTL";
            this.txtTenTL.Size = new System.Drawing.Size(250, 30);
            this.txtTenTL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên TL:";
            // 
            // tabTacGia
            // 
            this.tabTacGia.Controls.Add(this.dgvTacGia);
            this.tabTacGia.Controls.Add(this.panel1);
            this.tabTacGia.Location = new System.Drawing.Point(4, 32);
            this.tabTacGia.Name = "tabTacGia";
            this.tabTacGia.Padding = new System.Windows.Forms.Padding(3);
            this.tabTacGia.Size = new System.Drawing.Size(792, 414);
            this.tabTacGia.TabIndex = 1;
            this.tabTacGia.Text = "Tác Giả";
            this.tabTacGia.UseVisualStyleBackColor = true;
            // 
            // dgvTacGia
            // 
            this.dgvTacGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTacGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTacGia.Location = new System.Drawing.Point(3, 73);
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.RowHeadersWidth = 51;
            this.dgvTacGia.RowTemplate.Height = 24;
            this.dgvTacGia.Size = new System.Drawing.Size(786, 338);
            this.dgvTacGia.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoaTG);
            this.panel1.Controls.Add(this.btnLuuTG);
            this.panel1.Controls.Add(this.txtTenTG);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 70);
            this.panel1.TabIndex = 1;
            // 
            // btnXoaTG
            // 
            this.btnXoaTG.BackColor = System.Drawing.Color.Crimson;
            this.btnXoaTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTG.ForeColor = System.Drawing.Color.White;
            this.btnXoaTG.Location = new System.Drawing.Point(500, 17);
            this.btnXoaTG.Name = "btnXoaTG";
            this.btnXoaTG.Size = new System.Drawing.Size(100, 35);
            this.btnXoaTG.TabIndex = 3;
            this.btnXoaTG.Text = "Xóa";
            this.btnXoaTG.UseVisualStyleBackColor = false;
            this.btnXoaTG.Click += new System.EventHandler(this.btnXoaTG_Click);
            // 
            // btnLuuTG
            // 
            this.btnLuuTG.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLuuTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuTG.ForeColor = System.Drawing.Color.White;
            this.btnLuuTG.Location = new System.Drawing.Point(380, 17);
            this.btnLuuTG.Name = "btnLuuTG";
            this.btnLuuTG.Size = new System.Drawing.Size(100, 35);
            this.btnLuuTG.TabIndex = 2;
            this.btnLuuTG.Text = "Thêm/Lưu";
            this.btnLuuTG.UseVisualStyleBackColor = false;
            this.btnLuuTG.Click += new System.EventHandler(this.btnLuuTG_Click);
            // 
            // txtTenTG
            // 
            this.txtTenTG.Location = new System.Drawing.Point(100, 20);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(250, 30);
            this.txtTenTG.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên TG:";
            // 
            // tabNXB
            // 
            this.tabNXB.Controls.Add(this.dgvNXB);
            this.tabNXB.Controls.Add(this.panel2);
            this.tabNXB.Location = new System.Drawing.Point(4, 32);
            this.tabNXB.Name = "tabNXB";
            this.tabNXB.Padding = new System.Windows.Forms.Padding(3);
            this.tabNXB.Size = new System.Drawing.Size(792, 414);
            this.tabNXB.TabIndex = 2;
            this.tabNXB.Text = "Nhà Xuất Bản";
            this.tabNXB.UseVisualStyleBackColor = true;
            // 
            // dgvNXB
            // 
            this.dgvNXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNXB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNXB.Location = new System.Drawing.Point(3, 73);
            this.dgvNXB.Name = "dgvNXB";
            this.dgvNXB.RowHeadersWidth = 51;
            this.dgvNXB.RowTemplate.Height = 24;
            this.dgvNXB.Size = new System.Drawing.Size(786, 338);
            this.dgvNXB.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSdtNXB);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnXoaNXB);
            this.panel2.Controls.Add(this.btnLuuNXB);
            this.panel2.Controls.Add(this.txtTenNXB);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 70);
            this.panel2.TabIndex = 1;
            // 
            // txtSdtNXB
            // 
            this.txtSdtNXB.Location = new System.Drawing.Point(430, 20);
            this.txtSdtNXB.Name = "txtSdtNXB";
            this.txtSdtNXB.Size = new System.Drawing.Size(150, 30);
            this.txtSdtNXB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "SĐT:";
            // 
            // btnXoaNXB
            // 
            this.btnXoaNXB.BackColor = System.Drawing.Color.Crimson;
            this.btnXoaNXB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNXB.ForeColor = System.Drawing.Color.White;
            this.btnXoaNXB.Location = new System.Drawing.Point(700, 17);
            this.btnXoaNXB.Name = "btnXoaNXB";
            this.btnXoaNXB.Size = new System.Drawing.Size(80, 35);
            this.btnXoaNXB.TabIndex = 3;
            this.btnXoaNXB.Text = "Xóa";
            this.btnXoaNXB.UseVisualStyleBackColor = false;
            this.btnXoaNXB.Click += new System.EventHandler(this.btnXoaNXB_Click);
            // 
            // btnLuuNXB
            // 
            this.btnLuuNXB.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLuuNXB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuNXB.ForeColor = System.Drawing.Color.White;
            this.btnLuuNXB.Location = new System.Drawing.Point(600, 17);
            this.btnLuuNXB.Name = "btnLuuNXB";
            this.btnLuuNXB.Size = new System.Drawing.Size(80, 35);
            this.btnLuuNXB.TabIndex = 2;
            this.btnLuuNXB.Text = "Lưu";
            this.btnLuuNXB.UseVisualStyleBackColor = false;
            this.btnLuuNXB.Click += new System.EventHandler(this.btnLuuNXB_Click);
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Location = new System.Drawing.Point(100, 20);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(250, 30);
            this.txtTenNXB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên NXB:";
            // 
            // FormDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormDanhMuc";
            this.Text = "Quản Lý Danh Mục";
            this.tabControl1.ResumeLayout(false);
            this.tabTheLoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).EndInit();
            this.pnlTLAction.ResumeLayout(false);
            this.pnlTLAction.PerformLayout();
            this.tabTacGia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabNXB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTheLoai;
        private System.Windows.Forms.TabPage tabTacGia;
        private System.Windows.Forms.TabPage tabNXB;
        private System.Windows.Forms.DataGridView dgvTheLoai;
        private System.Windows.Forms.Panel pnlTLAction;
        private System.Windows.Forms.Button btnXoaTL;
        private System.Windows.Forms.Button btnLuuTL;
        private System.Windows.Forms.TextBox txtTenTL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTacGia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoaTG;
        private System.Windows.Forms.Button btnLuuTG;
        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvNXB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoaNXB;
        private System.Windows.Forms.Button btnLuuNXB;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSdtNXB;
        private System.Windows.Forms.Label label4;
    }
}