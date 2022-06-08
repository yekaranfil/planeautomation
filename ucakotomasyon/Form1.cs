using System;
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
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3306;Database=otomasyon;user=root;password=1234;SslMode=none;");


        int sayac = 0;
        public static String _tcno, _mail, _sifre, _ad, _soyad, _telefon, _dogumtarihi, _cinsiyet, _sikayetmetin, _sikayetmail;

        //tc kontrol fonksiyonu
        public bool TcKontrol()
        {
            _tcno = txtgiris.Text;
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

        private void cikisbuton_Click(object sender, EventArgs e)
        {

            Application.Exit();
            
        }

        private void girisbuton_Click(object sender, EventArgs e)
        {

            //giriş ekranı veritabanı tc şifre kontrolü
            _tcno = txtgiris.Text;
            _sifre = txtgirissifre.Text;

            baglanti.Close();
            baglanti.Open();
            MySqlCommand kontroltc = new MySqlCommand("SELECT yolcu_tc,yolcu_sifre FROM yolcular WHERE (yolcu_tc = @tc AND yolcu_sifre = @sifre)", baglanti);
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
                baglanti.Close();
                baglanti.Open();
                MySqlCommand idkontrol = new MySqlCommand("SELECT yolcu_id FROM yolcular WHERE (yolcu_tc = @tc)", baglanti);
                idkontrol.Parameters.AddWithValue("@tc", kisitc);
                MySqlDataReader dr1 = idkontrol.ExecuteReader();

                if (dr1.Read())
                {
                    kisiid = dr1["yolcu_id"].ToString();
                }
               baglanti.Close();
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

            baglanti.Close();
            baglanti.Open();
            MySqlCommand sikayetkomut = new MySqlCommand("INSERT INTO sikayetler (sikayet_metin,sikayet_mail) VALUES ('" + _sikayetmetin + "','" + _sikayetmail + "')", baglanti);
            sikayetkomut.ExecuteNonQuery();
            baglanti.Close();
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
            girisbuton.Visible = false;
            mailtext.Visible = true;
            kayitolbuton.Visible = false;
            kayitbuton2.Visible = true;
            geributon.Visible = true;
            txtgiris.BorderColor = Color.Red;
            txtgirissifre.BorderColor = Color.Red;
            mailtext.BorderColor = Color.Red;
        }

        private void kayitbuton2_Click(object sender, EventArgs e)
        {

            _tcno = Convert.ToString(txtgiris.Text);
            _sifre = Convert.ToString(txtgirissifre.Text);
            _mail = Convert.ToString(mailtext.Text);

            //boş alan kontrol
            if (_tcno == "" || _sifre == "" || _mail == "" || _tcno == "T.C Kimlik Numarası" || _sifre == "Şifre" || _mail == "Mail Adresi")
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
                    baglanti.Close();
                    baglanti.Open();
                    MySqlCommand kayitkomuttc = new MySqlCommand("SELECT yolcu_tc FROM yolcular WHERE yolcu_tc = @tc", baglanti);
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
                        baglanti.Close();
                        baglanti.Open();
                        MySqlCommand kayitkomut1 = new MySqlCommand("INSERT INTO yolcular (yolcu_tc,yolcu_mail,yolcu_sifre,cinsiyetler_cinsiyet_id) VALUES ('" + _tcno + "','" + _mail + "','" + _sifre + "','0')", baglanti);
                        kayitkomut1.ExecuteNonQuery();
                        baglanti.Close();
                        HataBox f = new HataBox();
                        HataBox.mesaj = "Kayıt Başarılı";
                        HataBox.text = "Kaydınız başarılı bir şekilde \ntamamlanmıştır!";
                        f.hataresim.Visible = false;
                        f.onayresim.Visible = true;
                        f.Show();
                        // kayit ekranı geri çıkış
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
        }

        private void geributon_Click(object sender, EventArgs e)
        {
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
