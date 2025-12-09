using QLTV.Database;
using QLTV.Database.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace QLTV
{
    public partial class FormDG : Form
    {
        private int _currentUserId; // ID người dùng đăng nhập
        private int _currentDocGiaId; // ID độc giả (quan trọng)

        public FormDG()
        {
            InitializeComponent();
            // Giả sử lấy ID từ biến toàn cục
            _currentUserId = Program.CurrentUserId;
            SetupUI_Logic();
        }

        private void SetupUI_Logic()
        {
            // 1. Cấu hình TabControl (Ẩn header để làm Dashboard)
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            // 2. Thêm nút "MƯỢN SÁCH" vào GridView bằng Code
            // Kiểm tra tránh thêm trùng nếu hàm này được gọi nhiều lần
            if (dgvSach.Columns["btnMuon"] == null)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "btnMuon";
                btn.HeaderText = "THAO TÁC";
                btn.Text = "MƯỢN SÁCH";
                btn.UseColumnTextForButtonValue = true;
                btn.FlatStyle = FlatStyle.Flat;
                btn.DefaultCellStyle.BackColor = Color.FromArgb(46, 204, 113); // Màu xanh lá
                btn.DefaultCellStyle.ForeColor = Color.White;
                dgvSach.Columns.Add(btn);
            }
            // Gắn lại sự kiện click (xóa cũ thêm mới để tránh trùng lặp)
            dgvSach.CellContentClick -= DgvSach_CellContentClick;
            dgvSach.CellContentClick += DgvSach_CellContentClick;

            // ==============================================================
            // 3. THÊM NÚT "XEM THẺ" TRỰC TIẾP VÀO TAB CÁ NHÂN (CODE MỚI)
            // ==============================================================
            Button btnXemThe = new Button();
            btnXemThe.Text = "XEM THẺ THƯ VIỆN";
            btnXemThe.Size = new Size(200, 50);
            btnXemThe.Location = new Point(40, 220); // Vị trí dưới Label Hạn thẻ
            btnXemThe.BackColor = Color.FromArgb(52, 152, 219); // Màu xanh dương
            btnXemThe.ForeColor = Color.White;
            btnXemThe.FlatStyle = FlatStyle.Flat;
            btnXemThe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXemThe.Cursor = Cursors.Hand;

            // Gắn sự kiện click
            btnXemThe.Click += BtnXemThe_Click;

            // Thêm nút này vào GroupBox thông tin cá nhân
            // Kiểm tra xem đã có nút chưa để tránh thêm chồng chéo
            bool buttonExists = false;
            foreach (Control c in groupBoxInfo.Controls)
            {
                if (c.Text == "XEM THẺ THƯ VIỆN") buttonExists = true;
            }

            if (!buttonExists)
            {
                groupBoxInfo.Controls.Add(btnXemThe);
            }

            // Mặc định chọn tab đầu tiên
            SetActiveButton(btnNavTraCuu);
        }

        private void FormDG_Load(object sender, EventArgs e)
        {
            if (!CheckUserRole()) return;
            LoadSach("");
        }

        // ================== LOGIC 1: XEM THẺ THƯ VIỆN ==================
        private void BtnXemThe_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ giao diện (đã được load từ DB)
            string tenDG = lblXinChao.Text.Replace("Xin chào, ", "");
            string hanThe = lblHanThe.Text.Replace("Hạn thẻ: ", "");
            string maThe = _currentDocGiaId.ToString(); // Dùng ID Độc giả làm mã QR

            // Gọi Form Thẻ (Form này bạn đã tạo ở bước trước)
            // Đảm bảo FormTheDocGia đã được add vào project
            FormTheDocGia f = new FormTheDocGia(tenDG, maThe, hanThe);
            f.ShowDialog();
        }

        // ================== LOGIC 2: KIỂM TRA TÀI KHOẢN ==================
        private bool CheckUserRole()
        {
            using (var db = new QLTVDataContext())
            {
                var user = db.NguoiDungs.Find(_currentUserId);
                if (user == null) return false;

                lblXinChao.Text = "Xin chào, " + user.HoTen_NguoiDung;

                // Tìm ID Độc giả tương ứng
                var dg = db.DocGias.FirstOrDefault(d => d.IDNguoiDung_DocGia == _currentUserId);
                if (dg == null)
                {
                    MessageBox.Show("Lỗi: Tài khoản chưa kích hoạt quyền Độc giả.");
                    this.Close();
                    return false;
                }

                _currentDocGiaId = dg.IDDocGia;

                // Hiển thị thông tin cá nhân lên Tab Cá Nhân
                lblEmail.Text = "Email: " + user.Email_NguoiDung;
                lblPhone.Text = "Số điện thoại: " + user.SDT_NguoiDung;
                lblHanThe.Text = "Hạn thẻ: " + dg.NgayHetHan.ToString("dd/MM/yyyy");

                return true;
            }
        }

        // ================== LOGIC 3: TRA CỨU & MƯỢN SÁCH ==================
        private void LoadSach(string keyword)
        {
            using (var db = new QLTVDataContext())
            {
                var list = db.Sachs
                    .Where(s => s.Name_Sach.Contains(keyword) || s.TacGia_Sach.Contains(keyword))
                    .Select(s => new {
                        ID = s.IDSach,
                        TenSach = s.Name_Sach,
                        TacGia = s.TacGia_Sach,
                        TheLoai = s.TheLoai_Sach,
                        SoLuong = s.SoLuong_Sach,
                        TrangThai = s.SoLuong_Sach > 0 ? "Sẵn sàng" : "Hết hàng"
                    }).ToList();

                dgvSach.DataSource = list;

                // Ẩn cột ID
                if (dgvSach.Columns["ID"] != null) dgvSach.Columns["ID"].Visible = false;

                // Đổi tên tiêu đề cột tiếng Việt cho đẹp
                if (dgvSach.Columns["TenSach"] != null) dgvSach.Columns["TenSach"].HeaderText = "Tên Sách";
                if (dgvSach.Columns["TacGia"] != null) dgvSach.Columns["TacGia"].HeaderText = "Tác Giả";
                if (dgvSach.Columns["TheLoai"] != null) dgvSach.Columns["TheLoai"].HeaderText = "Thể Loại";
                if (dgvSach.Columns["SoLuong"] != null) dgvSach.Columns["SoLuong"].HeaderText = "SL";
                if (dgvSach.Columns["TrangThai"] != null) dgvSach.Columns["TrangThai"].HeaderText = "Trạng Thái";

                // Đẩy nút Mượn ra cuối cùng
                if (dgvSach.Columns["btnMuon"] != null) dgvSach.Columns["btnMuon"].DisplayIndex = dgvSach.Columns.Count - 1;
            }
        }

        private void DgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra click vào nút Mượn (và không phải click vào header)
            if (e.RowIndex >= 0 && dgvSach.Columns[e.ColumnIndex].Name == "btnMuon")
            {
                int idSach = Convert.ToInt32(dgvSach.Rows[e.RowIndex].Cells["ID"].Value);
                string tenSach = dgvSach.Rows[e.RowIndex].Cells["TenSach"].Value.ToString();
                int sl = Convert.ToInt32(dgvSach.Rows[e.RowIndex].Cells["SoLuong"].Value);

                XuLyMuon(idSach, tenSach, sl);
            }
        }

        private void XuLyMuon(int idSach, string tenSach, int sl)
        {
            if (sl <= 0) { MessageBox.Show("Sách tạm hết hàng!"); return; }

            try
            {
                using (var db = new QLTVDataContext())
                {
                    // Check Spam: Đã yêu cầu chưa?
                    bool daYeuCau = db.YeuCauMuons.Any(y =>
                        y.IDDocGia_YCM == _currentDocGiaId &&
                        y.IDSACH_YCM == idSach &&
                        y.TrangThai_YCM == "Chờ duyệt");

                    if (daYeuCau) { MessageBox.Show("Đã yêu cầu rồi! Vui lòng chờ duyệt."); return; }

                    // Insert Yêu cầu
                    db.YeuCauMuons.Add(new YeuCauMuon
                    {
                        IDDocGia_YCM = _currentDocGiaId,
                        IDSACH_YCM = idSach,
                        Ngayyeucau_YCM = DateTime.Now,
                        TrangThai_YCM = "Chờ duyệt"
                    });

                    // Ghi Log hoạt động
                    db.HoatDongLogs.Add(new HoatDongLog
                    {
                        IDNguoiDung_DHG = _currentUserId,
                        HangDong_DHG = "Yêu cầu mượn",
                        DoiTuong = "Sách ID: " + idSach,
                        NoiDung_DHG = "ĐK mượn: " + tenSach,
                        ThoiGian_DHG = DateTime.Now
                    });

                    db.SaveChanges();
                    MessageBox.Show("Đã gửi yêu cầu mượn: " + tenSach);
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // ================== LOGIC 4: LỊCH SỬ ==================
        private void LoadLichSu()
        {
            using (var db = new QLTVDataContext())
            {
                // Lấy danh sách từ bảng YEUCAUMUON
                var listYeuCau = db.YeuCauMuons
                    .Where(y => y.IDDocGia_YCM == _currentDocGiaId)
                    .Select(y => new {
                        Sach = y.SACHDATA.Name_Sach,
                        Ngay = y.Ngayyeucau_YCM,
                        TrangThai = y.TrangThai_YCM
                    })
                    .OrderByDescending(y => y.Ngay)
                    .ToList();

                dgvLichSu.DataSource = listYeuCau;

                // Format cột cho đẹp
                if (dgvLichSu.Columns["Sach"] != null) dgvLichSu.Columns["Sach"].HeaderText = "Tên Sách";
                if (dgvLichSu.Columns["Ngay"] != null) dgvLichSu.Columns["Ngay"].HeaderText = "Ngày Gửi YC";
                if (dgvLichSu.Columns["TrangThai"] != null) dgvLichSu.Columns["TrangThai"].HeaderText = "Trạng Thái";
            }
        }

        // ================== SỰ KIỆN GIAO DIỆN ==================
        private void txtTimKiem_TextChanged(object sender, EventArgs e) => LoadSach(txtTimKiem.Text.Trim());

        private void SetActiveButton(Button btn)
        {
            btnNavTraCuu.BackColor = btnNavLichSu.BackColor = btnNavCaNhan.BackColor = Color.FromArgb(44, 62, 80);
            btn.BackColor = Color.FromArgb(52, 152, 219);
        }

        private void btnNavTraCuu_Click(object sender, EventArgs e) { tabControl1.SelectedTab = tabTraCuu; SetActiveButton(btnNavTraCuu); }
        private void btnNavLichSu_Click(object sender, EventArgs e) { tabControl1.SelectedTab = tabLichSu; SetActiveButton(btnNavLichSu); LoadLichSu(); }
        private void btnNavCaNhan_Click(object sender, EventArgs e) { tabControl1.SelectedTab = tabCaNhan; SetActiveButton(btnNavCaNhan); }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();
        }
    }
}