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

        public bool Guardar()
        {
            db = new DBConexion();
            var query = "INSERT INTO citas (NoCedula, FechaCita, MotivoCita, ComentarioMedico)" +
                        $" VALUES ('{NoCedula}','{FechaCita.Date}',{MotivoCita},'{Comentario}')";
            
            return db.ExcecuteQuery(query);
        }

        public bool Editar()
        {
            db = new DBConexion();
            var query = $"update citas set " +
                $" FechaCita = '{FechaCita.Date}', ComentarioMedico = '{Comentario}' " +
                $" where NoCedula = '{NoCedula}' AND MotivoCita = {MotivoCita} ";
            
            return db.ExcecuteQuery(query);
        }
        public bool Eliminar()
        {
            db = new DBConexion();
            var query = $"DELECTE FROM citas " +
                $"where NoCedula = '{NoCedula}' and FechaCita = '{FechaCita}'";
            return db.ExcecuteQuery(query);
        }

        public DataTable TraerCitas()
        {
            db = new DBConexion();
            var query = "Select * from citas";
            return db.BringData(query);
        }

        public DataTable TraerCitas(string cedula)
        {
            db = new DBConexion();
            var query = $"Select * from citas WHERE cliente='{cedula}'";
            return db.BringData(query);
        }
    }
}
