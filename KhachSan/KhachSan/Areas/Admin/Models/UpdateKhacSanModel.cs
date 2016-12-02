using Models;
using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KhachSan.Areas.Admin.Models
{
    public class UpdateKhacSanModel
    {
        public ConnectDb c = null;
        public bool updateGioiThieu(int? id, string tieude, string noidung, string ulrimage)
        {
            c = new ConnectDb();
            SqlCommand cmd = new SqlCommand("updateGioiThieu", c.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.Parameters.Add(new SqlParameter("@tieude", tieude));
            cmd.Parameters.Add(new SqlParameter("@noidung", noidung));
            cmd.Parameters.Add(new SqlParameter("@ulrimage", ulrimage));
            cmd.ExecuteNonQuery();
            return true;
        }
        public SqlDataReader rdr = null;
        public List<GIOITHIEU> getAllGioiThieu()
        {
            c = new ConnectDb();
            List<GIOITHIEU> list = new List<GIOITHIEU>();
            GIOITHIEU item = new GIOITHIEU();
            SqlCommand cmd = new SqlCommand("getAllGioiThieu", c.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                item.IDGIOITHIEU = (int)rdr["IDGIOITHIEU"];
                item.TENGIOITHIEU = (string)rdr["TENGIOITHIEU"];
                item.MOTA = (string)rdr["MOTA"];
                item.URLIMAGE = (string)rdr["URLIMAGE"];
                list.Add(item);
            }
            return list;
        }
    }
}