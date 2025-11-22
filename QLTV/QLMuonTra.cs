using QLTV.Database;
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
    public partial class QLMuonTra : Form
    {
        public QLMuonTra()
        {
            InitializeComponent();
        }
        private List<object> DanhSachMuon()
        {
            using (var db = new QLTVDataContext())
            {
                var lstMuon = from muon in db.PhieuMuons
                              join docgia in db.DocGias on muon.IDDocGia_PhieuMuon equals docgia.IDDocGia
                              join sach in db.Sachs on muon.IDSach_PhieuMuon equals sach.IDSach
                              select new
                              {
                                  muon.IDPhieuMuon,
                                  muon.IDDocGia_PhieuMuon,
                                  muon.IDSach_PhieuMuon,
                                  sach.Name_Sach,
                                  muon.NgayMuon_Sach,
                                  muon.HanTra_PhieuMuon,
                                  muon.TrangThai_PhieuMuon,
                                  muon.SoTienPhat_PhieuMuon
                              };

                return lstMuon.ToList<object>();


            }
        }
        private void SetupHeaders(DataGridView dgv)
        {
            dgv.Columns["IDPhieuMuon"].HeaderText = "Mã phiếu mượn";
            dgv.Columns["IDDocGia_PhieuMuon"].HeaderText = "Mã độc giả";
            dgv.Columns["IDSach_PhieuMuon"].HeaderText = "Mã sách";
            dgv.Columns["Name_Sach"].HeaderText = "Tên sách";
            dgv.Columns["NgayMuon_Sach"].HeaderText = "Ngày mượn";
            dgv.Columns["HanTra_PhieuMuon"].HeaderText = "Hạn trả";
            dgv.Columns["TrangThai_PhieuMuon"].HeaderText = "Trạng thái";
            dgv.Columns["SoTienPhat_PhieuMuon"].HeaderText = "Số tiền phạt";
        }
        private void BindDanhSachMuonToGrid(DataGridView dgv)
        {
            dgv.DataSource = DanhSachMuon();

            SetupHeaders(dgv);
        }



        //tabpage Quản lý mượn
        private void QLMuonTra_Load(object sender, EventArgs e)
        {
            dtpNgayMuon.Format = DateTimePickerFormat.Custom;
            dtpNgayMuon.CustomFormat = "yyyy/MM/dd";
            dtpNgayTra.Format = DateTimePickerFormat.Custom;
            dtpNgayTra.CustomFormat = "yyyy/MM/dd";
        }
        private void btnThemPhieuMuon_Click(object sender, EventArgs e)
        {
            LapPhieuMuon f = new LapPhieuMuon();
            f.Show();
        }
        private void btnHTDSMuon_Click(object sender, EventArgs e)
        {
            BindDanhSachMuonToGrid(dgvDSMuon);
        }
        private void dgvDSMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvDSMuon.Rows[e.RowIndex];

            txtMaPhieu.Text = row.Cells["IDPhieuMuon"].Value?.ToString();
            txtMaDG.Text = row.Cells["IDDocGia_PhieuMuon"].Value?.ToString();
            txtMaSach.Text = row.Cells["IDSach_PhieuMuon"].Value?.ToString();
            txtTenSach.Text = row.Cells["Name_Sach"].Value?.ToString();
            txtTrangThai.Text = row.Cells["TrangThai_PhieuMuon"].Value?.ToString();
            if (row.Cells["NgayMuon_Sach"].Value != null) { 
                dtpNgayMuon.Value = Convert.ToDateTime(row.Cells["NgayMuon_Sach"].Value);
            }

            if (row.Cells["HanTra_PhieuMuon"].Value != null)
            {
                dtpNgayTra.Value = Convert.ToDateTime(row.Cells["HanTra_PhieuMuon"].Value);
            }
            txtTienPhat.Text = row.Cells["SoTienPhat_PhieuMuon"].Value?.ToString();
        }
        private void btnSuaPhieuMuon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn cần sửa!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new QLTVDataContext())
                {
                    int idPhieu = Convert.ToInt32(txtMaPhieu.Text);

                    // Tìm phiếu mượn theo ID
                    var phieu = db.PhieuMuons.SingleOrDefault(p => p.IDPhieuMuon == idPhieu);

                    if (phieu == null)
                    {
                        MessageBox.Show("Không tìm thấy phiếu mượn!", "Lỗi",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    phieu.IDDocGia_PhieuMuon = Convert.ToInt32(txtMaDG.Text);
                    phieu.IDSach_PhieuMuon = Convert.ToInt32(txtMaSach.Text);
                    phieu.NgayMuon_Sach = dtpNgayMuon.Value;
                    phieu.HanTra_PhieuMuon = dtpNgayTra.Value;

                    phieu.TrangThai_PhieuMuon = "Đang mượn"; 

                    phieu.SoTienPhat_PhieuMuon =
                        string.IsNullOrWhiteSpace(txtTienPhat.Text)? 0: Convert.ToDecimal(txtTienPhat.Text);

                    db.SaveChanges();

                    MessageBox.Show("Cập nhật phiếu mượn thành công!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnHTDSMuon_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // tabpage Quản lý trả
        private void btnHTDSMuon1_Click(object sender, EventArgs e)
        {
            BindDanhSachMuonToGrid(dgvDSTra);
        }
        private void btnPhieuTra_Click(object sender, EventArgs e)
        {
            LapPhieuTra f = new LapPhieuTra();
            f.Show();
        }
        private void btnTimDSMuon_Click(object sender, EventArgs e)
        {
            using (var db = new QLTVDataContext())
            {
                string keyword = txtMaPMuon.Text.Trim();
                if (string.IsNullOrWhiteSpace(keyword))
                {
                    MessageBox.Show("Vui lòng nhập mã phiếu mượn để tìm kiếm!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                var ketqua = new List<object>();
                if(int.TryParse(keyword, out int maphieu))
                {
                    ketqua = (from muon in db.PhieuMuons
                              join docgia in db.DocGias on muon.IDDocGia_PhieuMuon equals docgia.IDDocGia
                              join sach in db.Sachs on muon.IDSach_PhieuMuon equals sach.IDSach
                              where muon.IDPhieuMuon == maphieu
                              select new
                              {
                                  muon.IDPhieuMuon,
                                  muon.IDDocGia_PhieuMuon,
                                  muon.IDSach_PhieuMuon,
                                  sach.Name_Sach,
                                  muon.NgayMuon_Sach,
                                  muon.HanTra_PhieuMuon,
                                  muon.TrangThai_PhieuMuon,
                                  muon.SoTienPhat_PhieuMuon
                              }).ToList<object>();

                }
                else
                {
                    MessageBox.Show("Mã phiếu mượn không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ketqua.Any())
                {
                    dgvDSTra.DataSource = ketqua;
                    SetupHeaders(dgvDSTra);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu mượn phù hợp", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDSMuon.DataSource = null;
                }
            }
            
            

        }
        private void btnXoaPhieuMuon_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
