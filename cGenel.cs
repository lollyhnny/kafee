using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CafeOtomasyonu
{
    class cGenel
    {
        public string conString = ("Data Source=DESKTOP-F13V9TB;Initial Catalog=CafeOtomasyonu; Integrated Security=True");
        public static int _personelId;
        public static int _gorevId;
        public static string _ButtonValue;
        public static string _ButtonName;
        public static int _ServisTurNo;
        public static string _AdisyonId;
    }
}
