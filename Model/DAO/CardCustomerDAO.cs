using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using Model.DAO;

namespace Model.DAO
{
    public class CardCustomerDAO : BaseDAO
    {
        public List<theKhachHang> GetAll()
        {
            List<theKhachHang> theKhachHangs = db_.theKhachHangs.ToList();

            return theKhachHangs;
        }

        public theKhachHang GetSingleByID(int maSoThe)
        {
            theKhachHang theKhachHang = db_.theKhachHangs.Where(t => t.maSoThe == maSoThe).FirstOrDefault();

            return theKhachHang;
        }

        public List<theKhachHang> GetCardCustomerByIDCardType(int idCardType)
        {
            List<theKhachHang> theKhachHangs = db_.theKhachHangs.Where(t => t.maLoaiThe == idCardType).ToList();

            return theKhachHangs;
        }

        public bool Add(theKhachHang theKhachHang)
        {
            try
            {
                db_.theKhachHangs.Add(theKhachHang);
                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }
        public bool Edit(theKhachHang theKhachHang)
        {
            try
            {
                theKhachHang currenttheKhachHang = GetSingleByID(theKhachHang.maSoThe);

                //currenttheKhachHang.maLoaiThe = theKhachHang.maLoaiThe;
                currenttheKhachHang.tenThe = theKhachHang.tenThe;
                currenttheKhachHang.maLoaiThe = theKhachHang.maLoaiThe;

                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }
        public bool Delete(int maSoThe)
        {
            try
            {
                theKhachHang currenttheKhachHang = GetSingleByID(maSoThe);

                db_.theKhachHangs.Remove(currenttheKhachHang);
                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public string GetNameByIDThe(string nameThe)
        {
            string info = db_.theKhachHangs.Where(t => t.tenThe == nameThe).Select(t => t.tenThe).FirstOrDefault();

            return info;
        }

        public string GetNameByIDLoaiThe(int idLoaiThe)
        {
            string info = db_.theKhachHangs.Where(t => t.maLoaiThe == idLoaiThe).Select(t => t.tenThe).FirstOrDefault();

            return info;
        }

        public int GetIDByName(int id)
        {
            theKhachHang info = db_.theKhachHangs.Where(t => t.maSoThe == id).FirstOrDefault();

            return id;
        }
    }
}
