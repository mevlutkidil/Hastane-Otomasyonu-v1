using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RandevuDAL
    {
        public static List<Randevu> RandevuListele()
        {
            List<Randevu> veriler = new List<Randevu>();
            OleDbCommand cmdListele = new OleDbCommand("Select * from Randevu_tbl", DbBaglantisi.connection);
            if (cmdListele.Connection.State != System.Data.ConnectionState.Open)
            {
                cmdListele.Connection.Open();
            }
            OleDbDataReader dbr = cmdListele.ExecuteReader();
            while (dbr.Read())
            {
                Randevu entRandevu = new Randevu();
                entRandevu.HastaId = int.Parse(dbr["HastaId"].ToString());
                entRandevu.DoktorId = int.Parse(dbr["DoktorId"].ToString());
                entRandevu.MuayeneTime = DateTime.Parse(dbr["MuayeneTime"].ToString());
                entRandevu.MuayeneNot = dbr["MuayeneNot"].ToString();
                entRandevu.RandevuId = int.Parse(dbr["RandevuId"].ToString());
                entRandevu.BransId = int.Parse(dbr["BransId"].ToString());
                veriler.Add(entRandevu);
            }
            cmdListele.Connection.Close();
            dbr.Close();
            return veriler;

        }



        public static int RandevuEkle(Randevu gran)
        {
            OleDbCommand ranekle = new OleDbCommand("Insert into Randevu_tbl(HastaId,BransId,DoktorId,MuayeneTime) " +
                "values(@HastaId,@BransId,@DoktorId,@MuayeneTime)", DbBaglantisi.connection);
            if (ranekle.Connection.State != ConnectionState.Open)
            {
                ranekle.Connection.Open();
            }
            ranekle.Parameters.AddWithValue("@HastaId", gran.HastaId);
            
            ranekle.Parameters.AddWithValue("@BransId", gran.BransId);
            ranekle.Parameters.AddWithValue("@DoktorId", gran.DoktorId);
            ranekle.Parameters.AddWithValue("@MuayeneTime", gran.MuayeneTime);
            //ranekle.Parameters.AddWithValue("@MuayeneNot", gran.MuayeneNot);
            return ranekle.ExecuteNonQuery();
           
        }

        public static List<Randevu> RandevuDoktorListele()
        {
            List<Randevu> veriler = new List<Randevu>();
            OleDbCommand cmdListele = new OleDbCommand("Select * from Randevu_tbl Inner Join Doktor_tbl on Randevu_tbl.DoktorId=Doktor_tbl.DoktorId ", DbBaglantisi.connection);
            if (cmdListele.Connection.State != ConnectionState.Open)
            {
                cmdListele.Connection.Open();
            }
            OleDbDataReader dbr = cmdListele.ExecuteReader();
            while (dbr.Read())
            {

                Randevu entRandevu = new Randevu();

                entRandevu.MuayeneNot = dbr["MuayeneNot"].ToString();
                entRandevu.HastaId = int.Parse(dbr["HastaId"].ToString());
                entRandevu.DoktorId = int.Parse(dbr["DoktorId"].ToString());
                entRandevu.MuayeneTime = DateTime.Parse(dbr["MuayeneTime"].ToString());
                entRandevu.RandevuId = int.Parse(dbr["RandevuId"].ToString());
                entRandevu.BransId = int.Parse(dbr["BransId"].ToString());
                veriler.Add(entRandevu);

            }
            dbr.Close();
            cmdListele.Connection.Close();
            return veriler;

        }


        public static int RandevuGuncelle(Randevu grana)
        {
            OleDbCommand rangun = new OleDbCommand("Update Randevu_tbl set MuayeneNot=@MuayeneNot" +
                " where RandevuId=@RandevuId", DbBaglantisi.connection);
            if (rangun.Connection.State != ConnectionState.Open)
            {
                rangun.Connection.Open();
            }
            rangun.Parameters.AddWithValue("@MuayeneNot", grana.MuayeneNot);
            rangun.Parameters.AddWithValue("@RandevuId", grana.RandevuId);

            return rangun.ExecuteNonQuery();



        }









    }
}
