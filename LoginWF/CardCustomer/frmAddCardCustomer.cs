using DevExpress.XtraEditors;
using Model.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginWF.CardCustomer
{
    public partial class frmAddCardCustomer : DevExpress.XtraEditors.XtraForm
    {

        private bool isSave_ = false;
        private bool isAdd_;
        private int idCardCustomer_;
        private int idCardType_;

        public frmAddCardCustomer()
        {
            InitializeComponent();
            txtIdCardCustomer.Enabled = false;
            txtIdCardType.Enabled = false;
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

        public int IDCardCustomer
        {
            set
            {
                idCardCustomer_ = value;
            }
        }

        public int IDCardType
        {
            set
            {
                idCardType_ = value;
            }
        }

        private void frmAddCardCustomer_Load(object sender, EventArgs e)
        {
            txtNameCardCustomer.Focus();
            if (!isAdd_)
            {
                CardCustomerDAO dao = new CardCustomerDAO();
                theKhachHang info = dao.GetSingleByID(idCardCustomer_);

                txtIdCardCustomer.Text = info.maSoThe.ToString();
                txtNameCardCustomer.Text = info.tenThe.ToString();
                txtIdCardType.Text = info.maLoaiThe.ToString();
            }
            else
            {
                CardCustomerDAO dao = new CardCustomerDAO();
                txtIdCardCustomer.Text = idCardCustomer_.ToString();
                txtIdCardType.Text = dao.GetNameByIDLoaiThe(idCardType_);
            }
        }

        public bool CheckEmpty()
        {
            bool flag = true;
            if (txtNameCardCustomer.Text == string.Empty)
            {
                errorProvider.SetError(txtNameCardCustomer, "Tên loại thẻ không được để trống");
                flag = false;
            }
            else
            {
                errorProvider.SetError(txtNameCardCustomer, null);
            }

            return flag;
        }

        public theKhachHang GetInfoCardCustomer()
        {
            CardTypeDAO dao = new CardTypeDAO();
            theKhachHang info = new theKhachHang();
            info.maSoThe = int.Parse(txtIdCardCustomer.Text);
            info.tenThe = txtNameCardCustomer.Text;
            info.maLoaiThe = idCardType_;

            return info;
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            if (!CheckEmpty())
            {
                return;
            }

            CardCustomerDAO dao = new CardCustomerDAO();

            Model.EF.theKhachHang info = GetInfoCardCustomer();

            if (isAdd_)
            {
                if (txtNameCardCustomer.Text.Trim().Equals(dao.GetNameByIDThe(txtNameCardCustomer.Text), StringComparison.OrdinalIgnoreCase) && int.Parse(txtIdCardCustomer.Text) == dao.GetIDByName(int.Parse(txtIdCardCustomer.Text)))
                {
                    DialogResult dlg = MessageBox.Show(string.Format("Thẻ khách hàng đã có, vẫn muốn thêm?"), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                MessageBox.Show(string.Format("{0} thẻ khách hàng thành công!", isAdd_ == true ? "Thêm" : "Sửa"), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(string.Format("{0} thẻ khách hàng thất bại!", isAdd_ == true ? "Thêm" : "Sửa"), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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