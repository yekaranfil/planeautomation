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
    public partial class BiletlerForm : Form
    {
        public BiletlerForm()
        {
            InitializeComponent();
        }
        String ucusbilgiid, ucusfirmaid, biletsinifi, nereden,nereye, neredenad, nereyead;
        DataTable tablo = new DataTable();

        private void gunaTransfarantPictureBox1_Click(object sender, EventArgs e)
        {

        }

        DataTable tablo2 = new DataTable();
        DataSet data = new DataSet();
        ArrayList iddizi = new ArrayList();
        ArrayList firmaiddizi = new ArrayList();
        private void BiletlerForm_Load(object sender, EventArgs e)
        {
            //firma sütunu ekleme
            biletdetaytablo.ColumnCount = 1;
            biletdetaytablo.Columns[0].Name = "firmaadı";
            biletdetaytablo.Columns[0].ValueType = typeof(String);

            tablo.Clear();
            ucustable.DataSource = tablo;
            ucustable.Refresh();

            try
            {
                //Tabloya biletleri listeleme
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlDataAdapter dr = new MySqlDataAdapter("SELECT * FROM biletler_has_yolcular WHERE (yolcular_yolcu_id=@yolcuid)", SqlBaglanti.baglanti);
                dr.SelectCommand.Parameters.AddWithValue("@yolcuid", Form1.kisiid);
                data = new DataSet();
                dr.Fill(tablo);
                ucustable.DataSource = tablo;
                SqlBaglanti.baglanti.Close();
            }
            catch (Exception ex)
            {
            }

        }

     

    

        private void ucustable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satirsayisi = e.RowIndex;
            biletsinifi = ucustable.Rows[satirsayisi].Cells[4].Value.ToString();
            tablo2.Clear();
            biletdetaytablo.DataSource = tablo;
            biletdetaytablo.Refresh();


            ucusbilgiid = ucustable.Rows[satirsayisi].Cells[2].Value.ToString();
            try
            {

                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlCommand kontrolfirmaid = new MySqlCommand("SELECT ucaklar_firmalar_firmalar_id FROM ucuslar WHERE (ucus_id=@ucusid)", SqlBaglanti.baglanti);
                kontrolfirmaid.Parameters.AddWithValue("@ucusid", ucusbilgiid);
                MySqlDataReader dr = kontrolfirmaid.ExecuteReader();
                while (dr.Read())
                {
                    //ucus id ye göre firma id alma
                    ucusfirmaid = (dr["ucaklar_firmalar_firmalar_id"]).ToString();

                }
            }
            catch (Exception ex)

            {

            }

            try
            {
                //Tabloya seçilen bilete göre uçuşları listeleme
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlDataAdapter dr = new MySqlDataAdapter("SELECT * FROM ucuslar WHERE (ucus_id=@ucusid)", SqlBaglanti.baglanti);
                dr.SelectCommand.Parameters.AddWithValue("@ucusid", ucusbilgiid);
                data = new DataSet();
                dr.Fill(tablo2);
                biletdetaytablo.DataSource = tablo2;

                // tabloya firma ismini yazdırma
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
                

                if (biletsinifi.Equals("EKONOMİ"))
                {
                    //seçilen sınıf eğer ekonomiyse belli sutunlari gizleme
                    biletdetaytablo.Columns[1].Visible = false;
                    biletdetaytablo.Columns[2].Visible = false;
                    biletdetaytablo.Columns[3].Visible = false;
                    biletdetaytablo.Columns[7].Visible = true;
                    biletdetaytablo.Columns[8].Visible = false;
                    biletdetaytablo.Columns[9].Visible = false;
                    biletdetaytablo.Columns[10].Visible = false;


                } else if(biletsinifi.Equals("BUSSİNES"))
                {
                    //seçilen sınıf eğer bussinessa belli sutunlari gizleme
                    biletdetaytablo.Columns[1].Visible = false;
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



            nereden = biletdetaytablo.Rows[0].Cells[2].Value.ToString();
            nereye = biletdetaytablo.Rows[0].Cells[3].Value.ToString();




            //şehir adi çekme
            try
            {
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlCommand sehirid = new MySqlCommand("SELECT sehir_ad FROM sehirler WHERE (sehir_id=@sehirid)", SqlBaglanti.baglanti);
                sehirid.Parameters.AddWithValue("@sehirid", nereden);
                MySqlDataReader dr = sehirid.ExecuteReader();
                while (dr.Read())
                {
                    //sehir adi alma
                    neredenad = (dr["sehir_ad"]).ToString();

                }
                SqlBaglanti.baglanti.Close();
            }
            catch (Exception ex)

            {

            }


            //şehir adi çekme
            try
            {
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlCommand sehirid = new MySqlCommand("SELECT sehir_ad FROM sehirler WHERE (sehir_id=@sehirid)", SqlBaglanti.baglanti);
                sehirid.Parameters.AddWithValue("@sehirid", nereye);
                MySqlDataReader dr = sehirid.ExecuteReader();
                while (dr.Read())
                {
                    //sehir adi alma
                    nereyead = (dr["sehir_ad"]).ToString();

                }
                SqlBaglanti.baglanti.Close();
            }
            catch (Exception ex)

            {

            }

            neredenlbl.Text = neredenad;
            nereyelbl.Text = nereyead;



        }
    }
}
