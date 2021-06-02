using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class DoanhThuDAO : BaseDAO
    {
        public List<DOANHTHUNAM> GetAll()
        {
            List<DOANHTHUNAM> doanhThu = db_.DOANHTHUNAMs.ToList();

            return doanhThu;
        }

        public int GetSoTienByIDThang(int idThang)
        {
            int info = db_.DOANHTHUNAMs.Where(t => t.MaThang == idThang).Select(t => (int)t.SoTien).FirstOrDefault();

            return info;
        }
    }
}
