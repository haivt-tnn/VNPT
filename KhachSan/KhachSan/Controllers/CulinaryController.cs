using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhachSan.Controllers
{
    public class CulinaryController : Controller
    {
        // GET: Culinary
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        { return View(); }
    }
}