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
    public partial class UcakGuncelle : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3306;Database=otomasyon;user=root;password=1234;SslMode=none;");
        public UcakGuncelle()
        {
            InitializeComponent();
        }
        String firmaidlogo, secim;

        private void ucaksecimbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                secim = ucaksecimbox.SelectedItem.ToString();

                // uçak ve firma id çekme
                baglanti.Close();
                baglanti.Open();
                MySqlCommand ucakidcekme = new MySqlCommand("SELECT ucak_id,firmalar_firmalar_id FROM ucaklar WHERE (ucak_plaka=@ucakplaka)", baglanti);
                ucakidcekme.Parameters.AddWithValue("@ucakplaka", secim.Substring(13, 6));
                MySqlDataReader dr = ucakidcekme.ExecuteReader();
                if (dr.Read())
                {

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


            String deger;

            plakabox.Text = secim.Substring(13, 6);
            koltuksayibox.Text = secim.Substring(39, 3);
















        }

        private void onaylabuton_Click(object sender, EventArgs e)
        {
            String plaka, koltuksayisi;


            plaka = plakabox.Text;
            koltuksayisi = koltuksayibox.Text;


            baglanti.Close();
            baglanti.Open();
            MySqlCommand ucakekleme = new MySqlCommand("UPDATE ucaklar SET ucak_plaka=@plaka, ucak_koltuksayisi=@koltuk WHERE ucak_id=@ucakid", baglanti);
            ucakekleme.Parameters.AddWithValue("@ucakid", UcusBilgileri.ucaklarid);
            ucakekleme.Parameters.AddWithValue("@plaka", plaka);
            ucakekleme.Parameters.AddWithValue("@koltuk", koltuksayisi);

            ucakekleme.ExecuteNonQuery();
            baglanti.Close();
            HataBox f = new HataBox();
            HataBox.mesaj = "Uçak ekleme";
            HataBox.text = "Uçak Güncellendi";
            f.hataresim.Visible = false;
            f.onayresim.Visible = true;

            f.Show();


        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                MySqlCommand ucakekleme = new MySqlCommand("DELETE FROM ucaklar WHERE ucak_id=@ucakid", baglanti);
                ucakekleme.Parameters.AddWithValue("@ucakid", UcusBilgileri.ucaklarid);
                ucakekleme.ExecuteNonQuery();
                baglanti.Close();
                HataBox f = new HataBox();
                HataBox.mesaj = "Uçak ekleme";
                HataBox.text = "Uçak Silindi";
                f.hataresim.Visible = false;
                f.onayresim.Visible = true;

                f.Show();
            }
            catch (Exception ex)
            {
                HataBox f = new HataBox();
                HataBox.mesaj = "Uçak Silme";
                HataBox.text = "Silmek İstediğiniz Uçağın \nSeferi Mevcut Lütfen Önce Seferi Siliniz";
                f.hataresim.Visible = true;
                f.onayresim.Visible = false;
                f.Show();
            }


        }

        private void UcakGuncelle_Load(object sender, EventArgs e)
        {
            String ucakid1;
            try
            {

                //comboboxa uçakları listeleme
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
    }
}
