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
            this.lalBC_TK = new System.Windows.Forms.Label();
            this.lalThongKe = new System.Windows.Forms.Label();
            this.lalAn = new System.Windows.Forms.Label();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.cboLoaiThongKe = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // lalBC_TK
            // 
            this.lalBC_TK.AutoSize = true;
            this.lalBC_TK.Location = new System.Drawing.Point(197, 22);
            this.lalBC_TK.Name = "lalBC_TK";
            this.lalBC_TK.Size = new System.Drawing.Size(119, 13);
            this.lalBC_TK.TabIndex = 0;
            this.lalBC_TK.Text = "BÁO CÁO & THỐNG KÊ ";
            // 
            // lalThongKe
            // 
            this.lalThongKe.AutoSize = true;
            this.lalThongKe.Location = new System.Drawing.Point(25, 53);
            this.lalThongKe.Name = "lalThongKe";
            this.lalThongKe.Size = new System.Drawing.Size(53, 13);
            this.lalThongKe.TabIndex = 1;
            this.lalThongKe.Text = "Thống kê";
            // 
            // lalAn
            // 
            this.lalAn.AutoSize = true;
            this.lalAn.Location = new System.Drawing.Point(25, 370);
            this.lalAn.Name = "lalAn";
            this.lalAn.Size = new System.Drawing.Size(20, 13);
            this.lalAn.TabIndex = 2;
            this.lalAn.Text = "An";
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(28, 145);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.Size = new System.Drawing.Size(358, 199);
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
            this.cboLoaiThongKe.Location = new System.Drawing.Point(92, 53);
            this.cboLoaiThongKe.Name = "cboLoaiThongKe";
            this.cboLoaiThongKe.Size = new System.Drawing.Size(121, 21);
            this.cboLoaiThongKe.TabIndex = 4;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(92, 89);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // BaoCao_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.cboLoaiThongKe);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.lalAn);
            this.Controls.Add(this.lalThongKe);
            this.Controls.Add(this.lalBC_TK);
            this.Name = "BaoCao_ThongKe";
            this.Text = "BaoCao_ThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lalBC_TK;
        private System.Windows.Forms.Label lalThongKe;
        private System.Windows.Forms.Label lalAn;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.ComboBox cboLoaiThongKe;
        private System.Windows.Forms.Button btnThongKe;
    }
}