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
    public partial class formProgressbarQL : Form
    {
        public formProgressbarQL()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 5;
            if(progressBar1.Value > 99)
            {
                formTaiKhoanQL ql = new formTaiKhoanQL();
                this.Hide();
                ql.Show();
                timer1.Enabled = false;
            }
        }
    }
}
