using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Models.Framework;
using Models;

namespace KhachSan.Models
{
    public class EventModel
    {
        ConnectDb connectdb;
        SqlDataReader sdr;

        public List<SU_KIEN> getAllSuKien()
        {
            connectdb = new ConnectDb();
            List<SU_KIEN> list = new List<SU_KIEN>();
            SqlCommand cmd = new SqlCommand("getAllSuKien", connectdb.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                SU_KIEN item_sukien = new SU_KIEN();
                item_sukien.MASUKIEN = (int)sdr["MASUKIEN"];
                item_sukien.TIEUDESUKIEN = (string)sdr["TIEUDESUKIEN"];
                item_sukien.NOIDUNGSUKIEN = (string)sdr["NOIDUNGSUKIEN"];
                item_sukien.URLANH = (string)sdr["URLANH"];
                item_sukien.NGAYTAO = (DateTime)sdr["NGAYTAO"];
                item_sukien.NGUOITAO = (string)sdr["NGUOITAO"];

                list.Add(item_sukien);
            }
            return list;
        }

        public List<SU_KIEN> getAllSuKien1(int id)
        {
            connectdb = new ConnectDb();
            List<SU_KIEN> list = new List<SU_KIEN>();
            SqlCommand cmd = new SqlCommand("getAllSuKien", connectdb.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                SU_KIEN item_sukien = new SU_KIEN();
                if (id == (int)sdr["MASUKIEN"])
                {
                    item_sukien.MASUKIEN = (int)sdr["MASUKIEN"];
                    item_sukien.TIEUDESUKIEN = (string)sdr["TIEUDESUKIEN"];
                    item_sukien.NOIDUNGSUKIEN = (string)sdr["NOIDUNGSUKIEN"];
                    item_sukien.URLANH = (string)sdr["URLANH"];
                    item_sukien.NGAYTAO = (DateTime)sdr["NGAYTAO"];
                    item_sukien.NGUOITAO = (string)sdr["NGUOITAO"];

                    list.Add(item_sukien);
                }
               
            }
            return list;
        }
    }
}