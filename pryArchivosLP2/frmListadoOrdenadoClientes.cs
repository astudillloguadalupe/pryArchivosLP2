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
    public partial class frmListadoOrdenadoClientes : Form
    {
        public frmListadoOrdenadoClientes()
        {
            InitializeComponent();
        }

       
        clsArchivo Archi = new clsArchivo();
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (radCodigo.Checked == true)
            {
                if (radAsc.Checked == true)
                {
                    Archi.OrdenarPorCodigoAsc();
                }
                else
                {
                    Archi.OrdenarPorCodigoDesc();
                }
            }
                if (radDeuda.Checked == true)
                {
                    if (radAsc.Checked == true)
                    {
                        Archi.OrdenarPorDeudaAsc();
                    }
                    else
                    {
                        Archi.OrdenarPorDeudaDesc();
                    }
                }

                if (radLimite.Checked == true)
                {
                    if (radAsc.Checked == true)
                    {
                        Archi.OrdenarPorLimiteAsc();
                    }
                    else
                    {
                        Archi.OrdenarPorLimiteDesc();
                    }
                }

                Archi.Listar(dgvGrilla);

                MessageBox.Show("Clientes ordenados correctamente");
            
        }

        private void frmListadoOrdenadoClientes_Load(object sender, EventArgs e)
        {
            radCodigo.Checked = true;
            radAsc.Checked = true;

            Archi.Listar(dgvGrilla);
        }
    }
}
