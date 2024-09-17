using entitylayer;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATAACCESSLAYER;

namespace LOGİCLAYER
{
    public class logichasta
    {
        public static List<entityhasta> LLHstList()
        {
            return dataaccesshasta.DALHstList();
        }

        public static List<entityhasta> LLDoktoraGoreHstList(entitydoktor p)
        {
            return dataaccesshasta.DALDoktoraGoreHstList(p);
        }

        public static int LLHstEkle(entityhasta p)
        {
            if (p.Hastaad != "" && p.Hastasoyad != "" && p.Hastaad.Length >= 3)
            {
                return dataaccesshasta.HstEkle(p);
            }
            else
            {
                return -1;
            }
        }

        public static OleDbDataReader LLFilter(string Branch)
        {
            return dataaccesshasta.filter(Branch);
        }

        public static bool LLHstSil(int per)
        {
            if (per >= 1)
            {
                return dataaccesshasta.HstSil(per);
            }
            else
            {
                return false;
            }
        }

        public static bool LLHstGuncelle(entityhasta ent)
        {
            if (ent.Hastaad.Length >= 3 && ent.Hastaad != "")
            {
                return dataaccesshasta.HstGuncelle(ent);
            }
            else
            {
                return false;
            }
        }

        public static bool LLHstGuncelle2(entityhasta ent)
        {
            if (ent.Rapor.Length >= 3 && ent.Rapor != "")
            {
                return dataaccesshasta.HstGuncelle2(ent);
            }
            else
            {
                return false;
            }
        }
    }
}
