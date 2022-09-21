using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formLogin
{
    public partial class formHoaDon : Form
    {
        public formHoaDon()
        {
            InitializeComponent();
        }
        private DataTable dt = new DataTable();
        private double total = 0;
        private string maHD = "";

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

        private void iconPicLoad_Click(object sender, EventArgs e)
        {
            dtgv_Product.DataSource = dt;
        }
        // tìm kiếm datagridview dùng rowfilter dataview
        private void rjButton1_Click(object sender, EventArgs e)
        {
            DataView data = new DataView(dt);
            data.RowFilter = String.Format("TENSP like '%{0}%'", txt_Search.Text);
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
            btn_HoanTac.Enabled = true;
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            maHD = txt_HoaDon.Text;

            Payment pm = new Payment(total, maHD);
            pm.Show();
        }
    }
}
