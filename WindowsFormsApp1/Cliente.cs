using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Configuracion;

namespace WindowsFormsApp1
{
    public class Cliente
    {
        DBConexion db;
        public string NoCedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NoCelular { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }

        public bool Guardar()
        {
            db = new DBConexion();
            var query = "Insert into cliente (NoCedula,Nombre,Apellido,NoCelular,Email,FechaNac,Direccion)" +
                           $" VALUES ('{NoCedula}','{Nombre}','{Apellido}','{NoCelular}','{Email}','{FechaNacimiento}','{Direccion}')";
            if (db.ExcecuteQuery(query))
            {
                return true;
            }
            return false;
        }

        public bool Editar()
        {
            db = new DBConexion();
            var query = $"UPDATE cliente set Nombre ='{Nombre}'" +
                        $", Apellido = '{Apellido}'" +
                        $", NoCelular = '{NoCelular}'," +
                        $" Email = '{Email}'," +
                        $" FechaNac = '{FechaNacimiento}'," +
                        $" Direccion = '{Direccion}'" +
                        $" WHERE NoCedula = '{NoCedula}'";
            if (db.ExcecuteQuery(query))
            {
                return true;
            }
            return false;
        }

        public bool Eliminar()
        {
            db = new DBConexion();
            var query = "DELTE FROM cliente" +
                           $" WHERE NoCedula='{NoCedula}'";
            if (db.ExcecuteQuery(query))
            {
                return true;
            }
            return false;
        }
     public DataTable TraerClientesTabla()
        {
            db = new DBConexion();
            var query = "Select * from Cliente";
            return db.BringData(query);
        }
        public bool Llenar()
        {
            db = new DBConexion();
            var query = $"SELECT * FROM cliente WHERE NoCedula='{NoCedula}'";
            DataTable data = db.BringData(query);
            if (data.Rows.Count > 0)
            {
                Nombre = data.Rows[0]["Nombre"].ToString();
                Apellido = data.Rows[0]["Apellido"].ToString();
                NoCelular = data.Rows[0]["NoCelular"].ToString();
                Email = data.Rows[0]["Email"].ToString();
                FechaNacimiento = DateTime.Parse(data.Rows[0]["FechaNac"].ToString());
                Direccion = data.Rows[0]["Direccion"].ToString();
                return true;
            }
            return false;
        }
    }
}
