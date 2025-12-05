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

                    DialogResult result = MessageBox.Show("Lập phiếu thành công! Bạn có muốn in phiếu không?", "In phiếu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void InPhieu_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    Font fontTieuDe = new Font("Arial", 20, FontStyle.Bold);
        //    Font fontNoiDung = new Font("Arial", 12);


        //    e.Graphics.DrawString("PHIẾU MƯỢN SÁCH", fontTieuDe, Brushes.Black, 250, 50);
        //    e.Graphics.DrawString($"Độc giả: {cboDocGia.Text}", fontNoiDung, Brushes.Black, 100, 120);
        //    e.Graphics.DrawString($"Sách: {cboSach.Text}", fontNoiDung, Brushes.Black, 100, 150);
        //    e.Graphics.DrawString($"Ngày mượn: {dtpNgayMuon.Value:dd/MM/yyyy}", fontNoiDung, Brushes.Black, 100, 180);
        //    e.Graphics.DrawString($"Hạn trả: {dtpHanTra.Value:dd/MM/yyyy}", fontNoiDung, Brushes.Black, 100, 210);
        //    e.Graphics.DrawString($"Người lập phiếu: {Program.CurrentName}", fontNoiDung, Brushes.Black, 500, 300);
        //}

        private void InPhieu_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font fontTieuDe = new Font("Arial", 20, FontStyle.Bold);
            Font fontNoiDung = new Font("Arial", 12);

            e.Graphics.DrawString("PHIẾU MƯỢN SÁCH", fontTieuDe, Brushes.Black, 250, 50);
            e.Graphics.DrawString($"Độc giả: {cboDocGia.Text}", fontNoiDung, Brushes.Black, 100, 120);
            e.Graphics.DrawString($"Sách: {cboSach.Text}", fontNoiDung, Brushes.Black, 100, 150);
            e.Graphics.DrawString($"Ngày mượn: {dtpNgayMuon.Value:dd/MM/yyyy}", fontNoiDung, Brushes.Black, 100, 180);
            e.Graphics.DrawString($"Hạn trả: {dtpHanTra.Value:dd/MM/yyyy}", fontNoiDung, Brushes.Black, 100, 210);

            // Font to, đậm, màu xanh dương
            using (Font fontNguoiLapPhieu = new Font("Arial", 16, FontStyle.Bold))
            {
                Brush brushNguoiLapPhieu = Brushes.DarkBlue;

                // Có thể căn chỉnh lại vị trí để đẹp hơn, ví dụ lùi lại chút bên trái
                PointF point = new PointF(400, 300);

                e.Graphics.DrawString($"Người lập phiếu: {Program.CurrentName}", fontNguoiLapPhieu, brushNguoiLapPhieu, point);
            }
        }

    }
}