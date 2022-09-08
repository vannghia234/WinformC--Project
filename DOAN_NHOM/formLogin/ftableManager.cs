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
    public partial class ftableManager : Form
    {
        public ftableManager()
        {
            InitializeComponent();
        }

      

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile acc = new fAccountProfile();
            this.Hide();
            acc.ShowDialog();
            this.Show();
        }
      
    }
}
