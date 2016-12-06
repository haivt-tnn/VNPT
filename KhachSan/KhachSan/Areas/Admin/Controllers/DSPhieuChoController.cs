using KhachSan.Areas.Admin.Models;
using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhachSan.Areas.Admin.Controllers
{
    public class DSPhieuChoController : Controller
    {
        // GET: Admin/DSPhieuCho
        public ActionResult Index()
        {
            KhachHangModel t = new KhachHangModel();
            List<PHIEU_DAT_PHONG1> model = t.getKhachHangDatPhong();
            return View(model);
        }
    }
}