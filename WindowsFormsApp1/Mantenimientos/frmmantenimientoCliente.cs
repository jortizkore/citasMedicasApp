using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Configuracion;
using System.Windows.Forms;

namespace WindowsFormsApp1.Mantenimientos
{
    public partial class FrmMantenimientoCliente : Form
    {
        Cliente cli;

        public FrmMantenimientoCliente()
        {
            InitializeComponent();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cli = new Cliente();
            PasarDatosCliente();
            if (cli.Guardar())
            {
                MessageManager.InfoMessage("Cliente guardado con éxito");
                Refrescar();
            }
            else
            {
                MessageManager.InfoMessage("No pudo completarse el registro");
            }
        }

        void Refrescar()
        {
            LlenarGrid();
            Limpiar();
            IrAlTab(0);
        }

        private void PasarDatosCliente()
        {
            cli.NoCedula = TxtNoCedula.Text;
            cli.Nombre = TxtNombreCliente.Text;
            cli.Apellido = TxtApellidoCliente.Text;
            cli.NoCelular = TxtNoCelularCliente.Text;
            cli.Email = TxtEmailCliente.Text;
            cli.FechaNacimiento = dtFechaNacimientoCliente.Value;
            cli.Direccion = TxtDireccionCliente.Text;
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cli = new Cliente();
            PasarDatosCliente();
            if (cli.Editar())
            {
                MessageManager.InfoMessage("Cliente modificado con éxito");
                Refrescar();
            }
            else
            {
                MessageManager.InfoMessage("No pudo completarse el registro");
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageManager.ErrorMessage("Esta accion no es válida");
        }

        void Limpiar()
        {
            TxtNoCedula.Text = string.Empty;
            TxtNombreCliente.Text = string.Empty;
            TxtApellidoCliente.Text = string.Empty;
            TxtNoCelularCliente.Text = string.Empty;
            TxtEmailCliente.Text = string.Empty;
            TxtDireccionCliente.Text = string.Empty;
            TxtNoCedula.Focus();
        }

        void IrAlTab(int tab)
        {
            tabControl1.SelectTab(tab);
        }

        private void FrmMantenimientoCliente_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        void LlenarGrid()
        {
            cli = new Cliente();
            grdMantenimientoClientes.DataSource = cli.TraerClientesTabla();
        }

        private void grdMantenimientoClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cli = new Cliente();
                var cedula = grdMantenimientoClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                cli.NoCedula = cedula;
                cli.Llenar();
                MoverparaEditar(cli);

            }
            catch (Exception)
            {
                
            }

        }

        void MoverparaEditar(Cliente cl)
        {

            TxtNoCedula.Text = cl.NoCedula;
            TxtNombreCliente.Text = cl.Nombre;
            TxtApellidoCliente.Text = cl.Apellido;
            TxtNoCelularCliente.Text = cl.NoCelular;
            TxtEmailCliente.Text = cl.Email;
            dtFechaNacimientoCliente.Value = cl.FechaNacimiento;
            TxtDireccionCliente.Text = cl.Direccion;
            TxtNoCedula.Enabled = false;
            IrAlTab(1);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
