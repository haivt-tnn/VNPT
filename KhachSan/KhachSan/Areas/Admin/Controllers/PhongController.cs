using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Framework;
using System.IO;
using System.Web.Security;

namespace KhachSan.Areas.Admin.Controllers
{
    public class PhongController : Controller
    {
        // GET: Admin/Phong
        //Loai Phong--------------------------------------------------------------------------------------------------
        [Authorize]
        [HttpGet]
        public ActionResult LoaiPhong()
        {
            var t = new Models.PhongModel();
            var model = t.getAllLoaiPhong();
            return View(model);
        }

        [Authorize]
        [HttpPost]
        public ActionResult them(DANH_MUC_LOAI_PHONG model)
        {
            model.TENLOAIPHONG = Request["txttenloaiphong"].ToString();
            model.MOTA = Request["txtmotaphong"].ToString();
            if (Request.Files.Count > 0)
            {
                var file = Request.Files[0];
                if (file != null && file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Image/Room/"), fileName);
                    file.SaveAs(path);
                    model.URLIMAGE = "/Image/Room/" + fileName;
                }
                else
                {
                    model.URLIMAGE = "/Image/Room/1.jpg";
                }
            }
            if (model.TENLOAIPHONG != "")
            {
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
            else
            {
                return RedirectToAction("LoaiPhong", "Phong");
            }

        }

        [Authorize]
        [HttpPost]
        public ActionResult capnhat(DANH_MUC_LOAI_PHONG model)
        {
            model.MALOAIPHONG = Convert.ToInt32(Request["txtmap"].ToString());
            model.TENLOAIPHONG = Request["txttenp"].ToString();
            model.MOTA = Request["txtmotap"].ToString();
            if (Request.Files.Count > 0)
            {
                var file = Request.Files[0];
                if (file != null && file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Image/Room/"), fileName);
                    file.SaveAs(path);
                    model.URLIMAGE = "/Image/Room/" + fileName;
                }
                else
                {
                    model.URLIMAGE = Request["txtulrp1"].ToString();
                }
            }
            if (model.TENLOAIPHONG != "")
            {
                var t = new Models.PhongModel();
                var result = t.updateLoaiPhong(model.MALOAIPHONG, model.TENLOAIPHONG, model.MOTA, model.URLIMAGE);
                if (result)
                {
                    return RedirectToAction("LoaiPhong", "Phong");
                }
                else
                {
                    return RedirectToAction("LoaiPhong", "Phong");
                }
            }
            else
            {
                return RedirectToAction("LoaiPhong", "Phong");
            }

        }

        [Authorize]
        [HttpPost]
        public ActionResult xoaphong(DANH_MUC_LOAI_PHONG model)
        {
            model.MALOAIPHONG = Convert.ToInt32(Request["txtidp"].ToString());
            var img = Request["txtip"].ToString();
            var t = new Models.PhongModel();
            var result = t.deleteLoaiPhong(model.MALOAIPHONG);
            if (result)
            {
                if (!img.Equals("/Image/Room/1.jpg"))
                {
                    var fullPath = Server.MapPath(img);
                    if (System.IO.File.Exists(fullPath))
                    {
                        System.IO.File.Delete(fullPath);
                    }
                }
                return RedirectToAction("LoaiPhong", "Phong");
            }
            else
            {
                return RedirectToAction("LoaiPhong", "Phong");
            }
        }

        //Kieu phong--------------------------------------------------------------------------------------------------
        [Authorize]
        [HttpGet]
        public ActionResult KieuPhong()
        {
            var t = new Models.KieuPhongModel();
            var model = t.getAllKieuPhong();
            return View(model);
        }

        [Authorize]
        [HttpPost]
        public ActionResult themkieu(DANH_MUC_KIEU_PHONG model)
        {
            model.TENKIEUPHONG = Request["txttenkieu"].ToString();
            model.MOTA = Request["txtmotakieu"].ToString();
            model.SONGUOILON = Convert.ToInt32(Request["txttsonguoilon"].ToString());
            model.SOTREEM = Convert.ToInt32(Request["txttsotreem"].ToString());

            if (model.TENKIEUPHONG != "" && model.MOTA != "" && model.SONGUOILON != null && model.SOTREEM != null)
            {
                var t = new Models.KieuPhongModel();
                var result = t.themKieuPhong(model.TENKIEUPHONG, model.MOTA, model.SONGUOILON, model.SOTREEM);
                if (result)
                {
                    return RedirectToAction("KieuPhong", "Phong");
                }
                else
                {
                    return RedirectToAction("KieuPhong", "Phong");
                }
            }
            else
            {
                return RedirectToAction("KieuPhong", "Phong");
            }

        }

        [Authorize]
        [HttpPost]
        public ActionResult capnhatkieu(DANH_MUC_KIEU_PHONG model)
        {
            model.MAKIEUPHONG = int.Parse(Request["txtmakieup"].ToString());
            model.TENKIEUPHONG = Request["txttenkieup"].ToString();
            model.MOTA = Request["txtmotakieup"].ToString();
            model.SONGUOILON = Convert.ToInt32(Request["txttsonguoilonp"].ToString());
            model.SOTREEM = Convert.ToInt32(Request["txttsotreemp"].ToString());

            if (model.TENKIEUPHONG != "" && model.MOTA != "" && model.SONGUOILON != null && model.SOTREEM != null)
            {
                var t = new Models.KieuPhongModel();
                var result = t.updateKieuPhong(model.MAKIEUPHONG, model.TENKIEUPHONG, model.MOTA, model.SONGUOILON, model.SOTREEM);
                if (result)
                {
                    return RedirectToAction("KieuPhong", "Phong");
                }
                else
                {
                    return RedirectToAction("KieuPhong", "Phong");
                }
            }
            else
            {
                return RedirectToAction("KieuPhong", "Phong");
            }

        }

        [Authorize]
        [HttpPost]
        public ActionResult xoakieu(DANH_MUC_KIEU_PHONG model)
        {
            model.MAKIEUPHONG = int.Parse(Request["txtidk"].ToString());
            var t = new Models.KieuPhongModel();
            var result = t.deleteKieuPhong(model.MAKIEUPHONG);
            if (result)
            {
                return RedirectToAction("KieuPhong", "Phong");
            }
            else
            {
                return RedirectToAction("KieuPhong", "Phong");
            }
        }

        //Logout-----------------------------------------------------------------------------------------------------
        [AllowAnonymous]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "HomeAdmin");
        }
    }

}
