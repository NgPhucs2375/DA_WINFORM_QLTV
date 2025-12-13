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
        public LapPhieuTra()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            dtpNgayTra.Value = DateTime.Now;

            // Cài đặt trạng thái ban đầu cho phần làm mất sách
            if (chkMatSach != null) chkMatSach.Checked = false;
            if (txtTienDenBu != null)
            {
                txtTienDenBu.Enabled = false;
                txtTienDenBu.Text = "0";
            }
        }

        private void LapPhieuTra_Load(object sender, EventArgs e)
        {
            // Fix lỗi binding
            cboPhieuMuon.DisplayMember = "Display";
            cboPhieuMuon.ValueMember = "IDPhieuMuon";
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
                            Display = "PM" + p.IDPhieuMuon + " - " + p.SACHDATA.Name_Sach + " (" + p.DOCGIADATA.NGUOIDUNGDATA.HoTen_NguoiDung + ")"
                        })
                        .ToList();

                    cboPhieuMuon.DataSource = listPhieu;

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
            lblTienMuon.Text = "0 VNĐ";
            lblTongTien.Text = "0 VNĐ";
            cboPhieuMuon.SelectedIndex = -1;
        }

        // Tính tiền mượn
        private decimal CalculateRentalFee()
        {
            if (cboPhieuMuon.SelectedValue == null) return 0m;
            if (!int.TryParse(cboPhieuMuon.SelectedValue.ToString(), out int idPhieu)) return 0m;

            using (var db = new QLTVDataContext())
            {
                var pm = db.PhieuMuons.Find(idPhieu);
                if (pm == null) return 0m;

                DateTime ngayMuon = pm.NgayMuon_Sach.Date;
                DateTime hanTra = pm.HanTra_PhieuMuon.Date;

                int soNgayMuon = (hanTra - ngayMuon).Days;
                if (soNgayMuon < 1) soNgayMuon = 1;

                decimal tienThueMoiNgay = 5000m;
                var configThue = db.ThamSos.Find("SO_TIEN_MUON_MOI_NGAY");
                if (configThue != null) decimal.TryParse(configThue.GiaTri, out tienThueMoiNgay);

                decimal tienMuon = soNgayMuon * tienThueMoiNgay;

                lblTienMuon.Text = $"{tienMuon:N0} VNĐ";
                lblTienMuon.Tag = tienMuon;

                return tienMuon;
            }
        }

        // Tính toán tiền phạt quá hạn
        private void CalculateFine()
        {
            if (cboPhieuMuon.SelectedValue == null) return;
            if (!int.TryParse(cboPhieuMuon.SelectedValue.ToString(), out int idPhieu)) return;

            using (var db = new QLTVDataContext())
            {
                var pm = db.PhieuMuons.Find(idPhieu);
                if (pm != null)
                {
                    DateTime ngayTra = dtpNgayTra.Value.Date;
                    DateTime hanTra = pm.HanTra_PhieuMuon.Date;

                    if (ngayTra > hanTra)
                    {
                        int daysLate = (ngayTra - hanTra).Days;
                        decimal finePerDay = 5000;
                        var config = db.ThamSos.Find("TIEN_PHAT_MOI_NGAY");
                        if (config != null) decimal.TryParse(config.GiaTri, out finePerDay);

                        decimal fine = daysLate * finePerDay;

                        lblSoTienPhat.Text = $"{fine:N0} VNĐ (Trễ {daysLate} ngày)";
                        lblSoTienPhat.ForeColor = Color.Red;
                        lblSoTienPhat.Tag = fine;
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

        // Cập nhật tổng tiền (Thuê + Phạt + Đền bù)
        private void UpdateTotalMoney()
        {
            decimal tienMuon = (lblTienMuon.Tag != null && lblTienMuon.Tag is decimal) ? (decimal)lblTienMuon.Tag : 0m;
            decimal tienPhat = (lblSoTienPhat.Tag != null && lblSoTienPhat.Tag is decimal) ? (decimal)lblSoTienPhat.Tag : 0m;

            decimal tienDenBu = 0;
            if (chkMatSach.Checked)
            {
                decimal.TryParse(txtTienDenBu.Text, out tienDenBu);
            }

            decimal tongTien = tienMuon + tienPhat + tienDenBu;
            lblTongTien.Text = $"{tongTien:N0} VNĐ";
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

                    CalculateRentalFee();
                    CalculateFine();
                    UpdateTotalMoney();
                }
            }
        }

        // Sự kiện thay đổi ngày trả
        private void dtpNgayTra_ValueChanged(object sender, EventArgs e)
        {
            CalculateFine();
            CalculateRentalFee();
            UpdateTotalMoney();
        }

        // Sự kiện Checkbox Mất sách
        private void chkMatSach_CheckedChanged(object sender, EventArgs e)
        {
            txtTienDenBu.Enabled = chkMatSach.Checked;
            if (chkMatSach.Checked)
            {
                txtTienDenBu.Text = "50000"; // Gợi ý giá trị mặc định
                txtTienDenBu.Focus();
            }
            else
            {
                txtTienDenBu.Text = "0";
            }
            UpdateTotalMoney();
        }

        // Sự kiện nhập tiền đền bù
        private void txtTienDenBu_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalMoney();
        }

        // Xử lý nút Trả Sách (Logic chính)
        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (cboPhieuMuon.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn!", "Cảnh báo");
                return;
            }

            int idPhieu = (int)cboPhieuMuon.SelectedValue;

            // Lấy các giá trị tiền
            decimal tienMuon = (lblTienMuon.Tag != null && lblTienMuon.Tag is decimal) ? (decimal)lblTienMuon.Tag : 0m;
            decimal tienPhatQuaHan = (lblSoTienPhat.Tag != null && lblSoTienPhat.Tag is decimal) ? (decimal)lblSoTienPhat.Tag : 0m;

            decimal tienDenBu = 0;
            if (chkMatSach.Checked) decimal.TryParse(txtTienDenBu.Text, out tienDenBu);

            decimal tongTienPhat = tienPhatQuaHan + tienDenBu; // Tổng tiền phạt ghi vào phiếu
            decimal tongThanhToan = tienMuon + tongTienPhat;

            try
            {
                using (var db = new QLTVDataContext())
                {
                    var pm = db.PhieuMuons.Find(idPhieu);
                    if (pm == null) return;

                    // Kiểm tra logic ngày tháng
                    if (dtpNgayTra.Value.Date < pm.NgayMuon_Sach.Date)
                    {
                        MessageBox.Show("Ngày trả không thể trước ngày mượn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 1. Cập nhật Phiếu Mượn
                    pm.NgayTra_PhieuMuon = dtpNgayTra.Value;
                    pm.SoTienPhat_PhieuMuon = tongTienPhat;
                    pm.TienMuon = tienMuon;
                    pm.TongTien = tongThanhToan;

                    // Xác định trạng thái dựa trên việc có mất sách không
                    if (chkMatSach.Checked)
                    {
                        pm.TrangThai_PhieuMuon = "Làm mất";
                    }
                    else
                    {
                        pm.TrangThai_PhieuMuon = "Đã trả";
                    }

                    // 2. Tạo Phiếu Phạt (Nếu có tiền phạt hoặc đền bù)
                    if (tongTienPhat > 0)
                    {
                        string lyDo = "Quá hạn trả sách";
                        if (chkMatSach.Checked) lyDo = "Làm mất sách";
                        if (tienPhatQuaHan > 0 && chkMatSach.Checked) lyDo = "Quá hạn & Làm mất sách";

                        Phat phat = new Phat()
                        {
                            IDPhieuMuon_Phat = pm.IDPhieuMuon,
                            SoTien_Phat = tongTienPhat,
                            LyDo_Phat = lyDo,
                            NgayPhat = DateTime.Now,
                            DaThanhToan = true
                        };
                        db.Phats.Add(phat);
                    }

                    // 3. Cập nhật Kho Sách
                    // QUAN TRỌNG: Chỉ cộng lại số lượng nếu KHÔNG làm mất sách
                    if (!chkMatSach.Checked)
                    {
                        var sach = db.Sachs.Find(pm.IDSach_PhieuMuon);
                        if (sach != null)
                        {
                            sach.SoLuong_Sach += 1;
                            if (sach.TrangThai_Sach == "Hết hàng") sach.TrangThai_Sach = "Còn sách";
                        }
                    }

                    db.SaveChanges();
                    MessageBox.Show("Trả sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTienMuon_Click(object sender, EventArgs e) { }
        private void lblTongTien_Click(object sender, EventArgs e) { }
        private void lblHanTra_Click(object sender, EventArgs e) { }
    }
}