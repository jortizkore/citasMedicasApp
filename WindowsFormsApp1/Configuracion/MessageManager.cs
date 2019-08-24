using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Configuracion
{
    public static class MessageManager
    {
        public static void InfoMessage(string message)
        {
            MessageBox.Show(message,
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static void AlerMessage(string message)
        {
            MessageBox.Show(message,
                     "Alert",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Exclamation);
        }

        public static void ErrorMessage(string message)
        {
            MessageBox.Show(message,
                     "Error",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
        }
        public static DialogResult Question(string question)
        {
            return MessageBox.Show(question,
                    "Are you sure?",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Exclamation);
        }
    }
}
