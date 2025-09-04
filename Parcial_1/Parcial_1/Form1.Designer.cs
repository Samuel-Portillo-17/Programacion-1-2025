namespace Parcial_1
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
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.btnCalcularImp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(50, 69);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(68, 24);
            this.lblMonto.TabIndex = 2;
            this.lblMonto.Text = "Monto";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(50, 129);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(103, 24);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(143, 72);
            this.txtM.Margin = new System.Windows.Forms.Padding(4);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(210, 21);
            this.txtM.TabIndex = 7;
            // 
            // btnCalcularImp
            // 
            this.btnCalcularImp.Location = new System.Drawing.Point(399, 60);
            this.btnCalcularImp.Name = "btnCalcularImp";
            this.btnCalcularImp.Size = new System.Drawing.Size(179, 113);
            this.btnCalcularImp.TabIndex = 10;
            this.btnCalcularImp.Text = "Calcular";
            this.btnCalcularImp.UseVisualStyleBackColor = true;
            this.btnCalcularImp.Click += new System.EventHandler(this.btnCalcularImp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(661, 386);
            this.Controls.Add(this.btnCalcularImp);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblMonto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Impuestos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Button btnCalcularImp;
    }
}

