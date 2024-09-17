using entitylayer;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATAACCESSLAYER;
using entitylayer;

namespace DATAACCESSLAYER
{
    public class dataaccesshasta
    {
        public static List<entityhasta> DALHstList()
        {
            List<entityhasta> degerler = new List<entityhasta>();
            OleDbCommand komut1 = new OleDbCommand("SELECT * FROM Hastatablosu", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            OleDbDataReader hst = komut1.ExecuteReader();
            while (hst.Read())
            {
                entityhasta ent = new entityhasta();
                ent.Hastaıd = Convert.ToInt32(hst["Hastaıd"]);
                ent.Hastaad = hst["Hastaad"].ToString();
                ent.Hastasoyad = hst["Hastasoyad"].ToString();
                ent.Hastatc = hst["Hastatc"].ToString();
                ent.Hastatel = hst["Hastatel"].ToString();
                ent.Hastarandevu = hst["Hastarandevu"].ToString();
                ent.Doktoradı = hst["Doktoradı"].ToString();
                ent.Tarih = Convert.ToDateTime(hst["Tarih"]);
                ent.Saat = hst["Saat"].ToString();
                ent.Rapor = hst["Rapor"].ToString();
                degerler.Add(ent);
            }
            hst.Close();
            return degerler;
        }

        public static int HstEkle(entityhasta p)
        {
            using (OleDbCommand komut2 = new OleDbCommand("INSERT INTO Hastatablosu(Hastaad, Hastasoyad, Hastatc, Hastatel, Hastarandevu, Doktoradı, Tarih, Saat, Rapor) VALUES (@P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8, @P9)", Baglanti.bgl))
            {
                if (komut2.Connection.State != ConnectionState.Open)
                {
                    komut2.Connection.Open();
                }

                komut2.Parameters.Add("@P1", OleDbType.VarChar).Value = p.Hastaad;
                komut2.Parameters.Add("@P2", OleDbType.VarChar).Value = p.Hastasoyad;
                komut2.Parameters.Add("@P3", OleDbType.VarChar).Value = p.Hastatc;
                komut2.Parameters.Add("@P4", OleDbType.VarChar).Value = p.Hastatel;
                komut2.Parameters.Add("@P5", OleDbType.VarChar).Value = p.Hastarandevu;
                komut2.Parameters.Add("@P6", OleDbType.VarChar).Value = p.Doktoradı;

                
                if (p.Tarih is DateTime tarihValue)
                {
                    komut2.Parameters.Add("@P7", OleDbType.Date).Value = tarihValue;
                }
                else
                {
                    throw new ArgumentException("Tarih bir DateTime nesnesi olmalıdır");
                }

                komut2.Parameters.Add("@P8", OleDbType.VarChar).Value = p.Saat;
                komut2.Parameters.Add("@P9", OleDbType.VarChar).Value = p.Rapor;

                return komut2.ExecuteNonQuery();
            }
        }



        public static bool HstSil(int p)
        {
            OleDbCommand komut3 = new OleDbCommand("DELETE FROM Hastatablosu WHERE Hastaıd = @P1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1", p);
            return komut3.ExecuteNonQuery() > 0;
        }

        public static bool HstGuncelle(entityhasta ent)
        {
            using (OleDbCommand komut4 = new OleDbCommand("UPDATE Hastatablosu SET Hastaad=@P1, Hastasoyad=@P2, Hastatc=@P3, Hastatel=@P4, Hastarandevu=@P5, Doktoradı=@P6, Tarih=@P7, Saat=@P8 WHERE Hastaıd=@P9", Baglanti.bgl))
            {
                if (komut4.Connection.State != ConnectionState.Open)
                {
                    komut4.Connection.Open();
                }

                
                komut4.Parameters.Add("@P1", OleDbType.VarChar).Value = ent.Hastaad;
                komut4.Parameters.Add("@P2", OleDbType.VarChar).Value = ent.Hastasoyad;
                komut4.Parameters.Add("@P3", OleDbType.VarChar).Value = ent.Hastatc;
                komut4.Parameters.Add("@P4", OleDbType.VarChar).Value = ent.Hastatel;
                komut4.Parameters.Add("@P5", OleDbType.VarChar).Value = ent.Hastarandevu;
                komut4.Parameters.Add("@P6", OleDbType.VarChar).Value = ent.Doktoradı;

                
                if (ent.Tarih is DateTime tarihValue)
                {
                    komut4.Parameters.Add("@P7", OleDbType.Date).Value = tarihValue;
                }
                else
                {
                    throw new ArgumentException("Tarih bir DateTime nesnesi olmalıdır");
                }

                komut4.Parameters.Add("@P8", OleDbType.VarChar).Value = ent.Saat;
                komut4.Parameters.Add("@P9", OleDbType.Integer).Value = ent.Hastaıd;

                return komut4.ExecuteNonQuery() > 0;
            }
        }


        public static OleDbDataReader filter(string Branch)
        {
            OleDbCommand komut5 = new OleDbCommand("SELECT * FROM Doktortablosu WHERE Doktoralan = @P1", Baglanti.bgl);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@P1", Branch);
            OleDbDataReader dr = komut5.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }

        public static bool HstGuncelle2(entityhasta ent)
        {
            OleDbCommand komut4 = new OleDbCommand("UPDATE Hastatablosu SET Rapor=@P1 WHERE Hastaıd=@P2", Baglanti.bgl);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1", ent.Rapor);
            komut4.Parameters.AddWithValue("@P2", ent.Hastaıd);
            return komut4.ExecuteNonQuery() > 0;
        }

        public static List<entityhasta> DALDoktoraGoreHstList(entitydoktor p)
        {
            List<entityhasta> degerler = new List<entityhasta>();
            OleDbCommand komut1 = new OleDbCommand("SELECT * FROM Hastatablosu WHERE Doktoradı=@P1", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            string adsoyad = p.Doctorad + " " + p.Doktorsoyad;
            komut1.Parameters.AddWithValue("@P1", adsoyad);
            OleDbDataReader hst = komut1.ExecuteReader();
            while (hst.Read())
            {
                entityhasta ent = new entityhasta();
                ent.Hastaıd = Convert.ToInt32(hst["Hastaıd"]);
                ent.Hastaad = hst["Hastaad"].ToString();
                ent.Hastasoyad = hst["Hastasoyad"].ToString();
                ent.Hastatc = hst["Hastatc"].ToString();
                ent.Hastatel = hst["Hastatel"].ToString();
                ent.Hastarandevu = hst["Hastarandevu"].ToString();
                ent.Doktoradı = hst["Doktoradı"].ToString();
                ent.Tarih = Convert.ToDateTime(hst["Tarih"]);
                ent.Saat = hst["Saat"].ToString();
                ent.Rapor = hst["Rapor"].ToString();
                degerler.Add(ent);
            }
            hst.Close();
            return degerler;
        }
    }
}
