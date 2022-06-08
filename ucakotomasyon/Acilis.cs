using System;
using System.Windows.Forms;

namespace ucakotomasyon
{
    public partial class Acilis : Form
    {
        public Acilis()
        {
            InitializeComponent();
        }

        private void Acilis_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 2;
            if (panel2.Width >= 576)
            {

                timer1.Stop();
                timer1.Enabled = false;
                this.Hide();
                Form1 f = new Form1();
                f.Show();

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
