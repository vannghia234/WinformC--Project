using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace formLogin.DAO
{
    internal class dataProvoder
    {
        // singleTon 
        private static dataProvoder instance;

        internal static dataProvoder Instance { get => instance; set => instance = value; }
        public dataProvoder() {}
        public void excuteProc()
        {
            SqlConnection conn = new SqlConnection();
            string conStr = "Data Source=DAICA-ZORO\\MSSQLSERVER01;Initial Catalog=QLQUANCOFFEE;Integrated Security=True";
            try
            {
                conn.ConnectionString = conStr;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "SP_CHECKLOGIN";
                cmd.Parameters.AddWithValue("@username", tbAccount.Text);
                cmd.Parameters.AddWithValue("@password", tbpassword.Text);
                cmd.Connection = conn;
                object kq = cmd.ExecuteScalar();
                int code = Convert.ToInt32(kq);

            }
}
    }
}
