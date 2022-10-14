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
    public partial class formLoaiThanhToan : Form
    {
        public formLoaiThanhToan()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.ShowDialog();
        }

        private void iconPic_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void iconPic_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            formThanhToanMomo mm = new formThanhToanMomo();
            mm.ShowDialog();
        }
    }
}
