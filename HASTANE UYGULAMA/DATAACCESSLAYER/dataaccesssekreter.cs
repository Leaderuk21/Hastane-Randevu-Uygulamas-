using entitylayer;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATAACCESSLAYER;

namespace DATAACCESSLAYER
{
    public class dataaccesssekreter
    {
        public static List<entitysekreter> DALSecList()
        {
            List<entitysekreter> degerler = new List<entitysekreter>();
            OleDbCommand komut1 = new OleDbCommand("SELECT * FROM Sekretertablosu", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            OleDbDataReader sec = komut1.ExecuteReader();
            while (sec.Read())
            {
                entitysekreter ent = new entitysekreter();
                ent.Sekreterıd = Convert.ToInt32(sec["Sekreterıd"]);
                ent.Sekreteradı = sec["Sekreteradı"].ToString();
                ent.Sekretersoyad = sec["Sekretersoyad"].ToString();
                ent.Sekretertel = sec["Sekretertel"].ToString();
                ent.Sekreterkullanıcıadı = sec["Sekreterkullanıcıadı"].ToString();
                ent.Sekreterşifre = sec["Sekreterşifre"].ToString();
                degerler.Add(ent);
            }
            sec.Close();
            return degerler;
        }

        public static int SecEkle(entitysekreter p)
        { 
            OleDbCommand komut2 = new OleDbCommand("INSERT INTO Sekretertablosu(Sekreteradı,Sekretersoyad,Sekretertel,Sekreterkullanıcıadı,Sekreterşifre) VALUES (@P1,@P2,@P3,@P4,@P5)", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@P1", p.Sekreteradı);
            komut2.Parameters.AddWithValue("@P2", p.Sekretersoyad);
            komut2.Parameters.AddWithValue("@P3", p.Sekretertel);
            komut2.Parameters.AddWithValue("@P4", p.Sekreterkullanıcıadı);
            komut2.Parameters.AddWithValue("@P5", p.Sekreterşifre);
            return komut2.ExecuteNonQuery();
        }
        public static bool SecSil(int p)
        {
            OleDbCommand komut3 = new OleDbCommand("DELETE FROM Sekretertablosu WHERE Sekreterıd = @P1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1", p);
            return komut3.ExecuteNonQuery() > 0;
        }

        public static bool SecGuncelle(entitysekreter ent)
        {
            OleDbCommand komut4 = new OleDbCommand("UPDATE Sekretertablosu SET Sekreteradı=@P1,Sekretersoyad=@P2,Sekretertel=@P3,Sekreterkullanıcıadı=@P4,Sekreterşifre=@P5 WHERE Sekreterıd=@P6", Baglanti.bgl);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1", ent.Sekreteradı);
            komut4.Parameters.AddWithValue("@P2", ent.Sekretersoyad);
            komut4.Parameters.AddWithValue("@P3", ent.Sekretertel);
            komut4.Parameters.AddWithValue("@P4", ent.Sekreterkullanıcıadı);
            komut4.Parameters.AddWithValue("@P5", ent.Sekreterşifre);
            komut4.Parameters.AddWithValue("@P6", ent.Sekreterıd);
            return komut4.ExecuteNonQuery() > 0;
        }
        public static int SecGiris(entitysekreter p)
        {
            Baglanti.bgl.Close();
            Baglanti.bgl.Open();
            OleDbCommand komut3 = new OleDbCommand("SELECT * FROM Sekretertablosu WHERE Sekreterkullanıcıadı=@P1 AND Sekreterşifre=@P2", Baglanti.bgl);
            komut3.Parameters.AddWithValue("@P1", p.Sekreterkullanıcıadı);
            komut3.Parameters.AddWithValue("@P2", p.Sekreterşifre);
            OleDbDataReader sec = komut3.ExecuteReader();
            if (sec.Read())
            {
                entitysekreter sekreter = new entitysekreter();
                sekreter.Sekreterıd = Convert.ToInt16(sec["Sekreterıd"]);
                sekreter.Sekreteradı = Convert.ToString(sec["Sekreteradı"]);
                sekreter.Sekretersoyad = Convert.ToString(sec["Sekretersoyad"]);
                sekreter.Sekreterkullanıcıadı = Convert.ToString(sec["Sekreterkullanıcıadı"]);
                sekreter.Sekreterşifre = Convert.ToString(sec["Sekreterşifre"]);
                sekreter.Sekretertel = Convert.ToString(sec["Sekretertel"]);
                sec.Close();
                return 1;
            }
            else
            {
                sec.Close();
                return 2;
            }
        }
    }
}

