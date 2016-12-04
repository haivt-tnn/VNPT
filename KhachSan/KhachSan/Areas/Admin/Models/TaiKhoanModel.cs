using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KhachSan.Areas.Admin.Models
{
    public class TaiKhoanModel
    {
        ConnectDb db;
        SqlDataReader sdr;

        public bool Login(string taikhoan, string matkhau)
        {
            db = new ConnectDb();
            int i = 0;
            if (taikhoan != null && matkhau != null)
            {
                SqlCommand cmd = new SqlCommand("checkLogin", db.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@taikhoan", taikhoan));
                cmd.Parameters.Add(new SqlParameter("@matkhau", matkhau));
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    i++;
                }
            }           
            if (i!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}