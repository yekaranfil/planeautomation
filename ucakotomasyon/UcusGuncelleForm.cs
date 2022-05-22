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
    public partial class UcusGuncelleForm : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3306;Database=otomasyon;user=root;password=1234;SslMode=none;");
        DataTable tablo = new DataTable();
        DataSet data = new DataSet();

        MySqlCommandBuilder upt = new MySqlCommandBuilder();
        public UcusGuncelleForm()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucaksecimbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UcusGuncelleForm_Load(object sender, EventArgs e)
        {


            
            try
            {

                //Tabloya uçuşları listeleme
                baglanti.Close();
                baglanti.Open();
                MySqlDataAdapter dr = new MySqlDataAdapter("SELECT * FROM ucuslar", baglanti);
                data = new DataSet();
                dr.Fill(tablo);
                ucustable.DataSource = tablo;
                ucustable.Refresh();

            }
            catch (Exception ex)
            {

            }

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
            }
            catch (Exception ex)

            {

            }


            try
            {

                //comboboxa uçakları listeleme
                baglanti.Close();
                baglanti.Open();
                MySqlCommand ucakekle = new MySqlCommand("SELECT *FROM ucaklar", baglanti);
                MySqlDataReader dr = ucakekle.ExecuteReader();
                while (dr.Read())
                {
                    String ucakid1 = dr["ucak_id"].ToString();
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

        private void guncellebuton_Click(object sender, EventArgs e)
        {
            // tablodaki verileri güncelleyip veritabanına kaydetme
            try
            {
                baglanti.Close();
                baglanti.Open();
                MySqlDataAdapter dr = new MySqlDataAdapter("SELECT *FROM ucuslar", baglanti);
                data = new DataSet();
                upt = new MySqlCommandBuilder(dr);
                tablo = (DataTable)ucustable.DataSource;
                dr.Update(tablo);
                ucustable.Refresh();
                HataBox f = new HataBox();
                HataBox.mesaj = "Uçuş ekleme";
                HataBox.text = "Uçuş Güncellendi";
                f.hataresim.Visible = false;
                f.onayresim.Visible = true;
                f.Show();
            }
            catch (Exception ex)
            {
                HataBox f = new HataBox();
                HataBox.mesaj = "Uçak ekleme";
                HataBox.text = "Uçuş Güncellenemedi";
                f.hataresim.Visible = true;
                f.onayresim.Visible = false;
                f.Show();
            }




            tablo.Clear();
            UcusGuncelleForm_Load(null, null);




        }
        int satirsayisi;
        private void ucustable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                //seçilen satır ve sutundaki şehir id verisibi alma
                String deger = ucustable.Rows[e.RowIndex].Cells[1].Value.ToString();
                String deger1 = ucustable.Rows[e.RowIndex].Cells[2].Value.ToString();

                satirsayisi = e.RowIndex;

                //alınan id ile şehir adını çekme
                try
                {
                    baglanti.Close();
                    baglanti.Open();
                    MySqlCommand kontrolfirma = new MySqlCommand("SELECT sehir_ad FROM sehirler WHERE (sehir_id=@sehirid)", baglanti);
                    kontrolfirma.Parameters.AddWithValue("@sehirid", deger);
                    MySqlDataReader dr = kontrolfirma.ExecuteReader();
                    while (dr.Read())
                    {
                        //seçilen hücrenin içindeki şehrin adını lbl yazdırma
                        neredenlbl.Text = (dr["sehir_ad"]).ToString();

                    }
                }
                catch (Exception ex)

                {

                }

                try
                {

                    baglanti.Close();
                    baglanti.Open();
                    MySqlCommand kontrolfirma = new MySqlCommand("SELECT sehir_ad FROM sehirler WHERE (sehir_id=@sehirid)", baglanti);
                    kontrolfirma.Parameters.AddWithValue("@sehirid", deger1);
                    MySqlDataReader dr = kontrolfirma.ExecuteReader();
                    while (dr.Read())
                    {
                        //seçilen hücrenin içindeki şehrin adını lbl yazdırma
                        nereyelbl.Text = (dr["sehir_ad"]).ToString();

                    }
                }
                catch (Exception ex)

                {
                    HataBox f = new HataBox();
                    HataBox.mesaj = "Uçak Güncelleme";
                    HataBox.text = "Hatalı Seçim";
                    f.hataresim.Visible = true;
                    f.onayresim.Visible = false;
                    f.Show();
                }

            } catch (Exception ex)
            {

            }
           


        }

        private void ucustable_Click(object sender, EventArgs e)
        {

        }

        private void neredenbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //secilen nereden şehrin idsini tabloya aktarma
           

            try
            {

                baglanti.Close();
                baglanti.Open();
                MySqlCommand kontrolfirma = new MySqlCommand("SELECT sehir_id FROM sehirler WHERE (sehir_ad=@sehirad)", baglanti);
                kontrolfirma.Parameters.AddWithValue("@sehirad", neredenbox.SelectedItem);
                MySqlDataReader dr = kontrolfirma.ExecuteReader();
                while (dr.Read())
                {
                    
                    ucustable.Rows[satirsayisi].Cells[1].Value =  (dr["sehir_id"]).ToString();

                }
            }
            catch (Exception ex)

            {

            }

        }

        private void nereyebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //secilen nereye şehrin idsini tabloya aktarma
       

            try
            {
                baglanti.Close();
                baglanti.Open();
                MySqlCommand kontrolfirma = new MySqlCommand("SELECT sehir_id FROM sehirler WHERE (sehir_ad=@sehirad)", baglanti);
                kontrolfirma.Parameters.AddWithValue("@sehirad", nereyebox.SelectedItem);
                MySqlDataReader dr = kontrolfirma.ExecuteReader();
                while (dr.Read())
                {
                    
                    ucustable.Rows[satirsayisi].Cells[2].Value = (dr["sehir_id"]).ToString();

                }
            }
            catch (Exception ex)

            {

            }

        }
        String firmaidlogo;
        private void ucaksecimbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                //ucak plakasına göre uçak id ve firma id sorgulama
                String secim;
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

            ucustable.Rows[satirsayisi].Cells[8].Value = UcusBilgileri.ucaklarid;
            ucustable.Rows[satirsayisi].Cells[9].Value = UcusBilgileri.ucaklar_firmalar_firmalar_id;

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

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                MySqlCommand ucussilme = new MySqlCommand("DELETE FROM ucuslar WHERE ucus_id=@ucusid", baglanti);
                ucussilme.Parameters.AddWithValue("@ucusid", ucustable.Rows[satirsayisi].Cells[0].Value);
                ucussilme.ExecuteNonQuery();
                baglanti.Close();
                HataBox f = new HataBox();
                HataBox.mesaj = "Uçuş silme";
                HataBox.text = "Uçuş Silindi";
                f.hataresim.Visible = false;
                f.onayresim.Visible = true;

                f.Show();
            }
            catch (Exception ex)
            {
                HataBox f = new HataBox();
                HataBox.mesaj = "Uçuş Silme";
                HataBox.text = "Hata";
                f.hataresim.Visible = true;
                f.onayresim.Visible = false;
                f.Show();
            }

            tablo.Clear();
            UcusGuncelleForm_Load(null, null);
        }

        private void ucustable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
