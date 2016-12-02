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
            var t = new Models.GIAITRI_MODEL();
            var model = t.getTypeTienIch(4);
            return View(model);
        }
        [HttpGet]
        public ActionResult Details()
        {
            string str = Request.QueryString["Id"];
            int id = Convert.ToInt32(str);
            var t = new Models.GIAITRI_MODEL();
            var model = t.getDetailTienIch(4, id);
            return View(model);
        }
    }
}