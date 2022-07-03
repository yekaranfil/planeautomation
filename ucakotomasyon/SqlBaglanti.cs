using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucakotomasyon
{
    public class SqlBaglanti
    {
        public static string MySqlConnection = ConfigurationManager.ConnectionStrings["Ucakotomasyonsql"].ConnectionString;
        public static MySqlConnection baglanti = new MySqlConnection(MySqlConnection);

    }
}
