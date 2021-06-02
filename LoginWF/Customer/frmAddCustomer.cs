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

namespace LoginWF.Customer
{
    public partial class frmAddCustomer : DevExpress.XtraEditors.XtraForm
    {

        private bool isSave_ = false;
        private bool isAdd_;
        private int idCustomer_;
        private int idCardCusotmer_;

        public frmAddCustomer()
        {
            InitializeComponent();

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

        public int IDCustomer
        {
            set
            {
                idCustomer_ = value;
            }
        }

        public int IDCardCustomer
        {
            set
            {
                idCardCusotmer_ = value;
            }
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            txtNameCustomer.Focus();
            if (!isAdd_)
            {
                CustomerDAO dao = new CustomerDAO();
                khachHang info = dao.GetSingleByID(idCustomer_);

                txtIdCustomer.Text = info.maKhachHang.ToString();
                txtNameCustomer.Text = info.tenKhachHang.ToString();
                txtUsername.Text = info.tenDangNhap.ToString();
                txtPassword.Text = info.matKhau.ToString();
                txtIdCardCustomer.Text = info.maSoThe.ToString();
                txtAddress.Text = info.diaChi.ToString();
                txtDescribeCustomer.Text = info.mieuTaKhachHang.ToString();
            }
            else
            {
                txtIdCustomer.Text = idCustomer_.ToString();
                txtIdCardCustomer.Text = idCardCusotmer_.ToString();
            }
        }

        public bool CheckEmpty()
        {
            bool flag = true;
            if (txtNameCustomer.Text == string.Empty)
            {
                errorProvider.SetError(txtNameCustomer, "Tên loại thẻ không được để trống");
                flag = false;
            }
            else
            {
                errorProvider.SetError(txtNameCustomer, null);
            }

            return flag;
        }

        public khachHang GetInfoCustomer()
        {
            khachHang info = new khachHang();
            info.maKhachHang = int.Parse(txtIdCustomer.Text);
            info.tenKhachHang = txtNameCustomer.Text;
            info.tenDangNhap = txtUsername.Text;
            info.matKhau = txtPassword.Text;
            info.maSoThe = int.Parse(txtIdCardCustomer.Text);
            info.diaChi = txtAddress.Text;
            info.mieuTaKhachHang = txtDescribeCustomer.Text;

            return info;
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            if (!CheckEmpty())
            {
                return;
            }

            CustomerDAO dao = new CustomerDAO();

            khachHang info = GetInfoCustomer();

            if (isAdd_)
            {
                if (txtNameCustomer.Text.Trim().Equals(dao.GetNameByIDLoaiThe(txtNameCustomer.Text), StringComparison.OrdinalIgnoreCase) && int.Parse(txtIdCustomer.Text) == dao.GetIDByName(int.Parse(txtIdCustomer.Text)))
                {
                    DialogResult dlg = MessageBox.Show(string.Format("Khách hàng đã có, vẫn muốn thêm?"), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                MessageBox.Show(string.Format("{0} khách hàng thành công!", isAdd_ == true ? "Thêm" : "Sửa"), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(string.Format("{0} khách hàng thất bại!", isAdd_ == true ? "Thêm" : "Sửa"), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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