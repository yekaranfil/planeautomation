using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class BiletiptalForm : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3306;Database=otomasyon;user=root;password=1234;SslMode=none;");

        public BiletiptalForm()
        {
            InitializeComponent();
        }
        public String iptalbiletid, iptalkisiid, iptalucusid, iptalkoltukid, iptalsinif, ucusbilgiid, ucusfirmaid, biletsinifi;

        DataTable tablo = new DataTable();
        DataTable tablo2 = new DataTable();
        DataSet data = new DataSet();

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            //talep oluşturmak
            try
            {
                baglanti.Close();
                baglanti.Open();
                MySqlCommand talepkayit = new MySqlCommand("INSERT INTO iptaltalebi (biletid,ucusid,koltukid,kisiid,biletsinif) VALUES ('" + iptalbiletid + "','" + iptalucusid + "','" + iptalkoltukid + "','" + iptalkisiid + "','" + iptalsinif + "')", baglanti);
                talepkayit.ExecuteNonQuery();
                baglanti.Close();

                HataBox uyari = new HataBox();
                HataBox.mesaj = "Talep Bilgi";
                HataBox.text = "İptal Talebiniz Başarıyla\nOluşturulmuştur.";
                uyari.hataresim.Visible = false;
                uyari.onayresim.Visible = true;
                uyari.Show();

            }
            catch (Exception ex)
            {
                HataBox uyari = new HataBox();
                HataBox.mesaj = "Talep Bilgi";
                HataBox.text = "İptal Talebinizde bir hata oluştu";
                uyari.hataresim.Visible = true;
                uyari.onayresim.Visible = false;
                uyari.Show();
            }
        }

        private void BiletiptalForm_Load(object sender, EventArgs e)
        {
            //tabloya firmaadı sütunu ekleme
            biletdetaytablo.ColumnCount = 1;
            biletdetaytablo.Columns[0].Name = "firmaadı";
            biletdetaytablo.Columns[0].ValueType = typeof(String);

            tablo.Clear();
            ucustable.DataSource = tablo;
            ucustable.Refresh();

            //biletleri tabloya yazdırma
            try
            {
                baglanti.Close();
                baglanti.Open();
                MySqlDataAdapter dr = new MySqlDataAdapter("SELECT * FROM biletler_has_yolcular WHERE (yolcular_yolcu_id=@yolcuid)", baglanti);
                dr.SelectCommand.Parameters.AddWithValue("@yolcuid", Form1.kisiid);
                data = new DataSet();
                dr.Fill(tablo);
                ucustable.DataSource = tablo;
                baglanti.Close();

            }
            catch (Exception ex)
            {

            }
        }
       

        private void ucustable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //satır sayisi alma
            int satirsayisi = e.RowIndex;

            //tablodaki gerekli verileri değişkenlere alma
            iptalbiletid = ucustable.Rows[satirsayisi].Cells[0].Value.ToString();
            iptalkisiid = ucustable.Rows[satirsayisi].Cells[1].Value.ToString();
            iptalucusid = ucustable.Rows[satirsayisi].Cells[2].Value.ToString();
            iptalkoltukid = ucustable.Rows[satirsayisi].Cells[3].Value.ToString();
            iptalsinif = ucustable.Rows[satirsayisi].Cells[4].Value.ToString();
            biletsinifi = ucustable.Rows[satirsayisi].Cells[4].Value.ToString();
            ucusbilgiid = ucustable.Rows[satirsayisi].Cells[2].Value.ToString();

            tablo2.Clear();
            biletdetaytablo.DataSource = tablo;
            biletdetaytablo.Refresh();

            
            try
            {

                baglanti.Close();
                baglanti.Open();
                MySqlCommand kontrolfirmaid = new MySqlCommand("SELECT ucaklar_firmalar_firmalar_id FROM ucuslar WHERE (ucus_id=@ucusid)", baglanti);
                kontrolfirmaid.Parameters.AddWithValue("@ucusid", ucusbilgiid);
                MySqlDataReader dr = kontrolfirmaid.ExecuteReader();
                while (dr.Read())
                {
                    //ucusunfirmasını alma
                    ucusfirmaid = (dr["ucaklar_firmalar_firmalar_id"]).ToString();

                }
            }
            catch (Exception ex)

            {

            }

            try
            {
                //tabloya seçilen bilete ait olan uçuşları listeleme
                baglanti.Close();
                baglanti.Open();
                MySqlDataAdapter dr = new MySqlDataAdapter("SELECT * FROM ucuslar WHERE (ucus_id=@ucusid)", baglanti);
                dr.SelectCommand.Parameters.AddWithValue("@ucusid", ucusbilgiid);
                data = new DataSet();
                dr.Fill(tablo2);
                biletdetaytablo.DataSource = tablo2;

                 //tabloya firma ismi yazma
                if (ucusfirmaid == "1")
                {
                    biletdetaytablo.Rows[0].Cells[0].Value = "Pegasus";
                }

                else if (ucusfirmaid == "2")
                {
                    biletdetaytablo.Rows[0].Cells[0].Value = "Türk Hava Yolları";
                }
                else if (ucusfirmaid == "3")
                {
                    biletdetaytablo.Rows[0].Cells[0].Value = "Sunexpress";
                }
                else if (ucusfirmaid == "4")
                {
                    biletdetaytablo.Rows[0].Cells[0].Value = "AnadoluJet";
                }
                else
                {

                }

                
                //seçilen sınıf ekomoni ise belirli sütünları gizleme
                if (biletsinifi.Equals("EKONOMİ"))

                {
                    biletdetaytablo.Columns[1].Visible = false;
                    biletdetaytablo.Columns[2].Visible = false;
                    biletdetaytablo.Columns[3].Visible = false;
                    biletdetaytablo.Columns[7].Visible = true;
                    biletdetaytablo.Columns[8].Visible = false;
                    biletdetaytablo.Columns[9].Visible = false;
                    biletdetaytablo.Columns[10].Visible = false;


                }
                //seçilen sınıf bussines ise belirli sütünları gizleme
                else if (biletsinifi.Equals("BUSSİNES"))
                {

                    biletdetaytablo.Columns[1].Visible = false;
                    biletdetaytablo.Columns[2].Visible = false;
                    biletdetaytablo.Columns[3].Visible = false;
                    biletdetaytablo.Columns[7].Visible = false;
                    biletdetaytablo.Columns[8].Visible = true;
                    biletdetaytablo.Columns[9].Visible = false;
                    biletdetaytablo.Columns[10].Visible = false;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
