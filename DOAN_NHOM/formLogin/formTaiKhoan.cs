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
        DataTable dataTable = new DataTable("TAIKHOANUSER");
        // Tạo kết nối
        String sqlconnectstring = @"Data Source=MINATOO;Initial Catalog=QUANLY_BEAUTY_HEALTH;Integrated Security=True";
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

                // Thiết lập bảng trong DataSet ánh xạ tương ứng có tên là TAIKHOANUSER
                adapter.TableMappings.Add("Table", "TAIKHOANUSER");

                // SelectCommand - Thực thi khi gọi Fill lấy dữ liệu về DataSet
                adapter.SelectCommand = new SqlCommand(@"SELECT TAIKHOAN as 'Tài Khoản'  , MATKHAU as 'Mật Khẩu'  , TENTAIKHOAN as 'Tên Tài Khoản' , MALOAI as 'Mã Loại'  FROM TAIKHOANUSER", connection);

                // InsertCommand - Thực khi khi gọi Update, nếu DataSet có chèn dòng mới (vào DataTable)
                // Dữ liệu lấy từ DataTable, như cột Tài Khoản tương  ứng với tham số @TAIKHOAN
                adapter.InsertCommand = new SqlCommand(@"INSERT INTO TAIKHOANUSER (TAIKHOAN , MATKHAU , TENTAIKHOAN , MALOAI) VALUES (@TAIKHOAN , @MATKHAU , @TENTAIKHOAN , @MALOAI)", connection);
                adapter.InsertCommand.Parameters.Add("@TAIKHOAN", SqlDbType.NVarChar, 50, "Tài Khoản");
                adapter.InsertCommand.Parameters.Add("@MATKHAU", SqlDbType.NVarChar, 50, "Mật Khẩu");
                adapter.InsertCommand.Parameters.Add("@TENTAIKHOAN", SqlDbType.NVarChar, 50, "Tên Tài Khoản");
                adapter.InsertCommand.Parameters.Add("@MALOAI", SqlDbType.Int, 255 ,"Mã Loại");

                //TAIKHOAN nvarchar(50)	
                //MATKHAU nvarchar(50)   
                //TENTAIKHOAN nvarchar(50)   
                //MALOAI  int


                // DeleteCommand  - Thực thi khi gọi Update, nếu có remove dòng nào đó của DataTable
                adapter.DeleteCommand = new SqlCommand(@"DELETE FROM TAIKHOANUSER WHERE TAIKHOAN = @TAIKHOAN", connection);
                var pr1 = adapter.DeleteCommand.Parameters.Add(new SqlParameter("@TAIKHOAN", SqlDbType.NVarChar));
                pr1.SourceColumn = "Tài Khoản";
                pr1.SourceVersion = DataRowVersion.Original;  // Giá trị ban đầu


                // UpdateCommand -  Thực thi khi gọi Update, nếu có chỉnh sửa trường dữ liệu nào đó
                adapter.UpdateCommand = new SqlCommand(@"UPDATE TAIKHOANUSER SET MATKHAU=@MATKHAU, TENTAKHOAN = @TENTAIKHOAN, MALOAI = @MALOAI  WHERE TAIKHOAN = @TAIKHOAN", connection);
                adapter.UpdateCommand.Parameters.Add("@MATKHAU", SqlDbType.NVarChar, 50, "Mật Khẩu");
                adapter.UpdateCommand.Parameters.Add("@TENTAIKHOAN", SqlDbType.NVarChar, 50, "Tên Tài Khoản");
                adapter.UpdateCommand.Parameters.Add("@MALOAI", SqlDbType.Int, 255, "Mã Loại");
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
            LoadDataTable();
            dgvAcounts.DataSource = dataTable.DefaultView;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dg = MessageBox.Show("Bạn có muốn lưu lại không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dg == DialogResult.OK)
                {

                    adapter.Update(dataSet);

                    dataTable.Rows.Clear();

                    adapter.Fill(dataSet);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n Không thêm được tài khoản, mời nhập lại.", "tài khoản bị trùng lặp !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
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
                LoadDataTable();
                dgvAcounts.DataSource = dataTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool CheckInfo()
        {
            if (txt_AccountsID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_AccountsID.Focus();
                return false;
            }
            if (txt_AccountName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_AccountName.Focus();
                return false;
            }
            else if (txt_Password.Text == "")
            {
                MessageBox.Show("Vui lòng mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Password.Focus();
                return false;
            }
            else if (txtMaLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập SĐT khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLoai.Focus();
                return false;
            }
            else if (txt_AccountsID.Text == "" && txt_AccountName.Text == "" && txtMaLoai.Text == "" && txt_Password.Text == "")
            {
                MessageBox.Show("Vui lòng điền thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Password.Focus();
                txt_AccountsID.Focus();
                txt_AccountName.Focus();
                txtMaLoai.Focus();
                return false;
            }
            return true;
        }

        private void AddValue()
        {
            DataRow row = dataTable.NewRow();
            row["Tài Khoản"] = txt_AccountsID.Text.ToString();
            row["Tên Tài Khoản"] = txt_AccountName.Text.ToString();
            row["Mã Loại"] = txtMaLoai.Text.ToString();
            row["Mật Khẩu"] = txt_Password.Text.ToString();
            dataTable.Rows.Add(row);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInfo())
                {
                    AddValue();
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
                txtMaLoai.Text = Convert.ToString(row.Cells["Mã Loại"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
