using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhachSan.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult Index()
        {
            var test = new List<string>()
            {
                "Hội nghị",
                "Tiệc cưới",
                "2k3"
            };
            ViewBag.Test = test;
            return View();
        }
        
        public ActionResult Details(string content)
        {
            //string content = Request["content"];
            ViewBag.Id = "Tham số nhận được: " + content;
            return View();
        }
    }
}