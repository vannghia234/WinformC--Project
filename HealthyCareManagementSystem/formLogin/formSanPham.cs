using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formLogin
{
    public partial class formSanPham : Form
    {

        public formSanPham()
        {
            InitializeComponent();

        }
        //private string masp;
       
        DataTable datagb = new DataTable();
        SqlConnection con;
        string ketnoi = "Data Source=DAICA-ZORO\\MSSQLSERVER01;Initial Catalog=QUANLY_BEAUTY_HEALTH;Integrated Security=True";
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void loadProduct()
        {
            DataTable dataTable = new DataTable();
            con = new SqlConnection(ketnoi);
            con.Open();
            string sanpham = "SELECT * FROM SANPHAM";
            SqlCommand command = new SqlCommand(sanpham, con);
            SqlDataAdapter data = new SqlDataAdapter(command);
            data.Fill(dataTable);
            dtgv_Product.DataSource = dataTable;
            con.Close();
        }
        private void SQL()
        {
            con = new SqlConnection(ketnoi);
            con.Open();
            string sanpham = "SELECT MASP [MÃ SẢN PHẨM], TENSP [TÊN SẢN PHẨM], GIATIEN [GIÁ], DONVITINH [ĐƠN VỊ TÍNH], HANSUDUNG [HSD], SOLUONGTON [SỐ LƯỢNG TỒN], MAKHO [MÃ KHO], MALOAI [MÃ LOẠI] FROM SANPHAM";
            SqlCommand command = new SqlCommand(sanpham, con);
            SqlDataAdapter data = new SqlDataAdapter(command);
            data.Fill(datagb);
            dtgv_Product.DataSource = datagb;
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            
            SQL();
            ///
            con.Open();
            string mak = "SELECT MAKHO FROM KHO";
            SqlCommand command = new SqlCommand(mak, con);
            command.Connection = con;
            DataTable makho = new DataTable();
            SqlDataReader dt = command.ExecuteReader();
            makho.Load(dt);
            cbbmakho.DataSource = makho;
            cbbmakho.DisplayMember = "MAKHO";
            cbbmakho.SelectedIndex = -1;
            con.Close();
            ///
            con.Open();
            string mal = "SELECT MALOAI FROM LOAISANPHAM";
            SqlCommand cmd = new SqlCommand(mal, con);
            cmd.Connection = con;
            DataTable maloai = new DataTable();
            SqlDataReader data = cmd.ExecuteReader();
            maloai.Load(data);
            cbbmaloai.DataSource = maloai;
            cbbmaloai.DisplayMember = "MALOAI";
            cbbmaloai.SelectedIndex = -1;
            con.Close();
            ///
            con = new SqlConnection(ketnoi);
            con.Open();
            string danh = "SELECT * FROM DANHMUC";
            SqlCommand comm = new SqlCommand(danh, con);
            comm.Connection = con;
            DataTable danhmuc = new DataTable();
            SqlDataReader dm = comm.ExecuteReader();
            danhmuc.Load(dm);
            foreach (DataRow item in danhmuc.Rows)
            {
                cbbdanhmuc.Items.Add(item["TENDANHMUC"].ToString());
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void txttensp_TextChanged(object sender, EventArgs e)
        {

        }
        private void reset()
        {
            txtmasp.Text = "";
            txttensp.Text = "";
            txtgia.Text = "";
            txthsd.Text = "";
            txtsoluong.Text = "";
            cbbmakho.SelectedIndex = -1;
            cbbmaloai.SelectedIndex = -1;
            
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnFix.Enabled = false;
            btn_Add.Enabled = true;
            txtmasp.Enabled = true;
            reset();
        }

        private void cbbmaloai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        public bool Kiemtra()
        {
            if (txttensp.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttensp.Focus();
                return false;
            }
            if (txtgia.Text == "")
            {
                MessageBox.Show("Bạn cần nhập giá sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtgia.Focus();
                return false;
            }
            if (txthsd.Text == "")
            {
                MessageBox.Show("Bạn cần nhập hạn sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdvt.Focus();
                return false;
            }

            if (txtsoluong.Text == "")
            {
                MessageBox.Show("Bạn cần nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluong.Focus();
                return false;
            }
            if (cbbmakho.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbmakho.Focus();
                return false;
            }
            if (cbbmaloai.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbmaloai.Focus();
                return false;
            }

            return true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            txtmasp.Text = RandomSP(8);

            try
            {
                if (panel1.Enabled == false)
                {
                    panel1.Enabled=true;
                    return;
                }
                else
                {
                    if (Kiemtra())
                    {
                        btnFix.Enabled = false;
                        btnDelete.Enabled = false;
                        con = new SqlConnection(ketnoi);
                        con.Open();
                        SqlCommand command = new SqlCommand();
                        command.CommandText = "INSERT_SANPHAM";
                        command.Connection = con;
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@MASP", SqlDbType.VarChar).Value = txtmasp.Text;
                        command.Parameters.Add("@TENSP", SqlDbType.NVarChar).Value = txttensp.Text;
                        command.Parameters.Add("@GIATIEN", SqlDbType.Money).Value = txtgia.Text;
                        command.Parameters.Add("@DONVITINH", SqlDbType.NVarChar).Value = txtdvt.Text;
                        command.Parameters.Add("@HANSUDUNG", SqlDbType.Date).Value = txthsd.Text;
                        command.Parameters.Add("@SOLUONGTON", SqlDbType.Int).Value = Convert.ToInt32(txtsoluong.Text);
                        command.Parameters.Add("@MAKHO", SqlDbType.VarChar).Value = cbbmakho.Text;
                        command.Parameters.Add("@MALOAI", SqlDbType.VarChar).Value = cbbmaloai.Text;
                        command.ExecuteNonQuery();
                        con.Close();
                        loadProduct();
                        //dtgv_Product.DataSource = datagb;
                        reset();
                        MessageBox.Show("thêm thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("thêm sai dữ liệu" + ex.Message);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            btnFix.Enabled = false;
            txtmasp.Enabled = true;
            btn_Add.Enabled = true;
            btnSave.Enabled = false;
            try
            {

                if (txtmasp.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập mã sản phẩm", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtmasp.Focus();
                }
                else if (Kiemtra())
                {
                    con = new SqlConnection(ketnoi);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "DELETE_SP";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MASP", SqlDbType.VarChar).Value = txtmasp.Text;
                    cmd.ExecuteNonQuery();
                    loadProduct();
                    reset();
                    con.Close();
                    MessageBox.Show("xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("xóa không thành công" + ex.Message);
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dataView = new DataView(datagb);
                dataView.RowFilter = String.Format("TENSP like '%{0}%' or MASP like '%{1}%'", txt_Search.Text, txt_Search.Text);
                dtgv_Product.DataSource = dataView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


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

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmasp.Text == "")
                {

                    MessageBox.Show("Bạn cần nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtmasp.Focus();
                }
                else if (Kiemtra())
                {

                    con = new SqlConnection(ketnoi);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "CHANGE_SANPHAM";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MASP", SqlDbType.VarChar).Value = txtmasp.Text;
                    cmd.Parameters.Add("@TENSP", SqlDbType.NVarChar).Value = txttensp.Text;
                    cmd.Parameters.Add("@GIATIEN", SqlDbType.Money).Value = txtgia.Text;
                    cmd.Parameters.Add("@DONVITINH", SqlDbType.NVarChar).Value = txtdvt.Text;
                    cmd.Parameters.Add("@HANSUDUNG", SqlDbType.Date).Value = txthsd.Text;
                    cmd.Parameters.Add("@SOLUONGTON", SqlDbType.Int).Value = Convert.ToInt32(txtsoluong.Text);
                    cmd.Parameters.Add("@MAKHO", SqlDbType.VarChar).Value = cbbmakho.Text;
                    cmd.Parameters.Add("@MALOAI", SqlDbType.VarChar).Value = cbbmaloai.Text;
                    cmd.ExecuteNonQuery();
                    reset();
                    loadProduct();
                    con.Close();
                    MessageBox.Show("sửa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("sửa không thành công" + ex.Message);

            }

        }

        private void addRow(DataTable data)
        {
            DataRow dataRow = data.NewRow();
            data.Rows.Add(dataRow);

        }
        private void btnLUU_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave.Enabled = true;
                btnFix.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                DataTable dataTable = (DataTable)dtgv_Product.DataSource;
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = txtmasp.Text;
                dataRow[1] = txttensp.Text;
                dataRow[2] = float.Parse(txtgia.Text);
                dataRow[3] = txtdvt.Text;
                dataRow[4] = txthsd.Text;
                dataRow[5] = txtsoluong.Text;
                dataRow[6] = cbbmakho.Text;
                dataRow[7] = cbbmaloai.Text;
                MessageBox.Show("Lưu thành công");
                dataTable.Rows.Add(dataRow);
                dataTable.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu không thành công" + ex.Message);
            }

        }







        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }


        private void dtgv_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnSave.Enabled = false;
                btn_Add.Enabled = false;
                txtmasp.Enabled = false;
                btnFix.Enabled = true;
                btnDelete.Enabled = true;
                DataGridViewRow row = new DataGridViewRow();
                row = dtgv_Product.Rows[e.RowIndex];
                txtmasp.Text = Convert.ToString(row.Cells[0].Value);
                txttensp.Text = Convert.ToString(row.Cells[1].Value);
                txtgia.Text = Convert.ToString(row.Cells[2].Value);
                txtdvt.Text = Convert.ToString(row.Cells[3].Value);
                txthsd.Text = Convert.ToString(row.Cells[4].Value);
                txtsoluong.Text = Convert.ToString(row.Cells[5].Value);
                cbbmakho.Text = Convert.ToString(row.Cells[6].Value);
                cbbmaloai.Text = Convert.ToString(row.Cells[7].Value);
                //cbbdanhmuc.Text = Convert.ToString(row.Cells["TENDM"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbdanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbbdanhmuc.SelectedIndex;
            string nameDM = cbbdanhmuc.Items[i].ToString();

                con = new SqlConnection(ketnoi);
                DataTable dt = new DataTable();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TIM_DANHMUC";
                cmd.Connection = con;
                cmd.Parameters.Add("@TENDM", SqlDbType.NVarChar).Value = nameDM;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                da.Fill(dt);
                con.Close();
                dtgv_Product.DataSource = dt;
            

        }

        private void btn_Cart_Click(object sender, EventArgs e)
        {
            loadProduct();
        }

       
    }
}
