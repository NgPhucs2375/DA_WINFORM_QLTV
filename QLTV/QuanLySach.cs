using QLTV.Database;
using QLTV.Database.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLTV
{
    public partial class QuanLySach : Form
    {
        public QuanLySach()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            // Style DataGridView
            dgwhowList.BorderStyle = BorderStyle.None;
            dgwhowList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgwhowList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgwhowList.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgwhowList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgwhowList.BackgroundColor = Color.White;
            dgwhowList.EnableHeadersVisualStyles = false;
            dgwhowList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgwhowList.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen; // Màu chủ đạo
            dgwhowList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgwhowList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgwhowList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwhowList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Init ComboBox Trạng thái
            cboTrangThai.Items.AddRange(new string[] { "Có sẵn", "Hết hàng", "Ngưng hoạt động" });
            cboTrangThai.SelectedIndex = 0;
        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (var db = new QLTVDataContext())
            {
                dgwhowList.DataSource = db.Sachs.Select(s => new {
                    ID = s.IDSach,
                    TenSach = s.Name_Sach,
                    TacGia = s.TacGia_Sach,
                    TheLoai = s.TheLoai_Sach,
                    NXB = s.NhaXuatBan_Sach,
                    NamXB = s.NamXuatBan_Sach,
                    SoLuong = s.SoLuong_Sach,
                    TrangThai = s.TrangThai_Sach
                }).ToList();
            }
        }

        private void dgwhowList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgwhowList.Rows[e.RowIndex];
            txtIDSach.Text = row.Cells["ID"].Value.ToString();
            txtNameSach.Text = row.Cells["TenSach"].Value.ToString();
            txtTacGia.Text = row.Cells["TacGia"].Value.ToString();
            txtChuDe.Text = row.Cells["TheLoai"].Value.ToString();
            txtNXB.Text = row.Cells["NXB"].Value.ToString();
            txtNamXB.Text = row.Cells["NamXB"].Value.ToString();
            txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();

            string status = row.Cells["TrangThai"].Value.ToString();
            if (cboTrangThai.Items.Contains(status)) cboTrangThai.SelectedItem = status;
        }

        // Tìm kiếm thông minh (Real-time)
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string key = txtSearch.Text.ToLower();
            using (var db = new QLTVDataContext())
            {
                // Tìm kiếm trên nhiều trường cùng lúc
                var list = db.Sachs.Where(s =>
                    s.Name_Sach.ToLower().Contains(key) ||
                    s.TacGia_Sach.ToLower().Contains(key) ||
                    s.TheLoai_Sach.ToLower().Contains(key) ||
                    s.IDSach.ToString().Contains(key)
                ).Select(s => new {
                    ID = s.IDSach,
                    TenSach = s.Name_Sach,
                    TacGia = s.TacGia_Sach,
                    TheLoai = s.TheLoai_Sach,
                    NXB = s.NhaXuatBan_Sach,
                    NamXB = s.NamXuatBan_Sach,
                    SoLuong = s.SoLuong_Sach,
                    TrangThai = s.TrangThai_Sach
                }).ToList();

                dgwhowList.DataSource = list;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                using (var db = new QLTVDataContext())
                {
                    Sach s = new Sach()
                    {
                        Name_Sach = txtNameSach.Text.Trim(),
                        TacGia_Sach = txtTacGia.Text.Trim(),
                        TheLoai_Sach = txtChuDe.Text.Trim(),
                        NhaXuatBan_Sach = txtNXB.Text.Trim(),
                        NamXuatBan_Sach = int.Parse(txtNamXB.Text),
                        SoLuong_Sach = int.Parse(txtSoLuong.Text),
                        TrangThai_Sach = cboTrangThai.Text,
                        ViTriSach = "Kệ A1" // Mặc định hoặc thêm textbox nhập
                    };

                    db.Sachs.Add(s);
                    db.SaveChanges();
                    MessageBox.Show("Thêm sách thành công!");
                    LoadData();
                    ClearForm();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDSach.Text)) return;
            if (!ValidateInput()) return;

            try
            {
                using (var db = new QLTVDataContext())
                {
                    int id = int.Parse(txtIDSach.Text);
                    var s = db.Sachs.FirstOrDefault(x => x.IDSach == id);
                    if (s != null)
                    {
                        s.Name_Sach = txtNameSach.Text.Trim();
                        s.TacGia_Sach = txtTacGia.Text.Trim();
                        s.TheLoai_Sach = txtChuDe.Text.Trim();
                        s.NhaXuatBan_Sach = txtNXB.Text.Trim();
                        s.NamXuatBan_Sach = int.Parse(txtNamXB.Text);
                        s.SoLuong_Sach = int.Parse(txtSoLuong.Text);
                        s.TrangThai_Sach = cboTrangThai.Text;

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
            if (string.IsNullOrEmpty(txtIDSach.Text)) return;
            if (MessageBox.Show("Bạn có chắc muốn xóa sách này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No) return;

            try
            {
                using (var db = new QLTVDataContext())
                {
                    int id = int.Parse(txtIDSach.Text);
                    var s = db.Sachs.FirstOrDefault(x => x.IDSach == id);
                    if (s != null)
                    {
                        // Kiểm tra ràng buộc khóa ngoại (sách đang mượn thì không được xóa)
                        if (db.PhieuMuons.Any(p => p.IDSach_PhieuMuon == id))
                        {
                            MessageBox.Show("Sách này đang có trong phiếu mượn, không thể xóa!", "Cảnh báo");
                            return;
                        }

                        db.Sachs.Remove(s);
                        db.SaveChanges();
                        MessageBox.Show("Đã xóa!");
                        LoadData();
                        ClearForm();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi hệ thống: " + ex.Message); }
        }

        private void btnReset_Click(object sender, EventArgs e) => ClearForm();

        private void ClearForm()
        {
            txtIDSach.Clear();
            txtNameSach.Clear();
            txtTacGia.Clear();
            txtChuDe.Clear();
            txtNXB.Clear();
            txtNamXB.Clear();
            txtSoLuong.Clear();
            cboTrangThai.SelectedIndex = 0;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtNameSach.Text)) { MessageBox.Show("Nhập tên sách!"); return false; }
            if (!int.TryParse(txtSoLuong.Text, out _)) { MessageBox.Show("Số lượng phải là số!"); return false; }
            if (!int.TryParse(txtNamXB.Text, out _)) { MessageBox.Show("Năm XB phải là số!"); return false; }
            return true;
        }

        // Sự kiện thừa
        private void btnSearch_Click(object sender, EventArgs e) { } // Đã dùng TextChanged
        private void btnHTDanhSach_Click(object sender, EventArgs e) => LoadData();
    }
}