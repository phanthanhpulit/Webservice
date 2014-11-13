namespace WindowsFormsApplication
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLSanPham = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLLoaiSanpham = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLPhieuNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLHoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLTonKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnBCDoanhThu = new DevExpress.XtraBars.BarButtonItem();
            this.btnBCTonKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnTGThongTin = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tabTrangChu = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnThoat,
            this.btnQLSanPham,
            this.btnQLLoaiSanpham,
            this.btnKhachHang,
            this.btnQLPhieuNhap,
            this.btnQLHoaDon,
            this.btnQLTonKho,
            this.btnBCDoanhThu,
            this.btnBCTonKho,
            this.btnTGThongTin});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbonControl1.Size = new System.Drawing.Size(1081, 142);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát chương trình";
            this.btnThoat.Id = 1;
            this.btnThoat.Name = "btnThoat";
            // 
            // btnQLSanPham
            // 
            this.btnQLSanPham.Caption = "Quản lý sản phẩm";
            this.btnQLSanPham.Id = 2;
            this.btnQLSanPham.Name = "btnQLSanPham";
            this.btnQLSanPham.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLSanPham_ItemClick);
            // 
            // btnQLLoaiSanpham
            // 
            this.btnQLLoaiSanpham.Caption = "Quản lý loại sản phẩm";
            this.btnQLLoaiSanpham.Id = 3;
            this.btnQLLoaiSanpham.Name = "btnQLLoaiSanpham";
            this.btnQLLoaiSanpham.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLLoaiSanpham_ItemClick);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Caption = "Quản lý khách hàng";
            this.btnKhachHang.Id = 4;
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhachHang_ItemClick);
            // 
            // btnQLPhieuNhap
            // 
            this.btnQLPhieuNhap.Caption = "Quản lý phiếu nhập";
            this.btnQLPhieuNhap.Id = 5;
            this.btnQLPhieuNhap.Name = "btnQLPhieuNhap";
            this.btnQLPhieuNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLPhieuNhap_ItemClick);
            // 
            // btnQLHoaDon
            // 
            this.btnQLHoaDon.Caption = "Quản lý hóa đơn";
            this.btnQLHoaDon.Id = 6;
            this.btnQLHoaDon.Name = "btnQLHoaDon";
            this.btnQLHoaDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLHoaDon_ItemClick);
            // 
            // btnQLTonKho
            // 
            this.btnQLTonKho.Caption = "Quản lý tồn kho";
            this.btnQLTonKho.Id = 7;
            this.btnQLTonKho.Name = "btnQLTonKho";
            this.btnQLTonKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLTonKho_ItemClick);
            // 
            // btnBCDoanhThu
            // 
            this.btnBCDoanhThu.Caption = "Báo cáo doanh thu";
            this.btnBCDoanhThu.Id = 8;
            this.btnBCDoanhThu.Name = "btnBCDoanhThu";
            this.btnBCDoanhThu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBCDoanhThu_ItemClick);
            // 
            // btnBCTonKho
            // 
            this.btnBCTonKho.Caption = "Báo cáo tồn kho";
            this.btnBCTonKho.Id = 9;
            this.btnBCTonKho.Name = "btnBCTonKho";
            // 
            // btnTGThongTin
            // 
            this.btnTGThongTin.Caption = "Thông tin công ty";
            this.btnTGThongTin.Id = 10;
            this.btnTGThongTin.Name = "btnTGThongTin";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "HỆ THỐNG";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThoat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "QUẢN LÝ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnQLSanPham);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnQLLoaiSanpham);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnKhachHang);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnQLPhieuNhap);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.ShowCaptionButton = false;
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnQLHoaDon);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.ShowCaptionButton = false;
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnQLTonKho);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.ShowCaptionButton = false;
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8,
            this.ribbonPageGroup9});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "BÁO CÁO";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnBCDoanhThu);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.ShowCaptionButton = false;
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btnBCTonKho);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.ShowCaptionButton = false;
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup10});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "TRỢ GIÚP";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.btnTGThongTin);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.ShowCaptionButton = false;
            // 
            // tabTrangChu
            // 
            this.tabTrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabTrangChu.Name = "tabTrangChu";
            this.tabTrangChu.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.tabTrangChu.Size = new System.Drawing.Size(1075, 215);
            this.tabTrangChu.Text = "Trang chủ";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 142);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabTrangChu;
            this.xtraTabControl1.Size = new System.Drawing.Size(1081, 243);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabTrangChu});
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 385);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnQLSanPham;
        private DevExpress.XtraBars.BarButtonItem btnQLLoaiSanpham;
        private DevExpress.XtraBars.BarButtonItem btnKhachHang;
        private DevExpress.XtraBars.BarButtonItem btnQLPhieuNhap;
        private DevExpress.XtraBars.BarButtonItem btnQLHoaDon;
        private DevExpress.XtraBars.BarButtonItem btnQLTonKho;
        private DevExpress.XtraBars.BarButtonItem btnBCDoanhThu;
        private DevExpress.XtraBars.BarButtonItem btnBCTonKho;
        private DevExpress.XtraBars.BarButtonItem btnTGThongTin;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraTab.XtraTabPage tabTrangChu;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
    }
}