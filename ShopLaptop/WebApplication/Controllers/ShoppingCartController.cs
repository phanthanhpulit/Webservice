using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.ServiceReferenceShopLaptop;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class ShoppingCartController : Controller
    {
        ServiceShopLaptopClient lt = new ServiceShopLaptopClient();
        private List<ShopLaptop> CartList = new List<ShopLaptop>();

        public ActionResult Index()
        {
            return View();
        }

        #region[Thêm giỏ hàng]
        public ActionResult ShowCart()
        {
            return View();
        }
        public ActionResult AddToCart(string id, int gia)
        {
            if (Session["Cart"] != null)
            {
                CartList = (List<ShopLaptop>)Session["Cart"];
                var OldCart = CartList.Find(m => m.MaSP == id);
                if (OldCart != null)
                {
                    var NewCart = new ShopLaptop { MaSP = id, SoLuong = OldCart.SoLuong + 1, DonGia = gia };
                    CartList.Remove(OldCart);
                    CartList.Add(NewCart);
                }
                else
                {
                    CartList.Add(new ShopLaptop{ MaSP = id, SoLuong = 1, DonGia = gia });
                }
            }
            else
            {
                CartList.Add(new ShopLaptop { MaSP = id, SoLuong = 1, DonGia = gia });
            }
            Session["Cart"] = CartList;
            return RedirectToAction("ShowCart");
        }
        #endregion
        #region[Xóa giỏ hàng]
        public ActionResult RemoveCart(string id)
        {
            var CartList = (List<ShopLaptop>)Session["Cart"];
            var _Cart = CartList.SingleOrDefault(m => m.MaSP == id);
            CartList.Remove(_Cart);
            Session["Cart"] = CartList;
            //return new EmptyResult();
            return RedirectToAction("ShowCart");
        }
        #endregion
        #region[Tạo giỏ hành mới]
        public ActionResult Create()
        {
            if (Session["LogedUserFullname"] != null)
            {
                string smahd = "99";
                string suser = Session["LogedUserID"].ToString();
                DateTime dngaymua = DateTime.Now.Date;
                int ftongtien = 0;
                int trangthai = 1;
                bool active = true;

                string smasp = "";
                int isoluong = 0;
                int fthanhtien = 0;

                CartList = (List<ShopLaptop>)Session["Cart"];
                foreach (var item in CartList)
                {

                    ftongtien = ftongtien + (item.SoLuong * item.DonGia);
                }
                lt.ThemHoaDon(smahd, suser, dngaymua,dngaymua,trangthai,active);

                foreach (var item in CartList)
                {
                    smasp = item.MaSP;
                    isoluong = item.SoLuong;
                    fthanhtien = item.DonGia * item.SoLuong;

                    lt.ThemChitietHD(smahd, smasp, isoluong, item.DonGia, fthanhtien);
                }
                Session["Cart"] = null;
                return View();
            }
            else
            {
                return RedirectToAction("LoginCart", "Account");
            }
        }
        #endregion

        public ActionResult Cart()
        {
            int soluong = 0;
            CartList = (List<ShopLaptop>)Session["Cart"];
            if (CartList != null)
            {
                foreach (var item in CartList)
                {
                    soluong += item.SoLuong;
                }
            }
            return View(soluong);
        }
    }
}
