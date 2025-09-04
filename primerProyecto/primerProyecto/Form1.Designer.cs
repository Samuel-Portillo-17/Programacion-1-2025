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
            this.lblCantidadConversor = new System.Windows.Forms.Label();
            this.lblRespuestaConversor = new System.Windows.Forms.Label();
            this.txtCantidadConversor = new System.Windows.Forms.TextBox();
            this.lblTipoConversor = new System.Windows.Forms.Label();
            this.cboTipoConversor = new System.Windows.Forms.ComboBox();
            this.lblDeConversor = new System.Windows.Forms.Label();
            this.cboDeConversor = new System.Windows.Forms.ComboBox();
            this.lblAConversor = new System.Windows.Forms.Label();
            this.cboAConversor = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCantidadConversor
            // 
            this.lblCantidadConversor.AutoSize = true;
            this.lblCantidadConversor.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadConversor.Location = new System.Drawing.Point(41, 110);
            this.lblCantidadConversor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadConversor.Name = "lblCantidadConversor";
            this.lblCantidadConversor.Size = new System.Drawing.Size(68, 17);
            this.lblCantidadConversor.TabIndex = 19;
            this.lblCantidadConversor.Text = "Cantidad:";
            // 
            // lblRespuestaConversor
            // 
            this.lblRespuestaConversor.AutoSize = true;
            this.lblRespuestaConversor.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuestaConversor.Location = new System.Drawing.Point(41, 135);
            this.lblRespuestaConversor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRespuestaConversor.Name = "lblRespuestaConversor";
            this.lblRespuestaConversor.Size = new System.Drawing.Size(76, 17);
            this.lblRespuestaConversor.TabIndex = 20;
            this.lblRespuestaConversor.Text = "Respuesta:";
            // 
            // txtCantidadConversor
            // 
            this.txtCantidadConversor.Location = new System.Drawing.Point(106, 109);
            this.txtCantidadConversor.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadConversor.Name = "txtCantidadConversor";
            this.txtCantidadConversor.Size = new System.Drawing.Size(163, 20);
            this.txtCantidadConversor.TabIndex = 21;
            // 
            // lblTipoConversor
            // 
            this.lblTipoConversor.AutoSize = true;
            this.lblTipoConversor.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoConversor.Location = new System.Drawing.Point(42, 31);
            this.lblTipoConversor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoConversor.Name = "lblTipoConversor";
            this.lblTipoConversor.Size = new System.Drawing.Size(45, 17);
            this.lblTipoConversor.TabIndex = 22;
            this.lblTipoConversor.Text = "Serie:";
            // 
            // cboTipoConversor
            // 
            this.cboTipoConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoConversor.Items.AddRange(new object[] {
            "Monedas",
            "Longitud",
            "Masa",
            "Volumen",
            "Almacenamiento",
            "Tiempo",
            "Area"});
            this.cboTipoConversor.Location = new System.Drawing.Point(97, 29);
            this.cboTipoConversor.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoConversor.Name = "cboTipoConversor";
            this.cboTipoConversor.Size = new System.Drawing.Size(172, 21);
            this.cboTipoConversor.TabIndex = 18;
            this.cboTipoConversor.SelectedIndexChanged += new System.EventHandler(this.cboTipoConversor_SelectedIndexChanged);
            // 
            // lblDeConversor
            // 
            this.lblDeConversor.AutoSize = true;
            this.lblDeConversor.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeConversor.Location = new System.Drawing.Point(42, 61);
            this.lblDeConversor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeConversor.Name = "lblDeConversor";
            this.lblDeConversor.Size = new System.Drawing.Size(30, 17);
            this.lblDeConversor.TabIndex = 24;
            this.lblDeConversor.Text = "De:";
            // 
            // cboDeConversor
            // 
            this.cboDeConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeConversor.Location = new System.Drawing.Point(97, 57);
            this.cboDeConversor.Margin = new System.Windows.Forms.Padding(2);
            this.cboDeConversor.Name = "cboDeConversor";
            this.cboDeConversor.Size = new System.Drawing.Size(172, 21);
            this.cboDeConversor.TabIndex = 23;
            // 
            // lblAConversor
            // 
            this.lblAConversor.AutoSize = true;
            this.lblAConversor.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAConversor.Location = new System.Drawing.Point(314, 61);
            this.lblAConversor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAConversor.Name = "lblAConversor";
            this.lblAConversor.Size = new System.Drawing.Size(23, 17);
            this.lblAConversor.TabIndex = 26;
            this.lblAConversor.Text = "A:";
            // 
            // cboAConversor
            // 
            this.cboAConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAConversor.Location = new System.Drawing.Point(353, 57);
            this.cboAConversor.Margin = new System.Windows.Forms.Padding(2);
            this.cboAConversor.Name = "cboAConversor";
            this.cboAConversor.Size = new System.Drawing.Size(172, 21);
            this.cboAConversor.TabIndex = 25;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(353, 109);
            this.btnConvertir.Margin = new System.Windows.Forms.Padding(2);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(171, 47);
            this.btnConvertir.TabIndex = 27;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 300);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.cboAConversor);
            this.Controls.Add(this.lblAConversor);
            this.Controls.Add(this.cboDeConversor);
            this.Controls.Add(this.lblDeConversor);
            this.Controls.Add(this.cboTipoConversor);
            this.Controls.Add(this.lblTipoConversor);
            this.Controls.Add(this.txtCantidadConversor);
            this.Controls.Add(this.lblRespuestaConversor);
            this.Controls.Add(this.lblCantidadConversor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Hola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantidadConversor;
        private System.Windows.Forms.Label lblRespuestaConversor;
        private System.Windows.Forms.TextBox txtCantidadConversor;
        private System.Windows.Forms.Label lblTipoConversor;
        private System.Windows.Forms.ComboBox cboTipoConversor;
        private System.Windows.Forms.Label lblDeConversor;
        private System.Windows.Forms.ComboBox cboDeConversor;
        private System.Windows.Forms.Label lblAConversor;
        private System.Windows.Forms.ComboBox cboAConversor;
        private System.Windows.Forms.Button btnConvertir;
    }
}

