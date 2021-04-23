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
    }
}