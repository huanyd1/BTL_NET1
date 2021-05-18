using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class CustomerDAO : BaseDAO
    {
        public List<khachHang> GetAll()
        {
            List<khachHang> khachHangs = db_.khachHangs.ToList();

            return khachHangs;
        }


        public khachHang GetSingleByID(int maKhachHang)
        {
            khachHang khachHang = db_.khachHangs.Where(t => t.maKhachHang == maKhachHang).FirstOrDefault();

            return khachHang;
        }
        public bool Add(khachHang khachHang)
        {
            try
            {
                db_.khachHangs.Add(khachHang);
                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }
        public bool Edit(khachHang khachHang)
        {
            try
            {
                khachHang currentkhachHang = GetSingleByID(khachHang.maKhachHang);

                //currentkhachHang.maLoaiThe = khachHang.maLoaiThe;
                currentkhachHang.tenKhachHang = khachHang.tenKhachHang;
                currentkhachHang.tenDangNhap = khachHang.tenDangNhap;
                currentkhachHang.matKhau = khachHang.matKhau;
                currentkhachHang.maSoThe = khachHang.maSoThe;
                currentkhachHang.diaChi = khachHang.diaChi;
                currentkhachHang.mieuTaKhachHang = khachHang.mieuTaKhachHang;

                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }
        public bool Delete(int maKhachHang)
        {
            try
            {
                khachHang currentkhachHang = GetSingleByID(maKhachHang);

                db_.khachHangs.Remove(currentkhachHang);
                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public string GetNameByIDLoaiThe(string nameKhachHang)
        {
            string info = db_.khachHangs.Where(t => t.tenKhachHang == nameKhachHang).Select(t => t.tenKhachHang).FirstOrDefault();

            return info;
        }

        public int GetIDByNameLoaiThe(string nameKhachHang)
        {
            int info = db_.khachHangs.Where(t => t.tenKhachHang == nameKhachHang).Select(t => t.maKhachHang).FirstOrDefault();

            return info;
        }


        public int GetIDByName(int id)
        {
            khachHang info = db_.khachHangs.Where(t => t.maKhachHang == id).FirstOrDefault();

            return id;
        }
    }
}
