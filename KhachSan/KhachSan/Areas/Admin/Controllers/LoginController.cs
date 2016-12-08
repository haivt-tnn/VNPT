using KhachSan.Areas.Admin.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Models.Framework;

namespace KhachSan.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
            var result = new TaiKhoanModel().Login(model.taikhoan, model.matkhau);
            if (result && ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(model.taikhoan, model.rememberMe);
                return RedirectToAction("Index","HomeAdmin");
            }
            else
            {
                ModelState.AddModelError("", "Sai tên đăng nhập hoặc mật khẩu!");
            }
            return View(model);
        }
    }
}