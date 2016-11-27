using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhachSan.Controllers
{
    public class RelaxController : Controller
    {
        // GET: Relax
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        { return View(); }
    }
}