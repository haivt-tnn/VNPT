using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ConnectDb
    {
        public SqlConnection conn = null;
        public ConnectDb()
        {
            string strconnect = "Data Source=123.30.182.15;Initial Catalog=qlks_db;Persist Security Info=True;User ID=account_website;Password=pR&i2s57";
            conn = new SqlConnection(strconnect);
            conn.Open();
        }
        public void DisConnect()
        {
            if (conn!=null)
            {
                conn.Close();
                //conn.Dispose();
            }
        }

    }
}
