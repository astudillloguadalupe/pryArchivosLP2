using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArchivosLP2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevosClientes frmNuevosClientes = new frmNuevosClientes();
            frmNuevosClientes.ShowDialog();
        }

        private void listadoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoClientes frmListadoClientes = new frmListadoClientes();
            frmListadoClientes.ShowDialog();
        }

        private void listadoClientesDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeudores frmDeudores = new frmDeudores();
            frmDeudores.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void listadoClientesOrdenadosPorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoOrdenadoClientes frmListadoOrdenadoClientes = new frmListadoOrdenadoClientes(); 
            frmListadoOrdenadoClientes.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDelDesarollador frmDatosDelDesarollador = new frmDatosDelDesarollador();    
            frmDatosDelDesarollador.ShowDialog();
        }
    }
}
