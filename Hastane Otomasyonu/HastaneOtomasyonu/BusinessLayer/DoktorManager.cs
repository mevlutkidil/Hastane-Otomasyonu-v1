using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class DoktorManager
    {
        //Dışarıdan gelen username ve şifreyi kontrol edecek business metodu
        public static bool DoktorGirisKontrol(Doktor dok)
        {
            if (dok.DoktorId != 0 && dok.DoktorUsername != null && dok.DoktorSifre != null)
            {
                return DoktorDAL.KontrolEt(dok);
            }
            else
            {
                return false;
            }
        }

        public static List<Doktor> DoktorList()
        {
            return DoktorDAL.DoktorListele();
        }

        public static int DoktorEkleme(Doktor dok)
        {
           
                if (dok.DoktorAd != null && dok.DoktorSoyad != null && dok.DoktorTel != null &&
                dok.BransId != 0 && dok.DoktorUsername != null && dok.DoktorSifre != null)
                {
                    return DoktorDAL.DoktorEkle(dok);
                }
                else
                {
                    return -2;
                }
         
            
        }

        public static int DoktorSilme(Doktor dok)
        {
            if (dok.DoktorId != 0)
            {
                return DoktorDAL.DoktorSil(dok);
            }
            else
            {
                return -1;
            }
        }

        public static int DoktorGüncelleme(Doktor dok)
        {
            if (dok.DoktorId != 0 && dok.DoktorAd != null && dok.DoktorSoyad != null && dok.DoktorTel != null &&
                dok.BransId != 0 && dok.DoktorUsername != null && dok.DoktorSifre != null)
            {
                return DoktorDAL.DoktorGuncelle(dok);
            }
            else
            {
                return-1;
            }
        }

        public static ComboBox DoktorlariGetirme(ComboBox cmbx)
        {
            return DoktorDAL.DoktorlariGetir(cmbx);
        }

        public  Doktor GetByIdDoktor(int id)
        {
            return DoktorDAL.DoktorGetirId(id);
        }


    }
}
