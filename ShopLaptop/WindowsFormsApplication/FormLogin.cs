using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication.ServiceReferenceShopLaptop;

namespace WindowsFormsApplication
{
    public partial class FormLogin : Form
    {
        ServiceShopLaptopClient lt = new ServiceShopLaptopClient();
        public FormLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnDangnhap;
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string ten,mk;
            ten = txtDangnhap.Text;
            mk = txtMatkhau.Text;
            if(lt.ktdangnhapKhachHang(ten,mk)==true)
            {
                FormMain frmMain = new FormMain();
                frmMain.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập!!","ĐĂNG NHẬP",MessageBoxButtons.OK);
                txtMatkhau.Text = "";
                txtDangnhap.Text = "admin";
                txtMatkhau.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông tin", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            { 
                Application.Exit();
            }
        }       
    }
}
