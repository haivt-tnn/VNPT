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
    public class KieuPhongModel
    {
        public ConnectDb c = null;
        public SqlDataReader rdr = null;
        public List<DANH_MUC_KIEU_PHONG> getAllKieuPhong()
        {
            c = new ConnectDb();
            List<DANH_MUC_KIEU_PHONG> list = new List<DANH_MUC_KIEU_PHONG>();
            SqlCommand cmd = new SqlCommand("getAllKieuPhong", c.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                DANH_MUC_KIEU_PHONG it = new DANH_MUC_KIEU_PHONG();
                it.MAKIEUPHONG = (int)rdr["MAKIEUPHONG"];
                it.TENKIEUPHONG = (string)rdr["TENKIEUPHONG"];
                it.MOTA = (string)rdr["MOTA"];
                it.SONGUOILON = (int)rdr["SONGUOILON"];
                it.SOTREEM = (int)rdr["SOTREEM"];
                list.Add(it);
            }
            return list;
        }
    }
}