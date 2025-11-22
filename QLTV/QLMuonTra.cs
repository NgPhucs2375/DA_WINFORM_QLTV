using QLTV.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity; // Cần thiết cho Include
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLTV
{
    public partial class QLMuonTra : Form
    {
        public QLMuonTra()
        {
            InitializeComponent();
            SetupModernUI();
        }

        private void SetupModernUI()
        {
            // Cấu hình TabControl để ẩn Header mặc định đi (Biến thành Tabless)
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            // Style cho DataGridView
            StyleDataGridView(dgvDSMuon);
            StyleDataGridView(dgvDSTra);

            // Mặc định chọn Tab Mượn
            SwitchTab(btnTabMuon, tabPage1);
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv.BackgroundColor = Color.White;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72); // Màu xanh đậm
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 40;
        }

        // Hàm chuyển Tab và đổi màu nút
        private void SwitchTab(Button clickedBtn, TabPage page)
        {
            tabControl1.SelectedTab = page;

            // Reset màu 2 nút
            btnTabMuon.BackColor = Color.Transparent;
            btnTabTra.BackColor = Color.Transparent;
            btnTabMuon.ForeColor = Color.White;
            btnTabTra.ForeColor = Color.White;

            // Highlight nút được chọn
            clickedBtn.BackColor = Color.White;
            clickedBtn.ForeColor = Color.Black;

            // Load dữ liệu tương ứng
            if (page == tabPage1) LoadDSMuon();
            else LoadDSTra();
        }

        private void LoadDSMuon()
        {
            using (var db = new QLTVDataContext())
            {
                // Chỉ lấy phiếu đang mượn
                var list = db.PhieuMuons
                    .Include(p => p.DOCGIADATA.NGUOIDUNGDATA)
                    .Include(p => p.SACHDATA)
                    .Where(p => p.TrangThai_PhieuMuon == "Đang mượn")
                    .Select(p => new
                    {
                        MaPhieu = p.IDPhieuMuon,
                        DocGia = p.DOCGIADATA.NGUOIDUNGDATA.HoTen_NguoiDung,
                        TenSach = p.SACHDATA.Name_Sach,
                        NgayMuon = p.NgayMuon_Sach,
                        HanTra = p.HanTra_PhieuMuon,
                        TrangThai = p.TrangThai_PhieuMuon
                    }).ToList();

                dgvDSMuon.DataSource = list;

                // Đổi tên cột cho đẹp
                if (dgvDSMuon.Columns["MaPhieu"] != null) dgvDSMuon.Columns["MaPhieu"].HeaderText = "Mã Phiếu";
                if (dgvDSMuon.Columns["DocGia"] != null) dgvDSMuon.Columns["DocGia"].HeaderText = "Độc Giả";
                if (dgvDSMuon.Columns["TenSach"] != null) dgvDSMuon.Columns["TenSach"].HeaderText = "Tên Sách";
                if (dgvDSMuon.Columns["NgayMuon"] != null) dgvDSMuon.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
                if (dgvDSMuon.Columns["HanTra"] != null) dgvDSMuon.Columns["HanTra"].HeaderText = "Hạn Trả";
            }
        }

        private void LoadDSTra()
        {
            using (var db = new QLTVDataContext())
            {
                // Chỉ lấy phiếu đã trả
                var list = db.PhieuMuons
                    .Include(p => p.DOCGIADATA.NGUOIDUNGDATA)
                    .Include(p => p.SACHDATA)
                    .Where(p => p.TrangThai_PhieuMuon == "Đã trả")
                    .Select(p => new
                    {
                        MaPhieu = p.IDPhieuMuon,
                        DocGia = p.DOCGIADATA.NGUOIDUNGDATA.HoTen_NguoiDung,
                        TenSach = p.SACHDATA.Name_Sach,
                        NgayTra = p.NgayTra_PhieuMuon,
                        Phat = p.SoTienPhat_PhieuMuon
                    }).ToList();

                dgvDSTra.DataSource = list;
            }
        }

        // --- EVENTS ---

        private void btnTabMuon_Click(object sender, EventArgs e) => SwitchTab(btnTabMuon, tabPage1);
        private void btnTabTra_Click(object sender, EventArgs e) => SwitchTab(btnTabTra, tabPage2);

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            LapPhieuMuon f = new LapPhieuMuon();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadDSMuon(); // Refresh lại lưới ngay khi thêm xong
            }
        }

        private void btnLapPhieuTra_Click(object sender, EventArgs e)
        {
            LapPhieuTra f = new LapPhieuTra();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadDSTra(); // Refresh lưới trả
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.ToLower();
            using (var db = new QLTVDataContext())
            {
                var list = db.PhieuMuons
                    .Where(p => p.TrangThai_PhieuMuon == "Đang mượn" &&
                               (p.DOCGIADATA.NGUOIDUNGDATA.HoTen_NguoiDung.ToLower().Contains(keyword) ||
                                p.SACHDATA.Name_Sach.ToLower().Contains(keyword)))
                    .Select(p => new
                    {
                        MaPhieu = p.IDPhieuMuon,
                        DocGia = p.DOCGIADATA.NGUOIDUNGDATA.HoTen_NguoiDung,
                        TenSach = p.SACHDATA.Name_Sach,
                        NgayMuon = p.NgayMuon_Sach,
                        HanTra = p.HanTra_PhieuMuon,
                        TrangThai = p.TrangThai_PhieuMuon
                    }).ToList();
                dgvDSMuon.DataSource = list;
            }
        }

        // Form Load
        private void QLMuonTra_Load(object sender, EventArgs e)
        {
            // Load dữ liệu ban đầu
            LoadDSMuon();
        }
    }
}