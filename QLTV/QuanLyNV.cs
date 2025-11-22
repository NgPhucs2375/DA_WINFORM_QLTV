using QLTV.Database;
using QLTV.Database.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class QuanLyNV : Form
    {
        public QuanLyNV()
        {
            InitializeComponent();
        }
        private void QuanLyTG_Load(object sender, EventArgs e)
        {
            dtpkNgayVLNV.Format = DateTimePickerFormat.Custom;
            dtpkNgayVLNV.CustomFormat = "yyyy/MM/dd";
            cboVaiTro.Items.Clear();
            cboVaiTro.Items.Add("Quản lý");
            cboVaiTro.Items.Add("Nhân viên");

        }

        private void btnHTDanhSach_Click(object sender, EventArgs e)
        {
            using (var db = new QLTVDataContext())
            {
                var listNV = from nv in db.NhanViens
                             join nd in db.NguoiDungs
                          on nv.IDNguoiDung_NhanVien equals nd.IDNguoiDung
                             select new
                             {
                                 MaNhanVien = nv.IDNhanVien,
                                 HoTen = nd.HoTen_NguoiDung,
                                 Email = nd.Email_NguoiDung,
                                 MatKhau = nd.MatKhau_NguoiDung,
                                 SDT = nd.SDT_NguoiDung,
                                 ChucVu = nv.ChucVu,
                                 NgayVaoLam = nv.NgayVaoLam,
                                 TrangThai = nd.TrangThai_NguoiDung
                             };

                dgvNhanVien.DataSource = listNV.ToList();

                // Thiết lập lại tiêu đề cột (header text)
                dgvNhanVien.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
                dgvNhanVien.Columns["HoTen"].HeaderText = "Họ tên";
                dgvNhanVien.Columns["Email"].HeaderText = "Email";
                dgvNhanVien.Columns["MatKhau"].HeaderText = "Mật khẩu";
                dgvNhanVien.Columns["SDT"].HeaderText = "Số điện thoại";
                dgvNhanVien.Columns["ChucVu"].HeaderText = "Chức vụ";
                dgvNhanVien.Columns["NgayVaoLam"].HeaderText = "Ngày vào làm";
                dgvNhanVien.Columns["TrangThai"].HeaderText = "Trạng thái";

                // Tự động co dãn cột cho đẹp hơn
                dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNhanVien"].Value.ToString();
                txtTenNV.Text = row.Cells["HoTen"].Value.ToString();
                txtEmailNV.Text = row.Cells["Email"].Value.ToString();
                txtSDTNV.Text = row.Cells["SDT"].Value.ToString();
                cboVaiTro.Text = row.Cells["ChucVu"].Value.ToString();
                dtpkNgayVLNV.Value = Convert.ToDateTime(row.Cells["NgayVaoLam"].Value);
                string base64 = row.Cells["MatKhau"].Value.ToString() ?? "";
                if (!string.IsNullOrEmpty(base64))
                {
                    try
                    {
                        byte[] data = Convert.FromBase64String(base64);
                        string decodedPass = Encoding.UTF8.GetString(data);
                        txtMatKhauNV.Text = decodedPass;
                    }
                    catch
                    {
                        // Nếu giải mã thất bại, hiển thị trực tiếp base64
                        txtMatKhauNV.Text = base64;
                    }
                }
                else
                {
                    txtMatKhauNV.Text = "";
                }

            }
        }
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtTenNV.Text) ||
                    string.IsNullOrWhiteSpace(txtEmailNV.Text) ||
                    string.IsNullOrWhiteSpace(txtSDTNV.Text) ||
                    string.IsNullOrWhiteSpace(txtMatKhauNV.Text) ||
                    string.IsNullOrWhiteSpace(cboVaiTro.Text)
                )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var db = new QLTVDataContext())
            {
                string email = txtEmailNV.Text.Trim();

                bool emailExists = db.NguoiDungs.Any(u => u.Email_NguoiDung == email);

                if (emailExists)
                {
                    MessageBox.Show("Email đã tồn tại, vui lòng nhập email khác!",
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string plaintext = txtMatKhauNV.Text;
                string base64pass = Convert.ToBase64String(Encoding.UTF8.GetBytes(plaintext));
                string vaitro = cboVaiTro.SelectedItem?.ToString();
                if (vaitro == "Nhân viên")
                {
                    vaitro = "nhanvien";
                }
                else
                {
                    vaitro = "admin";
                }
                NguoiDung nd = new NguoiDung
                {
                    HoTen_NguoiDung = txtTenNV.Text,
                    Email_NguoiDung = email,
                    SDT_NguoiDung = txtSDTNV.Text,
                    MatKhau_NguoiDung = base64pass,
                    VaiTro_NguoiDung = vaitro,
                    TrangThai_NguoiDung = "Đang hoạt động",
                    NgayTao_NguoiDung = DateTime.Now
                };
                db.NguoiDungs.Add(nd);
                db.SaveChanges();

                NhanVien nv = new NhanVien
                {
                    IDNguoiDung_NhanVien = nd.IDNguoiDung,
                    ChucVu = cboVaiTro.Text,
                    NgayVaoLam = dtpkNgayVLNV.Value
                };
                db.NhanViens.Add(nv);
                db.SaveChanges();
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 5. Refresh danh sách
                btnHTDanhSach_Click(null, null);
            }
        }
        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maNV = int.Parse(txtMaNV.Text.Trim());

            using (var db = new QLTVDataContext())
            {
                var nv = db.NhanViens.FirstOrDefault(x => x.IDNhanVien == maNV);
                if (nv == null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var nd = db.NguoiDungs.FirstOrDefault(x => x.IDNguoiDung == nv.IDNguoiDung_NhanVien);
                if (nd == null)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu người dùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string selectedVaiTro = cboVaiTro.SelectedItem?.ToString();
                string vaitro = (selectedVaiTro == "Nhân viên") ? "nhanvien" : "admin";

                // --- KIỂM TRA KHÔNG CHO TỰ ĐỔI ROLE CỦA CHÍNH MÌNH ---
                if (nd.IDNguoiDung == Program.CurrentUserId && nd.VaiTro_NguoiDung != vaitro)
                {
                    MessageBox.Show("Bạn không thể tự thay đổi vai trò của chính mình!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Nếu qua được kiểm tra thì mới cập nhật
                nd.HoTen_NguoiDung = txtTenNV.Text.Trim();
                nd.Email_NguoiDung = txtEmailNV.Text.Trim();
                nd.SDT_NguoiDung = txtSDTNV.Text.Trim();
                nd.VaiTro_NguoiDung = vaitro;

                nv.ChucVu = cboVaiTro.Text.Trim();
                nv.NgayVaoLam = dtpkNgayVLNV.Value;

                db.SaveChanges();

                MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnHTDanhSach_Click(null, null);

            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maNV = int.Parse(txtMaNV.Text.Trim());

            using (var db = new QLTVDataContext())
            {
                var nv = db.NhanViens.FirstOrDefault(x => x.IDNhanVien == maNV);
                if (nv == null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var nd = db.NguoiDungs.FirstOrDefault(x => x.IDNguoiDung == nv.IDNguoiDung_NhanVien);
                if (nd == null)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu người dùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (nd.IDNguoiDung == Program.CurrentUserId)
                {
                    MessageBox.Show("Bạn không thể xóa chính mình!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (nd.VaiTro_NguoiDung?.ToLower() == "admin")
                {
                    MessageBox.Show("Bạn không thể xóa nhân viên có vai trò Admin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirm = MessageBox.Show($"Bạn có chắc muốn xóa nhân viên: {nd.HoTen_NguoiDung}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        db.NhanViens.Remove(nv);
                        db.NguoiDungs.Remove(nd);

                        db.SaveChanges();

                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Load lại danh sách
                        btnHTDanhSach_Click(null, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEmailNV.Clear();
            txtMaNV.Clear();
            txtMatKhauNV.Clear();
            txtSDTNV.Clear();
            txtTenNV.Clear();
            cboVaiTro.SelectedIndex = -1;

        }

        private void btnSearchingNV_Click(object sender, EventArgs e)
        {
            using (var db = new QLTVDataContext())
            {
                string searchingValue = txtKeyword.Text.ToLower().Trim();

                if (!radMaNV.Checked && !radTenNV.Checked)
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

                if (radMaNV.Checked)
                {
                    if (int.TryParse(searchingValue, out int maNV))
                    {
                        ketqua = (
                            from nv in db.NhanViens
                            join nd in db.NguoiDungs on nv.IDNguoiDung_NhanVien equals nd.IDNguoiDung
                            where nv.IDNhanVien == maNV
                            select new
                            {
                                MaNhanVien = nv.IDNhanVien,
                                HoTen = nd.HoTen_NguoiDung,
                                Email = nd.Email_NguoiDung,
                                MatKhau = nd.MatKhau_NguoiDung,
                                SDT = nd.SDT_NguoiDung,
                                ChucVu = nv.ChucVu,
                                NgayVaoLam = nv.NgayVaoLam,
                                TrangThai = nd.TrangThai_NguoiDung
                            }
                        ).ToList<object>();
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên không hợp lệ, vui lòng nhập lại!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (radTenNV.Checked)
                {
                    string keyword = searchingValue.ToLower();
                    ketqua = (
                        from nv in db.NhanViens
                        join nd in db.NguoiDungs on nv.IDNguoiDung_NhanVien equals nd.IDNguoiDung
                        where nd.HoTen_NguoiDung.ToLower().Trim().Contains(keyword)
                        select new
                        {
                            MaNhanVien = nv.IDNhanVien,
                            HoTen = nd.HoTen_NguoiDung,
                            Email = nd.Email_NguoiDung,
                            MatKhau = nd.MatKhau_NguoiDung,
                            SDT = nd.SDT_NguoiDung,
                            ChucVu = nv.ChucVu,
                            NgayVaoLam = nv.NgayVaoLam,
                            TrangThai = nd.TrangThai_NguoiDung
                        }
                    ).ToList<object>();
                }

                if (ketqua.Any())
                {
                    dgvNhanVien.DataSource = ketqua;

                    // Đặt lại tiêu đề cột với kiểm tra null để tránh lỗi
                    if (dgvNhanVien.Columns["MaNhanVien"] != null)
                        dgvNhanVien.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
                    if (dgvNhanVien.Columns["HoTen"] != null)
                        dgvNhanVien.Columns["HoTen"].HeaderText = "Họ tên";
                    if (dgvNhanVien.Columns["Email"] != null)
                        dgvNhanVien.Columns["Email"].HeaderText = "Email";
                    if (dgvNhanVien.Columns["MatKhau"] != null)
                        dgvNhanVien.Columns["MatKhau"].HeaderText = "Mật khẩu";
                    if (dgvNhanVien.Columns["SDT"] != null)
                        dgvNhanVien.Columns["SDT"].HeaderText = "Số điện thoại";
                    if (dgvNhanVien.Columns["ChucVu"] != null)
                        dgvNhanVien.Columns["ChucVu"].HeaderText = "Chức vụ";
                    if (dgvNhanVien.Columns["NgayVaoLam"] != null)
                        dgvNhanVien.Columns["NgayVaoLam"].HeaderText = "Ngày vào làm";
                    if (dgvNhanVien.Columns["TrangThai"] != null)
                        dgvNhanVien.Columns["TrangThai"].HeaderText = "Trạng thái";

                    dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên phù hợp!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvNhanVien.DataSource = null;
                }
            }
        }


        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {

        }

        private void radMaNV_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radTenNV_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
