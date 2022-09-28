using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace formLogin
{
    public partial class reportView : Form
    {
        public reportView()
        {
            InitializeComponent();
        }

   

        private void reportView_Load(object sender, EventArgs e)
        {
            try
            {
                //ReportParameter rp = new ReportParameter("MAHD");
                //rp.Values.Add(formHoaDon.instance.maHD);
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.Constr);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GET_INF_INVOICE";
                cmd.Parameters.Add("@MAHD", SqlDbType.VarChar).Value = formHoaDon.maHD;
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "CTHoaDon");
                conn.Close();

                this.reportViewer1.LocalReport.ReportEmbeddedResource = "formLogin.Report123.rdlc";
                ReportDataSource ds2 = new ReportDataSource();
                ds2.Name = "DataSet2";
                ds2.Value = ds.Tables["CTHoaDon"];
                this.reportViewer1.LocalReport.DataSources.Add(ds2);
                this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
