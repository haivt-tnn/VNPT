using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models.Framework;
using Models;
using System.Data;
using System.Data.SqlClient;

namespace KhachSan.Models
{
    public class Gioithieu
    {
        public ConnectDb c = null;
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