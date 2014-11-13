using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication.ServiceReferenceShopLaptop;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication
{
    public partial class UserControlQLHoaDon : UserControl
    {
        ServiceShopLaptopClient lt = new ServiceShopLaptopClient();
        bool isAdditem = false;
        List<SanPham> list = new List<SanPham>();
        public UserControlQLHoaDon()
        {
            InitializeComponent();
            HienThiHD();
            panel3.Enabled = false;
            panel13.Enabled = false;
            btnThemCT.Enabled = false;
            cbtrangthai.Items.Add(1);
            cbtrangthai.Items.Add(2);
            cbtrangthai.Items.Add(3);
            cbactive.Items.Add(true);
            cbactive.Items.Add(false);
        }

        public void HienThiHD()
        {
            gvHoaDon.AutoGenerateColumns = false;
            this.gvHoaDon.DataSource = lt.findAllHoaDon();
            dtngaylap.Format = DateTimePickerFormat.Custom;
            dtngaylap.CustomFormat = "dd/MM/yyyy";
            dtngaythanhtoan.Format = DateTimePickerFormat.Custom;
            dtngaythanhtoan.CustomFormat = "dd/MM/yyyy";
        }
        public void LamMoiHD()
        {
            txtmahd.Text = "";
            txtusername.Text = "";
            dtngaylap.Text = "";
            dtngaythanhtoan.Text = "";
            cbtrangthai.Text = "";
            cbactive.Text = "";
        }
        public  void HienThiSP()
        {
            gvSanPham.AutoGenerateColumns = false;
            this.gvSanPham.DataSource = lt.findAllSanPham();
            gvSanPham.Columns[0].DataPropertyName = "masp";
            gvSanPham.Columns[1].DataPropertyName = "tensp";
            gvSanPham.Columns[2].DataPropertyName = "gia";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            panel13.Enabled = true;
            LamMoiHD();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnXuLy.Enabled = false;
            btnThemCT.Enabled = false;
            isAdditem = true;
            txtmahd.Enabled = true;
            txtusername.Enabled = true;
            dtngaylap.Enabled = true;
            dtngaythanhtoan.Enabled = true;
            cbtrangthai.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isAdditem = false;
            panel13.Enabled = true;
            txtmahd.Enabled = false;
            txtusername.Enabled = true;
            dtngaylap.Enabled = true;
            dtngaythanhtoan.Enabled = true;
            cbtrangthai.Enabled = true;
            txttim.Enabled = true;
            btnTim.Enabled = true;
            btnThem.Enabled = false;
            btnXuLy.Enabled = false;
            btnXoa.Enabled = false;
            btnThemCT.Enabled = true;
            string id;
            int currentIndex = gvHoaDon.CurrentRow.Index;
            id = gvHoaDon.Rows[currentIndex].Cells[0].Value.ToString();
            HoaDon sp = new HoaDon();
            sp = lt.findHoaDon(id);
            txtmahd.Text = sp.mahd.ToString();
            txtusername.Text = sp.username.ToString();
            dtngaylap.Text = sp.ngaylap.ToString();
            dtngaythanhtoan.Text = sp.ngaythanhtoan.ToString();
            cbtrangthai.Text = sp.trangthai.ToString();
            cbactive.Text = sp.active.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int currentIndex = gvHoaDon.CurrentRow.Index;
            string mahd = gvHoaDon.Rows[currentIndex].Cells[0].Value.ToString();
            System.DateTime myDate = default(System.DateTime);
            myDate = Convert.ToDateTime(gvHoaDon.Rows[currentIndex].Cells[2].Value);
            System.DateTime myDate1 = default(System.DateTime);
            myDate1 = Convert.ToDateTime(gvHoaDon.Rows[currentIndex].Cells[3].Value);
            string username = gvHoaDon.Rows[currentIndex].Cells[1].Value.ToString();
            DateTime ngaylap = myDate;
            DateTime ngaythanhtoan = myDate1;
            int trangthai = Convert.ToInt32(gvHoaDon.Rows[currentIndex].Cells[4].Value);
            bool active = false;
            DialogResult h = MessageBox.Show("Bạn có chắc muốn xóa loại sản phẩm này không?", "Thông tin", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                if (lt.XoaHoaDon1(mahd, username,ngaylap,ngaythanhtoan,trangthai,active)==true)
                {
                    MessageBox.Show("Xóa thành công!!!");
                    HienThiHD();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!!!");
                }
            }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            panel3.Enabled = true;
            HienThiSP();           
        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            isAdditem = false;
            panel13.Enabled = true;
            txtmahd.Enabled = false;
            txtusername.Enabled = false;
            dtngaylap.Enabled = false;
            dtngaythanhtoan.Enabled = true;
            cbtrangthai.Enabled = true;
            txttim.Enabled = true;
            btnTim.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThemCT.Enabled = false;
            string id;
            int currentIndex = gvHoaDon.CurrentRow.Index;
            id = gvHoaDon.Rows[currentIndex].Cells[0].Value.ToString();
            HoaDon sp = new HoaDon();
            sp = lt.findHoaDon(id);
            txtmahd.Text = sp.mahd.ToString();
            txtusername.Text = sp.username.ToString();
            dtngaylap.Text = sp.ngaylap.ToString();
            dtngaythanhtoan.Text = sp.ngaythanhtoan.ToString();
            cbtrangthai.Text = sp.trangthai.ToString();
            cbactive.Text = sp.active.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            System.DateTime myDate = default(System.DateTime);
            myDate = dtngaylap.Value;
            System.DateTime myDate1 = default(System.DateTime);
            myDate1 = dtngaythanhtoan.Value;            
            string username = txtusername.Text;
            DateTime ngaylap = myDate;
            DateTime ngaythanhtoan = myDate1;
            int trangthai = Convert.ToInt32(cbtrangthai.Text);
            bool active = Convert.ToBoolean(cbactive.Text);
            try
            {
                if (isAdditem == true)
                {
                    string mahd = this.layMaLoaiHD();
                    if (lt.ThemHoaDon(mahd, username, ngaylap, ngaythanhtoan, trangthai, active) == true)
                    {
                        MessageBox.Show("Lưu thành công!!!");
                        HienThiHD();
                    }
                    else
                    {
                        MessageBox.Show("Lưu thất bại!!");
                    }
                }
                else
                {
                    string mahd = this.txtmahd.Text;
                    if(lt.SuaHoaDon(mahd, username, ngaylap, ngaythanhtoan, trangthai, active)==true)
                    {
                        MessageBox.Show("Lưu thành công!!!");
                        HienThiHD();
                    }
                    else
                    {
                        MessageBox.Show("Lưu thất bại!!!!");
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThemCT.Enabled = true;
            btnXuLy.Enabled = true;
            panel13.Enabled = false;
            LamMoiHD();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            LamMoiHD();
            txtmahd.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string masp = txtTimSP.Text;
            //gvSanPham.DataSource = null;
            //List<SanPham> sp = new List<SanPham>();
            //sp = lt.findSanPham1(txtTimSP.Text.Trim().ToString());
            gvSanPham.AutoGenerateColumns = false;
            //gvSanPham.DataSource = null;
            gvSanPham.DataSource = lt.findSanPham1(txtTimSP.Text.Trim().ToString());
            gvSanPham.Columns[0].DataPropertyName = "masp";
            //gvSanPham.Columns[1].DataPropertyName = "tensp";
            gvSanPham.Columns[1].DataPropertyName = "gia";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (gvSanPham.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = gvSanPham.SelectedRows[0];
                    SanPham tSanPham = (SanPham)row.DataBoundItem;
                    foreach (var items in list)
                    {
                        if (items.masp == tSanPham.masp) return;
                    }
                    list.Add(tSanPham);
                    HienThiChitietHD();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (list.Count == 0) return;
            if (gvChitietHD.SelectedRows.Count > 0)
            {
                SanPham tSanPham = (SanPham)gvChitietHD.CurrentRow.DataBoundItem;
                list.Remove(tSanPham);
                //15.
                HienThiChitietHD();
            }
        }
        public void HienThiChitietHD()
        {
            gvChitietHD.AutoGenerateColumns = false;
            gvChitietHD.DataSource = null;
            gvChitietHD.DataSource = list;
            gvChitietHD.Columns[0].DataPropertyName = "masp";
            gvChitietHD.Columns[1].DataPropertyName = "tensp";
            gvChitietHD.Columns[2].DataPropertyName = "gia";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int currentIndex = gvChitietHD.CurrentRow.Index;
            //id = gvKhachHang.Rows[currentIndex].Cells[0].Value.ToString();
            //HienThiChitietHD();
            if(IsNumber(txtsoluong.Text)==true)
            {
                gvChitietHD.Rows[currentIndex].Cells[3].Value = txtsoluong.Text;
                int tien = (Convert.ToInt32(txtsoluong.Text)) * (Convert.ToInt32(gvChitietHD.Rows[currentIndex].Cells[2].Value));
                gvChitietHD.Rows[currentIndex].Cells[4].Value = tien;
            }
            else
            {
                MessageBox.Show("Bạn cần nhập số lượng là số!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mahd = txtmahd.Text;
            try
            {
                foreach(DataGridViewRow row in gvChitietHD.Rows)
                {
                    string masp = row.Cells[0].Value.ToString();
                    int gia = Convert.ToInt32(row.Cells[2].Value);
                    int soluong = Convert.ToInt32(row.Cells[3].Value);
                    int thanhtien = Convert.ToInt32(row.Cells[4].Value);
                    if(lt.ThemChitietHD(mahd,masp,soluong,gia,thanhtien)==true)
                    {
                        MessageBox.Show("Lưu chi tiết hóa đơn thành công!!!");
                    }
                    else
                    {
                        MessageBox.Show("Lưu chi tiết hóa đơn thất bại!!");
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            System.DateTime myDate = default(System.DateTime);
            myDate = dtngaythanhtoan.Value;
            int currentIndex = gvChitietHD.CurrentRow.Index;
            string masp = gvChitietHD.Rows[currentIndex].Cells[0].Value.ToString();
            int soluong = Convert.ToInt32(gvChitietHD.Rows[currentIndex].Cells[3].Value);
            try
            {
                if(lt.ThemKho1(masp,myDate,soluong)==true)
                {
                    MessageBox.Show("Lưu kho thành công!!!");
                }
                else
                {
                    MessageBox.Show("Lưu kho thất bại!!");
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void btnXemCT_Click(object sender, EventArgs e)
        {
            panel13.Enabled = true;
            txtmahd.Enabled = false;
            txtusername.Enabled = false;
            dtngaylap.Enabled = false;
            dtngaythanhtoan.Enabled = false;
            cbtrangthai.Enabled = false;
            txttim.Enabled = false;
            btnTim.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThemCT.Enabled = false;
            string id;
            int currentIndex = gvHoaDon.CurrentRow.Index;
            id = gvHoaDon.Rows[currentIndex].Cells[0].Value.ToString();
            HoaDon sp = new HoaDon();
            sp = lt.findHoaDon(id);
            txtmahd.Text = sp.mahd.ToString();
            txtusername.Text = sp.username.ToString();
            dtngaylap.Text = sp.ngaylap.ToString();
            dtngaythanhtoan.Text = sp.ngaythanhtoan.ToString();
            cbtrangthai.Text = sp.trangthai.ToString();
            try
            {
                if (lt.findChitietHD(id) != null)
                {
                    panel3.Enabled = true;
                    panel7.Enabled = false;
                    panel9.Enabled = false;
                    gvChitietHD.AutoGenerateColumns = false;
                    gvChitietHD.DataSource = lt.findChitietHD(id);
                    gvChitietHD.Columns[0].DataPropertyName = "masp";
                    gvChitietHD.Columns[1].DataPropertyName = "tensp";
                    gvChitietHD.Columns[2].DataPropertyName = "gia";
                    gvChitietHD.Columns[2].DataPropertyName = "soluong";
                    gvChitietHD.Columns[2].DataPropertyName = "thanhtien";
                }
                else
                {
                    MessageBox.Show("Hóa đơn này chưa có chi tiết!!! ^^");
                }
            }
            catch(Exception ex)
            {

            }
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        private string layMaLoaiHD()
        {
            string maloai = lt.LayMaLoaiHD();
            if(maloai=="")
            {
                return "HD00001";
            }
            else
            {
                int k; //Lấy giá trị số trong mã đã có
                string s = "HD"; //Lấy ký tự mặc định trong chuổi sinh viên đã có
                k = Convert.ToInt32(maloai.ToString().Substring(2, 5));
                k = k + 1;
                if (k < 10)
                    s += "0000";
                else if (k < 100)
                    s += "000";
                else if (k < 1000)
                    s += "00";
                else if (k < 10000)
                    s += "0";
                s += k.ToString();
                return s;
            }            
        }
    }
}
