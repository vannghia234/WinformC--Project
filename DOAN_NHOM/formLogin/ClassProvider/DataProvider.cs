using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formLogin.ClassProvider
{
    public class dataProvider
    {
        private static dataProvider instance;

        public static dataProvider Instance { get { if (instance == null) { dataProvider instance = new dataProvider(); } return instance; } set => instance = value; }
        public static DataTable GetDataTable (string query)
        {
            string conStr = "Data Source=DAICA-ZORO\\MSSQLSERVER01;Initial Catalog=QLQUANCOFFEE;Integrated Security=True";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
                conn.Close();
            }
            return dt;
        }
    }
}
