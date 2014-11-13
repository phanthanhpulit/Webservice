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
    public partial class UserControlQLLoaiSP : UserControl
    {
        ServiceShopLaptopClient lt = new ServiceShopLaptopClient();
        LoaiSP loai = new LoaiSP();
        bool isAdditem = false;
        public UserControlQLLoaiSP()
        {
            InitializeComponent();
            panel5.Enabled = false;
            HienThi();
            cbactive.Items.Add(true);
            cbactive.Items.Add(false);
        }
        public void HienThi()
        {
            gvLoaiSP.AutoGenerateColumns = false;
            this.gvLoaiSP.DataSource = lt.findAllLoaiSP();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            panel5.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtmaloai.Enabled = true;
            isAdditem = true;
            txtmaloai.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {           
            string tenloai = txttenloai.Text;
            bool active = Convert.ToBoolean(cbactive.Text);
            if(isAdditem == true)
            {
                string maloai = this.layMaLoaiLSP();
                if(lt.ThemLoaiSP(maloai,tenloai,active)==true)
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
                string maloai = this.txtmaloai.Text;
                if(lt.SuaLoaiSP(maloai,tenloai,active)==true)
                {
                    MessageBox.Show("Sửa thành công!!!");
                    HienThi();
                    LamMoi();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!!!!");
                }
            }
        }
        public void LamMoi()
        {
            txtmaloai.Text = "";
            txttenloai.Text = "";
            cbactive.Text = "";
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            LamMoi();
            txtmaloai.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            panel5.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            LamMoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            panel5.Enabled = true;
            isAdditem = false;
            txtmaloai.Enabled = false;
            cbactive.Enabled = false;
            string id;
            int currentIndex = gvLoaiSP.CurrentRow.Index;
            id = gvLoaiSP.Rows[currentIndex].Cells[0].Value.ToString();
            LoaiSP loai = new LoaiSP();
            loai = lt.findLoaiSP(id);
            txtmaloai.Text = loai.maloai;
            txttenloai.Text = loai.tenloai;
            cbactive.Text = loai.active.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int currentIndex = gvLoaiSP.CurrentRow.Index;
            string maloai = gvLoaiSP.Rows[currentIndex].Cells[0].Value.ToString();
            string tenloai = gvLoaiSP.Rows[currentIndex].Cells[1].Value.ToString();
            bool active = Convert.ToBoolean(gvLoaiSP.Rows[currentIndex].Cells[2].Value);
            DialogResult h = MessageBox.Show("Bạn có chắc muốn xóa loại sản phẩm này không?", "Thông tin", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                if (lt.XoaLoaiSP1(maloai,tenloai,active))
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

        private string layMaLoaiLSP()
        {
            string maloai = lt.LayMaLoaiLSP();
            if(maloai=="")
            {
                return "L00001";
            }
            else
            {
                int k; //Lấy giá trị số trong mã đã có
                string s = "L"; //Lấy ký tự mặc định trong chuổi sinh viên đã có
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
