
namespace PRO2_DABD1249321
{
    partial class VentaInicial
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
            this.BTN_Automatico = new System.Windows.Forms.Button();
            this.BTN_Manual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Bienvenido a menu inicial!\r\nDe que manera desea ejecutar la acción:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BTN_Automatico
            // 
            this.BTN_Automatico.BackColor = System.Drawing.Color.Moccasin;
            this.BTN_Automatico.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Automatico.Location = new System.Drawing.Point(232, 108);
            this.BTN_Automatico.Name = "BTN_Automatico";
            this.BTN_Automatico.Size = new System.Drawing.Size(194, 58);
            this.BTN_Automatico.TabIndex = 1;
            this.BTN_Automatico.Text = "AUTOMÁTICO";
            this.BTN_Automatico.UseVisualStyleBackColor = false;
            // 
            // BTN_Manual
            // 
            this.BTN_Manual.BackColor = System.Drawing.Color.Moccasin;
            this.BTN_Manual.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Manual.Location = new System.Drawing.Point(39, 108);
            this.BTN_Manual.Name = "BTN_Manual";
            this.BTN_Manual.Size = new System.Drawing.Size(157, 58);
            this.BTN_Manual.TabIndex = 2;
            this.BTN_Manual.Text = "MANUAL";
            this.BTN_Manual.UseVisualStyleBackColor = false;
            this.BTN_Manual.Click += new System.EventHandler(this.BTN_Manual_Click);
            // 
            // VentaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(464, 178);
            this.Controls.Add(this.BTN_Manual);
            this.Controls.Add(this.BTN_Automatico);
            this.Controls.Add(this.label1);
            this.Name = "VentaInicial";
            this.Text = "Venta Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Automatico;
        private System.Windows.Forms.Button BTN_Manual;
    }
}