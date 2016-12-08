using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Framework;
using Models;
using KhachSan.Models;

namespace KhachSan.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public static List<object> myModel;
        [HttpGet]
        public ActionResult Index()
        {
            myModel = new List<object>();
            var tt = new Models.Gioithieu();
            var model = tt.getAllGioiThieu();
            var ttt = new Models.LoaiPhongModel();
            var model2 = ttt.getAllLoaiPhong();
            var tttt = new Models.DICHVU_MODEL();
            var model3 = tttt.getTienIch();
            var tenqc = new Models.AdsModel();
            var model4 = tenqc.getOneQC(1);

            myModel.Add(model);
            myModel.Add(model2);
            myModel.Add(model3);
            myModel.Add(model4);

            return View(myModel);
        }
        [HttpPost]
        public ActionResult Index(PHIEU_DAT_PHONG model)
        {
            model.LOAIPHONG = Convert.ToInt32(Request["loaiphong"].ToString());
            model.HOTENKHACHHANG = Request["txthoten"].ToString();
            model.DIENTHOAI = Request["txtdt"].ToString();
            if (Request["txtngayden"].ToString() != "" && Request["txtngaydi"].ToString() != "" && model.HOTENKHACHHANG !="" && model.DIENTHOAI !="")
            {
                model.NGAYDUKIENDEN = Convert.ToDateTime(Request["txtngayden"].ToString());
                model.NGAYDUKIENTRA = Convert.ToDateTime(Request["txtngaydi"].ToString());
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }            
            var t = new OrderRoomModel();
            var result = t.bookRoom(model.LOAIPHONG, model.HOTENKHACHHANG, model.DIENTHOAI, model.NGAYDUKIENDEN, model.NGAYDUKIENTRA, model.NGAYTAOPHIEU, model.TRANGTHAIPHIEU, model.TIENDATCOC, model.LOAITIEN, model.NGUOIXACNHAN, model.NGAYXACNHAN);
            if (result)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}