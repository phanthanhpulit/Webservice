using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class ShopLaptop
    {
        public string MaSP
        {
            get;
            set;
        }

        public int DonGia
        {
            get;
            set;
        }

        public int SoLuong
        {
            get;
            set;
        }

        public int ThanhTien
        {
            get;
            set;
        }

        public ShopLaptop()
        {
        }

        public ShopLaptop(string masp, int soluong, int gia, int thanhtien)
        {
            this.MaSP = masp;
            this.SoLuong = soluong;
            this.DonGia = gia;
            this.ThanhTien = thanhtien;
        }
    }
}