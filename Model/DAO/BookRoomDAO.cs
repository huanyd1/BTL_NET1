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
    }
}
