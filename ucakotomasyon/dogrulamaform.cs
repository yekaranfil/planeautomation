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
    public partial class dogrulamaform : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;port=3306;Database=otomasyon;user=root;password=1234;SslMode=none;");
        public dogrulamaform()
        {
            InitializeComponent();
        }

        private void dogrulabuton_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();



            if (dogrulamabox.Text == Form1.dogrulamakodu.ToString())
            {
                form1.kayit();
                this.Close();
                form1.Refresh();
            } else
            {

                HataBox uyari = new HataBox();
                HataBox.mesaj = "Doğrulama Bilgilendirme";
                HataBox.text = "Lütfen doğrulama kodunu \ndoğru girdiğinizden emin olun";
                uyari.onayresim.Visible = false;
                uyari.hataresim.Visible = true;
                uyari.Show();
            }
          

        }

    }
}
