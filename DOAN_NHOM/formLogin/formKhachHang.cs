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
    public partial class formKhachHang : Form
    {

        DataTable dataTable = new DataTable("KHACHHANG");
        // Tạo kết nối
        String sqlconnectstring = @"Data Source=MINATOO;Initial Catalog=QUANLY_BEAUTY_HEALTH;Integrated Security=True";
        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet dataSet = new DataSet();



        public formKhachHang()
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

                // Thiết lập bảng trong DataSet ánh xạ tương ứng có tên là KHACHHANG
                adapter.TableMappings.Add("Table", "KHACHHANG");

                // SelectCommand - Thực thi khi gọi Fill lấy dữ liệu về DataSet
                adapter.SelectCommand = new SqlCommand(@"SELECT MAKH as 'Mã Khách Hàng'  , TENKH as 'Tên Khách Hàng'  , SDT as 'Số Điện Thoại' , DIACHI as 'Địa Chỉ'  FROM KHACHHANG", connection);

                // InsertCommand - Thực khi khi gọi Update, nếu DataSet có chèn dòng mới (vào DataTable)
                // Dữ liệu lấy từ DataTable, như cột Mã Khách Hàng tương  ứng với tham số @MAKH
                adapter.InsertCommand = new SqlCommand(@"INSERT INTO KHACHHANG (MAKH , TENKH , SDT , DIACHI) VALUES (@MAKH , @TENKH , @SDT , @DIACHI)", connection);
                adapter.InsertCommand.Parameters.Add("@MAKH", SqlDbType.VarChar, 10, "Mã Khách Hàng");
                adapter.InsertCommand.Parameters.Add("@TENKH", SqlDbType.NVarChar, 50, "Tên Khách Hàng");
                adapter.InsertCommand.Parameters.Add("@SDT", SqlDbType.VarChar, 20, "Số Điện Thoại");
                adapter.InsertCommand.Parameters.Add("@DIACHI", SqlDbType.NVarChar, 100, "Địa Chỉ");

                //[MAKH] VARCHAR(10)   NOT NULL,
                //[TENKH]  NVARCHAR(50)  NOT NULL,
                //[SDT]    VARCHAR(20)   NULL,
                //[DIACHI] NVARCHAR(100) NULL,

                // DeleteCommand  - Thực thi khi gọi Update, nếu có remove dòng nào đó của DataTable
                adapter.DeleteCommand = new SqlCommand(@"DELETE FROM KHACHHANG WHERE MAKH = @MAKH", connection);
                var pr1 = adapter.DeleteCommand.Parameters.Add(new SqlParameter("@MAKH", SqlDbType.VarChar));
                pr1.SourceColumn = "Mã Khách Hàng";
                pr1.SourceVersion = DataRowVersion.Original;  // Giá trị ban đầu


                // UpdateCommand -  Thực thi khi gọi Update, nếu có chỉnh sửa trường dữ liệu nào đó
                adapter.UpdateCommand = new SqlCommand(@"UPDATE KHACHHANG SET TENKH=@TENKH, SDT = @SDT, DIACHI = @DIACHI  WHERE MAKH = @MAKH", connection);
                adapter.UpdateCommand.Parameters.Add("@TENKH", SqlDbType.NVarChar, 50, "Tên Khách Hàng");
                adapter.UpdateCommand.Parameters.Add("@SDT", SqlDbType.VarChar, 20, "Số Điện Thoại");
                adapter.UpdateCommand.Parameters.Add("@DIACHI", SqlDbType.NVarChar, 100, "Địa Chỉ");
                var pr2 = adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MAKH", SqlDbType.VarChar) { SourceColumn = "Mã Khách Hàng" });
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
            //dataTable.Rows.Clear();
            //adapter.Fill(dataSet);
        }
        
        private void fromCustomer_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'qUANLY_BEAUTY_HEALTHDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            //this.kHACHHANGTableAdapter.Fill(this.qUANLY_BEAUTY_HEALTHDataSet.KHACHHANG);
            //LoadDataTable();
            //dgvCustomers.DataSource = dataTable.DefaultView;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //    if (dg == DialogResult.OK)
            //    {
            //        Application.Exit();
            //    }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DialogResult dg = MessageBox.Show("Bạn có muốn lưu lại không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //    if (dg == DialogResult.OK)
            //    {
                    
            //        adapter.Update(dataSet);

            //        dataTable.Rows.Clear();

            //        adapter.Fill(dataSet);

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message + "\n\n Không thêm được khách hàng, mời nhập lại.", "Mã Khách hàng bị trùng lặp !",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            //}
          
        }
         
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    foreach (DataGridViewRow item in this.dgvCustomers.SelectedRows)
            //    {
            //        DialogResult dg = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //        if (dg == DialogResult.OK)
            //        {
            //            dgvCustomers.Rows.RemoveAt(item.Index);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);

            //}

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    LoadDataTable();
            //    dgvCustomers.DataSource = dataTable.DefaultView;
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            
        }

        //public bool CheckInfo()
        //{
        //    if (txt_CustomerID.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txt_CustomerID.Focus();
        //        return false;
        //    }
        //    if (txt_CustomerName.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txt_CustomerName.Focus();
        //        return false;
        //    }
        //    else if (txt_CustomerAddress.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng nhập địa chỉ khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txt_CustomerAddress.Focus();
        //        return false;
        //    }
        //    else if(txtCustomersPhoneNumber.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng nhập SĐT khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txtCustomersPhoneNumber.Focus();
        //        return false;
        //    }
        //    else if(txt_CustomerName.Text == "" && txt_CustomerAddress.Text == "" && txtCustomersPhoneNumber.Text == "" && txt_CustomerID.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng điền thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txt_CustomerID.Focus();
        //        txt_CustomerName.Focus();
        //        txt_CustomerAddress.Focus();
        //        txtCustomersPhoneNumber.Focus();
        //        return false;
        //    }
        //    return true;
        //}

        //private void AddValue()
        //{
        //    DataRow row = dataTable.NewRow();
        //    row["Mã Khách Hàng"] = txt_CustomerID.Text.ToString();
        //    row["Tên Khách Hàng"] = txt_CustomerName.Text.ToString();
        //    row["Số Điện Thoại"] = txtCustomersPhoneNumber.Text.ToString();
        //    row["Địa Chỉ"] = txt_CustomerAddress.Text.ToString();
        //    dataTable.Rows.Add(row);   
        //}

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if(CheckInfo())
            //    {
            //        AddValue();
            //    }    
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    DataGridViewRow row = new DataGridViewRow();
            //    row = dgvCustomers.Rows[e.RowIndex];
            //    txt_CustomerID.Text = Convert.ToString(row.Cells["Mã Khách Hàng"].Value);
            //    txt_CustomerName.Text = Convert.ToString(row.Cells["Tên Khách Hàng"].Value);
            //    txt_CustomerAddress.Text = Convert.ToString(row.Cells["Địa Chỉ"].Value);
            //    txtCustomersPhoneNumber.Text = Convert.ToString(row.Cells["Số Điện Thoại"].Value);
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            
        }

        
    }
}

