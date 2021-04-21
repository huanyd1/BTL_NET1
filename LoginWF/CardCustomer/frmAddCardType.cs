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

namespace LoginWF.CardCustomer
{
    public partial class frmAddCardType : DevExpress.XtraEditors.XtraForm
    {

        private bool isSave_ = false;
        private bool isAdd_;
        private int idCardType_;

        public frmAddCardType()
        {
            InitializeComponent();
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

        public int IDCardType
        {
            set
            {
                idCardType_ = value;
            }
        }

        private void frmAddCardType_Load(object sender, EventArgs e)
        {
            txtNameCardType.Focus();
            if (!isAdd_)
            {
                CardTypeDAO dao = new CardTypeDAO();
                Model.EF.loaiTheKhachHang info = dao.GetSingleByID(idCardType_);

                txtIdCardType.Text = info.maLoaiThe.ToString();
                txtNameCardType.Text = info.tenLoaiThe.ToString();
                txtDescribeCardType.Text = info.mieuTaLoaiThe.ToString();
            }
            else
            {
                txtIdCardType.Text = idCardType_.ToString();
            }
        }

        public bool CheckEmpty()
        {
            bool flag = true;
            if(txtNameCardType.Text == string.Empty)
            {
                errorProvider.SetError(txtNameCardType, "Tên loại thẻ không được để trống");
                flag = false;
            }
            else
            {
                errorProvider.SetError(txtNameCardType, null);
            }

            return flag;
        }

        public Model.EF.loaiTheKhachHang GetInfoCardType()
        {
            Model.EF.loaiTheKhachHang info = new Model.EF.loaiTheKhachHang();
            info.maLoaiThe = int.Parse(txtIdCardType.Text);
            info.tenLoaiThe = txtNameCardType.Text;
            info.mieuTaLoaiThe = txtDescribeCardType.Text;

            return info;
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            if (!CheckEmpty())
            {
                return;
            }

            CardTypeDAO dao = new CardTypeDAO();

            Model.EF.loaiTheKhachHang info = GetInfoCardType();

            if (isAdd_)
            {
                if(txtNameCardType.Text.Trim().Equals(dao.GetNameByIDLoaiThe(txtNameCardType.Text), StringComparison.OrdinalIgnoreCase) && int.Parse(txtIdCardType.Text) == dao.GetIDByName(int.Parse(txtIdCardType.Text)))
                {
                    DialogResult dlg = MessageBox.Show(string.Format("Loại thẻ đã có, vẫn muốn thêm?"), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dlg == DialogResult.Yes)
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
                MessageBox.Show(string.Format("{0} loại thẻ thành công!", isAdd_ == true ? "Thêm" : "Sửa"), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(string.Format("{0} loại thẻ thất bại!", isAdd_ == true ? "Thêm" : "Sửa"), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Dữ liệu chưa được lưu, vẫn muốn thoát?", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlg == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }
    }
}