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
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication
{
    public partial class UserControlQLSanPham : UserControl
    {
        ServiceShopLaptopClient lt = new ServiceShopLaptopClient();
        SanPham loai = new SanPham();
        bool isAdditem = false;
        public UserControlQLSanPham()
        {
            InitializeComponent();
            panel4.Enabled = false;
            HienThi();
            cbactive.Items.Add(true);
            cbactive.Items.Add(false);
        }
        public void HienThi()
        {
            gvSanPham.AutoGenerateColumns = false;
            (gvSanPham.Columns[5] as DataGridViewComboBoxColumn).DataSource = lt.findAllLoaiSP();
            (gvSanPham.Columns[5] as DataGridViewComboBoxColumn).DisplayMember = "tenloai";
            (gvSanPham.Columns[5] as DataGridViewComboBoxColumn).ValueMember = "maloai";
            this.gvSanPham.DataSource = lt.findAllSanPham();

            cbLoaiSP.DataSource = lt.findAllLoaiSP();
            cbLoaiSP.DisplayMember = "tenloai";
            cbLoaiSP.ValueMember = "maloai";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            panel4.Enabled = true;
            LamMoi();
            isAdditem = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtID.Enabled = false;
            txtmasp.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string tensp = this.txttensp.Text;
                int gia = Convert.ToInt32(this.txtgia.Text);
                string hinh = this.txthinh.Text;
                string maloai = this.cbLoaiSP.SelectedValue.ToString();
                string CPU = this.txtCPU.Text;
                string RAM = this.txtRAM.Text;
                string HDD = this.txtHDD.Text;
                string VGA = this.txtVGA.Text;
                string manhinh = this.txtmanhinh.Text;
                string wireless = this.txtwireless.Text;
                string battery = this.txtbattery.Text;
                string weight = this.txtweight.Text;
                string chitiet = this.txtchitiet.Text;
                string baohanh = this.txtbaohanh.Text;
                bool active = Convert.ToBoolean(this.cbactive.Text);
                if (isAdditem == true)
                {
                    string masp = this.layMaLoaiSP();
                    if (lt.ThemSanPham(masp, tensp, gia, hinh, maloai, CPU, RAM, HDD, VGA, manhinh,
                     wireless, battery, weight, chitiet, baohanh, active) == true)
                    {
                        MessageBox.Show("Lưu thành công!!!");
                        HienThi();
                        LamMoi();
                    }
                    else
                    {
                        MessageBox.Show("Lưu thất bại!!!");
                    }
                }
                else
                {
                    string masp = this.txtmasp.Text;
                    if (lt.SuaSanPham(masp, tensp, gia, hinh, maloai, CPU, RAM, HDD, VGA, manhinh,
                     wireless, battery, weight, chitiet, baohanh, active) == true)
                    {
                        MessageBox.Show("Sửa thành công!!!");
                        HienThi();
                        LamMoi();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công!!!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bạn cần nhập giá là số!!!");
            }
        }

        private void gvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                  
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                panel4.Enabled = true;
                isAdditem = false;
                txtmasp.Enabled = false;
                txtID.Enabled = false;
                btnXoa.Enabled = false;
                string id;
                int currentIndex = gvSanPham.CurrentRow.Index;
                id = gvSanPham.Rows[currentIndex].Cells[1].Value.ToString();
                SanPham sp = new SanPham();
                sp = lt.findSanPham(id);
                string st = lt.findLoaiSP(sp.maloai).tenloai;
                txtID.Text = sp.id.ToString();
                txtmasp.Text = sp.masp.ToString();
                txttensp.Text = sp.tensp.ToString();
                txtgia.Text = sp.gia.ToString();
                txthinh.Text = sp.hinh.ToString();
                cbLoaiSP.Text = st.ToString();
                txtCPU.Text = sp.CPU.ToString();
                txtRAM.Text = sp.RAM.ToString();
                txtHDD.Text = sp.HDD.ToString();
                txtVGA.Text = sp.VGA.ToString();
                txtmanhinh.Text = sp.display.ToString();
                txtwireless.Text = sp.wireless.ToString();
                txtbattery.Text = sp.battery.ToString();
                txtweight.Text = sp.weight.ToString();
                txtchitiet.Text = sp.chitiet.ToString();
                txtbaohanh.Text = sp.baohanh.ToString();
                cbactive.Text = sp.active.ToString();
                btnThem.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;       
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống. Xin mời bạn thử lại!!!");
            }
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            LamMoi();
            txtmasp.Focus();
        }
        public void LamMoi()
        {
            txtID.Text = "";
            txtmasp.Text = "";
            txttensp.Text = "";
            txtgia.Text = "";
            txthinh.Text = "";
            cbLoaiSP.Text = "";
            txtCPU.Text = "";
            txtRAM.Text = "";
            txtHDD.Text = "";
            txtVGA.Text = "";
            txtmanhinh.Text = "";
            txtwireless.Text = "";
            txtbattery.Text = "";
            txtweight.Text = "";
            txtchitiet.Text = "";
            txtbaohanh.Text = "";
            cbactive.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            panel4.Enabled = false;
            LamMoi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int currentIndex = gvSanPham.CurrentRow.Index;
            string masp = gvSanPham.Rows[currentIndex].Cells[1].Value.ToString();
            string tensp = gvSanPham.Rows[currentIndex].Cells[2].Value.ToString();
            int gia = Convert.ToInt32(gvSanPham.Rows[currentIndex].Cells[3].Value);
            string hinh = gvSanPham.Rows[currentIndex].Cells[4].Value.ToString();
            string maloai = gvSanPham.Rows[currentIndex].Cells[5].Value.ToString();
            string CPU = gvSanPham.Rows[currentIndex].Cells[6].Value.ToString();
            string RAM = gvSanPham.Rows[currentIndex].Cells[7].Value.ToString();
            string HDD = gvSanPham.Rows[currentIndex].Cells[8].Value.ToString();
            string VGA = gvSanPham.Rows[currentIndex].Cells[9].Value.ToString();
            string manhinh = gvSanPham.Rows[currentIndex].Cells[10].Value.ToString();
            string wireless = gvSanPham.Rows[currentIndex].Cells[11].Value.ToString();
            string battery = gvSanPham.Rows[currentIndex].Cells[12].Value.ToString();
            string weight = gvSanPham.Rows[currentIndex].Cells[14].Value.ToString();
            string chitiet = gvSanPham.Rows[currentIndex].Cells[15].Value.ToString();
            string baohanh = gvSanPham.Rows[currentIndex].Cells[16].Value.ToString();
            bool active = false;
            DialogResult h = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này không?", "Thông tin", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                if (lt.XoaSanPham1(masp, tensp, gia, hinh, maloai, CPU, RAM, HDD, VGA, manhinh,
            wireless, battery, weight, chitiet, baohanh, active)==true)
                {
                    MessageBox.Show("Xóa thành công!!!");
                    HienThi();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!!!");
                }
            }           
        }

        private string NoiLuuHinhAnh = @"..\..\..\..\ShopLaptop\WebApplication\Images\Products\";

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op1 = new OpenFileDialog();
                op1.Filter = "Images |*.jpg;*.jpeg;*.png;*.gif";
                op1.Multiselect = false;
                if (op1.ShowDialog() == DialogResult.OK)
                {
                    string[] tmp = op1.FileNames;
                    foreach (string i in tmp)
                    {
                        FileInfo fi = new FileInfo(i);
                        string[] tenanh = i.Split('\\');
                        string des = NoiLuuHinhAnh + tenanh[tenanh.Length - 1];
                        try
                        {
                            fi.CopyTo(des);
                            txthinh.Text = "\\Images\\SanPham\\" + tenanh[tenanh.Length - 1];
                        }
                        catch
                        {
                            string ten = tenanh[tenanh.Length - 1];
                            string tenmoi = DateTime.Now.ToString("ddMMyyyyHHmmssmmmm") + ten.Substring(ten.LastIndexOf("."));
                            fi.CopyTo(NoiLuuHinhAnh + tenmoi);
                            txthinh.Text = "\\Images\\Products\\" + tenmoi;
                        }
                    }
                    MessageBox.Show("Upload ảnh thành công!!!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi trong quá trình tải hình!!!");
            }
        }

        private string getFileName(string path)
        {
            string[] arr = path.Split('\\');
            return arr[arr.Length - 1];
        }

        private string layMaLoaiSP()
        {
            string maloai = lt.LayMaLoaiSP();
            if(maloai=="")
            {
                return "SP00001";
            }
            else
            {
                int k; //Lấy giá trị số trong mã đã có
                string s = "SP"; //Lấy ký tự mặc định trong chuổi sinh viên đã có
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

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }
    }  
}


