using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Framework;

namespace KhachSan.Areas.Admin.Controllers
{
    public class NhanvienController : Controller
    {

        public static List<object> list;
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Nhanvien
        [HttpGet]
        public ActionResult DSnhanvien()
        {
            list = new List<object>();

            var dsnv = new Models.NhanVienModel().getAllNhanVien();
            var gt = new Models.NhanVienModel().getAllGioiTinh();
            var dct = new Models.NhanVienModel().getDiaChiTinh();
            var dcc = new Models.NhanVienModel().getDiaChiCon(Convert.ToInt32(Request["txtdiachitinhthanhpho"]));
            var dmvtct = new Models.NhanVienModel().getAllViTriCongTac();

            list.Add(dsnv);
            list.Add(gt);
            list.Add(dct);
            list.Add(dcc);
            list.Add(dmvtct);

            return View(list);
        }

        [Authorize]
        [HttpPost]
        public ActionResult themNhanVien(DANH_MUC_NGUOI_DUNG dmnd)
        {
            dmnd.TAIKHOAN = Request["txttaikhoan"].ToString();
            dmnd.MATKHAU = Request["txtmatkhau"].ToString();
            dmnd.HOTEN = Request["txthoten"].ToString();
            dmnd.NHOMQUYEN = Request["txtnhomquyen"].ToString();
            dmnd.GIOITINH = Convert.ToInt32(Request["txtgioitinh"]);
            dmnd.NGAYSINH = Convert.ToDateTime(Request["txtngaysinh"]);
            dmnd.SODIENTHOAI = Request["txtsodienthoai"].ToString();
            dmnd.EMAIL = Request["txtemail"].ToString();
            dmnd.MADIACHI = Convert.ToInt32(Request["txtdiachitinhthanhpho"]);
            dmnd.CHITIETDIACHI = Request["txtdiachisonha"].ToString() + Request["txtdiachixa"].ToString() + Request["txtdiachiquanhuyen"].ToString() + Request["txtdiachitinhthanhpho"].ToString();
            dmnd.VITRICONGTAC = Convert.ToInt32(Request["txtvitricongtac"]);
            dmnd.TRANGTHAI = Convert.ToInt32(Request["txttrangthai"]);

            var nv = new Models.NhanVienModel();
            nv.themNhanVien(dmnd);

            return RedirectToAction("DSnhanvien", "Nhanvien");
        }
        public ActionResult suaNhanVien(DANH_MUC_NGUOI_DUNG dmnd)
        {
            dmnd.TAIKHOAN = Request["txttaikhoan"].ToString();
            dmnd.MATKHAU = Request["txtmatkhau"].ToString();
            dmnd.HOTEN = Request["txthoten"].ToString();
            dmnd.NHOMQUYEN = Request["txtnhomquyen"].ToString();
            dmnd.GIOITINH = Convert.ToInt32(Request["txtgioitinh"]);
            dmnd.NGAYSINH = Convert.ToDateTime(Request["txtngaysinh"]);
            dmnd.SODIENTHOAI = Request["txtsodienthoai"].ToString();
            dmnd.EMAIL = Request["txtemail"].ToString();
            dmnd.MADIACHI = Convert.ToInt32(Request["txtdiachitinhthanhpho"]);
            dmnd.CHITIETDIACHI = Request["txtdiachisonha"].ToString() + Request["txtdiachixa"].ToString() + Request["txtdiachiquanhuyen"].ToString() + Request["txtdiachitinhthanhpho"].ToString();
            dmnd.VITRICONGTAC = Convert.ToInt32(Request["txtvitricongtac"]);
            dmnd.TRANGTHAI = Convert.ToInt32(Request["txttrangthai"]);

            var nv = new Models.NhanVienModel();
            nv.suaNhanVien(dmnd);

            return RedirectToAction("DSnhanvien", "Nhanvien");
        }
        
    }

}