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
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3306;Database=otomasyon;user=root;password=1234;SslMode=none;");
        public _40koltukform()
        {
            InitializeComponent();
        }
        public List<String> butonlist = new List<String>();
        public List<String> secilenler = new List<String>();
        public List<String> secilenkoltuk = new List<String>();
        int sayac = 0;


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void secilenkoltuklbl_Click(object sender, EventArgs e)
        {

        }


        int kisi;
        int secilensayac = 0;

        String deneme = "A2";
        String dolu = "DOLU";
        String dolukoltukid;


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
                if (btn.ForeColor == Color.Gray)
                {
                    btn.BackgroundImage = ucakotomasyon.Properties.Resources.Secili1;
                    btn.ForeColor = Color.Green;

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
                        koltuklbl.Text = degisken;
                        btn.ForeColor = Color.Gray;
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
                    koltuklbl.Text = degisken;
                    btn.ForeColor = Color.Gray;
                }
            }



        }

        private void ustpanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bussinesgrup_Click(object sender, EventArgs e)
        {

        }

        String bltid = "";
        private void satinalbtn_Click(object sender, EventArgs e)
        {

            baglanti.Close();
            baglanti.Open();

            MySqlCommand biletekle = new MySqlCommand("INSERT INTO biletler (biletadi) VALUES ('" + "a" + "')", baglanti);
            biletekle.ExecuteNonQuery();
            baglanti.Close();
            HataBox f = new HataBox();
            HataBox.mesaj = "Uçuş ekleme";
            HataBox.text = "Uçuş eklendi";
            f.hataresim.Visible = false;
            f.onayresim.Visible = true;
            f.Show();


            baglanti.Close();
            baglanti.Open();
            MySqlCommand biletcek = new MySqlCommand("SELECT bilet_id FROM biletler ORDER BY bilet_id DESC", baglanti);
            MySqlDataReader dr1 = biletcek.ExecuteReader();
            if (dr1.Read())
            {

                bltid = dr1["bilet_id"].ToString();


            }
            baglanti.Close();



            // seçiliyse


            for (int i = 0; i < secilenkoltuk.Count; i++)
            {
                baglanti.Close();
                baglanti.Open();

                MySqlCommand seferekleme = new MySqlCommand("INSERT INTO biletler_has_yolcular (biletler_bilet_id,yolcular_yolcu_id,ucuslar_ucus_id, koltukno) VALUES ('" + bltid + "','" + Form1.kisiid + "','" + AnaSayfa.biletucusid + "','" + secilenkoltuk[i].ToString() + "' )", baglanti);
                seferekleme.ExecuteNonQuery();
                baglanti.Close();



                try
                {

                    baglanti.Close();
                    baglanti.Open();
                    MySqlCommand ucakekleme = new MySqlCommand("UPDATE koltuklar_has_ucaklar SET dolubos='DOLU' WHERE koltuklar_koltuk_id=@koltukid AND ucuslar_ucus_id=@ucusid", baglanti);
                    ucakekleme.Parameters.AddWithValue("@ucusid", AnaSayfa.biletucusid);
                    ucakekleme.Parameters.AddWithValue("@koltukid", secilenkoltuk[i]);
                    ucakekleme.ExecuteNonQuery();
                    baglanti.Close();
                    secilenkoltuk.Clear();


                }
                catch
                {

                }
            }
    }
}
