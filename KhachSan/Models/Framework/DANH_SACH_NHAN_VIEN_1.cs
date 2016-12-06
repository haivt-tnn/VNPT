using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Framework
{
    public class DANH_SACH_NHAN_VIEN_1
    {
        private string taiKhoan;

        public string TaiKhoan
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }
        private string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        private string matKhau;

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        private string gioiTinh;

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        private DateTime? ngaySinh;

        public DateTime? NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        private string soDienThoai;

        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string tenDiaChi;

        public string TenDiaChi
        {
            get { return tenDiaChi; }
            set { tenDiaChi = value; }
        }
        private int? trangThai;
        private string chiTietDiaChi;

        public string ChiTietDiaChi
        {
            get { return chiTietDiaChi; }
            set { chiTietDiaChi = value; }
        }

        public int? TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public DANH_SACH_NHAN_VIEN_1() { }
        public DANH_SACH_NHAN_VIEN_1(string taikhoan, string hoten, string matkhau, string gioitinh, DateTime? ngaysinh, string sdt, string email, string tendiachi, string chitietdiachi, int? trangthai)
        {
            this.taiKhoan = taikhoan;
            this.hoTen = hoten;
            this.matKhau = matkhau;
            this.gioiTinh = gioitinh;
            this.ngaySinh = ngaysinh;
            this.soDienThoai = sdt;
            this.email = email;
            this.tenDiaChi = tendiachi;
            this.trangThai = trangthai;
            this.chiTietDiaChi = chitietdiachi;

        }
    }
}
