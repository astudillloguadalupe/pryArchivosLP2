using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArchivosLP2
{
    internal class clsArchivo
    {
        public string NomArchivo = "Clientes.csv";

        private struct RegCliente
        {
            public Int32 Codigo;
            public String Nombre;
            public Decimal Deuda;
            public Decimal Limite;
        }

        private RegCliente[] VecClientes = new RegCliente[15000];
        private Int32 IND = 0;

        private void CargarVector()
        {
            string datoLeido;
            string[] vecDatos = new string[4];
            IND = 0;

            StreamReader AD = new StreamReader(NomArchivo);
            datoLeido = AD.ReadLine();
            

            while (datoLeido != null)
            {
                vecDatos = datoLeido.Split(';');

                VecClientes[IND].Codigo=Convert.ToInt32(vecDatos[0]);
                VecClientes[IND].Nombre = vecDatos[1];
                VecClientes[IND].Deuda = Convert.ToDecimal(vecDatos[2]);
                VecClientes[IND].Limite = Convert.ToDecimal(vecDatos[3]);
                IND++;  
                datoLeido = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
        }

        private void OrdenarVerctor()
        {
            RegCliente aux;
            for (Int32 c = 0; c < IND - 1; c++)
            {
                for (Int32 i = 0; i < IND - 1; i++)
                {
                    if (VecClientes[i].Codigo > VecClientes[i + 1].Codigo)
                    {
                        aux = VecClientes[i];
                        VecClientes[i] = VecClientes[i + 1];
                        VecClientes[i + 1] = aux;
                    }
                }


            }
            
        }

        private void ReescribirArchivo()
        {
            StreamWriter AD = new StreamWriter(NomArchivo, false);
            for (Int32 i = 0; i < IND; i++)
            {
                //CARGAR O LEER
                AD.Write(VecClientes[i].Codigo);
                AD.Write(";"); //separador de campos
                AD.Write(VecClientes[i].Nombre);
                AD.Write(";");
                AD.Write(VecClientes[i].Deuda);
                AD.Write(";");
                AD.Write(VecClientes[i].Limite);
            }
                //CERRAR
                AD.Close();
                AD.Dispose();
        }
        public void OrdenarArchivo()
        {
            CargarVector();
            OrdenarArchivo();
            ReescribirArchivo();
        }



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
                Total = Total +Convert.ToDecimal(vecDatos[2]);
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
            Int32 c = 0;
          
            StreamReader AD = new StreamReader(NomArchivo);
            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                c++;
                vecDatos = datoLeido.Split(';');
                total = total + Convert.ToDecimal(vecDatos[2]);
                

                datoLeido = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();

            return total/c;
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
            string datoLeido;
            string[] vecDatos = new string[4];
            Decimal total = 0;
            Int32 cant = 0;
           
            StreamReader AD = new StreamReader(NomArchivo);
            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                cant++;
                vecDatos = datoLeido.Split(';');
                total = total + Convert.ToDecimal(vecDatos[2]);
                datoLeido = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();

            return total / cant;
        }

        public void GenerarReporte()
        {
            string datoLeido;
            string[] vecDatos = new string[4];
            Decimal total = 0;
            Int32 cantidad = 0;

            StreamWriter Reporte = new StreamWriter("Reporte.csv",false);

            Reporte.WriteLine("Listado de clientes");
            Reporte.WriteLine("");
            Reporte.WriteLine("Codigo,Nombre,deuda,limite");
            //abrir
            StreamReader AD = new StreamReader(NomArchivo);
            //leer
            datoLeido = AD.ReadLine();
      

            while (datoLeido != null)
            {
                vecDatos = datoLeido.Split(';');

                Reporte.Write(vecDatos[0]);
                Reporte.Write(";");
                Reporte.Write(vecDatos[1]);
                Reporte.Write(";");
                Reporte.Write(vecDatos[2]);
                Reporte.Write(";");
                Reporte.WriteLine(vecDatos[3]);

                datoLeido = AD.ReadLine();
                cantidad++;
                total= total+Convert.ToDecimal (vecDatos[2]);
            }
            //cerrar
            AD.Close();
            AD.Dispose();
            Reporte.WriteLine(); //esapacio entre medio
            Reporte.Write("TotalDeuda: ; ;");
            Reporte.WriteLine(total);

            Reporte.Write("Cantidad de clientes ; ;");
            Reporte.WriteLine(cantidad);

            Reporte.Write("Promedio de deuda ; ;");
            Reporte.WriteLine(total/cantidad);

            Reporte.Close();
            Reporte.Dispose();
           
        }
























    }






















}
