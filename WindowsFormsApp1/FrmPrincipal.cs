using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Mantenimientos;

namespace WindowsFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        Citas Cita;
        Cliente Cliente;
        List<Citas> citasDelDia = new List<Citas>();
        List<Cliente> filtroClientes = new List<Cliente>();
        List<Turno> Turnos = new List<Turno>();
        List<string> MuestraTurnos = new List<string>();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void motivoCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMotivoCitas frm = new FrmMotivoCitas();
            frm.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantenimientoCliente frm = new FrmMantenimientoCliente();
            frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        bool AgregarTurno(string nombre)
        {
            try
            {
                Turnos.Add(new Turno
                {
                    NumeroDeOrden = Turnos.Count + 1,
                    NombrePaciente = nombre,
                    Estado = estado.EnEspera
                });
                return true;
            }
            catch (Exception)
            {

            }
            return false;
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCrearCitas frm = new frmCrearCitas();
            frm.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            CargarCitasDelDia();
            RefrescarTurnos();
        }

        void RefrescarTurnos()
        {

            foreach (var turno in Turnos)
            {
                MuestraTurnos.Add($"{turno.NumeroDeOrden} - {turno.NombrePaciente} : {turno.MostrarEstado()}");
            }

            RefrescarListBox();
        }

        void RefrescarListBox()
        {
            lbMostrarTurnos.Items.Clear();
            foreach (var mostrarTurno in MuestraTurnos)
            {
                lbMostrarTurnos.Items.Add(mostrarTurno);
            }
        }

        List<Citas> citasDeTabla_A_Lista(DataTable datos)
        {
            List<Citas> result = new List<Citas>();
            var cli = new Cliente();

            foreach (DataRow cita in datos.Rows)
            {
                result.Add(new Citas
                {
                    NoCedula = cita["NoCedula"].ToString()
                    ,
                    FechaCita = DateTime.Parse(cita["FechaCita"].ToString())
                    ,
                    MotivoCita = int.Parse(cita["MotivoCita"].ToString())
                    ,
                    Comentario = cita["ComentarioMedico"].ToString()
                });
            }

            return result;
        }

        private void TxtFiltroClientePrincipal_TextChanged(object sender, EventArgs e)
        {
            Cliente = new Cliente();
            filtroClientes = new List<Cliente>();
            DataTable datosCliente = Cliente.TraerClientesTabla(TxtFiltroClientePrincipal.Text);
            filtroClientes = clienteDetabla_A_Lista(datosCliente);
            grdBuscarClientesPrincipal.DataSource = datosCliente;
            grdBuscarClientesPrincipal.AutoResizeColumns();
        }

        void CargarCitasDelDia()
        {
            Cita = new Citas();
            citasDelDia = new List<Citas>();
            citasDelDia = citasDeTabla_A_Lista(Cita.TraerCitasPorfecha(DateTime.Now.Date.ToString("MM/dd/yyyy")));
        }

        List<Cliente> clienteDetabla_A_Lista(DataTable datos)
        {
            try
            {
                var result = new List<Cliente>();
                foreach (DataRow cliente in datos.Rows)
                {
                    result.Add(new Cliente(cliente["NoCedula"].ToString()));
                }
                return result;
            }
            catch (Exception)
            {

            }
            return new List<Cliente>();
        }

        private void grdBuscarClientesPrincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string nombre = grdBuscarClientesPrincipal.Rows[e.RowIndex].Cells[0].Value.ToString();
                AgregarTurno(nombre);
                RefrescarTurnos();
            }
            catch (Exception)
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefrescarTurnos();
        }
    }

    public class Turno
    {
        public int NumeroDeOrden { get; set; }
        public string NombrePaciente { get; set; }
        public estado Estado { get; set; }

        public string MostrarEstado()
        {
            switch (Estado)
            {
                case estado.EnEspera:
                    return "Es espera";
                case estado.Atendiendose:
                    return "Tomando su turno";
                case estado.Completado:
                    return "Completado";
                default:
                    return "";
            }
        }

    }
    public enum estado
    {
        EnEspera,
        Atendiendose,
        Completado
    }
}
