using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Configuracion
{
    public class DBConexion
    {
        private const string server = @"(LocalDB)\MSSQLLocalDB";
        private const string database = "citas_medicas_db";
        private string conStr = "";

        private SqlConnection connection = new SqlConnection();
        private SqlCommand command = new SqlCommand();
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private DataTable table = new DataTable();

        public DBConexion()
        {
            setConnectionSettings();
        }

        private void setConnectionSettings()
        {
            this.conStr = $"Server={server};Database={database};Trusted_Connection=True;";
            this.connection = new SqlConnection(this.conStr);
            this.command = new SqlCommand();
            this.command.Connection = this.connection;
        }

        public DataTable BringData(string query)
        {
            this.command.CommandType = CommandType.Text;
            this.command.CommandText = query;
            this.table = new DataTable();

            if (this.connect())
            {
                adapter.SelectCommand = this.command;
                adapter.Fill(this.table);
            }
            this.Disconnect();

            var result = this.table;
            return result;
        }

        public string bringJsonData(string query)
        {
            this.command.CommandType = CommandType.Text;
            this.command.CommandText = query;
            if (this.connect())
            {
                adapter.SelectCommand = this.command;
                adapter.Fill(table);
            }
            Disconnect();
            var response = table.Rows.Count > 0;
            return response ? JsonConvert.SerializeObject(this.table) : string.Empty;
        }

        public bool IsConnected()
        {
            bool isConnected = this.connection.State == ConnectionState.Open;
            return isConnected;
        }

        public bool connect()
        {
            try
            {
                this.connection.Open();
                return true;
            }
            catch (Exception )
            {
                Disconnect();
            };
            return false;
        }

        public void Disconnect()
        {
            try
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }
            catch (Exception es)
            {
                throw es;
            }
        }


        // HERE Hacer un try en cada ejecusion en la base de datos para con el finally desconectar la app

        public bool CorrerSP(string sp)
        {
            this.command.CommandType = CommandType.StoredProcedure;
            this.command.CommandText = sp;
            if (this.connect())
            {
                this.command.ExecuteNonQuery();
                Disconnect();
                return true;
                
            }
            this.Disconnect();
            return false;
        }

        public bool ExcecuteQuery(string query)
        {
            this.command.CommandType = CommandType.Text;
            this.command.CommandText = query;
            if (this.connect())
            {
                this.command.ExecuteNonQuery();
                this.Disconnect();
                return true;
            }
            this.Disconnect();
            return false;
        }

        public bool CorrerSP(string sp, List<parametro> parametros)
        {
            try
            {
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = sp;

                foreach (var par in parametros)
                {
                    this.command.Parameters.Add(par.nombre, par.tipo).Value = par.valor;
                }

                if (this.connect())
                {
                    this.command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageManager.ErrorMessage(e.Message);
            }
            finally
            {
                Disconnect();
            }
            return false;
        }

    }
}

public class parametro
{
    public string nombre { get; set; }
    public SqlDbType tipo { get; set; }
    public string valor { get; set; }
}
