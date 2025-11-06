using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using QLTV.Database;
using QLTV.Database.Entities;

namespace QLTV
{
    public partial class LapPhieuTra : Form
    {
        private QLTVDataContext db = new QLTVDataContext();

        public LapPhieuTra()
        {
            InitializeComponent();
        }

        private void LapPhieuTra_Load(object sender, EventArgs e)
        {
            try
            {
                // Load phiếu đang mượn
                var phieus = db.PhieuMuons
                               .Where(p => p.TrangThai_PhieuMuon == "Đang mượn")
                               .Include(p => p.SACHDATA)
                               .Include(p => p.DOCGIADATA.NGUOIDUNGDATA)
                               .ToList();

                // Prepare anonymous list to show in combobox
                var list = phieus.Select(p => new
                {
                    p.IDPhieuMuon,
                    Display = "PM" + p.IDPhieuMuon + " - " + (p.SACHDATA != null ? p.SACHDATA.Name_Sach : "Sách #" + p.IDSach_PhieuMuon)
                }).ToList();

                cboPhieuMuon.DataSource = list;
                cboPhieuMuon.DisplayMember = "Display";
                cboPhieuMuon.ValueMember = "IDPhieuMuon";

                lblTenDocGia.Text = "-";
                lblTenSach.Text = "-";
                lblSoTienPhat.Text = "0 đ";
                dtpNgayTra.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load phiếu mượn: " + ex.Message);
            }
        }

        // Designer gọi cboPhieuMuon_SelectedIndexChanged
        private void cboPhieuMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboPhieuMuon.SelectedValue == null) return;
                int id = (int)cboPhieuMuon.SelectedValue;
                var pm = db.PhieuMuons
                           .Include(p => p.DOCGIADATA.NGUOIDUNGDATA)
                           .Include(p => p.SACHDATA)
                           .FirstOrDefault(p => p.IDPhieuMuon == id);

                if (pm != null)
                {
                    lblTenDocGia.Text = pm.DOCGIADATA?.NGUOIDUNGDATA?.HoTen_NguoiDung ?? "-";
                    lblTenSach.Text = pm.SACHDATA?.Name_Sach ?? "-";
                    dtpNgayTra.Value = DateTime.Now;

                    // Tính tiền phạt: giả sử 1000đ/ngày trễ
                    int songaytre = (DateTime.Now.Date - pm.HanTra_PhieuMuon.Date).Days;
                    if (songaytre > 0)
                    {
                        lblSoTienPhat.Text = (songaytre * 1000).ToString("N0") + " đ";
                    }
                    else
                    {
                        lblSoTienPhat.Text = "0 đ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Designer gọi btnTraSach_Click
        private void btnTraSach_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboPhieuMuon.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn phiếu mượn.", "Thông báo");
                    return;
                }

                int id = (int)cboPhieuMuon.SelectedValue;
                var pm = db.PhieuMuons.Include(p => p.SACHDATA).FirstOrDefault(p => p.IDPhieuMuon == id);

                if (pm == null)
                {
                    MessageBox.Show("Phiếu mượn không tồn tại.", "Lỗi");
                    return;
                }

                pm.NgayTra_PhieuMuon = dtpNgayTra.Value.Date;
                pm.TrangThai_PhieuMuon = "Đã trả";

                int songaytre = (dtpNgayTra.Value.Date - pm.HanTra_PhieuMuon.Date).Days;
                pm.SoTienPhat_PhieuMuon = songaytre > 0 ? songaytre * 1000 : 0;

                // Cập nhật sách thành có sẵn
                if (pm.SACHDATA != null)
                {
                    pm.SACHDATA.TrangThai_Sach = "Có sẵn";
                }

                db.SaveChanges();
                MessageBox.Show("Trả sách thành công!", "Thành công");

                // Refresh combobox phiếu mượn
                LapPhieuTra_Load(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi trả sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
