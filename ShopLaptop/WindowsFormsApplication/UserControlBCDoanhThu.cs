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
    public partial class UserControlBCDoanhThu : UserControl
    {
        ServiceShopLaptopClient lt = new ServiceShopLaptopClient();
        public UserControlBCDoanhThu()
        {
            InitializeComponent();
            dttungay.Format = DateTimePickerFormat.Custom;
            dttungay.CustomFormat = "dd/MM/yyyy";
            dtdenngay.Format = DateTimePickerFormat.Custom;
            dtdenngay.CustomFormat = "dd/MM/yyyy";
        }

        private void khoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            System.DateTime myDate = default(System.DateTime);
            myDate = dttungay.Value;
            System.DateTime myDate1 = default(System.DateTime);
            myDate1 = dtdenngay.Value;
            lt.ThongKeTK(myDate, myDate1);
            //reportViewer1.D = lt.ThongKeTK(myDate, myDate1);
        }
    }
}
