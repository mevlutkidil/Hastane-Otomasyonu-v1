using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RandevuManager
    {
        public static List<Randevu> RandevuList()
        {
            return RandevuDAL.RandevuListele();
        }
        public static int RandevuEkleme(Randevu ran)
        {
            if (
                 ran.HastaId != 0 &&
                ran.BransId != 0 && ran.DoktorId != 0 && ran.MuayeneTime != null)

            {
                return RandevuDAL.RandevuEkle(ran);
            }
            else
            {
                return -2;
            }
        }

        public static int RandevurGuncelleme(Randevu ran)
        {
            if (ran.RandevuId != 0 && ran.MuayeneNot != null)
            {
                return RandevuDAL.RandevuGuncelle(ran);
            }
            else
            {
                return -1;
            }
        }





    }
}
