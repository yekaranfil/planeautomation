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
    public partial class SeferEkleForm : Form
    {

        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3306;Database=otomasyon;user=root;password=1234;SslMode=none;");
        public SeferEkleForm()
        {
            InitializeComponent();
        }

        private void onaylabuton1_Click(object sender, EventArgs e)
        {

        }

        private void SeferEkleForm_Load(object sender, EventArgs e)
        {

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
            } catch(Exception ex) 
            {

            }

        }

        private void neredenbox_SelectedValueChanged(object sender, EventArgs e)
        {

            // combobox kontrol
            String secim1,secim2;
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
            
        }

        private void nereyebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void nereyebox_Click(object sender, EventArgs e)
        {

            // combobox kontrol
            String secim;
            secim = neredenbox.Text.ToString();
            if (secim == "")
            {
                if(nereyebox.Items != null )
                {
                    nereyebox.Items.Clear();
                }
                else { 

                }

            }

        }
    }
}
