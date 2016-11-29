using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhachSan.Areas.Admin.Controllers
{
    public class DichVuController : Controller
    {
        // GET: Admin/DichVu
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Thongke()
        {
            return View();
        }
    }
}