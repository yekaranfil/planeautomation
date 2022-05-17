using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucakotomasyon
{
    internal class UcakBilgileri
    {
        public static String ucak_plaka, ucak_koltuksayisi, firmalar_firmalar_id;


        public static String Ucakkoltuksayisi
        {
            get { return ucak_koltuksayisi; }
            set { ucak_koltuksayisi = value; }
        }

        public static String Ucakplaka
        {
            get { return ucak_plaka; }
            set { ucak_plaka = value; }
        }

        public static String Firmalarid
        {
            get { return firmalar_firmalar_id; }
            set { firmalar_firmalar_id = value; }
        }
    }
}
