using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class ThongTinKhachSanDAO : BaseDAO
    {
        public List<thongTinKhachSan> GetAll()
        {
            List<thongTinKhachSan> thongTinKhachSans = db_.thongTinKhachSans.ToList();

            return thongTinKhachSans;
        }

        public thongTinKhachSan GetSingleByID(int maKhachSan)
        {
            thongTinKhachSan thongTinKhachSan = db_.thongTinKhachSans.Where(t => t.maKhachSan == maKhachSan).FirstOrDefault();

            return thongTinKhachSan;
        }
        public bool Add(thongTinKhachSan thongTinKhachSan)
        {
            try
            {
                db_.thongTinKhachSans.Add(thongTinKhachSan);
                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }
        public bool Edit(thongTinKhachSan thongTinKhachSan)
        {
            try
            {
                thongTinKhachSan currentThongTinKhachSan = GetSingleByID(thongTinKhachSan.maKhachSan);

                //currentThongTinKhachSan.maKhachSan = thongTinKhachSan.maKhachSan;
                currentThongTinKhachSan.tenKhachSan = thongTinKhachSan.tenKhachSan;
                currentThongTinKhachSan.soSao = thongTinKhachSan.soSao;
                currentThongTinKhachSan.diaChi = thongTinKhachSan.diaChi;
                currentThongTinKhachSan.mieuTaKhachSan = thongTinKhachSan.mieuTaKhachSan;
                currentThongTinKhachSan.soPhong = thongTinKhachSan.soPhong;

                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }
        public bool Delete(int maKhachSan)
        {
            try
            {
                thongTinKhachSan currentThongTinKhachSan = GetSingleByID(maKhachSan);

                db_.thongTinKhachSans.Remove(currentThongTinKhachSan);
                db_.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public string GetNameByIDKhachSan(string nameKhachSan)
        {
            string info = db_.Admins.Where(t => t.username == nameKhachSan).Select(t => t.username).FirstOrDefault();

            return info;
        }

        //public thongTinKhachSan GetSingleByID(int maKhachSan)
        //{
        //    thongTinKhachSan thongTinKhachSan = db_.thongTinKhachSans.Where(t => t.maKhachSan == maKhachSan).FirstOrDefault();

        //    return thongTinKhachSan;
        //}
    }
}
