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
    public partial class UserControlQLKhachHang : UserControl
    {
        ServiceShopLaptopClient lt = new ServiceShopLaptopClient();
        bool isAdditem = false;
        public UserControlQLKhachHang()
        {
            InitializeComponent();
            HienThi();
            panel5.Enabled = false;
            cbgioitinh.Items.Add("Nam");
            cbgioitinh.Items.Add("Nữ");
            cbquyenhan.Items.Add("True");
            cbquyenhan.Items.Add("False");
            cbactive.Items.Add(true);
            cbactive.Items.Add(false);
        }

        public void HienThi()
        {
            gvKhachHang.AutoGenerateColumns = false;
            dtnamsinh.Format = DateTimePickerFormat.Custom;
            dtnamsinh.CustomFormat = "dd/MM/yyyy";
            this.gvKhachHang.DataSource = lt.findAllKhachHang();
        }
        public void LamMoi()
        {
            txtusername.Text = "";
            txtpassword.Text = "";
            txthoten.Text = "";
            cbgioitinh.Text = "Chọn giới tính";
            dtnamsinh.Text = "";
            txtdiachi.Text = "";
            cbquyenhan.Text = "Chọn quyền hạn";
            cbactive.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            panel5.Enabled = true;
            isAdditem = true;
            txtusername.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            isAdditem = false;
            txtusername.Enabled = false;
            panel5.Enabled = true;
            string id;
            int currentIndex = gvKhachHang.CurrentRow.Index;
            id = gvKhachHang.Rows[currentIndex].Cells[0].Value.ToString();
            KhachHang kh = new KhachHang();
            kh = lt.findKhachHang(id);
            txtusername.Text = kh.username;
            txtpassword.Text = kh.password;
            txthoten.Text = kh.hoten;
            cbgioitinh.Text = kh.gioitinh;
            dtnamsinh.Text = kh.namsinh.ToString();
            txtdiachi.Text = kh.diachi;
            cbquyenhan.Text = kh.quyenhan.ToString();
            cbactive.Text = kh.active.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int currentIndex = gvKhachHang.CurrentRow.Index;
            string username = gvKhachHang.Rows[currentIndex].Cells[0].Value.ToString();
            System.DateTime myDate = default(System.DateTime);
            myDate = Convert.ToDateTime(gvKhachHang.Rows[currentIndex].Cells[4].Value);
            string password = gvKhachHang.Rows[currentIndex].Cells[1].Value.ToString();
            string hoten = gvKhachHang.Rows[currentIndex].Cells[2].Value.ToString();;
            string gioitinh = gvKhachHang.Rows[currentIndex].Cells[3].Value.ToString();
            DateTime namsinh = myDate;
            string diachi = gvKhachHang.Rows[currentIndex].Cells[5].Value.ToString();
            string sodienthoai = gvKhachHang.Rows[currentIndex].Cells[6].Value.ToString();
            bool quyenhan = Convert.ToBoolean(gvKhachHang.Rows[currentIndex].Cells[7].Value);
            bool active = false;
            DialogResult h = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này không?", "Thông tin", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                if (lt.XoaKhangHang1(username, password,hoten,gioitinh,namsinh,diachi,sodienthoai,quyenhan,active))
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            System.DateTime myDate = default(System.DateTime);
            myDate = dtnamsinh.Value;
            string username = txtusername.Text;
            string password = txtpassword.Text;
            string hoten = txthoten.Text;
            string gioitinh = cbgioitinh.Text;
            DateTime namsinh = myDate;
            string diachi = txtdiachi.Text;
            string sodienthoai = txtsodienthoai.Text;
            bool quyenhan = Convert.ToBoolean(cbquyenhan.Text);
            bool active = Convert.ToBoolean(cbactive.Text);
            if (isAdditem == true)
            {
                if (lt.ThemKhachHang(username,password,hoten,gioitinh,namsinh,diachi,sodienthoai,quyenhan,active) == true)
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
                if (lt.SuaKhachHang(username, password, hoten, gioitinh, namsinh, diachi, sodienthoai,quyenhan,active) == true)
                {
                    MessageBox.Show("Sửa thành công!!!");
                    HienThi();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!!!!");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            panel5.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            LamMoi();
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            txtusername.Focus();
        }
    }
}
