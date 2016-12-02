using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhachSan.Controllers
{
    public class SaleController : Controller
    {
        // GET: Sale
        
        public ActionResult Index()
        {
            var km = new Models.SaleModel().getAllKhuyenMai();          
            return View(km);
        }

        [HttpGet]
        public ActionResult Details()
        {
            string str = Request.QueryString["Id"];
            int id = Convert.ToInt32(str);
            var km = new Models.SaleModel().getAllKhuyenMai1(id);
            return View(km);
        }
    }
}