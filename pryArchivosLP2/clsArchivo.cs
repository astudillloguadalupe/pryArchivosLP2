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
        public Decimal TotalDeuda()
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

        public Decimal Promedio()
        {
            String datoLeido;
            string[] vecDatos = new string[4];
            Decimal total = 0;
            int c = 0;
            Decimal promedio = 0;

            StreamReader AD = new StreamReader(NomArchivo);
            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                c++;
                vecDatos = datoLeido.Split(';');
                total = total + Convert.ToDecimal(vecDatos[2]);
                if (c > 0)
                {
                    promedio = Math.Round(total / Convert.ToDecimal(vecDatos[2]));//Redondea p/tener 2 decimales
                }

                datoLeido = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();

            return total / c;
        }

        public Int32 CantidadDeudores()
        {
            String datoLeido;
            string[] vecDatos = new string[4];
            int cantDeud = 0;

            StreamReader AD = new StreamReader(NomArchivo);
            datoLeido = AD.ReadLine();

            while (datoLeido != null && Convert.ToInt32(vecDatos[2]) > 0)
            {
                vecDatos = datoLeido.Split(';');
                cantDeud++;
                datoLeido = AD.ReadLine();

            }

            AD.Close();
            AD.Dispose();

            return cantDeud;
        }

        public Decimal PromedioDeudores()
        {
            String datoLeido;
            string[] vecDatos = new string[4];
            Decimal total = 0;
            int cant = 0;
            Decimal promedio = 0;

            StreamReader AD = new StreamReader(NomArchivo);
            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                cant++;
                vecDatos = datoLeido.Split(';');
                total = total + Convert.ToDecimal(vecDatos[2]);
                if (cant > 0)
                {
                    promedio = Math.Round(total / Convert.ToDecimal(vecDatos[2]));//Redondea p/tener 2 decimales
                }

                datoLeido = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();

            return total / cant;
        }


























    }






















}
