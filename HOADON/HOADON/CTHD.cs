using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOADON
{
    public partial class CTHD : Form
    {
        public CTHD()
        {
            InitializeComponent();
        }
        private string message;
        DataTable data = new DataTable();
        SqlConnection con;
        string ketnoi = "Data Source=DESKTOP-P2BL7QB\\SQLEXPRESS;Initial Catalog=QUANLY_BEAUTY_HEALTH;Integrated Security=True";
        public CTHD(string Message) : this()
        {
            message = Message;
            CThd();

        }
        private void CThd()
        {
            con = new SqlConnection(ketnoi);
            con.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "HIENTHI_CTHD";
            command.Connection = con;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAHD", SqlDbType.VarChar).Value = message;
            command.ExecuteNonQuery();
            SqlDataReader dr = command.ExecuteReader();
            data.Load(dr);
            dtgv_Product.DataSource = data;
            con.Close();
        }
        private void CTHD_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Form1.maHD);
         
        }

        private void dtgv_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            message = dtgv_Product.SelectedRows[0].Cells[0].Value.ToString();
        }
        private void dtgv_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    
    }
}
