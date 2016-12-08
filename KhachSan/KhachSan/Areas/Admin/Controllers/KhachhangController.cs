using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Framework;
using KhachSan.Areas.Admin.Models;

namespace KhachSan.Areas.Admin.Controllers
{
    public class KhachhangController : Controller
    {
        // GET: Admin/Khachhang
        [HttpGet]
        [Authorize]
        public ActionResult Index()
        {
            KhachHangModel t = new KhachHangModel();
            List<DANH_SACH_KHACH_HANG1> model = t.getAllKhachHang();
            return View(model);
        }

        [HttpGet]
        [Authorize]
        public ActionResult KHdango()
        {
            KhachHangModel t = new KhachHangModel();
            List<DANH_SACH_KHACH_HANG2> model = t.getKhachHangDangO();
            return View(model);

        }

        [HttpGet]
        [Authorize]
        public ActionResult KHdatphong()
        {
            KhachHangModel t = new KhachHangModel();
            List<PHIEU_DAT_PHONG1> model = t.getKhachHangDatPhong();
            return View(model);
        }
    }
}