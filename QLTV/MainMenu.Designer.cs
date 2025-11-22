namespace QLTV
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.đăngKýToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLSachMN = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLDGMN = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLNhanVienMN = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLMuonTraMN = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoThôngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.đăngKýToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(133, 48);
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            // 
            // đăngKýToolStripMenuItem
            // 
            this.đăngKýToolStripMenuItem.Name = "đăngKýToolStripMenuItem";
            this.đăngKýToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.đăngKýToolStripMenuItem.Text = "Đăng ký";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Yellow;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngKýToolStripMenuItem1,
            this.quảnLýDanhMụcToolStripMenuItem,
            this.btnQLMuonTraMN,
            this.báoCáoThôngKêToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip2.Size = new System.Drawing.Size(816, 27);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // đăngKýToolStripMenuItem1
            // 
            this.đăngKýToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChangePass,
            this.btnLogOut});
            this.đăngKýToolStripMenuItem1.Name = "đăngKýToolStripMenuItem1";
            this.đăngKýToolStripMenuItem1.ShowShortcutKeys = false;
            this.đăngKýToolStripMenuItem1.Size = new System.Drawing.Size(87, 25);
            this.đăngKýToolStripMenuItem1.Text = "Tài khoản";
            // 
            // btnChangePass
            // 
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(173, 26);
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(173, 26);
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // quảnLýDanhMụcToolStripMenuItem
            // 
            this.quảnLýDanhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQLSachMN,
            this.btnQLDGMN,
            this.btnQLNhanVienMN});
            this.quảnLýDanhMụcToolStripMenuItem.Name = "quảnLýDanhMụcToolStripMenuItem";
            this.quảnLýDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(149, 25);
            this.quảnLýDanhMụcToolStripMenuItem.Text = "Quản lý danh mục";
            // 
            // btnQLSachMN
            // 
            this.btnQLSachMN.Name = "btnQLSachMN";
            this.btnQLSachMN.Size = new System.Drawing.Size(209, 26);
            this.btnQLSachMN.Text = "Quản lý Sách";
            this.btnQLSachMN.Click += new System.EventHandler(this.btnQLSachMN_Click);
            // 
            // btnQLDGMN
            // 
            this.btnQLDGMN.Name = "btnQLDGMN";
            this.btnQLDGMN.Size = new System.Drawing.Size(209, 26);
            this.btnQLDGMN.Text = "Quản lý Độc giả";
            this.btnQLDGMN.Click += new System.EventHandler(this.btnQLDGMN_Click);
            // 
            // btnQLNhanVienMN
            // 
            this.btnQLNhanVienMN.Name = "btnQLNhanVienMN";
            this.btnQLNhanVienMN.Size = new System.Drawing.Size(209, 26);
            this.btnQLNhanVienMN.Text = "Quản lý Nhân viên";
            this.btnQLNhanVienMN.Click += new System.EventHandler(this.btnQLNhanVienMN_Click);
            // 
            // btnQLMuonTraMN
            // 
            this.btnQLMuonTraMN.Name = "btnQLMuonTraMN";
            this.btnQLMuonTraMN.Size = new System.Drawing.Size(149, 25);
            this.btnQLMuonTraMN.Text = "Quản lý Mượn-Trả";
            this.btnQLMuonTraMN.Click += new System.EventHandler(this.btnQLMuonTraMN_Click);
            // 
            // báoCáoThôngKêToolStripMenuItem
            // 
            this.báoCáoThôngKêToolStripMenuItem.Name = "báoCáoThôngKêToolStripMenuItem";
            this.báoCáoThôngKêToolStripMenuItem.Size = new System.Drawing.Size(141, 25);
            this.báoCáoThôngKêToolStripMenuItem.Text = "Báo cáo thông kê";
            this.báoCáoThôngKêToolStripMenuItem.Click += new System.EventHandler(this.báoCáoThôngKêToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLTV.Properties.Resources.bookstorebg2;
            this.ClientSize = new System.Drawing.Size(816, 467);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKýToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem đăngKýToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDanhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnQLSachMN;
        private System.Windows.Forms.ToolStripMenuItem btnQLDGMN;
        private System.Windows.Forms.ToolStripMenuItem btnQLMuonTraMN;
        private System.Windows.Forms.ToolStripMenuItem báoCáoThôngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnChangePass;
        private System.Windows.Forms.ToolStripMenuItem btnLogOut;
        private System.Windows.Forms.ToolStripMenuItem btnQLNhanVienMN;
    }
}