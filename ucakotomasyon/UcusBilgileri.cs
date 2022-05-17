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

        public static String ucustahminisure
        {
            get { return ucus_tahminsure; }
            set { ucus_tahminsure = value; }
        }

        public static String normalbilet
        {
            get { return normal_bilet; }
            set { normal_bilet = value; }
        }

        public static String bussinesbilet
        {
            get { return bussines_bilet; }
            set { bussines_bilet = value; }
        }

        public static String ucaklarid
        {
            get { return ucaklar_ucak_id; }
            set { ucaklar_ucak_id = value; }
        }

        public static String ucaklarfirmalarid
        {
            get { return ucaklar_firmalar_firmalar_id; }
            set { ucaklar_firmalar_firmalar_id = value; }
        }

    }

}
