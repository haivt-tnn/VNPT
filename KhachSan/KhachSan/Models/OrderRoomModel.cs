using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Models.Framework;

namespace KhachSan.Models
{
    public class OrderRoomModel
    {
        public ConnectDb c = null;
        public bool bookRoom(int? loaip,string hoten, string dt, DateTime? ngayden, DateTime? ngaydi,DateTime? ngaytao,int? trangthai, double? tiencoc, int? loaitien,string nguoixacnhan, DateTime? ngayxnh)
        {
            c = new ConnectDb();
            SqlCommand cmd = new SqlCommand("INSERT_PHIEU_DAT_PHONG", c.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@LOAIPHONG", loaip));
            cmd.Parameters.Add(new SqlParameter("@HOTENKHACHHANG", hoten));
            cmd.Parameters.Add(new SqlParameter("@DIENTHOAI", dt));
            cmd.Parameters.Add(new SqlParameter("@NGAYDUKIENDEN", ngayden));
            cmd.Parameters.Add(new SqlParameter("@NGAYDUKIENTRA", ngaydi));
            cmd.Parameters.Add(new SqlParameter("@NGAYTAOPHIEU", DateTime.Now));
            cmd.Parameters.Add(new SqlParameter("@TRANGTHAIPHIEU", null));
            cmd.Parameters.Add(new SqlParameter("@TIENDATCOC", null));
            cmd.Parameters.Add(new SqlParameter("@LOAITIEN", 1));
            cmd.Parameters.Add(new SqlParameter("@NGUOIXACNHAN", null));
            cmd.Parameters.Add(new SqlParameter("@NGAYXACNHAN", null));
            cmd.Parameters.Add(new SqlParameter("@SOLUONGPHONG", null));
            cmd.ExecuteNonQuery();
            return true;
        }
    }
}