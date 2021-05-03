using System.Threading.Tasks;

namespace PRO2_DABD1249321
{
    partial class MatrizForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(string[,] MatrizParaLeer)
        {
            
            //string[,] DataCSV = DataMatriz(MatrizParaLeer);
            int n_fila = MatrizParaLeer.GetLength(0); int n_columna = MatrizParaLeer.GetLength(1);
            string[,] DataCSV = MatrizParaLeer;
                
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatrizForm));

            this.SuspendLayout();
            // 
            // MatrizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Name = "MatrizForm";
            this.Text = "Diseño de bodega";
            this.ResumeLayout(false);


            this.ROBOT_1 = new System.Windows.Forms.PictureBox();
            this.Controls.Add(this.ROBOT_1);
            this.ROBOT_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ROBOT_1.Location = new System.Drawing.Point(650, 250);
            this.ROBOT_1.BackColor = System.Drawing.Color.Yellow;
            this.ROBOT_1.Size = new System.Drawing.Size(50, 50);


            for (int o = 0; o < n_fila; o++)
            {
                for (int x = 0; x < n_columna; x++)
                {
                    this.PB0_0 = new System.Windows.Forms.PictureBox();
                    this.Controls.Add(this.PB0_0);
                    if (DataCSV[o, x] == "P") this.PB0_0.BackColor = System.Drawing.SystemColors.ControlDark;
                    if (DataCSV[o, x] == "C") this.PB0_0.BackColor = System.Drawing.Color.SkyBlue;
                    if (DataCSV[o, x] == "F") this.PB0_0.BackColor = System.Drawing.Color.IndianRed;
                    if (DataCSV[o, x] == "N") this.PB0_0.BackColor = System.Drawing.Color.RosyBrown;
                    if (DataCSV[o, x] == "O") this.PB0_0.BackColor = System.Drawing.Color.Red;
                    this.PB0_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    this.PB0_0.Enabled = false;
                    this.PB0_0.Location = new System.Drawing.Point(x*89, o*89);
                    this.PB0_0.Name = "PB0_"+MatrizParaLeer[o,x];
                    this.PB0_0.Size = new System.Drawing.Size(89, 89);
                    this.PB0_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    this.PB0_0.TabIndex = 0;
                    this.PB0_0.TabStop = false;
                }
            }
            this.BT0_1 = new System.Windows.Forms.Button();
            this.Controls.Add(this.BT0_1);
            this.BT0_1.Location = new System.Drawing.Point(200, 500);
            this.BT0_1.Text = "Manual";
            this.BT0_1.Name = "Boton_1";
            this.BT0_1.Size = new System.Drawing.Size(89, 50);
            this.BT0_1.BackColor = System.Drawing.Color.LemonChiffon;
            this.BT0_1.Click += new System.EventHandler(this.BT0_1_Click);

            this.BT0_2 = new System.Windows.Forms.Button();
            this.Controls.Add(this.BT0_2);
            this.BT0_2.Location = new System.Drawing.Point(350, 500);
            this.BT0_2.Text = "Automatico";
            this.BT0_2.Name = "Boton_1";
            this.BT0_2.Size = new System.Drawing.Size(89, 50);
            this.BT0_2.BackColor = System.Drawing.Color.AliceBlue;
            this.BT0_2.Click += new System.EventHandler(this.BT0_2_Click);

        }
        
        private System.Windows.Forms.PictureBox ROBOT_1;
        private System.Windows.Forms.PictureBox PB0_0;
        private System.Windows.Forms.Button BT0_1;
        private System.Windows.Forms.Button BT0_2;
        #endregion
    }
}