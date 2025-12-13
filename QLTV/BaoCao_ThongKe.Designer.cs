using System.Drawing;

namespace QLTV
{
    partial class BaoCao_ThongKe
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
            System.Windows.Forms.DataGridViewCellStyle cellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();

            // Dashboard Components
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartAreaDashboard1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legendDashboard1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series seriesDashboard1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartAreaDashboard2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legendDashboard2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series seriesDashboard2 = new System.Windows.Forms.DataVisualization.Charting.Series();

            this.tabControlMain = new System.Windows.Forms.TabControl();

            // --- TAB 1: DASHBOARD ---
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelCards = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblCard1Value = new System.Windows.Forms.Label();
            this.lblCard1Title = new System.Windows.Forms.Label();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblCard2Value = new System.Windows.Forms.Label();
            this.lblCard2Title = new System.Windows.Forms.Label();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.lblCard3Value = new System.Windows.Forms.Label();
            this.lblCard3Title = new System.Windows.Forms.Label();
            this.pnlCard4 = new System.Windows.Forms.Panel();
            this.lblCard4Value = new System.Windows.Forms.Label();
            this.lblCard4Title = new System.Windows.Forms.Label();
            this.splitContainerDashboard = new System.Windows.Forms.SplitContainer();
            this.chartTrend = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPieCategory = new System.Windows.Forms.DataVisualization.Charting.Chart();

            // --- TAB 2: REPORT ---
            this.tabReport = new System.Windows.Forms.TabPage();
            this.grbDKLoc = new System.Windows.Forms.GroupBox();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.lalThongKe = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.cboLoaiThongKe = new System.Windows.Forms.ComboBox();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDateSep = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblTongTien = new System.Windows.Forms.Label();

            this.tabControlMain.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.tableLayoutPanelCards.SuspendLayout();
            this.pnlCard1.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.pnlCard3.SuspendLayout();
            this.pnlCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDashboard)).BeginInit();
            this.splitContainerDashboard.Panel1.SuspendLayout();
            this.splitContainerDashboard.Panel2.SuspendLayout();
            this.splitContainerDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTrend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPieCategory)).BeginInit();
            this.tabReport.SuspendLayout();
            this.grbDKLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabDashboard);
            this.tabControlMain.Controls.Add(this.tabReport);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1200, 700);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);

            // ================== TAB 1: DASHBOARD ==================
            this.tabDashboard.Controls.Add(this.splitContainerDashboard);
            this.tabDashboard.Controls.Add(this.tableLayoutPanelCards);
            this.tabDashboard.Location = new System.Drawing.Point(4, 32);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(10);
            this.tabDashboard.Size = new System.Drawing.Size(1192, 664);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "📊 DASHBOARD TỔNG QUAN";
            this.tabDashboard.UseVisualStyleBackColor = true;

            // Cards Layout
            this.tableLayoutPanelCards.ColumnCount = 4;
            this.tableLayoutPanelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelCards.Controls.Add(this.pnlCard1, 0, 0);
            this.tableLayoutPanelCards.Controls.Add(this.pnlCard2, 1, 0);
            this.tableLayoutPanelCards.Controls.Add(this.pnlCard3, 2, 0);
            this.tableLayoutPanelCards.Controls.Add(this.pnlCard4, 3, 0);
            this.tableLayoutPanelCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelCards.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanelCards.Name = "tableLayoutPanelCards";
            this.tableLayoutPanelCards.RowCount = 1;
            this.tableLayoutPanelCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelCards.Size = new System.Drawing.Size(1172, 130);
            this.tableLayoutPanelCards.TabIndex = 0;

            // 
            // pnlCard1 (TỔNG SÁCH)
            // 
            this.pnlCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlCard1.Controls.Add(this.lblCard1Title);
            this.pnlCard1.Controls.Add(this.lblCard1Value);
            this.pnlCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard1.Margin = new System.Windows.Forms.Padding(5);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Size = new System.Drawing.Size(283, 120);
            this.pnlCard1.TabIndex = 0;
            // 
            // lblCard1Title
            // 
            this.lblCard1Title.AutoSize = true;
            this.lblCard1Title.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCard1Title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCard1Title.Location = new System.Drawing.Point(15, 15);
            this.lblCard1Title.Name = "lblCard1Title";
            this.lblCard1Title.Size = new System.Drawing.Size(130, 25);
            this.lblCard1Title.TabIndex = 0;
            this.lblCard1Title.Text = "TỔNG SÁCH TRONG KHO";
            // 
            // lblCard1Value
            // 
            this.lblCard1Value.AutoSize = true;
            this.lblCard1Value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblCard1Value.ForeColor = System.Drawing.Color.White;
            this.lblCard1Value.Location = new System.Drawing.Point(10, 45);
            this.lblCard1Value.Name = "lblCard1Value";
            this.lblCard1Value.Size = new System.Drawing.Size(52, 54);
            this.lblCard1Value.TabIndex = 1;
            this.lblCard1Value.Text = "...";

            // 
            // pnlCard2 (ĐANG MƯỢN)
            // 
            this.pnlCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.pnlCard2.Controls.Add(this.lblCard2Title);
            this.pnlCard2.Controls.Add(this.lblCard2Value);
            this.pnlCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard2.Margin = new System.Windows.Forms.Padding(5);
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.Size = new System.Drawing.Size(283, 120);
            this.pnlCard2.TabIndex = 1;
            // 
            // lblCard2Title
            // 
            this.lblCard2Title.AutoSize = true;
            this.lblCard2Title.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCard2Title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCard2Title.Location = new System.Drawing.Point(15, 15);
            this.lblCard2Title.Name = "lblCard2Title";
            this.lblCard2Title.Size = new System.Drawing.Size(140, 25);
            this.lblCard2Title.TabIndex = 0;
            this.lblCard2Title.Text = "ĐANG ĐƯỢC MƯỢN";
            // 
            // lblCard2Value
            // 
            this.lblCard2Value.AutoSize = true;
            this.lblCard2Value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblCard2Value.ForeColor = System.Drawing.Color.White;
            this.lblCard2Value.Location = new System.Drawing.Point(10, 45);
            this.lblCard2Value.Name = "lblCard2Value";
            this.lblCard2Value.Size = new System.Drawing.Size(52, 54);
            this.lblCard2Value.TabIndex = 1;
            this.lblCard2Value.Text = "...";

            // 
            // pnlCard3 (SÁCH QUÁ HẠN)
            // 
            this.pnlCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.pnlCard3.Controls.Add(this.lblCard3Title);
            this.pnlCard3.Controls.Add(this.lblCard3Value);
            this.pnlCard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard3.Margin = new System.Windows.Forms.Padding(5);
            this.pnlCard3.Name = "pnlCard3";
            this.pnlCard3.Size = new System.Drawing.Size(283, 120);
            this.pnlCard3.TabIndex = 2;
            // 
            // lblCard3Title
            // 
            this.lblCard3Title.AutoSize = true;
            this.lblCard3Title.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCard3Title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCard3Title.Location = new System.Drawing.Point(15, 15);
            this.lblCard3Title.Name = "lblCard3Title";
            this.lblCard3Title.Size = new System.Drawing.Size(110, 25);
            this.lblCard3Title.TabIndex = 0;
            this.lblCard3Title.Text = "SÁCH QUÁ HẠN";
            // 
            // lblCard3Value
            // 
            this.lblCard3Value.AutoSize = true;
            this.lblCard3Value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblCard3Value.ForeColor = System.Drawing.Color.White;
            this.lblCard3Value.Location = new System.Drawing.Point(10, 45);
            this.lblCard3Value.Name = "lblCard3Value";
            this.lblCard3Value.Size = new System.Drawing.Size(52, 54);
            this.lblCard3Value.TabIndex = 1;
            this.lblCard3Value.Text = "...";

            // 
            // pnlCard4 (DOANH THU THÁNG)
            // 
            this.pnlCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.pnlCard4.Controls.Add(this.lblCard4Title);
            this.pnlCard4.Controls.Add(this.lblCard4Value);
            this.pnlCard4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard4.Margin = new System.Windows.Forms.Padding(5);
            this.pnlCard4.Name = "pnlCard4";
            this.pnlCard4.Size = new System.Drawing.Size(287, 120);
            this.pnlCard4.TabIndex = 3;
            // 
            // lblCard4Title
            // 
            this.lblCard4Title.AutoSize = true;
            this.lblCard4Title.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCard4Title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCard4Title.Location = new System.Drawing.Point(15, 15);
            this.lblCard4Title.Name = "lblCard4Title";
            this.lblCard4Title.Size = new System.Drawing.Size(130, 25);
            this.lblCard4Title.TabIndex = 0;
            this.lblCard4Title.Text = "DOANH THU THÁNG";
            // 
            // lblCard4Value
            // 
            this.lblCard4Value.AutoSize = true;
            this.lblCard4Value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblCard4Value.ForeColor = System.Drawing.Color.White;
            this.lblCard4Value.Location = new System.Drawing.Point(10, 45);
            this.lblCard4Value.Name = "lblCard4Value";
            this.lblCard4Value.Size = new System.Drawing.Size(52, 54);
            this.lblCard4Value.TabIndex = 1;
            this.lblCard4Value.Text = "...";

            // Dashboard Split Container (Charts)
            this.splitContainerDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDashboard.Location = new System.Drawing.Point(10, 140);
            this.splitContainerDashboard.Name = "splitContainerDashboard";

            // 
            // Chart Trend (Left) - ĐÃ FIX MinimumSize
            // 
            chartAreaDashboard1.Name = "ChartArea1";
            this.chartTrend.ChartAreas.Add(chartAreaDashboard1);
            legendDashboard1.Name = "Legend1";
            legendDashboard1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            this.chartTrend.Legends.Add(legendDashboard1);
            this.chartTrend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTrend.MinimumSize = new System.Drawing.Size(100, 100); // FIX: Tránh lỗi 0px width
            this.chartTrend.Name = "chartTrend";
            seriesDashboard1.ChartArea = "ChartArea1";
            seriesDashboard1.Legend = "Legend1";
            seriesDashboard1.Name = "Series1";
            seriesDashboard1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            this.chartTrend.Series.Add(seriesDashboard1);
            this.chartTrend.Titles.Add("XU HƯỚNG MƯỢN SÁCH THEO THÁNG (Năm nay)");
            this.splitContainerDashboard.Panel1.Controls.Add(this.chartTrend);

            // 
            // Chart Pie Category (Right) - ĐÃ FIX MinimumSize
            // 
            chartAreaDashboard2.Name = "ChartArea1";
            this.chartPieCategory.ChartAreas.Add(chartAreaDashboard2);
            legendDashboard2.Name = "Legend1";
            legendDashboard2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            this.chartPieCategory.Legends.Add(legendDashboard2);
            this.chartPieCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPieCategory.MinimumSize = new System.Drawing.Size(100, 100); // FIX: Tránh lỗi 0px width
            this.chartPieCategory.Name = "chartPieCategory";
            seriesDashboard2.ChartArea = "ChartArea1";
            seriesDashboard2.Legend = "Legend1";
            seriesDashboard2.Name = "Series1";
            seriesDashboard2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            this.chartPieCategory.Series.Add(seriesDashboard2);
            this.chartPieCategory.Titles.Add("TỶ LỆ SÁCH THEO THỂ LOẠI");
            this.splitContainerDashboard.Panel2.Controls.Add(this.chartPieCategory);
            this.splitContainerDashboard.SplitterDistance = 750;

            // ================== TAB 2: REPORT ==================
            this.tabReport.Controls.Add(this.splitContainer1);
            this.tabReport.Controls.Add(this.pnlFooter);
            this.tabReport.Controls.Add(this.grbDKLoc);
            this.tabReport.Location = new System.Drawing.Point(4, 32);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabReport.Size = new System.Drawing.Size(1192, 664);
            this.tabReport.TabIndex = 1;
            this.tabReport.Text = "📑 BÁO CÁO CHI TIẾT";
            this.tabReport.UseVisualStyleBackColor = true;

            // GroupBox Filter
            this.grbDKLoc.Controls.Add(this.btnXuatExcel);
            this.grbDKLoc.Controls.Add(this.lalThongKe);
            this.grbDKLoc.Controls.Add(this.btnThongKe);
            this.grbDKLoc.Controls.Add(this.cboLoaiThongKe);
            this.grbDKLoc.Controls.Add(this.dtpTuNgay);
            this.grbDKLoc.Controls.Add(this.dtpDenNgay);
            this.grbDKLoc.Controls.Add(this.lblDateSep);
            this.grbDKLoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbDKLoc.Location = new System.Drawing.Point(3, 3);
            this.grbDKLoc.Name = "grbDKLoc";
            this.grbDKLoc.Size = new System.Drawing.Size(1186, 100);
            this.grbDKLoc.TabIndex = 0;
            this.grbDKLoc.TabStop = false;
            this.grbDKLoc.Text = "Bộ lọc báo cáo";

            this.lalThongKe.AutoSize = true;
            this.lalThongKe.Location = new System.Drawing.Point(20, 35);
            this.lalThongKe.Name = "lalThongKe";
            this.lalThongKe.Text = "Loại báo cáo:";
            this.lalThongKe.Size = new System.Drawing.Size(100, 23);

            this.cboLoaiThongKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiThongKe.FormattingEnabled = true;
            this.cboLoaiThongKe.Location = new System.Drawing.Point(130, 32);
            this.cboLoaiThongKe.Name = "cboLoaiThongKe";
            this.cboLoaiThongKe.Size = new System.Drawing.Size(350, 31);
            this.cboLoaiThongKe.SelectedIndexChanged += new System.EventHandler(this.cboLoaiThongKe_SelectedIndexChanged);

            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(500, 32);
            this.dtpTuNgay.Size = new System.Drawing.Size(120, 30);

            this.lblDateSep.AutoSize = true;
            this.lblDateSep.Location = new System.Drawing.Point(630, 35);
            this.lblDateSep.Text = "→";

            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(660, 32);
            this.dtpDenNgay.Size = new System.Drawing.Size(120, 30);

            this.btnThongKe.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(800, 28);
            this.btnThongKe.Size = new System.Drawing.Size(150, 40);
            this.btnThongKe.Text = "XEM BÁO CÁO";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);

            this.btnXuatExcel.BackColor = System.Drawing.Color.SeaGreen;
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(960, 28);
            this.btnXuatExcel.Size = new System.Drawing.Size(150, 40);
            this.btnXuatExcel.Text = "XUẤT EXCEL";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);

            // Split Container Report
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 103);
            this.splitContainer1.Name = "splitContainer1";
            // Panel 1: GridView
            this.dgvKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKetQua.BackgroundColor = System.Drawing.Color.White;
            this.dgvKetQua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKetQua.ColumnHeadersHeight = 40;
            this.dgvKetQua.EnableHeadersVisualStyles = false;
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            headerStyle.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvKetQua.ColumnHeadersDefaultCellStyle = headerStyle;

            this.splitContainer1.Panel1.Controls.Add(this.dgvKetQua);

            // 
            // Panel 2: Detail Chart - ĐÃ FIX MinimumSize
            // 
            this.chartThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartThongKe.MinimumSize = new System.Drawing.Size(100, 100); // FIX: Tránh lỗi 0px width
            chartArea1.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            this.chartThongKe.Legends.Add(legend1);
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartThongKe.Series.Add(series1);
            this.splitContainer1.Panel2.Controls.Add(this.chartThongKe);
            this.splitContainer1.SplitterDistance = 700;

            // Footer (Total Revenue)
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Height = 50;
            this.pnlFooter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFooter.Controls.Add(this.lblTongTien);

            this.lblTongTien.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTongTien.AutoSize = false;
            this.lblTongTien.Width = 400;
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTongTien.Text = "Tổng doanh thu: 0 VNĐ";

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tabControlMain);
            this.Name = "BaoCao_ThongKe";
            this.Text = "Trung Tâm Báo Cáo & Thống Kê";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.tabControlMain.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.tableLayoutPanelCards.ResumeLayout(false);
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard1.PerformLayout();
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard2.PerformLayout();
            this.pnlCard3.ResumeLayout(false);
            this.pnlCard3.PerformLayout();
            this.pnlCard4.ResumeLayout(false);
            this.pnlCard4.PerformLayout();
            this.splitContainerDashboard.Panel1.ResumeLayout(false);
            this.splitContainerDashboard.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDashboard)).EndInit();
            this.splitContainerDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTrend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPieCategory)).EndInit();
            this.tabReport.ResumeLayout(false);
            this.grbDKLoc.ResumeLayout(false);
            this.grbDKLoc.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // Main Controls
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.TabPage tabReport;

        // Dashboard Elements
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCards;
        private System.Windows.Forms.Panel pnlCard1, pnlCard2, pnlCard3, pnlCard4;
        private System.Windows.Forms.Label lblCard1Title, lblCard1Value;
        private System.Windows.Forms.Label lblCard2Title, lblCard2Value;
        private System.Windows.Forms.Label lblCard3Title, lblCard3Value;
        private System.Windows.Forms.Label lblCard4Title, lblCard4Value;
        private System.Windows.Forms.SplitContainer splitContainerDashboard;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTrend;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPieCategory;

        // Detailed Report Elements
        private System.Windows.Forms.GroupBox grbDKLoc;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Label lalThongKe;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.ComboBox cboLoaiThongKe;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label lblDateSep;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblTongTien;
    }
}