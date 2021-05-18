using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class HotelInformationDAO : BaseDAO
    {
        public List<hoaDon> GetAll()
        {
            List<hoaDon> hoaDons = db_.hoaDons.ToList();

            return hoaDons;
        }

        public hoaDon GetSingleByID(int maHoaDon)
        {
            hoaDon hoaDon = db_.hoaDons.Where(t => t.maHoaDon == maHoaDon).FirstOrDefault();

            return hoaDon;
        }

        public List<hoaDon> GetBillByIDPaymentType(int idPaymentType)
        {
            List<hoaDon> hoaDons = db_.hoaDons.Where(t => t.maKieuThanhToan == idPaymentType).ToList();

            return hoaDons;
        }

        public bool Add(hoaDon hoaDon)
        {
            try
            {
                db_.hoaDons.Add(hoaDon);
                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }
        public bool Edit(hoaDon hoaDon)
        {
            try
            {
                hoaDon currenthoaDon = GetSingleByID(hoaDon.maHoaDon);

                //currenthoaDon.maLoaiThe = hoaDon.maLoaiThe;
                currenthoaDon.maDatPhong = hoaDon.maDatPhong;
                currenthoaDon.ngayThanhToan = hoaDon.ngayThanhToan;
                currenthoaDon.soTien = hoaDon.soTien;
                currenthoaDon.maKieuThanhToan = hoaDon.maKieuThanhToan;
                currenthoaDon.ghiChu = hoaDon.ghiChu;

                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }
        public bool Delete(int maHoaDon)
        {
            try
            {
                hoaDon currenthoaDon = GetSingleByID(maHoaDon);

                db_.hoaDons.Remove(currenthoaDon);
                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public string GetNameByIDHoaDon(decimal soTien)
        {
            string info = db_.hoaDons.Where(t => t.soTien == soTien).Select(t => t.soTien.ToString()).FirstOrDefault();

            return info;
        }

        public string GetNameByIDLoaiThe(int idHoaDon)
        {
            string info = db_.hoaDons.Where(t => t.maHoaDon == idHoaDon).Select(t => t.soTien.ToString()).FirstOrDefault();

            return info;
        }

        public int GetIDByName(int id)
        {
            hoaDon info = db_.hoaDons.Where(t => t.maHoaDon == id).FirstOrDefault();

            return id;
        }
    }
}
