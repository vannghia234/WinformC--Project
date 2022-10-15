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
    public partial class formNhapKho : Form
    {
        public formNhapKho()
        {
            InitializeComponent();
        }
        String strCon = "Data Source=DAICA-ZORO\\MSSQLSERVER01;Initial Catalog=QUANLY_BEAUTY_HEALTH;Integrated Security=True";
        SqlConnection SqlCon;
        DataTable dt = new DataTable();
        private void loadPGH()
        {
            SqlCon = new SqlConnection(strCon);
            SqlCon.Open();
            DataTable dtb = new DataTable();

            string sql = "SELECT * FROM CTPGH";
            SqlCommand command = new SqlCommand(sql, SqlCon);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dtb);
            dataGridView1.DataSource = dtb;
            SqlCon.Close();
        }
        private void HienThiDanhSach()
        {
            SqlCon = new SqlConnection(strCon);
            SqlCon.Open();
            string sql = "SELECT * FROM CTPGH";
            SqlCommand command = new SqlCommand(sql, SqlCon);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlCon.Close();
        }

        public bool Kiemtrathongtin()
        {
            if (cbbMaPhieuGiaoHang.Text == "")
            {
                MessageBox.Show("Bạn cần nhập phiếu giao hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbMaPhieuGiaoHang.Focus();
                return false;
            }

            if (cbbMaSanPham.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbMaSanPham.Focus();
                return false;
            }
            if (dateTime3.Text == "")
            {
                MessageBox.Show("Bạn cần nhập HSD", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTime3.Focus();
                return false;
            }
            if (dateTime1.Text == "")
            {
                MessageBox.Show("Bạn cần nhập ngày đặt ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTime1.Focus();
                return false;
            }
            if (dateTime2.Text == "")
            {
                MessageBox.Show("Bạn cần nhập ngày nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTime2.Focus();
                return false;
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn cần nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Focus();
                return false;
            }
            if (txtTongTien.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tổng tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTongTien.Focus();
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Kiemtrathongtin())
            {
                try
                {


                    SqlCon = new SqlConnection(strCon);
                    SqlCon.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "them_nhapkho";
                    command.Connection = SqlCon;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@MAPGH", SqlDbType.VarChar).Value = cbbMaPhieuGiaoHang.Text;
                    command.Parameters.Add("@MASP", SqlDbType.VarChar).Value = cbbMaSanPham.Text;
                    command.Parameters.Add("@HANSUDUNG", SqlDbType.Date).Value = dateTime3.Value;
                    command.Parameters.Add("@NGAYDAT", SqlDbType.Date).Value = dateTime1.Value;
                    command.Parameters.Add("@NGAYNHAN", SqlDbType.Date).Value = dateTime2.Value;
                    command.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = txtSoLuong.Text;
                    command.Parameters.Add("@TONGTIEN", SqlDbType.Money).Value = txtTongTien.Text;
                    command.ExecuteNonQuery();
                    HienThiDanhSach();
                    lammoi();
                    SqlCon.Close();
                    MessageBox.Show("Đã thêm thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("thêm sai mời nhập lại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cbbMaPhieuGiaoHang.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            lammoi();
        }
        private void lammoi()
        {
            cbbMaPhieuGiaoHang.Text = "";
            cbbMaSanPham.Text = "";
            dateTime3.Text = "";
            dateTime1.Text = "";
            dateTime2.Text = "";
            txtSoLuong.Text = "";
            txtTongTien.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {


            try
            {

                SqlCon = new SqlConnection(strCon);
                SqlCon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "xoa_nhapkho";
                cmd.Connection = SqlCon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MAPGH", SqlDbType.VarChar).Value = cbbMaPhieuGiaoHang.Text;
                cmd.ExecuteNonQuery();
                loadPGH();
                lammoi();
                SqlCon.Close();
                MessageBox.Show("Đã xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Xóa không thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbbMaPhieuGiaoHang.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                cbbMaPhieuGiaoHang.Text = Convert.ToString(row.Cells["MAPGH"].Value);
                cbbMaSanPham.Text = Convert.ToString(row.Cells["MASP"].Value);
                dateTime3.Text = Convert.ToString(row.Cells["HANSUDUNG"].Value);
                dateTime1.Text = Convert.ToString(row.Cells["NGAYDAT"].Value);
                dateTime2.Text = Convert.ToString(row.Cells["NGAYNHAN"].Value);
                txtSoLuong.Text = Convert.ToString(row.Cells["SOLUONG"].Value);
                txtTongTien.Text = Convert.ToString(row.Cells["TONGTIEN"].Value);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           if (Kiemtrathongtin())
            {
                try
                {


                    SqlCon = new SqlConnection(strCon);
                    SqlCon.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "sua_nhapkho";
                    command.Connection = SqlCon;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@MAPGH", SqlDbType.VarChar).Value = cbbMaPhieuGiaoHang.Text;
                    command.Parameters.Add("@MASP", SqlDbType.VarChar).Value = cbbMaSanPham.Text;
                    command.Parameters.Add("@HANSUDUNG", SqlDbType.Date).Value = dateTime3.Text;
                    command.Parameters.Add("@NGAYDAT", SqlDbType.Date).Value = dateTime1.Text;
                    command.Parameters.Add("@NGAYNHAN", SqlDbType.Date).Value = dateTime2.Text;
                    command.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = txtSoLuong.Text;
                    command.Parameters.Add("@TONGTIEN", SqlDbType.Money).Value = txtTongTien.Text;
                    command.ExecuteNonQuery();
                    loadPGH();
                    lammoi();
                    SqlCon.Close();
                    MessageBox.Show("Đã sửa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    MessageBox.Show("Sửa không thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataView dataView = new DataView(dt);
            dataView.RowFilter = String.Format("MAPGH like '%{0}%' or MASP like '%{1}%'", txt_Search.Text, txt_Search.Text);
            dataGridView1.DataSource = dataView;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgv_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
