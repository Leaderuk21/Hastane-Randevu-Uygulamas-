using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entitylayer;
using DATAACCESSLAYER;
using System.Data.OleDb;


namespace LOGİCLAYER
{
    public class logicdoktor
    {
        public static List<entitydoktor> LLDocList()
        {
            return dataaccesdoktor.DALDocList();
        }
        public static int LLDocEkle(entitydoktor p)
        {
            if (p.Doctorad != "" && p.Doktorsoyad != "" && p.Doctorad.Length >= 3)
            {
                return dataaccesdoktor.DocEkle(p);
            }
            else
            {
                return -1;
            }
        }

        public static bool LLDocSil(int per)
        {
            if (per >= 1)
            {
                return dataaccesdoktor.DocSil(per);
            }
            else
            {
                return false;
            }
        }

        public static bool LLDocGuncelle(entitydoktor ent)
        {
            if (ent.Doctorad.Length >= 3 && ent.Doctorad != "")
            {
                return dataaccesdoktor.DocGuncelle(ent);
            }
            else
            {
                return false;
            }
        }
        public static int LLDoktorGiris(entitydoktor p)
        {
            return dataaccesdoktor.DoktorGiris(p);
        }
        public static OleDbCommand LLBolumHastaSayisiCek(string brans)
        {
            return dataaccesdoktor.BolumHastaSayisiCek(brans);
        }
        public static OleDbCommand LLDoktorAdıCek(entitydoktor p)
        {
            return dataaccesdoktor.DoktorAdıCek(p);
        }
        public static OleDbCommand LLDoktorSoyadıCek(entitydoktor p)
        {
            return dataaccesdoktor.DoktorSoyadıCek(p);
        }
    }
}
