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

namespace ucakotomasyon
{
    public partial class AnaSayfa : Form
    {
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
    }
}
