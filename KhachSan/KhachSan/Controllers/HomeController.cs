using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhachSan.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<object> myModel = new List<object>();
            var tt = new Models.Gioithieu();
            var model = tt.getAllGioiThieu();
            var ttt = new Models.LoaiPhongModel();
            var model2 = ttt.getAllLoaiPhong();
            myModel.Add(model);
            myModel.Add(model2);
            return View(myModel);
        }
    }
}