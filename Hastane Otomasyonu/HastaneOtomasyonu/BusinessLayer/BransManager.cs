using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class BransManager
    {
        public static List<Brans> BransList()
        {
            return BransDAL.BransListele();
        }

        public static int BransEkleme(Brans bra)
        {
            if (bra.BransAd != null)
            {
                return BransDAL.BransEkle(bra);
            }
            else
            {
                return -2;
            }
        }

        public static int BransSilme(Brans bra)
        {
            if (bra.BransId != 0)
            {
                return BransDAL.BransSil(bra);
            }
            else
            {
                return -1;
            }
        }
        public static ComboBox BranslariGetirme(ComboBox cmbx)
        {
            return BransDAL.BranslariGetir(cmbx);
        }

        public static List<Brans> BransAdList()
        {
            return BransDAL.BransAdListele();
        }





    }

}
