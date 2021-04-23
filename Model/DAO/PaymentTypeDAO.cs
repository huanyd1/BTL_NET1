using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Model.DAO
{
    public class PaymentTypeDAO : BaseDAO
    {
        public List<kieuThanhToan> GetAll()
        {
            List<kieuThanhToan> kieuThanhToans = db_.kieuThanhToans.ToList();

            return kieuThanhToans;
        }

        public kieuThanhToan GetSingleByID(int maKieuThanhToan)
        {
            kieuThanhToan kieuThanhToan = db_.kieuThanhToans.Where(t => t.maKieuThanhToan == maKieuThanhToan).FirstOrDefault();

            return kieuThanhToan;
        }
        public bool Add(kieuThanhToan kieuThanhToan)
        {
            try
            {
                db_.kieuThanhToans.Add(kieuThanhToan);
                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }
        public bool Edit(kieuThanhToan kieuThanhToan)
        {
            try
            {
                kieuThanhToan currentkieuThanhToan = GetSingleByID(kieuThanhToan.maKieuThanhToan);

                //currentkieuThanhToan.maLoaiThe = kieuThanhToan.maLoaiThe;
                currentkieuThanhToan.tenKieuThanhToan = kieuThanhToan.tenKieuThanhToan;
                currentkieuThanhToan.mieuTaKieuThanhToan = kieuThanhToan.mieuTaKieuThanhToan;

                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }
        public bool Delete(int maKieuThanhToan)
        {
            try
            {
                kieuThanhToan currentkieuThanhToan = GetSingleByID(maKieuThanhToan);

                db_.kieuThanhToans.Remove(currentkieuThanhToan);
                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public string GetNameByIDLoaiThe(string nameKieuThanhToan)
        {
            string info = db_.kieuThanhToans.Where(t => t.tenKieuThanhToan == nameKieuThanhToan).Select(t => t.tenKieuThanhToan).FirstOrDefault();

            return info;
        }

        public int GetIDByNameLoaiThe(string nameKieuThanhToan)
        {
            int info = db_.kieuThanhToans.Where(t => t.tenKieuThanhToan == nameKieuThanhToan).Select(t => t.maKieuThanhToan).FirstOrDefault();

            return info;
        }


        public int GetIDByName(int id)
        {
            kieuThanhToan info = db_.kieuThanhToans.Where(t => t.maKieuThanhToan == id).FirstOrDefault();

            return id;
        }
    }
}
