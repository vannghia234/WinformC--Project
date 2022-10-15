using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace formLogin
{
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();
        }
        public int per = formDangNhap.Permit;
        private void addForm(Form form)
        {
            formTaiKhoanQL.panel.Controls.Clear();
            formTaiKhoanQL.panel.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            formTaiKhoanQL.panel.Controls.Add(form);
            form.Show();

        }
        private void addForm1(Form form)
        {
            formTaiKhoanNV.panel.Controls.Clear();
            formTaiKhoanNV.panel.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            formTaiKhoanNV.panel.Controls.Add(form);
            form.Show();

        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if(per == 1)
            {
                addForm(new formThongKe());
            }
            else
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            if (per == 1)
            {
                addForm(new formTaiKhoan());
            }
            else
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void rjButton7_Click(object sender, EventArgs e)
        {
            if (per == 1)
            {
                addForm(new FormQLNV());
            }
            else
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            if (per == 1)
            {
                addForm(new formKhachHang());
            }
            else if (per == 2)
            {
                addForm1(new formKhachHang());
            }
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            if (per == 1)
            {
                addForm(new formHoaDon());
            }
            else
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            if (per == 1)
            {
                addForm(new formSanPham());
            }
            else if (per == 2)
            {
                addForm1(new formSanPham());
            }

        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            if (per == 1)
            {
                addForm(new formNhapKho());
            }
            else if (per == 2)
            {
                addForm1(new formNhapKho());
            }

        }

        private void btnNcc_Click(object sender, EventArgs e)
        {
            if (per == 1)
            {
                addForm(new formNCC());
            }
            else if (per == 2)
            {
                addForm1(new formNCC());
            }

        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            if (per == 1)
            {
                addForm(new formGioHang());
            }
            else if (per == 2)
            {
                addForm1(new formGioHang());
            }

        }
    }
}
