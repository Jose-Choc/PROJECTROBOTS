using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PRO2_DABD1249321
{
    public partial class VentanaDeEntrada : Form
    {
        public VentanaDeEntrada()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string robot = this.tipo_robot.Text;
            string estanteria = this.tipo_material.Text;
            string cantidad = this.cantidad.Text;
            string accion = this.accion.Text;
            string fila = this.n_fila.Text;
            string columna = this.n_columna.Text;
            this.Close();

            if (robot != "") MessageBox.Show(robot);
            if (estanteria != "") MessageBox.Show(estanteria);
            if (cantidad != "") MessageBox.Show(cantidad);
            if (accion != "") MessageBox.Show(accion);
            if (fila != "") MessageBox.Show(fila);
            if (columna != "") MessageBox.Show(columna);
        }
    }
}
