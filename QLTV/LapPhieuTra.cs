using QLTV.Database;
using QLTV.Database.Entities;
using System;
using System.Data;
using System.Data.Entity; // Cần thiết cho Include
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLTV
{
    public partial class LapPhieuTra : Form
    {
        // Định nghĩa giá tiền phạt mỗi ngày (có thể lấy từ DB bảng ThamSo nếu có)
        private const decimal FINE_PER_DAY = 5000;

        public LapPhieuTra()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            dtpNgayTra.Value = DateTime.Now;
        }

        private void LapPhieuTra_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhieuMuon();
        }

        private void LoadDanhSachPhieuMuon()
        {
            try
            {
                using (var db = new QLTVDataContext())
                {
                    // Chỉ lấy các phiếu có trạng thái "Đang mượn"
                    var listPhieu = db.PhieuMuons
                        .Include(p => p.SACHDATA)
                        .Include(p => p.DOCGIADATA.NGUOIDUNGDATA)
                        .Where(p => p.TrangThai_PhieuMuon == "Đang mượn")
                        .Select(p => new
                        {
                            p.IDPhieuMuon,
                            // Hiển thị: PM10 - Harry Potter (Nguyễn Văn A)
                            Display = "PM" + p.IDPhieuMuon + " - " + p.SACHDATA.Name_Sach + " (" + p.DOCGIADATA.NGUOIDUNGDATA.HoTen_NguoiDung + ")"
                        })
                        .ToList();

                    cboPhieuMuon.DataSource = listPhieu;
                    cboPhieuMuon.DisplayMember = "Display";
                    cboPhieuMuon.ValueMember = "IDPhieuMuon";

                    // Reset thông tin
                    if (listPhieu.Count == 0) ClearInfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void ClearInfo()
        {
            lblTenDocGia.Text = "---";
            lblTenSach.Text = "---";
            lblNgayMuon.Text = "---";
            lblHanTra.Text = "---";
            lblSoTienPhat.Text = "0 VNĐ";
            cboPhieuMuon.SelectedIndex = -1;
        }

        // Tính toán tiền phạt
        private void CalculateFine()
        {
            if (cboPhieuMuon.SelectedValue == null) return;

            // Lấy hạn trả từ Tag (đã lưu lúc chọn combobox) hoặc query lại
            // Ở đây ta query lại cho an toàn dữ liệu
            int idPhieu = (int)cboPhieuMuon.SelectedValue;
            using (var db = new QLTVDataContext())
            {
                var pm = db.PhieuMuons.Find(idPhieu);
                if (pm != null)
                {
                    DateTime ngayTra = dtpNgayTra.Value.Date;
                    DateTime hanTra = pm.HanTra_PhieuMuon.Date;

                    // Nếu ngày trả > hạn trả -> Tính phạt
                    if (ngayTra > hanTra)
                    {
                        int daysLate = (ngayTra - hanTra).Days;
                        decimal fine = daysLate * FINE_PER_DAY;

                        lblSoTienPhat.Text = $"{fine:N0} VNĐ ({daysLate} ngày trễ)";
                        lblSoTienPhat.ForeColor = Color.Red;
                        lblSoTienPhat.Tag = fine; // Lưu giá trị số để dùng khi Save
                    }
                    else
                    {
                        lblSoTienPhat.Text = "0 VNĐ (Đúng hạn)";
                        lblSoTienPhat.ForeColor = Color.Green;
                        lblSoTienPhat.Tag = 0m;
                    }
                }
            }
        }

        // Sự kiện chọn phiếu mượn
        private void cboPhieuMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhieuMuon.SelectedValue == null) return;

            int idPhieu;
            if (!int.TryParse(cboPhieuMuon.SelectedValue.ToString(), out idPhieu)) return;

            using (var db = new QLTVDataContext())
            {
                var pm = db.PhieuMuons
                    .Include(p => p.SACHDATA)
                    .Include(p => p.DOCGIADATA.NGUOIDUNGDATA)
                    .FirstOrDefault(p => p.IDPhieuMuon == idPhieu);

                if (pm != null)
                {
                    lblTenDocGia.Text = pm.DOCGIADATA.NGUOIDUNGDATA.HoTen_NguoiDung;
                    lblTenSach.Text = pm.SACHDATA.Name_Sach;
                    lblNgayMuon.Text = pm.NgayMuon_Sach.ToString("dd/MM/yyyy");
                    lblHanTra.Text = pm.HanTra_PhieuMuon.ToString("dd/MM/yyyy");

                    CalculateFine(); // Tính tiền ngay khi chọn
                }
            }
        }

        // Sự kiện thay đổi ngày trả -> Tính lại tiền phạt
        private void dtpNgayTra_ValueChanged(object sender, EventArgs e)
        {
            CalculateFine();
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (cboPhieuMuon.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn!", "Cảnh báo");
                return;
            }

            int idPhieu = (int)cboPhieuMuon.SelectedValue;
            decimal tienPhat = Convert.ToDecimal(lblSoTienPhat.Tag);

            try
            {
                using (var db = new QLTVDataContext())
                {
                    var pm = db.PhieuMuons.Find(idPhieu);
                    if (pm == null) return;

                    // 1. Cập nhật Phiếu Mượn
                    pm.NgayTra_PhieuMuon = dtpNgayTra.Value;
                    pm.TrangThai_PhieuMuon = "Đã trả";
                    pm.SoTienPhat_PhieuMuon = tienPhat;

                    // 2. Tạo Phiếu Phạt (Nếu có tiền phạt)
                    if (tienPhat > 0)
                    {
                        Phat phat = new Phat()
                        {
                            IDPhieuMuon_Phat = pm.IDPhieuMuon,
                            SoTien_Phat = tienPhat,
                            LyDo_Phat = "Quá hạn trả sách",
                            NgayPhat = DateTime.Now,
                            DaThanhToan = true // Giả sử thu tiền luôn tại quầy
                        };
                        db.Phats.Add(phat);
                    }

                    // 3. Cập nhật Kho Sách (QUAN TRỌNG: Cộng lại số lượng)
                    var sach = db.Sachs.Find(pm.IDSach_PhieuMuon);
                    if (sach != null)
                    {
                        sach.SoLuong_Sach += 1; // Trả lại sách vào kho
                        if (sach.TrangThai_Sach == "Hết hàng") sach.TrangThai_Sach = "Còn sách";
                    }

                    db.SaveChanges();
                    MessageBox.Show("Trả sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}