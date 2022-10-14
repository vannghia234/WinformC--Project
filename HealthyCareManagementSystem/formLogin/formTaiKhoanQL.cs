using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formLogin
{
    public partial class formTaiKhoanQL : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public formTaiKhoanQL()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 60);
            panel_Menu.Controls.Add(leftBorderBtn);
        }
        private void addForm(Form form)
        {
            this.panelContent.Controls.Clear();
            panelContent.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelContent.Controls.Add(form);
            form.Show();

        }
        private struct MyColors
        {
            public static Color primary = Color.FromArgb(31, 30, 68);
            public static Color red = Color.FromArgb(255, 123, 137);
            public static Color yellow = Color.FromArgb(249, 225, 129);
            public static Color blue = Color.FromArgb(125, 214, 246);
            public static Color green = Color.FromArgb(102, 205, 170);
        }
        private void ActiveButton(object sender, Color color)
        {
            if(sender != null)
            {
                DisableButton();
                currentBtn = (IconButton) sender;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage; // text trước image
                // viền trái button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(currentBtn.Location.X, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // PictureBox title
                pic_Title.IconChar = currentBtn.IconChar;
                pic_Title.ForeColor = color;
                // label title
                lbl_Title.ForeColor= color;
                lbl_Title.Text = currentBtn.Text;
                // label chức vụ
                lbl_ChucVu.ForeColor = color;

                // iconbtn_logo
                iconBtn_logo.ForeColor = color;
                // 
                iconBtnExit.ForeColor = color;
                //
                iconBtnMini.ForeColor = color;
                // shop name lbl
                lbl_ShopName.ForeColor = color;


            }
            
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = MyColors.primary;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft; 
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation= TextImageRelation.ImageBeforeText;
            }
        }
        private void reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            pic_Title.IconChar = IconChar.Home;
            pic_Title.IconColor = Color.White;
            lbl_Title.Text = "Trang chủ";
            lbl_Title.ForeColor = Color.White;
            iconBtn_logo.ForeColor= Color.White;
            lbl_ChucVu.ForeColor= Color.White;
            lbl_ShopName.ForeColor = Color.White;



        }
      

        private void btn_HomePage_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, MyColors.red);
            pannelQuanLyDoiTuong.Visible = false;

        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, MyColors.green);
            addForm(new formSanPham());
            leftBorderBtn.Visible = false;

        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, MyColors.blue);

            leftBorderBtn.Visible = false;
            addForm(new FormQLNV());

        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, MyColors.red);
            addForm(new formKhachHang());
            leftBorderBtn.Visible = false;


        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, MyColors.yellow);
            leftBorderBtn.Visible = false;
            addForm(new formTaiKhoan());

        }

        private void btn_NCC_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, MyColors.yellow);
            leftBorderBtn.Visible = false;
            addForm(new formNCC());

        }

        private void btn_Chart_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, MyColors.green);
            pannelQuanLyDoiTuong.Visible = false;

            addForm(new formThongKe());

        }

        private void btn_Kho_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, MyColors.yellow);
            pannelQuanLyDoiTuong.Visible = false;
            addForm(new formNhapKho());

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, MyColors.red);
            if(MessageBox.Show("Đăng xuất ứng dụng ?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                formDangNhap fl = new formDangNhap();
                fl.Show();
            }
            


        }
       
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void iconBtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconBtnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, MyColors.blue);
            pannelQuanLyDoiTuong.Visible = false;
            addForm(new formHoaDon());


        }

        private void btn_QuanLyDoiTuong_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, MyColors.yellow);

            pannelQuanLyDoiTuong.Visible = true;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void iconBtn_logo_Click(object sender, EventArgs e)
        {
            addForm(new formHome());
            reset();
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, MyColors.green);

            pannelQuanLyDoiTuong.Visible = true;
            addForm(new formKho());
        }
    }
}
