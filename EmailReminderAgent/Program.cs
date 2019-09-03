using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsFormsApp1;
using WindowsFormsApp1.Configuracion;
using EmailReminderAgent.email;

namespace EmailReminderAgent
{
    class Program
    {
        private string nombreApp = "Citas Meidcas";
        private string piePagina = "--------------------------------------";
        static void Main(string[] args)
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
                     Comentario= cita["ComentarioMedico"].ToString()

                 });
            }

            if (ListaDeCitas.Count > 0)
            {
                foreach (var cita in ListaDeCitas)
                {
                    var diasRestantes = cita.FechaCita.Subtract(DateTime.Now).Days;
                    if (diasRestantes == 1)
                    {
                        email.EmailSender mailsSender = new EmailSender();
                        Cliente cli = new Cliente();
                        cli.NoCedula = cita.NoCedula;
                        if (cli.Llenar())
                        {   
                            mailsSender.SendMail(cli.Email,"wilmertavarez1313@gmail.com","CItas medicas mail");
                        }
                        
                    }
                            
                }
            }

        }


        void Wait(int minutes)
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
