using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entitylayer;

namespace DATAACCESSLAYER
{
    public class dataaccesdoktor
    {
        public static List<entitydoktor> DALDocList()
        {
            List<entitydoktor> degerler = new List<entitydoktor>();
            OleDbCommand komut1 = new OleDbCommand("SELECT * FROM DoktorTablosu", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            OleDbDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                entitydoktor ent = new entitydoktor();
                ent.Doktorıd = Convert.ToInt32(dr["Doktorıd"]);
                ent.Doctorad = dr["Doctorad"].ToString();
                ent.Doktorsoyad = dr["Doktorsoyad"].ToString();
                ent.Doktoralan = dr["Doktoralan"].ToString();
                ent.Doktortel = dr["Doktortel"].ToString();
                ent.Doktorkullanıcıadı = dr["Doktorkullanıcıadı"].ToString();
                ent.Doctorşifre = dr["Doctorşifre"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static OleDbCommand BolumHastaSayisiCek(string brans)
        {
            OleDbCommand komut2 = new OleDbCommand("SELECT Count(Hastaıd) FROM Hastatablosu WHERE Hastarandevu=@P1", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@P1", brans);
            return komut2;
        }

        public static OleDbCommand DoktorAdıCek(entitydoktor p)
        {
            OleDbCommand komut2 = new OleDbCommand("SELECT Doctorad FROM Doktortablosu WHERE Doktorkullanıcıadı=@P1 AND Doctorşifre=@P2", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@P1", p.Doktorkullanıcıadı);
            komut2.Parameters.AddWithValue("@P2", p.Doctorşifre);
           return komut2;
        }

        public static OleDbCommand DoktorSoyadıCek(entitydoktor p)
        {
            OleDbCommand komut2 = new OleDbCommand("SELECT Doktorsoyad FROM Doktortablosu WHERE Doktorkullanıcıadı=@P1 AND Doctorşifre=@P2", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@P1", p.Doktorkullanıcıadı);
            komut2.Parameters.AddWithValue("@P2", p.Doctorşifre);
            return komut2;
        }

        public static int DocEkle(entitydoktor p)
        {
            OleDbCommand komut2 = new OleDbCommand("INSERT INTO Doktortablosu (Doctorad, Doktorsoyad, Doktoralan, Doktortel, Doktorkullanıcıadı, Doctorşifre) VALUES (@P1, @P2, @P3, @P4, @P5, @P6)", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@P1", p.Doctorad);
            komut2.Parameters.AddWithValue("@P2", p.Doktorsoyad);
            komut2.Parameters.AddWithValue("@P3", p.Doktoralan);
            komut2.Parameters.AddWithValue("@P4", p.Doktortel);
            komut2.Parameters.AddWithValue("@P5", p.Doktorkullanıcıadı);
            komut2.Parameters.AddWithValue("@P6", p.Doctorşifre);

            try
            {
                return komut2.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                
                Console.WriteLine("Hata: " + ex.Message);
                return -1;
            }
        }


        public static bool DocSil(int p)
        {
            OleDbCommand komut3 = new OleDbCommand("DELETE FROM Doktortablosu WHERE Doktorıd = @P1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1", p);
            return komut3.ExecuteNonQuery() > 0;
        }

        public static bool DocGuncelle(entitydoktor ent)
        {
            OleDbCommand komut4 = new OleDbCommand("UPDATE Doktortablosu SET Doctorad=@P1, Doktorsoyad=@P2, Doktoralan=@P3, Doktortel=@P4, Doktorkullanıcıadı=@P5, Doctorşifre=@P6 WHERE Doktorıd=@P7", Baglanti.bgl);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1", ent.Doctorad ?? (object)DBNull.Value);
            komut4.Parameters.AddWithValue("@P2", ent.Doktorsoyad ?? (object)DBNull.Value);
            komut4.Parameters.AddWithValue("@P3", ent.Doktoralan ?? (object)DBNull.Value);
            komut4.Parameters.AddWithValue("@P4", ent.Doktortel ?? (object)DBNull.Value);
            komut4.Parameters.AddWithValue("@P5", ent.Doktorkullanıcıadı ?? (object)DBNull.Value);
            komut4.Parameters.AddWithValue("@P6", ent.Doctorşifre ?? (object)DBNull.Value);
            komut4.Parameters.AddWithValue("@P7", ent.Doktorıd);

            try
            {
                return komut4.ExecuteNonQuery() > 0;
            }
            catch (OleDbException ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
                return false;
            }
        }



        public static int DoktorGiris(entitydoktor p)
        {
            Baglanti.bgl.Close();
            Baglanti.bgl.Open();
            OleDbCommand komut3 = new OleDbCommand("SELECT * FROM Doktortablosu WHERE Doktorkullanıcıadı=@P1 AND Doctorşifre=@P2", Baglanti.bgl);
            komut3.Parameters.AddWithValue("@P1", p.Doktorkullanıcıadı);
            komut3.Parameters.AddWithValue("@P2", p.Doctorşifre);
            OleDbDataReader dr = komut3.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                return 1; 
            }
            else
            {
                dr.Close();
                return 2; 
            }
        }
    }
}