using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace LoginWF
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
            btnHotelInfomation_ItemClick(null, null);
        }

        private void AddToScreen(Control control)
        {
            panelSelect.Controls.Clear();
            panelSelect.Controls.Add(control);
        }

        private void btnCardCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddToScreen(new CardCustomer.UcSelectCadCustomer());
        }

        private void btnBill_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddToScreen(new Bill.UcSelectBill());
        }

        private void btnListRoom_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddToScreen(new ListRoom.UcSelectListRoom());
        }

        private void btnCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddToScreen(new Customer.UcSelectCustomer());
        }

        private void btnHotelInfomation_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddToScreen(new HotelInformation.UcSelectHotelInformation());
        }

        private void btnSaleReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddToScreen(new SalesReport.UcSelectSalesReport());
        }

        private void btnSaleReport2_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddToScreen(new SalesReport.UCSaleReportWeek());
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddToScreen(new CardCustomer.UcSelectCadCustomer());
        }

        private void barHeaderItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDoiMK frm = new frmDoiMK();
            frm.ShowDialog();
        }
    }
}