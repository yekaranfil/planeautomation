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


    public partial class AdminUcusEkleForm : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3306;Database=otomasyon;user=root;password=1234;SslMode=none;");
        public AdminUcusEkleForm()
        {
            InitializeComponent();
        }

        private void AdminUcusEkleForm_Load(object sender, EventArgs e)
        {
            //comboboxa firma adı çekme
            baglanti.Close();
            baglanti.Open();
            MySqlCommand kontrolfirma = new MySqlCommand("SELECT firma_adi FROM firmalar ", baglanti);
            MySqlDataReader dr = kontrolfirma.ExecuteReader();
            while (dr.Read())
            {

                firmabox.Items.Add(dr["firma_adi"]);
            }

        }

        public void onaylabuton_Click(object sender, EventArgs e)
        {
            String koltuk = "", plaka = "";

            try
            {
                

                koltuk = koltukbox.Text;
                plaka = plakabox.Text;



                if (plaka != "" && koltuk != "" && firmaid != "")
                {

                    

                    if (plakabox.Text.Length != 6)
                    {
                        HataBox f1 = new HataBox();
                        HataBox.mesaj = "Veri hatası";
                        HataBox.text = "Lütfen 6 haneli bir uçak plakası giriniz";
                        f1.hataresim.Visible = true;
                        f1.onayresim.Visible = false;
                        f1.Show();
                    }
                    else
                    {
                        plaka = plakabox.Text;
                        if (int.Parse(koltukbox.Text) == null)
                        {
                            HataBox f1 = new HataBox();
                            HataBox.mesaj = "Veri hatası";
                            HataBox.text = "Lütfen 250 den az bir koltuk sayısı giriniz";
                            f1.hataresim.Visible = true;
                            f1.onayresim.Visible = false;
                            f1.Show();
                        }
                        else
                        {
                            koltuk = koltukbox.Text;


                           
                                //ucak verileri kaydetme
                                baglanti.Close();
                                baglanti.Open();
                                MySqlCommand ucakekleme = new MySqlCommand("INSERT INTO ucaklar (ucak_plaka, ucak_koltuksayisi, firmalar_firmalar_id) VALUES ('" + plaka + "','" + koltuk + "','" + int.Parse(firmaid) + "')", baglanti);
                                ucakekleme.ExecuteNonQuery();
                                baglanti.Close();
                                HataBox f = new HataBox();
                                HataBox.mesaj = "Uçak ekleme";
                                HataBox.text = "Uçak eklendi";
                                f.hataresim.Visible = false;
                                f.onayresim.Visible = true;

                            f.Show();
                        }

                    }

                } else
                {
                    HataBox f1 = new HataBox();
                    HataBox.mesaj = "Veri hatası";
                    HataBox.text = "Lütfen Gerekli Alanları Doldurunuz";
                    f1.hataresim.Visible = true;
                    f1.onayresim.Visible = false;
                    f1.Show();
                }

            } catch(Exception ex)

            {

            }

        }

        public static String firmaid,firmaadi;
        public void firmabox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String secim;

            // seçilen uçağın logosunu getirme

            secim = firmabox.SelectedItem.ToString();
            if(secim == "Pegasus")
            {
                logobox.Image = Image.FromFile(Application.StartupPath + "\\pegasus.png");
                logobox.Refresh();
            }
            else if( secim == "Türk Hava Yolları")
            {
                
                logobox.Image = Image.FromFile(Application.StartupPath + "\\turkishairlines.png");
                logobox.Refresh();
            }
            else if (secim == "Sunexpress")
            {
                logobox.Image = Image.FromFile(Application.StartupPath + "\\sunexpress.png");
                logobox.Refresh();
            }

            else if(secim == "AnadoluJet")
            {
                logobox.Image = Image.FromFile(Application.StartupPath + "\\anadolujet.png");
                logobox.Refresh();
            }

            
              firmaadi = firmabox.SelectedItem.ToString();
                //firma id alma
                baglanti.Close();
                baglanti.Open();
                MySqlCommand kontrolfirmaid = new MySqlCommand("SELECT firmalar_id FROM firmalar WHERE (firma_adi=@firmaadi) ", baglanti);
                kontrolfirmaid.Parameters.AddWithValue("firmaadi", firmaadi);

                MySqlDataReader dr = kontrolfirmaid.ExecuteReader();

                if (dr.Read())
                {
                    firmaid = dr["firmalar_id"].ToString();
                }
                else
                {

                }





        }
    }
}
