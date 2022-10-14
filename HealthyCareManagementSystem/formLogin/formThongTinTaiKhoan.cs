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
    public partial class formThongTinTaiKhoan : Form
    {
        public formThongTinTaiKhoan()
        {
            InitializeComponent();

        }
        String strCon = "Data Source=DAICA-ZORO\\MSSQLSERVER01;Initial Catalog=QUANLY_BEAUTY_HEALTH;Integrated Security=True";
        SqlConnection SqlCon;
        private void HienThiDanhSach()
        {
            SqlCon = new SqlConnection(strCon);
            SqlCon.Open();
            string sql = "SELECT * FROM TAIKHOAN";
            SqlCommand command = new SqlCommand(sql, SqlCon);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            SqlCon.Close();
            
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tên tài khoản", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Focus();
            } else if(Kiemtra())
            {


                SqlCon = new SqlConnection(strCon);
                SqlCon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = SqlCon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Update_Pass";
                cmd.Parameters.Add("@TAIKHOAN", SqlDbType.NVarChar).Value = txtUserName.Text;
                cmd.Parameters.Add("@MATKHAUCU", SqlDbType.NVarChar).Value = txtCurrentPass.Text;
                cmd.Parameters.Add("@MATKHAUMOI", SqlDbType.NVarChar).Value = txtNewPass.Text;
                cmd.Parameters.Add("@TENTAIKHOAN", SqlDbType.NVarChar).Value = txtFullName.Text;
                cmd.ExecuteNonQuery();
                SqlCon.Close();
                MessageBox.Show("thay đổi thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void checkboxHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxHienThi.Checked)
            {
               txtNewPass.PasswordChar = (char)0;
               txtConfirmPass.PasswordChar = (char)0;
            }
            else
            {
                txtNewPass.PasswordChar = '*';
                txtConfirmPass.PasswordChar = '*';
            }
        }

        public bool Kiemtra()
        {
            if (txtCurrentPass.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCurrentPass.Focus();
                return false;
            }

            if (txtNewPass.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPass.Focus();
                return false;
            }
            if (txtConfirmPass.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConfirmPass.Focus();
                return false;
            }

            return true;
        }
 
        private void txtMatKhauHienTai_TextChanged(object sender, EventArgs e)
        {
           txtCurrentPass.PasswordChar = '*';
        }

        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
        {
           txtNewPass.PasswordChar = '*';
        }

        private void txtXacNhanMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtConfirmPass.PasswordChar = '*';
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void formThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            SqlCon = new SqlConnection(strCon);
            SqlCon.Open();
            string sql = "SELECT * FROM TAIKHOAN";
            SqlCommand command = new SqlCommand(sql, SqlCon);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            SqlCon.Close();
            foreach (DataRow item in dt.Rows)
            {
                try
                {
                    if (item[0].ToString() == formDangNhap.userName)
                    {
                        txtEmail.Text = item[4].ToString();
                        txtFullName.Text = item[2].ToString();
                        txtUserName.Text = item[0].ToString();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
