using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ConnectDb
    {
        public string str = "data source=123.30.182.15;initial catalog=qlks_db;persist security info=True;user id=account_website;password=pR&i2s57";
        public SqlConnection conn = null;
        public ConnectDb()
        {
            conn = new SqlConnection(str);
            conn.Open();
        }
        public void DisConnect()
        {
            if (conn!=null && conn.State==ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
