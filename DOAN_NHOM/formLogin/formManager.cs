using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formLogin
{
    public partial class formManager : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public formManager()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 60);
            panel_Menu.Controls.Add(leftBorderBtn);
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
            if (sender != null)
            {
                DisableButton();
                currentBtn = (IconButton)sender;
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
                lbl_Title.ForeColor = color;
                lbl_Title.Text = currentBtn.Text;
                // label chức vụ
                lbl_ChucVu.ForeColor = color;


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
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }
        private void reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            pic_Title.IconChar = IconChar.Home;
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
            formLogin fl = new formLogin();
            fl.Show();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            reset();
        }
    }


    //    private PictureBox picTitle;
    //    private Panel leftBorderBtn;
    //    private Button btnClicked;
    //    private Form currentChildForm;
    //    public formManager()
    //    {
    //        InitializeComponent();
    //        leftBorderBtn = new Panel();
    //        leftBorderBtn.Size = new Size(7, 60);
    //        panelMenu.Controls.Add(leftBorderBtn);
    //    }
    //    private void ActiveButton(Object senderBtn, Color color)
    //    {
    //        if (senderBtn != null)
    //        {
    //            //button
    //            btnClicked = (Button)senderBtn;
    //        }

    //    }


    //    private struct RGBColors
    //    {
    //        public static Color primary = Color.FromArgb(31,30, 68);
    //        public static Color red = Color.FromArgb(255, 67, 64);
    //        public static Color yellow = Color.FromArgb(253, 203, 2);
    //        public static Color blue = Color.FromArgb(54, 198, 255);
    //        public static Color green = Color.FromArgb(13, 196, 110);
    //    }

    //    private void btnHomePage_Click(object sender, EventArgs e)
    //    {
    //        pic_Title.BackColor = RGBColors.red;
    //        btnHomePage.BackColor = Color.FromArgb(255,67,64);
    //        addForm(new ftableManager());
    //        btnAccountInfo.BackColor = Color.FromArgb(65, 67, 106);
    //        labelTitle.BackColor = Color.FromArgb(255,67,64);
    //        labelTitle.Text = "TRANG CHỦ";
    //    }

    //    private void button1_Click(object sender, EventArgs e)
    //    {

    //    }

    //    private void button2_Click(object sender, EventArgs e)
    //    {

    //    }

    //    private void button3_Click(object sender, EventArgs e)
    //    {

    //    }
    //    //private Form kiemTraTonTai(Type formType)
    //    //{
    //    //    foreach (Form item in this.MdiChildren)
    //    //    {
    //    //        if(item.GetType() == formType)
    //    //        {
    //    //            return item;
    //    //        }    
    //    //    }
    //    //    return null;
    //    //}
    //    private void addForm(Form form)
    //    {
    //        this.pannelHomepage.Controls.Clear();
    //        pannelHomepage.Dock = DockStyle.Fill;
    //        form.TopLevel = false;
    //        form.Dock = DockStyle.Fill;
    //        pannelHomepage.Controls.Add(form);
    //        form.Show();

    //    }
    //    private void button4_Click(object sender, EventArgs e)
    //    {
    //        pannelHomepage.Controls.Clear();
    //        btnHomePage.BackColor = Color.FromArgb(65, 67, 106);
    //        labelTitle.Text = "THÔNG TIN TÀI KHOẢN";
    //        btnAccountInfo.BackColor = Color.FromArgb(13, 196, 110);
    //        labelTitle.BackColor = Color.FromArgb(13, 196, 110);
    //        //this.BackColor = Color.FromArgb(13, 196, 110);
    //        fAccountProfile form = new fAccountProfile();
    //        pannelHomepage.Dock = DockStyle.None;
    //        pannelHomepage.Location = new Point(290, 70);
    //        pannelHomepage.Size = new System.Drawing.Size(928, 678);
    //        form.TopLevel = false;
    //        //form.Dock = DockStyle.Fill;
    //        form.Show();
    //        pannelHomepage.Controls.Add(form);


    //    }

    //    private void btnLoginOut_Click(object sender, EventArgs e)
    //    {
    //        DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất tài khoản không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
    //       if (result == DialogResult.OK)
    //        {
    //            formLogin hp = new formLogin();
    //            this.Close();
    //            hp.Show();
    //        }

    //    }
    //}
}
