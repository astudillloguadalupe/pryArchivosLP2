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
    public partial class frmNuevosClientes : Form
    {
        public frmNuevosClientes()
        {
            InitializeComponent();
        }

        clsArchivo Arc = new clsArchivo();
        private void frmNuevosClientes_Load(object sender, EventArgs e)
        {
            btnCargar.Enabled = false;
        }


        private void Comprobar()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtDeuda.Text != "" && txtLimite.Text != "")
            {
                btnCargar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtLimite_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Arc.Grabar(txtCodigo.Text, txtNombre.Text, txtDeuda.Text, txtLimite.Text);
            MessageBox.Show("Datos Grabados");

            //Limpio los controles una vez que se hayan cargado
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDeuda.Text = "";
            txtLimite.Text = "";
        }
    }
}
