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
    public partial class AdminDestekForm : Form
    {

        DataTable tablo = new DataTable();
        DataSet data = new DataSet();
        public AdminDestekForm()
        {
            InitializeComponent();
        }
        int satirsayisi;
        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminDestekForm_Load(object sender, EventArgs e)
        {

            try
            {

                //tabloya şikayetleri listeleme
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlDataAdapter dr = new MySqlDataAdapter("SELECT * FROM sikayetler", SqlBaglanti.baglanti);
                data = new DataSet();
                dr.Fill(tablo);
                ucustable.DataSource = tablo;
                ucustable.Refresh();

            }
            catch (Exception ex)
            {

            }
        }

        
        private void ucustable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            satirsayisi = e.RowIndex;
            metintxt.Text = ucustable.Rows[satirsayisi].Cells[1].Value.ToString();
            
        }

        private void ucustable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
