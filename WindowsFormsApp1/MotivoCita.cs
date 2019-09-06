using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Configuracion;

namespace WindowsFormsApp1
{
    public class MotivoCita
    {
        DBConexion db;

        public int ID { get; set; }
        public string Descripcion { get; set; }

        public DataTable TraerMotivosCita()
        {
            db = new DBConexion();
            var query = "Select * from motivo_cita";
            return db.BringData(query);
        }

        public bool Llenar(int id)
        {
            try
            {
                db = new DBConexion();
                DataTable datos = new DataTable();
                datos = db.BringData($"Select * from motivo_cita WHERE idMotivoCita={id}");
                if(datos.Rows.Count > 0)
                {
                    ID = id;
                    Descripcion = datos.Rows[0]["Descripcion"].ToString();
                    return true;
                }
            }
            catch (Exception)
            {
                // HERE I should log this in a log file
            }
            return false;
        }

    }
}
