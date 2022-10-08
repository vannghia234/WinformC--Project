using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formLogin
{
    public partial class formNCC : Form
    {
        public formNCC()
        {
            InitializeComponent();
        }
        DataTable dataproc = new DataTable();
        SqlConnection con;
        string sql = "Data Source=DAICA-ZORO\\MSSQLSERVER01;Initial Catalog=QUANLY_BEAUTY_HEALTH;Integrated Security=True";
    private void SQL()
        {
            con = new SqlConnection(sql);
            con.Open();
            string nhacungcap = "SELECT * FROM NHACUNGCAP";
            SqlCommand command = new SqlCommand(nhacungcap,con);
            SqlDataAdapter data = new SqlDataAdapter(command);
            data.Fill(dataproc);
            dtgv_Product.DataSource = dataproc;
            con.Close();
        }
    private void sqlproc()
        {
                DataTable proc = new DataTable();
                con = new SqlConnection(sql);
                con.Open();
                string nhacungcap = "SELECT * FROM NHACUNGCAP";
                SqlCommand command = new SqlCommand(nhacungcap, con);
                SqlDataAdapter data = new SqlDataAdapter(command);
                data.Fill(proc);
                dtgv_Product.DataSource = proc;
                con.Close();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQL();
        }
        public bool Kiemtrathongtin()
        {
           
            
            if (txtSDT.Text == "" && txtSDT.Text.Length != 10)
            {
                MessageBox.Show("Bạn cần nhập đủ số điện thoại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return false;
            }
            if (txtDiachi.Text == "")
            {
                MessageBox.Show("Bạn cần nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiachi.Focus();
                return false;
            }
           
            return true;
        }
        private string RandomSP(int k)
        {
            string result = "";
            Random random = new Random();
            char[] MangKyTu = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < k; i++)
            {
                int t = random.Next(0, MangKyTu.Length);
                result += MangKyTu[t];
            }
            return result;
        }
        public bool kiemtra()
        {
            if (txt_Search.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã nhà cung cấp và tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Search.Focus();
                return false;
            }

            return true;
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenNcc.Text == "" )
                {
                    MessageBox.Show("Bạn cần nhập đủ số điện thoại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenNcc.Focus();
                   
                }else if (Kiemtrathongtin())
                {

                
                    txtNCC.Text = RandomSP(8);
                    btnxoa.Enabled = false;
                    con = new SqlConnection(sql);
                    con.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "INSERT_NHACC";
                    command.Connection = con;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@MANCC", SqlDbType.VarChar).Value = txtNCC.Text;
                    command.Parameters.Add("@TENNCC", SqlDbType.NVarChar).Value = txtTenNcc.Text;
                    command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = txtSDT.Text;
                    command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = txtDiachi.Text;
                    command.ExecuteNonQuery();
                    sqlproc();
                    reset();
                    con.Close();
                    MessageBox.Show("thêm thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
            }catch(Exception ex)
            {
                MessageBox.Show("thêm sai dữ liệu" + ex.Message);
            }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNCC.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập mã sản phẩm", "thông báo" ,MessageBoxButtons.OK,MessageBoxIcon.Question);
                    txtNCC.Focus();
                }
                else if (Kiemtrathongtin())
                {
                    btnsua.Enabled = false;
                    btnadd.Enabled = true;
                    con = new SqlConnection(sql);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "DELETE_NHACC";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MANCC", SqlDbType.VarChar).Value = txtNCC.Text;
                    cmd.ExecuteNonQuery();
                    sqlproc();
                    reset();
                    con.Close();
                    MessageBox.Show("xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("xóa không thành công" + ex.Message);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenNcc.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập tên nhà cung cấp ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSDT.Focus();

                }
                else if (Kiemtrathongtin())
                {
                    con = new SqlConnection(sql);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "CHANGE_NHACC";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MANCC", SqlDbType.VarChar).Value = txtNCC.Text;
                    cmd.Parameters.Add("@TENNCC", SqlDbType.NVarChar).Value = txtTenNcc.Text;
                    cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = txtSDT.Text;
                    cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = txtDiachi.Text;
                    cmd.ExecuteNonQuery();
                    sqlproc();
                    reset();
                    MessageBox.Show("sửa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
          
            }catch (Exception ex)
            {
                MessageBox.Show("sửa không thành công" + ex.Message);

            }
        }

      

 

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //if (txt_Search.Text == "")
            //{
            //    MessageBox.Show("Bạn cần nhập mã nhà cung cấp", "thông báo",MessageBoxButtons.OK,MessageBoxIcon.Question);
            //    txt_Search.Focus();
            //}
            //else if (kiemtra())
            //{
            //    con = new SqlConnection(sql);
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.CommandText = "SEACH_NHACC";
            //    cmd.Connection = con;
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.Add("@MANCC", SqlDbType.VarChar).Value = txt_Search.Text;
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    DataTable dt = new DataTable();
            //    dt.Load(dr);
            //    datagridncc.DataSource = dataproc;
            //    con.Close();
            //}
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("tìm kiếm không thành công" + ex.Message);
            //}
            DataView dataView = new DataView(dataproc);
            dataView.RowFilter = String.Format("TENNCC like '%{0}%' or MANCC like '%{1}%'", txt_Search.Text, txt_Search.Text);
            dtgv_Product.DataSource = dataView;

        }

        private void btnload_Click(object sender, EventArgs e)
        {
            sqlproc();

        }
        private void reset()
        {
            txtNCC.Text = "";
            txtTenNcc.Text = "";
            txtSDT.Text = "";
            txtDiachi.Text = "";
         
        }
        private void btnlammoi_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnadd.Enabled = true;
            txtNCC.Enabled = true;
            reset();
        }


        private void dtgv_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnadd.Enabled = false;
            txtNCC.Enabled = false;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            DataGridViewRow row = new DataGridViewRow();
            row = dtgv_Product.Rows[e.RowIndex];
            txtNCC.Text = Convert.ToString(row.Cells["MANCC"].Value);
            txtTenNcc.Text = Convert.ToString(row.Cells["TENNCC"].Value);
            txtSDT.Text = Convert.ToString(row.Cells["SDT"].Value);
            txtDiachi.Text = Convert.ToString(row.Cells["DIACHI"].Value);
        }

     
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            sqlproc();

        }
    }
}
