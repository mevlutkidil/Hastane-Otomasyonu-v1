using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class HastaManager
    {
        public static List<Hasta> HastaList()
        {
            return HastaDAL.HastaListele();
        }

        public static int HastaEkleme(Hasta has)
        {
            if (has.HastaTCNo != null && has.HastaAd != null && has.HastaSoyad != null && has.HastaTel != null)

            {
                return HastaDAL.HastaEkle(has);
            }
            else
            {
                return -2;
            }


        }

        public static int HastaSilme(Hasta has)
        {
            if (has.HastaId != 0)
            {
                return HastaDAL.HastaSil(has);
            }
            else
            {
                return -1;
            }
        }

        public static int HastaGüncelleme(Hasta has)
        {
            if (has.HastaId != 0 && has.HastaTCNo != null && has.HastaAd != null && has.HastaSoyad != null && has.HastaTel != null)
            {
                return HastaDAL.HastaGuncelle(has);
            }
            else
            {
                return -1;
            }
        }
        public static ComboBox HastaGetirme(ComboBox cmbx)
        {
            return HastaDAL.HastalarıGetir(cmbx);
        }
        public  Hasta GetByIdHasta(int id)
        {
            return HastaDAL.HastaGetirId(id);
        }




    }
}
