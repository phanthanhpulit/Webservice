using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTab;

namespace WindowsFormsApplication
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public void TabCreating(XtraTabControl TabControl, string Text, UserControl UC)
        {
            int Index = KiemTraTonTai(TabControl, Text);
            if (Index >= 0)
            {
                TabControl.SelectedTabPage = TabControl.TabPages[Index];
                TabControl.SelectedTabPage.Text = Text;

            }
            else
            {
                XtraTabPage TabPage = new XtraTabPage { Text = Text };
                TabControl.TabPages.Add(TabPage);
                TabControl.SelectedTabPage = TabPage;

                //UC.TopLevelControl = false;
                UC.Parent = TabPage;
                //  Form.MdiParent = this;
                UC.Show();
                UC.Dock = DockStyle.Fill;
            }
        }
        public static int KiemTraTonTai(XtraTabControl TabControlName, string TabName)
        {
            int temp = -1;
            for (int i = 0; i < TabControlName.TabPages.Count; i++)
            {
                if (TabControlName.TabPages[i].Text == TabName)
                {
                    temp = i;
                    break;
                }
            }
            return temp;
        }

        private void btnQLSanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserControlQLSanPham usersp = new UserControlQLSanPham();
            TabCreating(xtraTabControl1, "Quản lý sản phẩm", usersp);
        }

        private void btnQLLoaiSanpham_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserControlQLLoaiSP userlsp = new UserControlQLLoaiSP();
            TabCreating(xtraTabControl1, "Quản lý loại sản phẩm", userlsp);
        }

        private void btnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserControlQLKhachHang userkh = new UserControlQLKhachHang();
            TabCreating(xtraTabControl1, "Quản lý khách hàng", userkh);
        }

        private void btnQLHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserControlQLHoaDon userhd = new UserControlQLHoaDon();
            TabCreating(xtraTabControl1, "Quản lý hóa đơn", userhd);
        }

        private void btnQLPhieuNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserControlQLPhieuNhap userpn = new UserControlQLPhieuNhap();
            TabCreating(xtraTabControl1, "Quản lý phiếu nhập", userpn);
        }

        private void btnQLTonKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserControlQLTonKho usertk = new UserControlQLTonKho();
            TabCreating(xtraTabControl1, "Quản lý tồn kho", usertk);
        }

        private void btnBCDoanhThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserControlBCDoanhThu userdt = new UserControlBCDoanhThu();
            TabCreating(xtraTabControl1, "Báo cáo doanh thu", userdt);
        }

    }
}
