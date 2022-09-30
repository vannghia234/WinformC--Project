using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formLogin
{
    public partial class formGioHang : Form
    {
        private DataTable dt = new DataTable();
        private double total = 0;
        public static string maHD = "HD03";
     
        public formGioHang()
        {
            InitializeComponent();
        }


        // click datagridview Product
        private void dtgv_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    DataGridViewRow row = new DataGridViewRow();
            //    row = dtgv_Product.Rows[e.RowIndex];
            //    txt_ProductID.Text = row.Cells[0].Value.ToString();
            //    txt_ProductName.Text = row.Cells[1].Value.ToString();
            //    txt_Price.Text = row.Cells[2].Value.ToString();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            txt_ProductID.DataBindings.Clear();
            txt_ProductID.DataBindings.Add(new Binding("Text", dtgv_Product.DataSource, "MaSP", false, DataSourceUpdateMode.Never));
            txt_ProductName.DataBindings.Clear();

            txt_ProductName.DataBindings.Add(new Binding("Text", dtgv_Product.DataSource, "TenSP", false, DataSourceUpdateMode.Never));
            txt_Price.DataBindings.Clear();

            txt_Price.DataBindings.Add(new Binding("Text", dtgv_Product.DataSource, "GiaTien", false, DataSourceUpdateMode.Never));

            nmr_Amount.Value = 1;
        }
        // load sản phẩm lên
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            dt = ClassProvider.dataProvider.Instance.GetDataTableByProcedure("GET_PRODUCT");
            //DataTable s = ClassProvider.dataProvider.Instance.GetDataTable("Select * ");
            dtgv_Product.DataSource = dt;
            DataTable khachhang = ClassProvider.dataProvider.Instance.GetDatatableByQuery("Select * from KhachHang");
            cbb_KhachHang.DataSource = khachhang;
            cbb_KhachHang.DisplayMember = "MAKH";
            DataTable nhanvien = ClassProvider.dataProvider.Instance.GetDatatableByQuery("Select * from NhanVien");
            cbb_NhanVien.DataSource = nhanvien;
            cbb_NhanVien.DisplayMember = "MANV";
            // autocomplete
            loadDataToColection();
        }

        private void loadDataToColection()
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            DataTable dtb = ClassProvider.dataProvider.Instance.GetDatatableByQuery("select tensp from sanpham");
            foreach (DataRow item in dtb.Rows)
            {
                auto.Add(item["TENSP"].ToString());
            }
            txt_Search.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_Search.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_Search.AutoCompleteCustomSource = auto;

        }

        // cập nhật số lượng sản phẩm
        private int GetindexSP(string masp)
        {
            for (int i = 0; i < dtgv_Cart.Rows.Count; i++)
            {
                if (dtgv_Cart.Rows[i].Cells[0].Value.ToString() == masp)
                {
                    return i;
                }
            }
            return -1;
        }
        // cập nhật giỏ hàng
        private void UpdateInsert(int index)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgv_Cart.Rows[index];
            int amount = Convert.ToInt32(nmr_Amount.Value);
            int currentAmout = Convert.ToInt32(row.Cells[2].Value.ToString());
            row.Cells[2].Value = amount + currentAmout;
            int currentUpdateAmount = amount + currentAmout;
            double price = Convert.ToDouble(txt_Price.Text);
            double updatePrice = currentUpdateAmount * price;
            total = total + (amount * price);
            string rs = string.Format("{0:0.000}", updatePrice);
            row.Cells[3].Value = rs;

        }


        // thêm giỏ hàng
        private void btn_Cart_Click(object sender, EventArgs e)
        {
            try
            {
                double price = Convert.ToDouble(txt_Price.Text);
                int amount = Convert.ToInt32(nmr_Amount.Value);
                int index = GetindexSP(txt_ProductID.Text);
                string rs = string.Format("{0:0.000}", price);



                if (index == -1)
                {
                    dtgv_Cart.Rows.Add(txt_ProductID.Text, txt_ProductName.Text, nmr_Amount.Value, rs);
                    total = total + (amount * price);
                }
                else
                {
                    UpdateInsert(index);

                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Vui lòng chọn sản phẩm để thêm vào giỏ hàng", "Thông báo");

            }
            txt_TotalPrice.Text = String.Format("{0:0.000}", total);
        }
        // hoàn tác giỏ hàng
        private void btn_HoanTac_Click(object sender, EventArgs e)
        {

            try
            {
                int index = dtgv_Cart.SelectedRows[0].Index;

                if (dtgv_Cart.Rows.Count > 0)
                {
                    double unionPrice = Convert.ToDouble(dtgv_Cart.Rows[index].Cells[3].Value.ToString());
                    dtgv_Cart.Rows.RemoveAt(index);
                    total = total - unionPrice;
                    txt_TotalPrice.Text = String.Format("{0:0.000}", total);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giỏ hàng rỗng, không thể hoàn tác", "Cảnh báo");
              
            }



        }
        // trao đổi dữ liệu
        private void dtgv_Cart_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //txt_ProductID.DataBindings.Clear();
            //txt_ProductID.DataBindings.Add(new Binding("Text", dtgv_Cart.DataSource, "MaSP"));
            //txt_ProductName.DataBindings.Clear();
            //txt_ProductName.DataBindings.Add(new Binding("Text", dtgv_Cart.DataSource, "TenSP"));
            //nmr_Amount.DataBindings.Clear();
            //nmr_Amount.DataBindings.Add(new Binding("Value", dtgv_Cart.DataSource, "soLuong"));
            //txt_Price.DataBindings.Clear();
            //txt_Price.DataBindings.Add(new Binding("Text", dtgv_Cart.DataSource, "giaBan"));
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgv_Cart.Rows[e.RowIndex];
                txt_ProductID.Text = row.Cells[0].Value.ToString();
                txt_ProductName.Text = row.Cells[1].Value.ToString();
                nmr_Amount.Text = row.Cells[2].Value.ToString();
                txt_Price.Text = row.Cells[3].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void iconPic_Search_Click(object sender, EventArgs e)
        {


        }
        private void reset()
        {
            // clear giỏ hàng
            txt_ProductID.Text = "";
            txt_ProductName.Text = "";
            txt_Price.Text = "";
            //clear hóa đơn
            txt_HoaDon.Clear();
            txt_TotalPrice.Text = "0";
            nmr_KhuyenMai.Value = 0;
            // clear dtgv cart
            dtgv_Cart.Rows.Clear();
        }
        private void iconPicLoad_Click(object sender, EventArgs e)
        {
            dtgv_Product.DataSource = dt;
           

        }
        // tìm kiếm datagridview dùng rowfilter dataview
        private void rjButton1_Click(object sender, EventArgs e)
        {
            DataView data = new DataView(dt);
            data.RowFilter = String.Format("TENSP like '%{0}%' or MASP like '%{1}%'", txt_Search.Text, txt_Search.Text);
            dtgv_Product.DataSource = data;



        }
        // tạo random mã HOADON
        private string RandomIdHoaDon(int k)
        {
            string result = "";
            Random random = new Random();
            char[] MangKyTu = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < k; i++)
            {
                int t = random.Next(0, MangKyTu.Length);
                result += MangKyTu[t];
            }
            return result;
        }
        private void iconBtn_HoaDon_Click(object sender, EventArgs e)
        {
            txt_HoaDon.Text = RandomIdHoaDon(8);
            btn_Cart.Enabled = true;
            maHD = txt_HoaDon.Text;
            btn_HoanTac.Enabled = true;
        }
        

        // xử lý thanh toán hóa đơn + form thanh toán tiền mặt
        private void rjButton2_Click(object sender, EventArgs e)
        {
            maHD = txt_HoaDon.Text;
            string ngay = dtpk_NgayLap.Value.ToString("yyyy/MM/dd");
           
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.Constr))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = con;
                    sqlCommand.CommandText = "INSERT_HOADON";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@MAHD", SqlDbType.VarChar).Value = maHD;
                    sqlCommand.Parameters.Add("@MANV", SqlDbType.VarChar).Value = cbb_NhanVien.Text;
                    sqlCommand.Parameters.Add("@MAKH", SqlDbType.VarChar).Value = cbb_KhachHang.Text;
                    sqlCommand.Parameters.Add("@NGAYLAP", SqlDbType.Date).Value = ngay;
                    sqlCommand.Parameters.Add("@THANHTIEN", SqlDbType.Float).Value = string.Format("{0:0.000}", Convert.ToDouble(txt_TotalPrice.Text));
                    sqlCommand.Parameters.Add("@KHUYENMAI", SqlDbType.Float).Value = float.Parse(nmr_KhuyenMai.Value.ToString());
                    sqlCommand.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.Constr))
                {
                    con.Open();
                    for (int i = 0; i < dtgv_Cart.Rows.Count ; i++)
                    {
                        SqlCommand sqlCommand = new SqlCommand();
                        sqlCommand.Connection = con;
                        sqlCommand.CommandText = "INSERT_GIOHANG";
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.Add("@MAHD", SqlDbType.VarChar).Value = maHD;
                        sqlCommand.Parameters.Add("@MASP", SqlDbType.VarChar).Value = dtgv_Cart.Rows[i].Cells[0].Value.ToString();
                        sqlCommand.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = Convert.ToInt32(dtgv_Cart.Rows[i].Cells[2].Value.ToString());
                        sqlCommand.Parameters.Add("@GIABAN", SqlDbType.Money).Value = Convert.ToDouble(dtgv_Cart.Rows[i].Cells[3].Value.ToString());

                        sqlCommand.ExecuteNonQuery();
                    }
                    
                    con.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            Payment pm = new Payment(total, maHD, int.Parse(nmr_KhuyenMai.Value.ToString()));
            pm.ShowDialog();
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.Constr))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = con;
                    sqlCommand.CommandText = "UPDATE_TRANGTHAI";
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@MAHD", SqlDbType.VarChar).Value = maHD;
                    sqlCommand.ExecuteNonQuery();
                    reset();
                    MessageBox.Show("Thanh toán thành công !");
                    con.Close();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            reset();
        }

        private void rjButton2_Click_1(object sender, EventArgs e)
        {
            reportView rp = new reportView();
            rp.ShowDialog();
        }
    }
}
