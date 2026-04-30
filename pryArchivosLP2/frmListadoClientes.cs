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
        clsArchivo Arc = new clsArchivo();
        private void frmListadoClientes_Load(object sender, EventArgs e)
        {
            Arc.Listar(dgvClientes);
            lblCantRTA.Text = Arc.CantidadClientes().ToString();
            lblTotalDeudaRTA.Text = Arc.TotalDeuda().ToString();
            lblPromedioRTA.Text= Arc.PromedioDeudores().ToString();
        }

        private void btnReportar_Click(object sender, EventArgs e)
        {
           Arc.GenerarReporte();
            MessageBox.Show("Reporte generado correctamente");
        }
    }
}
