namespace PRO2_DABD1249321
{
    partial class MatrizForm
    {
        string[,] DataCSV;
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
            this.DataCSV = MatrizParaLeer;

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

            int n_fila = DataCSV.GetLength(0);
            int n_columna = DataCSV.GetLength(1);
            for (int o = 0; o < n_fila; o++)
            {
                for (int x = 0; x < n_columna; x++)
                {
                    this.PB0_0 = new System.Windows.Forms.PictureBox();
                    this.Controls.Add(this.PB0_0);
                    ((System.ComponentModel.ISupportInitialize)(this.PB0_0)).BeginInit();
                    this.PB0_0.BackColor = DataCSV[o,x]=="P"?System.Drawing.SystemColors.ControlDark: System.Drawing.SystemColors.ControlLight;
                    //this.PB0_0.Image = ;
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
        }
        private System.Windows.Forms.PictureBox PB0_0;
        #endregion
    }
}