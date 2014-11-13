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

namespace WindowsFormsApplication
{
    public partial class UserControlQLPhieuNhap : UserControl
    {
        ServiceShopLaptopClient lt = new ServiceShopLaptopClient();
        bool isAdditem = false;
        List<SanPham> list = new List<SanPham>();
        public UserControlQLPhieuNhap()
        {
            InitializeComponent();
            panel7.Enabled = false;
            panel3.Enabled = false;
            btnThemCT.Enabled = false;
            HienThiPN();
            cbactive.Items.Add(true);
            cbactive.Items.Add(false);
        }

        public void HienThiPN()
        {
            gvPhieuNhap.AutoGenerateColumns = false;
            this.gvPhieuNhap.DataSource = lt.findAllPhieuNhap();
            dtngay.Format = DateTimePickerFormat.Custom;
            dtngay.CustomFormat = "dd/MM/yyyy";
        }

        public void LamMoiPN()
        {
            txtmapn.Text = "";
            dtngay.Text = "";
            cbactive.Text = "";
        }

        public void HienThiSP()
        {
            gvSanPham.AutoGenerateColumns = false;
            this.gvSanPham.DataSource = lt.findAllSanPham();
            gvSanPham.Columns[0].DataPropertyName = "masp";
            gvSanPham.Columns[1].DataPropertyName = "tensp";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            panel7.Enabled = true;
            txtmapn.Enabled = true;
            dtngay.Enabled = true;
            isAdditem = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThemCT.Enabled = true;
            txtmapn.Enabled = false;
            LamMoiPN();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isAdditem = false;
            panel7.Enabled = true;
            txtmapn.Enabled = false;
            dtngay.Enabled = true;
            btnTimPN.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnThemCT.Enabled = true;
            string id;
            int currentIndex = gvPhieuNhap.CurrentRow.Index;
            id = gvPhieuNhap.Rows[currentIndex].Cells[0].Value.ToString();
            PhieuNhap sp = new PhieuNhap();
            sp = lt.findPhieuNhap(id);
            txtmapn.Text = sp.mapn.ToString();
            dtngay.Text = sp.ngay.ToString();
            cbactive.Text = sp.active.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int currentIndex = gvPhieuNhap.CurrentRow.Index;
            string ma = gvPhieuNhap.Rows[currentIndex].Cells[0].Value.ToString();
            DialogResult h = MessageBox.Show("Bạn có chắc muốn xóa phiếu nhập này không?", "Thông tin", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                if (lt.XoaPhieuNhap(ma))
                {
                    MessageBox.Show("Xóa thành công!!!");
                    HienThiPN();
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
            txtmapn.Enabled = false;
            HienThiSP();
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            System.DateTime myDate = default(System.DateTime);
            myDate = dtngay.Value;           
            DateTime ngay = myDate;
            bool active = Convert.ToBoolean(cbactive.Text);
            try
            {
                if (isAdditem == true)
                {
                    string mapn = this.layMaLoaiPN();
                    if (lt.ThemPhieuNhap(mapn,ngay,active) == true)
                    {
                        MessageBox.Show("Lưu thành công!!!");
                        HienThiPN();
                        LamMoiPN();
                    }
                    else
                    {
                        MessageBox.Show("Lưu thất bại!!");
                    }
                }
                else
                {
                    string mapn = this.txtmapn.Text;
                    if (lt.SuaPhieuNhap(mapn,ngay,active) == true)
                    {
                        MessageBox.Show("Lưu thành công!!!");
                        HienThiPN();
                    }
                    else
                    {
                        MessageBox.Show("Lưu thất bại!!!!");
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThemCT.Enabled = true;
            panel13.Enabled = false;
            LamMoiPN();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiPN();
            txtmapn.Focus();
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
                    HienThiChitietPN();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (list.Count == 0) return;
            if (gvChitietPN.SelectedRows.Count > 0)
            {
                SanPham tSanPham = (SanPham)gvChitietPN.CurrentRow.DataBoundItem;
                list.Remove(tSanPham);
                HienThiChitietPN();
            }
        }

        public void HienThiChitietPN()
        {
            gvChitietPN.AutoGenerateColumns = false;
            gvChitietPN.DataSource = null;
            gvChitietPN.DataSource = list;
            gvChitietPN.Columns[0].DataPropertyName = "masp";
            gvChitietPN.Columns[1].DataPropertyName = "tensp";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int currentIndex = gvChitietPN.CurrentRow.Index;
            gvChitietPN.Rows[currentIndex].Cells[2].Value = txtsoluong.Text;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string mapn = txtmapn.Text;
            try
            {
                foreach (DataGridViewRow row in gvChitietPN.Rows)
                {
                    string masp = row.Cells[0].Value.ToString();
                    int soluong = Convert.ToInt32(row.Cells[2].Value);
                    if (lt.ThemChitietPN(mapn, masp, soluong) == true)
                    {
                        MessageBox.Show("Lưu chi tiết phiếu nhập thành công!!!");
                    }
                    else
                    {
                        MessageBox.Show("Lưu chi tiết phiếu nhập thất bại!!");
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int currentIndex = gvChitietPN.CurrentRow.Index;
            System.DateTime myDate = default(System.DateTime);
            myDate = dtngay.Value;
            string masp = gvChitietPN.Rows[currentIndex].Cells[0].Value.ToString();
            DateTime ngay = myDate;
            int soluong = Convert.ToInt32(gvChitietPN.Rows[currentIndex].Cells[2].Value);
            try
            {
                if(lt.ThemKho(masp,ngay,soluong)==true)
                {
                    MessageBox.Show("Lưu kho thành công!!!");
                }
                else
                {
                    MessageBox.Show("Lưu kho thất bại!!!");
                }
            }
            catch(Exception ex)
            {

            }
        }

        private string layMaLoaiPN()
        {
            string maloai = lt.LayMaLoaiSP();
            if(maloai=="")
            {
                return "PN00001";
            }
            else
            {
                int k; //Lấy giá trị số trong mã đã có
                string s = "PN"; //Lấy ký tự mặc định trong chuổi sinh viên đã có
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
