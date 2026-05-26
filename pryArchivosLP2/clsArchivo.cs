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

        private void OrdenarVector()
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
                AD.WriteLine(VecClientes[i].Limite);
            }
                //CERRAR
                AD.Close();
                AD.Dispose();
        }
        public void OrdenarArchivo()
        {
            CargarVector();
            OrdenarVector();
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
            Int32 cantidad = CantidadClientes();

            if (cantidad == 0)
            {
                return 0;
            }

            return TotalDeuda() / cantidad;
        }
        public void ListarDeudores(DataGridView Grilla)
        {
            String datoLeido;
            string[] vecDatos = new string[4];

            StreamReader AD = new StreamReader(NomArchivo);
            datoLeido = AD.ReadLine();

            Grilla.Rows.Clear();

            while (datoLeido != null)
            {
                vecDatos = datoLeido.Split(';');

                if (Convert.ToDecimal(vecDatos[2]) > 0)
                {
                    Grilla.Rows.Add(vecDatos[0], vecDatos[1], vecDatos[2], vecDatos[3]);
                }

                datoLeido = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();
        }
        public Int32 CantidadDeudores()
        {
            String datoLeido;
            string[] vecDatos = new string[4];
            Int32 cantDeud = 0;

            StreamReader AD = new StreamReader(NomArchivo);
            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                vecDatos = datoLeido.Split(';');

                if (Convert.ToDecimal(vecDatos[2]) > 0)
                {
                    cantDeud++;
                }

                datoLeido = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();

            return cantDeud;
        
        }
        public Decimal TotalDeudaDeudores()
        {
            String datoLeido;
            string[] vecDatos = new string[4];
            Decimal total = 0;

            StreamReader AD = new StreamReader(NomArchivo);
            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                vecDatos = datoLeido.Split(';');

                if (Convert.ToDecimal(vecDatos[2]) > 0)
                {
                    total = total + Convert.ToDecimal(vecDatos[2]);
                }

                datoLeido = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();

            return total;
        }

        public Decimal PromedioDeudores()
        {
            Int32 cantidad = CantidadDeudores();

            if (cantidad == 0)
            {
                return 0;
            }

            return TotalDeudaDeudores() / cantidad;
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
            Reporte.WriteLine("Codigo;Nombre;Deuda;Limite");
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

            if (cantidad > 0)
            {
                Reporte.WriteLine(total / cantidad);
            }
            else
            {
                Reporte.WriteLine(0);
            }

            Reporte.Close();
            Reporte.Dispose();
           
        }

        public void OrdenarPorCodigoAsc()
        {
            CargarVector();

            RegCliente aux;

            for (Int32 c = 0; c < IND - 1; c++)
            {
                for (Int32 i = 0; i < IND - 1 - c; i++)
                {
                    if (VecClientes[i].Codigo > VecClientes[i + 1].Codigo)
                    {
                        aux = VecClientes[i];
                        VecClientes[i] = VecClientes[i + 1];
                        VecClientes[i + 1] = aux;
                    }
                }
            }

            ReescribirArchivo();
        }

        public void OrdenarPorCodigoDesc()
        {
            CargarVector();

            RegCliente aux;

            for (Int32 c = 0; c < IND - 1; c++)
            {
                for (Int32 i = 0; i < IND - 1 - c; i++)
                {
                    if (VecClientes[i].Codigo < VecClientes[i + 1].Codigo)
                    {
                        aux = VecClientes[i];
                        VecClientes[i] = VecClientes[i + 1];
                        VecClientes[i + 1] = aux;
                    }
                }
            }

            ReescribirArchivo();
        }

        public void OrdenarPorDeudaAsc()
        {
            CargarVector();

            RegCliente aux;

            for (Int32 c = 0; c < IND - 1; c++)
            {
                for (Int32 i = 0; i < IND - 1 - c; i++)
                {
                    if (VecClientes[i].Deuda > VecClientes[i + 1].Deuda)
                    {
                        aux = VecClientes[i];
                        VecClientes[i] = VecClientes[i + 1];
                        VecClientes[i + 1] = aux;
                    }
                }
            }

            ReescribirArchivo();
        }

        public void OrdenarPorDeudaDesc()
        {
            CargarVector();

            RegCliente aux;

            for (Int32 c = 0; c < IND - 1; c++)
            {
                for (Int32 i = 0; i < IND - 1 - c; i++)
                {
                    if (VecClientes[i].Deuda < VecClientes[i + 1].Deuda)
                    {
                        aux = VecClientes[i];
                        VecClientes[i] = VecClientes[i + 1];
                        VecClientes[i + 1] = aux;
                    }
                }
            }

            ReescribirArchivo();
        }

        public void OrdenarPorLimiteAsc()
        {
            CargarVector();

            RegCliente aux;

            for (Int32 c = 0; c < IND - 1; c++)
            {
                for (Int32 i = 0; i < IND - 1 - c; i++)
                {
                    if (VecClientes[i].Limite > VecClientes[i + 1].Limite)
                    {
                        aux = VecClientes[i];
                        VecClientes[i] = VecClientes[i + 1];
                        VecClientes[i + 1] = aux;
                    }
                }
            }

            ReescribirArchivo();
        }

        public void OrdenarPorLimiteDesc()
        {
            CargarVector();

            RegCliente aux;

            for (Int32 c = 0; c < IND - 1; c++)
            {
                for (Int32 i = 0; i < IND - 1 - c; i++)
                {
                    if (VecClientes[i].Limite < VecClientes[i + 1].Limite)
                    {
                        aux = VecClientes[i];
                        VecClientes[i] = VecClientes[i + 1];
                        VecClientes[i + 1] = aux;
                    }
                }
            }

            ReescribirArchivo();
        }


    }

}
