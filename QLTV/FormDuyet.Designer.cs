namespace QLTV
{
    partial class FormDuyet
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

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.btnTuChoi = new System.Windows.Forms.Button();
            this.btnDuyet = new System.Windows.Forms.Button();
            this.dgvYeuCau = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();

            this.pnlHeader.SuspendLayout();
            this.pnlAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeuCau)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(900, 70);

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Text = "DUYỆT YÊU CẦU MƯỢN SÁCH ONLINE";

            // 
            // pnlAction
            // 
            this.pnlAction.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAction.Controls.Add(this.btnTuChoi);
            this.pnlAction.Controls.Add(this.btnDuyet);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAction.Size = new System.Drawing.Size(900, 80);

            // Nút Duyệt
            this.btnDuyet.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDuyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuyet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDuyet.ForeColor = System.Drawing.Color.White;
            this.btnDuyet.Location = new System.Drawing.Point(540, 15);
            this.btnDuyet.Size = new System.Drawing.Size(150, 50);
            this.btnDuyet.Text = "✓ DUYỆT";
            this.btnDuyet.UseVisualStyleBackColor = false;
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);

            // Nút Từ chối
            this.btnTuChoi.BackColor = System.Drawing.Color.Firebrick;
            this.btnTuChoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuChoi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTuChoi.ForeColor = System.Drawing.Color.White;
            this.btnTuChoi.Location = new System.Drawing.Point(710, 15);
            this.btnTuChoi.Size = new System.Drawing.Size(150, 50);
            this.btnTuChoi.Text = "✗ TỪ CHỐI";
            this.btnTuChoi.UseVisualStyleBackColor = false;
            this.btnTuChoi.Click += new System.EventHandler(this.btnTuChoi_Click);

            // 
            // GroupBox & GridView
            // 
            this.groupBox1.Controls.Add(this.dgvYeuCau);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.Location = new System.Drawing.Point(0, 70);
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Text = "Danh sách chờ duyệt";

            this.dgvYeuCau.BackgroundColor = System.Drawing.Color.White;
            this.dgvYeuCau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvYeuCau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvYeuCau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYeuCau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYeuCau.AllowUserToAddRows = false;
            this.dgvYeuCau.RowHeadersVisible = false;
            this.dgvYeuCau.ColumnHeadersHeight = 40;
            this.dgvYeuCau.EnableHeadersVisualStyles = false;

            headerStyle.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvYeuCau.ColumnHeadersDefaultCellStyle = headerStyle;

            // 
            // FormDuyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FormDuyet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duyệt Mượn Sách";
            this.Load += new System.EventHandler(this.FormDuyet_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeuCau)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlAction;
        private System.Windows.Forms.Button btnTuChoi;
        private System.Windows.Forms.Button btnDuyet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvYeuCau;
    }
}