using QLTV.Database;
using QLTV.Database.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class QuanLyDG : Form
    {
        public QuanLyDG()
        {
            InitializeComponent();
        }

        

        private void QuanLyDG_Load(object sender, EventArgs e)
        {
            dtpNgayHetHan.Format = DateTimePickerFormat.Custom;
            dtpNgayHetHan.CustomFormat = "yyyy/MM/dd";
            cbxVaiTroDG.Items.Clear();
            cbxVaiTroDG.Items.Add("Độc giả");
            cbxVaiTroDG.SelectedIndex = 0;

            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Chờ duyệt");
            cboTrangThai.Items.Add("Hoạt động");
            cboTrangThai.Items.Add("Bị khóa");



            cboTrangThai.SelectedIndex = 0;

            txtNgayTao.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        //nút load danh sách độc giả
        private void btnHTDanhSach_Click(object sender, EventArgs e)
        {
            using (var db = new QLTVDataContext())
            {
                var lstDG = from dg in db.DocGias
                            join nd in db.NguoiDungs on dg.IDNguoiDung_DocGia equals nd.IDNguoiDung
                            where nd.VaiTro_NguoiDung.Trim().ToLower() == "docgia"
                            select new
                            {
                                MaDG = dg.IDDocGia,
                                HoTen = nd.HoTen_NguoiDung,
                                Email = nd.Email_NguoiDung,
                                MatKhau = nd.MatKhau_NguoiDung,
                                SDT = nd.SDT_NguoiDung,
                                TinhTrangThe = dg.TinhTrangThe,
                                NgayCapThe = dg.NgayCap,
                                NgayHetHanThe = dg.NgayHetHan,
                                TrangThaiThe = nd.TrangThai_NguoiDung

                            };
                dataGVDSDocGia.DataSource = lstDG.ToList();

                dataGVDSDocGia.Columns["MaDG"].HeaderText = "Mã Độc Giả";
                dataGVDSDocGia.Columns["HoTen"].HeaderText = "Họ Tên";
                dataGVDSDocGia.Columns["Email"].HeaderText = "Email";
                dataGVDSDocGia.Columns["MatKhau"].HeaderText = "Mật Khẩu";
                dataGVDSDocGia.Columns["SDT"].HeaderText = "Số Điện Thoại";
                dataGVDSDocGia.Columns["TinhTrangThe"].HeaderText = "Tình Trạng Thẻ";
                dataGVDSDocGia.Columns["NgayCapThe"].HeaderText = "Ngày Cấp Thẻ";
                dataGVDSDocGia.Columns["NgayHetHanThe"].HeaderText = "Ngày Hết Hạn Thẻ";
                dataGVDSDocGia.Columns["TrangThaiThe"].HeaderText = "Trạng Thái Thẻ";

                dataGVDSDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
        }

        

        
        private void btnSearchingDG_Click(object sender, EventArgs e)
        {
            using (var db = new QLTVDataContext())
            {
                string searchingValue =  txtSearchingDG.Text.ToLower().Trim();
                if(!radMaDG.Checked && !radTenDG.Checked)
                {
                    MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(searchingValue))
                {
                    MessageBox.Show("Vui lòng nhập thông tin cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var ketqua = new List<object>();
                if (radMaDG.Checked)
                {
                    if(int.TryParse(searchingValue, out int maDG))
                    {
                        ketqua = (
                            from dg in db.DocGias
                            join nd in db.NguoiDungs on dg.IDNguoiDung_DocGia equals nd.IDNguoiDung
                            where dg.IDDocGia == maDG && nd.VaiTro_NguoiDung.ToLower() == "docgia"
                            select new
                                {
                                    MaDG = dg.IDDocGia,
                                    HoTen = nd.HoTen_NguoiDung,
                                    Email = nd.Email_NguoiDung,
                                    MatKhau = nd.MatKhau_NguoiDung,
                                    SDT = nd.SDT_NguoiDung,
                                    TinhTrangThe = dg.TinhTrangThe,
                                    NgayCapThe = dg.NgayCap,
                                    NgayHetHanThe = dg.NgayHetHan,
                                    TrangThaiThe = nd.TrangThai_NguoiDung
                                }
                            ).ToList<object>();


                        
                    }
                    else
                    {
                        MessageBox.Show("Mã độc giả không hợp lệ vui lòng nhập lại!!!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                }
                else if (radTenDG.Checked)
                {
                    string keyword = searchingValue.ToLower();
                    ketqua = (
                            from dg in db.DocGias
                            join nd in db.NguoiDungs on dg.IDNguoiDung_DocGia equals nd.IDNguoiDung
                            where nd.HoTen_NguoiDung.ToLower().Trim().Contains(keyword) && nd.VaiTro_NguoiDung.ToLower() == "docgia"
                            select new
                            {
                                MaDG = dg.IDDocGia,
                                HoTen = nd.HoTen_NguoiDung,
                                Email = nd.Email_NguoiDung,
                                MatKhau = nd.MatKhau_NguoiDung,
                                SDT = nd.SDT_NguoiDung,
                                TinhTrangThe = dg.TinhTrangThe,
                                NgayCapThe = dg.NgayCap,
                                NgayHetHanThe = dg.NgayHetHan,
                                TrangThaiThe = nd.TrangThai_NguoiDung
                            }




                        ).ToList<object>();
                }

                if (ketqua.Any())
                {
                    dataGVDSDocGia.DataSource = ketqua;
                    dataGVDSDocGia.Columns["MaDG"].HeaderText = "Mã Độc Giả";
                    dataGVDSDocGia.Columns["HoTen"].HeaderText = "Họ Tên";
                    dataGVDSDocGia.Columns["Email"].HeaderText = "Email";
                    dataGVDSDocGia.Columns["MatKhau"].HeaderText = "Mật Khẩu";
                    dataGVDSDocGia.Columns["SDT"].HeaderText = "Số Điện Thoại";
                    dataGVDSDocGia.Columns["TinhTrangThe"].HeaderText = "Tình Trạng Thẻ";
                    dataGVDSDocGia.Columns["NgayCapThe"].HeaderText = "Ngày Cấp Thẻ";
                    dataGVDSDocGia.Columns["NgayHetHanThe"].HeaderText = "Ngày Hết Hạn Thẻ";
                    dataGVDSDocGia.Columns["TrangThaiThe"].HeaderText = "Trạng Thái Thẻ";
                    dataGVDSDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }
                else
                {
                    MessageBox.Show("Không tìm thấy độc giả", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGVDSDocGia.DataSource = null;

                }



            }
            
            
        }

        private void txtSearchingDG_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void textMaDG_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenDG_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmailDG_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassDG_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDTDG_TextChanged(object sender, EventArgs e)
        {

        }

        

        

        
        private void mskNgayTao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

     
        }

        //Thêm độc giả mới
        private void btnThemDG_Click(object sender, EventArgs e)
        {
            using (var db = new QLTVDataContext())
            {
                if(string.IsNullOrEmpty(txtEmailDG.Text) || string.IsNullOrEmpty(txtTenDG.Text) || string.IsNullOrEmpty(txtSDTDG.Text) || string.IsNullOrEmpty(txtPassDG.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                var checkMail = db.NguoiDungs.FirstOrDefault(nd => nd.Email_NguoiDung == txtEmailDG.Text.Trim());
                if (checkMail != null) { 
                
                    MessageBox.Show("Email đã tồn tại, vui lòng sử dụng email khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                var docgiamoi = new NguoiDung
                {
                    HoTen_NguoiDung = txtTenDG.Text.Trim(),
                    Email_NguoiDung = txtEmailDG.Text.Trim(),
                    MatKhau_NguoiDung = txtPassDG.Text.Trim(),
                    SDT_NguoiDung = txtSDTDG.Text.Trim(),
                    VaiTro_NguoiDung = "DocGia",
                    TrangThai_NguoiDung = cboTrangThai.SelectedItem != null ? cboTrangThai.SelectedItem.ToString() : "Chờ duyệt",
                    NgayTao_NguoiDung = DateTime.Now
                    

                };
                db.NguoiDungs.Add(docgiamoi);
                db.SaveChanges();

                DateTime ngaycap = DateTime.Now;
                DateTime ngayhethan = dtpNgayHetHan.Value;

                var dgmoi = new DocGia
                {
                    IDNguoiDung_DocGia = docgiamoi.IDNguoiDung,
                    TinhTrangThe = ngayhethan < DateTime.Now ? "Hết hạn" : "Còn hạn",
                    NgayCap = ngaycap,
                    NgayHetHan = ngayhethan
                };

                db.DocGias.Add(dgmoi);
                db.SaveChanges();
                MessageBox.Show("Thêm độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtEmailDG.Clear();
                txtPassDG.Clear();
                txtSDTDG.Clear();
                txtTenDG.Clear();
                cboTrangThai.SelectedIndex = -1;

            }
            
        }

        



        //Chọn độc giả từ DataGridView

        private void dataGVDSDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGVDSDocGia.Rows[e.RowIndex];
                textMaDG.Text = row.Cells["MaDG"].Value.ToString();
                txtEmailDG.Text = row.Cells["Email"].Value.ToString();
                txtTenDG.Text = row.Cells["HOTEN"].Value.ToString();
                txtSDTDG.Text = row.Cells["SDT"].Value.ToString();
                string base64Pass = row.Cells["MatKhau"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(base64Pass))
                {
                    try
                    {
                        byte[] data = Convert.FromBase64String(base64Pass);
                        string decodedPass = Encoding.UTF8.GetString(data);
                        txtPassDG.Text = decodedPass;
                    }
                    catch
                    {
                        // Nếu giải mã thất bại, hiển thị trực tiếp base64
                        txtPassDG.Text = base64Pass;
                    }
                }
                else
                {
                    txtPassDG.Text = "";
                }

                // Xử lý chọn trạng thái trong ComboBox an toàn
                string trangThai = row.Cells["TrangThaiThe"].Value?.ToString() ?? "";
                if (cboTrangThai.Items.Contains(trangThai))
                {
                    cboTrangThai.SelectedItem = trangThai;
                }
                else
                {
                    cboTrangThai.SelectedIndex = -1; // Không chọn mục nào
                }

                // Xử lý ngày hết hạn an toàn
                string ngayHetHanStr = row.Cells["NgayHetHanThe"].Value?.ToString();
                if (DateTime.TryParse(ngayHetHanStr, out DateTime ngayHetHan))
                {
                    dtpNgayHetHan.MinDate = DateTimePicker.MinimumDateTime;
                    dtpNgayHetHan.MaxDate = DateTimePicker.MaximumDateTime;
                    dtpNgayHetHan.Value = ngayHetHan;
                }
                else
                {
                    dtpNgayHetHan.Value = DateTime.Now;
                }

            }
        }

        //Sửa thông tin DG
        private void btnSuaDG_Click(object sender, EventArgs e)
        {
            if (dataGVDSDocGia.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn độc giả cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            DataGridViewRow selectedRow = dataGVDSDocGia.SelectedRows[0];
            int maDocGia = Convert.ToInt32(selectedRow.Cells["MaDG"].Value);

            using (var db = new QLTVDataContext())
            {
                var docGia = db.DocGias.FirstOrDefault(d => d.IDDocGia == maDocGia);
                if (docGia == null)
                {
                    MessageBox.Show("Không tìm thấy độc giả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var nguoiDung = db.NguoiDungs.FirstOrDefault(n => n.IDNguoiDung == docGia.IDNguoiDung_DocGia);
                if (nguoiDung == null)
                {
                    MessageBox.Show("Không tìm thấy người dùng tương ứng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                nguoiDung.HoTen_NguoiDung = txtTenDG.Text.Trim();
                nguoiDung.Email_NguoiDung = txtEmailDG.Text.Trim();
                nguoiDung.SDT_NguoiDung = txtSDTDG.Text.Trim();
                nguoiDung.MatKhau_NguoiDung = txtPassDG.Text.Trim();
                nguoiDung.TrangThai_NguoiDung = cboTrangThai.SelectedItem?.ToString() ?? "Hoạt động";

                
                docGia.NgayHetHan = dtpNgayHetHan.Value;

                
                if (DateTime.Now > docGia.NgayHetHan)
                    docGia.TinhTrangThe = "Hết hạn";
                else
                    docGia.TinhTrangThe = "Còn hạn";

                db.SaveChanges();

                MessageBox.Show("Cập nhật thông tin độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        //Xóa thông tin độc giả
        private void btnXoaDG_Click(object sender, EventArgs e)
        {
            if (dataGVDSDocGia.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn độc giả cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow selectedRow = dataGVDSDocGia.SelectedRows[0];

            if (!int.TryParse(selectedRow.Cells["MaDG"].Value?.ToString(), out int maDocGia))
            {
                MessageBox.Show("Không lấy được mã độc giả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa độc giả này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
            {
                return;

            }

            using (var db = new QLTVDataContext())
            {

                var docGia = db.DocGias.FirstOrDefault(d => d.IDDocGia == maDocGia);
                if (docGia != null)
                {

                    var nguoiDung = db.NguoiDungs.FirstOrDefault(nd => nd.IDNguoiDung == docGia.IDNguoiDung_DocGia);


                    db.DocGias.Remove(docGia);


                    if (nguoiDung != null)
                    {
                        db.NguoiDungs.Remove(nguoiDung);

                    }

                    db.SaveChanges();

                    MessageBox.Show("Xóa độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
                else
                {
                    MessageBox.Show("Không tìm thấy độc giả trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            textMaDG.Clear();
            txtEmailDG.Clear();
            txtPassDG.Clear();
            txtSDTDG.Clear();
            txtTenDG.Clear();
            cboTrangThai.SelectedIndex = -1;
            dtpNgayHetHan.Value = DateTime.Now;

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGVDSDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void mskNgayHetHan_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dtpNgayHetHan_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
