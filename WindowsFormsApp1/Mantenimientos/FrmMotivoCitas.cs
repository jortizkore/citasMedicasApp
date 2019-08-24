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
    public partial class FrmMotivoCitas : Form
    {
        DBConexion con;
        public FrmMotivoCitas()
        {
            InitializeComponent();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtInsertarMotivoCita.Text.Trim() == "")
            {
                MessageManager.AlerMessage("Debe llenar el campo Descripcion.");
                tabControlMotivoCitas.SelectTab(1);
                txtInsertarMotivoCita.Focus();
                return;
            }
            con = new DBConexion();
            var query = @"INSERT INTO motivo_cita (Descripcion)" +
                        $"VALUES ('{txtInsertarMotivoCita.Text}')";
            if (con.ExcecuteQuery(query))
            {
                MessageManager.InfoMessage("Motivo cita guardao satisfactoriamente!");
                RefrescarGridMotivoCita();
            }
            else
            {
                MessageManager.AlerMessage("No pudo guardar el registro.");
            }
            LimpiarFrmMotivoCita();
        }

        private void FrmMotivoCitas_Load(object sender, EventArgs e)
        {
            RefrescarGridMotivoCita();
        }

        void LimpiarFrmMotivoCita()
        {
            txtInsertarMotivoCita.Text = string.Empty;
            txtFiltroMotivoCita.Text = string.Empty;
            lblIDMotivoCita.Text = "0";
            tabControlMotivoCitas.SelectTab(0);
        }

        void RefrescarGridMotivoCita()
        {
            con = new DBConexion();
            var query = "Select * from motivo_cita";
            GrdMotivoCita.DataSource = con.BringData(query);
            GrdMotivoCita.AutoResizeRows();
            tabControlMotivoCitas.SelectTab(0);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtInsertarMotivoCita.Text.Trim() == "")
            {
                MessageManager.AlerMessage("Debe llenar el campo Descripcion.");
                tabControlMotivoCitas.SelectTab(1);
                txtInsertarMotivoCita.Focus();
                return;
            }
            var id = lblIDMotivoCita.Text;
            if (lblIDMotivoCita.Text.Trim() == "0" || lblIDMotivoCita.Text.Trim() == "")
            {
                MessageManager.AlerMessage("No tiene ningún motivo seleccionado.");
                tabControlMotivoCitas.SelectTab(0);
                txtFiltroMotivoCita.Focus();
                return;
            }
            con = new DBConexion();
            var query = $"UPDATE motivo_cita SET Descripcion = '{txtInsertarMotivoCita.Text}'" +
                        $"WHERE IdMotivoCita = {id}";
            if (con.ExcecuteQuery(query))
            {
                MessageManager.InfoMessage("Motivo cita guardao satisfactoriamente!");
                RefrescarGridMotivoCita();
                LimpiarFrmMotivoCita();
            }
            else
            {
                MessageManager.AlerMessage("No pudo guardar el registro.");
            }
        }

        void TomarValoresDelGridParaEditar(DataGridViewCellMouseEventArgs e)
        {
            var id = GrdMotivoCita.Rows[e.RowIndex].Cells[0].Value.ToString();
            var descripcion = GrdMotivoCita.Rows[e.RowIndex].Cells[1].Value.ToString();
            lblIDMotivoCita.Text = id;
            txtInsertarMotivoCita.Text = descripcion;
            tabControlMotivoCitas.SelectTab(1);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblIDMotivoCita.Text.Trim() == "0" || lblIDMotivoCita.Text.Trim() == "")
            {
                MessageManager.AlerMessage("No tiene ningun motivo seleccionado!");
                tabControlMotivoCitas.SelectTab(0);
                txtFiltroMotivoCita.Focus();
                return;
            }
            con = new DBConexion();
            var query = @"DELETE FROM motivo_cita " +
                        $"WHERE IdMotivoCita = {lblIDMotivoCita.Text}";
            if (con.ExcecuteQuery(query))
            {
                MessageManager.InfoMessage("Motivo cita eliminado satisfactoriamente!");
                RefrescarGridMotivoCita();
                LimpiarFrmMotivoCita();
            }
            else
            {
                MessageManager.AlerMessage("No pudo eliminar el registro.");
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GrdMotivoCita_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                TomarValoresDelGridParaEditar(e);
            }
            catch (Exception)
            {
            }
        }
    }
}
