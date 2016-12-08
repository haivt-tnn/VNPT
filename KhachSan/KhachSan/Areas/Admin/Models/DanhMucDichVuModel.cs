using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Models;
using Models.Framework;

namespace KhachSan.Areas.Admin.Models
{
    public class DanhMucDichVuModel
    {
        public ConnectDb c = null;
        public SqlDataReader rdr = null;

        public List<DichVu> getAllDichVu()
        {
            c = new ConnectDb();
            List<DichVu> list = new List<DichVu>();
            SqlCommand cmd = new SqlCommand("getAllDichVu", c.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                DichVu item = new DichVu();
                item.MADICHVU = (int)rdr["MADICHVU"];
                item.TENDICHVU = (string)rdr["TENDICHVU"];
                item.DONVITINH = (string)rdr["DONVITINH"];
                item.DONGIA = (double)rdr["DONGIA"];
                item.LOAITIEN = (int)rdr["LOAITIEN"];
                item.TENLOAITIEN = (string)rdr["TENLOAITIEN"];
                list.Add(item);
            }
            return list;
        }

        public bool insert_danh_muc_dich_vu(String tendichvu,String donvitinh,double? dongia,int? loaitien)
        {
            c = new ConnectDb();
            SqlCommand cmd = new SqlCommand("INSERT_DANH_MUC_DICH_VU",c.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@TENDICHVU", tendichvu));
            cmd.Parameters.Add(new SqlParameter("@DONVITINH", donvitinh));
            cmd.Parameters.Add(new SqlParameter("@DONGIA", dongia));
            cmd.Parameters.Add(new SqlParameter("@LOAITIEN", loaitien));
            cmd.ExecuteNonQuery();
            return true;

        }


        public bool updateDichVu(int? madichvu, string tendichvu , string donvitinh, double? dongia, int? loaitien)
        {
            c = new ConnectDb();
            SqlCommand cmd = new SqlCommand("updateDanhMucDichVu", c.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MADICHVU", madichvu));
            cmd.Parameters.Add(new SqlParameter("@TENDICHVU", tendichvu));
            cmd.Parameters.Add(new SqlParameter("@DONVITINH", donvitinh));
            cmd.Parameters.Add(new SqlParameter("@DONGIA", dongia));
            cmd.Parameters.Add(new SqlParameter("@LOAITIEN", loaitien));
            cmd.ExecuteNonQuery();
            return true;
        }

        public List<DANH_MUC_LOAI_TIEN> LoaiTien()
        {
            c = new ConnectDb();
            SqlDataReader rdr;
            List<DANH_MUC_LOAI_TIEN> list = new List<DANH_MUC_LOAI_TIEN>();
            SqlCommand cmd = new SqlCommand("getAllLoaiTien", c.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                DANH_MUC_LOAI_TIEN item = new DANH_MUC_LOAI_TIEN();
                item.MALOAITIEN = int.Parse(rdr["MALOAITIEN"].ToString());
                item.TENLOAITIEN = rdr["TENLOAITIEN"].ToString();
                list.Add(item);
            }
            return list;
        }

    }
}