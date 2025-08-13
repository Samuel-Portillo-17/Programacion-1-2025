
namespace Hello_word
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
            this.btnCantidad = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCantidad
            // 
            this.btnCantidad.Location = new System.Drawing.Point(90, 172);
            this.btnCantidad.Name = "btnCantidad";
            this.btnCantidad.Size = new System.Drawing.Size(182, 73);
            this.btnCantidad.TabIndex = 0;
            this.btnCantidad.Text = "calcular";
            this.btnCantidad.UseVisualStyleBackColor = true;
            this.btnCantidad.Click += new System.EventHandler(this.button1_Click);
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Location = new System.Drawing.Point(57, 50);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(38, 13);
            this.num1.TabIndex = 1;
            this.num1.Text = "Num1:";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(110, 47);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(149, 20);
            this.txtNum1.TabIndex = 2;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(57, 134);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(70, 13);
            this.lblRespuesta.TabIndex = 3;
            this.lblRespuesta.Text = "Respuesta: ?";
            this.lblRespuesta.Click += new System.EventHandler(this.lblSaludo_Click);
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Location = new System.Drawing.Point(57, 84);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(38, 13);
            this.num2.TabIndex = 4;
            this.num2.Text = "Num2:";
            this.num2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(110, 84);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(118, 20);
            this.txtNum2.TabIndex = 5;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 294);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.btnCantidad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCantidad;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.TextBox txtNum2;
    }
}

