/*
 *  DO NOT ALTER OR REMOVE COPYRIGHT NOTICES OR THIS FILE HEADER.
 *
 *  Copyright © (C) 2022 Tunex Digital Yazılım Ltd Şti - All Rights Reserved
 *  Unauthorized copying of this file, via any medium is strictly prohibited
 *  Proprietary and confidential.
 *  
 *  Copyright ©  August 2022 Tunex Digital @ http://tunexdigital.com
 *  
 *  Written by Yusuf Emre Karanfil & M.Sait Kocabaş <emrekaranfil@tunexdigital.com>, August 2022
 *   :Contributors:
 *        Y.Emre Karanfil
 *        M.Sait Kocabaş
 *        Necmettin Zıvlak
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace ucakotomasyon
{
    public partial class SeferEkleForm : Form
    {


        public SeferEkleForm()
        {
            InitializeComponent();
        }
        String firmaidlogo;
        String koltuksayi, ucusid;
        String ucussaat, ucusdakika, tahminisaat, tahminidakika;
        private void onaylabuton1_Click(object sender, EventArgs e)
        {
            
          

            int ucakid, firmaid;
            //componentlerden verileri değişkenlere aktarma 
            ucussaat = ucussaatbox.Text;
            ucusdakika = ucusdakikabox.Text;
            tahminisaat = tahminisaatbox.Text;
            tahminidakika = tahminidakikabox.Text;
            gidistarihbox.Format = DateTimePickerFormat.Custom;
            gidistarihbox.CustomFormat = "yyyy-MM-dd";
            UcusBilgileri.ucustarihi = gidistarihbox.Text;
            UcusBilgileri.ucussaati = ucussaat + ":" + ucusdakika;
            UcusBilgileri.ucustahminisure = tahminisaat + ":" + tahminidakika;
            UcusBilgileri.normalbilet = ekonomifiyatbox.Text;
            UcusBilgileri.bussinesbilet = bussinesfiyatbox.Text;






            try
            {
                //nereden şehir id çekme
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlCommand kontrolnereden = new MySqlCommand("SELECT sehir_id FROM sehirler WHERE (sehir_ad=@sehir)", SqlBaglanti.baglanti);
                kontrolnereden.Parameters.AddWithValue("@sehir", neredenbox.Text);
                MySqlDataReader dr = kontrolnereden.ExecuteReader();
                if (dr.Read())
                {

                    UcusBilgileri.ucusnereden = dr["sehir_id"].ToString();




                }
            }
            catch (Exception ex)
            {

            }

            try
            {
                //nereye şehir id çekme
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlCommand kontrolnereye = new MySqlCommand("SELECT sehir_id FROM sehirler WHERE (sehir_ad=@sehir)", SqlBaglanti.baglanti);
                kontrolnereye.Parameters.AddWithValue("@sehir", nereyebox.Text);
                MySqlDataReader dr = kontrolnereye.ExecuteReader();
                if (dr.Read())
                {

                    UcusBilgileri.ucusnereye = dr["sehir_id"].ToString();




                }
            }
            catch (Exception ex)
            {

            }
            // alınan verilerin uçuş olarak veritabanına kaydı
            SqlBaglanti.baglanti.Close();
            SqlBaglanti.baglanti.Open();
            MySqlCommand seferekleme = new MySqlCommand("INSERT INTO ucuslar (ucus_neredenID,ucus_nereyeID,ucus_saati, ucus_tarih, ucus_tahminsure,normal_bilet,bussines_bilet,ucaklar_ucak_id,ucaklar_firmalar_firmalar_id) VALUES ('" + UcusBilgileri.ucusnereden + "','" + UcusBilgileri.ucusnereye + "','" + UcusBilgileri.ucussaati + "','" + UcusBilgileri.ucustarihi + "','" + UcusBilgileri.ucustahminisure +
                "','" + UcusBilgileri.normalbilet + "','" + UcusBilgileri.bussinesbilet + "','" + int.Parse(UcusBilgileri.ucaklarid) + "','" + int.Parse(UcusBilgileri.ucaklar_firmalar_firmalar_id) + "')", SqlBaglanti.baglanti);
            seferekleme.ExecuteNonQuery();
            SqlBaglanti.baglanti.Close();
            HataBox f = new HataBox();
            HataBox.mesaj = "Uçuş ekleme";
            HataBox.text = "Uçuş eklendi";
            f.hataresim.Visible = false;
            f.onayresim.Visible = true;
            f.Show();
            try
            {

                // ucak id ye göre koltuksayisi  çekme
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlCommand koltuksayisi = new MySqlCommand("SELECT ucak_koltuksayisi FROM ucaklar WHERE (ucak_id=@ucakid)", SqlBaglanti.baglanti);
                koltuksayisi.Parameters.AddWithValue("@ucakid", UcusBilgileri.ucaklarid);
                MySqlDataReader dr = koltuksayisi.ExecuteReader();
                if (dr.Read())
                {
                    koltuksayi = dr["ucak_koltuksayisi"].ToString();
                }
                SqlBaglanti.baglanti.Close();


                // uçuşid sıralı çekme
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlCommand ucusid1 = new MySqlCommand("SELECT ucus_id FROM ucuslar ORDER BY ucus_id DESC", SqlBaglanti.baglanti);
                MySqlDataReader dr1 = ucusid1.ExecuteReader();
                if (dr1.Read())
                {
                    ucusid = dr1["ucus_id"].ToString();
                }
                SqlBaglanti.baglanti.Close();


                //oluşturulan uçağın koltuk sayısı kadar boş koltuk ekleme
                for (int i = 1; i <= int.Parse(koltuksayi); i++)
                {

                    SqlBaglanti.baglanti.Open();
                    MySqlCommand koltukekleme = new MySqlCommand("INSERT INTO koltuklar_has_ucaklar (koltuklar_koltuk_id,ucuslar_ucus_id,dolubos) VALUES ('" + i + "','" + ucusid + "','" + "BOS" + "')", SqlBaglanti.baglanti);
                    koltukekleme.ExecuteNonQuery();

                    SqlBaglanti.baglanti.Close();

                }

            }
            catch (Exception ex)
            {

            };




        }
        
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String secim;
                //seçilen uçağın substring ile plakasını alma
                secim = ucaksecimbox.SelectedItem.ToString();

                // plakaya göre uçak ve firma id çekme
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlCommand ucakidcekme = new MySqlCommand("SELECT ucak_id,firmalar_firmalar_id FROM ucaklar WHERE (ucak_plaka=@ucakplaka)", SqlBaglanti.baglanti);
                ucakidcekme.Parameters.AddWithValue("@ucakplaka", secim.Substring(13, 6));
                MySqlDataReader dr = ucakidcekme.ExecuteReader();
                if (dr.Read())
                {

                    //plakaya göre firma id ucak id ve firma id logoların alınması
                    UcusBilgileri.ucaklar_firmalar_firmalar_id = dr["firmalar_firmalar_id"].ToString();
                    firmaidlogo = dr["firmalar_firmalar_id"].ToString();
                    UcusBilgileri.ucaklarid = dr["ucak_id"].ToString();

                }

            }
            catch (Exception ex)
            {

            };

            // seçilen firmanın logosunu basma
            int secim1 = int.Parse(firmaidlogo);
            if (secim1 == 1)
            {
                logobox.Image = Image.FromFile(Application.StartupPath + "\\pegasus.png");
                logobox.Refresh();
            }
            else if (secim1 == 2)
            {

                logobox.Image = Image.FromFile(Application.StartupPath + "\\turkishairlines.png");
                logobox.Refresh();
            }
            else if (secim1 == 3)
            {
                logobox.Image = Image.FromFile(Application.StartupPath + "\\sunexpress.png");
                logobox.Refresh();
            }

            else if (secim1 == 4)
            {
                logobox.Image = Image.FromFile(Application.StartupPath + "\\anadolujet.png");
                logobox.Refresh();
            }



        }

        private void SeferEkleForm_Load(object sender, EventArgs e)
        {
            //combobox şehir bilgisi çekme
            try
            {
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlCommand ceksehir = new MySqlCommand("SELECT sehir_ad FROM sehirler", SqlBaglanti.baglanti);
                MySqlDataReader dr = ceksehir.ExecuteReader();
                while (dr.Read())
                {

                    neredenbox.Items.Add(dr["sehir_ad"]);
                    nereyebox.Items.Add(dr["sehir_ad"]);


                }
            }
            catch (Exception ex)

            {

            }

            String ucakid1;


            try
            {

                //comboboxa uçakları listeleme
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlCommand ucakekle = new MySqlCommand("SELECT *FROM ucaklar", SqlBaglanti.baglanti);
                MySqlDataReader dr = ucakekle.ExecuteReader();
                while (dr.Read())
                {
                    ucakid1 = dr["ucak_id"].ToString();
                    UcakBilgileri.Ucakplaka = dr["ucak_plaka"].ToString();
                    UcakBilgileri.Ucakkoltuksayisi = dr["ucak_koltuksayisi"].ToString();
                    UcakBilgileri.Firmalarid = dr["firmalar_firmalar_id"].ToString();


                    if (UcakBilgileri.Firmalarid == "1")
                    {
                        ucaksecimbox.Items.Add("Uçak Plaka - " + UcakBilgileri.Ucakplaka + " - " + " Koltuk Sayısı - " + UcakBilgileri.Ucakkoltuksayisi + " - " + "Pegasus");
                    }
                    else if (UcakBilgileri.Firmalarid == "2")
                    {
                        ucaksecimbox.Items.Add("Uçak Plaka - " + UcakBilgileri.Ucakplaka + " - " + " Koltuk Sayısı - " + UcakBilgileri.Ucakkoltuksayisi + " - " + "Türk Hava Yolları");
                    }
                    else if (UcakBilgileri.Firmalarid == "3")
                    {
                        ucaksecimbox.Items.Add("Uçak Plaka - " + UcakBilgileri.Ucakplaka + " - " + " Koltuk Sayısı - " + UcakBilgileri.Ucakkoltuksayisi + " - " + "Sunexpress");
                    }
                    else if (UcakBilgileri.Firmalarid == "4")
                    {
                        ucaksecimbox.Items.Add("Uçak Plaka - " + UcakBilgileri.Ucakplaka + " - " + " Koltuk Sayısı - " + UcakBilgileri.Ucakkoltuksayisi + " - " + "AnadoluJet");
                    }

                }
            }
            catch (Exception ex)
            {

            }

        }

        private void neredenbox_SelectedValueChanged(object sender, EventArgs e)
        {

            // combobox şehir çakışma kontrol
            String secim1, secim2;
            secim1 = neredenbox.SelectedItem.ToString();
            secim2 = neredenbox.SelectedItem.ToString();

            nereyebox.Items.Clear();
            try
            {
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlCommand kontrolsehir = new MySqlCommand("SELECT sehir_ad FROM sehirler", SqlBaglanti.baglanti);
                MySqlDataReader dr = kontrolsehir.ExecuteReader();
                while (dr.Read())
                {
                    nereyebox.Items.Add(dr["sehir_ad"]);
                }
            }
            catch (Exception ex)
            {

            }
            nereyebox.Items.Remove(secim1);
        }

      

        private void nereyebox_Click(object sender, EventArgs e)
        {

            // combobox şehir çakışma kontrol
            String secim;
            secim = neredenbox.Text.ToString();
            if (secim == "")
            {
                if (nereyebox.Items != null)
                {
                    nereyebox.Items.Clear();
                }
                else
                {

                }

            }

        }

    }
}
