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
    }
}
