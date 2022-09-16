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
    public partial class formQuanLy : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public formQuanLy()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 60);
            panel_Menu.Controls.Add(leftBorderBtn);

        
        }
        private void addForm(Form form)
        {
            //this.pannelHomepage.Controls.Clear();
            //pannelHomepage.Dock = DockStyle.Fill;
            //form.TopLevel = false;
            //form.Dock = DockStyle.Fill;
            //pannelHomepage.Controls.Add(form);
            //form.Show();

        }
        private struct MyColors
        {
            public static Color primary = Color.FromArgb(31, 30, 68);
            public static Color red = Color.FromArgb(255, 67, 64);
            public static Color yellow = Color.FromArgb(253, 203, 2);
            public static Color blue = Color.FromArgb(54, 198, 255);
            public static Color green = Color.FromArgb(13, 196, 110);
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
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
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
            pic_Title.IconChar = IconChar.HomeUser;
            pic_Title.IconColor = Color.White;
            lbl_Title.Text = "HOME";



        }
      

        private void btn_HomePage_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, MyColors.red);
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, MyColors.yellow);

        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, MyColors.green);

        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, MyColors.blue);

        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, MyColors.red);

        }

        private void btn_NCC_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, MyColors.yellow);

        }

        private void btn_Chart_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, MyColors.green);

        }

        private void btn_Kho_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, MyColors.blue);

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, MyColors.red);
            this.Hide();
            FormLogin fl = new FormLogin();
            fl.Show();


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

        }

        
    }
}
