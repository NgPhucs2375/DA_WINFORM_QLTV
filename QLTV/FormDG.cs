using QLTV.Database;
using System;
using System.Data;
using System.Drawing; // Cần thiết cho UI
using System.Linq;
using System.Windows.Forms;

namespace QLTV
{
    public partial class FormDG : Form
    {
        private int _userId;

        public FormDG()
        {
            InitializeComponent();
            _userId = Program.CurrentUserId;
            SetupModernUI();
        }

        // Hàm setup các thuộc tính giao diện nâng cao
        private void SetupModernUI()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            // Ẩn header của TabControl để tạo giao diện "Tabless"
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            // Mặc định chọn nút Tra Cứu
            SetActiveButton(btnNavTraCuu);
        }

        // Hàm tạo hiệu ứng "Nút đang chọn"
        private void SetActiveButton(Button activeBtn)
        {
            // Reset màu các nút khác
            btnNavTraCuu.BackColor = Color.FromArgb(44, 62, 80); // Màu tối
            btnNavLichSu.BackColor = Color.FromArgb(44, 62, 80);
            btnNavCaNhan.BackColor = Color.FromArgb(44, 62, 80);

            // Set màu nổi bật cho nút đang chọn
            activeBtn.BackColor = Color.FromArgb(230, 126, 34); // Màu Cam
        }

        // --- SỰ KIỆN ĐIỀU HƯỚNG SIDEBAR ---
        private void btnNavTraCuu_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabTraCuu;
            SetActiveButton(btnNavTraCuu);
        }

        private void btnNavLichSu_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabLichSu;
            SetActiveButton(btnNavLichSu);
            LoadLichSuMuon(); // Load lại dữ liệu cho mới
        }

        private void btnNavCaNhan_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabCaNhan;
            SetActiveButton(btnNavCaNhan);
        }

        // --- CÁC HÀM LOGIC CŨ (GIỮ NGUYÊN) ---
        private void FormDG_Load(object sender, EventArgs e)
        {
            LoadThongTinCaNhan();
            LoadDanhSachSach();
        }

        private void LoadThongTinCaNhan()
        {
            using (var db = new QLTVDataContext())
            {
                var user = db.NguoiDungs.FirstOrDefault(u => u.IDNguoiDung == _userId);
                if (user != null)
                {
                    lblXinChao.Text = user.HoTen_NguoiDung; // Chỉ hiện tên
                    lblEmail.Text = user.Email_NguoiDung;

                    var docGia = db.DocGias.FirstOrDefault(d => d.IDNguoiDung_DocGia == _userId);
                    if (docGia != null) lblHanThe.Text = docGia.NgayHetHan.ToString("dd/MM/yyyy");
                }
            }
        }

        private void LoadDanhSachSach()
        {
            using (var db = new QLTVDataContext())
            {
                dgvSach.DataSource = db.Sachs.Select(s => new {
                    s.Name_Sach,
                    s.TacGia_Sach,
                    s.TheLoai_Sach,
                    s.SoLuong_Sach,
                    TrangThai = s.SoLuong_Sach > 0 ? "Còn sách" : "Hết hàng"
                }).ToList();
            }
        }

        private void LoadLichSuMuon()
        {
            using (var db = new QLTVDataContext())
            {
                var idDocGia = db.DocGias.Where(d => d.IDNguoiDung_DocGia == _userId).Select(d => d.IDDocGia).FirstOrDefault();
                dgvLichSu.DataSource = db.PhieuMuons
                    .Where(pm => pm.IDDocGia_PhieuMuon == idDocGia)
                    .Select(pm => new {
                        Sach = pm.SACHDATA.Name_Sach,
                        NgayMuon = pm.NgayMuon_Sach,
                        HanTra = pm.HanTra_PhieuMuon,
                        TrangThai = pm.TrangThai_PhieuMuon
                    }).ToList();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text.Trim().ToLower();
            using (var db = new QLTVDataContext())
            {
                dgvSach.DataSource = db.Sachs
                    .Where(s => s.Name_Sach.ToLower().Contains(key) || s.TacGia_Sach.ToLower().Contains(key))
                    .Select(s => new { s.Name_Sach, s.TacGia_Sach, s.TheLoai_Sach, s.SoLuong_Sach, TrangThai = s.SoLuong_Sach > 0 ? "Còn" : "Hết" })
                    .ToList();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Đăng xuất?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            new FormDoiMatKhau().ShowDialog();
        }
    }
}