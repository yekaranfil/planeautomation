using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucakotomasyon
{
    public partial class AdminbiletiptalForm : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3306;Database=otomasyon;user=root;password=1234;SslMode=none;");
        public AdminbiletiptalForm()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();
        DataSet data = new DataSet();

        public static String talepid, biletid, iptalkoltukid, iptalucusid;
        private void AdminbiletiptalForm_Load(object sender, EventArgs e)
        {

            try
            {
                //Tabloya uçuşları listeleme
                baglanti.Close();
                baglanti.Open();
                MySqlDataAdapter dr = new MySqlDataAdapter("SELECT * FROM iptaltalebi", baglanti);
                data = new DataSet();
                dr.Fill(tablo);
                ucustable.DataSource = tablo;
                ucustable.Refresh();

            }
            catch (Exception ex)
            {

            }



        }

        String doluluk = "BOS";

        public static String silinenkoltuk;
        private void guncellebuton_Click(object sender, EventArgs e)
        {
            try
            {
                //biletler tablosundan seçilen bileti silme
                baglanti.Close();
                baglanti.Open();
                MySqlCommand biletsilme = new MySqlCommand("DELETE FROM biletler_has_yolcular WHERE biletler_bilet_id=@biletid", baglanti);
                biletsilme.Parameters.AddWithValue("@biletid", biletid);
                biletsilme.ExecuteNonQuery();



                //talepler tablosundan seçilen bileti silme
                MySqlCommand talepsilme = new MySqlCommand("DELETE FROM iptaltalebi WHERE talep_id=@talepid", baglanti);
                talepsilme.Parameters.AddWithValue("@talepid", talepid);
                talepsilme.ExecuteNonQuery();

                //Silinen biletlerin koltuklarını boşa çevirme
                MySqlCommand koltukguncelle = new MySqlCommand("UPDATE koltuklar_has_ucaklar SET dolubos=@doluluk WHERE ucuslar_ucus_id=@ucusid AND koltuklar_koltuk_id=@koltuk", baglanti);
                koltukguncelle.Parameters.AddWithValue("@ucusid", iptalucusid);
                koltukguncelle.Parameters.AddWithValue("@koltuk", iptalkoltukid);
                koltukguncelle.Parameters.AddWithValue("@doluluk", doluluk);
                koltukguncelle.ExecuteNonQuery();
                baglanti.Close();
                HataBox f = new HataBox();
                HataBox.mesaj = "Bilet Silme";
                HataBox.text = "Bilet Başarıyla Silindi";
                f.hataresim.Visible = false;
                f.onayresim.Visible = true;

                f.Show();
            }
            catch (Exception ex)
            {
                HataBox f1 = new HataBox();
                HataBox.mesaj = "bilet Silme";
                HataBox.text = "Hata";
                f1.hataresim.Visible = true;
                f1.onayresim.Visible = false;
                f1.Show();
            }

            tablo.Clear();
            AdminbiletiptalForm_Load(null, null);

        }

        private void ucustable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satirsayisi = e.RowIndex;

            // tablodan gerekli verileri değişkenlere atma
            talepid = ucustable.Rows[satirsayisi].Cells[0].Value.ToString();
            biletid = ucustable.Rows[satirsayisi].Cells[1].Value.ToString();
            iptalkoltukid = ucustable.Rows[satirsayisi].Cells[3].Value.ToString();
            iptalucusid = ucustable.Rows[satirsayisi].Cells[2].Value.ToString();
       
        }
    }
}
