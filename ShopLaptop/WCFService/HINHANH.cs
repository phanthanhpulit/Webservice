using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace WCFService
{
    public class HINHANH
    {
        public static string CopyFile(string pNguon, string pName)
        {

            if (pNguon == LayChuoi() + "Default.jpg") return "Default.jpg";
            FileInfo fi = new FileInfo(pNguon);

            string sDich = Application.StartupPath;
            DirectoryInfo ThuMuc = new DirectoryInfo(sDich);

            int Lap = 3;
            while (Lap > 0)
            {
                ThuMuc = new DirectoryInfo(ThuMuc.Parent.FullName.ToString());
                Lap--;
            }
            Random Next = new Random();
            int SoNgauNhiena = Next.Next(0, 100000);
            int SoNgauNhienb = Next.Next(0, 100000);
            sDich = ThuMuc.FullName.ToString() + @"\WebApplication\Images\Products\" + pName + SoNgauNhiena.ToString() + SoNgauNhienb.ToString() + ".jpg";

            File.Delete(sDich);
            fi.CopyTo(sDich);
            return pName + SoNgauNhiena.ToString() + SoNgauNhienb.ToString() + ".jpg";
        }
        public static string LayChuoi()
        {


            string sDich = Application.StartupPath;
            DirectoryInfo ThuMuc = new DirectoryInfo(sDich);

            int Lap = 3;
            while (Lap > 0)
            {
                ThuMuc = new DirectoryInfo(ThuMuc.Parent.FullName.ToString());
                Lap--;
            }

            sDich = ThuMuc.FullName.ToString() + @"\WebApplication\Images\Products\";


            return sDich;
        }
    }
}