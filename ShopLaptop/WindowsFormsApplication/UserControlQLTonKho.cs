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
    public partial class UserControlQLTonKho : UserControl
    {
        ServiceShopLaptopClient lt = new ServiceShopLaptopClient();
        public UserControlQLTonKho()
        {
            InitializeComponent();
            dttungay.Format = DateTimePickerFormat.Custom;
            dttungay.CustomFormat = "dd/MM/yyyy";
            dtdenngay.Format = DateTimePickerFormat.Custom;
            dtdenngay.CustomFormat = "dd/MM/yyyy";
            HienThiKho();
        }

        public void HienThiKho()
        {
            gvKho.AutoGenerateColumns = false;
            this.gvKho.DataSource = lt.findAllKho();           
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            System.DateTime myDate1 = default(System.DateTime);
            myDate1 = dttungay.Value;
            System.DateTime myDate2 = default(System.DateTime);
            myDate2 = dtdenngay.Value;
            gvKho.AutoGenerateColumns = false;
            gvKho.DataSource = lt.findKho(myDate1, myDate2);
        }

        private void btnXemAll_Click(object sender, EventArgs e)
        {
            HienThiKho();
        }
    }
}
