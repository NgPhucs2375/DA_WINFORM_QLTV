using QLTV.Database;
using QLTV.Database.Entities;
using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Printing;
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

            // Format hiển thị ngày tháng cho dễ nhìn
            dtpNgayMuon.Format = DateTimePickerFormat.Short;
            dtpHanTra.Format = DateTimePickerFormat.Short;
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

        private void dtpNgayMuon_ValueChanged(object sender, EventArgs e)
        {
            dtpHanTra.Value = dtpNgayMuon.Value.AddDays(7);
        }

        private void btnLapPhieuMuon_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra đầu vào
            if (cboDocGia.SelectedValue == null || cboSach.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Độc giả và Sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpHanTra.Value.Date <= dtpNgayMuon.Value.Date)
            {
                MessageBox.Show("Ngày hạn trả phải lớn hơn (sau) ngày mượn!", "Lỗi ngày tháng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpHanTra.Focus();
                return;
            }

            int idDocGia, idSach;
            if (!int.TryParse(cboDocGia.SelectedValue.ToString(), out idDocGia) ||
                !int.TryParse(cboSach.SelectedValue.ToString(), out idSach))
            {
                MessageBox.Show("Dữ liệu chọn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // --- SỬA LỖI: CHỈ DÙNG 1 KHỐI USING DUY NHẤT Ở ĐÂY ---
                using (var db = new QLTVDataContext())
                {
                    // === LOGIC MỚI: KIỂM TRA GIỚI HẠN MƯỢN ===
                    int dangMuon = db.PhieuMuons.Count(p =>
                        p.IDDocGia_PhieuMuon == idDocGia &&
                        p.TrangThai_PhieuMuon == "Đang mượn");

                    int gioiHan = 5; // Mặc định
                    var config = db.ThamSos.Find("GIOI_HAN_SACH_MUON");
                    if (config != null) int.TryParse(config.GiaTri, out gioiHan);

                    if (dangMuon >= gioiHan)
                    {
                        MessageBox.Show($"Độc giả này đang mượn {dangMuon} cuốn sách.\nQuy định chỉ được mượn tối đa {gioiHan} cuốn.\nVui lòng trả sách cũ trước khi mượn mới.",
                            "Vi phạm quy định", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Dừng lại, không cho mượn tiếp
                    }
                    // ==========================================

                    // 2. Kiểm tra sách trong kho
                    var sach = db.Sachs.Find(idSach);
                    if (sach == null) return;

                    if (sach.SoLuong_Sach <= 0)
                    {
                        MessageBox.Show($"Sách '{sach.Name_Sach}' vừa hết hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 3. Tạo phiếu mượn
                    PhieuMuon pm = new PhieuMuon()
                    {
                        IDDocGia_PhieuMuon = idDocGia,
                        IDSach_PhieuMuon = idSach,
                        NgayMuon_Sach = dtpNgayMuon.Value,
                        HanTra_PhieuMuon = dtpHanTra.Value,
                        TrangThai_PhieuMuon = "Đang mượn",
                        SoTienPhat_PhieuMuon = 0,
                        // IDNhanVien = Program.CurrentUserId 
                    };
                    db.PhieuMuons.Add(pm);

                    // 4. Trừ số lượng sách
                    sach.SoLuong_Sach -= 1;
                    if (sach.SoLuong_Sach == 0) sach.TrangThai_Sach = "Hết hàng";

                    db.SaveChanges();

                    // 5. In phiếu
                    DialogResult result = MessageBox.Show("Lập phiếu thành công! Bạn có muốn in phiếu không?", "Thành công", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        PrintDocument pd = new PrintDocument();
                        pd.PrintPage += new PrintPageEventHandler(InPhieu_PrintPage);
                        PrintPreviewDialog preview = new PrintPreviewDialog();
                        preview.Document = pd;
                        preview.ShowDialog();
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InPhieu_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font fontTieuDe = new Font("Arial", 20, FontStyle.Bold);
            Font fontNoiDung = new Font("Arial", 12);
            Font fontNguoiLap = new Font("Arial", 14, FontStyle.Bold);

            e.Graphics.DrawString("PHIẾU MƯỢN SÁCH", fontTieuDe, Brushes.DarkBlue, 250, 50);

            int startX = 100;
            int startY = 120;
            int offset = 30;

            e.Graphics.DrawString($"Độc giả: {cboDocGia.Text}", fontNoiDung, Brushes.Black, startX, startY);
            e.Graphics.DrawString($"Sách: {cboSach.Text}", fontNoiDung, Brushes.Black, startX, startY + offset);
            e.Graphics.DrawString($"Ngày mượn: {dtpNgayMuon.Value:dd/MM/yyyy}", fontNoiDung, Brushes.Black, startX, startY + offset * 2);
            e.Graphics.DrawString($"Hạn trả: {dtpHanTra.Value:dd/MM/yyyy}", fontNoiDung, Brushes.Black, startX, startY + offset * 3);

            string nguoiLap = Program.CurrentName ?? "Admin";
            e.Graphics.DrawString($"Người lập phiếu: {nguoiLap}", fontNguoiLap, Brushes.DarkBlue, 400, 300);
        }
    }
}