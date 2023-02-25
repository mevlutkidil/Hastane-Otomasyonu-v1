using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using ZedGraph;
using System.Reflection;

namespace DataAccessLayer
{
    public class SekreterDAL
    {
        //Business Layerda kullanabilmek için static tanımlıyoruz.
        public static bool KontrolEt(Sekreter gsek)
        {
            OleDbCommand kontrol = new OleDbCommand("Select * from Sekreter_tbl where SekreterUsername=@SekreterUsername and SekreterSifre=@SekreterSifre", DbBaglantisi.connection);
            {
                if (kontrol.Connection.State != ConnectionState.Open)
                {
                    kontrol.Connection.Open();
                }
                //Gelen bilgilerin kontrolünü sağlamak için veritabanındaki bilgilere entegre ediyoruz
                //Daha sonrasında bu entegre ettiğimiz bilgileri kontrol etmek için oledb ile bilgileri
                //okuyup businesslayera(DoktorManagera) bu bilgilerden çıkan değeri göndericez.
                kontrol.Parameters.AddWithValue("@SekreterUsername", gsek.SekreterUsername);
                kontrol.Parameters.AddWithValue("@SekreterSifre", gsek.SekreterSifre);

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

        public static ComboBox BranslariGetir(ComboBox cmbx)
        {
            ///*, Brans_tbl.BransAd as Brans_tbl FROM Doktor_tbl JOIN Brans_tbl ON Doktor_tbl.bransId = Brans_tbl.BransId*/

            string sql = "SELECT* from Brans_tbl ";
            OleDbCommand getirkomut = new OleDbCommand(sql, DbBaglantisi.connection);
            if (getirkomut.Connection.State != ConnectionState.Open)
            {
                getirkomut.Connection.Open();
            }
            OleDbDataReader dataReader = getirkomut.ExecuteReader();
            List<Brans> branslar = new List<Brans>();
            while (dataReader.Read())
            {
                cmbx.Items.Add(int.Parse(dataReader["BransId"].ToString()));
                // cmbx.Items.Add(dataReader["BransAd"].ToString());

            }
            dataReader.Close();
            //cmbx.DataSource=branslar;
            cmbx.ValueMember = "BransId";
            cmbx.DisplayMember = "BransAd";
            getirkomut.Connection.Close();
            return cmbx;
        }

        public static List<Sekreter> SekreterListele()
        {
            List<Sekreter> veriler = new List<Sekreter>();
            OleDbCommand cmdListele = new OleDbCommand("Select * from Sekreter_tbl", DbBaglantisi.connection);
            if (cmdListele.Connection.State != ConnectionState.Open)
            {
                cmdListele.Connection.Open();
            }
            OleDbDataReader dbr = cmdListele.ExecuteReader();
            while (dbr.Read())
            {
                Sekreter entSekreter = new Sekreter();
                entSekreter.SekreterId = int.Parse(dbr["SekreterId"].ToString());
                entSekreter.SekreterUsername = dbr["SekreterUsername"].ToString();
                entSekreter.SekreterSifre = dbr["SekreterSifre"].ToString();
                veriler.Add(entSekreter);
            }
            dbr.Close();
            cmdListele.Connection.Close();
            return veriler;

        }

        public static int SekreterEkle(Sekreter gsekreter)
        {
            OleDbCommand sekreterekle = new OleDbCommand("Insert into Sekreter_tbl(SekreterUsername,SekreterSifre) " + "values(@SekreterUsername,@SekreterSifre)", DbBaglantisi.connection);
            if (sekreterekle.Connection.State != ConnectionState.Open)
            {
                sekreterekle.Connection.Open();
            }
            sekreterekle.Parameters.AddWithValue("@SekreterUsername", gsekreter.SekreterUsername);
            sekreterekle.Parameters.AddWithValue("@SekreterSifre", gsekreter.SekreterSifre);
            return sekreterekle.ExecuteNonQuery();

        }

        public static int SekreterSil(Sekreter gsekreter)
        {
            OleDbCommand sekreterSil = new OleDbCommand("Delete from Sekreter_tbl where SekreterId=@SekreterId", DbBaglantisi.connection);
            if (sekreterSil.Connection.State != ConnectionState.Open)
            {
                sekreterSil.Connection.Open();
            }
            sekreterSil.Parameters.AddWithValue("@SekreterId", gsekreter.SekreterId);
            return sekreterSil.ExecuteNonQuery();


        }

        public static int SekreterGuncelle(Sekreter gsekreter)
        {
            OleDbCommand sekreterkle = new OleDbCommand("Update Sekreter_tbl set SekreterUsername=@SekreterUsername,SekreterSifre=@SekreterSifre  where SekreterId=@SekreterId", DbBaglantisi.connection);
            if (sekreterkle.Connection.State != ConnectionState.Open)
            {
                sekreterkle.Connection.Open();
            }

            sekreterkle.Parameters.AddWithValue("@SekreterUsername", gsekreter.SekreterUsername);
            sekreterkle.Parameters.AddWithValue("@SekreterSifre", gsekreter.SekreterSifre);
            sekreterkle.Parameters.AddWithValue("@SekreterId", gsekreter.SekreterId);
            return sekreterkle.ExecuteNonQuery();



        }
        public static ZedGraphControl GetGraphDataBrans(ZedGraphControl zedGraphControl1)
        {
            DbBaglantisi.connection.Open();

            //"SELECT Brans_tbl.BransAd, COUNT(Randevu_tbl.HastaId) as hasta_sayisi FROM Brans_tbl " +
            //                "JOIN Randevu_tbl ON Randevu_tbl.BransId = Brans_tbl.BransId " +
            //                "JOIN Hasta_tbl ON Hasta_tbl.HastaId = Randevu_tbl.HastaId " +
            //                "GROUP BY Brans_tbl.BransAd"
            //string query = "SELECT Brans_tbl.BransAd, COUNT(Randevu_tbl.HastaId) AS hasta_sayisi FROM (Brans_tbl " +
            //    "  JOIN Randevu_tbl ON Randevu_tbl.BransId = Brans_tbl.BransId " +
            //    "  JOIN Hasta_tbl ON Hasta_tbl.HastaId = Randevu_tbl.HastaId) " +
            //    "  WHERE (Randevu_tbl.BransId = Brans_tbl.BransId) " +
            //    "GROUP BY Brans_tbl.BransAd";
            //string query = "SELECT Brans_tbl.BransAd, COUNT(Randevu_tbl.HastaId) AS hasta_sayisi " +
            //    "FROM Brans_tbl " +
            //    "INNER JOIN Randevu_tbl ON Randevu_tbl.BransId = Brans_tbl.BransId" +
            //    "GROUP BY Brans_tbl.BransAd ";
            string query = "SELECT Brans_tbl.BransAd, COUNT(Randevu_tbl.HastaId) AS hasta_sayisi FROM (Brans_tbl INNER JOIN Randevu_tbl ON Randevu_tbl.BransId = Brans_tbl.BransId) GROUP BY Brans_tbl.BransAd";



            using (OleDbCommand cmd = new OleDbCommand(query, DbBaglantisi.connection))
            {
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    int i = 0;
                    Random r = new Random();
                    while (reader.Read())
                    {
                        string BransAd = reader["BransAd"].ToString();
                        double hastaSayisi = Convert.ToDouble(reader["hasta_sayisi"]);

                        // ZedGraph componenti kullanarak grafiği oluşturun
                        Double[] ghastaSayisi = new Double[reader.FieldCount + 10];
                        ghastaSayisi[i] = hastaSayisi;
                        i++;
                        zedGraphControl1.GraphPane.AddBar(BransAd, null, ghastaSayisi, Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256)));
                        //zedGraphControl1.GraphPane.AddBar(BransAd,null,);
                    }
                }
            }

            DbBaglantisi.connection.Close();
            return zedGraphControl1;

        }

        public static ZedGraphControl GetGraphDataRandevu(ZedGraphControl zedGraphControl1)
        {
            DbBaglantisi.connection.Open();

            string query = "SELECT Randevu_tbl.RandevuId, COUNT(Randevu_tbl.HastaId) as hasta_sayisi FROM Brans_tbl " +
                            "JOIN Randevu_tbl ON Randevu_tbl.BransId = Brans_tbl.BransId " +
                            "JOIN Hasta_tbl ON Hasta_tbl.HastaId = Randevu_tbl.HastaId " +
                            "GROUP BY Brans_tbl.BransAd";

            using (OleDbCommand cmd = new OleDbCommand(query, DbBaglantisi.connection))
            {
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        string BransAd = reader["BransAd"].ToString();
                        double hastaSayisi = Convert.ToDouble(reader["hasta_sayisi"]);

                        // ZedGraph componenti kullanarak grafiği oluşturun
                        Double[] ghastaSayisi = new Double[reader.FieldCount];
                        ghastaSayisi[i] = hastaSayisi;
                        i++;
                        zedGraphControl1.GraphPane.AddBar(BransAd, null, ghastaSayisi, Color.Blue);
                        //zedGraphControl1.GraphPane.AddBar(BransAd,null,);
                    }
                }
            }

            DbBaglantisi.connection.Close();
            return zedGraphControl1;

        }


    }
}














