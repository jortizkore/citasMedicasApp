using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Configuracion;

namespace WindowsFormsApp1.Mantenimientos
{
    public partial class frmCrearCitas : Form
    {
        Citas cita;
        Cliente clienteSeleccionado;
        public frmCrearCitas()
        {
            InitializeComponent();
        }

        private void frmCrearCitas_Load(object sender, EventArgs e)
        {
            RefrescarData();
        }

        void RefrescarData()
        {
            cita = new Citas();
            grdCitasMantenimiento.DataSource = cita.TraerCitas();
            grdCitasMantenimiento.AutoResizeColumns();
            LlenarCmbClientes();
            LlenarCmbMotivoCita();
        }

        void LlenarCmbMotivoCita()
        {
            MotivoCita mc = new MotivoCita();
            CmbMotivoCita.DataSource = mc.TraerMotivosCita();
            CmbMotivoCita.DisplayMember = "Descripcion";
            CmbMotivoCita.ValueMember = "IdMotivoCita";
        }

        void LlenarCmbClientes()
        {
            clienteSeleccionado = new Cliente();
            cmbClienteCita.DataSource = clienteSeleccionado.TraerClientesTabla();
            cmbClienteCita.DisplayMember = "Nombre";
            cmbClienteCita.ValueMember = "NoCedula";
        }

        void IrAlTab(int tab)
        {
            tabControl1.SelectTab(tab);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtFechaCita_ValueChanged(object sender, EventArgs e)
        {

        }

        void Limpiar()
        {
            txtFiltroCitas.Text = string.Empty;
            txtCometarioCita.Text = string.Empty;
            cmbClienteCita.SelectedIndex = 0;
            CmbMotivoCita.SelectedIndex = 0;
            RefrescarData();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar();
            IrAlTab(1);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cita = new Citas();
            PasarValoresCita();
            if (cita.Guardar())
            {
                MessageManager.InfoMessage("Cita programda");
                Limpiar();
                RefrescarData();
                IrAlTab(0);
            }
            else
            {
                MessageManager.AlerMessage("No pudo programarse la cita");
            }
        }

        void PasarValoresCita()
        {
            cita.NoCedula = cmbClienteCita.SelectedValue.ToString();
            cita.Comentario = txtCometarioCita.Text;
            cita.FechaCita = dtFechaCita.Value;
            cita.MotivoCita = int.Parse(CmbMotivoCita.SelectedValue.ToString());

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cita = new Citas();
            PasarValoresCita();
            if (cita.Editar())
            {
                MessageManager.InfoMessage("Cita modificada");
                Limpiar();
                RefrescarData();
                IrAlTab(0);
            }
            else
            {
                MessageManager.AlerMessage("No pudo modificarse la cita");
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cita = new Citas();
            PasarValoresCita();
            if (cita.Eliminar())
            {
                MessageManager.InfoMessage("Cita borrada");
                Limpiar();
                RefrescarData();
                IrAlTab(0);
            }
            else
            {
                MessageManager.AlerMessage("No pudo borraese la cita");
            }
        }
    }
}
