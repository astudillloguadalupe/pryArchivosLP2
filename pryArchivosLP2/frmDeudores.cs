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

        clsArchivo Archi= new clsArchivo();
        private void frmDeudores_Load(object sender, EventArgs e)
        {
            Archi.Listar(dgvClientes);
            lblCantidadRTA.Text = Archi.CantidadClientes().ToString();
            lblTotalDeudaRTA.Text = Archi.TotalDeuda().ToString();
            lblPromedioRTA.Text = Archi.PromedioDeudores().ToString();
        }

        private void lblCantidadRTA_Click(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
