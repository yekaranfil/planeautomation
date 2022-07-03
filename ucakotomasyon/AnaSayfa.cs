﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Collections;

namespace ucakotomasyon
{

    public partial class AnaSayfa : Form
    {
        public static String nereden, nereye, tarih,kisisayisi, biletucusid, biletturu, secilenucakid, koltuksayisi,yolcumail,tutar,mailnereden,mailnereye;
        public static int kisiindex;
        int satirsayisi, ucusid;
        DataTable tablo = new DataTable();
        DataSet data = new DataSet();
        ArrayList iddizi = new ArrayList();
        ArrayList firmaiddizi = new ArrayList();

        public AnaSayfa()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void guna2ControlBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void secenekbuton_Click(object sender, EventArgs e)
        {
            //componentlerin görünürlüğünü ayarlama
            satinalbtn.Visible = false;
            islemlerpanel.Visible = false;
            tunexlogo.Visible = false;
            anamenulabel2.Visible = false;
            neredenbox.Visible = true;
            nereyebox.Visible = true;
            nereyetxt.Visible = true;
            neredentxt.Visible = true;
            ucakicon.Visible = true;
            kisisayilbl.Visible = true;
            kisibox.Visible = true;
            ekonomilbl.Visible = true;
            ekonomiradiobtn.Visible = true;
            bussineslbl.Visible = true;
            bussinesradiobtn.Visible = true;
            tekyonlbl.Visible = true;
            tekyonradiobtn.Visible = true;

            neredentxt.Visible = true;
            nereyetxt.Visible = true;
            ucusarabtn.Visible = true;

        }
        private void tekyonradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            //componentlerin görünürlüğünü ayarlama

            gidistarihbox.Visible = true;
            gidistarihlbl.Visible = true;




            gidisgelisicon.Visible = false;
        }
        private void gidisdonusradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            //componentlerin görünürlüğünü ayarlama

            gidistarihbox.Visible = true;
            gidistarihlbl.Visible = true;

            gidisgelisicon.Visible = true;

        }

        public static String isim, soyisim;
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            try
            {
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlCommand adbilgi = new MySqlCommand("SELECT yolcu_adi,yolcu_soyadi,yolcu_mail FROM yolcular WHERE yolcu_tc=@yolcu", SqlBaglanti.baglanti);
                adbilgi.Parameters.AddWithValue("@yolcu", Form1._tcno);
                MySqlDataReader dr = adbilgi.ExecuteReader();
                while (dr.Read())
                {
                    isim = dr["yolcu_adi"].ToString(); 
                    soyisim = dr["yolcu_soyadi"].ToString();
                    yolcumail = dr["yolcu_mail"].ToString();
                   
                }
            }
            catch (Exception ex)

            {

            }




            isimlbl.Visible = true;
            soyisimlbl.Visible = true;
            isimlbl.Text = isim;
            soyisimlbl.Text = soyisim;

            //combobox şehir bilgisi çekme
            try
            {
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlCommand sehirbilgi = new MySqlCommand("SELECT sehir_ad FROM sehirler", SqlBaglanti.baglanti);
                MySqlDataReader dr = sehirbilgi.ExecuteReader();
                while (dr.Read())
                {

                    neredenbox.Items.Add(dr["sehir_ad"]);
                    nereyebox.Items.Add(dr["sehir_ad"]);


                }
            }
            catch (Exception ex)

            {

            }
            //combobox şehir bilgisi çekme bitiş


        }

        private void neredenbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            mailnereden = neredenbox.SelectedItem.ToString();
           

            // combobox şehir çakışma kontrol
            String secim1, secim2;
            secim1 = neredenbox.SelectedItem.ToString();
            secim2 = neredenbox.SelectedItem.ToString();

            nereyebox.Items.Clear();
            try
            {
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlCommand sehirbilgi = new MySqlCommand("SELECT sehir_ad FROM sehirler", SqlBaglanti.baglanti);
                MySqlDataReader dr = sehirbilgi.ExecuteReader();
                while (dr.Read())
                {
                    //comboboxa sehir doldurma
                    nereyebox.Items.Add(dr["sehir_ad"]);

                }
            }
            catch (Exception ex)
            {

            }

            nereyebox.Items.Remove(secim1);

            // combobox şehir çakışma kontrol bitiş


            //şehir id çekme
            try
            {
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlCommand sehirid = new MySqlCommand("SELECT sehir_id FROM sehirler WHERE (sehir_ad=@sehirad)", SqlBaglanti.baglanti);
                sehirid.Parameters.AddWithValue("@sehirad", neredenbox.Text);
                MySqlDataReader dr = sehirid.ExecuteReader();
                while (dr.Read())
                {
                   //sehir id alma
                    nereden = (dr["sehir_id"]).ToString();

                }
            }
            catch (Exception ex)

            {

            }


            // şehir id çekme
            try
            {

                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlCommand sehirid = new MySqlCommand("SELECT sehir_id FROM sehirler WHERE (sehir_ad=@sehirad)", SqlBaglanti.baglanti);
                sehirid.Parameters.AddWithValue("@sehirad", nereyebox.Text);
                MySqlDataReader dr = sehirid.ExecuteReader();
                while (dr.Read())
                {
                    //seçilen hücrenin içindeki şehrin adını lbl yazdırma
                    nereye = (dr["sehir_id"]).ToString();

                }
            }
            catch (Exception ex)

            {
                HataBox f = new HataBox();
                HataBox.mesaj = "Uçuş arama";
                HataBox.text = "Hatalı Seçim";
                f.hataresim.Visible = true;
                f.onayresim.Visible = false;
                f.Show();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 n = new Form1();
            n.Show();
            this.Close();
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

        public static String mailfirmaismi,mailucustarih,mailucussaat;
        private void ucustable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //satir sayısı alma
            satirsayisi = e.RowIndex;
            try
            {
                // logo getirme
                if (ucustable.Rows[satirsayisi].Cells[0].Value.ToString().Equals("Pegasus"))
                {
                    mailfirmaismi = ucustable.Rows[satirsayisi].Cells[0].Value.ToString();
                    logobox.Image = Image.FromFile(Application.StartupPath + "\\pegasus.png");
                    logobox.Refresh();
                }
                else if (ucustable.Rows[satirsayisi].Cells[0].Value.ToString().Equals("Türk Hava Yolları"))
                {
                    mailfirmaismi = ucustable.Rows[satirsayisi].Cells[0].Value.ToString();
                    logobox.Image = Image.FromFile(Application.StartupPath + "\\turkishairlines.png");
                    logobox.Refresh();
                }
                else if (ucustable.Rows[satirsayisi].Cells[0].Value.ToString().Equals("Sunexpress"))
                {
                    mailfirmaismi = ucustable.Rows[satirsayisi].Cells[0].Value.ToString();
                    logobox.Image = Image.FromFile(Application.StartupPath + "\\sunexpress.png");
                    logobox.Refresh();
                }

                else if (ucustable.Rows[satirsayisi].Cells[0].Value.ToString().Equals("AnadoluJet"))
                {
                    mailfirmaismi = ucustable.Rows[satirsayisi].Cells[0].Value.ToString();
                    logobox.Image = Image.FromFile(Application.StartupPath + "\\anadolujet.png");
                    logobox.Refresh();
                }
            } catch
            {

            }
            // seçilen bilet türünü değişkene atma

            if (ekonomiradiobtn.Checked == true)

            {
                tutar = ucustable.Rows[satirsayisi].Cells[7].Value.ToString();
                
                biletturu = "EKONOMİ";



            }
            else if (bussinesradiobtn.Checked == true)
            {
                tutar = ucustable.Rows[satirsayisi].Cells[8].Value.ToString();
                biletturu = "BUSSİNES";

            }
            // tablodan gerekli verileri değişkenlere atma
            biletucusid = ucustable.Rows[satirsayisi].Cells[1].Value.ToString();
            secilenucakid = ucustable.Rows[satirsayisi].Cells[9].Value.ToString();
            satinalbtn.Visible = true;

            mailucustarih = ucustable.Rows[satirsayisi].Cells[5].Value.ToString();
            mailucussaat = ucustable.Rows[satirsayisi].Cells[4].Value.ToString();




        }
        
        
        private void satinalbtn_Click(object sender, EventArgs e)
        {       
            try
            {
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlCommand koltuksayikontrol = new MySqlCommand("SELECT ucak_koltuksayisi FROM ucaklar WHERE (ucak_id=@ucakid)", SqlBaglanti.baglanti);
                koltuksayikontrol.Parameters.AddWithValue("@ucakid", secilenucakid);
                MySqlDataReader dr = koltuksayikontrol.ExecuteReader();
                if (dr.Read())
                {
                   // seçilen uçuşun uçağının şablonuu getirmek için ucak koltuk sayısını alma
                    koltuksayisi = (dr["ucak_koltuksayisi"]).ToString();
                }

            }
            catch (Exception ex)

            {



            }

            // seçilen uçağın koltuk sayısına göre bilet alma ekranı getirme
            if(koltuksayisi == "40")
            {

                HataBox hataform = new HataBox();
             

                _40koltukform secim1 = new _40koltukform();
                secim1.Show();
              

                if (ekonomiradiobtn.Checked == true)
                {

                    secim1.ekonomigrup.Enabled = true;
                    secim1.bussinesgrup.Enabled = false;


                }
                else if (bussinesradiobtn.Checked == true)
                { 
                    secim1.bussinesgrup.Enabled = true;
                    secim1.ekonomigrup.Enabled = false;
                }
            }
            // seçilen uçağın koltuk sayısına göre bilet alma ekranı getirme
            else if (koltuksayisi =="56")
            {

                

                _56koltukform secim2 = new _56koltukform();
                secim2.Show();
                

                
                if (ekonomiradiobtn.Checked == true)
                {

                    secim2.ekonomigrup.Enabled = true;
                    secim2.bussinesgrup.Enabled = false;


                }
                else if (bussinesradiobtn.Checked == true)
                {
                    secim2.bussinesgrup.Enabled = true;
                    secim2.ekonomigrup.Enabled = false;
                }


            }
            // seçilen uçağın koltuk sayısına göre bilet alma ekranı getirme
            else if (koltuksayisi == "72")
            {

                HataBox hataform = new HataBox();
             

                _72koltukform secim3 = new _72koltukform();
                secim3.Show();
           
                if (ekonomiradiobtn.Checked == true)
                {
                    secim3.ekonomi.Enabled = true;
                    secim3.bussinesgrup.Enabled = false;


                }
                else if (bussinesradiobtn.Checked == true)
                {
                    secim3.bussinesgrup.Enabled = true;
                    secim3.ekonomi.Enabled = false;
                }
            }

        }

        private void secenekbuton1_Click(object sender, EventArgs e)
        {
            satinalbtn.Visible = false;

            tunexlogo.Visible = false;
            anamenulabel2.Visible = false;
            //seçilen menü için ekrana paneli basma
            islemlerpanel.Visible = true;
            islemlerpanel.Controls.Clear();
            BiletlerForm biletform = new BiletlerForm();
            biletform.TopLevel = false;
            islemlerpanel.Controls.Add(biletform);
            biletform.Show();
            biletform.Dock = DockStyle.Fill;
            biletform.BringToFront();
        }

        private void secenekbuton2_Click(object sender, EventArgs e)
        {
            satinalbtn.Visible = false;

            tunexlogo.Visible = false;
            anamenulabel2.Visible = false;
            //seçilen menü için ekrana paneli basma

            islemlerpanel.Visible = false;
            islemlerpanel.Visible = true;
            islemlerpanel.Controls.Clear();
            BiletiptalForm biletiptalform = new BiletiptalForm();
            biletiptalform.TopLevel = false;
            islemlerpanel.Controls.Add(biletiptalform);
            biletiptalform.Show();
            biletiptalform.Dock = DockStyle.Fill;
            biletiptalform.BringToFront();
        }

        private void kisibox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //kişi sayısını alma
            kisisayisi = kisibox.SelectedItem.ToString();
            kisiindex = kisibox.SelectedIndex;
        }

        private void ucusarabtn_Click(object sender, EventArgs e)
        {
            // ucustablosuna firma adı ekleme
            try
            {
                ucustable.ColumnCount = 1;
                ucustable.Columns[0].Name = "firmaadı";
                ucustable.Columns[0].ValueType = typeof(String);
            }
            catch
            {

            }
            // ucustablosuna label gizleme
            ucustable.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;


            // Ekonomi veya bussines seçilmişse işlemde devam et
            if (ekonomiradiobtn.Checked == true || bussinesradiobtn.Checked == true )
            {
                tablo.Clear();
                ucustable.DataSource = tablo;
                ucustable.Refresh();

                gidistarihbox.Format = DateTimePickerFormat.Custom;
                gidistarihbox.CustomFormat = "yyyy-MM-dd";
                tarih = gidistarihbox.Text;

                try
                {
                    SqlBaglanti.baglanti.Close();
                    SqlBaglanti.baglanti.Open();
                    MySqlCommand ucusidgetir = new MySqlCommand("SELECT ucus_id FROM ucuslar WHERE (ucus_neredenID=@neredenid and ucus_nereyeID=@nereyeid and ucus_tarih=@ucustarih)", SqlBaglanti.baglanti);
                    ucusidgetir.Parameters.AddWithValue("@neredenid", nereden);
                    ucusidgetir.Parameters.AddWithValue("@nereyeid", nereye);
                    ucusidgetir.Parameters.AddWithValue("@ucustarih", tarih);
                    MySqlDataReader dr = ucusidgetir.ExecuteReader();
                    while (dr.Read())
                    {
                        //seçilen hücrenin içindeki şehrin adını lbl yazdırma
                        String ucus = (dr["ucus_id"]).ToString();
                        ucusid = int.Parse(ucus);
                        iddizi.Add(ucusid);
                    }
                    SqlBaglanti.baglanti.Close();
                }
                catch (Exception ex)

                {



                }


                int secim = 0;
                RadioButton rb = null;

                // ekonomi seçildiyse ekonomiye göre tabloyu düzenleme
                if (ekonomiradiobtn.Checked == true)
                {
                    tablo.Clear();
                    ucustable.DataSource = tablo;
                    ucustable.Refresh();

                    try
                    {

                        //Tabloya uçuşları listeleme
                        SqlBaglanti.baglanti.Close();
                        SqlBaglanti.baglanti.Open();

                        // dizideki ucusid ile ucusları listeleme
                        for (int i = 0; i < iddizi.Count; i++)
                        {

                            MySqlDataAdapter dr = new MySqlDataAdapter("SELECT * FROM ucuslar WHERE (ucus_id=@ucusid)", SqlBaglanti.baglanti);
                            dr.SelectCommand.Parameters.AddWithValue("@ucusid", iddizi[i]);
                            data = new DataSet();
                            dr.Fill(tablo);
                            ucustable.DataSource = tablo;
                            
                            firmaiddizi.Add(ucustable.Rows[i].Cells[10].Value.ToString());

                            String a = firmaiddizi[i].ToString();

                            if (a == "1")
                            {
                                ucustable.Rows[i].Cells[0].Value = "Pegasus";
                            }

                            else if (a == "2")
                            {
                                ucustable.Rows[i].Cells[0].Value = "Türk Hava Yolları";
                            }
                            else if (a == "3")
                            {
                                ucustable.Rows[i].Cells[0].Value = "Sunexpress";
                            }
                            else if (a == "4")
                            {
                                ucustable.Rows[i].Cells[0].Value = "AnadoluJet";
                            } else
                            {

                                HataBox f = new HataBox();
                                HataBox.mesaj = "Uçuş Arama Hatası";
                                HataBox.text = "Lütfen Bilet Türü Seçiniz";
                                f.hataresim.Visible = true;
                                f.onayresim.Visible = false;
                                f.Show();
                            }




                        }

                        iddizi.Clear();
                        firmaiddizi.Clear();
                        ucustable.Columns[1].Visible = false;
                        ucustable.Columns[2].Visible = false;
                        ucustable.Columns[3].Visible = false;
                        ucustable.Columns[7].Visible = true;
                        ucustable.Columns[8].Visible = false;
                        ucustable.Columns[9].Visible = false;
                        ucustable.Columns[10].Visible = false;


                    }
                    catch (Exception ex)
                    {

                    }
                }

                // bussines seçildiyse bussinesa göre tabloyu listeleme
                else if (bussinesradiobtn.Checked == true)
                {
                    tablo.Clear();
                    ucustable.DataSource = tablo;
                    ucustable.Refresh();

                    try
                    {
                        //Tabloya uçuşları listeleme
                        SqlBaglanti.baglanti.Close();
                        SqlBaglanti.baglanti.Open();

                        for (int i = 0; i < iddizi.Count; i++)
                        {
                            MySqlDataAdapter dr = new MySqlDataAdapter("SELECT * FROM ucuslar WHERE (ucus_id=@ucusid)", SqlBaglanti.baglanti);
                            dr.SelectCommand.Parameters.AddWithValue("@ucusid", iddizi[i]);
                            data = new DataSet();
                            dr.Fill(tablo);
                            ucustable.DataSource = tablo;

                            firmaiddizi.Add(ucustable.Rows[i].Cells[10].Value.ToString());

                            String a = firmaiddizi[i].ToString();

                            if (a == "1")
                            {
                                ucustable.Rows[i].Cells[0].Value = "Pegasus";
                            }

                            else if (a == "2")
                            {
                                ucustable.Rows[i].Cells[0].Value = "Türk Hava Yolları";
                            }
                            else if (a == "3")
                            {
                                ucustable.Rows[i].Cells[0].Value = "Sunexpress";
                            }
                            else if (a == "4")
                            {
                                ucustable.Rows[i].Cells[0].Value = "AnadoluJet";
                            }
                            else
                            {

                                HataBox f = new HataBox();
                                HataBox.mesaj = "Uçuş Arama Hatası";
                                HataBox.text = "Lütfen Bilet Türü Seçiniz";
                                f.hataresim.Visible = true;
                                f.onayresim.Visible = false;
                                f.Show();
                            }
                        }
                        iddizi.Clear();
                        firmaiddizi.Clear();
                        ucustable.Columns[1].Visible = false;
                        ucustable.Columns[2].Visible = false;
                        ucustable.Columns[3].Visible = false;
                        ucustable.Columns[7].Visible = false;
                        ucustable.Columns[8].Visible = true;
                        ucustable.Columns[9].Visible = false;
                        ucustable.Columns[10].Visible = false;
                    }
                    catch (Exception ex)
                    {

                    }
                }
                else
                {
                    tablo.Clear();
                    ucustable.DataSource = tablo;
                    ucustable.Refresh();
                }
            }
            else
            {
                HataBox f = new HataBox();
                HataBox.mesaj = "Uçuş Arama Hatası";
                HataBox.text = "Lütfen Bilet Türü Seçiniz";
                f.hataresim.Visible = true;
                f.onayresim.Visible = false;
                f.Show();
            }

        }

        private void nereyebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mailnereye = nereyebox.SelectedItem.ToString();
            //şehir id çekme
            try
            {
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlCommand sehiridcekme = new MySqlCommand("SELECT sehir_id FROM sehirler WHERE (sehir_ad=@sehirad)", SqlBaglanti.baglanti);
                sehiridcekme.Parameters.AddWithValue("@sehirad", neredenbox.Text);
                MySqlDataReader dr = sehiridcekme.ExecuteReader();
                while (dr.Read())
                {
                    //seçilen hücrenin içindeki şehrin adını lbl yazdırma
                    nereden = (dr["sehir_id"]).ToString();

                }
            }
            catch (Exception ex)

            {

            }

            // şehir id çekme
            try
            {

                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlCommand sehiridcekme = new MySqlCommand("SELECT sehir_id FROM sehirler WHERE (sehir_ad=@sehirad)", SqlBaglanti.baglanti);
                sehiridcekme.Parameters.AddWithValue("@sehirad", nereyebox.Text);
                MySqlDataReader dr = sehiridcekme.ExecuteReader();
                while (dr.Read())
                {
                    //seçilen hücrenin içindeki şehrin adını lbl yazdırma
                    nereye = (dr["sehir_id"]).ToString();

                }
            }
            catch (Exception ex)

            {
                HataBox f = new HataBox();
                HataBox.mesaj = "Uçuş Arama";
                HataBox.text = "Hatalı Seçim";
                f.hataresim.Visible = true;
                f.onayresim.Visible = false;
                f.Show();
            }
        }
    }
}
