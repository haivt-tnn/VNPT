using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KhachSan.Models;

namespace KhachSan.Controllers
{
    public class CulinaryController : Controller
    {
        // GET: Culinary
        qlks_dbEntities db = new qlks_dbEntities();
        public ActionResult Index()
        {
            return View(db.GetAllDichVu("AT"));
        }
        public ActionResult Details(int id)
        {
            return View(db.GetOneDichVu(id));
        }
    }
}