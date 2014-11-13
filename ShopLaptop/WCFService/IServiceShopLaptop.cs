using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceShopLaptop" in both code and config file together.
    [ServiceContract]
    public interface IServiceShopLaptop
    {
        //[OperationContract]
        #region[SanPham]
        [OperationContract]
        List<SanPham> findAllSanPham();

        [OperationContract]
        SanPham findSanPham(string masp);

        [OperationContract]
        List<SanPham> findSanPham1(string tensp);

        [OperationContract]
        bool ThemSanPham(string masp, string tensp, int gia, string hinh, string maloai, string CPU, string RAM,
            string HDD, string VGA, string display, string wireless, string battery, string weight,
            string baohanh, string chitiet, bool active);

        [OperationContract]
        bool XoaSanPham(string masp);

        [OperationContract]
        bool XoaSanPham1(string masp, string tensp, int gia, string hinh, string maloai, string CPU, string RAM,
            string HDD, string VGA, string display, string wireless, string battery, string weight,
            string baohanh, string chitiet, bool active);

        [OperationContract]
        bool SuaSanPham(string masp, string tensp, int gia, string hinh, string maloai, string CPU, string RAM,
            string HDD, string VGA, string display, string wireless, string battery, string weight,
            string baohanh, string chitiet, bool active);

        [OperationContract]
        List<SanPham> ProductNewSanPham();

        [OperationContract]
        List<SanPham> ProductLoai(string masp);

        [OperationContract]
        string LayMaLoaiSP();
        #endregion
        #region[LoaiSP]
        [OperationContract]
        List<LoaiSP> findAllLoaiSP();

        [OperationContract]
        LoaiSP findLoaiSP(string maloai);

        [OperationContract]
        bool ThemLoaiSP(string maloai, string tenloai, bool active);

        [OperationContract]
        bool XoaLoaiSP(string maloai);

        [OperationContract]
        bool XoaLoaiSP1(string maloai, string tenloai, bool active);

        [OperationContract]
        bool SuaLoaiSP(string maloai, string tenloai, bool active);

        [OperationContract]
        List<string> displayLoaiSP();

        [OperationContract]
        string HienthiLoaiSP(string temp);

        [OperationContract]
        string LayMaLoaiLSP();
        #endregion
        #region[KhachHang]
        [OperationContract]
        List<KhachHang> findAllKhachHang();

        [OperationContract]
        KhachHang findKhachHang(string username);

        [OperationContract]
        bool ThemKhachHang(string username, string password, string hoten, string gioitinh, DateTime namsinh, string diachi, string sodienthoai, bool quyenhan, bool active);

        [OperationContract]
        bool XoaKhachHang(string username);

        [OperationContract]
        bool XoaKhangHang1(string username, string password, string hoten, string gioitinh, DateTime namsinh, string diachi, string sodienthoai, bool quyenhan, bool active);

        [OperationContract]
        bool SuaKhachHang(string username, string password, string hoten, string gioitinh, DateTime namsinh, string diachi, string sodienthoai, bool quyenhan, bool active);

        [OperationContract]
        bool ktdangnhapKhachHang(string username, string password);

        [OperationContract]
        bool ktdangnhapKhachHang1(string txtusername, string txtpassword);

        [OperationContract]
        KhachHang findLoginKhachHang(string username, string password);
        #endregion
        #region[HoaDon]
        [OperationContract]
        List<HoaDon> findAllHoaDon();

        [OperationContract]
        HoaDon findHoaDon(string mahd);

        [OperationContract]
        bool ThemHoaDon(string mahd, string username, DateTime ngaylap,  DateTime ngaythanhtoan, int trangthai, bool active);

        [OperationContract]
        bool XoaHoaDon(string mahd);

        [OperationContract]
        bool XoaHoaDon1(string mahd, string username, DateTime ngaylap, DateTime ngaythanhtoan, int trangthai, bool active);

        [OperationContract]
        bool SuaHoaDon(string mahd, string username, DateTime ngaylap, DateTime ngaythanhtoan, int trangthai, bool active);

        [OperationContract]
        string LayMaLoaiHD();
        #endregion
        #region[ChitietHD]
        [OperationContract]
        List<ChitietHD> findAllChitietHD();

        //[OperationContract]
        //HoaDon findChitietHD(string mahd);

        [OperationContract]
        bool ThemChitietHD(string mahd, string masp, int soluong, int gia, int thanhtien);

        //[OperationContract]
        //bool XoaChitietHD(string mahd);

        [OperationContract]
        bool SuaChitietHD(string mahd, string masp, int soluong, int gia, int thanhtien);

        [OperationContract]
        List<ChitietHD> findChitietHD(string mahd);
        #endregion
        #region[PhieuNhap]
        [OperationContract]
        List<PhieuNhap> findAllPhieuNhap();

        [OperationContract]
        PhieuNhap findPhieuNhap(string mapn);

        [OperationContract]
        bool ThemPhieuNhap(string mapn, DateTime ngay, bool active);

        [OperationContract]
        bool XoaPhieuNhap(string mapn);

        [OperationContract]
        bool XoaPhieuNhap1(string mapn, DateTime ngay, bool active);

        [OperationContract]
        bool SuaPhieuNhap(string mapn, DateTime ngay, bool active);

        [OperationContract]
        string LayMaLoaiPN();
        #endregion
        #region[Kho]
        [OperationContract]
        List<Kho> findAllKho();

        [OperationContract]
        List<Kho> findKho(DateTime ngay1, DateTime ngay2);

        [OperationContract]
        bool ThemKho(string masp, DateTime ngay, int soluong);

        [OperationContract]
        bool ThemKho1(string masp, DateTime ngay, int soluong);

        /*[OperationContract]
        bool XoaKho(string masp);

        [OperationContract]
        bool SuaKho(string masp, DateTime ngay, int soluong);*/

        [OperationContract]
        List<Kho> ThongKeTK(DateTime ngay1, DateTime ngay2);
        #endregion
        #region[ChitietPN]
        [OperationContract]
        List<ChitietPN> findAllChitietPN();

        [OperationContract]
        bool ThemChitietPN(string mapn, string masp, int soluong);

        [OperationContract]
        bool SuaChitietPN(string mapn, string masp, int soluong);
        #endregion
    }
}
