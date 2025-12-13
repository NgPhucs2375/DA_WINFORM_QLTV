using QLTV.Database;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QLTV
{
    public partial class FormChiTietSach : Form
    {
        private int _bookId;

        public FormChiTietSach(int bookId)
        {
            InitializeComponent();
            _bookId = bookId;
        }

        private void FormChiTietSach_Load(object sender, EventArgs e)
        {
            LoadBookDetails();
            LoadReviews();
        }

        private void LoadBookDetails()
        {
            try
            {
                using (var db = new QLTVDataContext())
                {
                    var book = db.Sachs.Find(_bookId);
                    if (book != null)
                    {
                        lblTenSach.Text = book.Name_Sach;
                        lblTacGia.Text = "Tác giả: " + book.TacGia_Sach;
                        lblNXB.Text = $"Nhà xuất bản: {book.NhaXuatBan_Sach} (Năm: {book.NamXuatBan_Sach})";
                        lblTheLoai.Text = "Thể loại: " + book.TheLoai_Sach;
                        txtMoTa.Text = book.MoTa ?? "Chưa có mô tả cho sách này.";

                        // Hiển thị hình ảnh
                        if (!string.IsNullOrEmpty(book.AnhBia_Sach))
                        {
                            string path = Path.Combine(Application.StartupPath, "Images", book.AnhBia_Sach);
                            if (File.Exists(path))
                            {
                                picAnhBia.Image = Image.FromFile(path);
                            }
                            else
                            {
                                // Nếu không tìm thấy ảnh, set null hoặc ảnh mặc định
                                picAnhBia.Image = null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin sách: " + ex.Message);
            }
        }

        private void LoadReviews()
        {
            // Load dữ liệu đánh giá từ DB
            // Nếu bạn đã tạo bảng DANHGIA nhưng chưa cập nhật Entity Framework, 
            // đoạn code này có thể gây lỗi biên dịch. 
            // Để an toàn, tôi sẽ dùng SQL thuần hoặc giả định cấu trúc để hiển thị demo.

            try
            {
                using (var db = new QLTVDataContext())
                {
                    // Cách 1: Nếu đã có Entity DanhGia
                    /*
                    var reviews = db.DanhGias
                        .Where(d => d.MASACH == _bookId)
                        .Select(d => new {
                            NguoiDung = d.DOCGIADATA.NGUOIDUNGDATA.HoTen_NguoiDung,
                            Diem = d.DIEM,
                            BinhLuan = d.BINHLUAN,
                            Ngay = d.NGAYDANHGIA
                        }).ToList();
                    dgvDanhGia.DataSource = reviews;
                    */

                    // Cách 2: Dùng SQL Query trực tiếp (An toàn hơn nếu chưa update Model)
                    string query = $"SELECT HOTEN, DIEM, BINHLUAN, NGAYDANHGIA FROM DANHGIA D JOIN DOCGIA DG ON D.MADOCGIA = DG.MADOCGIA JOIN NGUOIDUNG N ON DG.MANGUOIDUNG = N.MANGUOIDUNG WHERE MASACH = {_bookId}";
                    var reviews = db.Database.SqlQuery<ReviewDTO>(query).ToList();

                    dgvDanhGia.DataSource = reviews;

                    // Tính điểm trung bình
                    if (reviews.Count > 0)
                    {
                        double avg = reviews.Average(r => r.Diem);
                        lblRating.Text = $"★ {avg:0.0}/5 ({reviews.Count} đánh giá)";
                    }
                    else
                    {
                        lblRating.Text = "Chưa có đánh giá";
                    }
                }
            }
            catch
            {
                // Silent fail nếu chưa có bảng
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // Class DTO tạm để hứng dữ liệu review
    public class ReviewDTO
    {
        public string HoTen { get; set; }
        public int Diem { get; set; }
        public string BinhLuan { get; set; }
        public DateTime NgayDanhGia { get; set; }
    }
}