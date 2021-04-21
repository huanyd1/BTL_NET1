using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Model.DAO
{
    public class CardTypeDAO : BaseDAO
    {
        public List<loaiTheKhachHang> GetAll()
        {
            List<loaiTheKhachHang> loaiTheKhachHangs = db_.loaiTheKhachHangs.ToList();

            return loaiTheKhachHangs;
        }

        public loaiTheKhachHang GetSingleByID(int maLoaiThe)
        {
            loaiTheKhachHang loaiTheKhachHang = db_.loaiTheKhachHangs.Where(t => t.maLoaiThe == maLoaiThe).FirstOrDefault();

            return loaiTheKhachHang;
        }
        public bool Add(loaiTheKhachHang loaiTheKhachHang)
        {
            try
            {
                db_.loaiTheKhachHangs.Add(loaiTheKhachHang);
                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }
        public bool Edit(loaiTheKhachHang loaiTheKhachHang)
        {
            try
            {
                loaiTheKhachHang currentLoaiTheKhachHang = GetSingleByID(loaiTheKhachHang.maLoaiThe);

                //currentLoaiTheKhachHang.maLoaiThe = loaiTheKhachHang.maLoaiThe;
                currentLoaiTheKhachHang.tenLoaiThe = loaiTheKhachHang.tenLoaiThe;
                currentLoaiTheKhachHang.mieuTaLoaiThe = loaiTheKhachHang.mieuTaLoaiThe;

                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }
        public bool Delete(int maLoaiThe)
        {
            try
            {
                loaiTheKhachHang currentLoaiTheKhachHang = GetSingleByID(maLoaiThe);

                db_.loaiTheKhachHangs.Remove(currentLoaiTheKhachHang);
                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public string GetNameByIDLoaiThe(string nameLoaiThe)
        {
            string info = db_.loaiTheKhachHangs.Where(t => t.tenLoaiThe == nameLoaiThe).Select(t => t.tenLoaiThe).FirstOrDefault();

            return info;
        }

        public int GetIDByNameLoaiThe(string nameLoaiThe)
        {
            int info = db_.loaiTheKhachHangs.Where(t => t.tenLoaiThe == nameLoaiThe).Select(t => t.maLoaiThe).FirstOrDefault();

            return info;
        }


        public int GetIDByName(int id)
        {
            loaiTheKhachHang info = db_.loaiTheKhachHangs.Where(t => t.maLoaiThe == id).FirstOrDefault();

            return id;
        }
    }
}
