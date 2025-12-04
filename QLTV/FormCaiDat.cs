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

                if (phat != null) txtTienPhat.Text = phat.GiaTri;
                if (giahan != null) txtGiaHan.Text = giahan.GiaTri;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new QLTVDataContext())
                {
                    var phat = db.ThamSos.Find("TIEN_PHAT_MOI_NGAY");
                    var giahan = db.ThamSos.Find("SO_NGAY_GIA_HAN");

                    if (phat != null) phat.GiaTri = txtTienPhat.Text;
                    if (giahan != null) giahan.GiaTri = txtGiaHan.Text;

                    db.SaveChanges();
                    MessageBox.Show("Lưu cấu hình thành công!", "Thông báo");
                    this.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }
    }
}