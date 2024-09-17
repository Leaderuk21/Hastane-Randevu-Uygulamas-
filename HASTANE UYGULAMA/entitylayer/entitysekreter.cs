using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitylayer
{
    public class entitysekreter
    {
        private int sekid;
        private string sekname;
        private string seksurname;
        private string sekphone;
        private string sekusername;
        private string sekpassword;

        public int Sekreterıd { get => sekid; set => sekid = value; }
        public string Sekreteradı { get => sekname; set => sekname = value; }
        public string Sekretersoyad { get => seksurname; set => seksurname = value; }
        public string Sekretertel { get => sekphone; set => sekphone = value; }
        public string Sekreterkullanıcıadı { get => sekusername; set => sekusername = value; }
        public string Sekreterşifre { get => sekpassword; set => sekpassword = value; }
    }
}
