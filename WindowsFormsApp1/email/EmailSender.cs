using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Net.Mail;
using System.Threading.Tasks;

namespace WindowsFormsApp1.email
{
    class EmailSender
    {
        private MailMessage sender;
        
        public void SendMail(string[] to, string[] cc, string body)
        {
            var SmtpServerHost = ConfigurationSettings.AppSettings["SmtpServerHost"];
            var SmtpServerPort = int.Parse(ConfigurationSettings.AppSettings["SmtpServerPort"]);
            var SmtpServerUserName = ConfigurationSettings.AppSettings["SmtpServerUserName"];
            var SmtpServerPassword = ConfigurationSettings.AppSettings["SmtpServerPassword"];

            sender = new MailMessage();
            sender.SubjectEncoding = Encoding.UTF8;
            sender.BodyEncoding = Encoding.UTF8;

            foreach (var person in to)
            {
                sender.To.Add(person);
            }
            foreach (var person in cc)
            {
                sender.To.Add(person);
            }

            sender.Subject = "TEST SUBJECT";
            sender.Body = body;
            sender.IsBodyHtml = false;
            sender.From = new MailAddress(SmtpServerUserName);

            try
            {
                SmtpClient client = new SmtpClient();
                client.Credentials = new NetworkCredential(SmtpServerUserName, SmtpServerPassword);
                client.Port = SmtpServerPort;
                client.EnableSsl = true;
                client.Host = SmtpServerHost;

                client.Send(sender);
            }
            catch (Exception e)
            {
                // HERE THIS SHOULD BE LOGGED IN A LOG FILE
                Configuracion.MessageManager.ErrorMessage(e.Message);
            }

        }
    }
}
