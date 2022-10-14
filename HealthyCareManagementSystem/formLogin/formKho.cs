using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Controls;


namespace formLogin
{
    public partial class formKho : Form
    {
        public formKho()
        {
            InitializeComponent();
        }
        String strCon = "Data Source=DAICA-ZORO\\MSSQLSERVER01;Initial Catalog=QUANLY_BEAUTY_HEALTH;Integrated Security=True";
        SqlConnection SqlCon;
        DataTable dataproc = new DataTable();

        private void HienThiDanhSach()
        {
            SqlCon = new SqlConnection(strCon);
            SqlCon.Open();
            string sql = "SELECT MAKHO [MÃ KHO], TENKHO [TÊN KHO], DIACHI [ĐỊA CHỈ] FROM KHO";
            SqlCommand command = new SqlCommand(sql, SqlCon);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataproc);
            dtgv_proc.DataSource = dataproc;
            SqlCon.Close();
        }
        private void load()
        {
            SqlCon = new SqlConnection(strCon);
            SqlCon.Open();
            string sql = "SELECT MAKHO [MÃ KHO], TENKHO [TÊN KHO], DIACHI [ĐỊA CHỈ] FROM KHO";
            SqlCommand command = new SqlCommand(sql, SqlCon);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtgv_proc.DataSource = dt;
            SqlCon.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private string RandomKho(int k)
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
        public bool Kiemtrathongtin()
        {


            if (txtTenKho.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tên kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKho.Focus();
                return false;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn cần nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return false;

            }
            return true;


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaKho.Enabled = false;
            try
            {
                if (Kiemtrathongtin())
                {
                    txtMaKho.Text = RandomKho(8);
                    SqlCon = new SqlConnection(strCon);
                    SqlCon.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "them";
                    command.Connection = SqlCon;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@MAKHO", SqlDbType.VarChar).Value = txtMaKho.Text;
                    command.Parameters.Add("@TENKHO", SqlDbType.NVarChar).Value = txtTenKho.Text;
                    command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = txtDiaChi.Text;
                    command.ExecuteNonQuery();
                    HienThiDanhSach();
                    lammoi();
                    MessageBox.Show("Đã thêm thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SqlCon.Close();
                }
            }

            catch
            {
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            lammoi();
        }

        private void lammoi()
        {
            txtMaKho.Text = "";
            txtTenKho.Text = "";
            txtDiaChi.Text = "";
            txtTimKiem.Text = "";
        }

        private void datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            DataGridViewRow row = new DataGridViewRow();
            row = dtgv_proc.Rows[e.RowIndex];
            txtMaKho.Text = Convert.ToString(row.Cells[0].Value);
            txtTenKho.Text = Convert.ToString(row.Cells[1].Value);
            txtDiaChi.Text = Convert.ToString(row.Cells[2].Value);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKho.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKho.Focus();

            }
            else if (Kiemtrathongtin())
            {
                try
                {


                    SqlCon = new SqlConnection(strCon);
                    SqlCon.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "xoa_kho";
                    command.Connection = SqlCon;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@MAKHO", SqlDbType.VarChar).Value = txtMaKho.Text;
                    command.ExecuteNonQuery();
                    HienThiDanhSach();
                    lammoi();
                    SqlCon.Close();
                    MessageBox.Show("Đã xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    MessageBox.Show("Xóa không thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKho.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKho.Focus();

            }
            else if (Kiemtrathongtin())
            {
                try
                {


                    SqlCon = new SqlConnection(strCon);
                    SqlCon.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "sua_kho";
                    command.Connection = SqlCon;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@MAKHO", SqlDbType.VarChar).Value = txtMaKho.Text;
                    command.Parameters.Add("@TENKHO", SqlDbType.NVarChar).Value = txtTenKho.Text;
                    command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = txtDiaChi.Text;
                    command.ExecuteNonQuery();
                    HienThiDanhSach();
                    lammoi();
                    SqlCon.Close();
                    MessageBox.Show("Đã sửa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    MessageBox.Show("Sửa không thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlCon = new SqlConnection(strCon);
            //    SqlCon.Open();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.CommandText = "timkiem";
            //    cmd.Connection = SqlCon;
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.Add("@MAKHO", SqlDbType.VarChar).Value = txtTimKiem.Text;
            //    DataTable dt = new DataTable();
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    da.Fill(dt);
            //    dataGridView1.DataSource = dt;
            //    SqlCon.Close();
            //}
            //catch
            //{
            //    MessageBox.Show("tìm kiếm không thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //} 
            DataView dataView = new DataView(dataproc);
            dataView.RowFilter = String.Format("[TÊN KHO] like '%{0}%' or [MÃ KHO] like '%{1}%'", txtTimKiem.Text, txtTimKiem.Text);
            dtgv_proc.DataSource = dataView;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            load();


        }
    }
}
