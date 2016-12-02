using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Models.Framework;
using System.Data;

namespace KhachSan.Models
{
    public class DICHVU_MODEL
    {
        public ConnectDb c = null;
        public SqlDataReader rdr = null;
        public List<DANH_MUC_TIEN_ICH> getTienIch()
        {
            c = new ConnectDb();
            List<DANH_MUC_TIEN_ICH> list = new List<DANH_MUC_TIEN_ICH>();
            
            SqlCommand cmd = new SqlCommand("getAllTienIch", c.conn);
            cmd.CommandType = CommandType.StoredProcedure;
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
        public List<DANH_MUC_TIEN_ICH> get1TienIch()
        {
            c = new ConnectDb();
            List<DANH_MUC_TIEN_ICH> list = new List<DANH_MUC_TIEN_ICH>();

            SqlCommand cmd = new SqlCommand("getAllTienIch", c.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if ((string) rdr["MADV"]=="1")
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
        public List<DANH_MUC_TIEN_ICH> getDetailTienIch(int id)
        {
            c = new ConnectDb();
            List<DANH_MUC_TIEN_ICH> list = new List<DANH_MUC_TIEN_ICH>();

            SqlCommand cmd = new SqlCommand("getAllTienIch", c.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (id==(int)rdr["ID"])
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