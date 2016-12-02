using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhachSan.Controllers
{
    public class OtherEventController : Controller
    {
        // GET: OtherEvent
        public ActionResult Index()
        {
            var tt = new Models.OtherEventModel().getAllTinTuc();
            return View(tt);
        }
        [HttpGet]
        public ActionResult Details()
        {
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            var tt = new Models.OtherEventModel().getAllTinTuc1(id);
            return View(tt);
        }
    }
}