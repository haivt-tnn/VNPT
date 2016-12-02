using KhachSan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhachSan.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            var tt = new Gioithieu();
            var model = tt.getAllGioiThieu();
            return View(model);
        }
    }
}