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
        private Boolean kiemTraChuoiMatKhau(string s)
        {
            int demThuong = 0;
            int demHoa = 0;
            int demSo = 0;
            if (s.Length < 8)
            {
                return false;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z')
                {
                    demThuong++;
                }
                if (s[i] >= 'A' && s[i] <= 'Z')
                {
                    demHoa++;
                }
                if (s[i] > '0' && s[i] < '9')
                {
                    demSo++;
                }
            }
            if (demThuong > 0 && demSo > 0 && demHoa > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if(Kiemtra())
            {

                if(kiemTraChuoiMatKhau(txtNewPass.Text) && txtNewPass.Text == txtConfirmPass.Text)
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
                    int result = cmd.ExecuteNonQuery();
                    SqlCon.Close();
                    if (result > 0)
                    {
                        MessageBox.Show("thay đổi thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không tồn tại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else if (txtNewPass.Text != txtConfirmPass.Text)
                {
                    MessageBox.Show("Xác nhận mật khẩu mới chưa chính xác", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Mật khẩu phải có ít nhất 8 kí tự bao gồm 1 chữ Hoa, 1 chữ thường, 1 chữ số", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

        }

        private void checkboxHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxHienThi.Checked)
            {
               txtNewPass.UseSystemPasswordChar = false;
               txtConfirmPass.UseSystemPasswordChar = false;
                txtCurrentPass.UseSystemPasswordChar = false;

            }
            else
            {
                txtNewPass.UseSystemPasswordChar = true;
                txtConfirmPass.UseSystemPasswordChar = true;
                txtCurrentPass.UseSystemPasswordChar = true;
            }
        }

        public bool Kiemtra()
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tên tài khoản", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Focus();
                return false;
            }
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
        }

        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtXacNhanMatKhau_TextChanged(object sender, EventArgs e)
        {
            if(txtConfirmPass.Text != txtNewPass.Text)
            {
                lblConfirm.ForeColor = Color.Black;
                lblConfirm.Text = "✅ invalid";
            }
            else
            {
                lblConfirm.ForeColor = Color.Green;
                lblConfirm.Text = "✅ valid";


            }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
