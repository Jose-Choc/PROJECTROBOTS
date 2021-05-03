using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PRO2_DABD1249321
{
    public class ChekFile
    {
        string[,] DataMatriz;
        string pathfile = @"C:\Users\CRGG\Desktop\Proyecto Web\Curso\PROJECTROBOTS\PRO2_DABD1249321\Data\ProyectoB.csv";


        //Verifica si el archivo existe y no vacío
        public bool issetfile()
        {
            if (File.Exists(pathfile) && File.ReadAllText(this.pathfile) != "")
            {
                StockParaLeer();
                return true;
            }
            return false;
        }

        //Genera en matriz el achivo CSV
        public string[,] MatrizParaLeer()
        {
            var reader = new StreamReader(File.OpenRead(this.pathfile));
            List<string> lista = new List<string>();
            int contador = 0;
            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();
                contador++;
                string[] valores = linea.Split(",");
                foreach (var i in valores)
                {
                    lista.Add(i);
                }
            }
            int n_fila = contador;
            int n_columna = lista.Count / contador;
            int contador2 = 0;
            DataMatriz = new string[n_fila, n_columna];
            for (int o = 0; o < n_fila; o++)
            {
                for (int x = 0; x < n_columna; x++)
                {
                    DataMatriz[o, x] = lista[contador2];
                    contador2++;
                }
            }
            return DataMatriz;
        }
        public void StockParaLeer()
        {
            string pathstock = @"C:\Users\CRGG\Desktop\Proyecto Web\Curso\PROJECTROBOTS\PRO2_DABD1249321\Data\Stock.csv";
            string[,] Data = MatrizParaLeer();
            int n_fila = Data.GetLength(0); int n_columna = Data.GetLength(1);
            string[] line_f = new string[n_columna]; string[] line_c = new string[n_fila];
            List<string> cadena = new List<string>();

            if (File.Exists(pathstock))
            {

                //File.
                for (int o = 0; o < n_fila; o++)
                {
                    for (int x = 0; x < n_columna; x++)
                    {
                        cadena.Add(Data[o, x].Remove(0, 1) + ",");
                    }
                }
                File.WriteAllLines(pathstock, cadena);
            }
            else
            {
                MessageBox.Show("Archivo de inventario no existe");
            }
        }
        public string[,] MatrizParaMostrar()
        {
            string[,] Data = MatrizParaLeer();
            int n_fila = Data.GetLength(0); int n_columna = Data.GetLength(1);
            string[,] Bodega = new string[n_fila,n_columna];
            for (int o = 0; o < n_fila; o++)
            {
                for (int x = 0; x < n_columna; x++)
                {
                    string cadena = Data[o, x];
                    Bodega[o,x] = cadena.Substring(0,1);
                    //DataStock[o, x] = cadena;
                }
            }

            return Bodega;
        }
    }
}
