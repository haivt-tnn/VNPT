using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhachSan.Areas.Admin.Controllers
{
    public class KhachhangController : Controller
    {
        // GET: Admin/Khachhang
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult KHodau()
        {
            return View();

        }
            public ActionResult KHdatphong()
        {
            return View();
        }
    }
}