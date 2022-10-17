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
    public partial class formXacNhanQuenMatKhau : Form
    {
        public formXacNhanQuenMatKhau()
        {
            InitializeComponent();
        }

      
        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool checkReEnterPass()
        {
            if (txtReEnterPass.Text != txtNewPass.Text)
            {
                lblError.Text = "Nhập lại mật khẩu không đúng";
                return false;
            }
            return true;
        }
        private bool checkRong()
        {
            if(txtcode.Text == "")
            {
                lblError.Text = "Chưa nhập mã xác nhận";
                txtcode.Focus();
                return false;
            }
            else if (txtNewPass.Text == "")
            {
                lblError.Text = "Chưa nhập mật khẩu mới";
                txtNewPass.Focus();
                return false;

            }
            else if (txtReEnterPass.Text == "")
            {
                lblError.Text = "Chưa nhập lại mật khẩu xác nhận";
                txtReEnterPass.Focus();
                return false;

            }
            return true;
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
        private void rjButton2_Click(object sender, EventArgs e)
        {
            if (checkRong())
            {
                if (kiemTraChuoiMatKhau(txtNewPass.Text))
                {
                    if (txtcode.Text.Trim() == formQuenMatKhau.randomCode)
                    {
                        if (checkReEnterPass())
                        {
                            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.Constr))
                            {
                                conn.Open();
                                SqlCommand cmd = new SqlCommand("Update_MK", conn);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add("@MATKHAUMOI", SqlDbType.NVarChar).Value = txtNewPass.Text.Trim();
                                cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = formQuenMatKhau.email;

                                cmd.ExecuteNonQuery();
                                conn.Close();
                                MessageBox.Show("Thay đổi mật khẩu thành công");
                            }
                        }
                    }
                    else
                    {
                        lblError.Text = "Mã xác nhận không chính xác";
                    }

                }
                else
                {
                    lblError.Text = "Mật khẩu của bạn phải có ít nhất 8 ký tự bao gồm 1 ký tự Hoa, 1 thường, 1 số";
                }

            }
            
        }

        private void iconPic_Exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            txtNewPass.PasswordChar = (char)0;
            txtReEnterPass.PasswordChar = (char)0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtNewPass.PasswordChar = (char)0;
                txtReEnterPass.PasswordChar = (char)0;
            }
            else if(checkBox1.Checked == false)
            {
                txtNewPass.PasswordChar = '*';
                txtReEnterPass.PasswordChar = '*';
            }
        }

        private void txtReEnterPass_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPass.Text != txtReEnterPass.Text)
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
    }
}
