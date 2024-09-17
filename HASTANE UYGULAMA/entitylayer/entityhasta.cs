using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitylayer
{
    public class entityhasta
    {
        private int hastaid;
        private string hastaname;
        private string hastasurname;
        private string hastatckn;
        private string hastaphone;
        private string hastabolum;
        private string docname;
        private DateTime tarih;
        private string saat;
        private string rapor;

        public int Hastaıd { get => hastaid; set => hastaid = value; }
        public string Hastaad { get => hastaname; set => hastaname = value; }
        public string Hastasoyad { get => hastasurname; set => hastasurname = value; }
        public string Hastatc { get => hastatckn; set => hastatckn = value; }
        public string Hastatel { get => hastaphone; set => hastaphone = value; }
        public string Hastarandevu { get => hastabolum; set => hastabolum = value; }
        public string Doktoradı { get => docname; set => docname = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }
        public string Saat { get => saat; set => saat = value; }
        public string Rapor { get => rapor; set => rapor = value; }
    }
}
