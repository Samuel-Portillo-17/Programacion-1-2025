
namespace Parcial_Ejercicio_2
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
            this.btnConvertir = new System.Windows.Forms.Button();
            this.cboAConversor = new System.Windows.Forms.ComboBox();
            this.lblAConversor = new System.Windows.Forms.Label();
            this.cboTipoConversor = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtCantidadConversor = new System.Windows.Forms.TextBox();
            this.lblRespuestaConversor = new System.Windows.Forms.Label();
            this.lblCantidadConversor = new System.Windows.Forms.Label();
            this.lblConversorAreas = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cboDeConversor = new System.Windows.Forms.ComboBox();
            this.lblDeConversor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(417, 186);
            this.btnConvertir.Margin = new System.Windows.Forms.Padding(2);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(171, 47);
            this.btnConvertir.TabIndex = 37;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // cboAConversor
            // 
            this.cboAConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAConversor.Location = new System.Drawing.Point(417, 134);
            this.cboAConversor.Margin = new System.Windows.Forms.Padding(2);
            this.cboAConversor.Name = "cboAConversor";
            this.cboAConversor.Size = new System.Drawing.Size(172, 21);
            this.cboAConversor.TabIndex = 35;
            // 
            // lblAConversor
            // 
            this.lblAConversor.AutoSize = true;
            this.lblAConversor.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAConversor.Location = new System.Drawing.Point(378, 138);
            this.lblAConversor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAConversor.Name = "lblAConversor";
            this.lblAConversor.Size = new System.Drawing.Size(23, 17);
            this.lblAConversor.TabIndex = 36;
            this.lblAConversor.Text = "A:";
            // 
            // cboTipoConversor
            // 
            this.cboTipoConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoConversor.Items.AddRange(new object[] {
            "Area"});
            this.cboTipoConversor.Location = new System.Drawing.Point(161, 104);
            this.cboTipoConversor.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoConversor.Name = "cboTipoConversor";
            this.cboTipoConversor.Size = new System.Drawing.Size(172, 21);
            this.cboTipoConversor.TabIndex = 28;
            this.cboTipoConversor.SelectedIndexChanged += new System.EventHandler(this.cboTipoConversor_SelectedIndexChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(105, 108);
            this.lblArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(43, 17);
            this.lblArea.TabIndex = 32;
            this.lblArea.Text = "Area:";
            // 
            // txtCantidadConversor
            // 
            this.txtCantidadConversor.Location = new System.Drawing.Point(170, 186);
            this.txtCantidadConversor.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadConversor.Name = "txtCantidadConversor";
            this.txtCantidadConversor.Size = new System.Drawing.Size(163, 20);
            this.txtCantidadConversor.TabIndex = 31;
            // 
            // lblRespuestaConversor
            // 
            this.lblRespuestaConversor.AutoSize = true;
            this.lblRespuestaConversor.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuestaConversor.Location = new System.Drawing.Point(105, 216);
            this.lblRespuestaConversor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRespuestaConversor.Name = "lblRespuestaConversor";
            this.lblRespuestaConversor.Size = new System.Drawing.Size(76, 17);
            this.lblRespuestaConversor.TabIndex = 30;
            this.lblRespuestaConversor.Text = "Respuesta:";
            // 
            // lblCantidadConversor
            // 
            this.lblCantidadConversor.AutoSize = true;
            this.lblCantidadConversor.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadConversor.Location = new System.Drawing.Point(105, 187);
            this.lblCantidadConversor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadConversor.Name = "lblCantidadConversor";
            this.lblCantidadConversor.Size = new System.Drawing.Size(68, 17);
            this.lblCantidadConversor.TabIndex = 29;
            this.lblCantidadConversor.Text = "Cantidad:";
            // 
            // lblConversorAreas
            // 
            this.lblConversorAreas.AutoSize = true;
            this.lblConversorAreas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversorAreas.Location = new System.Drawing.Point(235, 22);
            this.lblConversorAreas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConversorAreas.Name = "lblConversorAreas";
            this.lblConversorAreas.Size = new System.Drawing.Size(142, 19);
            this.lblConversorAreas.TabIndex = 38;
            this.lblConversorAreas.Text = "Conversor de Areas";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(137, 59);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(358, 19);
            this.lblInfo.TabIndex = 39;
            this.lblInfo.Text = "Programa para calcular distintas medidas de las areas";
            // 
            // cboDeConversor
            // 
            this.cboDeConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeConversor.Location = new System.Drawing.Point(161, 138);
            this.cboDeConversor.Margin = new System.Windows.Forms.Padding(2);
            this.cboDeConversor.Name = "cboDeConversor";
            this.cboDeConversor.Size = new System.Drawing.Size(172, 21);
            this.cboDeConversor.TabIndex = 40;
            // 
            // lblDeConversor
            // 
            this.lblDeConversor.AutoSize = true;
            this.lblDeConversor.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeConversor.Location = new System.Drawing.Point(106, 142);
            this.lblDeConversor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeConversor.Name = "lblDeConversor";
            this.lblDeConversor.Size = new System.Drawing.Size(30, 17);
            this.lblDeConversor.TabIndex = 41;
            this.lblDeConversor.Text = "De:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(656, 313);
            this.Controls.Add(this.cboDeConversor);
            this.Controls.Add(this.lblDeConversor);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblConversorAreas);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.cboAConversor);
            this.Controls.Add(this.lblAConversor);
            this.Controls.Add(this.cboTipoConversor);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtCantidadConversor);
            this.Controls.Add(this.lblRespuestaConversor);
            this.Controls.Add(this.lblCantidadConversor);
            this.Name = "Form1";
            this.Text = "Conversor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.ComboBox cboAConversor;
        private System.Windows.Forms.Label lblAConversor;
        private System.Windows.Forms.ComboBox cboTipoConversor;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtCantidadConversor;
        private System.Windows.Forms.Label lblRespuestaConversor;
        private System.Windows.Forms.Label lblCantidadConversor;
        private System.Windows.Forms.Label lblConversorAreas;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cboDeConversor;
        private System.Windows.Forms.Label lblDeConversor;
    }
}

