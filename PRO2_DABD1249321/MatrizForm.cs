using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PRO2_DABD1249321
{
    public partial class MatrizForm : Form
    {
        
        public MatrizForm(string[,] MatrizParaLeer)
        {
            
            InitializeComponent(MatrizParaLeer);
        }
        public void BT0_1_Click(object sender, EventArgs e)
        {
            VentanaDeEntrada EntradaCSV = new VentanaDeEntrada();
            EntradaCSV.Show();
        }
    }
}
