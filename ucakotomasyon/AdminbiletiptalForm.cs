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
    public partial class AdminbiletiptalForm : Form
    {
        public AdminbiletiptalForm()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();
        DataSet data = new DataSet();
        String konu,icerik;
        public static String talepid, biletid, iptalkoltukid, iptalucusid, iptalkisiid,iptalkisiad,iptalkisisoyad,iptalkisimail;
        private void AdminbiletiptalForm_Load(object sender, EventArgs e)
        {

            try
            {
                //Tabloya uçuşları listeleme
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlDataAdapter dr = new MySqlDataAdapter("SELECT * FROM iptaltalebi", SqlBaglanti.baglanti);
                data = new DataSet();
                dr.Fill(tablo);
                ucustable.DataSource = tablo;
                ucustable.Refresh();

            }
            catch (Exception ex)
            {

            }



        }

        String doluluk = "BOS";

        public static String silinenkoltuk;
        private void guncellebuton_Click(object sender, EventArgs e)
        {

            try
            {
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlCommand sehiridcekme = new MySqlCommand("SELECT yolcu_adi,yolcu_soyadi,yolcu_mail FROM yolcular WHERE (yolcu_id=@yolcu)", SqlBaglanti.baglanti);
                sehiridcekme.Parameters.AddWithValue("@yolcu", iptalkisiid);
                MySqlDataReader dr = sehiridcekme.ExecuteReader();
                if (dr.Read())
                {
                    //seçilen hücrenin içindeki şehrin adını lbl yazdırma
                     iptalkisiad= (dr["yolcu_adi"]).ToString();
                     iptalkisisoyad= (dr["yolcu_soyadi"]).ToString();
                     iptalkisimail= (dr["yolcu_mail"]).ToString();

                }
                SqlBaglanti.baglanti.Close();
            }
            catch
            {

            }

            try
            {
                //biletler tablosundan seçilen bileti silme
                SqlBaglanti.baglanti.Close();
                SqlBaglanti.baglanti.Open();
                MySqlCommand biletsilme = new MySqlCommand("DELETE FROM biletler_has_yolcular WHERE biletler_bilet_id=@biletid", SqlBaglanti.baglanti);
                biletsilme.Parameters.AddWithValue("@biletid", biletid);
                biletsilme.ExecuteNonQuery();



                //talepler tablosundan seçilen bileti silme
                MySqlCommand talepsilme = new MySqlCommand("DELETE FROM iptaltalebi WHERE talep_id=@talepid", SqlBaglanti.baglanti);
                talepsilme.Parameters.AddWithValue("@talepid", talepid);
                talepsilme.ExecuteNonQuery();

                //Silinen biletlerin koltuklarını boşa çevirme
                MySqlCommand koltukguncelle = new MySqlCommand("UPDATE koltuklar_has_ucaklar SET dolubos=@doluluk WHERE ucuslar_ucus_id=@ucusid AND koltuklar_koltuk_id=@koltuk", SqlBaglanti.baglanti);
                koltukguncelle.Parameters.AddWithValue("@ucusid", iptalucusid);
                koltukguncelle.Parameters.AddWithValue("@koltuk", iptalkoltukid);
                koltukguncelle.Parameters.AddWithValue("@doluluk", doluluk);
                koltukguncelle.ExecuteNonQuery();
                SqlBaglanti.baglanti.Close();
                HataBox f = new HataBox();
                HataBox.mesaj = "Bilet Silme";
                HataBox.text = "Bilet Başarıyla Silindi";
                f.hataresim.Visible = false;
                f.onayresim.Visible = true;
                f.Show();


                konu = "TUNEX TURİZM BİLET İPTAL TALEBİNİZ ONAYLANMIŞTIR.";

                icerik = "<html>" +
                                                       "<div align=center><img src = https://i.hizliresim.com/qeh85fy.png  width=350px height=100px   alt=\"TUNEX TURİZM\"></div>" +
                                                       " <head>" +
                                                       "  <meta http-equiv='Content-Type' content='text/html; charset=utf-8'/>" +
                                                       "  <style type='text/css'>" +

                                                       " .onayla" +
                                                       " {" +
                                                            " background-color:#33FFFF;" +
                                                            " cursor:pointer;" +
                                                            " height:50px;" +
                                                            "  width:398px;" +
                                                            " color:#FFFFFF;" +
                                                       " }" +
                                                       " .onayla:hover" +
                                                       " {" +
                                                            " background-color:#66CDAA;" +
                                                       " }" +
                                                       " .onayla:active" +
                                                       " {" +
                                                            " background-color:#2E8B57;" +
                                                       " }" +
                                                       " .onayla a" +
                                                       " {" +
                                                            " text-decoration:none;" +
                                                            " color:white;" +
                                                            " width:100%;" +
                                                            " height:100%;" +
                                                            " display:block;" +
                                                            " padding-top:13px;" +
                                                            " overflow:hidden;" +
                                                       " }" +


                                                       " .link1" +
                                                       " {" +
                                                            " background-color:#6633FF;" +
                                                            "cursor:pointer;" +
                                                            " height:50px;" +
                                                            " width:400px;" +
                                                            "color:#FFFFFF;" +
                                                       " }" +
                                                       " .link1:hover" +
                                                       " {" +
                                                            " background-color:#FFA07A;" +
                                                       " }" +
                                                       " .link1:active" +
                                                       " {" +
                                                            " background-color:#CD5C5C;" +
                                                       " }" +
                                                       " .link1 a" +
                                                       " {" +
                                                            " text-decoration:none;" +
                                                            " color:white;" +
                                                            " width:100%;" +
                                                            " height:100%;" +
                                                            " display:block;" +
                                                            " padding-top:13px;" +
                                                            " overflow:hidden;" +
                                                       " }" +


                                                       " .link2" +
                                                       " {" +
                                                            " background-color:#1E90FF;" +
                                                            " cursor:pointer;" +
                                                            " color:#FFFFFF;" +
                                                            " width:800px;" +
                                                            "height:50px;" +
                                                       " }" +
                                                       " .link2:hover" +
                                                       " {" +
                                                            " background-color:#00BFFF;" +
                                                       " }" +
                                                       " .link2:active" +
                                                       " {" +
                                                            " background-color:#0000FF;" +
                                                       " }" +
                                                       " .link2 a" +
                                                       " {" +
                                                            " text-decoration:none;" +
                                                            " color:white;" +
                                                            " width:100%;" +
                                                            " height:100%;" +
                                                            " display:block;" +
                                                            " padding-top:13px;" +
                                                            " overflow:hidden;" +
                                                       " }" +
                                                       " </style>" +
                                                       " </head>" +
                                                       " <body>" +
                                                         " <table border='1' cellpadding='0' cellspacing='0' align='center'>" +
                                                           " <tr>" +
                                                             " <td align='center' style='height:50px; width:800px;'  bgcolor='6633CC'><b><font color='FFFFFF'>TUNEX TURİZM BİLET İPTAL TALEBİNİZ ONAYLANMIŞTIR.</font></b></td>" +
                                                           " </tr>" +
                                                         " </table>" +



                                                         " <table border='1' cellpadding='0' cellspacing='0' align='center'>" +
                                                           " <td align='center' height='30' width='800' bgcolor='DCDCDC'><b>İPTAL BİLGİLERİ</b></td>" +
                                                         " </table>" +

                                                         " <table border='1' cellpadding='0' cellspacing='0' align='center'>" +
                                                           " <td align='right' height='100' width='200' bgcolor='DCDCDC'><b>SAYIN</b> <br> <b>KOLTUK NO: </b> <br> <b>BİLET NO: </b> <br> <b>BİLGİ: </b> <br><br></b></td>" +
                                                           " <td align='left' height='100' width='598'>: "+ iptalkisiad+" "+iptalkisisoyad + " <br>" + iptalkoltukid + "<br>"+ biletid + "<br> YUKARIDA BİLGİLERİ VERİLEN iPTAL TALEBİ OLUŞTURULMUŞ UÇUŞ BİLETİNİZİN İPTAL İŞLEMLERİ TAMAMLANMIŞTIR. </td>" +
                                                         " </table>" +



                                                         " <table border='1' cellpadding='0' style='height:50px; width:800px;' cellspacing='0' align='center'>" +
                                                           " <tr>" +
                                                             " <td class='onayla' align='center'> <a href='http://digitalepinsatis.com/prestashop/tr/'>Diğer Şirketlerimiz(DigitalE-PİN)</a> </td>" +
                                                             " <td class='link1' align='center'> <a href='https://www.instagram.com/emreekrnfl/'>Destek ve iletişim için Tıkla</a> </td>" +
                                                           " </tr>" +
                                                         " </table>" +

                                                         " <table border='1' cellpadding='0' cellspacing='0' align='center'>" +
                                                           " <td class='link2' align='center'> <a href='https://www.google.com'>Kullanım Şartları</a> </td>  " +
                                                         " </table> " +
                                                       " </body>" +
                                                       " </html>";
                mailgonder email = new mailgonder();
                email.mailyolla(iptalkisimail, konu, icerik);
                HataBox f12 = new HataBox();
                HataBox.mesaj = "Bilet bilgisi";
                HataBox.text = iptalkisiad + " " + iptalkisisoyad + " İsimli \nKullanıcının Mail Adresine \nBilgilendirme Yapılmıştır.";
                f12.hataresim.Visible = false;
                f12.onayresim.Visible = true;
                f12.Show();


            }
            catch (Exception ex)
            {
                HataBox f1 = new HataBox();
                HataBox.mesaj = "bilet Silme";
                HataBox.text = "Hata";
                f1.hataresim.Visible = true;
                f1.onayresim.Visible = false;
                f1.Show();
            }

            tablo.Clear();
            AdminbiletiptalForm_Load(null, null);

        }

        private void ucustable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satirsayisi = e.RowIndex;

            // tablodan gerekli verileri değişkenlere atma
            talepid = ucustable.Rows[satirsayisi].Cells[0].Value.ToString();
            biletid = ucustable.Rows[satirsayisi].Cells[1].Value.ToString();
            iptalkoltukid = ucustable.Rows[satirsayisi].Cells[3].Value.ToString();
            iptalucusid = ucustable.Rows[satirsayisi].Cells[2].Value.ToString();
            iptalkisiid = ucustable.Rows[satirsayisi].Cells[4].Value.ToString();
       
        }
    }
}
