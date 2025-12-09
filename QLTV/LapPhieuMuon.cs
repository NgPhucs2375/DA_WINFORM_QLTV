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

        // Sự kiện khi thay đổi ngày mượn -> Tự tính hạn trả
        private void dtpNgayMuon_ValueChanged(object sender, EventArgs e)
        {
            dtpHanTra.Value = dtpNgayMuon.Value.AddDays(7);
        }

        private void btnLapPhieuMuon_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra đã chọn độc giả và sách chưa
            if (cboDocGia.SelectedValue == null || cboSach.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Độc giả và Sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ================================================================
            // 2. XỬ LÝ LỖI NGÀY THÁNG (Theo yêu cầu của bạn)
            // ================================================================

            // Sử dụng .Date để so sánh ngày, bỏ qua giờ phút giây
            if (dtpHanTra.Value.Date <= dtpNgayMuon.Value.Date)
            {
                MessageBox.Show("Ngày hạn trả phải lớn hơn (sau) ngày mượn!", "Lỗi ngày tháng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpHanTra.Focus(); // Đưa con trỏ về ô hạn trả để người dùng sửa
                return;
            }

            // (Tùy chọn) Kiểm tra ngày mượn không được quá khứ quá xa
            // if (dtpNgayMuon.Value.Date < DateTime.Now.AddDays(-30).Date) { MessageBox.Show("Ngày mượn quá cũ!"); return; }

            // Lấy ID an toàn (Tránh lỗi crash nếu value không phải int)
            int idDocGia, idSach;
            if (!int.TryParse(cboDocGia.SelectedValue.ToString(), out idDocGia) ||
                !int.TryParse(cboSach.SelectedValue.ToString(), out idSach))
            {
                MessageBox.Show("Dữ liệu chọn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var db = new QLTVDataContext())
                {
                    // 3. Kiểm tra lại số lượng sách (tránh trường hợp 2 người cùng mượn 1 cuốn cuối cùng cùng lúc)
                    var sach = db.Sachs.Find(idSach);
                    if (sach == null)
                    {
                        MessageBox.Show("Không tìm thấy thông tin sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (sach.SoLuong_Sach <= 0)
                    {
                        MessageBox.Show($"Sách '{sach.Name_Sach}' vừa hết hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        // Refresh lại danh sách sách nếu cần
                        return;
                    }

                    // 4. Tạo phiếu mượn
                    PhieuMuon pm = new PhieuMuon()
                    {
                        IDDocGia_PhieuMuon = idDocGia,
                        IDSach_PhieuMuon = idSach,
                        NgayMuon_Sach = dtpNgayMuon.Value,
                        HanTra_PhieuMuon = dtpHanTra.Value,
                        TrangThai_PhieuMuon = "Đang mượn",
                        SoTienPhat_PhieuMuon = 0,
                        // Nếu có thông tin người lập phiếu (Program.CurrentUserId) thì thêm vào
                        // IDNhanVien = Program.CurrentUserId 
                    };
                    db.PhieuMuons.Add(pm);

                    // 5. Trừ số lượng sách trong kho
                    sach.SoLuong_Sach -= 1;

                    // Cập nhật trạng thái nếu hết sách
                    if (sach.SoLuong_Sach == 0) sach.TrangThai_Sach = "Hết hàng";

                    db.SaveChanges();

                    // 6. Hỏi in phiếu
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
            // Thiết lập font chữ
            Font fontTieuDe = new Font("Arial", 20, FontStyle.Bold);
            Font fontNoiDung = new Font("Arial", 12);
            Font fontNguoiLap = new Font("Arial", 14, FontStyle.Bold);

            // Vẽ tiêu đề
            e.Graphics.DrawString("PHIẾU MƯỢN SÁCH", fontTieuDe, Brushes.DarkBlue, 250, 50);

            // Vẽ thông tin chi tiết
            int startX = 100;
            int startY = 120;
            int offset = 30;

            e.Graphics.DrawString($"Độc giả: {cboDocGia.Text}", fontNoiDung, Brushes.Black, startX, startY);
            e.Graphics.DrawString($"Sách: {cboSach.Text}", fontNoiDung, Brushes.Black, startX, startY + offset);
            e.Graphics.DrawString($"Ngày mượn: {dtpNgayMuon.Value:dd/MM/yyyy}", fontNoiDung, Brushes.Black, startX, startY + offset * 2);
            e.Graphics.DrawString($"Hạn trả: {dtpHanTra.Value:dd/MM/yyyy}", fontNoiDung, Brushes.Black, startX, startY + offset * 3);

            // Vẽ footer (Người lập phiếu)
            // Kiểm tra null để tránh lỗi nếu chưa đăng nhập (Program.CurrentName chưa có giá trị)
            string nguoiLap = Program.CurrentName ?? "Admin";

            e.Graphics.DrawString($"Người lập phiếu: {nguoiLap}", fontNguoiLap, Brushes.DarkBlue, 400, 300);
        }



    }
}