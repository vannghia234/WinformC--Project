using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace formLogin
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        string conStr = "Data Source=DAICA-ZORO\\MSSQLSERVER01;Initial Catalog=QUANLY_BEAUTY_HEALTH;Integrated Security=True";
        //Data Source=DAICA-ZORO\MSSQLSERVER01;Initial Catalog=QUANLY_BEAUTY_HEALTH;Integrated Security=True

        private void tbAccount_MouseClick(object sender, MouseEventArgs e)
        {
            txt_Account.Text = null;

            if (txt_Password.Text == null || txt_Password.Text == "Mật khẩu")
            {
                txt_Password.Text = null;
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
            if (cbShowPass.Checked == true)
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

        private void bt_Login_Click(object sender, EventArgs e)
        {
            
            this.Size = new Size(770, 479);
            this.StartPosition = FormStartPosition.CenterScreen;
            lbl_Error.Text = "";
            lbl_ErrorPass.Text = "";

            if (kiemTra_UserPass())
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "CHECK_VALID_LOGIN";
                    cmd.Parameters.AddWithValue("@username", txt_Account.Text);
                    cmd.Parameters.AddWithValue("@password", txt_Password.Text);
                    cmd.Connection = conn;
                    object kq = cmd.ExecuteScalar();
                    int code = Convert.ToInt32(kq);
                    FormQuanLy f = new FormQuanLy();
                    this.Hide();
                    f.Show();

                    //                    formStaff fst = new formStaff();
                    //;                    if (code == 1)
                    //                    {
                    //                        MessageBox.Show("Chào mừng bạn đến với giao diện của Quản Lý !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //                        this.Hide();
                    //                        f.Size = new Size(1600, 900);
                    //                        f.Show();
                    //                    }
                    //                    else if (code == 2)
                    //                    {
                    //                        MessageBox.Show("Chào mừng bạn đến với giao diện của Nhân Viên cửa hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //                        this.Hide();
                    //                        fst.Show();
                    //                    }
                    //                    else if (code == 3)
                    //                    {
                    //                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //                        txt_Account.Focus();

                    //                    }
                    //                    else if(code == 4)
                    //                    {
                    //                        MessageBox.Show("Tài khoản bạn nhập không tồn tại trên hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //                        txt_Account.Focus();
                    //                    }
                    conn.Close();
                }
               
                txt_Account.Text = "Tài khoản";
                txt_Password.Text = "Mật khẩu";
                txt_Account.ForeColor = Color.Black;
                txt_Password.ForeColor = Color.Black;
                txt_Account.Focus();
            }
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }





        //TableManager a = new TableManager();
        //this.Hide();
        //a.ShowDialog();
        //this.Show();
        //if (kiemTra_UserPass)
        //txt_Account.Text = "Tài khoản";
        //txt_Password.Text = "Mật khẩu";
        //txt_Account.ForeColor = Color.Black;
        //txt_Password.ForeColor = Color.Black;
        //txt_Account.Focus();


    }
}

