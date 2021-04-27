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

namespace LoginWF.ListRoom
{
    public partial class frmAddBookRoom : DevExpress.XtraEditors.XtraForm
    {
        private bool isSave_ = false;
        private bool isAdd_;
        private int idBookRoom_;
        private int idCustomer_;
        private int idRoom_;

        public frmAddBookRoom()
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

        public int IDBookRoom
        {
            set
            {
                idBookRoom_ = value;
            }
        }

        public int IDCustomer
        {
            set
            {
                idCustomer_ = value;
            }
        }

        public int IDRoom
        {
            set
            {
                idRoom_ = value;
            }
        }

        private void frmAddBookRoom_Load(object sender, EventArgs e)
        {
            txtDescribeBookRoom.Focus();
            if (!isAdd_)
            {
                BookRoomDAO dao = new BookRoomDAO();
                datPhong info = dao.GetSingleByID(idBookRoom_);

                txtIdBookRoom.Text = info.maDatPhong.ToString();
                txtIdCustomer.Text = info.maKhachHang.ToString();
                txtIdRoom.Text = info.maPhong.ToString();
                dtimeStartDate.Text = info.ngayBatDau.ToString();
                dtimeEndDate.Text = info.ngayKetThuc.ToString();
                txtPrice.Text = info.gia.ToString();
                txtDescribeBookRoom.Text = info.mieuTaDatPhong.ToString();
            }
            else
            {
                //BillDAO dao = new CardCustomerDAO();
                txtIdBookRoom.Text = idBookRoom_.ToString();
                txtIdCustomer.Text = idCustomer_.ToString();
                txtIdRoom.Text = idRoom_.ToString();
            }
        }

        public bool CheckEmpty()
        {
            bool flag = true;
            if (txtDescribeBookRoom.Text == string.Empty)
            {
                errorProvider.SetError(txtDescribeBookRoom, "Miêu tả đặt phòng không được để trống");
                flag = false;
            }
            else
            {
                errorProvider.SetError(txtDescribeBookRoom, null);
            }

            return flag;
        }

        public datPhong GetInfoBookRoom()
        {
            BookRoomDAO dao = new BookRoomDAO();
            datPhong info = new datPhong();
            info.maDatPhong = int.Parse(txtIdBookRoom.Text);
            info.maKhachHang = int.Parse(txtIdCustomer.Text);
            info.maPhong = int.Parse(txtIdRoom.Text);
            info.ngayBatDau = DateTime.Parse(dtimeStartDate.Text);
            info.ngayKetThuc = DateTime.Parse(dtimeEndDate.Text);
            info.gia = decimal.Parse(txtPrice.Text);
            info.mieuTaDatPhong = txtDescribeBookRoom.Text;

            return info;
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            if (!CheckEmpty())
            {
                return;
            }

            if (!CheckEmpty())
            {
                return;
            }

            BookRoomDAO dao = new BookRoomDAO();

            datPhong info = GetInfoBookRoom();

            if (isAdd_)
            {
                if (txtIdBookRoom.Text.Trim().Equals(dao.GetNameByIDDatPhong(int.Parse(txtIdBookRoom.Text)), StringComparison.OrdinalIgnoreCase) && int.Parse(txtDescribeBookRoom.Text) == dao.GetIDByName(int.Parse(txtDescribeBookRoom.Text)))
                {
                    DialogResult dlg = MessageBox.Show(string.Format("Phòng này đã có, vẫn muốn thêm?"), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                MessageBox.Show(string.Format("{0} đặt phòng thành công!", isAdd_ == true ? "Thêm" : "Sửa"), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(string.Format("{0} đặt phòng thất bại!", isAdd_ == true ? "Thêm" : "Sửa"), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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