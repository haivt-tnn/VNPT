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
    public class LoaiPhongModel
    {
        public ConnectDb c = null;
        public SqlDataReader rdr = null;
        public List<DANH_MUC_LOAI_PHONG> getChiTietLoaiPhong(int id)
        {
            c = new ConnectDb();
            List<DANH_MUC_LOAI_PHONG> list = new List<DANH_MUC_LOAI_PHONG>();            
            SqlCommand cmd = new SqlCommand("getAllLoaiPhong", c.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                DANH_MUC_LOAI_PHONG item = new DANH_MUC_LOAI_PHONG();
                if (id == (int)rdr["MALOAIPHONG"])
                {
                    item.MALOAIPHONG = (int)rdr["MALOAIPHONG"];
                    item.TENLOAIPHONG = (string)rdr["TENLOAIPHONG"];
                    item.MOTA = (string)rdr["MOTA"];
                    item.URLIMAGE = (string)rdr["URLIMAGE"];
                    list.Add(item);
                }
            }
            return list;
        }
        public List<DANH_MUC_LOAI_PHONG> getAllLoaiPhong()
        {
            c = new ConnectDb();
            List<DANH_MUC_LOAI_PHONG> list = new List<DANH_MUC_LOAI_PHONG>();
            SqlCommand cmd = new SqlCommand("getAllLoaiPhong", c.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                DANH_MUC_LOAI_PHONG item = new DANH_MUC_LOAI_PHONG();
                item.MALOAIPHONG = (int)rdr["MALOAIPHONG"];
                item.TENLOAIPHONG = (string)rdr["TENLOAIPHONG"];
                item.MOTA = (string)rdr["MOTA"];
                item.URLIMAGE = (string)rdr["URLIMAGE"];
                list.Add(item); ;
            }
            return list;
        }
    }
}