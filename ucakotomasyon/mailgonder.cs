using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucakotomasyon
{
    internal class mailgonder
    {
        String kime, konu, icerik;

        public void mailyolla(String kime, String konu, String icerik)
        {
            SmtpClient sc = new SmtpClient();

            sc.Port = 587;
            sc.Host = "smtp.office365.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential("tunexturizm@outlook.com", "pass");
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("tunexturizm@outlook.com");
            mail.To.Add(kime);
            mail.Subject = konu;
            mail.IsBodyHtml = true;
            mail.Body = icerik;
            sc.Send(mail);
            
        }
    }
}
