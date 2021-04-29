using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO2_DABD1249321
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            checkfile();
            //Application.Run(new DataForm());
        }
        private static void checkfile()
        {
            string[,] MatrizParaLeer;
            string pathfile = @"C:\Users\CRGG\source\repos\Jose-Choc\PROJECTROBOTS\PRO2_DABD1249321\Data\ProyectoB.csv";
            if (File.Exists(pathfile))
            {  
                var reader = new StreamReader(File.OpenRead(pathfile));
                List<string> lista = new List<string>();
                try
                {
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
                    int contador2=0;
                    MatrizParaLeer = new string[n_fila,n_columna];
                    for (int o = 0; o < n_fila; o++)
                    {
                        for (int x = 0; x < n_columna; x++)
                        {
                            MatrizParaLeer[o, x] = lista[contador2];
                            contador2++;
                        }
                    }
                    Application.Run(new MatrizForm(MatrizParaLeer));
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            else
            {
                Application.Run(new DataForm());
            }
        }
    }
}
