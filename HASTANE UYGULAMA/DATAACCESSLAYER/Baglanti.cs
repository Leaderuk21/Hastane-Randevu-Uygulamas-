
using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAACCESSLAYER
{
    public class Baglanti
    {
        public static OleDbConnection bgl = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ukara\\OneDrive\\Masaüstü\\HASTANE UYGULAMA\\Databaseşimdi.accdb");
    }

}
