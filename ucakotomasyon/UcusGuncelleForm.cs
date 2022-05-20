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
    public partial class UcusGuncelleForm : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3306;Database=otomasyon;user=root;password=1234;SslMode=none;");
        DataTable tablo = new DataTable();
        DataSet data = new DataSet();
        MySqlCommandBuilder upt = new MySqlCommandBuilder();
        public UcusGuncelleForm()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucaksecimbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UcusGuncelleForm_Load(object sender, EventArgs e)
        {


            String ucakid1;
            try
            {

                //comboboxa uçakları listeleme
                baglanti.Close();
                baglanti.Open();
                //MySqlCommand ucuscek = new MySqlCommand("SELECT *FROM ucuslar", baglanti);
                MySqlDataAdapter dr = new MySqlDataAdapter("SELECT * FROM ucuslar",baglanti);
                data = new DataSet();
                dr.Fill(tablo);
                ucustable.DataSource = tablo;
                ucustable.Refresh();
                
                

                

            }
            catch (Exception ex)
            {

            }
        }

        private void guncellebuton_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Close();
                baglanti.Open();
                //MySqlCommand ucuscek = new MySqlCommand("SELECT *FROM ucuslar", baglanti);
                MySqlDataAdapter dr = new MySqlDataAdapter("SELECT *FROM ucuslar", baglanti);
                data = new DataSet();
                upt = new MySqlCommandBuilder(dr);
                tablo = (DataTable)ucustable.DataSource;
                dr.Update(tablo);
                ucustable.Refresh();
                HataBox f = new HataBox();
                HataBox.mesaj = "Uçuş ekleme";
                HataBox.text = "Uçuş Güncellendi";
                f.hataresim.Visible = false;
                f.onayresim.Visible = true;
            f.Show();
            }
            catch (Exception ex)
            {
                HataBox f = new HataBox();
                HataBox.mesaj = "Uçak ekleme";
                HataBox.text = "Uçuş Güncellenemedi";
                f.hataresim.Visible = true;
                f.onayresim.Visible = false;
                f.Show();
            }
           


        }

        private void ucustable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String deger = ucustable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                



        }

        private void ucustable_Click(object sender, EventArgs e)
        {

        }
    }
}
