using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PRO2_DABD1249321
{
    class Motricidad
    {
        string[,] DataCSV;
        ChekFile DataMatriz = new ChekFile();
        public int[,] entrada()
        {
            DataCSV = DataMatriz.MatrizParaLeer();
            int xpos = 0; int ypos = 0;
            int n_fila = DataCSV.GetLength(0); int n_columna = DataCSV.GetLength(1);
            for (int o = 0; o < n_fila; o++)
            {
                for (int x = 0; x < n_columna; x++)
                {
                    if (DataCSV[o, x] == "O")
                    {
                        xpos = x;
                        ypos = o;
                    }
                }
            }
            return new int[xpos, ypos];
        }
        public int[,] distanciaxy(int n_fila, int n_columna)
        {
            int entradax = entrada().GetLength(0);
            int entraday = entrada().GetLength(0);
            int distanciax = entradax - n_columna;
            int distanciay = entraday - n_fila;

            return new int [distanciax, distanciay];
        }
        public int[,] cambioxy (int n_fila, int n_columna, int xini, int yini)
        {
            int cambiox = xini - n_columna;
            int cambioy = yini - n_fila;
            return new int[cambiox, cambioy];
        }
        public bool buscarespacio(int dirx, int diry, string busqueda)
        {
            DataCSV = DataMatriz.MatrizParaMostrar();
            int n_fila = dirx; int n_columna = diry;
            bool result = false;
            for (int o = 0; o < n_fila; o++)
            {
                for (int x = 0; x < n_columna; x++)
                {
                    if (DataCSV[o, x] == busqueda)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
    }
}
