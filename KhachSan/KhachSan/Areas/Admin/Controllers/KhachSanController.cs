using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Framework;
using KhachSan.Areas.Admin.Models;
using System.Web.Security;

namespace KhachSan.Areas.Admin.Controllers
{
    public class KhachSanController : Controller
    {
        // GET: Admin/KhachSan
        [Authorize]
        [HttpGet]
        public ActionResult Index()
        {
            UpdateKhacSanModel up = new UpdateKhacSanModel();
            var model = up.getAllGioiThieu();
            return View(model);
        }
        [Authorize]
        [HttpPost]
        public ActionResult Index(GIOITHIEU model)
        {
            model.IDGIOITHIEU = 1;
            model.TENGIOITHIEU = Request["txttieude"].ToString();
            model.MOTA = Request["txtnoidung"].ToString();
            if (Request["txtulr"].ToString() != "")
            {
                model.URLIMAGE = Request["txtfile"].ToString();
            }else
            {
                model.URLIMAGE = "/Image/Gioithieu/";
            }
            var result = new UpdateKhacSanModel().updateGioiThieu(model.IDGIOITHIEU, model.TENGIOITHIEU, model.MOTA, model.URLIMAGE);
            return RedirectToAction("Index", "KhachSan");
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "HomeAdmin");
        }
    }
}