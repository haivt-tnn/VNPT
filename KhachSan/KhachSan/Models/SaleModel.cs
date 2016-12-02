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
    public class SaleModel
    {
        ConnectDb connectdb;
        SqlDataReader sdr;

        public List<KHUYEN_MAI> getAllKhuyenMai()
        {
            connectdb = new ConnectDb();
            List<KHUYEN_MAI> list = new List<KHUYEN_MAI>();
         
            SqlCommand cmd = new SqlCommand("getAllKhuyenMai",connectdb.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                KHUYEN_MAI item_khuyenmai = new KHUYEN_MAI();

                item_khuyenmai.MAKHUYENMAI = (int)sdr["MAKHUYENMAI"];
                item_khuyenmai.TIEUDEKHUYENMAI = (string)sdr["TIEUDEKHUYENMAI"];
                item_khuyenmai.NOIDUNGKHUYENMAI = (string)sdr["NOIDUNGKHUYENMAI"];
                item_khuyenmai.URLANH = (string)sdr["URLANH"];
                item_khuyenmai.THOIGIANTAO = (DateTime)sdr["THOIGIANTAO"];
                item_khuyenmai.NGUOITAO = (string)sdr["NGUOITAO"];

                list.Add(item_khuyenmai);

            }
            return list;

        }
        public List<KHUYEN_MAI> getAllKhuyenMai1(int id)
        {
            connectdb = new ConnectDb();
            List<KHUYEN_MAI> list = new List<KHUYEN_MAI>();

            SqlCommand cmd = new SqlCommand("getAllKhuyenMai", connectdb.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                KHUYEN_MAI item_khuyenmai = new KHUYEN_MAI();
                if (id == (int)sdr["MAKHUYENMAI"])
                {
                    item_khuyenmai.MAKHUYENMAI = (int)sdr["MAKHUYENMAI"];
                    item_khuyenmai.TIEUDEKHUYENMAI = (string)sdr["TIEUDEKHUYENMAI"];
                    item_khuyenmai.NOIDUNGKHUYENMAI = (string)sdr["NOIDUNGKHUYENMAI"];
                    item_khuyenmai.URLANH = (string)sdr["URLANH"];
                    item_khuyenmai.THOIGIANTAO = (DateTime)sdr["THOIGIANTAO"];
                    item_khuyenmai.NGUOITAO = (string)sdr["NGUOITAO"];

                    list.Add(item_khuyenmai);
                }
            }
            return list;

        }

    }
}