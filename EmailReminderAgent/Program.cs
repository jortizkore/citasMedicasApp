using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsFormsApp1;
using System.Configuration;
using WindowsFormsApp1.Configuracion;
using EmailReminderAgent.email;

namespace EmailReminderAgent
{
    class Program
    {
        private string nombreApp = "Citas Meidcas";
        private string piePagina = "--------------------------------------";
        private static string DiasParaEnviarMails = ConfigurationSettings.AppSettings["DiasParaEnviarMails"];

        static void Main(string[] args)
        {
            while (true)
            {
                BuscarCitasPendientes();
                Wait(1);
            }
        }

        static void BuscarCitasPendientes()
        {
            Citas citas = new Citas();
            List<Citas> ListaDeCitas = new List<Citas>();

            foreach (DataRow cita in citas.TraerCitas().Rows)
            {
                ListaDeCitas.Add(new Citas()
                {
                    NoCedula = cita["NoCedula"].ToString(),
                    FechaCita = DateTime.Parse(cita["FechaCita"].ToString()),
                    MotivoCita = int.Parse(cita["MotivoCita"].ToString()),
                    Comentario = cita["ComentarioMedico"].ToString()

                });
            }

            if (ListaDeCitas.Count > 0)
            {
                foreach (var cita in ListaDeCitas)
                {
                    var diasRestantes = cita.FechaCita.Subtract(DateTime.Now.Date).Days;

                    email.EmailSender mailsSender = new EmailSender();
                    Cliente cli = new Cliente();
                    cli.NoCedula = cita.NoCedula;
                    if (cli.Llenar())
                    {
                        var send = DiasParaEnviarMails.Split(',').Any(d => d == diasRestantes.ToString());
                        if (send)
                        {
                            // mailsSender.SendMail(cli.Email, CrearCuerpoCorreo(cli, cita));
                        }
                    }
                }
            }
        }

        static string CrearCuerpoCorreo(Cliente cli, Citas cita)
        {
            var motivoCita = new MotivoCita();
            motivoCita.Llenar(cita.MotivoCita);
            var centro = ConfigurationSettings.AppSettings["NombreCentro"];
            string cuerpo =
                $"Estimado {cli.Nombre}, le recordamos asistir al centro {centro} \n" +
                $"el {cita.FechaCita.ToString("dd/MM/yyyy")}. \n" +
                $"El motivo de la cita es: {motivoCita.Descripcion} \n" +
                $"Feliz resto del día, le esperamos.";

            return cuerpo;
        }

        static void Wait(int minutes)
        {
            var end = DateTime.Now.AddMinutes(minutes);
            while (true)
            {
                Thread.Sleep(110);
                if (DateTime.Now > end)
                    return;
            }
        }
    }
}
