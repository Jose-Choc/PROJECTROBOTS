using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO2_DABD1249321
{
    public partial class MatrizForm : Form
    {
        int almacen_fila; int almacen_columna; string almacen; string robot; int capacidad;
        string[,] DataCSV;
        
        public MatrizForm(string[,] MatrizParaLeer)
        {
            this.DataCSV = MatrizParaLeer;
            InitializeComponent(MatrizParaLeer);
        }
        public void BT0_1_Click(object sender, EventArgs e)
        {
            MoveRobot();
            //VentanaDeEntrada EntradaCSV = new VentanaDeEntrada();
            //EntradaCSV.Show();
        }
        public void MoveRobot()
        {
            int fila = 2; int columna = 1; int xpos = 0; int ypos = 0;
            int n_fila = DataCSV.GetLength(0); int n_columna = DataCSV.GetLength(1);
            for (int o = 0; o < n_fila; o++)
            {
                for (int x = 0; x < n_columna; x++)
                {
                    if (DataCSV[o, x] == "O") {
                        xpos = x;   
                        ypos = o; 
                    }
                }
            }
            int distancia_x = fila - xpos; int distancia_y = columna-ypos;
            this.ROBOT_1.Location = new Point(xpos * 89 +15, ypos * 89+15);
            if(distancia_x > distancia_y)
            {
                Moveleft(columna * 89 + 15, xpos, ypos);
                MoveDown(fila * 89 + 15, xpos, ypos);
            }
            if(distancia_y > distancia_x)
            {
                Moveleft(columna * 89 + 15, xpos, ypos);
                MoveDown(fila * 89  + 15, xpos, ypos);
            }

        }
        private void Moveleft(int x, int xpos, int ypos)
        {
            for (int i = xpos * 89 + 15; i > x+89; i--)
            {
                this.ROBOT_1.Location = new Point(i, ypos * 89 + 15);
                Thread.Sleep(20);
            }
        }
        private void MoveRight(int x)
        {
            for (int i = 0; i < x; i++)
            {
                this.ROBOT_1.Location = new Point(i + 15, 15);
                Thread.Sleep(20);
            }
        }
        private void MoveDown(int y, int xpos, int ypos)
        {
            for (int i = ypos; i < y; i++)
            {
                this.ROBOT_1.Location = new Point(xpos+15+89, i+15);
                Thread.Sleep(20);
            }
        }
        private void MoveUp(int y)
        {
            for (int i = y; i > 0; i--)
            {
                this.ROBOT_1.Location = new Point(15, i+15);
                Thread.Sleep(20);
            }
        }
        
    }
}
