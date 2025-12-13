using QLTV.Database;
using QLTV.Database.Entities;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLTV
{
    public partial class QuanLySach : Form
    {
        string selectedImagePath = ""; // Biến lưu đường dẫn ảnh tạm thời

        public QuanLySach()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized; // Mở rộng toàn màn hình

            // Cấu hình ComboBox Trạng thái
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.AddRange(new string[] { "Có sẵn", "Hết hàng", "Ngưng hoạt động" });
            cboTrangThai.SelectedIndex = 0;

            // Cấu hình DataGridView đẹp hơn
            dgwhowList.BorderStyle = BorderStyle.None;
            dgwhowList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgwhowList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgwhowList.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgwhowList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgwhowList.BackgroundColor = Color.White;
            dgwhowList.EnableHeadersVisualStyles = false;
            dgwhowList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgwhowList.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
            dgwhowList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgwhowList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgwhowList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwhowList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwhowList.RowTemplate.Height = 35;
        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (var db = new QLTVDataContext())
                {
                    // 1. Load danh sách sách
                    var list = db.Sachs.Select(s => new {
                        ID = s.IDSach,
                        TenSach = s.Name_Sach,
                        TacGia = s.TacGia_Sach,
                        TheLoai = s.TheLoai_Sach,
                        NXB = s.NhaXuatBan_Sach,
                        NamXB = s.NamXuatBan_Sach,
                        SoLuong = s.SoLuong_Sach,
                        ViTri = s.ViTriSach,
                        TrangThai = s.TrangThai_Sach
                    }).ToList();

                    dgwhowList.DataSource = list;

                    // Định dạng cột (nếu cần)
                    if (dgwhowList.Columns["ID"] != null) dgwhowList.Columns["ID"].Width = 50;

                    // 2. Load Filters (Chỉ load 1 lần để tránh lag)
                    if (cboChuDe.Items.Count <= 1)
                    {
                        cboChuDe.Items.Clear();
                        cboChuDe.Items.Add("Tất cả");
                        cboChuDe.Items.AddRange(db.Sachs.Select(s => s.TheLoai_Sach).Distinct().ToArray());
                        cboChuDe.SelectedIndex = 0;
                    }

                    if (cboTacGia.Items.Count <= 1)
                    {
                        cboTacGia.Items.Clear();
                        cboTacGia.Items.Add("Tất cả");
                        cboTacGia.Items.AddRange(db.Sachs.Select(s => s.TacGia_Sach).Distinct().ToArray());
                        cboTacGia.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // ================== CÁC SỰ KIỆN NÚT BẤM ==================

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                using (var db = new QLTVDataContext())
                {
                    // Logic: Luôn thêm mới khi bấm nút THÊM
                    // Nếu muốn cập nhật số lượng sách cũ, hãy dùng chức năng Sửa hoặc tạo nút Nhập Kho riêng

                    Sach s = new Sach()
                    {
                        Name_Sach = txtNameSach.Text.Trim(),
                        TacGia_Sach = txtTacGia.Text.Trim(),
                        TheLoai_Sach = txtChuDe.Text.Trim(),
                        NhaXuatBan_Sach = txtNXB.Text.Trim(),
                        NamXuatBan_Sach = int.Parse(txtNamXB.Text),
                        SoLuong_Sach = int.Parse(txtSoLuong.Text),
                        TrangThai_Sach = cboTrangThai.Text,
                        ViTriSach = txtViTri.Text.Trim(), // Lấy từ textbox thay vì cứng "Kệ A1"
                        MaQR = txtISBN.Text.Trim(),       // Lưu ISBN vào MaQR

                        // Xử lý ảnh
                        AnhBia_Sach = !string.IsNullOrEmpty(selectedImagePath) ? SaveImage(selectedImagePath, DateTime.Now.Ticks.ToString()) : null
                    };

                    db.Sachs.Add(s);
                    db.SaveChanges();
                    MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDSach.Text))
            {
                MessageBox.Show("Vui lòng chọn sách cần sửa từ danh sách!", "Thông báo");
                return;
            }
            if (!ValidateInput()) return;

            try
            {
                using (var db = new QLTVDataContext())
                {
                    int id = int.Parse(txtIDSach.Text);
                    var s = db.Sachs.FirstOrDefault(x => x.IDSach == id);
                    if (s != null)
                    {
                        s.Name_Sach = txtNameSach.Text.Trim();
                        s.TacGia_Sach = txtTacGia.Text.Trim();
                        s.TheLoai_Sach = txtChuDe.Text.Trim();
                        s.NhaXuatBan_Sach = txtNXB.Text.Trim();
                        s.NamXuatBan_Sach = int.Parse(txtNamXB.Text);
                        s.SoLuong_Sach = int.Parse(txtSoLuong.Text);
                        s.TrangThai_Sach = cboTrangThai.Text;
                        s.ViTriSach = txtViTri.Text.Trim();
                        s.MaQR = txtISBN.Text.Trim();

                        // Chỉ cập nhật ảnh nếu người dùng chọn ảnh mới
                        if (!string.IsNullOrEmpty(selectedImagePath))
                        {
                            s.AnhBia_Sach = SaveImage(selectedImagePath, s.IDSach.ToString());
                        }

                        db.SaveChanges();
                        MessageBox.Show("Cập nhật thành công!", "Thông báo");
                        LoadData();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi khi sửa: " + ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDSach.Text)) return;
            if (MessageBox.Show("Xóa sách này sẽ mất dữ liệu vĩnh viễn.\nBạn có chắc chắn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            try
            {
                using (var db = new QLTVDataContext())
                {
                    int id = int.Parse(txtIDSach.Text);
                    var s = db.Sachs.FirstOrDefault(x => x.IDSach == id);
                    if (s != null)
                    {
                        // Kiểm tra ràng buộc
                        if (db.PhieuMuons.Any(p => p.IDSach_PhieuMuon == id))
                        {
                            MessageBox.Show("Sách đang được mượn hoặc có trong lịch sử, không thể xóa!\nHãy chuyển trạng thái sang 'Ngưng hoạt động'.", "Cảnh báo");
                            return;
                        }

                        db.Sachs.Remove(s);
                        db.SaveChanges();
                        MessageBox.Show("Đã xóa sách!", "Thông báo");
                        LoadData();
                        ClearForm();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi khi xóa: " + ex.Message); }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // ================== HÀM PHỤ TRỢ (HELPER) ==================

        private void ClearForm()
        {
            txtIDSach.Clear();
            txtNameSach.Clear();
            txtTacGia.Clear();
            txtChuDe.Clear();
            txtNXB.Clear();
            txtNamXB.Clear();
            txtSoLuong.Clear();
            txtISBN.Clear();
            txtViTri.Clear();
            cboTrangThai.SelectedIndex = 0;

            // Xóa ảnh và đường dẫn tạm
            if (picAnhBia.Image != null) picAnhBia.Image.Dispose();
            picAnhBia.Image = null;
            selectedImagePath = "";
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtNameSach.Text)) { MessageBox.Show("Vui lòng nhập tên sách."); txtNameSach.Focus(); return false; }
            if (!int.TryParse(txtSoLuong.Text, out _)) { MessageBox.Show("Số lượng phải là số nguyên."); txtSoLuong.Focus(); return false; }
            if (!int.TryParse(txtNamXB.Text, out _)) { MessageBox.Show("Năm xuất bản phải là số."); txtNamXB.Focus(); return false; }
            return true;
        }

        // --- SỬA LỖI UPLOAD ẢNH (Dùng FileStream tránh lỗi OutOfMemory) ---
        private void btnUploadAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            // Chỉ cho phép chọn các đuôi file chuẩn
            op.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Kiểm tra dung lượng file trước
                    var fileInfo = new FileInfo(op.FileName);
                    if (fileInfo.Length == 0)
                    {
                        MessageBox.Show("File ảnh này bị rỗng (0 bytes). Vui lòng tải lại.", "Lỗi File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Thử đọc Header của file để xem có phải WebP không
                    byte[] header = new byte[4];
                    using (FileStream fs = new FileStream(op.FileName, FileMode.Open, FileAccess.Read))
                    {
                        fs.Read(header, 0, 4);
                    }
                    // Header của WebP thường bắt đầu bằng RIFF (52 49 46 46)
                    if (header[0] == 0x52 && header[1] == 0x49 && header[2] == 0x46 && header[3] == 0x46)
                    {
                        MessageBox.Show("Đây là file WebP (dù đuôi là .jpg). WinForms không hỗ trợ định dạng này.\n\nHãy mở bằng Paint và Save As lại thành JPG chuẩn.", "Sai định dạng ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Nếu ổn thì load ảnh
                    using (var stream = new FileStream(op.FileName, FileMode.Open, FileAccess.Read))
                    {
                        picAnhBia.Image = Image.FromStream(stream);
                        selectedImagePath = op.FileName;
                    }
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("File ảnh bị hỏng hoặc định dạng không được hỗ trợ (Ví dụ: WebP, AVIF).\nHãy thử chụp màn hình hoặc dùng Paint lưu lại.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi không xác định: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string SaveImage(string sourcePath, string fileNamePre)
        {
            try
            {
                string folder = Path.Combine(Application.StartupPath, "Images");
                if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);

                string ext = Path.GetExtension(sourcePath);
                string fileName = fileNamePre + ext; // Tạo tên file mới để tránh trùng
                string dest = Path.Combine(folder, fileName);

                File.Copy(sourcePath, dest, true);
                return fileName; // Trả về tên file để lưu vào DB
            }
            catch { return null; }
        }

        // ================== CÁC CHỨC NĂNG NÂNG CAO ==================

        // 1. Grid Click & Hiển thị ảnh
        private void dgwhowList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgwhowList.Rows[e.RowIndex];
                txtIDSach.Text = row.Cells["ID"].Value.ToString();
                txtNameSach.Text = row.Cells["TenSach"].Value.ToString();
                txtTacGia.Text = row.Cells["TacGia"].Value?.ToString();
                txtChuDe.Text = row.Cells["TheLoai"].Value?.ToString();
                txtNXB.Text = row.Cells["NXB"].Value?.ToString();
                txtNamXB.Text = row.Cells["NamXB"].Value?.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtViTri.Text = row.Cells["ViTri"].Value?.ToString();

                string status = row.Cells["TrangThai"].Value?.ToString();
                if (cboTrangThai.Items.Contains(status)) cboTrangThai.SelectedItem = status;

                // Load Ảnh và ISBN từ DB
                using (var db = new QLTVDataContext())
                {
                    int id = int.Parse(txtIDSach.Text);
                    var s = db.Sachs.Find(id);
                    if (s != null)
                    {
                        txtISBN.Text = s.MaQR; // Hiển thị ISBN

                        if (!string.IsNullOrEmpty(s.AnhBia_Sach))
                        {
                            string folder = Path.Combine(Application.StartupPath, "Images");
                            string path = Path.Combine(folder, s.AnhBia_Sach);
                            if (File.Exists(path))
                            {
                                // Dùng FileStream để load ảnh xem trước mà không khóa file
                                using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                                {
                                    if (picAnhBia.Image != null) picAnhBia.Image.Dispose();
                                    picAnhBia.Image = Image.FromStream(stream);
                                }
                            }
                            else picAnhBia.Image = null;
                        }
                        else picAnhBia.Image = null;
                    }
                }
            }
            catch { /* Bỏ qua lỗi nhỏ khi load ảnh */ }
        }

        private void dgwhowList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dgwhowList.Rows[e.RowIndex].Cells["ID"].Value);
                FormChiTietSach f = new FormChiTietSach(id);
                f.ShowDialog();
            }
        }

        // 2. Tìm kiếm & Lọc
        private void FilterData()
        {
            using (var db = new QLTVDataContext())
            {
                string key = txtSearch.Text.ToLower();
                string chuDe = cboChuDe.SelectedItem?.ToString();
                string tacGia = cboTacGia.SelectedItem?.ToString();

                var query = db.Sachs.AsQueryable();

                if (!string.IsNullOrEmpty(key))
                {
                    query = query.Where(s => s.Name_Sach.ToLower().Contains(key) || s.IDSach.ToString().Contains(key));
                }
                if (!string.IsNullOrEmpty(chuDe) && chuDe != "Tất cả")
                {
                    query = query.Where(s => s.TheLoai_Sach == chuDe);
                }
                if (!string.IsNullOrEmpty(tacGia) && tacGia != "Tất cả")
                {
                    query = query.Where(s => s.TacGia_Sach == tacGia);
                }

                dgwhowList.DataSource = query.Select(s => new {
                    ID = s.IDSach,
                    TenSach = s.Name_Sach,
                    TacGia = s.TacGia_Sach,
                    TheLoai = s.TheLoai_Sach,
                    NXB = s.NhaXuatBan_Sach,
                    NamXB = s.NamXuatBan_Sach,
                    SoLuong = s.SoLuong_Sach,
                    ViTri = s.ViTriSach,
                    TrangThai = s.TrangThai_Sach
                }).ToList();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => FilterData();
        private void cboChuDe_SelectedIndexChanged(object sender, EventArgs e) => FilterData();
        private void cboTacGia_SelectedIndexChanged(object sender, EventArgs e) => FilterData();

        private void btnRsFilter_Click_1(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cboChuDe.SelectedIndex = 0;
            cboTacGia.SelectedIndex = 0;
            LoadData();
        }

        // 3. Scan QR (Nhập liệu nhanh)
        private void txtScanQR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string code = txtScanQR.Text.Trim();
                if (string.IsNullOrEmpty(code)) return;

                using (var db = new QLTVDataContext())
                {
                    var book = db.Sachs.ToList().FirstOrDefault(s => s.IDSach.ToString() == code || (s.MaQR != null && s.MaQR == code));
                    if (book != null)
                    {
                        // Tìm thấy sách -> Highlight và điền thông tin
                        foreach (DataGridViewRow row in dgwhowList.Rows)
                        {
                            if (row.Cells["ID"].Value.ToString() == book.IDSach.ToString())
                            {
                                row.Selected = true;
                                dgwhowList.FirstDisplayedScrollingRowIndex = row.Index;
                                dgwhowList_CellClick(null, new DataGridViewCellEventArgs(0, row.Index));
                                break;
                            }
                        }
                    }
                    else
                    {
                        // Không thấy -> Hỏi lấy từ Web
                        if (MessageBox.Show($"Sách mã '{code}' chưa có trong kho. Bạn có muốn lấy thông tin từ Google Books?", "Scan", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            txtISBN.Text = code; // Điền vào ô ISBN
                            btnGetInfo.PerformClick(); // Tự động bấm nút lấy tin
                        }
                    }
                }
                txtScanQR.SelectAll(); // Bôi đen để sẵn sàng scan tiếp
            }
        }

        // 4. Google Books API
        private async void btnGetInfo_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text.Replace("-", "").Trim();
            if (string.IsNullOrEmpty(isbn)) { MessageBox.Show("Vui lòng nhập ISBN!"); return; }

            btnGetInfo.Text = "⏳";
            btnGetInfo.Enabled = false;

            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; // Fix lỗi SSL
                using (HttpClient client = new HttpClient())
                {
                    // Thêm User-Agent giả lập trình duyệt
                    client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)");

                    string url = $"https://www.googleapis.com/books/v1/volumes?q=isbn:{isbn}";
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        JObject data = JObject.Parse(json);
                        if (data["totalItems"] != null && data["totalItems"].Value<int>() > 0)
                        {
                            var info = data["items"][0]["volumeInfo"];
                            txtNameSach.Text = info["title"]?.ToString();
                            txtNXB.Text = info["publisher"]?.ToString();

                            if (info["authors"] != null)
                                txtTacGia.Text = string.Join(", ", info["authors"].Select(a => a.ToString()));

                            string date = info["publishedDate"]?.ToString();
                            if (!string.IsNullOrEmpty(date) && date.Length >= 4)
                                txtNamXB.Text = date.Substring(0, 4);

                            // Lấy ảnh thumbnail nếu có (Nâng cao)
                            // if (info["imageLinks"] != null) { ... }

                            MessageBox.Show("Đã tìm thấy thông tin!", "Thành công");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sách này trên Google Books.", "Thông báo");
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi kết nối API: " + ex.Message); }
            finally { btnGetInfo.Text = "🌐 Web"; btnGetInfo.Enabled = true; }
        }

        // 5. Import Excel
        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "Excel Files|*.xls;*.xlsx" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Excel.Application xlApp = new Excel.Application();
                    Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(openFileDialog.FileName);
                    Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                    Excel.Range xlRange = xlWorksheet.UsedRange;

                    int rowCount = xlRange.Rows.Count;
                    int count = 0;

                    using (var db = new QLTVDataContext())
                    {
                        // Bắt đầu từ dòng 2 (bỏ qua Header)
                        for (int i = 2; i <= rowCount; i++)
                        {
                            if (xlRange.Cells[i, 1].Value2 == null) continue;

                            Sach s = new Sach();
                            s.Name_Sach = xlRange.Cells[i, 1].Value2.ToString();
                            s.TacGia_Sach = xlRange.Cells[i, 2].Value2?.ToString() ?? "Unknown";
                            s.TheLoai_Sach = xlRange.Cells[i, 3].Value2?.ToString() ?? "General";
                            s.NhaXuatBan_Sach = "Unknown";
                            s.NamXuatBan_Sach = DateTime.Now.Year;
                            s.SoLuong_Sach = 1;
                            s.TrangThai_Sach = "Có sẵn";
                            s.ViTriSach = "Kho";

                            db.Sachs.Add(s);
                            count++;
                        }
                        db.SaveChanges();
                    }

                    // Giải phóng Excel
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkbook);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);

                    MessageBox.Show($"Đã nhập {count} sách!", "Thành công");
                    LoadData();
                }
                catch (Exception ex) { MessageBox.Show("Lỗi Import: " + ex.Message); }
            }
        }

        // Các event thừa
        private void btnSearch_Click(object sender, EventArgs e) { }
        private void btnHTDanhSach_Click(object sender, EventArgs e) => LoadData();
    }
}