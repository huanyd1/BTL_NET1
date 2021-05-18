using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class HotelInfomationDAO : BaseDAO
    {
        public thongTinKhachSan GetSingleByID(int maKhachSan)
        {
            thongTinKhachSan thongTinKhachSan = db_.thongTinKhachSans.Where(t => t.maKhachSan == maKhachSan).FirstOrDefault();

            return thongTinKhachSan;
        }
    }
}
