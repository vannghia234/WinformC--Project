using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace formLogin
{
    public partial class formTaiKhoan : Form
    {
        DataTable dataTable = new DataTable("TAIKHOAN");
        // Tạo kết nối
        String sqlconnectstring = "Data Source=DAICA-ZORO\\MSSQLSERVER01;Initial Catalog=QUANLY_BEAUTY_HEALTH;Integrated Security=True";
        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet dataSet = new DataSet();


        public formTaiKhoan()
        {
            InitAdapter(); 

            InitializeComponent();
 
        }

        private void InitAdapter()
        {
            connection = new SqlConnection(sqlconnectstring);
            
            try
            {
                connection.Open();

                // Thiết lập bảng trong DataSet ánh xạ tương ứng có tên là TAIKHOAN
                adapter.TableMappings.Add("Table", "TAIKHOAN");

                // SelectCommand - Thực thi khi gọi Fill lấy dữ liệu về DataSet
                adapter.SelectCommand = new SqlCommand(@"SELECT TAIKHOAN as 'Tài Khoản'  , MATKHAU as 'Mật Khẩu'  , TENTAIKHOAN as 'Tên Tài Khoản' , MALOAI as 'Mã Loại' , EMAIL as 'Email'  FROM TAIKHOAN", connection);

                // InsertCommand - thực thi khi gọi Update, nếu DataSet có chèn dòng mới (vào DataTable)
                // Dữ liệu lấy từ DataTable, như cột Tài Khoản tương  ứng với tham số @TAIKHOAN
                adapter.InsertCommand = new SqlCommand(@"INSERT INTO TAIKHOAN (TAIKHOAN , MATKHAU , TENTAIKHOAN , MALOAI , EMAIL) VALUES (@TAIKHOAN , @MATKHAU , @TENTAIKHOAN , @MALOAI , @EMAIL)", connection);
                adapter.InsertCommand.Parameters.Add("@TAIKHOAN", SqlDbType.NVarChar, 50, "Tài Khoản");
                adapter.InsertCommand.Parameters.Add("@MATKHAU", SqlDbType.NVarChar, 50, "Mật Khẩu");
                adapter.InsertCommand.Parameters.Add("@TENTAIKHOAN", SqlDbType.NVarChar, 50, "Tên Tài Khoản");
                adapter.InsertCommand.Parameters.Add("@MALOAI", SqlDbType.Int, 255 ,"Mã Loại");
                adapter.InsertCommand.Parameters.Add("@EMAIL", SqlDbType.VarChar, 50, "Email");

                // DeleteCommand  - Thực thi khi gọi Update, nếu có remove dòng nào đó của DataTable
                adapter.DeleteCommand = new SqlCommand(@"DELETE FROM TAIKHOAN WHERE TAIKHOAN = @TAIKHOAN", connection);
                var pr1 = adapter.DeleteCommand.Parameters.Add(new SqlParameter("@TAIKHOAN", SqlDbType.NVarChar));
                pr1.SourceColumn = "Tài Khoản"; 
                pr1.SourceVersion = DataRowVersion.Original;  // Giá trị ban đầu

                // UpdateCommand -  Thực thi khi gọi Update, nếu có chỉnh sửa trường dữ liệu nào đó
                adapter.UpdateCommand = new SqlCommand(@"UPDATE TAIKHOAN SET MATKHAU=@MATKHAU, TENTAIKHOAN = @TENTAIKHOAN, MALOAI = @MALOAI, EMAIL = @EMAIL  WHERE TAIKHOAN = @TAIKHOAN", connection);
                adapter.UpdateCommand.Parameters.Add("@MATKHAU", SqlDbType.NVarChar, 50, "Mật Khẩu");
                adapter.UpdateCommand.Parameters.Add("@TENTAIKHOAN", SqlDbType.NVarChar, 50, "Tên Tài Khoản"); 
                adapter.UpdateCommand.Parameters.Add("@MALOAI", SqlDbType.Int, 255, "Mã Loại");
                adapter.UpdateCommand.Parameters.Add("@EMAIL", SqlDbType.VarChar, 50, "Email"); 
                var pr2 = adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TAIKHOAN", SqlDbType.NVarChar) { SourceColumn = "Tài khoản" });
                pr2.SourceVersion = DataRowVersion.Original;
                dataSet.Tables.Add(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void LoadDataTable()
        {
            dataTable.Rows.Clear();
            adapter.Fill(dataSet);
        }

        private void formTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLY_BEAUTY_HEALTHDataSet3.LOAITAIKHOAN' table. You can move, or remove it, as needed.
            this.lOAITAIKHOANTableAdapter.Fill(this.qUANLY_BEAUTY_HEALTHDataSet3.LOAITAIKHOAN);
            // TODO: This line of code loads data into the 'qUANLY_BEAUTY_HEALTHDataSet2.TAIKHOAN' table. You can move, or remove it, as needed.
            this.tAIKHOANTableAdapter1.Fill(this.qUANLY_BEAUTY_HEALTHDataSet2.TAIKHOAN);
            // TODO: This line of code loads data into the 'qUANLY_BEAUTY_HEALTHDataSet1.TAIKHOAN' table. You can move, or remove it, as needed.
            this.tAIKHOANTableAdapter.Fill(this.qUANLY_BEAUTY_HEALTHDataSet1.TAIKHOAN);
            pnlNhap.Enabled = false;
            btn_Add.Enabled = true;
            btn_Delete.Enabled = false; 
            btnFix.Enabled = false; 
            btnSave.Enabled = false;    
            LoadDataTable();
            dgvAcounts.DataSource = dataTable.DefaultView;

        }

        private void Reset()
        {
            lbShowText.Text = "";
            txtEmail.Text = "";
            cmbMaLoai.Text = "";
            txt_AccountName.Text = "";
            txt_AccountsID.Text = "";
            txt_Password.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave.Enabled = false;
                btnFix.Enabled = false;
                btn_Delete.Enabled=false;
                btn_Add.Enabled = false;
                DialogResult dg = MessageBox.Show("Bạn có muốn lưu lại không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dg == DialogResult.OK)
                {

                    adapter.Update(dataSet);

                    dataTable.Rows.Clear();

                    adapter.Fill(dataSet);

                    MessageBox.Show("Lưu thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave.Enabled = true;
                foreach (DataGridViewRow item in this.dgvAcounts.SelectedRows)
                {
                    DialogResult dg = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dg == DialogResult.OK)
                    {
                        dgvAcounts.Rows.RemoveAt(item.Index);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);       
            }          
        }            
                    
        private void btnShow_Click(object sender, EventArgs e)
        {                                                                         
            try             
            {
                lbShowText.Enabled = false;
                pnlNhap.Enabled = true;
                btn_Add.Enabled = true;
                btn_Delete.Enabled = false;
                btnFix.Enabled = false; 
                btnSave.Enabled = false;
                Reset();
                LoadDataTable();      
                dgvAcounts.DataSource = dataTable.DefaultView;                                                                                                                                                                                                                  
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                       }

        public bool CheckInfo()
        {
            if (txt_AccountsID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_AccountsID.Focus();
                return false;
            }
            else if (txt_Password.Text == "")
            {
                MessageBox.Show("Vui lòng mật khẩu tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Password.Focus();
                return false;
            }

            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Email tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return false;
            }

            if (txt_AccountName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); MessageBox.Show("Vui lòng nhập tên tài khoản khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_AccountName.Focus();
                return false;
            }

            else if (cmbMaLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã loại tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMaLoai.Focus();
                return false;
            }
            
            return true;
        }

        private void AddValue()
        {
            
            DataRow row = dataTable.NewRow();
            row["Tài Khoản"] = txt_AccountsID.Text.ToString();
            row["Tên Tài Khoản"] = txt_AccountName.Text.ToString();
            row["Mã Loại"] = cmbMaLoai.Text.ToString();
            row["Mật Khẩu"] = txt_Password.Text.ToString();
            row["Email"] = txtEmail.Text.ToString();
            dataTable.Rows.Add(row);
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            try
            {
                if (pnlNhap.Enabled == false)
                {
                    pnlNhap.Enabled = true;
                    return;
                }
                else
                {
                    if (CheckInfo())
                    {
                        AddValue();
                        btn_Add.Enabled = false;
                        btnSave.Enabled = true;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAcounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvAcounts.Rows[e.RowIndex];
                txt_AccountsID.Text = Convert.ToString(row.Cells["Tài Khoản"].Value);
                txt_Password.Text = Convert.ToString(row.Cells["Mật Khẩu"].Value);
                txt_AccountName.Text = Convert.ToString(row.Cells["Tên tài Khoản"].Value);
                cmbMaLoai.Text = Convert.ToString(row.Cells["Mã Loại"].Value);
                txtEmail.Text = Convert.ToString(row.Cells["Email"].Value);

                btn_Add.Enabled = false;
                btnFix.Enabled = true;
                btn_Delete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FixValue()
        {
            try
            {
                DialogResult dg = MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dg == DialogResult.OK)
                {
                    int VT = dgvAcounts.CurrentCell.RowIndex;
                    DataRow rowedit = dataTable.Rows[VT];
                    rowedit["Tài Khoản"] = txt_AccountsID.Text;
                    rowedit["Mật Khẩu"] = txt_Password.Text;
                    rowedit["Tên Tài Khoản"] = txt_AccountName.Text;
                    rowedit["Mã Loại"] = cmbMaLoai.Text;
                    rowedit["Email"] = txtEmail.Text;
                    
                }   
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            FixValue();
        }

        private bool kiemTraChuoiMatKhau(string s)
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

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            if (kiemTraChuoiMatKhau(txt_Password.Text) == true)
            {
                lbShowText.ForeColor = Color.Green;
                lbShowText.Text = "Bạn đã nhập đúng các điều kiện";
            }
            else
            {
                lbShowText.ForeColor = Color.Red;
                lbShowText.Text = "Bạn đã nhập sai các điều kiện";
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dg == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                DataView data = new DataView(dataTable);
                data.RowFilter = String.Format("[Tài Khoản] like '%{0}%' or [Tên Tài Khoản] like '%{1}%'", txt_Search.Text, txt_Search.Text);
                dgvAcounts.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            dgvAcounts.DataSource = dataTable.DefaultView;
        }

        private void ckbPass_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbPass.Checked)
            {
                txt_Password.UseSystemPasswordChar = false;
            }    
            else
            {
                txt_Password.UseSystemPasswordChar = true;
            }    
        }
    }
}