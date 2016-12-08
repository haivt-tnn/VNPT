using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Framework;

namespace KhachSan.Areas.Admin.Controllers
{
    public class DichVuController : Controller
    {
        // GET: Admin/DichVu
        public ActionResult Index()
        {
            var m = new Models.DanhMucDichVuModel();
            var mymodel = new List<Object>();

            var model = m.getAllDichVu();
            var model2 = m.LoaiTien();
            mymodel.Add(model);
            mymodel.Add(model2);

            return View(mymodel);


        }

        public ActionResult insertdanhmucdichvu(DANH_MUC_DICH_VU model)
        {
            model.TENDICHVU = Request["txttendichvu"].ToString();
            model.DONVITINH = Request["txtdonvitinh"].ToString();
            model.DONGIA = double.Parse(Request["txtdongia"].ToString());
            model.LOAITIEN = int.Parse(Request["loaitien"].ToString());
            if (model.TENDICHVU != "" && model.DONVITINH != "" && model.DONGIA != null)
            {
                var m = new Models.DanhMucDichVuModel();
                var result = m.insert_danh_muc_dich_vu(model.TENDICHVU, model.DONVITINH, model.DONGIA, model.LOAITIEN);
                if (result)
                {
                    return RedirectToAction("index", "DichVu");
                }
                else
                {
                    return RedirectToAction("index", "DichVu");
                }
            }
            else
            {
                return RedirectToAction("index", "DichVu");
            }
        }


        public ActionResult updatedanhmucdichvu(DANH_MUC_DICH_VU model)
        {
            model.MADICHVU = int.Parse(Request["madichvu"].ToString());
            model.TENDICHVU = Request["txttendichvu"].ToString();
            model.DONVITINH = Request["txtdonvitinh"].ToString();
            model.DONGIA = double.Parse(Request["txtdongia"].ToString());
            model.LOAITIEN = int.Parse(Request["loaitien"].ToString());
            if (model.TENDICHVU != "" && model.DONVITINH != "" && model.DONGIA != null)
            {
                var m = new Models.DanhMucDichVuModel();
                var result = m.updateDichVu(model.MADICHVU,model.TENDICHVU, model.DONVITINH, model.DONGIA, model.LOAITIEN);
                if (result)
                {
                    return RedirectToAction("index", "DichVu");
                }
                else
                {
                    return RedirectToAction("index", "DichVu");
                }
            }
            else
            {
                return RedirectToAction("index", "DichVu");
            }
        }



        public ActionResult Thongke()
        {
            return View();
        }
    }
}