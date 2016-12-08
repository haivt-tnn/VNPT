using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc;
using Models.Framework;
using System.IO;
using System.Web.Security;

namespace KhachSan.Areas.Admin.Controllers
{
    public class QuangCaoController : Controller
    {
        // GET: Admin/QuangCao
        [Authorize]
        [HttpGet]
        public ActionResult Index()
        {
            var t = new Models.AdsModel();
            var model = t.getAllQC();
            return View(model);
        }
        [Authorize]
        [HttpPost]
        public ActionResult Them(QUANG_CAO model)
        {
            model.TENQC = Request["txttenQuangCao"].ToString();
            model.LINK = Request["txtLink"].ToString();
            if (Request.Files.Count > 0)
            {
                var file = Request.Files[0];
                if (file != null && file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Image/Ads/"), fileName);
                    file.SaveAs(path);
                    model.HINH = "/Image/Ads/" + fileName;
                }
                else
                {
                    model.HINH = "/Image/Ads/banner_728x90.gif";
                }
            }
            model.TT = Convert.ToInt32(Request["tttrangthaiadd"]);
            if (model.TENQC != "")
            {
                var t = new Models.AdsModel();
                var result = t.insertOneQC(model.TENQC, model.HINH, model.LINK, model.TT);
                if (result)
                {
                    return RedirectToAction("Index", "QuangCao");
                }
                else
                {
                    return RedirectToAction("Index", "QuangCao");
                }
            }
            else
            {
                return RedirectToAction("Index", "QuangCao");
            }

        }

        [Authorize]
        [HttpPost]
        public ActionResult Capnhat(QUANG_CAO model)
        {
            model.ID = Convert.ToInt32(Request["txtmaqc"]);
            model.TENQC = Request["txttenqc"].ToString();
            model.LINK = Request["txtlinkqc"].ToString();
            if (Request.Files.Count > 0)
            {
                var file = Request.Files[0];
                if (file != null && file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Image/Ads/"), fileName);
                    file.SaveAs(path);
                    model.HINH = "/Image/Ads/" + fileName;
                }
                else
                {
                    model.HINH = Request["txturlqc1"].ToString();
                }
            }
            model.TT = Convert.ToInt32(Request["tttrangthaiup"].ToString());
            if (model.TENQC != "")
            {
                var t = new Models.AdsModel();
                var result = t.UpdateOneQC(model.ID, model.TENQC, model.HINH, model.LINK, model.TT);
                if (result)
                {
                    return RedirectToAction("Index", "QuangCao");
                }
                else
                {
                    return RedirectToAction("Index", "QuangCao");
                }
            }
            else
            {
                return RedirectToAction("Index", "QuangCao");
            }

        }

        [Authorize]
        [HttpPost]
        public ActionResult Xoa(QUANG_CAO model)
        {
            model.ID = Convert.ToInt32(Request["txtiads"].ToString());
            var img = Request["txtiad"].ToString();
            var t = new Models.AdsModel();
            var result = t.delOneQC(model.ID);
            if (result)
            {
                if (!img.Equals("/Image/Ads/banner_728x90.gif"))
                {
                    var fullPath = Server.MapPath(img);
                    if (System.IO.File.Exists(fullPath))
                    {
                        System.IO.File.Delete(fullPath);
                    }
                }
                return RedirectToAction("Index", "QuangCao");
            }
            else
            {
                return RedirectToAction("Index", "QuangCao");
            }
        }
    }
}