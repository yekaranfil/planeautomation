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
    public partial class _72koltukform : Form
    {
        public _72koltukform()
        {
            InitializeComponent();

        }

        public List<String> butonlist = new List<String>();
        public List<String> secilenler = new List<String>();
        int sayac = 0;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void ustpanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        int kisi;
        int secilensayac = 0;

        public void btn_Click(object sender, EventArgs e)
        {
            //kişi kontrol
            if (AnaSayfa.kisiindex == 0)
            {
                kisi = 1;
            }
            else
            {
                kisi = int.Parse(AnaSayfa.kisisayisi);
            }

            // KOLTUK SEÇERKENKİ RENK AYARLAMALARI
            sayac++;
            Button btn = (Button)sender;

            if (sayac < kisi + 1)
            {
                if (btn.ForeColor == Color.Gray)
                {
                    btn.BackgroundImage = ucakotomasyon.Properties.Resources.Secili1;
                    btn.ForeColor = Color.Green;

                    secilenler.Add(btn.Name);
                    koltuklbl.Text += secilenler[0].ToString() + " - ";
                    secilenler.Clear();
                }
                else
                {
                    if (btn.ForeColor == Color.Green)
                    {
                        sayac = 0;
                        String degisken = koltuklbl.Text.Substring(0, koltuklbl.Text.Length - (btn.Name.Length + 3));
                        btn.BackgroundImage = ucakotomasyon.Properties.Resources.Bos1;
                        secilenler.Remove(btn.Name);
                        koltuklbl.Text = degisken;
                        btn.ForeColor = Color.Gray;
                    }
                }

            }
            else
            {
                if (btn.ForeColor == Color.Green)
                {
                    sayac = 0;
                    String degisken = koltuklbl.Text.Substring(0, koltuklbl.Text.Length - (btn.Name.Length + 3));
                    btn.BackgroundImage = ucakotomasyon.Properties.Resources.Bos1;
                    secilenler.Remove(btn.Name);
                    koltuklbl.Text = degisken;
                    btn.ForeColor = Color.Gray;
                }
            }



        }
    }
}
