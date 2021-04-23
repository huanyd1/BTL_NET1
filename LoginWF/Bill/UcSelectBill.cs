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

namespace LoginWF.Bill
{
    public partial class UcSelectBill : DevExpress.XtraEditors.XtraUserControl
    {
        public UcSelectBill()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public void LoadPaymentType()
        {
            PaymentTypeDAO dao = new PaymentTypeDAO();
            gPaymentType.DataSource = dao.GetAll();
        }

        private void UcSelectBill_Load(object sender, EventArgs e)
        {
            LoadPaymentType();
            LoadcbPaymentType();
            LoadBillByIDPaymentType();
        }

        private void LoadcbPaymentType()
        {
            BookRoomDAO dao = new BookRoomDAO();

            cbPaymentType.DataSource = dao.GetAll();
            cbPaymentType.DisplayMember = "maPhong";
            cbPaymentType.ValueMember = "maDatPhong";
        }

        public void LoadBillByIDPaymentType()
        {
            if (gvPaymentType.RowCount > 0)
            {
                int idPaymentType;
                if (int.TryParse(gvPaymentType.GetFocusedRowCellValue("maKieuThanhToan").ToString(), out idPaymentType))
                {
                    BillDAO dao = new BillDAO();
                    gBill.DataSource = dao.GetBillByIDPaymentType(idPaymentType);
                }
            }
        }

        private void btnAddPaymentType_Click(object sender, EventArgs e)
        {
            frmAddPaymentType frmAddPaymentType = new frmAddPaymentType();
            frmAddPaymentType.IsAdd = true;
            frmAddPaymentType.ShowDialog();

            if (frmAddPaymentType.IsSave)
            {
                LoadPaymentType();
            }
        }

        private void btnEditPaymentType_Click(object sender, EventArgs e)
        {
            if(gvPaymentType.RowCount > 0)
            {
                int idPaymentType = int.Parse(gvPaymentType.GetFocusedRowCellValue("maKieuThanhToan").ToString());

                frmAddPaymentType frmAddPaymentType = new frmAddPaymentType();
                frmAddPaymentType.IsAdd = false;
                frmAddPaymentType.IDPaymentType = idPaymentType;
                frmAddPaymentType.ShowDialog();

                if (frmAddPaymentType.IsSave)
                {
                    LoadPaymentType();
                }
            }


        }

        private void btnDeletePaymentType_Click(object sender, EventArgs e)
        {
            if (gvPaymentType.RowCount > 0)
            {
                string namePaymentType = gvPaymentType.GetFocusedRowCellValue("tenKieuThanhToan").ToString();
                DialogResult dlg = MessageBox.Show(string.Format("Bạn có muốn xóa kiểu thanh toán '{0}' không?", namePaymentType), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    int idPaymentType = int.Parse(gvPaymentType.GetFocusedRowCellValue("maKieuThanhToan").ToString());

                    PaymentTypeDAO dao = new PaymentTypeDAO();

                    if (dao.Delete(idPaymentType))
                    {
                        MessageBox.Show("Xóa kiểu thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPaymentType();
                    }
                    else
                    {
                        MessageBox.Show("Hiện tại không thể xóa kiểu thanh toán này, vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            int idBookRoom = int.Parse(cbPaymentType.SelectedValue.ToString());
            int idPaymentType = int.Parse(gvPaymentType.GetFocusedRowCellValue("maKieuThanhToan").ToString());

            frmAddBill frmAddBill = new frmAddBill();
            frmAddBill.IsAdd = true;
            frmAddBill.IDPaymentType = idPaymentType;
            frmAddBill.IDBookRoom = idBookRoom;
            frmAddBill.ShowDialog();
            if (frmAddBill.IsSave)
            {
                LoadBillByIDPaymentType();
            }
        }

        private void btnEditBill_Click(object sender, EventArgs e)
        {
            if(gvBill.RowCount > 0)
            {
                int idBill = int.Parse(gvBill.GetFocusedRowCellValue("maHoaDon").ToString());
                int idBookRoom = int.Parse(cbPaymentType.SelectedValue.ToString());
                int idPaymentType = int.Parse(gvPaymentType.GetFocusedRowCellValue("maKieuThanhToan").ToString());

                frmAddBill frmAddBill = new frmAddBill();
                frmAddBill.IsAdd = false;
                frmAddBill.IDPaymentType = idPaymentType;
                frmAddBill.IDBookRoom = idBookRoom;
                frmAddBill.IDBill = idBill;
                frmAddBill.ShowDialog();
                if (frmAddBill.IsSave)
                {
                    LoadBillByIDPaymentType();
                }
            }
        }
    }
}
