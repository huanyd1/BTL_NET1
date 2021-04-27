using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
     public class BookRoomDAO : BaseDAO
    {
        public List<datPhong> GetAll()
        {
            List<datPhong> datPhongs = db_.datPhongs.ToList();

            return datPhongs;
        }

        public datPhong GetSingleByID(int maDatPhong)
        {
            datPhong datPhong = db_.datPhongs.Where(t => t.maDatPhong == maDatPhong).FirstOrDefault();

            return datPhong;
        }

        public List<datPhong> GetBookRoomByIDListRoom(int idListRoom)
        {
            List<datPhong> datPhongs = db_.datPhongs.Where(t => t.maPhong == idListRoom).ToList();

            return datPhongs;
        }

        public bool Add(datPhong datPhong)
        {
            try
            {
                db_.datPhongs.Add(datPhong);
                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }
        public bool Edit(datPhong datPhong)
        {
            try
            {
                datPhong currentdatPhong = GetSingleByID(datPhong.maDatPhong);

                //currentdatPhong.maLoaiThe = datPhong.maLoaiThe;
                currentdatPhong.maKhachHang = datPhong.maKhachHang;
                currentdatPhong.maPhong = datPhong.maPhong;
                currentdatPhong.ngayBatDau = datPhong.ngayBatDau;
                currentdatPhong.ngayKetThuc = datPhong.ngayKetThuc;
                currentdatPhong.gia = datPhong.gia;
                currentdatPhong.mieuTaDatPhong = datPhong.mieuTaDatPhong;

                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }
        public bool Delete(int maDatPhong)
        {
            try
            {
                datPhong currentdatPhong = GetSingleByID(maDatPhong);

                db_.datPhongs.Remove(currentdatPhong);
                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public string GetNameByIDThe(string nameMieuTaDatPhong)
        {
            string info = db_.datPhongs.Where(t => t.mieuTaDatPhong == nameMieuTaDatPhong).Select(t => t.mieuTaDatPhong).FirstOrDefault();

            return info;
        }

        public string GetNameByIDDatPhong(int idDatPhong)
        {
            string info = db_.datPhongs.Where(t => t.maDatPhong == idDatPhong).Select(t => t.mieuTaDatPhong).FirstOrDefault();

            return info;
        }

        public int GetIDByName(int id)
        {
            datPhong info = db_.datPhongs.Where(t => t.maDatPhong == id).FirstOrDefault();

            return id;
        }
    }
}
