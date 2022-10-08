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
    public partial class formHoaDon : Form
    {

        public formHoaDon()
        {
            InitializeComponent();
        }
        public static string maHD;
        DataTable datagb = new DataTable();
        SqlConnection con;
        string ketnoi = "Data Source=DAICA-ZORO\\MSSQLSERVER01;Initial Catalog=QUANLY_BEAUTY_HEALTH;Integrated Security=True";
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void SQL()
        {
            con = new SqlConnection(ketnoi);
            con.Open();
            string sanpham = "SELECT * FROM HOADON";
            SqlCommand command = new SqlCommand(sanpham, con);
            SqlDataAdapter data = new SqlDataAdapter(command);
            data.Fill(datagb);
            dtgv_Product.DataSource = datagb;
            con.Close();
        }
        private void loadproc()
        {
            con = new SqlConnection(ketnoi);
            con.Open();
            string sanp = "SELECT * FROM HOADON";
            DataTable datab = new DataTable();
            SqlCommand commd = new SqlCommand(sanp, con);
            SqlDataAdapter datt = new SqlDataAdapter(commd);
            datt.Fill(datab);
            dtgv_Product.DataSource = datab;
            con.Close();
        }
        public bool Kiemtra()
        {

            if (cbbmanv.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbmanv.Focus();
                return false;
            }
            if (cbbmakh.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbmakh.Focus();
                return false;
            }
            if (dtpk_NgayLap.Text == "")
            {
                MessageBox.Show("Bạn cần nhập ngày lập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpk_NgayLap.Focus();
                return false;
            }

            //if (numeric.Value == 0)
            //{
            //    MessageBox.Show("Bạn cần nhập mã khuyến mãi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    numeric.Focus();
            //    return false;
            //}
            //if (txtthanhtien.Text == "")
            //{
            //    MessageBox.Show("Bạn cần nhập thành tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtthanhtien.Focus();
            //    return false;
            //}
            //if (txttrangthai.Text == "")
            //{
            //    MessageBox.Show("Bạn cần nhập trạng thái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txttrangthai.Focus();
            //    return false;
            //}

            return true;
        }
        private string RandomHD(int k)
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
        private void reset()
        {
            txtmahd.Text = "";
            cbbmanv.SelectedIndex = -1;
            cbbmakh.SelectedIndex = -1;
            dtpk_NgayLap.Text = "";
            numeric.Value = 0;
            txtthanhtien.Text = "";
            txttrangthai.Text = "";

        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {

                if (cbbmanv.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbbmanv.Focus();

                }
                else if (Kiemtra())
                {

                    txtmahd.Text = RandomHD(8);
                    btnxoa.Enabled = false;
                    con = new SqlConnection(ketnoi);
                    con.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "INSERT_HOADON";
                    command.Connection = con;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@MAHD", SqlDbType.VarChar).Value = txtmahd.Text;
                    command.Parameters.Add("@MANV", SqlDbType.VarChar).Value = cbbmanv.Text;
                    command.Parameters.Add("@MAKH", SqlDbType.VarChar).Value = cbbmakh.Text;
                    command.Parameters.Add("@NGAYLAP", SqlDbType.Date).Value = dtpk_NgayLap.Value.ToString("yyyy-MM-dd");
                    command.Parameters.Add("@KHUYENMAI", SqlDbType.Float).Value = float.Parse(numeric.Value.ToString());
                    command.Parameters.Add("@THANHTIEN", SqlDbType.Money).Value = txtthanhtien.Text;
                    command.Parameters.Add("@TRANGTHAI", SqlDbType.NVarChar).Value = txttrangthai.Text;
                    command.ExecuteNonQuery();
                    loadproc();
                    reset();
                    con.Close();
                    //dtgv_Product.DataSource = datagb;
                    MessageBox.Show("thêm thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("thêm sai dữ liệu" + ex.Message);
            }

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtmahd.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập mã hóa đơn", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmahd.Focus();
                }
                else if (Kiemtra())
                {
                    con = new SqlConnection(ketnoi);
                    con.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "CHANGE_HOAD";
                    command.Connection = con;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@MAHD", SqlDbType.VarChar).Value = txtmahd.Text;
                    command.Parameters.Add("@MANV", SqlDbType.VarChar).Value = cbbmanv.Text;
                    command.Parameters.Add("@MAKH", SqlDbType.VarChar).Value = cbbmakh.Text;
                    command.Parameters.Add("@NGAYLAP", SqlDbType.Date).Value = dtpk_NgayLap.Text;
                    command.Parameters.Add("@KHUYENMAI", SqlDbType.Float).Value = float.Parse(numeric.Value.ToString());
                    command.Parameters.Add("@THANHTIEN", SqlDbType.Money).Value = txtthanhtien.Text;
                    command.Parameters.Add("@TRANGTHAI", SqlDbType.NVarChar).Value = txttrangthai.Text;
                    command.ExecuteNonQuery();
                    loadproc();
                    reset();
                    con.Close();
                    //dtgv_Product.DataSource = datagb;
                    MessageBox.Show("Sửa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa không thành công" + ex.Message);
            }
        }

        private void dtgv_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnCTHD.Enabled = true;
                btnadd.Enabled = false;
                txtmahd.Enabled = false;
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                DataGridViewRow row = new DataGridViewRow();
                row = dtgv_Product.Rows[e.RowIndex];
                txtmahd.Text = Convert.ToString(row.Cells["MAHD"].Value);
                cbbmanv.Text = Convert.ToString(row.Cells["MANV"].Value);
                cbbmakh.Text = Convert.ToString(row.Cells["MAKH"].Value);
                dtpk_NgayLap.Text = Convert.ToString(row.Cells["NGAYLAP"].Value);
                numeric.Value = Convert.ToDecimal(row.Cells["KHUYENMAI"].Value.ToString());
                txtthanhtien.Text = Convert.ToString(row.Cells["THANHTIEN"].Value);
                txttrangthai.Text = Convert.ToString(row.Cells["TRANGTHAI"].Value);
                maHD = row.Cells["MAHD"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmahd.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập mã hóa đơn", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmahd.Focus();
                }
                else if (Kiemtra())
                {
                    btnadd.Enabled = true;
                    btnsua.Enabled = false;
                    txtmahd.Enabled = true;
                    con = new SqlConnection(ketnoi);
                    con.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "DELETE_HOAD";
                    command.Connection = con;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@MAHD", SqlDbType.VarChar).Value = txtmahd.Text;
                    //command.Parameters.Add("@THANHTIEN", SqlDbType.Money).Value = txtthanhtien.Text;
                    //command.Parameters.Add("@TRANGTHAI", SqlDbType.NVarChar).Value = txttrangthai.Text;
                    command.ExecuteNonQuery();
                    loadproc();
                    reset();
                    con.Close();
                    //dtgv_Product.DataSource = datagb;
                    MessageBox.Show("Xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa không thành công" + ex.Message);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            btnadd.Enabled = true;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            txtmahd.Enabled = true;
            reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataView dataView = new DataView(datagb);
            dataView.RowFilter = String.Format("MAHD like '%{0}%' or MAKH like '%{1}%' or MAKH like'%{2}%'", txt_Search.Text, txt_Search.Text, txt_Search.Text);
            dtgv_Product.DataSource = dataView;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void btnCTHD_Click(object sender, EventArgs e)
        {
            formCTHD frm = new formCTHD();
            frm.ShowDialog();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            loadproc();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void formHoaDon_Load(object sender, EventArgs e)
        {
            SQL();
            ////
            con.Open();
            string manv = "SELECT MANV FROM NHANVIEN";
            SqlCommand command = new SqlCommand(manv, con);
            command.Connection = con;
            DataTable nhanvien = new DataTable();
            SqlDataReader dt = command.ExecuteReader();
            nhanvien.Load(dt);
            cbbmanv.DataSource = nhanvien;
            cbbmanv.DisplayMember = "MANV";
            cbbmanv.SelectedIndex = -1;
            con.Close();
            ///
            con.Open();
            string makH = "SELECT MAKH FROM KHACHHANG";
            SqlCommand mand = new SqlCommand(makH, con);
            mand.Connection = con;
            DataTable makhach = new DataTable();
            SqlDataReader data = mand.ExecuteReader();
            makhach.Load(data);
            cbbmakh.DataSource = makhach;
            cbbmakh.DisplayMember = "MAKH";
            cbbmakh.SelectedIndex = -1;
            con.Close();
            ///
            con.Open();
            string maKM = "SELECT KHUYENMAI FROM HOADON";
            SqlCommand comman = new SqlCommand(maKM, con);
            comman.Connection = con;
            DataTable makm = new DataTable();
            SqlDataReader dta = comman.ExecuteReader();
            makm.Load(dta);
            numeric.Value = 1;
            con.Close();
        }
    }
}
