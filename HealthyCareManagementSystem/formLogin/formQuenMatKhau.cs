using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace formLogin
{
    public partial class formQuenMatKhau : Form
    {
        public formQuenMatKhau()
        {
            InitializeComponent();
            dt = ClassProvider.dataProvider.Instance.GetDatatableByQuery("Select * from TaiKhoan");
        }
        DataTable dt = new DataTable();
        public static string randomCode;
        public static String to;
        public static string email;
        // kiểm tra email trong hệ thống
        private bool checkExistEmail(string email)
        {
            foreach (DataRow item in dt.Rows)
            {
                if (email == item["email"].ToString().Trim())
                {
                    return true;
                }    
                //MessageBox.Show(item["email"].ToString().Trim());
            }
            return false;
        }
    
        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (checkExistEmail(txtEmail.Text.Trim()) && txtEmail.Text != "")
            {
                email = txtEmail.Text;
              
                String from, pass, messageBody;
                Random rand = new Random();
                randomCode = (rand.Next(10000, 100000)).ToString();
                MailMessage message = new MailMessage();
                to = (txtEmail.Text).ToString();
                from = "nghiazorovn2304@gmail.com";
                pass = "nxjuwfxyvnqgfaaa";
                messageBody = "Xin chào,\r\nChúng tôi đã nhận được yêu cầu đặt lại mật khẩu HealthyCare của bạn.\r\nNhập mã đặt lại mật khẩu sau đây: \n " + randomCode;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = randomCode + " là mã khôi phục tài khoản HealthyCare của bạn";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                
                try
                {
                    smtp.Send(message);
                    formXacNhanQuenMatKhau fxn = new formXacNhanQuenMatKhau();
                    fxn.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                lblError.Text = "Email này không tồn tại trong hệ thống";
                txtEmail.Focus();
                txtEmail.Text = "";

            }


        }

        private void formQuenMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void lblTilte_Click(object sender, EventArgs e)
        {

        }

        private void iconPic_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool checkMailValid(string email)
        {
            //return Regex.IsMatch(email, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
            return Regex.IsMatch(email, @"^\w{3,20}@gmail.com$");


        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!checkMailValid(txtEmail.Text))
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
