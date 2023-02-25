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
using ZedGraph;


namespace BusinessLayer
{
    public class SekreterManager
    {

        public static bool SekreterGirisKontrol(Sekreter sek)
        {
            if (sek.SekreterUsername != null && sek.SekreterSifre != null)
            {
                return SekreterDAL.KontrolEt(sek);
            }
            else
            {
                return false;
            }
        }

        public static ComboBox BranslariGetirme(ComboBox cmbx)
        {
            return SekreterDAL.BranslariGetir(cmbx);
        }

        public static List<Sekreter> SekreterList()
        {
            return SekreterDAL.SekreterListele();
        }

        public static int SekreterEkleme(Sekreter sek)
        {
            if (sek.SekreterUsername != null && sek.SekreterSifre != null)
            {
                return SekreterDAL.SekreterEkle(sek);
            }
            else
            {
                return -2;
            }
        }

        public static int SekreterSilme(Sekreter sek)
        {
            if (sek.SekreterId != 0)
            {
                return SekreterDAL.SekreterSil(sek);
            }
            else
            {
                return -1;
            }
        }
        public static int SekreterGüncelleme(Sekreter gsekreter)
        {
            if (gsekreter.SekreterId != 0 && gsekreter.SekreterUsername != null && gsekreter.SekreterSifre != null)
            {
                return SekreterDAL.SekreterGuncelle(gsekreter);
            }
            else
            {
                return -1;
            }
        }


        public static ZedGraphControl GrafikGetirme(ZedGraphControl zedGraph)
        {
            return SekreterDAL.GetGraphDataBrans(zedGraph);
        }
    }
}
