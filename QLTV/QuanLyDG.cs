using QLTV.Database;
using QLTV.Database.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLTV
{
    public partial class QuanLyDG : Form
    {
        public QuanLyDG()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            // Init ComboBox
            cboTrangThai.Items.AddRange(new string[] { "Hoạt động", "Bị khóa", "Chờ duyệt" });
            cboTrangThai.SelectedIndex = 0;

            // Style DataGridView
            StyleDataGridView();
        }

        private void StyleDataGridView()
        {
            dgvDocGia.BorderStyle = BorderStyle.None;
            dgvDocGia.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvDocGia.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDocGia.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dgvDocGia.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvDocGia.BackgroundColor = Color.White;
            dgvDocGia.EnableHeadersVisualStyles = false;
            dgvDocGia.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDocGia.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvDocGia.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocGia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void QuanLyDG_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (var db = new QLTVDataContext())
            {
                var list = from dg in db.DocGias
                           join nd in db.NguoiDungs on dg.IDNguoiDung_DocGia equals nd.IDNguoiDung
                           where nd.VaiTro_NguoiDung == "DocGia"
                           select new
                           {
                               ID = dg.IDDocGia,
                               HoTen = nd.HoTen_NguoiDung,
                               Email = nd.Email_NguoiDung,
                               SDT = nd.SDT_NguoiDung,
                               NgayHetHan = dg.NgayHetHan,
                               TrangThai = nd.TrangThai_NguoiDung
                           };
                dgvDocGia.DataSource = list.ToList();
            }
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvDocGia.Rows[e.RowIndex];
            txtMaDG.Text = row.Cells["ID"].Value.ToString();
            txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            txtSDT.Text = row.Cells["SDT"].Value.ToString();

            if (row.Cells["NgayHetHan"].Value != null)
                dtpNgayHetHan.Value = Convert.ToDateTime(row.Cells["NgayHetHan"].Value);

            string status = row.Cells["TrangThai"].Value.ToString();
            if (cboTrangThai.Items.Contains(status)) cboTrangThai.SelectedItem = status;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                using (var db = new QLTVDataContext())
                {
                    // 1. Thêm User
                    NguoiDung user = new NguoiDung()
                    {
                        HoTen_NguoiDung = txtHoTen.Text.Trim(),
                        Email_NguoiDung = txtEmail.Text.Trim(),
                        SDT_NguoiDung = txtSDT.Text.Trim(),
                        MatKhau_NguoiDung = "123456", // Mặc định, nên mã hóa MD5
                        VaiTro_NguoiDung = "DocGia",
                        TrangThai_NguoiDung = cboTrangThai.Text,
                        NgayTao_NguoiDung = DateTime.Now
                    };
                    db.NguoiDungs.Add(user);
                    db.SaveChanges();

                    // 2. Thêm DocGia
                    DocGia dg = new DocGia()
                    {
                        IDNguoiDung_DocGia = user.IDNguoiDung,
                        TinhTrangThe = "Active",
                        NgayCap = DateTime.Now,
                        NgayHetHan = dtpNgayHetHan.Value
                    };
                    db.DocGias.Add(dg);
                    db.SaveChanges();

                    MessageBox.Show("Thêm thành công!");
                    LoadData();
                    ClearForm();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDG.Text)) return;
            if (!ValidateInput()) return;

            try
            {
                using (var db = new QLTVDataContext())
                {
                    int id = int.Parse(txtMaDG.Text);
                    var dg = db.DocGias.FirstOrDefault(d => d.IDDocGia == id);
                    if (dg != null)
                    {
                        var user = db.NguoiDungs.FirstOrDefault(u => u.IDNguoiDung == dg.IDNguoiDung_DocGia);

                        // Cập nhật thông tin
                        user.HoTen_NguoiDung = txtHoTen.Text.Trim();
                        user.Email_NguoiDung = txtEmail.Text.Trim();
                        user.SDT_NguoiDung = txtSDT.Text.Trim();
                        user.TrangThai_NguoiDung = cboTrangThai.Text;
                        dg.NgayHetHan = dtpNgayHetHan.Value;

                        db.SaveChanges();
                        MessageBox.Show("Cập nhật thành công!");
                        LoadData();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDG.Text)) return;
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No) return;

            try
            {
                using (var db = new QLTVDataContext())
                {
                    int id = int.Parse(txtMaDG.Text);
                    var dg = db.DocGias.FirstOrDefault(d => d.IDDocGia == id);
                    if (dg != null)
                    {
                        // Xóa logic hoặc xóa vật lý tùy yêu cầu. Ở đây xóa vật lý:
                        // Cần xóa DocGia trước, sau đó xóa NguoiDung (do ràng buộc khóa ngoại)
                        var userId = dg.IDNguoiDung_DocGia;
                        db.DocGias.Remove(dg);

                        var user = db.NguoiDungs.FirstOrDefault(u => u.IDNguoiDung == userId);
                        if (user != null) db.NguoiDungs.Remove(user);

                        db.SaveChanges();
                        MessageBox.Show("Đã xóa!");
                        LoadData();
                        ClearForm();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Không thể xóa do ràng buộc dữ liệu (Đang mượn sách...)"); }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text.ToLower();
            using (var db = new QLTVDataContext())
            {
                var list = from dg in db.DocGias
                           join nd in db.NguoiDungs on dg.IDNguoiDung_DocGia equals nd.IDNguoiDung
                           where nd.VaiTro_NguoiDung == "DocGia" &&
                                 (nd.HoTen_NguoiDung.ToLower().Contains(key) || nd.Email_NguoiDung.Contains(key))
                           select new
                           {
                               ID = dg.IDDocGia,
                               HoTen = nd.HoTen_NguoiDung,
                               Email = nd.Email_NguoiDung,
                               SDT = nd.SDT_NguoiDung,
                               NgayHetHan = dg.NgayHetHan,
                               TrangThai = nd.TrangThai_NguoiDung
                           };
                dgvDocGia.DataSource = list.ToList();
            }
        }

        private void btnReset_Click(object sender, EventArgs e) => ClearForm();

        private void ClearForm()
        {
            txtMaDG.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            cboTrangThai.SelectedIndex = 0;
            dtpNgayHetHan.Value = DateTime.Now.AddYears(1);
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtHoTen.Text)) { MessageBox.Show("Nhập họ tên!"); return false; }
            if (string.IsNullOrEmpty(txtEmail.Text)) { MessageBox.Show("Nhập email!"); return false; }
            // Thêm Regex check email, sdt ở đây nếu cần
            return true;
        }
    }
}