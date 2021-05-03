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
        }
        private static void checkfile()
        {
            ChekFile archivo = new ChekFile();
            if (archivo.issetfile())
            {
                Application.Run(new MatrizForm());
            }else
            {
                Application.Run(new DataForm());
            }
        }
    }
}
