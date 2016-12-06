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

        public bool updateKieuPhong(int? makieuphong, string tenkieuphong, string mota, int? songuoilon, int? sotreem)
        {
            c = new ConnectDb();
            SqlCommand cmd = new SqlCommand("updateKieuPhong", c.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAKIEUPHONG", makieuphong));
            cmd.Parameters.Add(new SqlParameter("@TENKIEUPHONG", tenkieuphong));
            cmd.Parameters.Add(new SqlParameter("@MOTA", mota));
            cmd.Parameters.Add(new SqlParameter("@SONGUOILON", songuoilon));
            cmd.Parameters.Add(new SqlParameter("@SOTREEM", sotreem));
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool themKieuPhong(string tenkieuphong, string mota, int? songuoilon, int? sotreem)
        {
            c = new ConnectDb();
            SqlCommand cmd = new SqlCommand("insertKieuPhong", c.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@TENKIEUPHONG", tenkieuphong));
            cmd.Parameters.Add(new SqlParameter("@MOTA", mota));
            cmd.Parameters.Add(new SqlParameter("@SONGUOILON", songuoilon));
            cmd.Parameters.Add(new SqlParameter("@SOTREEM", sotreem));
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteKieuPhong(int? makieuphong)
        {
            c = new ConnectDb();
            SqlCommand cmd = new SqlCommand("deleteKieuPhong", c.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAKIEUPHONG", makieuphong));
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}