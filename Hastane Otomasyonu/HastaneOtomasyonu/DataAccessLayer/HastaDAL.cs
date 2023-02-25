using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class HastaDAL
    {
        public static List<Hasta> HastaListele()
        {
            List<Hasta> veriler = new List<Hasta>();
            OleDbCommand cmdListele = new OleDbCommand("Select * from Hasta_tbl", DbBaglantisi.connection);
            if (cmdListele.Connection.State != System.Data.ConnectionState.Open)
            {
                cmdListele.Connection.Open();
            }

            OleDbDataReader dr = cmdListele.ExecuteReader();
            while (dr.Read())
            {
                Hasta enthasta = new Hasta();
                enthasta.HastaId = int.Parse(dr["HastaId"].ToString());
                enthasta.HastaAd = dr["HastaAd"].ToString();
                enthasta.HastaTCNo = dr["HastaTCNo"].ToString();
                enthasta.HastaSoyad = dr["HastaSoyad"].ToString();
                enthasta.HastaTel = dr["HastaTel"].ToString();
                veriler.Add(enthasta);
            }
            dr.Close();
            cmdListele.Connection.Close();
            return veriler;
        }
        public static int HastaSil(Hasta ghas)
        {
            OleDbCommand hassil = new OleDbCommand("Delete from Hasta_tbl where HastaId=@HastaId", DbBaglantisi.connection);
            if (hassil.Connection.State != ConnectionState.Open)
            {
                hassil.Connection.Open();
            }
            hassil.Parameters.AddWithValue("@HastaId", ghas.HastaId);
            return hassil.ExecuteNonQuery();
        }
        public static int HastaEkle(Hasta ghas)
        {
            OleDbCommand hasekle = new OleDbCommand("Insert into Hasta_tbl(HastaTCNo,HastaAd,HastaSoyad,HastaTel) " + "values(@HastaTCNo,@HastaAd,@HastaSoyad,@HastaTel)", DbBaglantisi.connection);
            if (hasekle.Connection.State != ConnectionState.Open)
            {
                hasekle.Connection.Open();
            }
            hasekle.Parameters.AddWithValue("@HastaTCNo", ghas.HastaTCNo);
            hasekle.Parameters.AddWithValue("@HastaAd", ghas.HastaAd);
            hasekle.Parameters.AddWithValue("@HastaSoyad", ghas.HastaSoyad);
            hasekle.Parameters.AddWithValue("@HastaTel", ghas.HastaTel);
            return hasekle.ExecuteNonQuery();
        }

        public static int HastaGuncelle(Hasta ghas)
        {
            OleDbCommand hasguncelle = new OleDbCommand("Update Hasta_tbl set HastaTCNo=@HastaTCNo,HastaAd=@HastaAd,HastaSoyad=@HastaSoyad,HastaTel=@HastaTel" + " where HastaId=@HastaId", DbBaglantisi.connection);
            if (hasguncelle.Connection.State != ConnectionState.Open)
            {
                hasguncelle.Connection.Open();
            }
            
            hasguncelle.Parameters.AddWithValue("@HastaTCNo", ghas.HastaTCNo);
            hasguncelle.Parameters.AddWithValue("@HastaAd", ghas.HastaAd);
            hasguncelle.Parameters.AddWithValue("@HastaSoyad", ghas.HastaSoyad);
            hasguncelle.Parameters.AddWithValue("@HastaTel", ghas.HastaTel);
            hasguncelle.Parameters.AddWithValue("@HastaId", ghas.HastaId);
            return hasguncelle.ExecuteNonQuery();
        }

        public static ComboBox HastalarıGetir(ComboBox cmbx)
        {
            ///*, Brans_tbl.BransAd as Brans_tbl FROM Doktor_tbl JOIN Brans_tbl ON Doktor_tbl.bransId = Brans_tbl.BransId*/

            string sql = "SELECT* from Hasta_tbl ";
            OleDbCommand getirkomut = new OleDbCommand(sql, DbBaglantisi.connection);
            if (getirkomut.Connection.State != ConnectionState.Open)
            {
                getirkomut.Connection.Open();
            }
            OleDbDataReader dataReader = getirkomut.ExecuteReader();
            List<Hasta> hastalar = new List<Hasta>();
            while (dataReader.Read())
            {
                cmbx.Items.Add(int.Parse(dataReader["HastaId"].ToString()));
                //cmbx.Items.Add(dataReader["DoktorAd"].ToString());
            }
            cmbx.DataSource = hastalar;
            cmbx.ValueMember = "HastaId";
            cmbx.DisplayMember = "HastaAd";

            dataReader.Close();
            getirkomut.Connection.Close();
            return cmbx;
        }
        public static Hasta HastaGetirId(int id)
        {
            DbBaglantisi.connection.Open();
            string sql = "Select * From Hasta_tbl where HastaId=@id";
            OleDbCommand cmdhasta = new OleDbCommand(sql, DbBaglantisi.connection);
            cmdhasta.Parameters.AddWithValue("@id", id);
            OleDbDataReader dbr = cmdhasta.ExecuteReader();
            if (dbr.Read())
            {
                Hasta hasta = new Hasta()
                {
                    HastaId = (int)dbr["HastaId"],
                    HastaTCNo = (string)dbr["HastaTCNo"],
                    HastaAd = (string)dbr["HastaAd"],
                    HastaSoyad = (string)dbr["HastaSoyad"],
                    HastaTel = (string)dbr["HastaTel"]
                    
                };
                cmdhasta.Connection.Close();
                dbr.Close();
                return hasta;

            }
            else
            {
                cmdhasta.Connection.Close();
                return null;
            }
        }


    }
}
