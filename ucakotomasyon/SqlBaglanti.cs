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
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucakotomasyon
{
    public class SqlBaglanti
    {
        public static string MySqlConnection = ConfigurationManager.ConnectionStrings["Ucakotomasyonsql"].ConnectionString;
        public static MySqlConnection baglanti = new MySqlConnection(MySqlConnection);

    }
}
