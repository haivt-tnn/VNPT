using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Framework;

namespace KhachSan.Areas.Admin.Controllers
{
    public class PhongController : Controller
    {
        // GET: Admin/Phong
        [HttpGet]
        public ActionResult LoaiPhong()
        {
            var t = new Models.PhongModel();
            var model = t.getAllLoaiPhong();
            return View(model);
        }
        [HttpGet]
        public ActionResult KieuPhong()
        {
            var t = new Models.KieuPhongModel();
            var model = t.getAllKieuPhong();
            return View(model);
        }
        [HttpPost]
        public ActionResult them(DANH_MUC_LOAI_PHONG model)
        {
            model.TENLOAIPHONG = Request["txttenloaiphong"].ToString();
            model.MOTA = Request["txtmotaphong"].ToString();
            model.URLIMAGE = Request["txturlphong"].ToString();
            var t = new Models.PhongModel();
            var result = t.themLoaiPhong(model.TENLOAIPHONG, model.MOTA, model.URLIMAGE);
            if (result)
            {
                return RedirectToAction("LoaiPhong", "Phong");
            }
            else
            {
                return RedirectToAction("LoaiPhong", "Phong");
            }
        }
        [HttpPost]
        public ActionResult capnhat(DANH_MUC_LOAI_PHONG model)
        {
            model.MALOAIPHONG = Convert.ToInt32(Request["txtmap"].ToString());
            model.TENLOAIPHONG = Request["txttenp"].ToString();
            model.MOTA = Request["txtmotap"].ToString();
            if (Request["txtulrp"].ToString() != "")
            {
                model.URLIMAGE = Request["txtulrp"].ToString();
            }
            else
            {
                model.URLIMAGE = Request["txtulrp1"].ToString();
            }          
            var t = new Models.PhongModel();
            var result = t.updateLoaiPhong(model.MALOAIPHONG,model.TENLOAIPHONG, model.MOTA, model.URLIMAGE);
            if (result)
            {
                return RedirectToAction("LoaiPhong", "Phong");
            }
            else
            {
                return RedirectToAction("LoaiPhong", "Phong");
            }
        }
        [HttpPost]
        public ActionResult xoaphong(DANH_MUC_LOAI_PHONG model)
        {
            model.MALOAIPHONG = Convert.ToInt32(Request["txtidp"].ToString());
            var t = new Models.PhongModel();
            var result = t.deleteLoaiPhong(model.MALOAIPHONG);
            if (result)
            {
                return RedirectToAction("LoaiPhong", "Phong");
            }
            else
            {
                return RedirectToAction("LoaiPhong", "Phong");
            }
        }
    }

}
