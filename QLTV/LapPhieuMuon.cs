using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using QLTV.Database; // chứa QLTVDataContext
using QLTV.Database.Entities;

namespace QLTV
{
    public partial class LapPhieuMuon : Form
    {
        // SỬ DỤNG đúng class context của project anh
        private QLTVDataContext db = new QLTVDataContext();

        public LapPhieuMuon()
        {
            InitializeComponent();
        }

        private void LapPhieuMuon_Load(object sender, EventArgs e)
        {
            try
            {
                // Load độc giả: dùng DbSet tên DocGias (theo QLTVDataContext.cs)
                var docs = db.DocGias.Include(d => d.NGUOIDUNGDATA).ToList();
                cboDocGia.DataSource = docs;
                cboDocGia.DisplayMember = "NGUOIDUNGDATA.HoTen_NguoiDung";
                cboDocGia.ValueMember = "IDDocGia";

                // Load sách có trạng thái "Có sẵn" (hoặc theo giá trị anh lưu)
                var saches = db.Sachs.Where(s => s.TrangThai_Sach == "Có sẵn" || s.TrangThai_Sach == "Còn sẵn" || s.TrangThai_Sach == "Co san")
                                     .ToList();
                // nếu không có, fallback load tất cả
                if (!saches.Any()) saches = db.Sachs.ToList();

                cboSach.DataSource = saches;
                cboSach.DisplayMember = "Name_Sach";
                cboSach.ValueMember = "IDSach";

                // Trang thai mặc định khi lập phiếu
                cboTrangThai.Items.Clear();
                cboTrangThai.Items.Add("Đang mượn");
                cboTrangThai.SelectedIndex = 0;

                dtpNgayMuon.Value = DateTime.Now;
                dtpHanTra.Value = DateTime.Now.AddDays(7);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
            }
        }

        // NOTE: Designer gọi event này: btnLapPhieuMuon_Click
        private void btnLapPhieuMuon_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboDocGia.SelectedValue == null || cboSach.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn độc giả và sách.", "Thông báo");
                    return;
                }

                int idDocGia = (int)cboDocGia.SelectedValue;
                int idSach = (int)cboSach.SelectedValue;

                // Tạo phiếu mượn mới
                var pm = new PhieuMuon
                {
                    IDDocGia_PhieuMuon = idDocGia,
                    IDSach_PhieuMuon = idSach,
                    NgayMuon_Sach = dtpNgayMuon.Value.Date,
                    HanTra_PhieuMuon = dtpHanTra.Value.Date,
                    TrangThai_PhieuMuon = cboTrangThai.Text,
                    SoTienPhat_PhieuMuon = 0
                };

                db.PhieuMuons.Add(pm);

                // Cập nhật trạng thái sách (nếu có field TrangThai_Sach)
                var sach = db.Sachs.Find(idSach);
                if (sach != null)
                {
                    sach.TrangThai_Sach = "Đang mượn";
                }

                db.SaveChanges();
                MessageBox.Show("Lập phiếu mượn thành công!", "Thành công");

                // Refresh danh sách sách còn mượn
                var saches = db.Sachs.Where(s => s.TrangThai_Sach == "Có sẵn" || s.TrangThai_Sach == "Còn sẵn" || s.TrangThai_Sach == "Co san").ToList();
                if (!saches.Any()) saches = db.Sachs.ToList();
                cboSach.DataSource = saches;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lập phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
