using KhachSan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhachSan.Controllers
{
    public class ViewRoomController : Controller
    {
        // GET: ViewRoom        
        [HttpGet]
        public ActionResult Index()
        {
            string str = Request.QueryString["Id"];
            Console.WriteLine(str);
            int id = Convert.ToInt32(str);
            var ttt = new Models.LoaiPhongModel();
            var model1 = ttt.getChiTietLoaiPhong(id);
            return View(model1);
        }
        public ActionResult Details()
        { return View(); }
    }
}