using System;
using System.Windows.Forms;
using Model.DAO;

namespace LoginWF.CardCustomer
{
    public partial class UcSelectCadCustomer : DevExpress.XtraEditors.XtraUserControl
    {
        public UcSelectCadCustomer()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void LoadCardType()
        {
            CardTypeDAO dao = new CardTypeDAO();
            gCardType.DataSource = dao.GetAll();
        }

        private void LoadcbCardType()
        {
            CardTypeDAO dao = new CardTypeDAO();

            cbCardType.DataSource = dao.GetAll();
            cbCardType.DisplayMember = "tenLoaiThe";
            cbCardType.ValueMember = "maLoaiThe";
        }

        public void LoadCardCustomerByIDCardType()
        {
            if (gvCardType.RowCount > 0)
            {
                int idCardCustomer;
                if (int.TryParse(gvCardType.GetFocusedRowCellValue("maLoaiThe").ToString(), out idCardCustomer))
                {
                    CardCustomerDAO dao = new CardCustomerDAO();
                    gCardCustomer.DataSource = dao.GetCardCustomerByIDCardType(idCardCustomer);
                }
            }
        }

        private void LoadCardCustomer()
        {
            //CardCustomerDAO dao = new CardCustomerDAO();
            //gCardCustomer.DataSource = dao.GetAll();
        }

        private void UcSelectCadCustomer_Load(object sender, EventArgs e)
        {
            LoadCardCustomer();
            LoadCardType();
            LoadcbCardType();
        }

        private void gCardCustomer_Load(object sender, EventArgs e)
        {
            //CardCustomerDAO dao = new CardCustomerDAO();
            //gCardType.DataSource = dao.GetAll();
        }

        private void btnAddCardType_Click(object sender, EventArgs e)
        {
            //int idCardType = int.Parse()

            frmAddCardType frmAddCardType = new frmAddCardType();
            frmAddCardType.IsAdd = true;
            frmAddCardType.ShowDialog();

            if (frmAddCardType.IsSave)
            {
                LoadCardType();
            }
        }

        private void btnEditCardType_Click(object sender, EventArgs e)
        {
            if (gvCardType.RowCount > 0)
            {
                int idCardType = int.Parse(gvCardType.GetFocusedRowCellValue("maLoaiThe").ToString());

                frmAddCardType frmAddCardType = new frmAddCardType();
                frmAddCardType.IsAdd = false;
                frmAddCardType.IDCardType = idCardType;
                frmAddCardType.ShowDialog();
                if (frmAddCardType.IsSave)
                {
                    LoadCardType();
                }
            }
        }

        private void btnDeleteCardType_Click(object sender, EventArgs e)
        {
            if (gvCardType.RowCount > 0)
            {
                string nameCardType = gvCardType.GetFocusedRowCellValue("tenLoaiThe").ToString();
                DialogResult dlg = MessageBox.Show(string.Format("Bạn có muốn xóa loại thẻ '{0}' không?", nameCardType), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    int idCardType = int.Parse(gvCardType.GetFocusedRowCellValue("maLoaiThe").ToString());

                    CardCustomerDAO dao = new CardCustomerDAO();

                    if (dao.Delete(idCardType))
                    {
                        MessageBox.Show("Xóa loại thẻ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCardType();
                    }
                    else
                    {
                        MessageBox.Show("Hiện tại không thể xóa loại thẻ này, vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void gvCardType_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadCardCustomerByIDCardType();
        }

        private void btnAddCustomerCard_Click(object sender, EventArgs e)
        {
            int idCardType = int.Parse(cbCardType.SelectedValue.ToString());

            frmAddCardCustomer frmAddCardCustomer = new frmAddCardCustomer();
            frmAddCardCustomer.IsAdd = true;
            frmAddCardCustomer.IDCardType = idCardType;
            frmAddCardCustomer.ShowDialog();

            if (frmAddCardCustomer.IsSave)
            {
                LoadCardCustomerByIDCardType();
            }
        }

        private void btnEditCustomerCard_Click(object sender, EventArgs e)
        {
            if (gvCardType.RowCount > 0 && gvCardCustomer.RowCount > 0)
            {
                int idCardCustomer = int.Parse(gvCardCustomer.GetFocusedRowCellValue("maSoThe").ToString());
                int idCardType = int.Parse(cbCardType.SelectedValue.ToString());

                frmAddCardCustomer frmAddCardCustomer = new frmAddCardCustomer();
                frmAddCardCustomer.IsAdd = false;
                frmAddCardCustomer.IDCardCustomer = idCardCustomer;
                frmAddCardCustomer.IDCardType = idCardType;
                frmAddCardCustomer.ShowDialog();

                if (frmAddCardCustomer.IsSave)
                {
                    LoadCardCustomerByIDCardType();
                }
            }
        }

        private void btnDeleteCustomerCard_Click(object sender, EventArgs e)
        {
            if (gvCardType.RowCount > 0 && gvCardCustomer.RowCount > 0)
            {
                string nameCardCustomer = gvCardCustomer.GetFocusedRowCellValue("tenThe").ToString();
                DialogResult dlg = MessageBox.Show(string.Format("Bạn có muốn xóa thẻ khách hàng '{0}' không?", nameCardCustomer), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    int idCardCustomer = int.Parse(gvCardCustomer.GetFocusedRowCellValue("maSoThe").ToString());

                    CardCustomerDAO dao = new CardCustomerDAO();

                    if (dao.Delete(idCardCustomer))
                    {
                        MessageBox.Show("Xóa thẻ khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCardCustomerByIDCardType();
                    }
                    else
                    {
                        MessageBox.Show("Hiện tại không thể xóa thẻ khách hàng này, vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
