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
        String nereden, nereye, tarih;
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3306;Database=otomasyon;user=root;password=1234;SslMode=none;");
        DataTable tablo = new DataTable();
        DataSet data = new DataSet();

        ArrayList iddizi = new ArrayList();
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

        private void ucusarabtn_Click(object sender, EventArgs e)
        {
          if(ekonomiradiobtn.Checked == true || bussinesradiobtn.Checked == true)
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

                }
                catch (Exception ex)

                {



                }


                RadioButton rb = null;
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

                        for (int i = 0; i < iddizi.Count; i++)
                        {
                            MySqlDataAdapter dr = new MySqlDataAdapter("SELECT * FROM ucuslar WHERE (ucus_id=@ucusid)", baglanti);
                            dr.SelectCommand.Parameters.AddWithValue("@ucusid", iddizi[i]);
                            data = new DataSet();
                            dr.Fill(tablo);
                            ucustable.DataSource = tablo;


                        }
                        iddizi.Clear();

                        ucustable.Columns[0].Visible = false;
                        ucustable.Columns[1].Visible = false;
                        ucustable.Columns[2].Visible = false;
                        ucustable.Columns[7].Visible = false;
                        ucustable.Columns[8].Visible = false;



                    }
                    catch (Exception ex)
                    {

                    }



                }
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


                        }
                        iddizi.Clear();





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
            }else
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
