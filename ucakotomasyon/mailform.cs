using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucakotomasyon
{
    public partial class mailform : Form
    {
        public mailform()
        {
            InitializeComponent();
        }
        String kime, konu, icerik;

       
        String icerik2 = "<html>" +
                                                       " <head>" +
                                                       "  <meta http-equiv='Content-Type' content='text/html; charset=utf-8'/>" +
                                                       "  <style type='text/css'>" +

                                                       " .onayla" +
                                                       " {" +
                                                            " background-color:#3CB371;" +
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


                                                       " .mutabikdegil" +
                                                       " {" +
                                                            " background-color:#FA8072;" +
                                                            "cursor:pointer;" +
                                                            " height:50px;" +
                                                            " width:400px;" +
                                                            "color:#FFFFFF;" +
                                                       " }" +
                                                       " .mutabikdegil:hover" +
                                                       " {" +
                                                            " background-color:#FFA07A;" +
                                                       " }" +
                                                       " .mutabikdegil:active" +
                                                       " {" +
                                                            " background-color:#CD5C5C;" +
                                                       " }" +
                                                       " .mutabikdegil a" +
                                                       " {" +
                                                            " text-decoration:none;" +
                                                            " color:white;" +
                                                            " width:100%;" +
                                                            " height:100%;" +
                                                            " display:block;" +
                                                            " padding-top:13px;" +
                                                            " overflow:hidden;" +
                                                       " }" +


                                                       " .ilgilikisidegil" +
                                                       " {" +
                                                            " background-color:#1E90FF;" +
                                                            " cursor:pointer;" +
                                                            " color:#FFFFFF;" +
                                                            " width:800px;" +
                                                            "height:50px;" +
                                                       " }" +
                                                       " .ilgilikisidegil:hover" +
                                                       " {" +
                                                            " background-color:#00BFFF;" +
                                                       " }" +
                                                       " .ilgilikisidegil:active" +
                                                       " {" +
                                                            " background-color:#0000FF;" +
                                                       " }" +
                                                       " .ilgilikisidegil a" +
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
                                                             " <td align='center' style='height:50px; width:800px;'  bgcolor='3CB371'><b><font color='FFFFFF'>TUNEX TURİZM BİLET FATURASI</font></b></td>" +
                                                           " </tr>" +
                                                         " </table>" +

                                                         " <table border='1' cellpadding='0' cellspacing='0' align='center'>" +
                                                           " <tr>" +
                                                             " <td align='left' height='100' width='400'>Gönderen:TUNEX TURİZM.LTD.ŞTİ <br> <b>Bilet Türü: BUSSİNES</b> <br> <b>Bilet Numarası: 111111111</b></td> " +
                                                             " <td align='left' height='100' width='398'>Firma:" + "FİRMA ADI" + " <br> <b>Uçuş Tarihi ve Saati: " + "09.09.22 05.45" + "</b> <br> <b>Nereden-Nereye:" + "Ankara - Konya" + "</b></td>" +
                                                           " </tr>" +
                                                         " </table>" +

                                                         " <table border='1' cellpadding='0' cellspacing='0' align='center'>" +
                                                           " <td align='center' height='30' width='800' bgcolor='DCDCDC'><b>Ödeme Detayları</b></td>" +
                                                         " </table>" +

                                                         " <table border='1' cellpadding='0' cellspacing='0' align='center'>" +
                                                           " <td align='right' height='100' width='200' bgcolor='DCDCDC'><b>Fatura Tarihi:</b> <br> <b>Bilet Tutarı:</b> <br> <b>Bilet Türü:</b> <br> <b>Koltuk numarası:</b> <br></b></td>" +
                                                           " <td align='left' height='100' width='598'> 10.06.2022 <br>" + "450" + "<br> BUSSİNES <br> 25 </td>" +
                                                         " </table>" +

                                                         " <table border='1' cellpadding='0' cellspacing='0' align='center'>" +
                                                           " <td height='100' width='800'>Uçuş Biletiniz Başarıyla Tanımlanmıştır! Bizi ettiğiniz için teşekkür eder iyi yolculuklar dileriz - TUNEX TURİZM LTD.ŞTİ (BİLET İPTAL TALEBİ OLUŞTURMAK İSTİYORSANIZ UYGULAMA ÜZERİNDEN İPTAL TALEBİ SEKMESİNİ KULLANARAK BİLETİNİZİ İPTAL ETTİREBİLİRSİNİZ.) </td>" +
                                                         " </table>" +

                                                         " <table border='1' cellpadding='0' style='height:50px; width:800px;' cellspacing='0' align='center'>" +
                                                           " <tr>" +
                                                             " <td class='onayla' align='center'> <a href='http://digitalepinsatis.com/prestashop/tr/'>Diğer Şirketlerimiz(DigitalE-PİN)</a> </td>" +
                                                             " <td class='mutabikdegil' align='center'> <a href='https://www.instagram.com/emreekrnfl/'>Destek ve iletişim için Tıkla</a> </td>" +
                                                           " </tr>" +
                                                         " </table>" +

                                                         " <table border='1' cellpadding='0' cellspacing='0' align='center'>" +
                                                           " <td class='ilgilikisidegil' align='center'> <a href='https://www.google.com'>Kullanım Şartları</a> </td>  " +
                                                         " </table> " +
                                                       " </body>" +
                                                       " </html>";


        String icerik3 = "<html>" +
                                                       "<div align=center><img src = https://i.hizliresim.com/qeh85fy.png  width=350px height=100px   alt=\"TUNEX TURİZM\"></div>" +
                                                       " <head>" +
                                                       "  <meta http-equiv='Content-Type' content='text/html; charset=utf-8'/>" +
                                                       "  <style type='text/css'>"+

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
                                                             " <td align='center' style='height:50px; width:800px;'  bgcolor='6633CC'><b><font color='FFFFFF'>TUNEX TURİZM BİLET FATURASI</font></b></td>" +
                                                           " </tr>" +
                                                         " </table>" +

                                                         " <table border='1' cellpadding='0' cellspacing='0' align='center'>" +
                                                           " <tr>" +
                                                             " <td align='left' height='100' width='400'>Gönderen: TUNEX TURİZM.LTD.ŞTİ <br> <b>Bilet Türü: BUSSİNES</b> <br> <b>Bilet Numarası: 111111111</b></td> " +
                                                             " <td align='left' height='100' width='398'>Firma: " + "FİRMA ADI" + " <br> <b>Uçuş Tarihi ve Saati: " + "09.09.22 05.45" + "</b> <br> <b>Nereden-Nereye: " + "Ankara - Konya" + "</b></td>" +
                                                           " </tr>" +
                                                         " </table>" +

                                                         " <table border='1' cellpadding='0' cellspacing='0' align='center'>" +
                                                           " <td align='center' height='30' width='800' bgcolor='DCDCDC'><b>Ödeme Detayları</b></td>" +
                                                         " </table>" +

                                                         " <table border='1' cellpadding='0' cellspacing='0' align='center'>" +
                                                           " <td align='right' height='100' width='200' bgcolor='DCDCDC'><b>Fatura Tarihi: </b> <br> <b>Bilet Tutarı: </b> <br> <b>Bilet Türü: </b> <br> <b>Koltuk numarası: </b> <br></b></td>" +
                                                           " <td align='left' height='100' width='598'> 10.06.2022 <br>" + "450" + "<br> BUSSİNES <br> 25 </td>" +
                                                         " </table>" +

                                                         " <table border='1' cellpadding='0' cellspacing='0' align='center'>" +
                                                           " <td height='100' width='800'>Uçuş Biletiniz Başarıyla Tanımlanmıştır! Bizi ettiğiniz için teşekkür eder iyi yolculuklar dileriz - TUNEX TURİZM LTD.ŞTİ (BİLET İPTAL TALEBİ OLUŞTURMAK İSTİYORSANIZ UYGULAMA ÜZERİNDEN İPTAL TALEBİ SEKMESİNİ KULLANARAK BİLETİNİZİ İPTAL ETTİREBİLİRSİNİZ.) </td>" +
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
        private void gonderbtn_Click(object sender, EventArgs e)
        {
        }

        private void mailform_Load(object sender, EventArgs e)
        {
           
        }

        private void mailgonder(String kime, String konu, String icerik)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.office365.com";
            sc.EnableSsl = true;
            kime = kimebox.Text;
            konu = konubox.Text;
            

            sc.Credentials = new NetworkCredential("tunexturizm@outlook.com", "75952.yek");
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("tunexturizm@outlook.com");
            mail.To.Add(kime);
            mail.Subject = konu;
            mail.IsBodyHtml = true;
            mail.Body = icerik;
            sc.Send(mail);
            MessageBox.Show("Mail Gönderildi1");
        }


        private void button1_Click(object sender, EventArgs e)
        {

            mailgonder(kimebox.Text,konubox.Text,icerik3);
         
            

        }
    }
}
