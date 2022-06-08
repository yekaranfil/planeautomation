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
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Collections;

namespace ucakotomasyon
{

    public partial class AnaSayfa : Form
    {
        public static String nereden, nereye, tarih,kisisayisi;
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3306;Database=otomasyon;user=root;password=1234;SslMode=none;");
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
        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

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
            islemlerpanel.Visible = false;
            anamenulabel.Visible = false;
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
            gidisdonuslbl.Visible = true;
            gidisdonusradiobtn.Visible = true;
            neredentxt.Visible = true;
            nereyetxt.Visible = true;
            ucusarabtn.Visible = true;

        }

        private void tekyonradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            gidistarihbox.Visible = true;
            gidistarihlbl.Visible = true;



            donustarihbox.Visible = false;
            donustarihlbl.Visible = false;
            gidisgelisicon.Visible = false;
        }

        private void gidisdonuslbl_Click(object sender, EventArgs e)
        {

        }

        private void gidisdonusradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            gidistarihbox.Visible = true;
            gidistarihlbl.Visible = true;
            donustarihbox.Visible = true;
            donustarihlbl.Visible = true;
            gidisgelisicon.Visible = true;

        }



        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            //combobox şehir bilgisi çekme
            try
            {
                baglanti.Close();
                baglanti.Open();
                MySqlCommand kontrolfirma = new MySqlCommand("SELECT sehir_ad FROM sehirler", baglanti);
                MySqlDataReader dr = kontrolfirma.ExecuteReader();
                while (dr.Read())
                {

                    neredenbox.Items.Add(dr["sehir_ad"]);
                    nereyebox.Items.Add(dr["sehir_ad"]);


                }
            }
            catch (Exception ex)

            {

            }



        }

        private void neredenbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

           

            // combobox şehir çakışma kontrol
            String secim1, secim2;
            secim1 = neredenbox.SelectedItem.ToString();
            secim2 = neredenbox.SelectedItem.ToString();

            nereyebox.Items.Clear();
            try
            {
                baglanti.Close();
                baglanti.Open();
                MySqlCommand kontrolfirma = new MySqlCommand("SELECT sehir_ad FROM sehirler", baglanti);
                MySqlDataReader dr = kontrolfirma.ExecuteReader();
                while (dr.Read())
                {

                    nereyebox.Items.Add(dr["sehir_ad"]);


                }
            }
            catch (Exception ex)
            {

            }

            nereyebox.Items.Remove(secim1);



            //şehir id çekme
            try
            {
                baglanti.Close();
                baglanti.Open();
                MySqlCommand kontrolfirma = new MySqlCommand("SELECT sehir_id FROM sehirler WHERE (sehir_ad=@sehirad)", baglanti);
                kontrolfirma.Parameters.AddWithValue("@sehirad", neredenbox.Text);
                MySqlDataReader dr = kontrolfirma.ExecuteReader();
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

                baglanti.Close();
                baglanti.Open();
                MySqlCommand kontrolfirma = new MySqlCommand("SELECT sehir_id FROM sehirler WHERE (sehir_ad=@sehirad)", baglanti);
                kontrolfirma.Parameters.AddWithValue("@sehirad", nereyebox.Text);
                MySqlDataReader dr = kontrolfirma.ExecuteReader();
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

        private void gidistarihbox_ValueChanged(object sender, EventArgs e)
        {

        }


        int ucusid;

        private void gidistarihbox_TextChanged(object sender, EventArgs e)
        {


        }

        int satirsayisi;
        String secilenucakid;
        public static String biletucusid;
        private void ucustable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            satirsayisi = e.RowIndex;
            try
            {
                if (ucustable.Rows[satirsayisi].Cells[0].Value.ToString().Equals("Pegasus"))
                {
                    logobox.Image = Image.FromFile(Application.StartupPath + "\\pegasus.png");
                    logobox.Refresh();
                }
                else if (ucustable.Rows[satirsayisi].Cells[0].Value.ToString().Equals("Türk Hava Yolları"))
                {

                    logobox.Image = Image.FromFile(Application.StartupPath + "\\turkishairlines.png");
                    logobox.Refresh();
                }
                else if (ucustable.Rows[satirsayisi].Cells[0].Value.ToString().Equals("Sunexpress"))
                {
                    logobox.Image = Image.FromFile(Application.StartupPath + "\\sunexpress.png");
                    logobox.Refresh();
                }

                else if (ucustable.Rows[satirsayisi].Cells[0].Value.ToString().Equals("AnadoluJet"))
                {
                    logobox.Image = Image.FromFile(Application.StartupPath + "\\anadolujet.png");
                    logobox.Refresh();
                }
            } catch
            {

            }

            biletucusid = ucustable.Rows[satirsayisi].Cells[1].Value.ToString();
            secilenucakid = ucustable.Rows[satirsayisi].Cells[9].Value.ToString();
            satinalbtn.Visible = true;
            
        }
        
        String koltuksayisi;
        private void satinalbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //seçilen uçuşun satın ala basınca uçuş idsini alma
                String a = ucustable.Rows[satirsayisi].Cells[1].Value.ToString();


            } catch
            {

            }




            try
            {
                baglanti.Close();
                baglanti.Open();
                MySqlCommand kontrolfirma = new MySqlCommand("SELECT ucak_koltuksayisi FROM ucaklar WHERE (ucak_id=@ucakid)", baglanti);
                kontrolfirma.Parameters.AddWithValue("@ucakid", secilenucakid);
                MySqlDataReader dr = kontrolfirma.ExecuteReader();
                if (dr.Read())
                {
                   // seçilen uçuşun uçağının şablonuu getirmek için ucak koltuk sayısını alma
                    koltuksayisi = (dr["ucak_koltuksayisi"]).ToString();
                }

            }
            catch (Exception ex)

            {



            }

            if(koltuksayisi == "40")
            {

                HataBox hataform = new HataBox();
                HataBox.mesaj = "Giriş başarılı";
                HataBox.text = "Giriş Yapıldı";
                hataform.Show();

                _40koltukform secim1 = new _40koltukform();
                secim1.Show();
                hataform.hataresim.Visible = false;
                hataform.onayresim.Visible = true;
                hataform.Show();

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
            else if(koltuksayisi =="56")
            {

                HataBox hataform = new HataBox();
                HataBox.mesaj = "Giriş başarılı";
                HataBox.text = "Giriş Yapıldı";
                hataform.Show();

                _56koltukform secim2 = new _56koltukform();
                secim2.Show();
                hataform.hataresim.Visible = false;
                hataform.onayresim.Visible = true;
                hataform.Show();

                
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

            } else if(koltuksayisi == "72")
            {

                HataBox hataform = new HataBox();
                HataBox.mesaj = "Giriş başarılı";
                HataBox.text = "Giriş Yapıldı";
                hataform.Show();

                _72koltukform secim3 = new _72koltukform();
                secim3.Show();
                hataform.hataresim.Visible = false;
                hataform.onayresim.Visible = true;
                hataform.Show();


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
        public static int kisiindex;

        private void secenekbuton1_Click(object sender, EventArgs e)
        {
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
            islemlerpanel.Visible = false;
        }

        private void kisibox_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                    baglanti.Close();
                    baglanti.Open();
                    MySqlCommand kontrolfirma = new MySqlCommand("SELECT ucus_id FROM ucuslar WHERE (ucus_neredenID=@neredenid and ucus_nereyeID=@nereyeid and ucus_tarih=@ucustarih)", baglanti);
                    kontrolfirma.Parameters.AddWithValue("@neredenid", nereden);
                    kontrolfirma.Parameters.AddWithValue("@nereyeid", nereye);
                    kontrolfirma.Parameters.AddWithValue("@ucustarih", tarih);
                    MySqlDataReader dr = kontrolfirma.ExecuteReader();
                    while (dr.Read())
                    {
                        //seçilen hücrenin içindeki şehrin adını lbl yazdırma
                        String ucus = (dr["ucus_id"]).ToString();
                        ucusid = int.Parse(ucus);
                        iddizi.Add(ucusid);
                    }
                    baglanti.Close();
                }
                catch (Exception ex)

                {



                }

                int secim = 0;
                RadioButton rb = null;
                // ekonomi seçildiyse
                if (ekonomiradiobtn.Checked == true)
                {
                    tablo.Clear();
                    ucustable.DataSource = tablo;
                    ucustable.Refresh();

                    try
                    {

                        //Tabloya uçuşları listeleme
                        baglanti.Close();
                        baglanti.Open();

                        // dizideki ucusid ile ucusları listeleme
                        for (int i = 0; i < iddizi.Count; i++)
                        {

                            MySqlDataAdapter dr = new MySqlDataAdapter("SELECT * FROM ucuslar WHERE (ucus_id=@ucusid)", baglanti);
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

                // bussines seçildiyse
                else if (bussinesradiobtn.Checked == true)
                {
                    tablo.Clear();
                    ucustable.DataSource = tablo;
                    ucustable.Refresh();

                    try
                    {
                        //Tabloya uçuşları listeleme
                        baglanti.Close();
                        baglanti.Open();

                        for (int i = 0; i < iddizi.Count; i++)
                        {
                            MySqlDataAdapter dr = new MySqlDataAdapter("SELECT * FROM ucuslar WHERE (ucus_id=@ucusid)", baglanti);
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
            //şehir id çekme
            try
            {
                baglanti.Close();
                baglanti.Open();
                MySqlCommand kontrolfirma = new MySqlCommand("SELECT sehir_id FROM sehirler WHERE (sehir_ad=@sehirad)", baglanti);
                kontrolfirma.Parameters.AddWithValue("@sehirad", neredenbox.Text);
                MySqlDataReader dr = kontrolfirma.ExecuteReader();
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

                baglanti.Close();
                baglanti.Open();
                MySqlCommand kontrolfirma = new MySqlCommand("SELECT sehir_id FROM sehirler WHERE (sehir_ad=@sehirad)", baglanti);
                kontrolfirma.Parameters.AddWithValue("@sehirad", nereyebox.Text);
                MySqlDataReader dr = kontrolfirma.ExecuteReader();
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
    }
}
