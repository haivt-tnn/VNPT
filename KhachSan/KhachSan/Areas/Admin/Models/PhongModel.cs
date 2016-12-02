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
    public class PhongModel
    {
        public ConnectDb c = null;
        public SqlDataReader rdr = null;
        public List<DANH_MUC_LOAI_PHONG> getAllLoaiPhong()
        {
            c = new ConnectDb();
            List<DANH_MUC_LOAI_PHONG> list = new List<DANH_MUC_LOAI_PHONG>();
            SqlCommand cmd = new SqlCommand("getLoaiPhong", c.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                DANH_MUC_LOAI_PHONG item = new DANH_MUC_LOAI_PHONG();
                item.MALOAIPHONG = (int)rdr["MALOAIPHONG"];
                item.TENLOAIPHONG = (string)rdr["TENLOAIPHONG"];
                item.MOTA = (string)rdr["MOTA"];
                item.URLIMAGE = (string)rdr["URLIMAGE"];
                list.Add(item);
            }
            return list;
        }
        public bool themLoaiPhong(string tenphong, string mota, string ulr)
        {
            c = new ConnectDb();
            SqlCommand cmd = new SqlCommand("insertLoaiPhong", c.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@TENLOAIPHONG", tenphong));
            cmd.Parameters.Add(new SqlParameter("@MOTA", mota));
            cmd.Parameters.Add(new SqlParameter("@URL", ulr));
            cmd.ExecuteNonQuery();
            return true;
        }
    }
}