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
            string[,] DataCSV = MatrizParaLeer;
            //bool actividad = false;
            int entrada_f=0; int entrada_c=0;
            int n_fila = DataCSV.GetLength(0);int n_columna = DataCSV.GetLength(1);
            for (int o = 0; o < n_fila; o++)
            {
                for (int x = 0; x < n_columna; x++)
                {
                    if (DataCSV[o, x] == "O")
                    {
                        
                        entrada_f = o;
                        entrada_c = x;
                    }
                }
            }

            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatrizForm));

            this.SuspendLayout();
            // 
            // MatrizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "MatrizForm";
            this.Text = "Diseño de bodega";
            this.ResumeLayout(false);


            this.ROBOT_1 = new System.Windows.Forms.PictureBox();
            this.Controls.Add(this.ROBOT_1);
            this.ROBOT_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ROBOT_1.Location = new System.Drawing.Point(entrada_c*89+15, entrada_f*89+15);
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
                    if (DataCSV[o, x] == "F") this.PB0_0.BackColor = System.Drawing.Color.Red;
                    if (DataCSV[o, x] == "N") this.PB0_0.BackColor = System.Drawing.Color.RosyBrown;
                    if (DataCSV[o, x] == "O") this.PB0_0.BackColor = System.Drawing.Color.IndianRed;
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
            this.BT0_1.Location = new System.Drawing.Point(200, 400);
            this.BT0_1.Text = "Entrada";
            this.BT0_1.Name = "Boton_1";
            this.BT0_1.Size = new System.Drawing.Size(89, 50);
            this.BT0_1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BT0_1.Click += new System.EventHandler(this.BT0_1_Click);

            this.BT0_2 = new System.Windows.Forms.Button();
            this.Controls.Add(this.BT0_2);
            this.BT0_2.Location = new System.Drawing.Point(350, 400);
            this.BT0_2.Text = "Salida";
            this.BT0_2.Name = "Boton_1";
            this.BT0_2.Size = new System.Drawing.Size(89, 50);
            this.BT0_2.BackColor = System.Drawing.SystemColors.ControlDarkDark;

        }
        private System.Windows.Forms.PictureBox ROBOT_1;
        private System.Windows.Forms.PictureBox PB0_0;
        private System.Windows.Forms.Button BT0_1;
        private System.Windows.Forms.Button BT0_2;
        #endregion
    }
}