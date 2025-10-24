namespace QLTV
{
    partial class FormDangNhap
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
            this.lalNamedangnhap = new System.Windows.Forms.Label();
            this.lalMatKhau = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail_DangNhap = new System.Windows.Forms.TextBox();
            this.lalEmail = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnAccesLogin = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau_DangNhap = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lalNamedangnhap
            // 
            this.lalNamedangnhap.AutoSize = true;
            this.lalNamedangnhap.Location = new System.Drawing.Point(28, 43);
            this.lalNamedangnhap.Name = "lalNamedangnhap";
            this.lalNamedangnhap.Size = new System.Drawing.Size(181, 29);
            this.lalNamedangnhap.TabIndex = 0;
            this.lalNamedangnhap.Text = "Tên đăng nhập:";
            // 
            // lalMatKhau
            // 
            this.lalMatKhau.AutoSize = true;
            this.lalMatKhau.Location = new System.Drawing.Point(28, 100);
            this.lalMatKhau.Name = "lalMatKhau";
            this.lalMatKhau.Size = new System.Drawing.Size(115, 29);
            this.lalMatKhau.TabIndex = 1;
            this.lalMatKhau.Text = "Mật khẩu:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail_DangNhap);
            this.groupBox1.Controls.Add(this.lalEmail);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.btnAccesLogin);
            this.groupBox1.Controls.Add(this.Exit);
            this.groupBox1.Controls.Add(this.txtTenDangNhap);
            this.groupBox1.Controls.Add(this.txtMatKhau_DangNhap);
            this.groupBox1.Controls.Add(this.lalMatKhau);
            this.groupBox1.Controls.Add(this.lalNamedangnhap);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 437);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // txtEmail_DangNhap
            // 
            this.txtEmail_DangNhap.Location = new System.Drawing.Point(214, 166);
            this.txtEmail_DangNhap.Name = "txtEmail_DangNhap";
            this.txtEmail_DangNhap.Size = new System.Drawing.Size(307, 35);
            this.txtEmail_DangNhap.TabIndex = 9;
            // 
            // lalEmail
            // 
            this.lalEmail.AutoSize = true;
            this.lalEmail.Location = new System.Drawing.Point(28, 171);
            this.lalEmail.Name = "lalEmail";
            this.lalEmail.Size = new System.Drawing.Size(80, 29);
            this.lalEmail.TabIndex = 8;
            this.lalEmail.Text = "Email:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(356, 246);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(120, 33);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Độc giả";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(34, 246);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(118, 33);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Thủ thư";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnAccesLogin
            // 
            this.btnAccesLogin.Location = new System.Drawing.Point(33, 320);
            this.btnAccesLogin.Name = "btnAccesLogin";
            this.btnAccesLogin.Size = new System.Drawing.Size(150, 49);
            this.btnAccesLogin.TabIndex = 5;
            this.btnAccesLogin.Text = "Đăng nhập";
            this.btnAccesLogin.UseVisualStyleBackColor = true;
            this.btnAccesLogin.Click += new System.EventHandler(this.btnAccesLogin_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(356, 320);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(150, 49);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(214, 43);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(307, 35);
            this.txtTenDangNhap.TabIndex = 3;
            // 
            // txtMatKhau_DangNhap
            // 
            this.txtMatKhau_DangNhap.Location = new System.Drawing.Point(214, 95);
            this.txtMatKhau_DangNhap.Name = "txtMatKhau_DangNhap";
            this.txtMatKhau_DangNhap.Size = new System.Drawing.Size(307, 35);
            this.txtMatKhau_DangNhap.TabIndex = 2;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 511);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDangNhap";
            this.Tag = "";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lalNamedangnhap;
        private System.Windows.Forms.Label lalMatKhau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAccesLogin;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau_DangNhap;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtEmail_DangNhap;
        private System.Windows.Forms.Label lalEmail;
    }
}