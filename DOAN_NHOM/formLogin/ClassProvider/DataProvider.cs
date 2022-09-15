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
        private static dataProvider instance = null; // bien singleTon
        public static dataProvider Instance { 
            get { 
                if (instance == null) 
                    instance = new dataProvider();
                return instance;
            }
            set => instance = value; }

        // method
        public DataTable GetDataTableByProcedure (string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.Constr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            return dt;
        }
        public DataTable GetDatatableByQuery (string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.Constr))
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
