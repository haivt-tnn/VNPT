using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models.Framework;
using Models;
using System.Data;
using System.Data.SqlClient;


namespace KhachSan.Areas.Admin.Models
{
    public class NhanVienModel
    {
        ConnectDb db;
        SqlDataReader sdr;

        public List<DANH_SACH_NHAN_VIEN_1> getAllNhanVien()
        {
            db = new ConnectDb();
            List<DANH_SACH_NHAN_VIEN_1> list = new List<DANH_SACH_NHAN_VIEN_1>();
            SqlCommand cmd = new SqlCommand("SELECT_DANH_SACH_NHAN_VIEN", db.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                DANH_MUC_NGUOI_DUNG item_danh_muc_nguoi_dung = new DANH_MUC_NGUOI_DUNG();
                DANH_MUC_DIA_CHI item_danh_muc_dia_chi = new DANH_MUC_DIA_CHI();
                DANH_MUC_GIOI_TINH item_danh_muc_gioi_tinh = new DANH_MUC_GIOI_TINH();
                item_danh_muc_nguoi_dung.TAIKHOAN = (string)sdr["TAIKHOAN"];
                item_danh_muc_nguoi_dung.MATKHAU = (string)sdr["MATKHAU"];
                item_danh_muc_nguoi_dung.HOTEN = (string)sdr["HOTEN"];
                item_danh_muc_gioi_tinh.CHITIET = (string)sdr["CHITIET"];
                item_danh_muc_nguoi_dung.NGAYSINH = (DateTime)sdr["NGAYSINH"];
                item_danh_muc_nguoi_dung.SODIENTHOAI = (string)sdr["SODIENTHOAI"];
                item_danh_muc_nguoi_dung.EMAIL = (string)sdr["EMAIL"];
                item_danh_muc_dia_chi.TENDIACHI = (string)sdr["TENDIACHI"];
                item_danh_muc_nguoi_dung.CHITIETDIACHI = (string)sdr["CHITIETDIACHI"];
                item_danh_muc_nguoi_dung.TRANGTHAI = (int)sdr["TRANGTHAI"];

                list.Add(new DANH_SACH_NHAN_VIEN_1(item_danh_muc_nguoi_dung.TAIKHOAN,
                                                  item_danh_muc_nguoi_dung.HOTEN,
                                                  item_danh_muc_nguoi_dung.MATKHAU,
                                                  item_danh_muc_gioi_tinh.CHITIET,
                                                  item_danh_muc_nguoi_dung.NGAYSINH,
                                                  item_danh_muc_nguoi_dung.SODIENTHOAI,
                                                  item_danh_muc_nguoi_dung.EMAIL,
                                                  item_danh_muc_dia_chi.TENDIACHI,
                                                  item_danh_muc_nguoi_dung.CHITIETDIACHI,
                                                  item_danh_muc_nguoi_dung.TRANGTHAI));

            }
            return list;
        }

        public List<DANH_MUC_GIOI_TINH> getAllGioiTinh()
        {
            db = new ConnectDb();
            List<DANH_MUC_GIOI_TINH> list = new List<DANH_MUC_GIOI_TINH>();
            SqlCommand cmd = new SqlCommand("getAllGioiTinh", db.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                DANH_MUC_GIOI_TINH gt = new DANH_MUC_GIOI_TINH();
                gt.GIOITINH = (int)sdr["GIOITINH"];
                gt.CHITIET = (string)sdr["CHITIET"];

                list.Add(gt);
            }
            return list;
        }

        public List<DANH_MUC_DIA_CHI> getDiaChiTinh()
        {
            db = new ConnectDb();
            List<DANH_MUC_DIA_CHI> list = new List<DANH_MUC_DIA_CHI>();
            SqlCommand cmd = new SqlCommand("SELECT_DIA_CHI_TINH", db.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                DANH_MUC_DIA_CHI dc = new DANH_MUC_DIA_CHI();
                dc.MADIACHI= (int)sdr["MADIACHI"];
                dc.MADIACHICHA = (int)sdr["MADIACHICHA"];
                dc.TENDIACHI = (string)sdr["TENDIACHI"];

                list.Add(dc);
            }
            return list;
        }
        public List<DANH_MUC_DIA_CHI> getDiaChiCon(int dccha)
        {
            db = new ConnectDb();
            List<DANH_MUC_DIA_CHI> list = new List<DANH_MUC_DIA_CHI>();
            SqlCommand cmd = new SqlCommand("SELECT_DIA_CHI_CON", db.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MADIACHICHA", dccha));
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                DANH_MUC_DIA_CHI dc = new DANH_MUC_DIA_CHI();
                dc.MADIACHI = (int)sdr["MADIACHI"];
                dc.MADIACHICHA = (int)sdr["MADIACHICHA"];
                dc.TENDIACHI = (string)sdr["TENDIACHI"];

                list.Add(dc);
            }
            return list;
        }
        public List<DANH_MUC_VI_TRI_CONG_TAC> getAllViTriCongTac()
        {
            db = new ConnectDb();
            List<DANH_MUC_VI_TRI_CONG_TAC> list = new List<DANH_MUC_VI_TRI_CONG_TAC>();
            SqlCommand cmd = new SqlCommand("SELECT_DANH_MUC_VI_TRI_CONG_TAC", db.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                DANH_MUC_VI_TRI_CONG_TAC dmvtct = new DANH_MUC_VI_TRI_CONG_TAC();
                dmvtct.MAVITRICONGTAC = (int)sdr["MAVITRICONGTAC"];
                dmvtct.VITRICONGTAC = (string)sdr["VITRICONGTAC"];

                list.Add(dmvtct);
            }
            return list;
        }


        public bool themNhanVien(DANH_MUC_NGUOI_DUNG dmnd)
        {
            db = new ConnectDb();
            SqlCommand cmd = new SqlCommand("INSERT_DANH_MUC_NGUOI_DUNG", db.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@TAIKHOAN", dmnd.TAIKHOAN));
            cmd.Parameters.Add(new SqlParameter("@MATKHAU", dmnd.MATKHAU));
            cmd.Parameters.Add(new SqlParameter("@NHOMQUYEN", dmnd.NHOMQUYEN));
            cmd.Parameters.Add(new SqlParameter("@HOTEN", dmnd.HOTEN));
            cmd.Parameters.Add(new SqlParameter("@GIOITINH", dmnd.GIOITINH));
            cmd.Parameters.Add(new SqlParameter("@NGAYSINH", dmnd.NGAYSINH));
            cmd.Parameters.Add(new SqlParameter("@SODIENTHOAI", dmnd.SODIENTHOAI));
            cmd.Parameters.Add(new SqlParameter("@EMAIL", dmnd.EMAIL));
            cmd.Parameters.Add(new SqlParameter("@MADIACHI", dmnd.MADIACHI));
            cmd.Parameters.Add(new SqlParameter("@CHITIETDIACHI", dmnd.CHITIETDIACHI));
            cmd.Parameters.Add(new SqlParameter("@MAVITRICONGTAC", dmnd.VITRICONGTAC));
            cmd.Parameters.Add(new SqlParameter("@TRANGTHAI", dmnd.TRANGTHAI));

            cmd.ExecuteNonQuery();
            return true;
        }
        public bool suaNhanVien(DANH_MUC_NGUOI_DUNG dmnd)
        {
            db = new ConnectDb();
            SqlCommand cmd = new SqlCommand("UPDATE_DANH_MUC_NGUOI_DUNG", db.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@TAIKHOAN", dmnd.TAIKHOAN));
            cmd.Parameters.Add(new SqlParameter("@MATKHAU", dmnd.MATKHAU));
            cmd.Parameters.Add(new SqlParameter("@NHOMQUYEN", dmnd.NHOMQUYEN));
            cmd.Parameters.Add(new SqlParameter("@HOTEN", dmnd.HOTEN));
            cmd.Parameters.Add(new SqlParameter("@GIOITINH", dmnd.GIOITINH));
            cmd.Parameters.Add(new SqlParameter("@NGAYSINH", dmnd.NGAYSINH));
            cmd.Parameters.Add(new SqlParameter("@SODIENTHOAI", dmnd.SODIENTHOAI));
            cmd.Parameters.Add(new SqlParameter("@EMAIL", dmnd.EMAIL));
            cmd.Parameters.Add(new SqlParameter("@MADIACHI", dmnd.MADIACHI));
            cmd.Parameters.Add(new SqlParameter("@CHITIETDIACHI", dmnd.CHITIETDIACHI));
            cmd.Parameters.Add(new SqlParameter("@MAVITRICONGTAC", dmnd.VITRICONGTAC));
            cmd.Parameters.Add(new SqlParameter("@TRANGTHAI", dmnd.TRANGTHAI));

            cmd.ExecuteNonQuery();
            return true;
        }
    }
}

