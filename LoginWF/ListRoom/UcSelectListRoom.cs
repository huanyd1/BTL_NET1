using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.EF;
using Model.DAO;

namespace LoginWF.ListRoom
{
    public partial class UcSelectListRoom : DevExpress.XtraEditors.XtraUserControl
    {
        public UcSelectListRoom()
        {
            InitializeComponent();
            LoadListRoom();
            LoadcbCustomer();
            LoadBookRoomByListRoom();
        }

        private void LoadListRoom()
        {
            ListRoomDAO dao = new ListRoomDAO();
            gListRoom.DataSource = dao.GetAll();
        }

        private void LoadcbCustomer()
        {
            CustomerDAO dao = new CustomerDAO();

            cbCustomer.DataSource = dao.GetAll();
            cbCustomer.DisplayMember = "tenKhachHang";
            cbCustomer.ValueMember = "maKhachHang";
        }

        private void LoadBookRoomByListRoom()
        {
            if (gvListRoom.RowCount > 0)
            {
                int idRoom;
                if (int.TryParse(gvListRoom.GetFocusedRowCellValue("maPhong").ToString(), out idRoom))
                {
                    BookRoomDAO dao = new BookRoomDAO();
                    gBookRoom.DataSource = dao.GetBookRoomByIDListRoom(idRoom);
                }
            }
        }

        private void btnAddListRoom_Click(object sender, EventArgs e)
        {
            frmAddListRoom frmAddListRoom = new frmAddListRoom();
            frmAddListRoom.IsAdd = true;
            frmAddListRoom.ShowDialog();
            if(frmAddListRoom.IsSave == true)
            {
                LoadListRoom();
            }
        }

        private void btnEditListRoom_Click(object sender, EventArgs e)
        {
            if (gvListRoom.RowCount > 0)
            {
                int idRoom = int.Parse(gvListRoom.GetFocusedRowCellValue("maPhong").ToString());
                //int idHotke

                frmAddListRoom frmAddListRoom = new frmAddListRoom();
                frmAddListRoom.IsAdd = false;
                frmAddListRoom.IDRoom = idRoom;
                frmAddListRoom.ShowDialog();
                if (frmAddListRoom.IsSave == true)
                {
                    LoadListRoom();
                }
            }
        }

        private void btnDeleteListRoom_Click(object sender, EventArgs e)
        {
            if (gvListRoom.RowCount > 0)
            {
                string nameListRoom = gvListRoom.GetFocusedRowCellValue("tenPhong").ToString();
                DialogResult dlg = MessageBox.Show(string.Format("Bạn có muốn xóa phòng '{0}' không?", nameListRoom), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    int idRoom = int.Parse(gvListRoom.GetFocusedRowCellValue("maPhong").ToString());

                    ListRoomDAO dao = new ListRoomDAO();

                    if (dao.Delete(idRoom))
                    {
                        MessageBox.Show("Xóa phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListRoom();
                    }
                    else
                    {
                        MessageBox.Show("Hiện tại không thể xóa phòng này, vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAddBookRoom_Click(object sender, EventArgs e)
        {
            if (gvListRoom.RowCount > 0)
            {
                int idRoom = int.Parse(gvListRoom.GetFocusedRowCellValue("maPhong").ToString());
                int idCustomer = int.Parse(cbCustomer.SelectedValue.ToString());

                frmAddBookRoom frmAddBookRoom = new frmAddBookRoom();
                frmAddBookRoom.IsAdd = true;
                frmAddBookRoom.IDRoom = idRoom;
                frmAddBookRoom.IDCustomer = idCustomer;
                frmAddBookRoom.ShowDialog();
                if (frmAddBookRoom.IsSave == true)
                {
                    LoadBookRoomByListRoom();
                }
            }
        }

        private void btnEditBookRoom_Click(object sender, EventArgs e)
        {
            if (gvListRoom.RowCount > 0)
            {
                int idRoom = int.Parse(gvListRoom.GetFocusedRowCellValue("maPhong").ToString());
                int idCustomer = int.Parse(cbCustomer.SelectedValue.ToString());
                int idBookRoom = int.Parse(gvBookRoom.GetFocusedRowCellValue("maDatPhong").ToString());

                frmAddBookRoom frmAddBookRoom = new frmAddBookRoom();
                frmAddBookRoom.IsAdd = false;
                frmAddBookRoom.IDBookRoom = idBookRoom;
                frmAddBookRoom.IDRoom = idRoom;
                frmAddBookRoom.IDCustomer = idCustomer;
                frmAddBookRoom.ShowDialog();
                if (frmAddBookRoom.IsSave == true)
                {
                    LoadBookRoomByListRoom();
                }
            }
        }

        private void btnDeleteBookRoom_Click(object sender, EventArgs e)
        {
            if (gvListRoom.RowCount > 0)
            {
                string nameMieuTa = gvBookRoom.GetFocusedRowCellValue("mieuTaDatPhong").ToString();
                DialogResult dlg = MessageBox.Show(string.Format("Bạn có muốn xóa phòng '{0}' không?", nameMieuTa), "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    int idBookRoom = int.Parse(gvBookRoom.GetFocusedRowCellValue("maDatPhong").ToString());

                    BookRoomDAO dao = new BookRoomDAO();

                    if (dao.Delete(idBookRoom))
                    {
                        MessageBox.Show("Xóa đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBookRoomByListRoom();
                    }
                    else
                    {
                        MessageBox.Show("Hiện tại không thể xóa đặt phòng này, vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
