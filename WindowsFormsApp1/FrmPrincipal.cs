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
    }
}
