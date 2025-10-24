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
            this.lalNamedangnhap.Location = new System.Drawing.Point(19, 28);
            this.lalNamedangnhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lalNamedangnhap.Name = "lalNamedangnhap";
            this.lalNamedangnhap.Size = new System.Drawing.Size(120, 20);
            this.lalNamedangnhap.TabIndex = 0;
            this.lalNamedangnhap.Text = "Tên đăng nhập:";
            // 
            // lalMatKhau
            // 
            this.lalMatKhau.AutoSize = true;
            this.lalMatKhau.Location = new System.Drawing.Point(19, 65);
            this.lalMatKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lalMatKhau.Name = "lalMatKhau";
            this.lalMatKhau.Size = new System.Drawing.Size(79, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(8, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(366, 284);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // txtEmail_DangNhap
            // 
            this.txtEmail_DangNhap.Location = new System.Drawing.Point(143, 108);
            this.txtEmail_DangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail_DangNhap.Name = "txtEmail_DangNhap";
            this.txtEmail_DangNhap.Size = new System.Drawing.Size(206, 26);
            this.txtEmail_DangNhap.TabIndex = 9;
            // 
            // lalEmail
            // 
            this.lalEmail.AutoSize = true;
            this.lalEmail.Location = new System.Drawing.Point(19, 111);
            this.lalEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lalEmail.Name = "lalEmail";
            this.lalEmail.Size = new System.Drawing.Size(52, 20);
            this.lalEmail.TabIndex = 8;
            this.lalEmail.Text = "Email:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(237, 160);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 24);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Độc giả";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 160);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 24);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Thủ thư";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnAccesLogin
            // 
            this.btnAccesLogin.Location = new System.Drawing.Point(22, 208);
            this.btnAccesLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccesLogin.Name = "btnAccesLogin";
            this.btnAccesLogin.Size = new System.Drawing.Size(100, 32);
            this.btnAccesLogin.TabIndex = 5;
            this.btnAccesLogin.Text = "Đăng nhập";
            this.btnAccesLogin.UseVisualStyleBackColor = true;
            this.btnAccesLogin.Click += new System.EventHandler(this.btnAccesLogin_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(237, 208);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 32);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(143, 28);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(206, 26);
            this.txtTenDangNhap.TabIndex = 3;
            // 
            // txtMatKhau_DangNhap
            // 
            this.txtMatKhau_DangNhap.Location = new System.Drawing.Point(143, 62);
            this.txtMatKhau_DangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatKhau_DangNhap.Name = "txtMatKhau_DangNhap";
            this.txtMatKhau_DangNhap.Size = new System.Drawing.Size(206, 26);
            this.txtMatKhau_DangNhap.TabIndex = 2;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 332);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
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