﻿using MySql.Data.MySqlClient;
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
    public partial class BiletlerForm : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3306;Database=otomasyon;user=root;password=1234;SslMode=none;");
        public BiletlerForm()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();
        DataTable tablo2 = new DataTable();
        DataSet data = new DataSet();
        ArrayList iddizi = new ArrayList();
        ArrayList firmaiddizi = new ArrayList();


        private void BiletlerForm_Load(object sender, EventArgs e)
        {
            biletdetaytablo.ColumnCount = 1;
            biletdetaytablo.Columns[0].Name = "firmaadı";
            biletdetaytablo.Columns[0].ValueType = typeof(String);

            tablo.Clear();
            ucustable.DataSource = tablo;
            ucustable.Refresh();

            try
            {

                //Tabloya uçuşları listeleme
                baglanti.Close();
                baglanti.Open();



                MySqlDataAdapter dr = new MySqlDataAdapter("SELECT * FROM biletler_has_yolcular WHERE (yolcular_yolcu_id=@yolcuid)", baglanti);
                dr.SelectCommand.Parameters.AddWithValue("@yolcuid", Form1.kisiid);
                data = new DataSet();
                dr.Fill(tablo);
                ucustable.DataSource = tablo;




                iddizi.Clear();
                firmaiddizi.Clear();

                baglanti.Close();

            }
            catch (Exception ex)
            {

            }



        }

        String ucusbilgiid,ucusfirmaid;
        private void ucustable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satirsayisi = e.RowIndex;

            tablo2.Clear();
            biletdetaytablo.DataSource = tablo;
            biletdetaytablo.Refresh();


            ucusbilgiid = ucustable.Rows[satirsayisi].Cells[2].Value.ToString();
            try
            {

                baglanti.Close();
                baglanti.Open();
                MySqlCommand kontrolfirmaid = new MySqlCommand("SELECT ucaklar_firmalar_firmalar_id FROM ucuslar WHERE (ucus_id=@ucusid)", baglanti);
                kontrolfirmaid.Parameters.AddWithValue("@ucusid", ucusbilgiid);
                MySqlDataReader dr = kontrolfirmaid.ExecuteReader();
                while (dr.Read())
                {
                    //seçilen hücrenin içindeki şehrin adını lbl yazdırma
                    ucusfirmaid = (dr["ucaklar_firmalar_firmalar_id"]).ToString();

                }
            }
            catch (Exception ex)

            {
              
            }

            try
            {

                //Tabloya uçuşları listeleme
                baglanti.Close();
                baglanti.Open();



                

                MySqlDataAdapter dr = new MySqlDataAdapter("SELECT * FROM ucuslar WHERE (ucus_id=@ucusid)", baglanti);
                dr.SelectCommand.Parameters.AddWithValue("@ucusid", ucusbilgiid);
                data = new DataSet();
                dr.Fill(tablo2);
                biletdetaytablo.DataSource = tablo2;

                //firmaiddizi.Add(ucustable.Rows[satirsayisi].Cells[10].Value.ToString());


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

                    HataBox f = new HataBox();
                    HataBox.mesaj = "Uçuş Arama Hatası";
                    HataBox.text = "Lütfen Bilet Türü Seçiniz";
                    f.hataresim.Visible = true;
                    f.onayresim.Visible = false;
                    f.Show();
                }



                iddizi.Clear();
                firmaiddizi.Clear();

                biletdetaytablo.Columns[1].Visible = false;
                biletdetaytablo.Columns[2].Visible = false;
                biletdetaytablo.Columns[3].Visible = false;
                biletdetaytablo.Columns[7].Visible = true;
                biletdetaytablo.Columns[8].Visible = false;
                biletdetaytablo.Columns[9].Visible = false;
                biletdetaytablo.Columns[10].Visible = false;

            }
            catch (Exception ex)
            {

            }


        }
    }
}