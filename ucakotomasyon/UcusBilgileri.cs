using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucakotomasyon
{
    internal class UcusBilgileri
    {
        public static String ucus_neredenID, ucus_nereyeID, ucus_saati, ucus_tarihi, ucus_tahminsure, normal_bilet, bussines_bilet, ucaklar_ucak_id, ucaklar_firmalar_firmalar_id;

        public static String ucusnereden
        {
            get { return ucus_neredenID; }
            set { ucus_neredenID = value; }
        }
        public static String ucusnereye
        {
            get { return ucus_nereyeID; }
            set { ucus_nereyeID = value; }
        }

        public static String ucussaati
        {
            get { return ucus_saati; }
            set { ucus_saati = value; }
        }
        public static String ucustarihi
        {
            get { return ucus_tarihi; }
            set { ucus_tarihi = value; }
        }
    }

}
