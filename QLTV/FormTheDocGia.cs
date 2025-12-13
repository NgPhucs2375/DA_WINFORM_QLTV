using QRCoder;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLTV
{
    public partial class FormTheDocGia : Form
    {
        public FormTheDocGia(string tenDG, string maDG, string hanThe)
        {
            InitializeComponent_Code(); // Gọi hàm vẽ giao diện
            DrawCard(tenDG, maDG, hanThe);
        }

        // Hàm vẽ giao diện bằng code (Không cần Designer)
        private PictureBox picQR;
        private Label lblTen, lblMa, lblHan, lblSchool;
        private Panel pnlCard;

        private void FormTheDocGia_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent_Code()
        {
            this.Size = new Size(450, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Thẻ Thư Viện Điện Tử";
            this.BackColor = Color.WhiteSmoke;

            // Khung thẻ (Giống thẻ ATM)
            pnlCard = new Panel();
            pnlCard.Size = new Size(400, 230);
            pnlCard.Location = new Point(18, 18);
            pnlCard.BackColor = Color.FromArgb(25, 118, 210); // Màu xanh thẻ
            pnlCard.BackgroundImageLayout = ImageLayout.Stretch; // Nếu có ảnh nền thẻ thì gán vào đây
            this.Controls.Add(pnlCard);

            // Tên thư viện
            lblSchool = new Label();
            lblSchool.Text = "THƯ VIỆN QLTV";
            lblSchool.Font = new Font("Arial", 16, FontStyle.Bold);
            lblSchool.ForeColor = Color.White;
            lblSchool.AutoSize = true;
            lblSchool.Location = new Point(20, 20);
            pnlCard.Controls.Add(lblSchool);

            // Mã QR
            picQR = new PictureBox();
            picQR.Size = new Size(100, 100);
            picQR.Location = new Point(280, 65);
            picQR.SizeMode = PictureBoxSizeMode.StretchImage;
            picQR.BackColor = Color.White;
            pnlCard.Controls.Add(picQR);

            // Thông tin
            lblTen = CreateLabel(20, 80, 14, FontStyle.Bold);
            pnlCard.Controls.Add(lblTen);

            lblMa = CreateLabel(20, 110, 10, FontStyle.Regular);
            pnlCard.Controls.Add(lblMa);

            lblHan = CreateLabel(20, 180, 10, FontStyle.Italic);
            pnlCard.Controls.Add(lblHan);
        }

        private Label CreateLabel(int x, int y, float size, FontStyle style)
        {
            Label l = new Label();
            l.ForeColor = Color.White;
            l.Font = new Font("Segoe UI", size, style);
            l.Location = new Point(x, y);
            l.AutoSize = true;
            return l;
        }

        private void DrawCard(string ten, string ma, string han)
        {
            lblTen.Text = ten.ToUpper();
            lblMa.Text = "ID: " + ma;
            lblHan.Text = "Có giá trị đến: " + han;

            // Tạo mã QR
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(ma, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            picQR.Image = qrCodeImage;
        }
    }
}