using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entitylayer;
using DATAACCESSLAYER;


namespace LOGİCLAYER
{
    public class logicsekreter
    {
        public static List<entitysekreter> LLSecList()
        {
            return dataaccesssekreter.DALSecList();
        }
        public static int LLSecEkle(entitysekreter p)
        {
            if (p.Sekreteradı != "" && p.Sekretersoyad != "" && p.Sekreteradı.Length >= 3)
            {
                return dataaccesssekreter.SecEkle(p);
            }
            else
            {
                return -1;
            }
        }

        public static bool LLSecSil(int per)
        {
            if (per >= 1)
            {
                return dataaccesssekreter.SecSil(per);
            }
            else
            {
                return false;
            }
        }

        public static bool LLSecGuncelle(entitysekreter ent)
        {
            if (ent.Sekreteradı.Length >= 3 && ent.Sekreteradı != "")
            {
                return dataaccesssekreter.SecGuncelle(ent);
            }
            else
            {
                return false;
            }
        }
        public static int LLSecGiris(entitysekreter p)
        {
            return dataaccesssekreter.SecGiris(p);
        }
    }
}
