using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.ServiceReferenceShopLaptop;

namespace WebApplication.Controllers
{
    public class DefaultController : Controller
    {
        int pagesize = 9;
        ServiceShopLaptopClient lt = new ServiceShopLaptopClient();
        public ActionResult Default(int page = 1)
        {            
            var sanpham = lt.ProductNewSanPham().ToList();
            ViewBag.TotalPages = Math.Ceiling((double)sanpham.Count / pagesize);
            return View(sanpham.Skip((page - 1) * pagesize).Take(pagesize));
        }

        [ChildActionOnly]
        public ActionResult Menu()
        {
            var loai = lt.findAllLoaiSP().ToList();
            return PartialView(loai);
        }

        public ActionResult Danhmuc(int page = 1)
        {
            string loai = Request.QueryString["loai"];
            var sanpham = lt.ProductLoai(loai).ToList();
            ViewBag.TotalPages = Math.Ceiling((double)sanpham.Count / pagesize);
            ViewBag.maloai = loai;
            return View(sanpham.Skip((page - 1) * pagesize).Take(pagesize));
        }

        public ActionResult ChitietSP()
        {
            string masp = Request.QueryString["masp"];
            var sanpham = lt.findSanPham(masp);
            if (sanpham == null) return HttpNotFound();
            return View(sanpham);
        }

        #region[Search]
        public ActionResult Timkiem()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TimkiemResult(SanPham sp, int page = 1)
        {
            string ten = sp.tensp;
            if (ten != null)
            {
                var product = lt.findAllSanPham().ToList();
                ViewBag.Tensp = ten;
                ten = ten.ToLower();
                if (!String.IsNullOrEmpty(ten))
                {
                   product = lt.findSanPham1(ten).ToList();
                }
                ViewBag.KhongTimThay = "Không tìm thấy các sản phẩm thỏa điều kiện!";
                ViewBag.TotalPages = Math.Ceiling((double)product.Count / pagesize);
                return View(product.Skip((page - 1) * pagesize).Take(pagesize));
            }
            else
            {
                return RedirectToAction("Default", "Default");
            }
        }
        #endregion
    }
}
