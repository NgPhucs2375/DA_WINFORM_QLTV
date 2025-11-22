using QLTV.Database;
using QLTV.Database.Entities;
using System;
using System.Data;
using System.Data.Entity;
using System.Drawing; // Để chỉnh màu
using System.Linq;
using System.Windows.Forms;

namespace QLTV
{
    public partial class LapPhieuMuon : Form
    {
        public LapPhieuMuon()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            // Mặc định ngày mượn là hôm nay, hạn trả +7 ngày
            dtpNgayMuon.Value = DateTime.Now;
            dtpHanTra.Value = DateTime.Now.AddDays(7);
        }

        private void LapPhieuMuon_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new QLTVDataContext())
                {
                    // Load Độc giả (Chỉ lấy những người thẻ còn hạn)
                    var docs = db.DocGias
                        .Include(d => d.NGUOIDUNGDATA)
                        .Where(d => d.NgayHetHan >= DateTime.Now)
                        .Select(d => new {
                            d.IDDocGia,
                            HoTen = d.NGUOIDUNGDATA.HoTen_NguoiDung
                        }).ToList();

                    cboDocGia.DataSource = docs;
                    cboDocGia.DisplayMember = "HoTen";
                    cboDocGia.ValueMember = "IDDocGia";

                    // Load Sách (Chỉ lấy sách còn trong kho)
                    var saches = db.Sachs
                        .Where(s => s.SoLuong_Sach > 0)
                        .Select(s => new { s.IDSach, s.Name_Sach })
                        .ToList();

                    cboSach.DataSource = saches;
                    cboSach.DisplayMember = "Name_Sach";
                    cboSach.ValueMember = "IDSach";

                    // Load Trạng thái
                    cboTrangThai.Items.Clear();
                    cboTrangThai.Items.Add("Đang mượn");
                    cboTrangThai.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // Sự kiện khi thay đổi ngày mượn -> Tự tính hạn trả
        private void dtpNgayMuon_ValueChanged(object sender, EventArgs e)
        {
            dtpHanTra.Value = dtpNgayMuon.Value.AddDays(7);
        }

        private void btnLapPhieuMuon_Click(object sender, EventArgs e)
        {
            if (cboDocGia.SelectedValue == null || cboSach.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Độc giả và Sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idDocGia = (int)cboDocGia.SelectedValue;
            int idSach = (int)cboSach.SelectedValue;

            try
            {
                using (var db = new QLTVDataContext())
                {
                    // 1. Kiểm tra lại số lượng sách (tránh trường hợp vừa hết)
                    var sach = db.Sachs.Find(idSach);
                    if (sach == null || sach.SoLuong_Sach <= 0)
                    {
                        MessageBox.Show("Sách này vừa hết hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 2. Tạo phiếu mượn
                    PhieuMuon pm = new PhieuMuon()
                    {
                        IDDocGia_PhieuMuon = idDocGia,
                        IDSach_PhieuMuon = idSach,
                        NgayMuon_Sach = dtpNgayMuon.Value,
                        HanTra_PhieuMuon = dtpHanTra.Value,
                        TrangThai_PhieuMuon = "Đang mượn",
                        SoTienPhat_PhieuMuon = 0
                    };
                    db.PhieuMuons.Add(pm);

                    // 3. Trừ số lượng sách trong kho
                    sach.SoLuong_Sach -= 1;
                    // Nếu muốn đổi trạng thái khi hết sách:
                    if (sach.SoLuong_Sach == 0) sach.TrangThai_Sach = "Hết hàng";

                    db.SaveChanges();

                    MessageBox.Show("Lập phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Quan trọng: Báo cho form cha biết là đã OK để reload lại danh sách
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}