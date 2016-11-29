using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhachSan.Areas.Admin.Controllers
{
    public class ThongkeController : Controller
    {
        // GET: Admin/Thongke
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Baocao()
        {
            return View();
        }
    }
}