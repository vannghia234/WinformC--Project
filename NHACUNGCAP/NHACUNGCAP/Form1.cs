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

namespace NHACUNGCAP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        string sql = "Data Source=DESKTOP-P2BL7QB\\SQLEXPRESS;Initial Catalog=QUANLY_BEAUTY_HEALTH;Integrated Security=True";
    private void SQL()
        {
            con = new SqlConnection(sql);
            con.Open();
            string nhacungcap = "SELECT * FROM NHACUNGCAP";
            SqlCommand command = new SqlCommand(nhacungcap,con);
            DataTable dt = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter(command);
            data.Fill(dt);
            datagridncc.DataSource = dt;
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQL();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(sql);
                con.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "INSERT_NHACC";
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MANCC", SqlDbType.VarChar).Value = txtmaNcc.Text;
                command.Parameters.Add("@TENNCC", SqlDbType.NVarChar).Value = txtTenNcc.Text;
                command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = txtSDT.Text;
                command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = txtDiachi.Text;
                command.ExecuteNonQuery();
                SQL();
                con.Close();
                MessageBox.Show("thêm thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch(Exception ex)
            {
                MessageBox.Show("thêm sai dữ liệu" + ex.Message);
            }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(sql);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "DELETE_NHACC";
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MANCC", SqlDbType.VarChar).Value = txtmaNcc.Text;
                cmd.ExecuteNonQuery();
                SQL();
                con.Close();
                MessageBox.Show("xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch(Exception ex)
            {
                MessageBox.Show("xóa không thành công" + ex.Message);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(sql);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "CHANGE_NHACC";
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MANCC", SqlDbType.VarChar).Value = txtmaNcc.Text;
                cmd.Parameters.Add("@TENNCC", SqlDbType.NVarChar).Value = txtTenNcc.Text;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = txtSDT.Text;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = txtDiachi.Text;
                cmd.ExecuteNonQuery();
                SQL();
                MessageBox.Show("sửa thành công", "thông báo" + MessageBoxButtons.OK + MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("sửa không thành công" + ex.Message);

            }
        }

        private void datagridncc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datagridncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = datagridncc.Rows[e.RowIndex];
            txtmaNcc.Text = Convert.ToString(row.Cells["MANCC"].Value);
            txtTenNcc.Text = Convert.ToString(row.Cells["TENNCC"].Value);
            txtSDT.Text = Convert.ToString(row.Cells["SDT"].Value);
            txtDiachi.Text = Convert.ToString(row.Cells["DIACHI"].Value);
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(sql);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SEACH_NHACC";
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MANCC", SqlDbType.VarChar).Value = txt_Search.Text;
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                datagridncc.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("tìm kiếm không thành công" + ex.Message);
            }
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(sql);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SEACH_NHACC";
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MANCC", SqlDbType.VarChar).Value = txt_Search.Text;
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                datagridncc.DataSource = dt;
                SQL();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("tìm kiếm không thành công" + ex.Message);
            }
        }
        private void reset()
        {
            txtmaNcc.Text = "";
            txtTenNcc.Text = "";
            txtSDT.Text = "";
            txtDiachi.Text = "";
        }
        private void btnlammoi_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát","thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
