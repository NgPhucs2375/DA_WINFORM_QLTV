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
using Newtonsoft.Json.Linq; // Cần cài NuGet Newtonsoft.Json
using Excel = Microsoft.Office.Interop.Excel; // Cần Add Reference Microsoft.Office.Interop.Excel

namespace QLTV
{
    public partial class QuanLySach : Form
    {
        string selectedImagePath = ""; // Biến lưu đường dẫn ảnh

        public QuanLySach()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            // Style DataGridView
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

            // Init ComboBox Trạng thái
            cboTrangThai.Items.AddRange(new string[] { "Có sẵn", "Hết hàng", "Ngưng hoạt động" });
            cboTrangThai.SelectedIndex = 0;
        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (var db = new QLTVDataContext())
            {
                dgwhowList.DataSource = db.Sachs.Select(s => new {
                    ID = s.IDSach,
                    TenSach = s.Name_Sach,
                    TacGia = s.TacGia_Sach,
                    TheLoai = s.TheLoai_Sach,
                    NXB = s.NhaXuatBan_Sach,
                    NamXB = s.NamXuatBan_Sach,
                    SoLuong = s.SoLuong_Sach,
                    TrangThai = s.TrangThai_Sach
                }).ToList();
            }
        }

        private void dgwhowList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgwhowList.Rows[e.RowIndex];
            txtIDSach.Text = row.Cells["ID"].Value.ToString();
            txtNameSach.Text = row.Cells["TenSach"].Value.ToString();
            txtTacGia.Text = row.Cells["TacGia"].Value.ToString();
            txtChuDe.Text = row.Cells["TheLoai"].Value.ToString();
            txtNXB.Text = row.Cells["NXB"].Value.ToString();
            txtNamXB.Text = row.Cells["NamXB"].Value.ToString();
            txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();

            string status = row.Cells["TrangThai"].Value.ToString();
            if (cboTrangThai.Items.Contains(status)) cboTrangThai.SelectedItem = status;

            // Load ảnh nếu có
            using (var db = new QLTVDataContext())
            {
                int id = int.Parse(txtIDSach.Text);
                var s = db.Sachs.Find(id);
                if (s != null && !string.IsNullOrEmpty(s.AnhBia_Sach))
                {
                    string folder = Path.Combine(Application.StartupPath, "Images");
                    string path = Path.Combine(folder, s.AnhBia_Sach);
                    if (File.Exists(path))
                    {
                        picAnhBia.Image = Image.FromFile(path);
                    }
                    else picAnhBia.Image = null;
                }
                else picAnhBia.Image = null;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string key = txtSearch.Text.ToLower();
            using (var db = new QLTVDataContext())
            {
                var list = db.Sachs.Where(s =>
                    s.Name_Sach.ToLower().Contains(key) ||
                    s.TacGia_Sach.ToLower().Contains(key) ||
                    s.TheLoai_Sach.ToLower().Contains(key) ||
                    s.IDSach.ToString().Contains(key)
                ).Select(s => new {
                    ID = s.IDSach,
                    TenSach = s.Name_Sach,
                    TacGia = s.TacGia_Sach,
                    TheLoai = s.TheLoai_Sach,
                    NXB = s.NhaXuatBan_Sach,
                    NamXB = s.NamXuatBan_Sach,
                    SoLuong = s.SoLuong_Sach,
                    TrangThai = s.TrangThai_Sach
                }).ToList();

                dgwhowList.DataSource = list;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                using (var db = new QLTVDataContext())
                {
                    Sach s = new Sach()
                    {
                        Name_Sach = txtNameSach.Text.Trim(),
                        TacGia_Sach = txtTacGia.Text.Trim(),
                        TheLoai_Sach = txtChuDe.Text.Trim(),
                        NhaXuatBan_Sach = txtNXB.Text.Trim(),
                        NamXuatBan_Sach = int.Parse(txtNamXB.Text),
                        SoLuong_Sach = int.Parse(txtSoLuong.Text),
                        TrangThai_Sach = cboTrangThai.Text,
                        ViTriSach = "Kệ A1",
                        // Lưu tên file ảnh (nếu có)
                        AnhBia_Sach = !string.IsNullOrEmpty(selectedImagePath) ? SaveImage(selectedImagePath, DateTime.Now.Ticks.ToString()) : null
                    };

                    db.Sachs.Add(s);
                    db.SaveChanges();
                    MessageBox.Show("Thêm sách thành công!");
                    LoadData();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDSach.Text)) return;
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

                        // Cập nhật ảnh nếu có chọn ảnh mới
                        if (!string.IsNullOrEmpty(selectedImagePath))
                        {
                            s.AnhBia_Sach = SaveImage(selectedImagePath, s.IDSach.ToString());
                        }

                        db.SaveChanges();
                        MessageBox.Show("Cập nhật thành công!");
                        LoadData();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDSach.Text)) return;
            if (MessageBox.Show("Bạn có chắc muốn xóa sách này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No) return;

            try
            {
                using (var db = new QLTVDataContext())
                {
                    int id = int.Parse(txtIDSach.Text);
                    var s = db.Sachs.FirstOrDefault(x => x.IDSach == id);
                    if (s != null)
                    {
                        if (db.PhieuMuons.Any(p => p.IDSach_PhieuMuon == id))
                        {
                            MessageBox.Show("Sách này đang có trong phiếu mượn, không thể xóa!", "Cảnh báo");
                            return;
                        }

                        db.Sachs.Remove(s);
                        db.SaveChanges();
                        MessageBox.Show("Đã xóa!");
                        LoadData();
                        ClearForm();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi hệ thống: " + ex.Message); }
        }

        private void btnReset_Click(object sender, EventArgs e) => ClearForm();

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
            cboTrangThai.SelectedIndex = 0;
            picAnhBia.Image = null;
            selectedImagePath = "";
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtNameSach.Text)) { MessageBox.Show("Nhập tên sách!"); return false; }
            if (!int.TryParse(txtSoLuong.Text, out _)) { MessageBox.Show("Số lượng phải là số!"); return false; }
            if (!int.TryParse(txtNamXB.Text, out _)) { MessageBox.Show("Năm XB phải là số!"); return false; }
            return true;
        }

        // --- CÁC CHỨC NĂNG MỚI (SCAN, IMPORT, ẢNH) ---

        // 1. Scan QR Logic
        private void txtScanQR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string code = txtScanQR.Text.Trim();
                if (string.IsNullOrEmpty(code)) return;

                using (var db = new QLTVDataContext())
                {
                    // Tìm sách theo ID hoặc Mã QR (ở đây giả sử check IDSach trước)
                    // Nếu bạn có cột ISBN/MaQR riêng thì sửa lại điều kiện Where
                    var book = db.Sachs.ToList().FirstOrDefault(s => s.IDSach.ToString() == code || (s.MaQR != null && s.MaQR == code));

                    if (book != null)
                    {
                        // Highlight trên lưới
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
                        if (MessageBox.Show("Sách chưa có trong kho. Bạn có muốn lấy thông tin từ Web?", "Scan", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            txtISBN.Text = code;
                            btnGetInfo.PerformClick();
                        }
                    }
                }
                txtScanQR.SelectAll(); // Sẵn sàng scan tiếp
            }
        }

        // 2. Import Excel Logic
        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xls;*.xlsx;*.xlsm",
                Title = "Chọn file Excel danh sách sách"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Excel.Application xlApp = new Excel.Application();
                    Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(openFileDialog.FileName);
                    Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                    Excel.Range xlRange = xlWorksheet.UsedRange;

                    int rowCount = xlRange.Rows.Count;
                    int successCount = 0;

                    using (var db = new QLTVDataContext())
                    {
                        // Bắt đầu từ dòng 2 (giả sử dòng 1 là tiêu đề)
                        for (int i = 2; i <= rowCount; i++)
                        {
                            // Giả sử cột 1: Tên, 2: Tác giả, 3: Thể loại
                            string tenSach = Convert.ToString((xlRange.Cells[i, 1] as Excel.Range).Value2);
                            if (string.IsNullOrEmpty(tenSach)) continue;

                            Sach s = new Sach();
                            s.Name_Sach = tenSach;
                            s.TacGia_Sach = Convert.ToString((xlRange.Cells[i, 2] as Excel.Range).Value2);
                            s.TheLoai_Sach = Convert.ToString((xlRange.Cells[i, 3] as Excel.Range).Value2);
                            s.NhaXuatBan_Sach = "Unknown";
                            s.NamXuatBan_Sach = 2020;
                            s.SoLuong_Sach = 1;
                            s.TrangThai_Sach = "Có sẵn";
                            s.ViTriSach = "Kho";

                            db.Sachs.Add(s);
                            successCount++;
                        }
                        db.SaveChanges();
                    }

                    // Cleanup Excel
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorksheet);
                    xlWorkbook.Close();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkbook);
                    xlApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);

                    MessageBox.Show($"Đã nhập thành công {successCount} cuốn sách!", "Import hoàn tất");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Import: " + ex.Message);
                }
            }
        }

        // 3. Google Books API Logic
        private async void btnGetInfo_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text.Replace("-", "").Trim();
            if (string.IsNullOrEmpty(isbn)) { MessageBox.Show("Nhập ISBN!"); return; }

            btnGetInfo.Text = "...";
            btnGetInfo.Enabled = false;

            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                using (HttpClient client = new HttpClient())
                {
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

                            // Lấy tác giả (mảng)
                            if (info["authors"] != null)
                                txtTacGia.Text = string.Join(", ", info["authors"].Select(a => a.ToString()));

                            string date = info["publishedDate"]?.ToString();
                            if (!string.IsNullOrEmpty(date) && date.Length >= 4)
                                txtNamXB.Text = date.Substring(0, 4);

                            MessageBox.Show("Tìm thấy!");
                        }
                        else MessageBox.Show("Không tìm thấy sách này.");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi API: " + ex.Message); }
            finally { btnGetInfo.Text = "Web"; btnGetInfo.Enabled = true; }
        }

        // 4. Upload Image Logic
        private void btnUploadAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            if (op.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = op.FileName;
                picAnhBia.Image = Image.FromFile(selectedImagePath);
            }
        }

        private string SaveImage(string sourcePath, string fileNamePre)
        {
            try
            {
                string folder = Path.Combine(Application.StartupPath, "Images");
                if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);

                string ext = Path.GetExtension(sourcePath);
                string fileName = fileNamePre + ext;
                string dest = Path.Combine(folder, fileName);

                File.Copy(sourcePath, dest, true);
                return fileName;
            }
            catch { return null; }
        }

        // 5. Open Detail Form (Double Click)
        private void dgwhowList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dgwhowList.Rows[e.RowIndex].Cells["ID"].Value);
                FormChiTietSach f = new FormChiTietSach(id);
                f.ShowDialog();
            }
        }
    }
}