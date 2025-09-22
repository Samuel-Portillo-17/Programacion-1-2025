namespace primerProyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblArmonica = new System.Windows.Forms.Label();
            this.lblTipica = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblArmonica
            // 
            this.lblArmonica.AutoSize = true;
            this.lblArmonica.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmonica.Location = new System.Drawing.Point(33, 138);
            this.lblArmonica.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArmonica.Name = "lblArmonica";
            this.lblArmonica.Size = new System.Drawing.Size(73, 17);
            this.lblArmonica.TabIndex = 11;
            this.lblArmonica.Text = "Armonica:";
            // 
            // lblTipica
            // 
            this.lblTipica.AutoSize = true;
            this.lblTipica.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipica.Location = new System.Drawing.Point(33, 101);
            this.lblTipica.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipica.Name = "lblTipica";
            this.lblTipica.Size = new System.Drawing.Size(49, 17);
            this.lblTipica.TabIndex = 10;
            this.lblTipica.Text = "Tipica:";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(33, 72);
            this.lblMedia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(50, 17);
            this.lblMedia.TabIndex = 9;
            this.lblMedia.Text = "Media:";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(33, 39);
            this.lblSerie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(45, 17);
            this.lblSerie.TabIndex = 8;
            this.lblSerie.Text = "Serie:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(344, 51);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(107, 57);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSerie
            // 
            this.txtSerie.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(88, 39);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(2);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(163, 23);
            this.txtSerie.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 300);
            this.Controls.Add(this.lblArmonica);
            this.Controls.Add(this.lblTipica);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSerie);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Hola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArmonica;
        private System.Windows.Forms.Label lblTipica;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSerie;
    }
}

