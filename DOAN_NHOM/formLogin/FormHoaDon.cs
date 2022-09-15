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
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }

      

        private void dtgv_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataTable dt = ClassProvider.dataProvider.Instance.GetDataTable("GET_PRODUCT");
            //dtgv_Product.DataSource = dt ;
            //txt_ProductName.DataBindings.Add(new Binding("Text", dtgv_Product.DataSource,"");
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            DataTable dt = ClassProvider.dataProvider.Instance.GetDataTableByProcedure("GET_PRODUCT");
            //DataTable s = ClassProvider.dataProvider.Instance.GetDataTable("Select * ");
            dtgv_Product.DataSource = dt;

            
        }

        

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
