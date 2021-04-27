
namespace PRO2_DABD1249321
{
    partial class DataForm
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
            this.labelCSV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCSV
            // 
            this.labelCSV.AutoSize = true;
            this.labelCSV.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCSV.ForeColor = System.Drawing.Color.Brown;
            this.labelCSV.Location = new System.Drawing.Point(269, 56);
            this.labelCSV.Name = "labelCSV";
            this.labelCSV.Size = new System.Drawing.Size(200, 30);
            this.labelCSV.TabIndex = 0;
            this.labelCSV.Text = "Cargar archivo CSV";
            this.labelCSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCSV);
            this.Name = "DataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCSV;
    }
}