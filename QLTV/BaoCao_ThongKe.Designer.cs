namespace QLTV
{
    partial class BaoCao_ThongKe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lalBC_TK = new System.Windows.Forms.Label();
            this.lalThongKe = new System.Windows.Forms.Label();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.cboLoaiThongKe = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.grbDKLoc = new System.Windows.Forms.GroupBox();
            this.Pal = new System.Windows.Forms.Panel();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.grbDKLoc.SuspendLayout();
            this.Pal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // lalBC_TK
            // 
            this.lalBC_TK.AutoSize = true;
            this.lalBC_TK.Location = new System.Drawing.Point(526, 9);
            this.lalBC_TK.Name = "lalBC_TK";
            this.lalBC_TK.Size = new System.Drawing.Size(119, 13);
            this.lalBC_TK.TabIndex = 0;
            this.lalBC_TK.Text = "BÁO CÁO & THỐNG KÊ ";
            // 
            // lalThongKe
            // 
            this.lalThongKe.AutoSize = true;
            this.lalThongKe.Location = new System.Drawing.Point(6, 48);
            this.lalThongKe.Name = "lalThongKe";
            this.lalThongKe.Size = new System.Drawing.Size(117, 13);
            this.lalThongKe.TabIndex = 1;
            this.lalThongKe.Text = "Loại báo cáo & thống kê";
            // 
            // dgvKetQua
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvKetQua.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(320, 97);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.Size = new System.Drawing.Size(855, 381);
            this.dgvKetQua.TabIndex = 3;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // cboLoaiThongKe
            // 
            this.cboLoaiThongKe.FormattingEnabled = true;
            this.cboLoaiThongKe.Location = new System.Drawing.Point(148, 45);
            this.cboLoaiThongKe.Name = "cboLoaiThongKe";
            this.cboLoaiThongKe.Size = new System.Drawing.Size(212, 21);
            this.cboLoaiThongKe.TabIndex = 4;
            this.cboLoaiThongKe.SelectedIndexChanged += new System.EventHandler(this.cboLoaiThongKe_SelectedIndexChanged);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(693, 49);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(77, 23);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(366, 48);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(157, 20);
            this.dtpTuNgay.TabIndex = 6;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(529, 48);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(158, 20);
            this.dtpDenNgay.TabIndex = 7;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(1053, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(122, 24);
            this.lblTongTien.TabIndex = 8;
            this.lblTongTien.Text = "TỔNG TIỀN";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(776, 49);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(53, 23);
            this.btnXuatExcel.TabIndex = 9;
            this.btnXuatExcel.Text = "Xuất ";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // grbDKLoc
            // 
            this.grbDKLoc.Controls.Add(this.cboLoaiThongKe);
            this.grbDKLoc.Controls.Add(this.btnXuatExcel);
            this.grbDKLoc.Controls.Add(this.lalBC_TK);
            this.grbDKLoc.Controls.Add(this.lalThongKe);
            this.grbDKLoc.Controls.Add(this.btnThongKe);
            this.grbDKLoc.Controls.Add(this.dtpTuNgay);
            this.grbDKLoc.Controls.Add(this.dtpDenNgay);
            this.grbDKLoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbDKLoc.Location = new System.Drawing.Point(0, 0);
            this.grbDKLoc.Name = "grbDKLoc";
            this.grbDKLoc.Size = new System.Drawing.Size(1175, 100);
            this.grbDKLoc.TabIndex = 10;
            this.grbDKLoc.TabStop = false;
            this.grbDKLoc.Text = "Điều kiện lọc";
            // 
            // Pal
            // 
            this.Pal.Controls.Add(this.lblTongTien);
            this.Pal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pal.Location = new System.Drawing.Point(0, 481);
            this.Pal.Name = "Pal";
            this.Pal.Size = new System.Drawing.Size(1175, 50);
            this.Pal.TabIndex = 11;
            // 
            // chartThongKe
            // 
            chartArea3.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartThongKe.Legends.Add(legend3);
            this.chartThongKe.Location = new System.Drawing.Point(0, 97);
            this.chartThongKe.Name = "chartThongKe";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartThongKe.Series.Add(series3);
            this.chartThongKe.Size = new System.Drawing.Size(314, 381);
            this.chartThongKe.TabIndex = 12;
            this.chartThongKe.Text = "Biểu đồ";
            // 
            // BaoCao_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1175, 531);
            this.Controls.Add(this.chartThongKe);
            this.Controls.Add(this.Pal);
            this.Controls.Add(this.grbDKLoc);
            this.Controls.Add(this.dgvKetQua);
            this.Name = "BaoCao_ThongKe";
            this.Text = "BaoCao_ThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.grbDKLoc.ResumeLayout(false);
            this.grbDKLoc.PerformLayout();
            this.Pal.ResumeLayout(false);
            this.Pal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lalBC_TK;
        private System.Windows.Forms.Label lalThongKe;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.ComboBox cboLoaiThongKe;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.GroupBox grbDKLoc;
        private System.Windows.Forms.Panel Pal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
    }
}