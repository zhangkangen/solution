using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SendEmailTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MailAddress fromAddress = new MailAddress("robotmsg@126.com");
            MailAddress toAddress = new MailAddress("kangeneral@126.com");

            MailMessage mail = new MailMessage(fromAddress, toAddress);
            mail.Subject = "新的书籍";
            mail.Body = "查看这些新书";
            mail.IsBodyHtml = true;
            mail.BodyEncoding = Encoding.Default;
            mail.Priority = MailPriority.Normal;

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.126.com";
            client.Port = 25;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("robotmsg@126.com", "q1w2e3r4");
            //client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Send(mail);
        }
    }
}
