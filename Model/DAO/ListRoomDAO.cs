using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class ListRoomDAO : BaseDAO
    {
        public List<danhSachPhong> GetAll()
        {
            List<danhSachPhong> danhSachPhongs = db_.danhSachPhongs.ToList();

            return danhSachPhongs;
        }

        public danhSachPhong GetSingleByID(int maPhong)
        {
            danhSachPhong danhSachPhong = db_.danhSachPhongs.Where(t => t.maPhong == maPhong).FirstOrDefault();

            return danhSachPhong;
        }
        public bool Add(danhSachPhong danhSachPhong)
        {
            try
            {
                db_.danhSachPhongs.Add(danhSachPhong);
                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }
        public bool Edit(danhSachPhong danhSachPhong)
        {
            try
            {
                danhSachPhong currentdanhSachPhong = GetSingleByID(danhSachPhong.maPhong);

                //currentdanhSachPhong.maLoaiThe = danhSachPhong.maLoaiThe;
                currentdanhSachPhong.tenPhong = danhSachPhong.tenPhong;
                currentdanhSachPhong.loaiPhong = danhSachPhong.loaiPhong;
                currentdanhSachPhong.maKhachsan = danhSachPhong.maKhachsan;
                currentdanhSachPhong.mieuTaPhong = danhSachPhong.mieuTaPhong;
                currentdanhSachPhong.tinhTrangPhong = danhSachPhong.tinhTrangPhong;
                currentdanhSachPhong.giaPhong = danhSachPhong.giaPhong;

                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }
        public bool Delete(int maPhong)
        {
            try
            {
                danhSachPhong currentdanhSachPhong = GetSingleByID(maPhong);

                db_.danhSachPhongs.Remove(currentdanhSachPhong);
                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public string GetNameByIDPhong(string namePhong)
        {
            string info = db_.danhSachPhongs.Where(t => t.tenPhong == namePhong).Select(t => t.tenPhong).FirstOrDefault();

            return info;
        }

        public int GetIDByNamePhong(string namePhong)
        {
            int info = db_.danhSachPhongs.Where(t => t.tenPhong == namePhong).Select(t => t.maPhong).FirstOrDefault();

            return info;
        }


        public int GetIDByName(int id)
        {
            danhSachPhong info = db_.danhSachPhongs.Where(t => t.maPhong == id).FirstOrDefault();

            return id;
        }
    }
}
