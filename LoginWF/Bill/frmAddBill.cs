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

namespace LoginWF.Bill
{
    public partial class frmAddBill : DevExpress.XtraEditors.XtraForm
    {

        private bool isSave_ = false;
        private bool isAdd_;
        private int idPaymentType_;
        private int idBill_;
        private int idBookRoom_;

        public frmAddBill()
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

        public int IDPaymentType
        {
            set
            {
                idPaymentType_ = value;
            }
        }

        public int IDBill
        {
            set
            {
                idBill_ = value;
            }
        }

        public int IDBookRoom
        {
            set
            {
                idBookRoom_ = value;
            }
        }

        private void frmAddBill_Load(object sender, EventArgs e)
        {
            txtMoney.Focus();
            if (!isAdd_)
            {
                BillDAO dao = new BillDAO();
                hoaDon info = dao.GetSingleByID(idBill_);

                txtIdBill.Text = info.maHoaDon.ToString();
                txtIdBookRoom.Text = info.maDatPhong.ToString();
                dtimeDateOfPayment.Text = info.ngayThanhToan.ToString();
                txtMoney.Text = info.soTien.ToString();
                txtIdPaymentType.Text = info.maKieuThanhToan.ToString();
                txtDescribeBill.Text = info.ghiChu.ToString();
            }
            else
            {
                //BillDAO dao = new CardCustomerDAO();
                txtIdBill.Text = idBill_.ToString();
                txtIdPaymentType.Text = idPaymentType_.ToString();
                txtIdBookRoom.Text = idBookRoom_.ToString();
            }
        }

        public bool CheckEmpty()
        {
            bool flag = true;
            if (txtMoney.Text == string.Empty)
            {
                errorProvider.SetError(txtMoney, "Số tiền không được để trống");
                flag = false;
            }
            else
            {
                errorProvider.SetError(txtMoney, null);
            }

            return flag;
        }

        public hoaDon GetInfoBill()
        {
            BillDAO dao = new BillDAO();
            hoaDon info = new hoaDon();
            info.maHoaDon = int.Parse(txtIdBill.Text);
            info.maDatPhong = int.Parse(txtIdBookRoom.Text);
            //info.ngayThanhToan = DateTime.Parse(dtimeDateOfPayment.Text);
            info.soTien = decimal.Parse(txtMoney.Text);
            info.maKieuThanhToan = int.Parse(txtIdPaymentType.Text);
            info.ghiChu = txtDescribeBill.Text;

            return info;
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            if (!CheckEmpty())
            {
                return;
            }

            BillDAO dao = new BillDAO();

            hoaDon info = GetInfoBill();

            if (isAdd_)
            {
                if (txtMoney.Text.Trim().Equals(dao.GetNameByIDHoaDon(decimal.Parse(txtMoney.Text)), StringComparison.OrdinalIgnoreCase) && int.Parse(txtMoney.Text) == dao.GetIDByName(int.Parse(txtMoney.Text)))
                {
                    DialogResult dlg = MessageBox.Show(string.Format("Hóa đơn đã có, vẫn muốn thêm?"), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                MessageBox.Show(string.Format("{0} hóa đơn thành công!", isAdd_ == true ? "Thêm" : "Sửa"), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(string.Format("{0} hóa đơn thất bại!", isAdd_ == true ? "Thêm" : "Sửa"), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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