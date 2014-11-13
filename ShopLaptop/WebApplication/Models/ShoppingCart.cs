using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class ShoppingCart
    {
        public List<ShopLaptop> danhsach = new List<ShopLaptop>();

        public float TongTien
        {
            get;
            set;
        }

        public ShoppingCart()
        {
        }

        public ShopLaptop LuaChon(int ChiSo)
        {
            return danhsach[ChiSo];
        }

        public void AddToCart(string id)
        {
            bool daco = false;
            foreach (ShopLaptop it in danhsach)
            {
                if (it.MaSP == id)
                {
                    it.SoLuong += 1;
                    daco = true;
                    break;
                }
            }
            if (daco == false)
                danhsach.Add(new ShopLaptop { MaSP = id, SoLuong = 1 });
        }

        public void XoaItem(string masp)
        {
            foreach (ShopLaptop it in danhsach)
            {
                if (it.MaSP == masp)
                    danhsach.Remove(it);
            }
            return;
        }

        public void CapNhatGioHang(ShopLaptop laptop)
        {
            foreach (ShopLaptop it in danhsach)
            {
                if (it.MaSP == laptop.MaSP)
                {
                    it.SoLuong = laptop.SoLuong;
                    if (laptop.SoLuong == 0)
                        danhsach.Remove(it);
                    return;
                }
            }
        }
    }
}