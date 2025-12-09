using QLTV.Database;
using QLTV.Database.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLTV
{
    public partial class FormDanhMuc : Form
    {
        // Biến lưu ID đang chọn để sửa (0 = chế độ thêm mới)
        private int _idTheLoai = 0;
        private int _idTacGia = 0;
        private int _idNXB = 0;

        public FormDanhMuc()
        {
            InitializeComponent();
            SetupUI();
            LoadData();
        }

        private void SetupUI()
        {
            // Ẩn Header của TabControl để dùng Sidebar điều khiển
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            // Mặc định chọn tab đầu tiên
            SetActiveButton(btnNavTheLoai);
        }

        private void SetActiveButton(Button activeBtn)
        {
            // Reset màu các nút sidebar
            btnNavTheLoai.BackColor = Color.FromArgb(45, 50, 60);
            btnNavTacGia.BackColor = Color.FromArgb(45, 50, 60);
            btnNavNXB.BackColor = Color.FromArgb(45, 50, 60);

            // Highlight nút đang chọn
            activeBtn.BackColor = Color.SeaGreen;
        }

        private void LoadData()
        {
            LoadTheLoai("");
            LoadTacGia("");
            LoadNXB("");
        }

        // ================== LOGIC THỂ LOẠI ==================
        private void LoadTheLoai(string search)
        {
            using (var db = new QLTVDataContext())
            {
                var list = db.TheLoais
                    .Where(t => t.Ten.Contains(search))
                    .Select(t => new { t.Ma, t.Ten })
                    .ToList();
                dgvTheLoai.DataSource = list;
            }
        }

        private void btnThemTL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenTL.Text)) return;
            using (var db = new QLTVDataContext())
            {
                db.TheLoais.Add(new TheLoai { Ten = txtTenTL.Text });
                db.SaveChanges();
            }
            ResetTL();
        }

        private void btnSuaTL_Click(object sender, EventArgs e)
        {
            if (_idTheLoai == 0) { MessageBox.Show("Vui lòng chọn dòng để sửa"); return; }
            using (var db = new QLTVDataContext())
            {
                var item = db.TheLoais.Find(_idTheLoai);
                if (item != null)
                {
                    item.Ten = txtTenTL.Text;
                    db.SaveChanges();
                }
            }
            ResetTL();
        }

        private void btnXoaTL_Click(object sender, EventArgs e)
        {
            if (_idTheLoai == 0) return;
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var db = new QLTVDataContext())
                {
                    var item = db.TheLoais.Find(_idTheLoai);
                    if (item != null) { db.TheLoais.Remove(item); db.SaveChanges(); }
                }
                ResetTL();
            }
        }

        private void dgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTheLoai.Rows[e.RowIndex];
                _idTheLoai = (int)row.Cells["Ma"].Value;
                txtTenTL.Text = row.Cells["Ten"].Value.ToString();
            }
        }

        private void btnHuyTL_Click(object sender, EventArgs e) => ResetTL();
        private void ResetTL() { txtTenTL.Clear(); _idTheLoai = 0; LoadTheLoai(""); }
        private void txtSearchTL_TextChanged(object sender, EventArgs e) => LoadTheLoai(txtSearchTL.Text);


        // ================== LOGIC TÁC GIẢ ==================
        private void LoadTacGia(string search)
        {
            using (var db = new QLTVDataContext())
            {
                var list = db.TacGias
                    .Where(t => t.Ten.Contains(search))
                    .Select(t => new { t.Ma, t.Ten })
                    .ToList();
                dgvTacGia.DataSource = list;
            }
        }

        private void btnThemTG_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenTG.Text)) return;
            using (var db = new QLTVDataContext())
            {
                db.TacGias.Add(new TacGia { Ten = txtTenTG.Text });
                db.SaveChanges();
            }
            ResetTG();
        }

        private void btnSuaTG_Click(object sender, EventArgs e)
        {
            if (_idTacGia == 0) { MessageBox.Show("Vui lòng chọn dòng để sửa"); return; }
            using (var db = new QLTVDataContext())
            {
                var item = db.TacGias.Find(_idTacGia);
                if (item != null)
                {
                    item.Ten = txtTenTG.Text;
                    db.SaveChanges();
                }
            }
            ResetTG();
        }

        private void btnXoaTG_Click(object sender, EventArgs e)
        {
            if (_idTacGia == 0) return;
            if (MessageBox.Show("Xóa tác giả này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var db = new QLTVDataContext())
                {
                    var item = db.TacGias.Find(_idTacGia);
                    if (item != null) { db.TacGias.Remove(item); db.SaveChanges(); }
                }
                ResetTG();
            }
        }

        private void dgvTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTacGia.Rows[e.RowIndex];
                _idTacGia = (int)row.Cells["Ma"].Value;
                txtTenTG.Text = row.Cells["Ten"].Value.ToString();
            }
        }

        private void btnHuyTG_Click(object sender, EventArgs e) => ResetTG();
        private void ResetTG() { txtTenTG.Clear(); _idTacGia = 0; LoadTacGia(""); }
        private void txtSearchTG_TextChanged(object sender, EventArgs e) => LoadTacGia(txtSearchTG.Text);


        // ================== LOGIC NXB ==================
        private void LoadNXB(string search)
        {
            using (var db = new QLTVDataContext())
            {
                var list = db.NhaXuatBans
                    .Where(n => n.Ten.Contains(search))
                    .Select(n => new { n.Ma, n.Ten, n.SDT })
                    .ToList();
                dgvNXB.DataSource = list;
            }
        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNXB.Text)) return;
            using (var db = new QLTVDataContext())
            {
                db.NhaXuatBans.Add(new NhaXuatBan { Ten = txtTenNXB.Text, SDT = txtSdtNXB.Text });
                db.SaveChanges();
            }
            ResetNXB();
        }

        private void btnSuaNXB_Click(object sender, EventArgs e)
        {
            if (_idNXB == 0) { MessageBox.Show("Vui lòng chọn dòng để sửa"); return; }
            using (var db = new QLTVDataContext())
            {
                var item = db.NhaXuatBans.Find(_idNXB);
                if (item != null)
                {
                    item.Ten = txtTenNXB.Text;
                    item.SDT = txtSdtNXB.Text;
                    db.SaveChanges();
                }
            }
            ResetNXB();
        }

        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            if (_idNXB == 0) return;
            if (MessageBox.Show("Xóa NXB này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var db = new QLTVDataContext())
                {
                    var item = db.NhaXuatBans.Find(_idNXB);
                    if (item != null) { db.NhaXuatBans.Remove(item); db.SaveChanges(); }
                }
                ResetNXB();
            }
        }

        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNXB.Rows[e.RowIndex];
                _idNXB = (int)row.Cells["Ma"].Value;
                txtTenNXB.Text = row.Cells["Ten"].Value.ToString();
                txtSdtNXB.Text = row.Cells["SDT"].Value?.ToString();
            }
        }

        private void btnHuyNXB_Click(object sender, EventArgs e) => ResetNXB();
        private void ResetNXB() { txtTenNXB.Clear(); txtSdtNXB.Clear(); _idNXB = 0; LoadNXB(""); }
        private void txtSearchNXB_TextChanged(object sender, EventArgs e) => LoadNXB(txtSearchNXB.Text);


        // ================== ĐIỀU HƯỚNG TAB ==================
        private void btnNavTheLoai_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabTheLoai;
            SetActiveButton(btnNavTheLoai);
        }

        private void btnNavTacGia_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabTacGia;
            SetActiveButton(btnNavTacGia);
        }

        private void btnNavNXB_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabNXB;
            SetActiveButton(btnNavNXB);
        }
    }
}