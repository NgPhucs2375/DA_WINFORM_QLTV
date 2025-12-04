using QLTV.Database;
using QLTV.Database.Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLTV
{
    public partial class FormDanhMuc : Form
    {
        public FormDanhMuc()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadData();
        }

        private void LoadData()
        {
            using (var db = new QLTVDataContext())
            {
                dgvTheLoai.DataSource = db.TheLoais.ToList();
                dgvTacGia.DataSource = db.TacGias.ToList();
                dgvNXB.DataSource = db.NhaXuatBans.ToList();
            }
        }

        // Xử lý Thể Loại
        private void btnLuuTL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenTL.Text)) return;
            using (var db = new QLTVDataContext())
            {
                db.TheLoais.Add(new TheLoai { Ten = txtTenTL.Text });
                db.SaveChanges();
            }
            LoadData(); txtTenTL.Clear();
        }

        private void btnXoaTL_Click(object sender, EventArgs e)
        {
            if (dgvTheLoai.CurrentRow == null) return;
            int id = (int)dgvTheLoai.CurrentRow.Cells["Ma"].Value;
            using (var db = new QLTVDataContext())
            {
                var item = db.TheLoais.Find(id);
                if (item != null) { db.TheLoais.Remove(item); db.SaveChanges(); }
            }
            LoadData();
        }

        // Xử lý Tác Giả
        private void btnLuuTG_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenTG.Text)) return;
            using (var db = new QLTVDataContext())
            {
                db.TacGias.Add(new TacGia { Ten = txtTenTG.Text });
                db.SaveChanges();
            }
            LoadData(); txtTenTG.Clear();
        }

        private void btnXoaTG_Click(object sender, EventArgs e)
        {
            if (dgvTacGia.CurrentRow == null) return;
            int id = (int)dgvTacGia.CurrentRow.Cells["Ma"].Value;
            using (var db = new QLTVDataContext())
            {
                var item = db.TacGias.Find(id);
                if (item != null) { db.TacGias.Remove(item); db.SaveChanges(); }
            }
            LoadData();
        }

        // Xử lý NXB
        private void btnLuuNXB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNXB.Text)) return;
            using (var db = new QLTVDataContext())
            {
                db.NhaXuatBans.Add(new NhaXuatBan { Ten = txtTenNXB.Text, SDT = txtSdtNXB.Text });
                db.SaveChanges();
            }
            LoadData(); txtTenNXB.Clear(); txtSdtNXB.Clear();
        }

        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            if (dgvNXB.CurrentRow == null) return;
            int id = (int)dgvNXB.CurrentRow.Cells["Ma"].Value;
            using (var db = new QLTVDataContext())
            {
                var item = db.NhaXuatBans.Find(id);
                if (item != null) { db.NhaXuatBans.Remove(item); db.SaveChanges(); }
            }
            LoadData();
        }
    }
}