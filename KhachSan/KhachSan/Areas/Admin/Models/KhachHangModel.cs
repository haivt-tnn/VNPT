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
    public class KhachHangModel
    {
        public ConnectDb c = null;
        public SqlDataReader rdr = null;
        public SqlDataReader rdr1 = null;
        public List<DANH_SACH_KHACH_HANG1> getAllKhachHang()
        {
            c = new ConnectDb();
            List<DANH_SACH_KHACH_HANG1> list = new List<DANH_SACH_KHACH_HANG1>();
            SqlCommand cmd = new SqlCommand("getAllKhachHang", c.conn);            
            cmd.CommandType = CommandType.StoredProcedure;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                DANH_SACH_KHACH_HANG1 item = new DANH_SACH_KHACH_HANG1();
                item.MAKHACHHANG1 = (long)rdr["MAKHACHHANG"];
                item.HOTEN1 = (string)rdr["HOTEN"];
                item.MADIACHI1 = (int)rdr["MADIACHI"];
                item.TENDIACHI = (string)rdr["TENDIACHI"];
                item.CHITIETDIACHI1 = (string)rdr["CHITIETDIACHI"];
                item.GIOITINH1 = (int)rdr["GIOITINH"];
                item.NGAYSINH1 = (DateTime)rdr["NGAYSINH"];
                item.SODIENTHOAI1 = (string)rdr["SODIENTHOAI"];
                item.EMAIL1 = (string)rdr["EMAIL"];
                item.SOGIAYTO1 = (string)rdr["SOGIAYTO"];
                item.LOAIGIAYTO1 = (string)rdr["TENLOAIGIAYTO"];
                item.NGAYTAO1 = (DateTime)rdr["NGAYTAO"];
                item.NGUOITAO1 = (string)rdr["NGUOITAO"];
                int id = (int)rdr["MADIACHI"];
                string diachi = (string)rdr["CHITIETDIACHI"] + ", " + (string)rdr["TENDIACHI"];
                SqlCommand cmd1 = new SqlCommand("getDiaChi", c.conn);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.Add(new SqlParameter("@MADIACHI", id));
                rdr1 = cmd1.ExecuteReader();
                rdr1.Read();
                id = (int)rdr1["MADIACHI"];
                diachi += ", " + (string)rdr1["TENDIACHI"];
                cmd1 = new SqlCommand("getDiaChi", c.conn);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.Add(new SqlParameter("@MADIACHI", id));
                rdr1 = cmd1.ExecuteReader();
                rdr1.Read();
                diachi += ", " + (string)rdr1["TENDIACHI"];
                item.ALLDIACHI = diachi;
                list.Add(item);
            }
            return list;
        }

        public List<DANH_SACH_KHACH_HANG2> getKhachHangDangO()
        {
            c = new ConnectDb();
            List<DANH_SACH_KHACH_HANG2> list = new List<DANH_SACH_KHACH_HANG2>();
            SqlCommand cmd = new SqlCommand("getKhachHangDangO", c.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                DANH_SACH_KHACH_HANG2 item = new DANH_SACH_KHACH_HANG2();
                item.MAKHACHHANG2 = (long)rdr["MAKHACHHANG"];
                item.HOTEN2 = (string)rdr["HOTEN"];
                item.MADIACHI2 = (int)rdr["MADIACHI"];
                item.TENDIACHI2 = (string)rdr["TENDIACHI"];
                item.CHITIETDIACHI2 = (string)rdr["CHITIETDIACHI"];
                item.GIOITINH2 = (int)rdr["GIOITINH"];
                item.NGAYSINH2 = (DateTime)rdr["NGAYSINH"];
                item.SODIENTHOAI2 = (string)rdr["SODIENTHOAI"];
                item.EMAIL2 = (string)rdr["EMAIL"];
                item.SOGIAYTO2 = (string)rdr["SOGIAYTO"];
                item.LOAIGIAYTO2 = (string)rdr["TENLOAIGIAYTO"];
                item.NGAYTAO2 = (DateTime)rdr["NGAYTAO"];
                item.NGUOITAO2 = (string)rdr["NGUOITAO"];
                int id = (int)rdr["MADIACHI"];
                item.MASOPHONG = (int)rdr["MASOPHONG"];
                string diachi = (string)rdr["CHITIETDIACHI"] + ", " + (string)rdr["TENDIACHI"];
                SqlCommand cmd1 = new SqlCommand("getDiaChi", c.conn);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.Add(new SqlParameter("@MADIACHI", id));
                rdr1 = cmd1.ExecuteReader();
                rdr1.Read();
                id = (int)rdr1["MADIACHI"];
                diachi += ", " + (string)rdr1["TENDIACHI"];
                cmd1 = new SqlCommand("getDiaChi", c.conn);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.Add(new SqlParameter("@MADIACHI", id));
                rdr1 = cmd1.ExecuteReader();
                rdr1.Read();
                diachi += ", " + (string)rdr1["TENDIACHI"];
                item.ALLDIACHI2 = diachi;
                list.Add(item);
            }
            return list;
        }

        public List<PHIEU_DAT_PHONG1> getKhachHangDatPhong()
        {
            c = new ConnectDb();
            List<PHIEU_DAT_PHONG1> list = new List<PHIEU_DAT_PHONG1>();
            SqlCommand cmd = new SqlCommand("getKhachHangDatPhong", c.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                PHIEU_DAT_PHONG1 item = new PHIEU_DAT_PHONG1();
                item.SOPHIEU = (long)rdr["SOPHIEU"];
                item.TENLOAIPHONG = (string)rdr["TENLOAIPHONG"];
                item.HOTENKHACHHANG = (string)rdr["HOTENKHACHHANG"];
                item.DIENTHOAI = (string)rdr["DIENTHOAI"];
                item.NGAYDUKIENDEN = (DateTime)rdr["NGAYDUKIENDEN"];
                item.NGAYDUKIENTRA = (DateTime)rdr["NGAYDUKIENTRA"];
                item.NGAYTAOPHIEU = (DateTime)rdr["NGAYTAOPHIEU"];
                item.TRANGTHAIPHIEU = (int)rdr["TRANGTHAIPHIEU"];
                item.TIENDATCOC = (double)rdr["TIENDATCOC"];
                item.LOAITIEN = (int)rdr["LOAITIEN"];
                item.SOLUONGPHONG = (int)rdr["SOLUONGPHONG"];
                list.Add(item);
            }
            return list;
        }
    }
}