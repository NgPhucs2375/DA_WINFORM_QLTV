using QLTV.Database;
using QLTV.Database.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class QuanLySach : Form
    {
        public QuanLySach()
        {
            InitializeComponent();
            this.Load += QuanLySach_Load;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!");
                return;
            }

            using (var db = new QLTVDataContext())
            {
                // IQueryable<> la 1 kieu interface trong LINQ dung de truy van du lieu tu tra lai lap trinh huong doi tuong
                IQueryable<Sach> truyvan = db.Sachs;
                bool anyChecked = false;
                if (cbTTheoTen.Checked)
                {
                    truyvan = truyvan.Where(s => s.Name_Sach.ToLower().Contains(keyword.ToLower()));
                    anyChecked = true;
                }
                if (cbTTheoMa.Checked )
                {
                    if (!int.TryParse(keyword, out int maSach))
                    {
                        MessageBox.Show("Mã sách phải là số!");
                        return;
                    }
                    truyvan = truyvan.Where(s => s.IDSach == maSach);
                    anyChecked = true;
                }
                 if (cbTTheoTacGia.Checked)
                {
                    truyvan = truyvan.Where(s => s.TacGia_Sach.ToLower().Contains(keyword.ToLower()));
                    anyChecked = true;
                }
                if (cbTTChuDe.Checked)
                {
                    truyvan = truyvan.Where(s => s.TheLoai_Sach.ToLower().Contains(keyword.ToLower()));
                    anyChecked = true;
                }
                if(!anyChecked)
                {
                    MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm!");
                    return;
                }

                var ketqua = truyvan.ToList();

                if (ketqua.Count == 0)
                {
                    dgwhowList.DataSource = null; // Xóa dữ liệu cũ

                    MessageBox.Show("Không tìm thấy sách phù hợp với từ khóa!");
                }
                else
                {
                    dgwhowList.DataSource = ketqua;
                    MessageBox.Show($"Tìm thấy {ketqua.Count} sách phù hợp.");

                }
           }
        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            using (var db = new QLTVDataContext())
            {
                var allBooks = db.Sachs.ToList();
                dgwhowList.DataSource = allBooks;
            }
        }

        private void dgwhowList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgwhowList.Rows[e.RowIndex];
                txtIDSach.Text = row.Cells["IDSach"].Value.ToString();
                txtNameSach.Text = row.Cells["Name_Sach"].Value.ToString();
                txtTacGia.Text = row.Cells["TacGia_Sach"].Value.ToString();
                txtChuDe.Text = row.Cells["TheLoai_Sach"].Value.ToString();
                txtNXB.Text = row.Cells["NhaXuatBan_Sach"].Value.ToString();
                txtNamXB.Text = row.Cells["NamXuatBan_Sach"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong_Sach"].Value.ToString();
                txtTrangThai.Text = row.Cells["TrangThai_Sach"].Value.ToString();

            }
        }

        private void dgwhowList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHTDanhSach_Click(object sender, EventArgs e)
        {
            using (var db = new QLTVDataContext())
            {
                var allBooks = db.Sachs.ToList();
                dgwhowList.DataSource = allBooks;
            }
        }
    }
}
