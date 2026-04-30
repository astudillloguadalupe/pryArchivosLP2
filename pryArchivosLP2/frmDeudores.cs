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
    public partial class frmDeudores : Form
    {
        public frmDeudores()
        {
            InitializeComponent();
        }

        clsArchivo Arc = new clsArchivo();
        private void frmDeudores_Load(object sender, EventArgs e)
        {
            Arc.Listar(dgvClientes);
            lblTotalDeudaRTA.Text = "$" + Arc.TotalDeuda().ToString();
            lblCantidadRTA.Text = Arc.CantidadDeudores().ToString();
            lblPromedioRTA.Text = "$" + Arc.PromedioDeudores().ToString();
        }

        private void lblCantidadRTA_Click(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
