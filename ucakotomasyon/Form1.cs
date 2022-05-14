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
    public partial class Form1 : Form
    {
        int sayac = 0;
        
        

        public Form1()
        {
            InitializeComponent();


            



        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

       

        private void guna2GradientPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void guna2GradientPanel1_MouseEnter(object sender, EventArgs e)
        {

            if (txtgirissifre.Text.Equals(""))
            {
                txtgirissifre.Text = "Şifre";
                txtgirissifre.PasswordChar = '\0';
                sayac = 0;
            }

            if(txtgiris.Text.Equals(""))
            {
                txtgiris.Text = "Kullanıcı adı";
            }

        }
        private void txtgirissifre_KeyPress(object sender, KeyPressEventArgs e)
        {
           

            if (sayac == 0)
            {
                txtgirissifre.Clear();
                sayac++;

            }

            if(txtgirissifre.Text.Equals(""))
            {
                txtgirissifre.PasswordChar = '\0';
            }
            else
            {
                txtgirissifre.PasswordChar = '*';
            }
            
        }

        private void txtgiris_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtgiris.Text.Equals("Kullanıcı adı"))
            {
                txtgiris.Clear();
            }
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
               

        private void destekbutonn_MouseDown(object sender, MouseEventArgs e)
        {

            

            if ((destekbox.Visible == true) || (destekboxcerceve.Visible == true) || (destekgonderb.Visible == true) )
            {
                destekbox.Visible = false;
                destekboxcerceve.Visible = false; 
                destekgonderb.Visible = false;
                destekbox.Clear();
            } else
            {
                destekbox.Visible = true;
                destekboxcerceve.Visible = true;
                destekgonderb.Visible = true;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            destekbox.Visible = false;
            destekboxcerceve.Visible = false;
            destekgonderb.Visible = false;
            destekbox.Clear();
        }

        private void destekgonderb_MouseDown(object sender, MouseEventArgs e)
        {
            destekbox.Visible = false;
            destekboxcerceve.Visible = false;
            destekgonderb.Visible = false;
            destekbox.Clear();
        }

        private void destekgonderb_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
