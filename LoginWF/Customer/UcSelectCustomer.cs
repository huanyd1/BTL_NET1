using DevExpress.XtraEditors;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginWF.Customer
{
    public partial class UcSelectCustomer : DevExpress.XtraEditors.XtraUserControl
    {
        public UcSelectCustomer()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            LoadCustomer();
            LoadcbCardCustomer();
        }

        private void LoadCustomer()
        {
            CustomerDAO dao = new CustomerDAO();
            gCustomer.DataSource = dao.GetAll();
        }

        private void LoadcbCardCustomer()
        {
            CardCustomerDAO dao = new CardCustomerDAO();

            cbCardCustomer.DataSource = dao.GetAll();
            cbCardCustomer.DisplayMember = "tenThe";
            cbCardCustomer.ValueMember = "maSoThe";
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            int idCardCustomer = int.Parse(cbCardCustomer.SelectedValue.ToString());

            frmAddCustomer frmAddCustomer = new frmAddCustomer();
            frmAddCustomer.IsAdd = true;
            frmAddCustomer.IDCardCustomer = idCardCustomer;
            frmAddCustomer.ShowDialog();
            if(frmAddCustomer.IsSave == true)
            {
                LoadCustomer();
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if(gvCustomer.RowCount > 0)
            {
                int idCustomer = int.Parse(gvCustomer.GetFocusedRowCellValue("maKhachHang").ToString());
                int idCardCustomer = int.Parse(cbCardCustomer.SelectedValue.ToString());

                frmAddCustomer frmAddCustomer = new frmAddCustomer();
                frmAddCustomer.IsAdd = false;
                frmAddCustomer.IDCustomer = idCustomer;
                frmAddCustomer.IDCardCustomer = idCardCustomer;
                frmAddCustomer.ShowDialog();
                if (frmAddCustomer.IsSave == true)
                {
                    LoadCustomer();
                }
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (gvCustomer.RowCount > 0)
            {
                string nameCustomer = gvCustomer.GetFocusedRowCellValue("tenKhachHang").ToString();
                DialogResult dlg = MessageBox.Show(string.Format("Bạn có muốn xóa loại thẻ '{0}' không?", nameCustomer), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    int idCustomer = int.Parse(gvCustomer.GetFocusedRowCellValue("maKhachHang").ToString());

                    CustomerDAO dao = new CustomerDAO();

                    if (dao.Delete(idCustomer))
                    {
                        MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCustomer();
                    }
                    else
                    {
                        MessageBox.Show("Hiện tại không thể xóa loại thẻ này, vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
