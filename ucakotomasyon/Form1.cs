﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace ucakotomasyon
{

    public partial class Form1 : Form
    {

        internal void kayitbuton2_Click()
        {
            throw new NotImplementedException();
        }

        int sayac = 0;
        public static String _tcno, _mail, _sifre, _ad, _soyad, _telefon, _dogumtarihi, _cinsiyet, _sikayetmetin, _sikayetmail;

        //tc kontrol fonksiyonu
        public bool TcKontrol()
        {
            
            _tcno = _tcno.Trim();
            if (_tcno.Length != 11)
            {
                txtgiris.Focus();
                return false;
            }
            int[] sayilar = new int[11];
            for (int i = 0; i < _tcno.Length; i++)
            {
                sayilar[i] = Int32.Parse(_tcno[i].ToString());
            }
            int toplam = 0;
            for (int i = 0; i < _tcno.Length - 1; i++)
            {
                toplam += sayilar[i];
            }
            if (toplam.ToString()[1].ToString() == sayilar[10].ToString() & sayilar[10] % 2 == 0)
            {
                return true;
            }
            else
            {
                txtgiris.Focus();
                return false;
            }
        }
        //tc kontrol fonksiyonu bitiş
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void guna2GradientPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void guna2GradientPanel1_MouseEnter(object sender, EventArgs e)
        {
            // txt içi yazıların düzenlenmesi

            if (txtgirissifre.Text.Equals(""))
            {
                txtgirissifre.Text = "Şifre";
                txtgirissifre.PasswordChar = '\0';
                sayac = 0;
            }

            if (txtgiris.Text.Equals(""))
            {
                txtgiris.Text = "T.C. Kimlik Numarası";
            }

            if (mailtext.Text.Equals(""))
            {
                mailtext.Text = "Mail Adresi";
            }
            if (adbox.Text.Equals(""))
            {
                adbox.Text = "Ad";
            }
            if (soyadbox.Text.Equals(""))
            {
                 soyadbox.Text = "Soyad";
            }



        }
        private void txtgirissifre_KeyPress(object sender, KeyPressEventArgs e)
        {

            // txt içi yazıların düzenlenmesi

            if (sayac == 0)
            {
                txtgirissifre.Clear();
                sayac++;

            }

            if (txtgirissifre.Text.Equals(""))
            {
                txtgirissifre.PasswordChar = '\0';
            }
            else
            {
                txtgirissifre.PasswordChar = '*';
            }

        }

        private void txtgiris_KeyPress(object sender, KeyPressEventArgs e)
        {
            // txt içi yazıların düzenlenmesi

            if (txtgiris.Text.Equals("T.C. Kimlik Numarası"))
            {
                txtgiris.Clear();
            }
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void mailtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            // txt içi yazıların düzenlenmesi

            if (mailtext.Text.Equals("Mail Adresi"))
            {
                mailtext.Clear();
            }

        }



        private void girisbuton_MouseDown(object sender, MouseEventArgs e)
        {

        }
        public static String kisiid, kisitc = "";

        private void adbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (adbox.Text.Equals("Ad"))
            {
                adbox.Clear();
            }

        }

        private void soyadbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (soyadbox.Text.Equals("Soyad"))
            {
                soyadbox.Clear();
            }
        }

        private void cikisbuton_Click(object sender, EventArgs e)
        {

            Application.Exit();
            
        }

        private void girisbuton_Click(object sender, EventArgs e)
        {

            //giriş ekranı veritabanı tc şifre kontrolü
            _tcno = txtgiris.Text;
            _sifre = txtgirissifre.Text;

            SqlBaglanti.baglanti.Close();
            SqlBaglanti.baglanti.Open();
            MySqlCommand kontroltc = new MySqlCommand("SELECT yolcu_tc,yolcu_sifre FROM yolcular WHERE (yolcu_tc = @tc AND yolcu_sifre = @sifre)", SqlBaglanti.baglanti);
            kontroltc.Parameters.AddWithValue("@tc", _tcno);
            kontroltc.Parameters.AddWithValue("@sifre", _sifre);
            MySqlDataReader dr = kontroltc.ExecuteReader();

            if (dr.Read())
            {
                kisitc = _tcno;
                HataBox.mesaj = "Giriş başarılı";
                HataBox.text = "Giriş Yapıldı";
                HataBox hataform = new HataBox();
                this.Hide();
                AnaSayfa anasayfaform = new AnaSayfa();
                anasayfaform.Show();
                hataform.hataresim.Visible = false;
                hataform.onayresim.Visible = true;
                hataform.Show();
            }
            else
            {
                HataBox.mesaj = "Hatalı Giriş";
                HataBox.text = "Kullanıcı Adı Veya Şifre Hatalı!";
                HataBox f = new HataBox();
                f.Show();
            }
            if (kisitc != "")
            {
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlCommand idkontrol = new MySqlCommand("SELECT yolcu_id FROM yolcular WHERE (yolcu_tc = @tc)", SqlBaglanti.baglanti);
                idkontrol.Parameters.AddWithValue("@tc", kisitc);
                MySqlDataReader dr1 = idkontrol.ExecuteReader();

                if (dr1.Read())
                {
                    kisiid = dr1["yolcu_id"].ToString();
                }
               SqlBaglanti.baglanti.Close();
            }
            //giriş ekranı veritabanı tc şifre kontrolü bitiş


        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            //adminpanel girişi
            AdminGiris adminpanelgiris = new AdminGiris();
            adminpanelgiris.Show();


        }
        private void maildestekbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (maildestekbox.Text.Equals("Mail Adresi"))
            {
                maildestekbox.Clear();
            }
        }

        private void destekbutonn_MouseDown(object sender, MouseEventArgs e)
        {


            // destek buton görünüm ayarlama
            if ((destekbox.Visible == true) || (destekboxcerceve.Visible == true) || (destekgonderb.Visible == true || maildestekbox.Visible == true))
            {
                destekbox.Visible = false;
                destekboxcerceve.Visible = false;
                destekgonderb.Visible = false;
                maildestekbox.Visible = false;
                destekbox.Clear();
            }
            else
            {
                destekbox.Visible = true;
                destekboxcerceve.Visible = true;
                destekgonderb.Visible = true;
                maildestekbox.Visible = true;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            destekbox.Visible = false;
            destekboxcerceve.Visible = false;
            destekgonderb.Visible = false;
            maildestekbox.Visible = false;
            if (maildestekbox.Text.Equals(""))
            {
                maildestekbox.Text = "Mail Adresi";

            }
            destekbox.Clear();
        }

        private void destekgonderb_MouseDown(object sender, MouseEventArgs e)
        {

            //destek veritabanı bağlantısı
            _sikayetmail = maildestekbox.Text;
            _sikayetmetin = destekbox.Text;

            SqlBaglanti.baglanti.Close();
            SqlBaglanti.baglanti.Open();
            MySqlCommand sikayetkomut = new MySqlCommand("INSERT INTO sikayetler (sikayet_metin,sikayet_mail) VALUES ('" + _sikayetmetin + "','" + _sikayetmail + "')", SqlBaglanti.baglanti);
            sikayetkomut.ExecuteNonQuery();
            SqlBaglanti.baglanti.Close();
            HataBox f = new HataBox();
            HataBox.mesaj = "Talep Oluşturuldu";
            HataBox.text = "Talebiniz başarılı bir şekilde \nGönderilmiştir!";
            f.hataresim.Visible = false;
            f.onayresim.Visible = true;

            f.Show();


            destekbox.Visible = false;
            destekboxcerceve.Visible = false;
            destekgonderb.Visible = false;
            maildestekbox.Visible = false;
            maildestekbox.Text = "Mail Adresi";
            destekbox.Clear();

        }
        private void kayitolbuton_Click(object sender, EventArgs e)
        {
            adbox.Visible = true;
            soyadbox.Visible = true;
            girisbuton.Visible = false;
            mailtext.Visible = true;
            kayitolbuton.Visible = false;
            kayitbuton2.Visible = true;
            geributon.Visible = true;
            txtgiris.BorderColor = Color.Red;
            txtgirissifre.BorderColor = Color.Red;
            mailtext.BorderColor = Color.Red;
            adbox.BorderColor = Color.Red;
            soyadbox.BorderColor = Color.Red;
        }



        // veritabanına yolcu kaydı yapan fonksiyon
        public void kayit()
        {
            

            //boş alan kontrol
            if (_tcno == "" || _sifre == "" || _mail == "" || _ad == "" || _soyad == "" || _tcno == "T.C Kimlik Numarası" || _sifre == "Şifre" || _mail == "Mail Adresi" || _ad == "Ad" || _soyad == "Soyad")
            {
                HataBox.mesaj = "Uyarı";
                HataBox.text = "Zorunlu alanlar boş geçilemez!";
                HataBox f = new HataBox();
                f.Show();

            }
            else
            {
                //tc kontrol
                if (TcKontrol() == false)
                {
                    errorProvider1.SetError(txtgiris, "Geçerli Bir Kimlik No Giriniz.");
                    HataBox.mesaj = "Yanlış Veri";
                    HataBox.text = "Lütfen Geçerli Bir T.C kimlik \nNumarası Giriniz";
                    HataBox f = new HataBox();
                    f.Show();

                }

                //tc veritabanına kayıtlı mı ?
                else if (TcKontrol() == true)
                {
                    SqlBaglanti.baglanti.Close();
                    SqlBaglanti.baglanti.Open();
                    MySqlCommand kayitkomuttc = new MySqlCommand("SELECT yolcu_tc FROM yolcular WHERE yolcu_tc = @tc", SqlBaglanti.baglanti);
                    kayitkomuttc.Parameters.AddWithValue("@tc", _tcno);
                    MySqlDataReader dr = kayitkomuttc.ExecuteReader();
                    if (dr.Read())
                    {
                        HataBox.mesaj = "Kayıt Hatası";
                        HataBox.text = "Bu T.C Kimlik Numarası \nZaten Kayıtlı";
                        HataBox f = new HataBox();
                        f.Show();
                    }

                    // tc veritabanında kayıtlı değilse 
                    else
                    {
                        //baglanti veri kaydı
                        errorProvider1.Clear();
                        SqlBaglanti.baglanti.Close();
                        SqlBaglanti.baglanti.Open();
                        MySqlCommand kayitkomut1 = new MySqlCommand("INSERT INTO yolcular (yolcu_tc,yolcu_mail,yolcu_sifre,cinsiyetler_cinsiyet_id,yolcu_adi,yolcu_soyadi) VALUES ('" + _tcno + "','" + _mail + "','" + _sifre + "','0','" + _ad + "','" + _soyad + "')", SqlBaglanti.baglanti);
                        kayitkomut1.ExecuteNonQuery();
                        SqlBaglanti.baglanti.Close();
                        HataBox f = new HataBox();
                        HataBox.mesaj = "Kayıt Başarılı";
                        HataBox.text = "Kaydınız başarılı bir şekilde \ntamamlanmıştır!";
                        f.hataresim.Visible = false;
                        f.onayresim.Visible = true;
                        f.Show();
                        // kayit ekranı geri çıkış

                        adbox.Visible = false;
                        soyadbox.Visible = false;
                        girisbuton.Visible = true;
                        mailtext.Visible = false;
                        kayitolbuton.Visible = true;
                        kayitbuton2.Visible = false;
                        geributon.Visible = false;
                        txtgiris.BorderColor = Color.Blue;
                        txtgirissifre.BorderColor = Color.Blue;
                        mailtext.BorderColor = Color.Blue;
                        adbox.BorderColor = Color.Blue;
                        soyadbox.BorderColor = Color.Blue;



                    }
                }
            }

        }
        public static int dogrulamakodu;
        // girilen verileri çekme ve doğrulama kodu için diğer forma gönderme
        public static String dogrulamamail;
        public void kayitbuton2_Click(object sender, EventArgs e)
        {

            _ad = Convert.ToString(adbox.Text);
            _soyad = Convert.ToString(soyadbox.Text);
            _tcno = Convert.ToString(txtgiris.Text);
            _sifre = Convert.ToString(txtgirissifre.Text);
            _mail = Convert.ToString(mailtext.Text);
            dogrulamamail = mailtext.Text;
            dogrulamaform dform = new dogrulamaform();
            

            try
            {
                Random rastgele = new Random();
                dogrulamakodu = rastgele.Next(100000, 999999);
                mailgonder mail = new mailgonder();
                String konu = "TUNEX TURİZM KAYIT DOĞRULAMA KODU";
                String icerik = "<html>" +
                                                       "<div align=center><img src = https://i.hizliresim.com/qeh85fy.png  width=350px height=100px   alt=\"TUNEX TURİZM\"></div>" +
                                                       " <head>" +
                                                       "  <meta http-equiv='Content-Type' content='text/html; charset=utf-8'/>" +
                                                       "  <style type='text/css'>" +

                                                       " .onayla" +
                                                       " {" +
                                                            " background-color:#33FFFF;" +
                                                            " cursor:pointer;" +
                                                            " height:50px;" +
                                                            "  width:398px;" +
                                                            " color:#FFFFFF;" +
                                                       " }" +
                                                       " .onayla:hover" +
                                                       " {" +
                                                            " background-color:#66CDAA;" +
                                                       " }" +
                                                       " .onayla:active" +
                                                       " {" +
                                                            " background-color:#2E8B57;" +
                                                       " }" +
                                                       " .onayla a" +
                                                       " {" +
                                                            " text-decoration:none;" +
                                                            " color:white;" +
                                                            " width:100%;" +
                                                            " height:100%;" +
                                                            " display:block;" +
                                                            " padding-top:13px;" +
                                                            " overflow:hidden;" +
                                                       " }" +


                                                       " .link1" +
                                                       " {" +
                                                            " background-color:#6633FF;" +
                                                            "cursor:pointer;" +
                                                            " height:50px;" +
                                                            " width:400px;" +
                                                            "color:#FFFFFF;" +
                                                       " }" +
                                                       " .link1:hover" +
                                                       " {" +
                                                            " background-color:#FFA07A;" +
                                                       " }" +
                                                       " .link1:active" +
                                                       " {" +
                                                            " background-color:#CD5C5C;" +
                                                       " }" +
                                                       " .link1 a" +
                                                       " {" +
                                                            " text-decoration:none;" +
                                                            " color:white;" +
                                                            " width:100%;" +
                                                            " height:100%;" +
                                                            " display:block;" +
                                                            " padding-top:13px;" +
                                                            " overflow:hidden;" +
                                                       " }" +


                                                       " .link2" +
                                                       " {" +
                                                            " background-color:#1E90FF;" +
                                                            " cursor:pointer;" +
                                                            " color:#FFFFFF;" +
                                                            " width:800px;" +
                                                            "height:50px;" +
                                                       " }" +
                                                       " .link2:hover" +
                                                       " {" +
                                                            " background-color:#00BFFF;" +
                                                       " }" +
                                                       " .link2:active" +
                                                       " {" +
                                                            " background-color:#0000FF;" +
                                                       " }" +
                                                       " .link2 a" +
                                                       " {" +
                                                            " text-decoration:none;" +
                                                            " color:white;" +
                                                            " width:100%;" +
                                                            " height:100%;" +
                                                            " display:block;" +
                                                            " padding-top:13px;" +
                                                            " overflow:hidden;" +
                                                       " }" +
                                                       " </style>" +
                                                       " </head>" +
                                                       " <body>" +
                                                         " <table border='1' cellpadding='0' cellspacing='0' align='center'>" +
                                                           " <tr>" +
                                                             " <td align='center' style='height:50px; width:800px;'  bgcolor='0066FF'><b><font color='FFFFFF'>TUNEX TURİZM HESAP OLUŞTURMA</font></b></td>" +
                                                           " </tr>" +
                                                         " </table>" +



                                                         " <table border='1' cellpadding='0' cellspacing='0' align='center'>" +
                                                           " <td align='center' height='30' width='800' bgcolor='DCDCDC'><b>DOĞRULAMA KODU  : "+dogrulamakodu+"</b></td>" +
                                                         " </table>" +





                                                         " <table border='1' cellpadding='0' style='height:50px; width:800px;' cellspacing='0' align='center'>" +
                                                           " <tr>" +
                                                             " <td class='onayla' align='center'> <a href='http://digitalepinsatis.com/prestashop/tr/'>Diğer Şirketlerimiz(DigitalE-PİN)</a> </td>" +
                                                             " <td class='link1' align='center'> <a href='https://www.instagram.com/emreekrnfl/'>Destek ve iletişim için Tıkla</a> </td>" +
                                                           " </tr>" +
                                                         " </table>" +

                                                         " <table border='1' cellpadding='0' cellspacing='0' align='center'>" +
                                                           " <td class='link2' align='center'> <a href='https://www.google.com'>Kullanım Şartları</a> </td>  " +
                                                         " </table> " +
                                                       " </body>" +
                                                       " </html>";
                mail.mailyolla(Form1.dogrulamamail, konu, icerik);

                HataBox uyari = new HataBox();
                HataBox.mesaj = "Mail Bilgilendirme";
                HataBox.text = "Doğrulama Kodu \n"+ dogrulamamail +" Mail \nAdresinize Gönderilmiştir.";
                uyari.onayresim.Visible = true;
                uyari.hataresim.Visible = false;
                dform.Show();
                uyari.Show();

                adbox.Visible = false;
                soyadbox.Visible = false;
                girisbuton.Visible = true;
                mailtext.Visible = false;
                kayitolbuton.Visible = true;
                kayitbuton2.Visible = false;
                geributon.Visible = false;
                txtgiris.BorderColor = Color.Blue;
                txtgirissifre.BorderColor = Color.Blue;
                mailtext.BorderColor = Color.Blue;
                adbox.BorderColor = Color.Blue;
                soyadbox.BorderColor = Color.Blue;

            }
            catch
            {

                HataBox uyari = new HataBox();
                HataBox.mesaj = "Mail Bilgilendirme";
                HataBox.text = "Doğrulama Kodu Gönderilemedi Lütfen \nDoğru Mail Adresi Girdiğinizden\n Emin Olun";
                uyari.onayresim.Visible = false;
                uyari.hataresim.Visible = true;
                uyari.Show();
            }

        }

        public void geributon_Click(object sender, EventArgs e)
        {
            adbox.Visible = false;
            soyadbox.Visible = false;
            girisbuton.Visible = true;
            mailtext.Visible = false;
            kayitolbuton.Visible = true;
            kayitbuton2.Visible = false;
            geributon.Visible = false;
            txtgiris.BorderColor = Color.Blue;
            txtgirissifre.BorderColor = Color.Blue;
        }
    }
}
