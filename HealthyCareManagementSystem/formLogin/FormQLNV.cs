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
using System.Windows.Forms;

namespace formLogin
{
    public partial class FormQLNV : Form
    {
        public FormQLNV()
        {
            InitializeComponent();
            
        }
        String strCon = "Data Source=LAPTOP-RB6DNAEA\\SQLEXPRESS;Initial Catalog=QUANLY_BEAUTY_HEALTH;Integrated Security=True";
        SqlConnection SqlCon;
        private void HienThiDanhSach()
        {
            SqlCon = new SqlConnection(strCon);
            SqlCon.Open();
            string sql = "SELECT * FROM NHANVIEN";
            SqlCommand command = new SqlCommand(sql, SqlCon);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            datagridview.DataSource = dt;
            SqlCon.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
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
                        btnXoa.Enabled = false;
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
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            lammoi();
        }

        private void datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            DataGridViewRow row = new DataGridViewRow();
            row = datagridview.Rows[e.RowIndex];
            txtMaNhanVien.Text = Convert.ToString(row.Cells["MANV"].Value);
            txtTenNhanVien.Text = Convert.ToString(row.Cells["TENNV"].Value);
            txtSoDienThoai.Text = Convert.ToString(row.Cells["SDT"].Value);
            txtDiaChi.Text = Convert.ToString(row.Cells["DIACHI"].Value);
            
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
                        lammoi();
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
            try
            {
                SqlCon = new SqlConnection(strCon);
                SqlCon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "timkiem";
                cmd.Connection = SqlCon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = txtTimKiem.Text;
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                datagridview.DataSource = dt;
                SqlCon.Close();
            }
            catch
            {
                MessageBox.Show("tìm kiếm không thành công","thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);  
            }
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar)&& !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }    
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
