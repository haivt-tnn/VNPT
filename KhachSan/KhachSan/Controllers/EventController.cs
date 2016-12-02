using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhachSan.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        public ActionResult Index()
        {
            var sk = new Models.EventModel().getAllSuKien();

            return View(sk);
        }

        [HttpGet]
        public ActionResult Details()
        {
            string str = Request.QueryString["Id"];
            int id = Convert.ToInt32(str);
            var sk = new Models.EventModel().getAllSuKien1(id);
            return View(sk);
        }
    }
}