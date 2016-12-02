using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KhachSan.Models;

namespace KhachSan.Controllers
{
    public class RelaxController : Controller
    {
        qlks_dbEntities db = new qlks_dbEntities();
        // GET: Events
        public ActionResult Index()
        {
            return View(db.GetAllDichVu("TG"));
        }
        public ActionResult Details(int id)
        {
            return View(db.GetOneDichVu(id));
        }
    }
}