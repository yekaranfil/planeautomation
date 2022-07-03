using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucakotomasyon
{
    public partial class _40koltukform : Form
    {
        public _40koltukform()
        {
            InitializeComponent();
        }
        public List<String> butonlist = new List<String>();
        public List<String> secilenler = new List<String>();
        public List<String> secilenkoltuk = new List<String>();
        String mailtext, konu;
        int sayac = 0;
        int kisi;
        int secilensayac = 0;
        String bltid = "";

        String dolu = "DOLU";
        String dolukoltukid;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void secilenkoltuklbl_Click(object sender, EventArgs e)
        {

        }
        void LogAl()
        {
            //koltukların dolu boş kontrolünü yapma
            SqlBaglanti.baglanti.Close();
            SqlBaglanti.baglanti.Open();      
            MySqlCommand dolukoltuk = new MySqlCommand("SELECT koltuklar_koltuk_id FROM koltuklar_has_ucaklar WHERE dolubos=@doluluk AND ucuslar_ucus_id=@ucus", SqlBaglanti.baglanti);
            dolukoltuk.Parameters.AddWithValue("@doluluk", dolu);
            dolukoltuk.Parameters.AddWithValue("@ucus", AnaSayfa.biletucusid);
            MySqlDataReader dr1 = dolukoltuk.ExecuteReader();
            while (dr1.Read())
            {
                //dolu koltukları kırmızı yapma
                string koltuk_No = dr1["koltuklar_koltuk_id"].ToString();     
                Button s = this.Controls.Find("Koltuk_" + koltuk_No, true).FirstOrDefault() as Button;
                s.BackgroundImage = ucakotomasyon.Properties.Resources.Dolu1;
                s.Enabled = false;
            }
            SqlBaglanti.baglanti.Close();
        }

        public void btn_Click(object sender, EventArgs e)
        {
            //kişi kontrol
            if (AnaSayfa.kisiindex == 0)
            {
                kisi = 1;
            }
            else
            {
                kisi = int.Parse(AnaSayfa.kisisayisi);
            }

            // KOLTUK SEÇERKENKİ RENK AYARLAMALARI
            sayac++;
            Button btn = (Button)sender;

            if (sayac < kisi + 1)
            {
                if (btn.ForeColor == Color.White)
                {
                    btn.BackgroundImage = ucakotomasyon.Properties.Resources.Secili1;
                    btn.ForeColor = Color.Green;
                    secilenkoltuk.Add(btn.Text);
                    secilenler.Add(btn.Name);
                    koltuklbl.Text += secilenler[0].ToString() + " - ";
                    secilenler.Clear();
                }
                else
                {
                    if (btn.ForeColor == Color.Green)
                    {
                        sayac = 0;
                        String degisken = koltuklbl.Text.Substring(0, koltuklbl.Text.Length - (btn.Name.Length + 3));
                        btn.BackgroundImage = ucakotomasyon.Properties.Resources.Bos1;
                        secilenler.Remove(btn.Name);
                        secilenkoltuk.Remove(btn.Text.ToString());
                        koltuklbl.Text = degisken;
                        btn.ForeColor = Color.White;
                    }
                }

            }
            else
            {
                if (btn.ForeColor == Color.Green)
                {
                    sayac = 0;
                    String degisken = koltuklbl.Text.Substring(0, koltuklbl.Text.Length - (btn.Name.Length + 3));
                    btn.BackgroundImage = ucakotomasyon.Properties.Resources.Bos1;
                    secilenler.Remove(btn.Name);
                    secilenkoltuk.Remove(btn.Text.ToString());
                    koltuklbl.Text = degisken;
                    btn.ForeColor = Color.White;
                }
            }



        }

        private void ustpanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        String faturatarihi;
        private void satinalbtn_Click(object sender, EventArgs e)
        {
            faturatarihi = DateTime.Now.ToString();
            for (int i = 0; i < secilenkoltuk.Count; i++)
            {
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                //boş bilet kaydı oluşturma
                MySqlCommand biletekle = new MySqlCommand("INSERT INTO biletler (biletadi) VALUES ('" + "a" + "')", SqlBaglanti.baglanti);
                biletekle.ExecuteNonQuery();
                SqlBaglanti.baglanti.Close();

                //boş bilet id çekme
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlCommand biletcek = new MySqlCommand("SELECT bilet_id FROM biletler ORDER BY bilet_id DESC", SqlBaglanti.baglanti);
                MySqlDataReader dr1 = biletcek.ExecuteReader();
                if (dr1.Read())
                {
                    bltid = dr1["bilet_id"].ToString();

                }
                SqlBaglanti.baglanti.Close();

                //bilet kaydı yapma
                SqlBaglanti.baglanti.Open();

                MySqlCommand biletkayit = new MySqlCommand("INSERT INTO biletler_has_yolcular (biletler_bilet_id,yolcular_yolcu_id,ucuslar_ucus_id, koltukno,bilettur) VALUES ('" + bltid + "','" + Form1.kisiid + "','" + AnaSayfa.biletucusid + "','" + secilenkoltuk[i].ToString() + "','" + AnaSayfa.biletturu + "' )", SqlBaglanti.baglanti);
                biletkayit.ExecuteNonQuery();
                SqlBaglanti.baglanti.Close();

                try
                {

                    SqlBaglanti.baglanti.Close();
                    SqlBaglanti.baglanti.Open();
                    MySqlCommand ucakekleme = new MySqlCommand("UPDATE koltuklar_has_ucaklar SET dolubos='DOLU' WHERE koltuklar_koltuk_id=@koltukid AND ucuslar_ucus_id=@ucusid", SqlBaglanti.baglanti);
                    ucakekleme.Parameters.AddWithValue("@ucusid", AnaSayfa.biletucusid);
                    ucakekleme.Parameters.AddWithValue("@koltukid", secilenkoltuk[i]);
                    ucakekleme.ExecuteNonQuery();
                    SqlBaglanti.baglanti.Close();

                    HataBox f = new HataBox();
                    HataBox.mesaj = "Bilet bilgisi";
                    HataBox.text = "Biletiniz Başarıyla Kaydedilmiştir\nDetaylı Bilgileri Biletlerim\nSekmesinde Bulabilirsiniz.";
                    f.hataresim.Visible = false;
                    f.onayresim.Visible = true;
                    f.Show();
                    this.Hide();





                    AnaSayfa ana = new AnaSayfa();


                    konu = "TUNEX TURİZM UÇUŞ BİLETİNİZ BAŞARIYLA TANIMLANMIŞTIR.";
                    mailtext = "<html>" +
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
                                                                 " <td align='center' style='height:50px; width:800px;'  bgcolor='6633CC'><b><font color='FFFFFF'>TUNEX TURİZM BİLET FATURASI</font></b></td>" +
                                                               " </tr>" +
                                                             " </table>" +

                                                             " <table border='1' cellpadding='0' cellspacing='0' align='center'>" +
                                                               " <tr>" +
                                                                 " <td align='left' height='100' width='400'>Gönderen: TUNEX TURİZM.LTD.ŞTİ <br> <b>Bilet Türü: " + AnaSayfa.biletturu + "</b> <br> <b>Bilet Numarası: " + bltid + "</b></td> " +
                                                                 " <td align='left' height='100' width='398'>Firma: " + AnaSayfa.mailfirmaismi + " <br> <b>Uçuş Tarihi ve Saati: " + AnaSayfa.mailucustarih.Substring(0, 10) + " -- " + AnaSayfa.mailucussaat + "</b> <br> <b>Nereden-Nereye: " + AnaSayfa.mailnereden + "-" + AnaSayfa.mailnereye + "</b></td>" +
                                                               " </tr>" +
                                                             " </table>" +

                                                             " <table border='1' cellpadding='0' cellspacing='0' align='center'>" +
                                                               " <td align='center' height='30' width='800' bgcolor='DCDCDC'><b>Ödeme Detayları</b></td>" +
                                                             " </table>" +

                                                             " <table border='1' cellpadding='0' cellspacing='0' align='center'>" +
                                                               " <td align='right' height='100' width='200' bgcolor='DCDCDC'><b>Fatura Tarih ve Saati: </b> <br> <b>Bilet Tutarı: </b> <br> <b>Bilet Türü: </b> <br> <b>Koltuk numarası: </b> <br></b></td>" +
                                                               " <td align='left' height='100' width='598'> " + faturatarihi + " <br>" + AnaSayfa.tutar + "<br> " + AnaSayfa.biletturu + " <br>" + secilenkoltuk[i].ToString() + "</td>" + " </table>" +
                                                             " <table border='1' cellpadding='0' cellspacing='0' align='center'>" +
                                                               " <td height='100' width='800'>Uçuş Biletiniz Başarıyla Tanımlanmıştır! Bizi ettiğiniz için teşekkür eder iyi yolculuklar dileriz - TUNEX TURİZM LTD.ŞTİ (BİLET İPTAL TALEBİ OLUŞTURMAK İSTİYORSANIZ UYGULAMA ÜZERİNDEN İPTAL TALEBİ SEKMESİNİ KULLANARAK BİLETİNİZİ İPTAL ETTİREBİLİRSİNİZ.) </td>" +
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
                    mailgonder email = new mailgonder();


                    try
                    {

                        email.mailyolla(AnaSayfa.yolcumail, konu, mailtext);
                        HataBox f12 = new HataBox();
                        HataBox.mesaj = "Bilet bilgisi";
                        HataBox.text = "BİLET BİLGİLERİNİZ MAİL\nADRESİNİZE GÖNDERİLMİŞTİR";
                        f12.hataresim.Visible = false;
                        f12.onayresim.Visible = true;
                        f12.Show();
                    }
                    catch
                    {
                        HataBox f12 = new HataBox();
                        HataBox.mesaj = "Bilet bilgisi";
                        HataBox.text = "MAİL BİLGİSİ GÖNDERİLEMEDİ";
                        f12.hataresim.Visible = true;
                        f12.onayresim.Visible = false;
                        f12.Show();

                    }







                }
                catch
                {
                    HataBox f = new HataBox();
                    HataBox.mesaj = "Bilet bilgisi";
                    HataBox.text = "Biletiniz Kaydedilemedi";
                    f.hataresim.Visible = false;
                    f.onayresim.Visible = true;
                    f.Show();
                }



            }

        }

        private void _40koltukform_Load(object sender, EventArgs e)
        {

            LogAl();
            AnaSayfa ana = new AnaSayfa();
            if (ana.ekonomiradiobtn.Checked == true)
            {

                ekonomigrup.Enabled = true;
                bussinesgrup.Enabled = false;


            }
            else if (ana.bussinesradiobtn.Checked == true)
            {
                bussinesgrup.Enabled = true;
                ekonomigrup.Enabled = false;
            }
        }

        private void gunaTransfarantPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void geributon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
