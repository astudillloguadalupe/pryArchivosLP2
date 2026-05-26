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
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }
        clsArchivo Archi = new clsArchivo();
        private void frmListadoClientes_Load(object sender, EventArgs e)
        {
            Archi.Listar(dgvClientes);
            lblCantRTA.Text = Archi.CantidadClientes().ToString();
            lblTotalDeudaRTA.Text = Archi.TotalDeuda().ToString();
            lblPromedioRTA.Text = Archi.Promedio().ToString();
        }

        private void btnReportar_Click(object sender, EventArgs e)
        {
           Archi.GenerarReporte();
            MessageBox.Show("Reporte generado correctamente");
        }

        
            
    }
}
