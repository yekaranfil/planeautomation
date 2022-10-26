/*
 *  DO NOT ALTER OR REMOVE COPYRIGHT NOTICES OR THIS FILE HEADER.
 *
 *  Copyright © (C) 2022 Tunex Digital Yazılım Ltd Şti - All Rights Reserved
 *  Unauthorized copying of this file, via any medium is strictly prohibited
 *  Proprietary and confidential.
 *  
 *  Copyright ©  August 2022 Tunex Digital @ http://tunexdigital.com
 *  
 *  Written by Yusuf Emre Karanfil & M.Sait Kocabaş <emrekaranfil@tunexdigital.com>, August 2022
 *   :Contributors:
 *        Y.Emre Karanfil
 *        M.Sait Kocabaş
 *        Necmettin Zıvlak
 */
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
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
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

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            // uçuşekleme formunu panele basma
            islemlerpanel.Controls.Clear();
            SeferEkleForm seferform = new SeferEkleForm();
            seferform.TopLevel = false;
            islemlerpanel.Controls.Add(seferform);
            seferform.Show();
            seferform.Dock = DockStyle.Fill;
            seferform.BringToFront();

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            // ucak ekleme formunu panele basma
            islemlerpanel.Controls.Clear();
            AdminUcusEkleForm ucakekleform = new AdminUcusEkleForm();
            ucakekleform.TopLevel = false;
            islemlerpanel.Controls.Add(ucakekleform);
            ucakekleform.Show();
            ucakekleform.Dock = DockStyle.Fill;
            ucakekleform.BringToFront();
        }

        private void ucakguncellebuton_Click(object sender, EventArgs e)
        {
            // ucak günncelleme formunu panele basma
            islemlerpanel.Controls.Clear();
            UcakGuncelle ucakguncelle = new UcakGuncelle();
            ucakguncelle.TopLevel = false;
            islemlerpanel.Controls.Add(ucakguncelle);
            ucakguncelle.Show();
            ucakguncelle.Dock = DockStyle.Fill;
            ucakguncelle.BringToFront();


        }
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            // uçuş güncelleme formunu panele basma
            islemlerpanel.Controls.Clear();
            UcusGuncelleForm ucusguncelle = new UcusGuncelleForm();
            ucusguncelle.TopLevel = false;
            islemlerpanel.Controls.Add(ucusguncelle);
            ucusguncelle.Show();
            ucusguncelle.Dock = DockStyle.Fill;
            ucusguncelle.BringToFront();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            // destek formunu panele basma
            islemlerpanel.Controls.Clear();
            AdminDestekForm admindestek = new AdminDestekForm();
            admindestek.TopLevel = false;
            islemlerpanel.Controls.Add(admindestek);
            admindestek.Show();
            admindestek.Dock = DockStyle.Fill;
            admindestek.BringToFront();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            // bilet güncelle formunu panele basma
            islemlerpanel.Controls.Clear();
            AdminbiletiptalForm iptalform = new AdminbiletiptalForm();
            iptalform.TopLevel = false;
            islemlerpanel.Controls.Add(iptalform);
            iptalform.Show();
            iptalform.Dock = DockStyle.Fill;
            iptalform.BringToFront();
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            kullanicilbl.Text = AdminGiris.adminkullanici.ToString();
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminformkapatma_Click(object sender, EventArgs e)
        {

        }
    }
}
