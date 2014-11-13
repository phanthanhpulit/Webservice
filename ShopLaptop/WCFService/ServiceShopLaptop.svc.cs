using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;

namespace WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceShopLaptop" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceShopLaptop.svc or ServiceShopLaptop.svc.cs at the Solution Explorer and start debugging.
    public class ServiceShopLaptop : IServiceShopLaptop
    {
        private LinqtoSQLDataContext sp = new LinqtoSQLDataContext();
        #region[SanPham]
        public List<SanPham> findAllSanPham()
        {
            List<SanPham> p1 = new List<SanPham>();
            p1 = (from p in sp.SanPhams where p.active == true select p).ToList();
            return p1;
        }

        public SanPham findSanPham(string masp)
        {
            return sp.SanPhams.Single(sps => sps.masp == masp);
        }
        public List<SanPham> findSanPham1(string tensp)
        {
            List<SanPham> p1 = new List<SanPham>();
            p1 = (from p in sp.SanPhams where p.tensp.ToLower().Contains(tensp) select p).ToList();
            return p1;
            //return this.sp.SanPhams.Where(sps => sps.tensp.ToLower().Contains("tensp")).ToList();
        }
        public bool ThemSanPham(string masp, string tensp, int gia, string hinh, string maloai, string CPU, string RAM,
            string HDD, string VGA, string display, string wireless, string battery, string weight,
            string baohanh, string chitiet, bool active)
        {
            try
            {
                SanPham sps = new SanPham();
                sps.masp = masp;
                sps.tensp = tensp;
                sps.gia = gia;
                sps.hinh = hinh;
                sps.maloai = maloai;
                sps.CPU = CPU;
                sps.RAM = RAM;
                sps.HDD = HDD;
                sps.VGA = VGA;
                sps.display = display;
                sps.wireless = wireless;
                sps.battery = battery;
                sps.weight = weight;
                sps.baohanh = baohanh;
                sps.chitiet = chitiet;
                sps.active = active;
                sp.SanPhams.InsertOnSubmit(sps);
                sp.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaSanPham(string masp)
        {
            try
            {
                SanPham sps = sp.SanPhams.Single(p => p.masp == masp);
                sp.SanPhams.DeleteOnSubmit(sps);
                sp.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaSanPham1(string masp, string tensp, int gia, string hinh, string maloai, string CPU, string RAM,
            string HDD, string VGA, string display, string wireless, string battery, string weight,
            string baohanh, string chitiet, bool active)
        {
            active = false;
            try
            {
                SanPham sps = sp.SanPhams.Single(p => p.masp == masp);
                sps.tensp = tensp;
                sps.gia = gia;
                sps.hinh = hinh;
                sps.maloai = maloai;
                sps.CPU = CPU;
                sps.RAM = RAM;
                sps.HDD = HDD;
                sps.VGA = VGA;
                sps.display = display;
                sps.wireless = wireless;
                sps.battery = battery;
                sps.weight = weight;
                sps.baohanh = baohanh;
                sps.chitiet = chitiet;
                sps.active = active;
                sp.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaSanPham(string masp, string tensp, int gia, string hinh, string maloai, string CPU, string RAM, string HDD, string VGA, string display, string wireless, string battery, string weight, string baohanh, string chitiet, bool active)
        {
            try
            {
                SanPham sps = sp.SanPhams.Single(p => p.masp == masp);
                sps.tensp = tensp;
                sps.gia = gia;
                sps.hinh = hinh;
                sps.maloai = maloai;
                sps.CPU = CPU;
                sps.RAM = RAM;
                sps.HDD = HDD;
                sps.VGA = VGA;
                sps.display = display;
                sps.wireless = wireless;
                sps.battery = battery;
                sps.weight = weight;
                sps.baohanh = baohanh;
                sps.chitiet = chitiet;
                sps.active = active;
                sp.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<SanPham> ProductNewSanPham()
        {
            List<SanPham> products = new List<SanPham>();
            products = (from p in sp.SanPhams orderby p.id descending select p).Take(15).ToList();
            return products;
        }
        public List<SanPham> ProductLoai(string maloai)
        {
            List<SanPham> products = new List<SanPham>();
            products = (from p in sp.SanPhams where p.maloai == maloai select p).ToList();
            return products;
        }

        public string LayMaLoaiSP()
        {
            string MaLoai = "";
            List<SanPham> l = (from p in sp.SanPhams where p.id == p.id orderby p.id descending select p).Take(1).ToList();
            foreach (var item in l)
            {
                MaLoai = item.masp;
            }
            return MaLoai;
        }
        #endregion
        #region[KhachHang]
        public List<KhachHang> findAllKhachHang()
        {
            List<KhachHang> khang = new List<KhachHang>();
            khang = (from p in sp.KhachHangs where p.quyenhan == true && p.active==true select p).ToList();
            return khang;
        }

        public KhachHang findKhachHang(string username)
        {
            return sp.KhachHangs.Single(khs => khs.username == username);
        }

        public bool ThemKhachHang(string username, string password, string hoten, string gioitinh, DateTime namsinh, string diachi, string sodienthoai, bool quyenhan, bool active)
        {
            try
            {
                KhachHang khs = new KhachHang();
                khs.username = username;
                khs.password = password;
                khs.hoten = hoten;
                khs.gioitinh = gioitinh;
                khs.namsinh = namsinh;
                khs.diachi = diachi;
                khs.sodienthoai = sodienthoai;
                khs.quyenhan = quyenhan;
                khs.active = active;
                sp.KhachHangs.InsertOnSubmit(khs);
                sp.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaKhachHang(string username)
        {
            try
            {
                KhachHang khs = sp.KhachHangs.Single(p => p.username == username);
                sp.KhachHangs.DeleteOnSubmit(khs);
                sp.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaKhangHang1(string username, string password, string hoten, string gioitinh, DateTime namsinh, string diachi, string sodienthoai, bool quyenhan, bool active)
        {
            active = false;
            try
            {
                KhachHang khs = sp.KhachHangs.Single(p => p.username == username);
                khs.username = username;
                khs.password = password;
                khs.hoten = hoten;
                khs.gioitinh = gioitinh;
                khs.namsinh = namsinh;
                khs.diachi = diachi;
                khs.sodienthoai = sodienthoai;
                khs.quyenhan = quyenhan;
                khs.active = active;
                sp.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaKhachHang(string username, string password, string hoten, string gioitinh, DateTime namsinh, string diachi, string sodienthoai, bool quyenhan, bool active)
        {
            try
            {
                KhachHang khs = sp.KhachHangs.Single(p => p.username == username);
                khs.username = username;
                khs.password = password;
                khs.hoten = hoten;
                khs.gioitinh = gioitinh;
                khs.namsinh = namsinh;               
                khs.diachi = diachi;
                khs.sodienthoai = sodienthoai;
                khs.quyenhan = quyenhan;
                khs.active = active;
                sp.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ktdangnhapKhachHang(string txtusername, string txtpassword)
        {
            List<KhachHang> khachhang = new List<KhachHang>();
            khachhang = (from u in sp.KhachHangs
                         where u.username == txtusername.Trim() && u.password == txtpassword.Trim()
                         select u).ToList();
            KhachHang sales = khachhang.FirstOrDefault();
            if (sales != null && sales.quyenhan == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ktdangnhapKhachHang1(string txtusername, string txtpassword)
        {
            List<KhachHang> khachhang = new List<KhachHang>();
            khachhang = (from u in sp.KhachHangs
                         where u.username == txtusername.Trim() && u.password == txtpassword.Trim()
                         select u).ToList();
            KhachHang sales = khachhang.FirstOrDefault();
            if (sales != null && sales.quyenhan == true && sales.active == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public KhachHang findLoginKhachHang(string username, string password)
        {
            return sp.KhachHangs.Single(khs => khs.username == username && khs.password == password);
        }

        #endregion
        #region[LoaiSP]
        public List<LoaiSP> findAllLoaiSP()
        {
            List<LoaiSP> p1 = new List<LoaiSP>();
            p1 = (from p in sp.LoaiSPs where p.active == true select p).ToList();
            return p1;
        }

        public LoaiSP findLoaiSP(string maloai)
        {
            return sp.LoaiSPs.Single(loais => loais.maloai == maloai);
        }

        public bool ThemLoaiSP(string maloai, string tenloai, bool active)
        {
            try
            {
                LoaiSP ma = new LoaiSP();
                ma.maloai = maloai;
                ma.tenloai = tenloai;
                ma.active = active;
                sp.LoaiSPs.InsertOnSubmit(ma);
                sp.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaLoaiSP(string maloai)
        {
            try
            {
                LoaiSP ma = sp.LoaiSPs.Single(p => p.maloai == maloai);
                sp.LoaiSPs.DeleteOnSubmit(ma);
                sp.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaLoaiSP1(string maloai, string tenloai, bool active)
        {
            active = false;
            try
            {
                LoaiSP ma = sp.LoaiSPs.Single(p => p.maloai == maloai);
                ma.maloai = maloai;
                ma.tenloai = tenloai;
                ma.active = active;
                sp.SubmitChanges();
                return true;
            }
            catch
            {
                return true;
            }
        }
        public bool SuaLoaiSP(string maloai, string tenloai, bool active)
        {
            try
            {
                LoaiSP ma = sp.LoaiSPs.Single(p => p.maloai == maloai);
                ma.maloai = maloai;
                ma.tenloai = tenloai;
                ma.active = active;
                sp.SubmitChanges();
                return true;
            }
            catch
            {
                return true;
            }
        }
        public List<string> displayLoaiSP()
        {
            var l = (from p in sp.LoaiSPs select p.tenloai).ToList();
            List<string> Result = new List<string>();
            for (int i = 0; i < l.Count; i++)
            {
                Result.Add(l[i]);
            }
            return Result;
        }
        public string HienthiLoaiSP(string temp)
        {
            string ten = (from p in sp.LoaiSPs where temp == p.maloai select p.tenloai).ToString();
            return ten;
        }

        public string LayMaLoaiLSP()
        {
            string MaLoai = "";
            List<LoaiSP> l = (from p in sp.LoaiSPs where p.id == p.id orderby p.id descending select p).Take(1).ToList();
            foreach (var item in l)
            {
                MaLoai = item.maloai;
            }
            return MaLoai;
        }
        #endregion
        #region[HoaDon]
        public List<HoaDon> findAllHoaDon()
        {
            List<HoaDon> p1 = new List<HoaDon>();
            p1 = (from p in sp.HoaDons where p.active == true select p).ToList();
            return p1;
        }

        public HoaDon findHoaDon(string mahd)
        {
            return sp.HoaDons.Single(hds => hds.mahd == mahd);
        }

        public bool ThemHoaDon(string mahd, string username, DateTime ngaylap, DateTime ngaythanhtoan, int trangthai, bool active)
        {
            try
            {
                HoaDon ma = new HoaDon();
                ma.mahd = mahd;
                ma.username = username;
                ma.ngaylap = ngaylap;
                ma.ngaythanhtoan = ngaythanhtoan;
                ma.trangthai = trangthai;
                ma.active = active;
                sp.HoaDons.InsertOnSubmit(ma);
                sp.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaHoaDon(string mahd)
        {
            try
            {
                HoaDon ma = sp.HoaDons.Single(p => p.mahd == mahd);
                sp.HoaDons.DeleteOnSubmit(ma);
                sp.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaHoaDon1(string mahd, string username, DateTime ngaylap, DateTime ngaythanhtoan, int trangthai, bool active)
        {
            active = false;
            try
            {
                HoaDon ma = sp.HoaDons.Single(p => p.mahd == mahd);
                ma.mahd = mahd;
                ma.username = username;
                ma.ngaylap = ngaylap;
                ma.ngaythanhtoan = ngaythanhtoan;
                ma.trangthai = trangthai;
                ma.active = active;
                sp.SubmitChanges();
                return true;
            }
            catch
            {
                return true;
            }
        }

        public bool SuaHoaDon(string mahd, string username, DateTime ngaylap, DateTime ngaythanhtoan, int trangthai, bool active)
        {
            try
            {
                HoaDon ma = sp.HoaDons.Single(p => p.mahd == mahd);
                ma.mahd = mahd;
                ma.username = username;
                ma.ngaylap = ngaylap;
                ma.ngaythanhtoan = ngaythanhtoan;
                ma.trangthai = trangthai;
                ma.active = active;
                sp.SubmitChanges();
                return true;
            }
            catch
            {
                return true;
            }
        }

        public string LayMaLoaiHD()
        {
            string MaLoai = "";
            List<HoaDon> l = (from p in sp.HoaDons where p.id == p.id orderby p.id descending select p).Take(1).ToList();
            foreach (var item in l)
            {
                MaLoai = item.mahd;
            }
            return MaLoai;
        }
        #endregion
        #region[ChitietHD]
        public List<ChitietHD> findAllChitietHD()
        {
            return this.sp.ChitietHDs.ToList();
        }

        public bool ThemChitietHD(string mahd, string masp, int soluong, int gia, int thanhtien)
        {
            try
            {
                ChitietHD ma = new ChitietHD();
                ma.mahd = mahd;
                ma.masp = masp;
                ma.soluong = soluong;
                ma.gia = gia;
                ma.thanhtien = thanhtien;               
                sp.ChitietHDs.InsertOnSubmit(ma);
                sp.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaChitietHD(string mahd, string masp, int soluong, int gia, int thanhtien)
        {
            try
            {
                ChitietHD ma = sp.ChitietHDs.Single(p => p.mahd == mahd);
                ma.mahd = mahd;
                ma.masp = masp;
                ma.soluong = soluong;
                ma.gia = gia;
                ma.thanhtien = thanhtien;
                sp.SubmitChanges();
                return true;
            }
            catch
            {
                return true;
            }
        }

        public List<ChitietHD> findChitietHD(string mahd)
        {
            List<ChitietHD> p1 = new List<ChitietHD>();
            p1 = (from p in sp.ChitietHDs where p.mahd == mahd select p).ToList();
            return p1;
        }
        #endregion
        #region[Kho]
        public List<Kho> findAllKho()
        {
            return this.sp.Khos.ToList();
        }
        public List<Kho> findKho(DateTime ngay1, DateTime ngay2)
        {
            List<Kho> kh = new List<Kho>();
            kh = (from p in sp.Khos where p.ngay >= ngay1 && p.ngay <=ngay2 orderby p.ngay select p).ToList();
            return kh;
        }
        public bool ThemKho(string masp, DateTime ngay, int soluong)
        {
            var stock = (from p in sp.Khos where p.masp == masp && p.ngay.Value <= ngay orderby p.id descending select p.soluong).FirstOrDefault();
            if(string.IsNullOrEmpty(stock.ToString()))
            {
                try
                {
                    Kho ma = new Kho();
                    ma.masp = masp;
                    ma.ngay = ngay;
                    ma.soluong = soluong;
                    sp.Khos.InsertOnSubmit(ma);
                    sp.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                int tonkho = Convert.ToInt32(stock.ToString());
                try
                {
                    Kho ma = new Kho();
                    ma.masp = masp;
                    ma.ngay = ngay;
                    ma.soluong = soluong+tonkho;
                    sp.Khos.InsertOnSubmit(ma);
                    sp.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool ThemKho1(string masp, DateTime ngay, int soluong)
        {
            var stock = (from p in sp.Khos where p.masp == masp && p.ngay.Value <= ngay orderby p.id descending select p.soluong).FirstOrDefault();
            if (string.IsNullOrEmpty(stock.ToString()))
            {
                return false;
            }
            else
            {
                int tonkho = Convert.ToInt32(stock.ToString());
                try
                {
                    Kho ma = new Kho();
                    ma.masp = masp;
                    ma.ngay = ngay;
                    ma.soluong = tonkho-soluong;
                    sp.Khos.InsertOnSubmit(ma);
                    sp.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public List<Kho> ThongKeTK(DateTime ngay1, DateTime ngay2)
        {
            List<SanPham> l = new List<SanPham>();
            List<Kho> k = new List<Kho>();
            foreach (var d in l)
            {
                Kho ds = (from c in sp.Khos where d.masp == c.masp && c.ngay >= ngay1 && c.ngay <= ngay2 orderby c.id descending select c).FirstOrDefault();
                k.Add(ds);
            }
            return k;
        }
        #endregion
        #region[PhieuNhap]
        public List<PhieuNhap> findAllPhieuNhap()
        {
            List<PhieuNhap> p1 = new List<PhieuNhap>();
            p1 = (from p in sp.PhieuNhaps where p.active == true select p).ToList();
            return p1;
        }

        public PhieuNhap findPhieuNhap(string mapn)
        {
            return sp.PhieuNhaps.Single(hds => hds.mapn == mapn);
        }

        public bool ThemPhieuNhap(string mapn, DateTime ngay, bool active)
        {
            try
            {
                PhieuNhap ma = new PhieuNhap();
                ma.mapn = mapn;
                ma.ngay = ngay;
                ma.active = active;
                sp.PhieuNhaps.InsertOnSubmit(ma);
                sp.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaPhieuNhap(string mapn)
        {
            try
            {
                PhieuNhap ma = sp.PhieuNhaps.Single(p => p.mapn == mapn);
                sp.PhieuNhaps.DeleteOnSubmit(ma);
                sp.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaPhieuNhap1(string mapn, DateTime ngay, bool active)
        {
            active = false;
            try
            {
                PhieuNhap ma = sp.PhieuNhaps.Single(p => p.mapn == mapn);
                ma.mapn = mapn;
                ma.ngay = ngay;
                ma.active = active;
                sp.SubmitChanges();
                return true;
            }
            catch
            {
                return true;
            }
        }

        public bool SuaPhieuNhap(string mapn, DateTime ngay, bool active)
        {
            try
            {
                PhieuNhap ma = sp.PhieuNhaps.Single(p => p.mapn == mapn);
                ma.mapn = mapn;
                ma.ngay = ngay;
                ma.active = active;
                sp.SubmitChanges();
                return true;
            }
            catch
            {
                return true;
            }
        }

        public string LayMaLoaiPN()
        {
            string MaLoai = "";
            List<PhieuNhap> l = (from p in sp.PhieuNhaps where p.id == p.id orderby p.id descending select p).Take(1).ToList();
            foreach (var item in l)
            {
                MaLoai = item.mapn;
            }
            return MaLoai;
        }
        #endregion
        #region[ChitietPN]
        public List<ChitietPN> findAllChitietPN()
        {
            return this.sp.ChitietPNs.ToList();
        }

        public bool ThemChitietPN(string mapn, string masp, int soluong)
        {
            try
            {
                ChitietPN ma = new ChitietPN();
                ma.mapn = mapn;
                ma.masp = masp;
                ma.soluong = soluong;
                sp.ChitietPNs.InsertOnSubmit(ma);
                sp.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaChitietPN(string mapn, string masp, int soluong)
        {
            try
            {
                ChitietPN ma = sp.ChitietPNs.Single(p => p.mapn == mapn);
                ma.mapn = mapn;
                ma.masp = masp;
                ma.soluong = soluong;
                sp.SubmitChanges();
                return true;
            }
            catch
            {
                return true;
            }
        }
        #endregion
    }
}
