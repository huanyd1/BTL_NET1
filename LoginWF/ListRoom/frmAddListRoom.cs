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
    public partial class frmAddListRoom : DevExpress.XtraEditors.XtraForm
    {

        private bool isSave_ = false;
        private bool isAdd_;
        private int idRoom_;
        private int idHotel_;

        public frmAddListRoom()
        {
            InitializeComponent();
            txtIdHotel.Enabled = false;
            txtIdRoom.Enabled = false;
            LoadcbTinhTrangPhong();
            LoadcbLoaiPhong();
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

        public int IDRoom
        {
            set
            {
                idRoom_ = value;
            }
        }

        public int IDHotel
        {
            set
            {
                idHotel_ = value;
            }
        }

        private void LoadcbTinhTrangPhong()
        {
            cbTinhTrangPhong.Items.Add("Còn trống");
            cbTinhTrangPhong.Items.Add("Đã đặt");
            cbTinhTrangPhong.Items.Add("Không xác định");
        }

        private void LoadcbLoaiPhong()
        {
            cbRoomType.Items.Add("VIP");
            cbRoomType.Items.Add("Cao cấp");
            cbRoomType.Items.Add("Thường");
        }

        private void frmAddListRoom_Load(object sender, EventArgs e)
        {
            txtNameRoom.Focus();
            if (!isAdd_)
            {
                ListRoomDAO dao = new ListRoomDAO();
                danhSachPhong info = dao.GetSingleByID(idRoom_);

                txtIdRoom.Text = info.maPhong.ToString();
                txtNameRoom.Text = info.tenPhong.ToString();
                cbRoomType.Text = info.loaiPhong.ToString();
                txtIdHotel.Text = info.maKhachsan.ToString();
                txtDescribeRoom.Text = info.mieuTaPhong.ToString();
                cbTinhTrangPhong.Text = info.tinhTrangPhong.ToString();
                txtCostRoom.Text = info.giaPhong.ToString();
            }
            else
            {
                idHotel_ = 1;
                //BillDAO dao = new CardCustomerDAO();
                txtIdRoom.Text = idRoom_.ToString();
                txtIdHotel.Text = idHotel_.ToString();
            }
        }


        public bool CheckEmpty()
        {
            bool flag = true;
            if (txtNameRoom.Text == string.Empty)
            {
                errorProvider.SetError(txtNameRoom, "Số tiền không được để trống");
                flag = false;
            }
            else
            {
                errorProvider.SetError(txtNameRoom, null);
            }

            return flag;
        }

        public danhSachPhong GetInfoRoom()
        {
            ListRoomDAO dao = new ListRoomDAO();
            danhSachPhong info = new danhSachPhong();
            info.maPhong = int.Parse(txtIdRoom.Text);
            info.tenPhong = txtNameRoom.Text;
            info.loaiPhong = cbTinhTrangPhong.Text;
            info.maKhachsan = int.Parse(txtIdHotel.Text);
            info.mieuTaPhong = txtDescribeRoom.Text;
            info.tinhTrangPhong = cbTinhTrangPhong.Text;
            info.giaPhong = decimal.Parse(txtCostRoom.Text);

            return info;
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            if (!CheckEmpty())
            {
                return;
            }

            ListRoomDAO dao = new ListRoomDAO();

            danhSachPhong info = GetInfoRoom();

            if (isAdd_)
            {
                if (txtNameRoom.Text.Trim().Equals(dao.GetNameByIDPhong(txtNameRoom.Text), StringComparison.OrdinalIgnoreCase) && int.Parse(txtNameRoom.Text) == dao.GetIDByName(int.Parse(txtNameRoom.Text)))
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
                MessageBox.Show(string.Format("{0} phòng thành công!", isAdd_ == true ? "Thêm" : "Sửa"), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(string.Format("{0} phòng thất bại!", isAdd_ == true ? "Thêm" : "Sửa"), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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