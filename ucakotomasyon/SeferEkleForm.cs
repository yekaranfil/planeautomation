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
        

        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3306;Database=otomasyon;user=root;password=1234;SslMode=none;");
        public SeferEkleForm()
        {
            InitializeComponent();
        }


        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sonuc = ucaksecimbox.SelectedIndex + 1 ;
            UcusBilgileri.ucaklarid = sonuc.ToString();

          


        }

        private void onaylabuton1_Click(object sender, EventArgs e)
        {
            String ucussaat, ucusdakika, tahminisaat, tahminidakika;
            int ucakid, firmaid;
            ucussaat = ucussaatbox.Text;
            ucusdakika = ucusdakikabox.Text;
            tahminisaat = tahminisaatbox.Text;
            tahminidakika = tahminidakikabox.Text;

            UcusBilgileri.ucustarihi = gidistarihbox.Text; 
            UcusBilgileri.ucussaati = ucussaat + ":" + ucusdakika;
            UcusBilgileri.ucustahminisure = tahminisaat + ":" + tahminidakika;
            UcusBilgileri.normalbilet = ekonomifiyatbox.Text; 
            UcusBilgileri.bussinesbilet = bussinesfiyatbox.Text;


            String sorgu1 = UcakBilgileri.Ucakplaka + " - " + UcakBilgileri.Ucakkoltuksayisi + " - " + "Pegasus";


            try
            {
                baglanti.Close();
                baglanti.Open();
                MySqlCommand kontrolnereden = new MySqlCommand("SELECT firmalar_id FROM firmalar WHERE (firma_adi=@firmaadi)", baglanti);


                //firma id çekmek için eklenen uçaklar ile şartlı sorgulama

                if (ucaksecimbox.Text == sorgu1)
                {
                    kontrolnereden.Parameters.AddWithValue("@firmaadi","Pegasus");

                }
                else if (ucaksecimbox.Text == UcakBilgileri.Ucakplaka + " - " + UcakBilgileri.Ucakkoltuksayisi + " - " + "Türk Hava Yolları")
                {
                    kontrolnereden.Parameters.AddWithValue("@firmaadi","Türk Hava Yolları");
                }
                else if (ucaksecimbox.Text == UcakBilgileri.Ucakplaka + " - " + UcakBilgileri.Ucakkoltuksayisi + " - " + "Sunexpress")
                {
                    kontrolnereden.Parameters.AddWithValue("@firmaadi","Sunexpress");
                }
                else if (ucaksecimbox.Text == UcakBilgileri.Ucakplaka + " - " + UcakBilgileri.Ucakkoltuksayisi + " - " + "AnadoluJet")
                {
                    kontrolnereden.Parameters.AddWithValue("@firmaadi","AnadoluJet");
                }

                MySqlDataReader dr = kontrolnereden.ExecuteReader();
                if (dr.Read())
                {

                    UcakBilgileri.Firmalarid = dr["firmalar_id"].ToString();




                }
            }
            catch (Exception ex)
            {

            }





            //firma id çekme







            //nereden şehir id çekme

            try
            {
                baglanti.Close();
                baglanti.Open();
                MySqlCommand kontrolnereden = new MySqlCommand("SELECT sehir_id FROM sehirler WHERE (sehir_ad=@sehir)", baglanti);
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
                baglanti.Close();
                baglanti.Open();
                MySqlCommand kontrolnereye = new MySqlCommand("SELECT sehir_id FROM sehirler WHERE (sehir_ad=@sehir)", baglanti);
                kontrolnereye.Parameters.AddWithValue("@sehir", nereyebox.Text);
                MySqlDataReader dr = kontrolnereye.ExecuteReader();
                if (dr.Read())
                {

                    UcusBilgileri.ucusnereye= dr["sehir_id"].ToString();




                }
            }
            catch (Exception ex)
            {

            }




            baglanti.Close();
            baglanti.Open();

            MySqlCommand seferekleme = new MySqlCommand("INSERT INTO ucuslar (ucus_neredenID,ucus_nereyeID,ucus_saati, ucus_tarih, ucus_tahminsure,normal_bilet,bussines_bilet,ucaklar_ucak_id,ucaklar_firmalar_firmalar_id) VALUES ('" + UcusBilgileri.ucusnereden + "','" + UcusBilgileri.ucusnereye + "','" + UcusBilgileri.ucussaati  + "','" + UcusBilgileri.ucustarihi + "','" + UcusBilgileri.ucustahminisure + 
                "','" + UcusBilgileri.normalbilet + "','" + UcusBilgileri.bussinesbilet + "','" + UcusBilgileri.ucaklarid + "','" + UcakBilgileri.Firmalarid + "')", baglanti);
            seferekleme.ExecuteNonQuery();
            baglanti.Close();
            HataBox f = new HataBox();
            HataBox.mesaj = "Uçuş ekleme";
            HataBox.text = "Uçuş eklendi";
            f.hataresim.Visible = false;
            f.onayresim.Visible = true;
            f.Show();



        }

        private void SeferEkleForm_Load(object sender, EventArgs e)
        {
            //combobox şehir bilgisi çekme
            try
            {
                baglanti.Close();
                baglanti.Open();
                MySqlCommand kontrolfirma = new MySqlCommand("SELECT sehir_ad FROM sehirler", baglanti);
                MySqlDataReader dr = kontrolfirma.ExecuteReader();
                while (dr.Read())
                {

                    neredenbox.Items.Add(dr["sehir_ad"]);
                    nereyebox.Items.Add(dr["sehir_ad"]);

                    
                }
            } catch(Exception ex) 

            {

            }

            String ucakid1;
            try
            {
                baglanti.Close();
                baglanti.Open();
                MySqlCommand ucakekle = new MySqlCommand("SELECT *FROM ucaklar", baglanti);
                MySqlDataReader dr = ucakekle.ExecuteReader();
                while (dr.Read())
                {
                    ucakid1 = dr["ucak_id"].ToString();
                    UcakBilgileri.Ucakplaka = dr["ucak_plaka"].ToString();
                    UcakBilgileri.Ucakkoltuksayisi = dr["ucak_koltuksayisi"].ToString();
                    UcakBilgileri.Firmalarid = dr["firmalar_firmalar_id"].ToString();


                    if (UcakBilgileri.Firmalarid == "1")
                    {
                        ucaksecimbox.Items.Add(UcakBilgileri.Ucakplaka + " - " + UcakBilgileri.Ucakkoltuksayisi + " - " + "Pegasus");
                    } else if (UcakBilgileri.Firmalarid == "2")
                    {
                        ucaksecimbox.Items.Add(UcakBilgileri.Ucakplaka + " - " + UcakBilgileri.Ucakkoltuksayisi + " - " + "Türk Hava Yolları");
                    }
                    else if (UcakBilgileri.Firmalarid == "3")
                    {
                        ucaksecimbox.Items.Add(UcakBilgileri.Ucakplaka + " - " + UcakBilgileri.Ucakkoltuksayisi + " - " + "Sunexpress");
                    }
                    else if (UcakBilgileri.Firmalarid == "4")
                    {
                        ucaksecimbox.Items.Add(UcakBilgileri.Ucakplaka + " - " + UcakBilgileri.Ucakkoltuksayisi + " - " + "AnadoluJet");
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
            String secim1,secim2;
            secim1 = neredenbox.SelectedItem.ToString();
            secim2 = neredenbox.SelectedItem.ToString();

            nereyebox.Items.Clear();
            try
            {
                baglanti.Close();
                baglanti.Open();
                MySqlCommand kontrolfirma = new MySqlCommand("SELECT sehir_ad FROM sehirler", baglanti);
                MySqlDataReader dr = kontrolfirma.ExecuteReader();
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

        private void nereyebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void nereyebox_Click(object sender, EventArgs e)
        {

            // combobox şehir çakışma kontrol
            String secim;
            secim = neredenbox.Text.ToString();
            if (secim == "")
            {
                if(nereyebox.Items != null )
                {
                    nereyebox.Items.Clear();
                }
                else { 

                }

            }




        }

        private void neredenbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
        }
    }
}
