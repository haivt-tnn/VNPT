using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Models;
using Models.Framework;
using System.Data.SqlClient;

namespace KhachSan.Models
{
    public class AdsModel
    {
        public ConnectDb c = null;
        public SqlDataReader rdr = null;
        public List<QUANG_CAO> getAllQC()
        {
            c = new ConnectDb();
            List<QUANG_CAO> list = new List<QUANG_CAO>();
            SqlCommand cmd = new SqlCommand("getAllQC", c.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                QUANG_CAO item = new QUANG_CAO();
                item.ID = (int)rdr["ID"];
                item.TENQC = (string)rdr["TENQC"];
                item.HINH = (string)rdr["HINH"];
                item.LINK = (string)rdr["LINK"];
                list.Add(item);
            }
            return list;
        }
        public List<QUANG_CAO> getOneQC(string tenq)
        {
            c = new ConnectDb();
            List<QUANG_CAO> list = new List<QUANG_CAO>();
            SqlCommand cmd = new SqlCommand("getOneQC", c.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@TENQC", tenq));
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                QUANG_CAO item = new QUANG_CAO();
                item.ID = (int)rdr["ID"];
                item.TENQC = (string)rdr["TENQC"];
                item.HINH = (string)rdr["HINH"];
                item.LINK = (string)rdr["LINK"];
                list.Add(item);
            }
            return list;
        }
    }
}