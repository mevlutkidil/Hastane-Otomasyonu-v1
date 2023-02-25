using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class DoktorDAL
    {
        //Data Access Layerda kullanabilmek için static tanımlıyoruz.
        public static bool KontrolEt(Doktor gdok)
        {
            OleDbCommand kontrol = new OleDbCommand("Select * from Doktor_tbl where DoktorId=@DoktorId and DoktorUsername=@DoktorUsername and DoktorSifre=@DoktorSifre",
                                                    DbBaglantisi.connection);
            {
                //Veritabanına bağlı olup olmadığımızı kontrol ediyor eğer bağlı değilsek bağlantıyı gerçekleştiriyor.
                if (kontrol.Connection.State != ConnectionState.Open)
                {
                    kontrol.Connection.Open();
                }
                //Gelen bilgilerin kontrolünü sağlamak için veritabanındaki bilgilere entegre ediyoruz
                //Daha sonrasında bu entegre ettiğimiz bilgileri kontrol etmek için oledb ile bilgileri
                //okuyup businesslayera(DoktorManagera) bu bilgilerden çıkan değeri göndericez.
                kontrol.Parameters.AddWithValue("@DoktorId", gdok.DoktorId);
                kontrol.Parameters.AddWithValue("@DoktorUsername", gdok.DoktorUsername);
                kontrol.Parameters.AddWithValue("@DoktorSifre", gdok.DoktorSifre);

                //Veritabanından gelen bilgiyi okuyacak metodun tanımlanması (DBReader)
                OleDbDataReader dbr = kontrol.ExecuteReader();
                //Okuduğu bilginin varlığını öğrenmek için döngü yardımıyla kontrol sağlıyoruz

                bool dbrkontrol = false;
                int dbrsayac = 0;

                while (dbr.Read())
                {
                    //okunacak veri varsa sayac artar
                    dbrsayac++;
                }
                if (dbrsayac > 0)
                {
                    dbrkontrol = true;
                }
                dbr.Close();
                kontrol.Connection.Close();
                return dbrkontrol;

            }

        }


        public static List<Doktor> DoktorListele()
        {
            List<Doktor> veriler = new List<Doktor>();
            OleDbCommand cmdListele = new OleDbCommand("Select * from Doktor_tbl ", DbBaglantisi.connection);
            if (cmdListele.Connection.State != ConnectionState.Open)
            {
                cmdListele.Connection.Open();
            }
            OleDbDataReader dbr = cmdListele.ExecuteReader();
            while (dbr.Read())
            {
                Doktor entDoktor = new Doktor();
                entDoktor.DoktorId = int.Parse(dbr["DoktorId"].ToString());
                entDoktor.DoktorAd = dbr["DoktorAd"].ToString();
                entDoktor.DoktorSoyad = dbr["DoktorSoyad"].ToString();
                entDoktor.DoktorTel = dbr["DoktorTel"].ToString();
                entDoktor.BransId = int.Parse(dbr["BransId"].ToString());
                entDoktor.DoktorUsername = dbr["DoktorUsername"].ToString();
                entDoktor.DoktorSifre = dbr["DoktorSifre"].ToString();
                veriler.Add(entDoktor);
            }
            dbr.Close();
            cmdListele.Connection.Close();
            return veriler;

        }

        public static int DoktorSil(Doktor gdok)
        {
            OleDbCommand dokSil = new OleDbCommand("Delete from Doktor_tbl where DoktorId=@DoktorId",
                DbBaglantisi.connection);
            if (dokSil.Connection.State != ConnectionState.Open)
            {
                dokSil.Connection.Open();
            }
            dokSil.Parameters.AddWithValue("@DoktorId", gdok.DoktorId);
            return dokSil.ExecuteNonQuery();
        }

        public static int DoktorEkle(Doktor gdok)
        {

            OleDbCommand dokekle = new OleDbCommand("Insert into Doktor_tbl(DoktorAd,DoktorSoyad,DoktorTel,BransId,DoktorUsername,DoktorSifre) " +
                "values(@DoktorAd,@DoktorSoyad,@DoktorTel,@BransId,@DoktorUsername,@DoktorSifre)", DbBaglantisi.connection);
            if (dokekle.Connection.State != ConnectionState.Open)
            {
                dokekle.Connection.Open();
            }
            //Ana satır
            dokekle.Parameters.AddWithValue("@DoktorAd", gdok.DoktorAd);
            dokekle.Parameters.AddWithValue("@DoktorSoyad", gdok.DoktorSoyad);
            dokekle.Parameters.AddWithValue("@Doktortel", gdok.DoktorTel);
            dokekle.Parameters.AddWithValue("@BransId", gdok.BransId);
            dokekle.Parameters.AddWithValue("@DoktorUsername", gdok.DoktorUsername);
            dokekle.Parameters.AddWithValue("@DoktorSifre", gdok.DoktorSifre);
            return dokekle.ExecuteNonQuery();
            //Ana Satır
        }

        public static int DoktorGuncelle(Doktor gdok)
        {
            OleDbCommand dokekle = new OleDbCommand("Update Doktor_tbl set DoktorAd=@DoktorAd,DoktorSoyad=@DoktorSoyad,DoktorTel=@DoktorTel,BransId=@BransId,DoktorUsername=@DoktorUsername,DoktorSifre=@DoktorSifre" +
                " where DoktorId=@DoktorId", DbBaglantisi.connection);
            if (dokekle.Connection.State != ConnectionState.Open)
            {
                dokekle.Connection.Open();
            }

            dokekle.Parameters.AddWithValue("@DoktorAd", gdok.DoktorAd);
            dokekle.Parameters.AddWithValue("@DoktorSoyad", gdok.DoktorSoyad);
            dokekle.Parameters.AddWithValue("@DoktorTel", gdok.DoktorTel);
            dokekle.Parameters.AddWithValue("@BransId", gdok.BransId);
            dokekle.Parameters.AddWithValue("@DoktorUsername", gdok.DoktorUsername);
            dokekle.Parameters.AddWithValue("@DoktorSifre", gdok.DoktorSifre);
            dokekle.Parameters.AddWithValue("@DoktorId", gdok.DoktorId);
            return dokekle.ExecuteNonQuery();



        }

        public static ComboBox DoktorlariGetir(ComboBox cmbx)
        {
            ///*, Brans_tbl.BransAd as Brans_tbl FROM Doktor_tbl JOIN Brans_tbl ON Doktor_tbl.bransId = Brans_tbl.BransId*/

            string sql = "SELECT * from Doktor_tbl ";
            OleDbCommand getirkomut = new OleDbCommand(sql, DbBaglantisi.connection);
            if (getirkomut.Connection.State != ConnectionState.Open)
            {
                getirkomut.Connection.Open();
            }
            OleDbDataReader dataReader = getirkomut.ExecuteReader();
            List<Doktor> doktorlar = new List<Doktor>();
            while (dataReader.Read())
            {
                cmbx.Items.Add(int.Parse(dataReader["DoktorId"].ToString()));
                // cmbx.Items.Add(dataReader["DoktorAd"].ToString());
            }
            dataReader.Close();

            //cmbx.DataSource = doktorlar;
            cmbx.ValueMember = "DoktorId";
            cmbx.DisplayMember = "DoktorAd";


            getirkomut.Connection.Close();
            return cmbx;
        }

        public static Doktor DoktorGetirId(int id)
        {
            string sql = "Select * From Doktor_tbl where DoktorId=@id";
            OleDbCommand cmddoktor = new OleDbCommand(sql, DbBaglantisi.connection);
            if (cmddoktor.Connection.State != ConnectionState.Open)
            {
                cmddoktor.Connection.Open();
            }
            cmddoktor.Parameters.AddWithValue("@id", id);
            OleDbDataReader dbr = cmddoktor.ExecuteReader();
            if (dbr.Read())
            {
                Doktor doktor = new Doktor()
                {
                    DoktorId = (int)dbr["DoktorId"],
                    DoktorAd = (string)dbr["DoktorAd"],
                    DoktorSoyad = (string)dbr["DoktorSoyad"],
                    DoktorTel = (string)dbr["DoktorTel"],
                };
                dbr.Close();
                cmddoktor.Connection.Close();
                return doktor;

            }
            else
            {

                DbBaglantisi.connection.Close();
                return null;

            }

        }







    }
}


