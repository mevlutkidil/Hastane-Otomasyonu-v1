using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DataAccessLayer
{
    public class BransDAL
    {
        public static List<Brans> BransListele()
        {
            List<Brans> veriler = new List<Brans>();
            OleDbCommand cmdListele = new OleDbCommand("Select * from Brans_tbl", DbBaglantisi.connection);
            if (cmdListele.Connection.State != ConnectionState.Open)
            {
                cmdListele.Connection.Open();
            }
            OleDbDataReader dbr = cmdListele.ExecuteReader();
            while (dbr.Read())
            {
                Brans entBrans = new Brans();
                entBrans.BransId = int.Parse(dbr["BransId"].ToString());
                entBrans.BransAd = dbr["BransAd"].ToString();
                veriler.Add(entBrans);
            }
            dbr.Close();
            cmdListele.Connection.Close();
            return veriler;

        }

        public static int BransEkle(Brans gbrans)
        {
            OleDbCommand bransekle = new OleDbCommand("Insert into Brans_tbl(BransAd) " +
                "values(@BransAd)", DbBaglantisi.connection);
            if (bransekle.Connection.State != ConnectionState.Open)
            {
                bransekle.Connection.Open();
            }
            bransekle.Parameters.AddWithValue("@BransAd", gbrans.BransAd);
            return bransekle.ExecuteNonQuery();
        }

        public static int BransSil(Brans gbrans)
        {
            OleDbCommand bransSil = new OleDbCommand("Delete from Brans_tbl where BransId=@BransId",
                DbBaglantisi.connection);
            if (bransSil.Connection.State != ConnectionState.Open)
            {
                bransSil.Connection.Open();
            }
            bransSil.Parameters.AddWithValue("@BransId", gbrans.BransId);
            return bransSil.ExecuteNonQuery();


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
                // cmbx.Items.Add(dataReader["DoktorAd"].ToString());
            }
            dataReader.Close();
            // cmbx.DataSource = doktorlar;
            //cmbx.ValueMember = "DoktorId";
            //cmbx.DisplayMember = "DoktorAd";


            getirkomut.Connection.Close();
            return cmbx;
        }


        public static List<Brans> BransAdListele()
        {
            List<Brans> veriler = new List<Brans>();
            OleDbCommand cmdListele = new OleDbCommand("Select * from Brans_tbl", DbBaglantisi.connection);
            if (cmdListele.Connection.State != ConnectionState.Open)
            {
                cmdListele.Connection.Open();
            }
            OleDbDataReader dbr = cmdListele.ExecuteReader();
            while (dbr.Read())
            {
                Brans entBrans = new Brans();
                entBrans.BransId = int.Parse(dbr["BransId"].ToString());
                entBrans.BransAd = dbr["BransAd"].ToString();
                veriler.Add(entBrans);
            }
            dbr.Close();
            cmdListele.Connection.Close();
            return veriler;

        }

    }
}
