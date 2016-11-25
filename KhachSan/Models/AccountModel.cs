using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AccountModel
    {
        private KhachSanDbContext context = null;
        private SqlConnection conn = null;
        private SqlDataReader rdr = null;

        public AccountModel()
        {
            context = new KhachSanDbContext();
        }
        public bool Login(string userName, string password)
        {
            bool kq = false;
            if (userName == null || password == null)
            {
                return false;
            }
            else
            {
                int i = 0;
                conn = new SqlConnection("data source=DESKTOP-MMFJR37;initial catalog=taikhoan;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
                conn.Open();
                SqlCommand cmd = new SqlCommand("check_Login", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@User", userName));
                cmd.Parameters.Add(new SqlParameter("@Pass", password));
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    i++;
                }
                if (i > 0)
                {
                    kq = true;
                }
            }
            return kq;
        }
    }
}
