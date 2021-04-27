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
    }
}
