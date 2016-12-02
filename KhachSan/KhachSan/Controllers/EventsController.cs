using System;
using System.Web.Mvc;

namespace KhachSan.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult Index()
        {
            var t = new Models.DICHVU_MODEL();
            var model = t.get1TienIch();
            return View(model);
        }
        [HttpGet]
        public ActionResult Details()
        {
            string str = Request.QueryString["Id"];
            int id = Convert.ToInt32(str);
            var t = new Models.DICHVU_MODEL();
            var model = t.getDetailTienIch(id);
            return View(model);
        }
    }
}