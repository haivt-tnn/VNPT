using KhachSan.Areas.Admin.Models;
using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KhachSan.Areas.Admin.Controllers
{
    public class DSPhieuChoController : Controller
    {
        // GET: Admin/DSPhieuCho
        public ActionResult Index()
        {
<<<<<<< HEAD
            List<object> myModel = new List<object>();

            KhachHangModel t1 = new KhachHangModel();
            List<PHIEU_DAT_PHONG1> model1 = t1.getKhachHangDatPhong();
            List<DANH_MUC_LOAI_GIAY_TO> model2 = t1.getLoaiGiayTo();

            DanhMucDichVuModel t2 = new DanhMucDichVuModel();
            List<DANH_MUC_LOAI_TIEN> model3 = t2.LoaiTien();

            NhanVienModel t3 = new NhanVienModel();
            List<DANH_MUC_GIOI_TINH> model4 = t3.getAllGioiTinh();

            PhongModel t4 = new PhongModel();
            List<DANH_MUC_LOAI_PHONG> model5 = t4.getAllLoaiPhong();

            KieuPhongModel t5 = new KieuPhongModel();
            List<DANH_MUC_KIEU_PHONG> model6 = t5.getAllKieuPhong();

            myModel.Add(model1);
            myModel.Add(model2);
            myModel.Add(model3);
            myModel.Add(model4);
            myModel.Add(model5);
            myModel.Add(model6);

            return View(myModel);
        }       
=======
            KhachHangModel t = new KhachHangModel();
            List<PHIEU_DAT_PHONG1> model = t.getKhachHangDatPhong();
            return View(model);
        }
>>>>>>> e0fc588e21dc3e9ab6b9ef79a6713efea8f6b6ac
    }
}