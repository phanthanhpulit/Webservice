using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.ServiceReferenceShopLaptop;
using System.Web.Security;

namespace WebApplication.Controllers
{
    public class AccountController : Controller
    {
        ServiceShopLaptopClient lt = new ServiceShopLaptopClient();
        public ActionResult IndexUser()
        {
            if (Session["LogedUserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("LoginUser");
            }
        }

        public ActionResult LoginUser()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoginUserComplete(KhachHang u)
        {
            string user = u.username;
            string pass = u.password;

            if (user != null && pass != null)
            {
                using (lt)
                {
                    if (lt.ktdangnhapKhachHang1(user, pass)==true)
                    {
                        var v = lt.findLoginKhachHang(user,pass);
                        if (v != null)
                        {
                            Session["LogedUserID"] = v.username.ToString();
                            Session["LogedUserFullname"] = v.hoten.ToString();
                            return RedirectToAction("Default", "Default");
                        }
                    }
                    else
                    {
                        TempData["AlertMessageLogin"] = "Sai thông tin đăng nhập!!";
                        return RedirectToAction("Default", "Default");
                    }
                    
                }
            }
            return RedirectToAction("Default", "Default");
        }

        public ActionResult AfterLoginUser()
        {
            if (Session["LogedUserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("LoginUser");
            }
        }

        public ActionResult ProfileUser(string id)
        {
            return View(lt.findKhachHang(id));
        }

        public ActionResult LogoutUser()
        {
            System.Web.HttpContext.Current.Response.Cookies.Clear();
            FormsAuthentication.SignOut();
            Session["LogedUserID"] = null;
            Session["LogedUserFullname"] = null;
            //Session.Clear();
            //Session.Abandon();
            //Session.RemoveAll();
            return RedirectToAction("Default", "Default");
        }

        public ActionResult RegisterUser()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult RegisterUser(FormCollection conllection)
        {
            try
            {
                string user = conllection["txtusername"];
                string pass = conllection["txtpassword"];
                string hoten = conllection["txthoten"];
                string gioitinh = conllection["txtgioitinh"];
                DateTime namsinh = DateTime.Parse(conllection["txtnamsinh"]);
                string diachi = conllection["txtdiachi"];
                string sodienthoai = conllection["txtsodienthoai"];
                bool quyenhan = true;
                bool active = true;

                if (lt.ThemKhachHang(user,pass,hoten,gioitinh,namsinh,diachi,sodienthoai,quyenhan,active)==true)
                {
                    TempData["AlertMessageRegister"] = "Đăng ký thành công. Bạn có thể đăng nhập ngay bây giờ!!";
                    return RedirectToAction("Default", "Default");
                }
                else
                {
                    return RedirectToAction("RegisterUser", "Account");
                }
            }
            catch
            {
                return RedirectToAction("RegisterUser", "Account");
            }
        }

        public ActionResult EditUser(string id, string gioitinh)
        {
            //string username = Request.QueryString["username"];
            ViewBag.gioitinh = gioitinh;
            var khachhang = lt.findKhachHang(id);
            return View(khachhang);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult EditUser(FormCollection conllection)
        {
                string user = conllection["txtusername"];
                string pass = conllection["txtpassword"];
                string hoten = conllection["txthoten"];
                string gioitinh = conllection["txtgioitinh"];
                DateTime namsinh = DateTime.Parse(conllection["txtnamsinh"]);
                string diachi = conllection["txtdiachi"];
                string sodienthoai = conllection["txtsodienthoai"];
                bool quyenhan = true;
                bool active = true;

                if(lt.SuaKhachHang(user,pass,hoten,gioitinh,namsinh,diachi,sodienthoai,quyenhan,active)==true)
                {
                    lt.SuaKhachHang(user, pass, hoten, gioitinh, namsinh, diachi,sodienthoai,quyenhan,active);
                    TempData["AlertMessageEdit"] = "Sửa thành công!!";
                    return RedirectToAction("Default", "Default");
                }
                else
                {
                    TempData["AlertMessageEdit"] = "Sửa thất bại!!";
                    return RedirectToAction("Default", "Default");
                }
            
        }

        #region[Login Cart]
        public ActionResult LoginCart()
        {
            if (Session["LogedUserFullname"] != null)
                return RedirectToAction("Default", "Default");
            else
                return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoginCart(KhachHang u)
        {
            string user = u.username;
            string pass = u.password;

            if (user != null && pass != null)
            {
                using (lt)
                {
                    if (lt.ktdangnhapKhachHang1(user,pass)==true)
                    {
                        var v = lt.findLoginKhachHang(user,pass);
                        if (v != null)
                        {
                            Session["LogedUserID"] = v.username.ToString();
                            Session["LogedUserFullname"] = v.hoten.ToString();
                            //Session["LogedUserImages"] = v.hinh.ToString();
                            return RedirectToAction("Create", "ShoppingCart");
                        }
                    }
                    return RedirectToAction("LoginCart", "Account");
                }
            }
            return RedirectToAction("LoginCart", "Account");
        }
        #endregion
    }
}
