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
    public partial class AdminGiris : Form
    {
        int sayac = 0;
        public AdminGiris()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3306;Database=otomasyon;user=root;password=1234;SslMode=none;");
        private void txtgiris_TextChanged(object sender, EventArgs e)
        {

        }

        private void kayitbuton2_Click(object sender, EventArgs e)
        {

            baglanti.Close();
            baglanti.Open();
            MySqlCommand kontroltc = new MySqlCommand("SELECT admin_kullanici_adi,admin_sifre FROM adminler WHERE (admin_kullanici_adi = @kullanici AND admin_sifre = @sifre)", baglanti);
            kontroltc.Parameters.AddWithValue("@kullanici", txtgiris.Text);
            kontroltc.Parameters.AddWithValue("@sifre", txtgirissifre.Text);
            MySqlDataReader dr = kontroltc.ExecuteReader();

            if (dr.Read())
            {
                HataBox.mesaj = "Giriş başarılı";
                HataBox.text = "Giriş Yapıldı";
                HataBox hataform = new HataBox();
                this.Hide();

                AdminPanelForm adminform = new AdminPanelForm();
                adminform.Show();
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




        }

        private void txtgirissifre_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            if (txtgiris.Text.Equals("Kullanıcı Adı"))
            {
                txtgiris.Clear();
            }
        }
    }
}
