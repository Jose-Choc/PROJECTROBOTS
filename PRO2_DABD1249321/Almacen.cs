using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PRO2_DABD1249321
{
    class Almacen
    {
        ChekFile DataMatriz = new ChekFile();
        public Almacen(int n_fila, int n_columna)
        {

        }
        public int[,] ubicacion()
        {
            return new int[0,0];
        }
        public string material()
        {
            return "almacen";
        }
        public int [,] stock()
        {
            return new int[0, 0];
        }
        public int indicealmacen(int n_fila, int n_columna)
        {
            int indice = 0;
            for (int o = 0; o < n_fila; o++)
            {
                for (int x = 0; x < n_columna; x++)
                {
                    indice++;
                }
            }
            return indice;
        }
        public void StockParaVer()
        {
            string pathstock = @"C:\Users\CRGG\Desktop\Proyecto Web\Curso\PROJECTROBOTS\PRO2_DABD1249321\Data\Stock.csv";
            string[,] Data = DataMatriz.MatrizParaLeer();
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
    }
}
