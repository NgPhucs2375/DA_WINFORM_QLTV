using QLTV.Database;
using System;
using System.Windows.Forms;

namespace QLTV
{
    public partial class FormCaiDat : Form
    {
        public FormCaiDat()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            using (var db = new QLTVDataContext())
            {
                var phat = db.ThamSos.Find("TIEN_PHAT_MOI_NGAY");
                var giahan = db.ThamSos.Find("SO_NGAY_GIA_HAN");
                var tienmuon = db.ThamSos.Find("SO_TIEN_MUON_MOI_NGAY");

                if (phat != null) txtTienPhat.Text = phat.GiaTri;
                if (giahan != null) txtGiaHan.Text = giahan.GiaTri;
                if (tienmuon != null) txtTienMuon.Text = tienmuon.GiaTri;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateSettingsInput()) return;
            try
            {
                using (var db = new QLTVDataContext())
                {
                    var phat = db.ThamSos.Find("TIEN_PHAT_MOI_NGAY");
                    var giahan = db.ThamSos.Find("SO_NGAY_GIA_HAN");
                    var tienmuon = db.ThamSos.Find("SO_TIEN_MUON_MOI_NGAY");

                    if (phat != null) phat.GiaTri = txtTienPhat.Text;
                    if (giahan != null) giahan.GiaTri = txtGiaHan.Text;
                    if (tienmuon != null) tienmuon.GiaTri = txtTienMuon.Text;

                    db.SaveChanges();
                    MessageBox.Show("Lưu cấu hình thành công!", "Thông báo");
                    this.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }


        private bool ValidateSettingsInput()
        {
            // Kiểm tra txtTienPhat
            if (!IsValidNonNegativeInt(txtTienPhat.Text))
            {
                MessageBox.Show("Nhập sai giá tiền phạt.", "Lỗi");
                txtTienPhat.Focus();
                return false;
            }

            // Kiểm tra txtGiaHan (số ngày gia hạn phải là số nguyên dương, không âm)
            if (!IsValidNonNegativeInt(txtGiaHan.Text))
            {
                MessageBox.Show("Số ngày gia hạn không hợp lệ.", "Lỗi");
                txtGiaHan.Focus();
                return false;
            }

            // Kiểm tra txtTienMuon (tiền mượn phải là số nguyên dương, mệnh giá hợp lệ)
            if (!IsValidNonNegativeInt(txtTienMuon.Text))
            {
                MessageBox.Show("Nhập sai giá tiền mượn.", "Lỗi");
                txtTienMuon.Focus();
                return false;
            }

            return true;
        }

        // Hàm kiểm tra chuỗi có phải số nguyên không âm (>= 0) và không có ký tự khác
        private bool IsValidNonNegativeInt(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return false;

            // Kiểm tra chỉ chứa số và chuyển sang số nguyên
            if (!int.TryParse(text, out int value)) return false;

            return value >= 0;
        }

    }
}