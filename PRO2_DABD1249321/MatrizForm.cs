using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO2_DABD1249321
{
    public partial class MatrizForm : Form
    {
        ChekFile MatrizData = new ChekFile();
        int almacen_fila; int almacen_columna; string almacen; string robot; int capacidad;
        string[,] DataCSV;
        Motricidad motriz = new Motricidad();
        Timer tiempo = new Timer();
        
        public MatrizForm()
        {
            DataCSV = MatrizData.MatrizParaMostrar();
            InitializeComponent(DataCSV);
        }
        public void BT0_1_Click(object sender, EventArgs e)
        {
            VentanaManual manual = new VentanaManual();
            manual.ShowDialog();
            try
            {
                almacen = manual.tipo_material.Text;
                almacen_fila = Int32.Parse(manual.n_fila.Text);
                almacen_columna = Int32.Parse(manual.n_columna.Text);
                robot = manual.tipo_robot.Text;
                capacidad = Int32.Parse(manual.cantidad.Text);
                int[,] distinicial = motriz.distanciaxy(almacen_fila, almacen_columna);
                if (distinicial.GetLength(0) < 0 && distinicial.GetLength(1)> 0)
                {
                    int x = motriz.entrada().GetLength(0);
                    int y = motriz.entrada().GetLength(1);
                    if (motriz.buscarespacio(x - 1, y, "P")) Moveleft(x - 1, x, y, 1000);
                    if (motriz.buscarespacio(x, y + 1, "P")) MoveUp(y - 1, x, y, 1000);
                }
                //ROBOT_1.Location = new Point(motriz.entrada().GetLength(0) * 89 + 15, motriz.entrada().GetLength(1) * 89 + 15);

            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
        public void BT0_2_Click(object send, EventArgs e)
        {
            Close();
        }
        private void Moveleft(int x, int xpos, int ypos, int duracion)
        {
            for (int i = xpos * 89 + 15; i > x + 89; i--)
            {
                this.ROBOT_1.Location = new Point(i, ypos * 89 + 15);
                tiempo.Interval = duracion;
                tiempo.Start();
            }
        }
        private void MoveRight(int x)
        {
            for (int i = 0; i < x; i++)
            {
                this.ROBOT_1.Location = new Point(i + 15, 15);
            }
        }
        private void MoveDown(int y, int xpos, int ypos)
        {
            for (int i = ypos; i < y; i++)
            {
                this.ROBOT_1.Location = new Point(xpos + 15 + 89, i + 15);
            }
        }
        private void MoveUp(int y, int ypos, int xpos, int duracion)
        {
            for (int i = ypos*89+15; i > y-89 ; i--)
            {
                this.ROBOT_1.Location = new Point(i, xpos*89 + 15);
            }
        }
    }
}
