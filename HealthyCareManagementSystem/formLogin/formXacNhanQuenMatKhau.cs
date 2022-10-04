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
     
        private void rjButton2_Click(object sender, EventArgs e)
        {
            if (checkRong())
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
            
        }

        private void iconPic_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

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
        
    }
}
