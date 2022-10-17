using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.Rendering;
using ZXing.QrCode.Internal;

namespace formLogin
{
    public partial class formThanhToanMomo : Form
    {
        public formThanhToanMomo()
        {
            InitializeComponent();
        }
        private int kmai = formGioHang.khuyenmai;
        private float tongTien = formGioHang.tongtien;
        public static bool confirm = false;
        private void bt_Payment_Click(object sender, EventArgs e)
        {
            var qrCode = $"2|99|{tb_SDT.Text.Trim()}|{tb_Name.Text.Trim()}|Nghiazorovn2304@gmail.com|0|0|{tb_Money.Text.Trim()}";
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            EncodingOptions encodingOptions = new EncodingOptions() { Width = 250, Height = 250, Margin = 0, PureBarcode = false };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            barcodeWriter.Renderer = new BitmapRenderer();
            barcodeWriter.Options = encodingOptions;
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = barcodeWriter.Write(qrCode);
            Bitmap logo = new Bitmap(Properties.Resources.MoMo_Logo1, new Size(64, 64));
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
            pictureBox1.Image = bitmap;
        }

        private void iconPic_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void iconPic_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formThanhToanMomo_Load(object sender, EventArgs e)
        {
            tb_Money.Text = ((tongTien) - (kmai * 0.01* tongTien)).ToString() + "000";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            confirm = true;
            if(MessageBox.Show("bạn có muốn in hóa đơn?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                reportView reportView = new reportView();
                reportView.Show();
            }
            else
            {
                this.Close();
            }
        }
    }
}
