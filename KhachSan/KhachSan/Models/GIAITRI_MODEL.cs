using Models;
using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KhachSan.Models
{
    public class GIAITRI_MODEL
    {
        public ConnectDb c = null;
        public SqlDataReader rdr = null;
        public List<DANH_MUC_TIEN_ICH> getTypeTienIch(int id)
        {
            c = new ConnectDb();
            List<DANH_MUC_TIEN_ICH> list = new List<DANH_MUC_TIEN_ICH>();

            SqlCommand cmd = new SqlCommand("getTypeTienIch", c.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", id));
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                DANH_MUC_TIEN_ICH item = new DANH_MUC_TIEN_ICH();
                item.ID = (int)rdr["ID"];
                item.MADV = (string)rdr["MADV"];
                item.TENDV = (string)rdr["TENDV"];
                item.MOTA = (string)rdr["MOTA"];
                item.URL = (string)rdr["URL"];
                item.NGAYTAO = (DateTime)rdr["NGAYTAO"];
                list.Add(item);
            }
            return list;
        }
        public List<DANH_MUC_TIEN_ICH> getDetailTienIch(int id, int id2)
        {
            c = new ConnectDb();
            List<DANH_MUC_TIEN_ICH> list = new List<DANH_MUC_TIEN_ICH>();

            SqlCommand cmd = new SqlCommand("getTypeTienIch", c.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", id));
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if ((int)rdr["ID"] == id2)
                {
                    DANH_MUC_TIEN_ICH item = new DANH_MUC_TIEN_ICH();
                    item.ID = (int)rdr["ID"];
                    item.MADV = (string)rdr["MADV"];
                    item.TENDV = (string)rdr["TENDV"];
                    item.MOTA = (string)rdr["MOTA"];
                    item.URL = (string)rdr["URL"];
                    item.NGAYTAO = (DateTime)rdr["NGAYTAO"];
                    list.Add(item);
                }
            }
            return list;
        }
    }
}