using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Net.Mail;
using System.Threading.Tasks;
using WindowsFormsApp1.Configuracion;

namespace EmailReminderAgent.email
{
    class EmailSender
    {
        private MailMessage sender;
        
        public void SendMail(string to, string body)
        {
            var SmtpServerHost = ConfigurationSettings.AppSettings["SmtpServerHost"];
            var SmtpServerPort = int.Parse(ConfigurationSettings.AppSettings["SmtpServerPort"]);
            var SmtpServerUserName = ConfigurationSettings.AppSettings["SmtpServerUserName"];
            var SmtpServerPassword = ConfigurationSettings.AppSettings["SmtpServerPassword"];
            var CorreoDelCentro = ConfigurationSettings.AppSettings["CorreoCentro"];

            sender = new MailMessage();
            sender.SubjectEncoding = Encoding.UTF8;
            sender.BodyEncoding = Encoding.UTF8;
            sender.To.Add(to);
            sender.CC.Add(CorreoDelCentro);
            

            sender.Subject = "TEST SUBJECT";
            sender.Body = body;
            sender.IsBodyHtml = false;
            sender.From = new MailAddress("citaMedica@reminder.com");

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
                MessageManager.ErrorMessage(e.Message);
            }

        }
    }
}
