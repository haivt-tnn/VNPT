using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Models
{
    public class ConnectDb
    {
        public SqlConnection conn = null;
        public ConnectDb()
        {
            //conn = new SqlConnection("data source=123.30.182.15;initial catalog=qlks_db;user id=account_website;password=pR&i2s57;multipleactiveresultsets=True;application name=EntityFramework");
            conn = new SqlConnection("data source=10.23.31.4;initial catalog=qlks_db;user id=sa;password=123456;multipleactiveresultsets=True;application name=EntityFramework");
            //conn = new SqlConnection("data source=192.168.0.112;initial catalog=qlks_db;user id=sa;password=123456;multipleactiveresultsets=True;application name=EntityFramework");
            conn.Open();
        }
        public void DisConnect()
        {
            conn.Close();
        }
    }
}
