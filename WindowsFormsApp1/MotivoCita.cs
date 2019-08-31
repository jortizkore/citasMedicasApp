using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Configuracion;

namespace WindowsFormsApp1
{
    class MotivoCita
    {
        DBConexion db;


        public DataTable TraerMotivosCita()
        {
            db = new DBConexion();
            var query = "Select * from motivo_cita";
            return db.BringData(query);
        }

    }
}
