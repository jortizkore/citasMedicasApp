using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Configuracion;

namespace WindowsFormsApp1
{
    class Citas
    {
        DBConexion db;
        public string NoCedula { get; set; }
        public DateTime FechaCita { get; set; }
        public int MotivoCita { get; set; }
        public string Comentario { get; set; }

        bool Guardar()
        {
            db = new DBConexion();
            var query = "INSERT INTO citas (NoCedula, FechaCita, MotivoCita, ComentarioMedico)" +
                        $" VALUES ('{NoCedula}','{FechaCita}',{MotivoCita},'{Comentario}')";
            if (db.ExcecuteQuery(query))
            {
                MessageManager.AlerMessage("se guardo correctamente");
            }
            else
            {
                MessageManager.AlerMessage("");

            }

            return true;
        }

        bool Editar()
        {
            db = new DBConexion();
            var query = $"update citas set " +
                $" FechaCitas = '{FechaCita}' , MotivoCita = {MotivoCita} , ComentarioMedico = '{Comentario}' " +
                $" where NoCedula = '{NoCedula}'";
            if (db.ExcecuteQuery(query))
            {
                MessageManager.AlerMessage(" correctamente");
            }
            else
            {
                MessageManager.AlerMessage("");

            }

            return true;
        }
        bool Eliminar()
        {
            db = new DBConexion();
            var query = $"DELECTE FROM citas " +
                $"where NoCedula = '{NoCedula}' and FechaCita = '{FechaCita}'";
            return true;
        }
        
        DataTable TraerCitas()
        {
            DataTable datos = new DataTable();
            db = new DBConexion();
            return datos;
        }
    }
}
