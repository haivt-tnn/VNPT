using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhachSan.Areas.Admin.Controllers
{
    public class QuangCaoController : Controller
    {
        // GET: Admin/QuangCao
        public ActionResult Index()
        {
            var t = new Models.AdsModel();
            var model = t.getAllQC();
            return View(model);
        }
    }
}