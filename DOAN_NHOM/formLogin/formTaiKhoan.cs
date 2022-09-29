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

                // Thiết lập bảng trong DataSet ánh xạ tương ứng có tên là TAIKHOAN
                adapter.TableMappings.Add("Table", "TAIKHOAN");

                // SelectCommand - Thực thi khi gọi Fill lấy dữ liệu về DataSet
                adapter.SelectCommand = new SqlCommand(@"SELECT TAIKHOAN as 'Tài Khoản'  , MATKHAU as 'Mật Khẩu'  , TENTAIKHOAN as 'Tên Tài Khoản' , MALOAI as 'Mã Loại'  FROM TAIKHOAN", connection);

                // InsertCommand - Thực khi khi gọi Update, nếu DataSet có chèn dòng mới (vào DataTable)
                // Dữ liệu lấy từ DataTable, như cột Tài Khoản tương  ứng với tham số @TAIKHOAN
                adapter.InsertCommand = new SqlCommand(@"INSERT INTO KHACHHANG (TAIKHOAN , MATKHAU , TENTAIKHOAN , MALOAI) VALUES (@MATKHAU , @MATKHAU , @TENTAIKHOAN , @MALOAI)", connection);
                adapter.InsertCommand.Parameters.Add("@TAIKHOAN", SqlDbType.NVarChar, 50, "Tài Khoản");
                adapter.InsertCommand.Parameters.Add("@MATKHAU", SqlDbType.NVarChar, 50, "Mật Khẩu");
                adapter.InsertCommand.Parameters.Add("@TENTAIKHOAN", SqlDbType.NVarChar, 50, "Tên Tài Khoản");
                adapter.InsertCommand.Parameters.Add("@MALOAI", SqlDbType.Int, 255 ,"Mã Loại");

                //TAIKHOAN nvarchar(50)	
                //MATKHAU nvarchar(50)   
                //TENTAIKHOAN nvarchar(50)   
                //MALOAI  int


                // DeleteCommand  - Thực thi khi gọi Update, nếu có remove dòng nào đó của DataTable
                adapter.DeleteCommand = new SqlCommand(@"DELETE FROM TAIKHOAN WHERE TAIKHOAN = @TAKHOAN", connection);
                var pr1 = adapter.DeleteCommand.Parameters.Add(new SqlParameter("@TAIKHOAN", SqlDbType.VarChar));
                pr1.SourceColumn = "Tài Khoản";
                pr1.SourceVersion = DataRowVersion.Original;  // Giá trị ban đầu


                // UpdateCommand -  Thực thi khi gọi Update, nếu có chỉnh sửa trường dữ liệu nào đó
                adapter.UpdateCommand = new SqlCommand(@"UPDATE TAIKHOAN SET MATKHAU=@MATKHAU, TENTAKHOAN = @TENTAIKHOAN, MALOAI = @MALOAI  WHERE TAIKHOAN = @TAIKHOAN", connection);
                adapter.UpdateCommand.Parameters.Add("@MATKHAU", SqlDbType.NVarChar, 50, "Mật Khẩu");
                adapter.UpdateCommand.Parameters.Add("@TENTAIKHOAN", SqlDbType.NVarChar, 50, "Tên Tài Khoản");
                adapter.UpdateCommand.Parameters.Add("@MALOAI", SqlDbType.Int, 255, "Mã Loại");
                var pr2 = adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TAIKHOAN", SqlDbType.VarChar) { SourceColumn = "Tài khoản" });
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
    }
}
