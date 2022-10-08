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

namespace formLogin
{
    public partial class formCTHD : Form
    {
        public formCTHD()
        {
            InitializeComponent();
        }
        private string message;
        DataTable data = new DataTable();
        SqlConnection con;
        string ketnoi = "Data Source=DAICA-ZORO\\MSSQLSERVER01;Initial Catalog=QUANLY_BEAUTY_HEALTH;Integrated Security=True";
        
        private void CThd()
        {
            con = new SqlConnection(ketnoi);
            con.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "HIENTHI_CTHD";
            command.Connection = con;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAHD", SqlDbType.VarChar).Value = formHoaDon.maHD;
            command.ExecuteNonQuery();
            SqlDataReader dr = command.ExecuteReader();
            data.Load(dr);
            dtgv_Product.DataSource = data;
            con.Close();
        }
        //private void Deletecthd()
        //{
        //    con = new SqlConnection(ketnoi);
        //    con.Open();
        //    SqlCommand command = new SqlCommand();
        //    command.CommandText = "DELETE_GIOHANG";
        //    command.Connection = con;
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.Parameters.Add("@MAHD", SqlDbType.VarChar).Value = Form1.maHD;
        //    command.ExecuteNonQuery();
        //    SqlDataReader dr = command.ExecuteReader();
        //    data.Load(dr);
        //    dtgv_Product.DataSource = data;
        //    con.Close();
        //}

        private void CTHD_Load(object sender, EventArgs e)
        {
            CThd();
            con = new SqlConnection(ketnoi);
            con.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "GETDATA_HD";
            command.Connection = con;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAHD", SqlDbType.VarChar).Value = formHoaDon.maHD;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            foreach (DataRow item in dt.Rows)
            {
                lblKH.Text = "Tên khách hàng: " + item[0].ToString();
                lblHD.Text = "Mã hóa đơn: " + item[4].ToString();
                lblNV.Text = "Tên nhân viên: " + item[1].ToString();
                lblNgayLap.Text = "Ngày lập: " + item[2].ToString();
                lblTongTien.Text = "Tổng tiền: " + item[3].ToString();


            }

        }

        private void dtgv_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
