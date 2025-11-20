namespace QLTV
{
    partial class FormDoiMatKhau
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail_DangNhap = new System.Windows.Forms.TextBox();
            this.lalEmail = new System.Windows.Forms.Label();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau_DangNhap = new System.Windows.Forms.TextBox();
            this.lalMatKhau = new System.Windows.Forms.Label();
            this.lalNamedangnhap = new System.Windows.Forms.Label();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtMKMoi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEmail_DangNhap);
            this.groupBox1.Controls.Add(this.lalEmail);
            this.groupBox1.Controls.Add(this.btnDoiMK);
            this.groupBox1.Controls.Add(this.Exit);
            this.groupBox1.Controls.Add(this.txtTenDangNhap);
            this.groupBox1.Controls.Add(this.txtMatKhau_DangNhap);
            this.groupBox1.Controls.Add(this.lalMatKhau);
            this.groupBox1.Controls.Add(this.lalNamedangnhap);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 437);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đổi mật khẩu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtEmail_DangNhap
            // 
            this.txtEmail_DangNhap.Location = new System.Drawing.Point(257, 97);
            this.txtEmail_DangNhap.Name = "txtEmail_DangNhap";
            this.txtEmail_DangNhap.Size = new System.Drawing.Size(307, 35);
            this.txtEmail_DangNhap.TabIndex = 9;
            this.txtEmail_DangNhap.TextChanged += new System.EventHandler(this.txtEmail_DangNhap_TextChanged);
            // 
            // lalEmail
            // 
            this.lalEmail.AutoSize = true;
            this.lalEmail.Location = new System.Drawing.Point(27, 97);
            this.lalEmail.Name = "lalEmail";
            this.lalEmail.Size = new System.Drawing.Size(80, 29);
            this.lalEmail.TabIndex = 8;
            this.lalEmail.Text = "Email:";
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Location = new System.Drawing.Point(33, 320);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(175, 49);
            this.btnDoiMK.TabIndex = 5;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(540, 320);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(150, 49);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(257, 43);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(307, 35);
            this.txtTenDangNhap.TabIndex = 3;
            this.txtTenDangNhap.TextChanged += new System.EventHandler(this.txtTenDangNhap_TextChanged);
            // 
            // txtMatKhau_DangNhap
            // 
            this.txtMatKhau_DangNhap.Location = new System.Drawing.Point(257, 148);
            this.txtMatKhau_DangNhap.Name = "txtMatKhau_DangNhap";
            this.txtMatKhau_DangNhap.Size = new System.Drawing.Size(307, 35);
            this.txtMatKhau_DangNhap.TabIndex = 2;
            this.txtMatKhau_DangNhap.TextChanged += new System.EventHandler(this.txtMatKhau_DangNhap_TextChanged);
            // 
            // lalMatKhau
            // 
            this.lalMatKhau.AutoSize = true;
            this.lalMatKhau.Location = new System.Drawing.Point(27, 148);
            this.lalMatKhau.Name = "lalMatKhau";
            this.lalMatKhau.Size = new System.Drawing.Size(198, 29);
            this.lalMatKhau.TabIndex = 1;
            this.lalMatKhau.Text = "Mật khẩu hiện tại:";
            // 
            // lalNamedangnhap
            // 
            this.lalNamedangnhap.AutoSize = true;
            this.lalNamedangnhap.Location = new System.Drawing.Point(27, 43);
            this.lalNamedangnhap.Name = "lalNamedangnhap";
            this.lalNamedangnhap.Size = new System.Drawing.Size(181, 29);
            this.lalNamedangnhap.TabIndex = 0;
            this.lalNamedangnhap.Text = "Tên đăng nhập:";
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Location = new System.Drawing.Point(257, 201);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Size = new System.Drawing.Size(307, 35);
            this.txtMKMoi.TabIndex = 11;
            this.txtMKMoi.TextChanged += new System.EventHandler(this.txtXacNhanMK_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mật khẩu mới:";
            // 
            // FormDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDoiMatKhau";
            this.Text = "FormDoiMatKhau";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail_DangNhap;
        private System.Windows.Forms.Label lalEmail;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau_DangNhap;
        private System.Windows.Forms.Label lalMatKhau;
        private System.Windows.Forms.Label lalNamedangnhap;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.Label label1;
    }
}