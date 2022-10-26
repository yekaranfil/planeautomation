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


    public partial class AdminUcusEkleForm : Form
    {
        public AdminUcusEkleForm()
        {
            InitializeComponent();
        }

        public static String firmaid, firmaadi;
        private void AdminUcusEkleForm_Load(object sender, EventArgs e)
        {
            //comboboxa firma adı çekme
            SqlBaglanti.baglanti.Close();
            SqlBaglanti.baglanti.Open();
            MySqlCommand kontrolfirma = new MySqlCommand("SELECT firma_adi FROM firmalar ", SqlBaglanti.baglanti);
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

                //boş kontrol
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
                            HataBox.text = "";
                            f1.hataresim.Visible = true;
                            f1.onayresim.Visible = false;
                            f1.Show();
                        }
                        else
                        {

                            koltuk = koltukbox.Text;
                            //ucak verileri kaydetme
                            SqlBaglanti.baglanti.Close();
                            SqlBaglanti.baglanti.Open();
                            MySqlCommand ucakekleme = new MySqlCommand("INSERT INTO ucaklar (ucak_plaka, ucak_koltuksayisi, firmalar_firmalar_id) VALUES ('" + plaka + "','" + koltuk + "','" + int.Parse(firmaid) + "')", SqlBaglanti.baglanti);
                            ucakekleme.ExecuteNonQuery();
                            SqlBaglanti.baglanti.Close();
                            HataBox f = new HataBox();
                            HataBox.mesaj = "Uçak ekleme";
                            HataBox.text = "Uçak Başarıyla eklendi";
                            f.hataresim.Visible = false;
                            f.onayresim.Visible = true;

                            f.Show();
                        }

                    }

                }
                else
                {
                    HataBox f1 = new HataBox();
                    HataBox.mesaj = "Veri hatası";
                    HataBox.text = "Lütfen Gerekli Alanları Doldurunuz";
                    f1.hataresim.Visible = true;
                    f1.onayresim.Visible = false;
                    f1.Show();
                }

            }
            catch (Exception ex)

            {

            }

        }
        public void firmabox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String secim;

            // seçilen uçağın logosunu getirme

            secim = firmabox.SelectedItem.ToString();
            if (secim == "Pegasus")
            {
                logobox.Image = Image.FromFile(Application.StartupPath + "\\pegasus.png");
                logobox.Refresh();
            }
            else if (secim == "Türk Hava Yolları")
            {

                logobox.Image = Image.FromFile(Application.StartupPath + "\\turkishairlines.png");
                logobox.Refresh();
            }
            else if (secim == "Sunexpress")
            {
                logobox.Image = Image.FromFile(Application.StartupPath + "\\sunexpress.png");
                logobox.Refresh();
            }

            else if (secim == "AnadoluJet")
            {
                logobox.Image = Image.FromFile(Application.StartupPath + "\\anadolujet.png");
                logobox.Refresh();
            }

            firmaadi = firmabox.SelectedItem.ToString();
            //firma id alma
            SqlBaglanti.baglanti.Close();
            SqlBaglanti.baglanti.Open();
            MySqlCommand kontrolfirmaid = new MySqlCommand("SELECT firmalar_id FROM firmalar WHERE (firma_adi=@firmaadi) ", SqlBaglanti.baglanti);
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
