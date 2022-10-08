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
    public partial class formProgressBarNV : Form
    {
        public formProgressBarNV()
        {
            InitializeComponent();
            
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    progressBar1.Value = progressBar1.Value + 5;
        //    if (progressBar1.Value > 99)
        //    {
        //        formNV ql = new formNV();
        //        this.Hide();
        //        ql.Show();
        //        timer1.Enabled = false;
        //    }
        //}

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 5;
            if (progressBar1.Value > 99)
            {
                formTaiKhoanNV ql = new formTaiKhoanNV();
                this.Hide();
                ql.Show();
                timer1.Enabled = false;
            }
        }
    }
}
