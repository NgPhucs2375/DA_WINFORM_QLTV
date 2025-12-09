using QLTV.Database;
using QLTV.Database.Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity; // Cần dòng này để dùng .Include()

namespace QLTV
{
    public partial class FormDuyet : Form
    {
        private int _nhanVienID; // ID của Nhân viên đang đăng nhập

        public FormDuyet()
        {
            InitializeComponent();
            GetNhanVienID();
        }

        // Lấy ID Nhân viên từ UserID đăng nhập
        private void GetNhanVienID()
        {
            int currentUserID = Program.CurrentUserId;
            using (var db = new QLTVDataContext())
            {
                var nv = db.NhanViens.FirstOrDefault(n => n.IDNguoiDung_NhanVien == currentUserID);
                if (nv != null)
                {
                    _nhanVienID = nv.IDNhanVien;
                }
                else
                {
                    // Nếu admin đăng nhập mà chưa có record trong bảng NHANVIEN, có thể để null hoặc xử lý riêng
                    // Ở đây tạm gán là 1 để test nếu cần
                    _nhanVienID = 1;
                }
            }
        }

        private void FormDuyet_Load(object sender, EventArgs e)
        {
            LoadDanhSachYeuCau();
        }

        private void LoadDanhSachYeuCau()
        {
            using (var db = new QLTVDataContext())
            {
                var list = db.YeuCauMuons
                    .Include(y => y.DOCGIADATA.NGUOIDUNGDATA)
                    .Include(y => y.SACHDATA)
                    .Where(y => y.TrangThai_YCM == "Chờ duyệt")
                    .Select(y => new
                    {
                        MaYC = y.IDYeuCau,
                        DocGia = y.DOCGIADATA.NGUOIDUNGDATA.HoTen_NguoiDung,
                        TenSach = y.SACHDATA.Name_Sach,
                        NgayYC = y.Ngayyeucau_YCM,
                        TrangThai = y.TrangThai_YCM
                    })
                    .ToList();

                dgvYeuCau.DataSource = list;

                // Đổi tên cột cho đẹp
                if (dgvYeuCau.Columns["MaYC"] != null) dgvYeuCau.Columns["MaYC"].HeaderText = "Mã YC";
                if (dgvYeuCau.Columns["DocGia"] != null) dgvYeuCau.Columns["DocGia"].HeaderText = "Tên Độc Giả";
                if (dgvYeuCau.Columns["TenSach"] != null) dgvYeuCau.Columns["TenSach"].HeaderText = "Sách Yêu Cầu";
                if (dgvYeuCau.Columns["NgayYC"] != null) dgvYeuCau.Columns["NgayYC"].HeaderText = "Ngày Gửi";
            }
        }

        // --- XỬ LÝ DUYỆT ---
        private void btnDuyet_Click(object sender, EventArgs e)
        {
            if (dgvYeuCau.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn yêu cầu cần duyệt!", "Thông báo");
                return;
            }

            // Lấy ID Yêu cầu
            int idYC = Convert.ToInt32(dgvYeuCau.CurrentRow.Cells["MaYC"].Value);

            try
            {
                using (var db = new QLTVDataContext())
                {
                    // 1. Lấy thông tin yêu cầu
                    var yc = db.YeuCauMuons.Find(idYC);
                    if (yc == null) return;

                    // 2. Kiểm tra sách còn trong kho không (Check lần cuối cho chắc)
                    var sach = db.Sachs.Find(yc.IDSACH_YCM);
                    if (sach.SoLuong_Sach <= 0)
                    {
                        MessageBox.Show($"Sách '{sach.Name_Sach}' vừa hết hàng. Không thể duyệt!", "Lỗi kho");
                        return;
                    }

                    // 3. TẠO PHIẾU MƯỢN CHÍNH THỨC
                    PhieuMuon pm = new PhieuMuon()
                    {
                        IDDocGia_PhieuMuon = yc.IDDocGia_YCM,
                        IDSach_PhieuMuon = yc.IDSACH_YCM,
                        IDNhanVien = _nhanVienID, // Nhân viên đang đăng nhập duyệt
                        NgayMuon_Sach = DateTime.Now,
                        HanTra_PhieuMuon = DateTime.Now.AddDays(7), // Mặc định 7 ngày
                        TrangThai_PhieuMuon = "Đang mượn",
                        TienMuon = 5000 * 7, // Tính sơ bộ (hoặc lấy từ tham số)
                        TongTien = 5000 * 7
                    };
                    db.PhieuMuons.Add(pm);

                    // 4. TRỪ KHO SÁCH
                    sach.SoLuong_Sach -= 1;
                    if (sach.SoLuong_Sach == 0) sach.TrangThai_Sach = "Hết hàng";

                    // 5. CẬP NHẬT TRẠNG THÁI YÊU CẦU
                    yc.TrangThai_YCM = "Đã duyệt";

                    db.SaveChanges();

                    MessageBox.Show("Duyệt thành công! Đã tạo phiếu mượn.", "Thành công");
                    LoadDanhSachYeuCau(); // Refresh lại lưới
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // --- XỬ LÝ TỪ CHỐI ---
        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            if (dgvYeuCau.SelectedRows.Count == 0) return;

            if (MessageBox.Show("Bạn chắc chắn muốn từ chối yêu cầu này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int idYC = Convert.ToInt32(dgvYeuCau.CurrentRow.Cells["MaYC"].Value);

            using (var db = new QLTVDataContext())
            {
                var yc = db.YeuCauMuons.Find(idYC);
                if (yc != null)
                {
                    yc.TrangThai_YCM = "Từ chối"; // Hoặc có thể xóa luôn: db.YeuCauMuons.Remove(yc);
                    db.SaveChanges();
                    MessageBox.Show("Đã từ chối yêu cầu.");
                    LoadDanhSachYeuCau();
                }
            }
        }
    }
}