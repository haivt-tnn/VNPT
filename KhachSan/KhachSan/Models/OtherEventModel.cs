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
    public class OtherEventModel
    {
        ConnectDb connectdb;
        SqlDataReader sdr;

        public List<TIN_TUC_KHAC> getAllTinTuc()
        {
            connectdb = new ConnectDb();
            List<TIN_TUC_KHAC> list = new List<TIN_TUC_KHAC>();
            SqlCommand cmd = new SqlCommand("getAllTinTuc", connectdb.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                TIN_TUC_KHAC item_tintuc = new TIN_TUC_KHAC();
                item_tintuc.MATINTUC = (int)sdr["MATINTUC"];
                item_tintuc.TIEUDETINTUC = (string)sdr["TIEUDETINTUC"];
                item_tintuc.NOIDUNGTINTUC = (string)sdr["NOIDUNGTINTUC"];
                item_tintuc.URLANH = (string)sdr["URLANH"];
                item_tintuc.NGAYTAO = (DateTime)sdr["NGAYTAO"];
                item_tintuc.NGUOITAO = (string)sdr["NGUOITAO"];

                list.Add(item_tintuc);
            }
            return list;
        }

        public List<TIN_TUC_KHAC> getAllTinTuc1(int id)
        {
            connectdb = new ConnectDb();
            List<TIN_TUC_KHAC> list = new List<TIN_TUC_KHAC>();
            SqlCommand cmd = new SqlCommand("getAllTinTuc", connectdb.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                TIN_TUC_KHAC item_tintuc = new TIN_TUC_KHAC();
                if (id == (int) sdr["MATINTUC"])
                {
                    item_tintuc.MATINTUC = (int)sdr["MATINTUC"];
                    item_tintuc.TIEUDETINTUC = (string)sdr["TIEUDETINTUC"];
                    item_tintuc.NOIDUNGTINTUC = (string)sdr["NOIDUNGTINTUC"];
                    item_tintuc.URLANH = (string)sdr["URLANH"];
                    item_tintuc.NGAYTAO = (DateTime)sdr["NGAYTAO"];
                    item_tintuc.NGUOITAO = (string)sdr["NGUOITAO"];

                    list.Add(item_tintuc);
                }
                
            }
            return list;
        }
    }
}