using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArchivosLP2
{
    internal class clsArchivo
    {
        public string NomArchivo = "Clientes.csv";

        public void Grabar(string cod, string nom, string deu, string lim)
        {
            //ABRIR
            StreamWriter AD = new StreamWriter(NomArchivo, true); //Quiere decir que ya existen datos

            //CARGAR O LEER
            AD.Write(cod);
            AD.Write(";");
            AD.Write(nom);
            AD.Write(";");
            AD.Write(deu);
            AD.Write(";");
            AD.WriteLine(lim);

            //CERRAR
            AD.Close();
            AD.Dispose();
        }
        //Procedimiento para mostrar clientes en una grilla
        public void Listar(DataGridView Grilla)
        {
            String datoLeido;
            string[] vecDatos = new string[4];

            StreamReader AD = new StreamReader(NomArchivo);
            datoLeido = AD.ReadLine();
            Grilla.Rows.Clear();

            while (datoLeido != null)
            {
                vecDatos = datoLeido.Split(';');

                Grilla.Rows.Add(vecDatos[0], vecDatos[1], vecDatos[2], vecDatos[3]);
                datoLeido = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
        }


        public Int32 CantidadClientes()
        {    
            string datoLeido;
            Int32 c = 0;

            StreamReader AD = new StreamReader(NomArchivo);
            datoLeido = AD.ReadLine();
            while (datoLeido != null)
            {
                c++;
                datoLeido = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
            return c;
        }
        public Decimal DeudaClientes()
        {
            string datoLeido;
            string[] vecDatos = new string[4];
            Decimal Total = 0;
            StreamReader AD = new StreamReader(NomArchivo);
            datoLeido = AD.ReadLine();
            while (datoLeido != null)
            {
                vecDatos = datoLeido.Split(';');
                Total += Convert.ToDecimal(vecDatos[2]);
                datoLeido = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
            return Total;
        }
    }

}
