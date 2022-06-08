using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ucakotomasyon
{
    public partial class HataBox : Form
    {       
        public HataBox()
        {
            InitializeComponent();
          
        }
        public static String mesaj, text;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void guna2GradientPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void HataYazdir(String mesaj, String text)
        {
            hatamesaj.Text = mesaj;
            hatayazi.Text = text;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void HataBox_Load_1(object sender, EventArgs e)
        {
            HataYazdir(mesaj, text);

        }

       


    }
}
