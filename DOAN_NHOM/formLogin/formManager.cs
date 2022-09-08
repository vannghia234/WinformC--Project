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
        public formManager()
        {
            InitializeComponent();
        }
    
        private void btnHomePage_Click(object sender, EventArgs e)
        {
            btnHomePage.BackColor = Color.FromArgb(255,67,64);
            addForm(new ftableManager());
            btnAccountInfo.BackColor = Color.FromArgb(65, 67, 106);
            labelTitle.BackColor = Color.FromArgb(255,67,64);
            labelTitle.Text = "TRANG CHỦ";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        //private Form kiemTraTonTai(Type formType)
        //{
        //    foreach (Form item in this.MdiChildren)
        //    {
        //        if(item.GetType() == formType)
        //        {
        //            return item;
        //        }    
        //    }
        //    return null;
        //}
        private void addForm(Form form)
        {
            this.pannelHomepage.Controls.Clear();
            pannelHomepage.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pannelHomepage.Controls.Add(form);
            form.Show();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            pannelHomepage.Controls.Clear();
            btnHomePage.BackColor = Color.FromArgb(65, 67, 106);
            labelTitle.Text = "THÔNG TIN TÀI KHOẢN";
            btnAccountInfo.BackColor = Color.FromArgb(13, 196, 110);
            labelTitle.BackColor = Color.FromArgb(13, 196, 110);
            //this.BackColor = Color.FromArgb(13, 196, 110);
            fAccountProfile form = new fAccountProfile();
            pannelHomepage.Dock = DockStyle.None;
            pannelHomepage.Location = new Point(290, 70);
            pannelHomepage.Size = new System.Drawing.Size(928, 678);
            form.TopLevel = false;
            //form.Dock = DockStyle.Fill;
            form.Show();
            pannelHomepage.Controls.Add(form);


        }

        private void btnLoginOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất tài khoản không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
           if (result == DialogResult.OK)
            {
                formLogin hp = new formLogin();
                this.Close();
                hp.Show();
            }

        }
    }
}
