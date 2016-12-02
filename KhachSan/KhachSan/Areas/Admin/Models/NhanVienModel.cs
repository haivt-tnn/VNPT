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

        public List<DanhSachNhanVien1> getAllNhanVien()
        {
            db = new ConnectDb();
            List<DanhSachNhanVien1> list = new List<DanhSachNhanVien1>();
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

                list.Add(new DanhSachNhanVien1(item_danh_muc_nguoi_dung.TAIKHOAN,
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

    }
}