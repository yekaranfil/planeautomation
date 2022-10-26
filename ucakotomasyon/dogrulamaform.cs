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

        private void dogrulamaform_Load(object sender, EventArgs e)
        {
            txt.Text = Form1.dogrulamamail.ToString();
           
        }

        private void txt_Click(object sender, EventArgs e)
        {

        }
    }
}
