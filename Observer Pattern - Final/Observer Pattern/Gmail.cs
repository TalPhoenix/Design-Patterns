using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MailUtilities
{
    public class Gmail
    {

        public static void SendGmail(string userName, string password, string mailFrom, string commaDelimCCs, bool isBodyHtml, string mailTo, string subject, string message)
        {

            SmtpClient smtp_server = new SmtpClient("smtp.gmail.com", 587);
            smtp_server.Credentials = new System.Net.NetworkCredential(userName, password);
            smtp_server.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp_server.EnableSsl = true;

            MailMessage e_mail = new MailMessage();
            e_mail.From = new MailAddress(mailFrom);
            e_mail.To.Add(mailTo);
            e_mail.Subject = subject;
            e_mail.IsBodyHtml = false;
            e_mail.Body = message;
            smtp_server.Send(e_mail);
        }

    }
}
