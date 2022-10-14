using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace formLogin
{
    public partial class FormQLNV : Form
    {
        public FormQLNV()
        {
            InitializeComponent();
            
        }
        String strCon = "Data Source=DAICA-ZORO\\MSSQLSERVER01;Initial Catalog=QUANLY_BEAUTY_HEALTH;Integrated Security=True";
        SqlConnection SqlCon;
            DataTable datatable = new DataTable();

        private void HienThiDanhSach()
        {
            SqlCon = new SqlConnection(strCon);
            SqlCon.Open();
            string sql = "SELECT * FROM NHANVIEN";
            SqlCommand command = new SqlCommand(sql, SqlCon);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(datatable);
            dtgv_proc.DataSource = datatable;
            SqlCon.Close();
        }
        private void loadDSNV()
        {
            SqlCon = new SqlConnection(strCon);
            SqlCon.Open();
            string sql = "SELECT * FROM NHANVIEN";
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
        private string RandomNV(int k)
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = false;
            if (Kiemtrathongtin())
            {
                try
                {

                    if (txtSoDienThoai.Text.Length == 10)
                    {
                        txtMaNhanVien.Text = RandomNV(8);
                        btnThem.Enabled = false;
                        btnSua.Enabled = false;
                        SqlCon = new SqlConnection(strCon);
                        SqlCon.Open();
                        SqlCommand command = new SqlCommand();
                        command.CommandText = "them_nhanvien";
                        command.Connection = SqlCon;
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@MANV", SqlDbType.VarChar).Value = txtMaNhanVien.Text;
                        command.Parameters.Add("@TENNV", SqlDbType.NVarChar).Value = txtTenNhanVien.Text;
                        command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = txtSoDienThoai.Text;
                        command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = txtDiaChi.Text;
                        command.ExecuteNonQuery();
                        SqlCon.Close();
                        HienThiDanhSach();
                        lammoi();
                        MessageBox.Show("Đã thêm thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Vui lòng nhập số điện thoại 10 kí tự", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("thêm sai mời nhập lại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public bool Kiemtrathongtin()
        {
            if(txtTenNhanVien.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNhanVien.Focus();
                return false;
            }

            if (txtSoDienThoai.Text == "")
            {
                MessageBox.Show("Bạn cần nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoDienThoai.Focus();
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
        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void lammoi()
        {
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            txtSoDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtTimKiem.Text = "";
        }
     

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            lammoi();
        }

        private void datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnThem.Enabled = false;
                DataGridViewRow row = new DataGridViewRow();
                row = dtgv_proc.Rows[e.RowIndex];
                txtMaNhanVien.Text = Convert.ToString(row.Cells["MANV"].Value);
                txtTenNhanVien.Text = Convert.ToString(row.Cells["TENNV"].Value);
                txtSoDienThoai.Text = Convert.ToString(row.Cells["SDT"].Value);
                txtDiaChi.Text = Convert.ToString(row.Cells["DIACHI"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhanVien.Focus();

            }else if (Kiemtrathongtin())
            {

            
                try
                {


                    SqlCon = new SqlConnection(strCon);
                    SqlCon.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "xoa_nhanvien";
                    command.Connection = SqlCon;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@MANV", SqlDbType.VarChar).Value = txtMaNhanVien.Text;
                    command.ExecuteNonQuery();
                    SqlCon.Close();
                    HienThiDanhSach();
                    lammoi();
                    SqlCon.Close();
                    MessageBox.Show("Đã xóa thành công","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhanVien.Focus();

            }
            else if (Kiemtrathongtin())
            {


                try
                {
                    if (txtSoDienThoai.Text.Length == 10)
                    {



                        SqlCon = new SqlConnection(strCon);
                        SqlCon.Open();
                        SqlCommand command = new SqlCommand();
                        command.CommandText = "sua_nhanvien";
                        command.Connection = SqlCon;
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@MANV", SqlDbType.VarChar).Value = txtMaNhanVien.Text;
                        command.Parameters.Add("@TENNV", SqlDbType.NVarChar).Value = txtTenNhanVien.Text;
                        command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = txtSoDienThoai.Text;
                        command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = txtDiaChi.Text;
                        command.ExecuteNonQuery();
                        SqlCon.Close();
                        HienThiDanhSach();

                        MessageBox.Show("Đã sửa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Vui lòng nhập số điện thoại 10 kí tự", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DataView dataView = new DataView(datatable);
            dataView.RowFilter = String.Format("MANV like '%{0}%' or TENNV like '%{1}%'", txtTimKiem.Text, txtTimKiem.Text);
            dtgv_proc.DataSource = dataView;
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar)&& !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }    
        }

      

        private void FormQLNV_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            loadDSNV();
        }
    }
}
