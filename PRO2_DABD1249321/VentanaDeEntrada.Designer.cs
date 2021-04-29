
namespace PRO2_DABD1249321
{
    partial class VentanaDeEntrada
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
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tipo_robot = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tipo_material = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.accion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.n_fila = new System.Windows.Forms.TextBox();
            this.n_columna = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escoja al robot:";
            // 
            // tipo_robot
            // 
            this.tipo_robot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tipo_robot.FormattingEnabled = true;
            this.tipo_robot.Items.AddRange(new object[] {
            "Robot1 (Alta velocidad)",
            "Robot2 (Alto cargamento)",
            "Robot3 (Standard)"});
            this.tipo_robot.Location = new System.Drawing.Point(198, 151);
            this.tipo_robot.Name = "tipo_robot";
            this.tipo_robot.Size = new System.Drawing.Size(223, 28);
            this.tipo_robot.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ir a Estanteria: ";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(384, 884);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 3;
            // 
            // tipo_material
            // 
            this.tipo_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tipo_material.FormattingEnabled = true;
            this.tipo_material.Items.AddRange(new object[] {
            "Materiales Fríos",
            "Materiales Frájiles",
            "Materiales Normales"});
            this.tipo_material.Location = new System.Drawing.Point(198, 217);
            this.tipo_material.Name = "tipo_material";
            this.tipo_material.Size = new System.Drawing.Size(223, 28);
            this.tipo_material.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unidades del Material:";
            // 
            // cantidad
            // 
            this.cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cantidad.Location = new System.Drawing.Point(261, 288);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(45, 26);
            this.cantidad.TabIndex = 6;
            // 
            // accion
            // 
            this.accion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accion.FormattingEnabled = true;
            this.accion.Items.AddRange(new object[] {
            "Agregar",
            "Retirar"});
            this.accion.Location = new System.Drawing.Point(328, 288);
            this.accion.Name = "accion";
            this.accion.Size = new System.Drawing.Size(93, 28);
            this.accion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(63, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fila de ubicación de Estantería:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(31, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Columna de ubicación de la Estantería:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(132, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "¡Bienvenido!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(51, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(347, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Seleccione las acciones que desea realizar:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(141, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 53);
            this.button1.TabIndex = 14;
            this.button1.Text = "CONTINUAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // n_fila
            // 
            this.n_fila.Location = new System.Drawing.Point(162, 408);
            this.n_fila.Name = "n_fila";
            this.n_fila.Size = new System.Drawing.Size(100, 23);
            this.n_fila.TabIndex = 15;
            // 
            // n_columna
            // 
            this.n_columna.Location = new System.Drawing.Point(162, 490);
            this.n_columna.Name = "n_columna";
            this.n_columna.Size = new System.Drawing.Size(100, 23);
            this.n_columna.TabIndex = 16;
            // 
            // VentanaDeEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(446, 597);
            this.Controls.Add(this.n_columna);
            this.Controls.Add(this.n_fila);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.accion);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tipo_material);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tipo_robot);
            this.Controls.Add(this.label1);
            this.Name = "VentanaDeEntrada";
            this.Text = "VentanaDeEntrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tipo_robot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox tipo_material;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.ComboBox accion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox n_fila;
        private System.Windows.Forms.TextBox n_columna;
    }
}