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
    public partial class formDangNhap : Form
    {
        public formDangNhap()
        {
            InitializeComponent();
        }

        private void tbAccount_MouseClick(object sender, MouseEventArgs e)
        {
            txt_Account.Text = "";

            if (txt_Password.Text == "" || txt_Password.Text == "Mật khẩu")
            {
                txt_Password.Text = "";
                txt_Account.ForeColor = Color.Black;
            }
        }

        private void tbpassword_MouseClick(object sender, MouseEventArgs e)
        {
            txt_Password.Text = null;
            txt_Password.ForeColor = Color.Black;

        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ShowPass.Checked == true)
            {
                txt_Password.PasswordChar = (char)0;
            }
            else
            {
                txt_Password.PasswordChar = '*';

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }


        private void tbAccount_KeyDown(object sender, KeyEventArgs e)
        {
            txt_Account.ForeColor = Color.Black;
            string t = txt_Account.Text;
            txt_Account.ForeColor = Color.Black;

            if (t.Equals("Tài khoản"))
            {
                txt_Account.Clear();
            }
            if (txt_Password.Text == "Mật khẩu")
                txt_Password.Clear();

        }
        // kiểm tra tài khoản mật khẩu
        private bool kiemTra_UserPass()
        {
            lbl_Error.Visible = true;
            lbl_ErrorPass.Visible = true;
            string user = txt_Account.Text;
            string pass = txt_Password.Text;
            if (string.IsNullOrEmpty(user) && string.IsNullOrEmpty(pass))
            {
                //MessageBox.Show("Vui lòng nhập tài khoản & mật khẩu", "Thông báo");
                lbl_Error.Text = "Vui lòng nhập tài khoản và mật khẩu";
                lbl_ErrorPass.Text = "Vui lòng nhập tài khoản và mật khẩu";
                txt_Account.Focus();
                return false;
            }
            else if (user.Equals("Tài khoản") && pass.Equals("Mật khẩu"))
            {
                //MessageBox.Show("Vui lòng nhập tài khoản & mật khẩu", "Thông báo");
                lbl_Error.Text = "Vui lòng nhập tài khoản và mật khẩu";
                lbl_ErrorPass.Text = "Vui lòng nhập tài khoản và mật khẩu";
                txt_Account.Focus();
                return false;

            }
            else if (string.IsNullOrEmpty(user) || user == "Tài khoản")
            {
                //MessageBox.Show("Bạn chưa nhập tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK);
                lbl_Error.Text = "Vui lòng nhập tài khoản";
                txt_Account.Focus();
                return false;

            }
            else if (string.IsNullOrEmpty(pass) || pass == "Mật khẩu")
            {
                lbl_ErrorPass.Text = "Vui lòng nhập mật khẩu";
                txt_Password.Focus();
                return false;


            }
            else if (user.Equals("Tài khoản") || pass.Equals("Mật khẩu"))
            {
                //MessageBox.Show("Bạn chưa nhập tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK);
                lbl_Error.Text = "bạn chưa nhập tài khoản hoặc mật khẩu";
                txt_Account.Focus();
                return false;


            }
            return true;


        }



        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cb_SavePassword_CheckedChanged(object sender, EventArgs e)
        {
            if ((txt_Account.Text != "" && txt_Password.Text != "") || txt_Account.Text != "Tài khoản" && txt_Password.Text != "Mật khẩu")
            {
                if (cb_SavePassword.Checked)
                {
                    string user = txt_Account.Text;
                    string pass = txt_Password.Text;
                    Properties.Settings.Default.username = user;
                    Properties.Settings.Default.password = pass;
                    Properties.Settings.Default.Save();
                }
                else if (cb_SavePassword.Checked == false)
                {
                    Properties.Settings.Default.Reset();
                }
            }
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.username == "" || Properties.Settings.Default.password == "")
            {
                txt_Account.Text = "Tài khoản";
                txt_Password.Text = "Mật khẩu";

            }
            else
            {
                txt_Account.Text = Properties.Settings.Default.username;
                txt_Password.Text = Properties.Settings.Default.password;
            }


            if (Properties.Settings.Default.username != "")
            {
                cb_SavePassword.Checked = true;
            }
            else
                cb_SavePassword.Checked = false;
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
        private void bt_Login_Click(object sender, EventArgs e)
        {
            lbl_Error.Text = "";
            lbl_ErrorPass.Text = "";

            if (kiemTra_UserPass())
            {
                if (kiemTraChuoiMatKhau(txt_Password.Text))
                {
                    using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.Constr))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "CHECK_LOGIN";
                        cmd.Parameters.AddWithValue("@username", txt_Account.Text);
                        cmd.Parameters.AddWithValue("@pass", txt_Password.Text);
                        cmd.Connection = conn;

                        object kq = cmd.ExecuteScalar();
                        int code = Convert.ToInt32(kq);
                        if (code == 1)
                        {
                            formProgressbarQL p = new formProgressbarQL();
                            this.Hide();
                            p.Show();
                            //MessageBox.Show("Chào mừng bạn đến với giao diện của Quản Lý !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //this.Hide();
                            //f.Show();
                        }
                        else if (code == 2)
                        {
                            formProgressBarNV pgnv = new formProgressBarNV();
                            this.Hide();
                            pgnv.Show();
                            //fst.Show();
                        }
                        else if (code == 3)
                        {
                            MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_Account.Focus();

                        }
                        else if (code == 4)
                        {
                            MessageBox.Show("Tài khoản bạn nhập không tồn tại trên hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_Account.Focus();
                        }
                        conn.Close();
                    }
                }
                else
                {
                    lbl_ErrorPass.Text = "Mật khẩu của bạn phải có ít nhất 8 ký tự bao gồm 1 ký tự Hoa, 1 thường, 1 số";
                }


                txt_Account.Text = "Tài khoản";
                txt_Password.Text = "Mật khẩu";
                txt_Account.ForeColor = Color.Black;
                txt_Password.ForeColor = Color.Black;
                txt_Account.Focus();
            }
        }

        private void iconPic_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void formDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ok = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel);
            if (ok == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {
            
            if (Properties.Settings.Default.username == "" || Properties.Settings.Default.password == "")
            {
                txt_Account.Text = "Tài khoản";
                txt_Password.Text = "Mật khẩu";

            }
            else
            {
                txt_Account.ForeColor = Color.Black;
                txt_Password.ForeColor = Color.Black;

                txt_Account.Text = Properties.Settings.Default.username;
                txt_Password.Text = Properties.Settings.Default.password;
            }


            if (Properties.Settings.Default.username != "")
            {
                cb_SavePassword.Checked = true;
            }
            else
                cb_SavePassword.Checked = false;
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            txt_Password.PasswordChar = '*';
        }

        private void lbl_QuenPass_Click(object sender, EventArgs e)
        {
            formQuenMatKhau qmk = new formQuenMatKhau();
            qmk.Show();
        }
    }
}
