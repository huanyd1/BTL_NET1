using Model.DAO;
using System;
using Model.EF;
using System.Windows.Forms;

namespace LoginWF.Bill
{
    public partial class frmAddPaymentType : DevExpress.XtraEditors.XtraForm
    {
        private bool isSave_ = false;
        private bool isAdd_;
        private int idPaymentType_;

        public frmAddPaymentType()
        {
            InitializeComponent();
            txtIdPaymentType.Enabled = false;
        }

        public bool IsSave
        {
            get
            {
                return isSave_;
            }
        }

        public bool IsAdd
        {
            get
            {
                return isAdd_;
            }
            set
            {
                isAdd_ = value;
            }
        }

        public int IDPaymentType
        {
            set
            {
                idPaymentType_ = value;
            }
        }

        private void frmAddPaymentType_Load(object sender, EventArgs e)
        {
            txtNamePaymentType.Focus();
            if (!isAdd_)
            {
                PaymentTypeDAO dao = new PaymentTypeDAO();
                kieuThanhToan info = dao.GetSingleByID(idPaymentType_);

                txtIdPaymentType.Text = info.maKieuThanhToan.ToString();
                txtNamePaymentType.Text = info.tenKieuThanhToan.ToString();
                txtDescribePaymentType.Text = info.mieuTaKieuThanhToan.ToString();
            }
            else
            {
                txtIdPaymentType.Text = idPaymentType_.ToString();
            }
        }

        public bool CheckEmpty()
        {
            bool flag = true;
            if (txtNamePaymentType.Text == string.Empty)
            {
                errorProvider.SetError(txtNamePaymentType, "Tên loại thẻ không được để trống");
                flag = false;
            }
            else
            {
                errorProvider.SetError(txtNamePaymentType, null);
            }

            return flag;
        }

        public kieuThanhToan GetInfoPaymentType()
        {
            kieuThanhToan info = new kieuThanhToan();
            info.maKieuThanhToan = int.Parse(txtIdPaymentType.Text);
            info.tenKieuThanhToan = txtNamePaymentType.Text;
            info.mieuTaKieuThanhToan = txtDescribePaymentType.Text;

            return info;
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            if (!CheckEmpty())
            {
                return;
            }

            PaymentTypeDAO dao = new PaymentTypeDAO();

            kieuThanhToan info = GetInfoPaymentType();

            if (isAdd_)
            {
                if (txtNamePaymentType.Text.Trim().Equals(dao.GetNameByIDLoaiThe(txtNamePaymentType.Text), StringComparison.OrdinalIgnoreCase) && int.Parse(txtIdPaymentType.Text) == dao.GetIDByName(int.Parse(txtIdPaymentType.Text)))
                {
                    DialogResult dlg = MessageBox.Show(string.Format("Loại thẻ đã có, vẫn muốn thêm?"), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlg == DialogResult.Yes)
                    {
                        if (dao.Add(info))
                        {
                            isSave_ = true;
                        }
                    }

                }
                else
                {
                    if (dao.Add(info))
                    {
                        isSave_ = true;
                    }
                }

            }
            else
            {
                if (dao.Edit(info))
                {
                    isSave_ = true;
                }
            }

            if (isSave_)
            {
                MessageBox.Show(string.Format("{0} kiểu thanh toán thành công!", isAdd_ == true ? "Thêm" : "Sửa"), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(string.Format("{0} kiểu thanh toán thất bại!", isAdd_ == true ? "Thêm" : "Sửa"), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Dữ liệu chưa được lưu, vẫn muốn thoát?", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }
    }
}