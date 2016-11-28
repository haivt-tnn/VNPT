using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TaiKhoanModel
    {
        private KhachSanDbContext context;
        private SqlConnection conn = null;
        private SqlDataReader rdr = null;
        public TaiKhoanModel()
        {
            context = new KhachSanDbContext();
        }
        public bool Login(string taikhoan, string matkhau)
        {
            bool kq = false;
            if (taikhoan == null || matkhau == null)
            {
                return false;
            }
            else
            {
                int i = 0;
                conn = new SqlConnection("data source=DESKTOP-MMFJR37;initial catalog=QLKS;integrated security=True;");
                conn.Open();
                SqlCommand cmd = new SqlCommand("getOneUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@taikhoan", taikhoan));
                cmd.Parameters.Add(new SqlParameter("@matkhau", matkhau));
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
