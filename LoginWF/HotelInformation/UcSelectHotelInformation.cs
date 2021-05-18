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

namespace LoginWF.HotelInformation
{
    public partial class UcSelectHotelInformation : DevExpress.XtraEditors.XtraUserControl
    {
        public UcSelectHotelInformation()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            LoadHotelInfomation();
            EnabelTextBox();
        }

        private void LoadHotelInfomation()
        {
            int idHotel = 1;

            HotelInfomationDAO dao = new HotelInfomationDAO();
            thongTinKhachSan info = dao.GetSingleByID(idHotel);

            txtIdHotel.Text = info.maKhachSan.ToString();
            txtNameHotel.Text = info.tenKhachSan.ToString();
            txtStarNumber.Text = info.soSao.ToString();
            txtAddress.Text = info.diaChi.ToString();
            txtDescribeHotel.Text = info.mieuTaKhachSan.ToString();
            txtRoomNumber.Text = info.soPhong.ToString();
        }

        private void EnabelTextBox()
        {
            txtIdHotel.Enabled = false;
            txtNameHotel.Enabled = false;
            txtStarNumber.Enabled = false;
            txtAddress.Enabled = false;
            txtDescribeHotel.Enabled = false;
            txtRoomNumber.Enabled = false;

            txtIdHotel.Font = new Font(txtIdHotel.Font, FontStyle.Bold);
            txtNameHotel.Font = new Font(txtNameHotel.Font, FontStyle.Bold);
            txtStarNumber.Font = new Font(txtStarNumber.Font, FontStyle.Bold);
            txtAddress.Font = new Font(txtAddress.Font, FontStyle.Bold);
            txtDescribeHotel.Font = new Font(txtDescribeHotel.Font, FontStyle.Bold);
            txtRoomNumber.Font = new Font(txtRoomNumber.Font, FontStyle.Bold);
        }
    }
}
