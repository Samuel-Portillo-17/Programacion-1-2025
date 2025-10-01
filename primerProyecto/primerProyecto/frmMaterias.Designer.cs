namespace primerProyecto
{
    partial class frmMaterias
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
            this.grbBusquedaMateria = new System.Windows.Forms.GroupBox();
            this.grdMateria = new System.Windows.Forms.DataGridView();
            this.txtBuscarMateria = new System.Windows.Forms.TextBox();
            this.grbEdicionAlumno = new System.Windows.Forms.GroupBox();
            this.btnEliminarMateria = new System.Windows.Forms.Button();
            this.btnModificarMateria = new System.Windows.Forms.Button();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.grbNavegacionAlumno = new System.Windows.Forms.GroupBox();
            this.lblnRegistrosMateria = new System.Windows.Forms.Label();
            this.btnUltimoMateria = new System.Windows.Forms.Button();
            this.btnSiguienteMateria = new System.Windows.Forms.Button();
            this.btnAnteriorMateria = new System.Windows.Forms.Button();
            this.btnPrimeroMateria = new System.Windows.Forms.Button();
            this.grbDatosMateria = new System.Windows.Forms.GroupBox();
            this.idMateria = new System.Windows.Forms.Label();
            this.lblIdlMateria = new System.Windows.Forms.Label();
            this.txtUvMateria = new System.Windows.Forms.TextBox();
            this.lblUvMateria = new System.Windows.Forms.Label();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.lblNombreMateria = new System.Windows.Forms.Label();
            this.txtCodigoMateria = new System.Windows.Forms.TextBox();
            this.lblCodigoMateria = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbBusquedaMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMateria)).BeginInit();
            this.grbEdicionAlumno.SuspendLayout();
            this.grbNavegacionAlumno.SuspendLayout();
            this.grbDatosMateria.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBusquedaMateria
            // 
            this.grbBusquedaMateria.Controls.Add(this.grdMateria);
            this.grbBusquedaMateria.Controls.Add(this.txtBuscarMateria);
            this.grbBusquedaMateria.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBusquedaMateria.Location = new System.Drawing.Point(353, 30);
            this.grbBusquedaMateria.Margin = new System.Windows.Forms.Padding(2);
            this.grbBusquedaMateria.Name = "grbBusquedaMateria";
            this.grbBusquedaMateria.Padding = new System.Windows.Forms.Padding(2);
            this.grbBusquedaMateria.Size = new System.Drawing.Size(577, 260);
            this.grbBusquedaMateria.TabIndex = 13;
            this.grbBusquedaMateria.TabStop = false;
            this.grbBusquedaMateria.Text = "Busqueda Materias";
            // 
            // grdMateria
            // 
            this.grdMateria.AllowUserToAddRows = false;
            this.grdMateria.AllowUserToDeleteRows = false;
            this.grdMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nombre,
            this.codigo,
            this.Unidad});
            this.grdMateria.Location = new System.Drawing.Point(4, 53);
            this.grdMateria.Margin = new System.Windows.Forms.Padding(2);
            this.grdMateria.Name = "grdMateria";
            this.grdMateria.ReadOnly = true;
            this.grdMateria.RowHeadersWidth = 62;
            this.grdMateria.RowTemplate.Height = 28;
            this.grdMateria.Size = new System.Drawing.Size(464, 173);
            this.grdMateria.TabIndex = 11;
            // 
            // txtBuscarMateria
            // 
            this.txtBuscarMateria.Location = new System.Drawing.Point(7, 29);
            this.txtBuscarMateria.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarMateria.Name = "txtBuscarMateria";
            this.txtBuscarMateria.Size = new System.Drawing.Size(461, 23);
            this.txtBuscarMateria.TabIndex = 10;
            // 
            // grbEdicionAlumno
            // 
            this.grbEdicionAlumno.Controls.Add(this.btnEliminarMateria);
            this.grbEdicionAlumno.Controls.Add(this.btnModificarMateria);
            this.grbEdicionAlumno.Controls.Add(this.btnAgregarMateria);
            this.grbEdicionAlumno.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEdicionAlumno.Location = new System.Drawing.Point(364, 307);
            this.grbEdicionAlumno.Margin = new System.Windows.Forms.Padding(2);
            this.grbEdicionAlumno.Name = "grbEdicionAlumno";
            this.grbEdicionAlumno.Padding = new System.Windows.Forms.Padding(2);
            this.grbEdicionAlumno.Size = new System.Drawing.Size(326, 65);
            this.grbEdicionAlumno.TabIndex = 12;
            this.grbEdicionAlumno.TabStop = false;
            this.grbEdicionAlumno.Text = "Edicion";
            // 
            // btnEliminarMateria
            // 
            this.btnEliminarMateria.Location = new System.Drawing.Point(228, 23);
            this.btnEliminarMateria.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarMateria.Name = "btnEliminarMateria";
            this.btnEliminarMateria.Size = new System.Drawing.Size(94, 32);
            this.btnEliminarMateria.TabIndex = 2;
            this.btnEliminarMateria.Text = "Eliminar";
            this.btnEliminarMateria.UseVisualStyleBackColor = true;
            // 
            // btnModificarMateria
            // 
            this.btnModificarMateria.Location = new System.Drawing.Point(123, 23);
            this.btnModificarMateria.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarMateria.Name = "btnModificarMateria";
            this.btnModificarMateria.Size = new System.Drawing.Size(95, 32);
            this.btnModificarMateria.TabIndex = 1;
            this.btnModificarMateria.Text = "Modificar";
            this.btnModificarMateria.UseVisualStyleBackColor = true;
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Location = new System.Drawing.Point(16, 23);
            this.btnAgregarMateria.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(103, 32);
            this.btnAgregarMateria.TabIndex = 0;
            this.btnAgregarMateria.Text = "Nuevo";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            // 
            // grbNavegacionAlumno
            // 
            this.grbNavegacionAlumno.Controls.Add(this.lblnRegistrosMateria);
            this.grbNavegacionAlumno.Controls.Add(this.btnUltimoMateria);
            this.grbNavegacionAlumno.Controls.Add(this.btnSiguienteMateria);
            this.grbNavegacionAlumno.Controls.Add(this.btnAnteriorMateria);
            this.grbNavegacionAlumno.Controls.Add(this.btnPrimeroMateria);
            this.grbNavegacionAlumno.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNavegacionAlumno.Location = new System.Drawing.Point(10, 307);
            this.grbNavegacionAlumno.Margin = new System.Windows.Forms.Padding(2);
            this.grbNavegacionAlumno.Name = "grbNavegacionAlumno";
            this.grbNavegacionAlumno.Padding = new System.Windows.Forms.Padding(2);
            this.grbNavegacionAlumno.Size = new System.Drawing.Size(326, 86);
            this.grbNavegacionAlumno.TabIndex = 11;
            this.grbNavegacionAlumno.TabStop = false;
            this.grbNavegacionAlumno.Text = "Navegacion";
            // 
            // lblnRegistrosMateria
            // 
            this.lblnRegistrosMateria.AutoSize = true;
            this.lblnRegistrosMateria.Location = new System.Drawing.Point(123, 64);
            this.lblnRegistrosMateria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnRegistrosMateria.Name = "lblnRegistrosMateria";
            this.lblnRegistrosMateria.Size = new System.Drawing.Size(49, 17);
            this.lblnRegistrosMateria.TabIndex = 10;
            this.lblnRegistrosMateria.Text = "X de N";
            // 
            // btnUltimoMateria
            // 
            this.btnUltimoMateria.Location = new System.Drawing.Point(231, 23);
            this.btnUltimoMateria.Margin = new System.Windows.Forms.Padding(2);
            this.btnUltimoMateria.Name = "btnUltimoMateria";
            this.btnUltimoMateria.Size = new System.Drawing.Size(61, 32);
            this.btnUltimoMateria.TabIndex = 3;
            this.btnUltimoMateria.Text = "Ultimo";
            this.btnUltimoMateria.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteMateria
            // 
            this.btnSiguienteMateria.Location = new System.Drawing.Point(158, 23);
            this.btnSiguienteMateria.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiguienteMateria.Name = "btnSiguienteMateria";
            this.btnSiguienteMateria.Size = new System.Drawing.Size(69, 32);
            this.btnSiguienteMateria.TabIndex = 2;
            this.btnSiguienteMateria.Text = "Siguiente";
            this.btnSiguienteMateria.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorMateria
            // 
            this.btnAnteriorMateria.Location = new System.Drawing.Point(93, 23);
            this.btnAnteriorMateria.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnteriorMateria.Name = "btnAnteriorMateria";
            this.btnAnteriorMateria.Size = new System.Drawing.Size(61, 32);
            this.btnAnteriorMateria.TabIndex = 1;
            this.btnAnteriorMateria.Text = "Anterior";
            this.btnAnteriorMateria.UseVisualStyleBackColor = true;
            // 
            // btnPrimeroMateria
            // 
            this.btnPrimeroMateria.Location = new System.Drawing.Point(22, 23);
            this.btnPrimeroMateria.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrimeroMateria.Name = "btnPrimeroMateria";
            this.btnPrimeroMateria.Size = new System.Drawing.Size(63, 32);
            this.btnPrimeroMateria.TabIndex = 0;
            this.btnPrimeroMateria.Text = "Primero";
            this.btnPrimeroMateria.UseVisualStyleBackColor = true;
            // 
            // grbDatosMateria
            // 
            this.grbDatosMateria.Controls.Add(this.idMateria);
            this.grbDatosMateria.Controls.Add(this.lblIdlMateria);
            this.grbDatosMateria.Controls.Add(this.txtUvMateria);
            this.grbDatosMateria.Controls.Add(this.lblUvMateria);
            this.grbDatosMateria.Controls.Add(this.txtNombreMateria);
            this.grbDatosMateria.Controls.Add(this.lblNombreMateria);
            this.grbDatosMateria.Controls.Add(this.txtCodigoMateria);
            this.grbDatosMateria.Controls.Add(this.lblCodigoMateria);
            this.grbDatosMateria.Enabled = false;
            this.grbDatosMateria.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosMateria.Location = new System.Drawing.Point(10, 20);
            this.grbDatosMateria.Margin = new System.Windows.Forms.Padding(2);
            this.grbDatosMateria.Name = "grbDatosMateria";
            this.grbDatosMateria.Padding = new System.Windows.Forms.Padding(2);
            this.grbDatosMateria.Size = new System.Drawing.Size(326, 270);
            this.grbDatosMateria.TabIndex = 10;
            this.grbDatosMateria.TabStop = false;
            this.grbDatosMateria.Text = "Datos";
            // 
            // idMateria
            // 
            this.idMateria.AutoSize = true;
            this.idMateria.Location = new System.Drawing.Point(91, 44);
            this.idMateria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idMateria.Name = "idMateria";
            this.idMateria.Size = new System.Drawing.Size(24, 17);
            this.idMateria.TabIndex = 9;
            this.idMateria.Text = "ID";
            // 
            // lblIdlMateria
            // 
            this.lblIdlMateria.AutoSize = true;
            this.lblIdlMateria.Location = new System.Drawing.Point(33, 44);
            this.lblIdlMateria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdlMateria.Name = "lblIdlMateria";
            this.lblIdlMateria.Size = new System.Drawing.Size(29, 17);
            this.lblIdlMateria.TabIndex = 6;
            this.lblIdlMateria.Text = "ID:";
            // 
            // txtUvMateria
            // 
            this.txtUvMateria.Location = new System.Drawing.Point(113, 144);
            this.txtUvMateria.Margin = new System.Windows.Forms.Padding(2);
            this.txtUvMateria.Name = "txtUvMateria";
            this.txtUvMateria.Size = new System.Drawing.Size(124, 23);
            this.txtUvMateria.TabIndex = 5;
            // 
            // lblUvMateria
            // 
            this.lblUvMateria.AutoSize = true;
            this.lblUvMateria.Location = new System.Drawing.Point(34, 144);
            this.lblUvMateria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUvMateria.Name = "lblUvMateria";
            this.lblUvMateria.Size = new System.Drawing.Size(71, 17);
            this.lblUvMateria.TabIndex = 4;
            this.lblUvMateria.Text = "Direccion:";
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Location = new System.Drawing.Point(113, 106);
            this.txtNombreMateria.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(124, 23);
            this.txtNombreMateria.TabIndex = 3;
            // 
            // lblNombreMateria
            // 
            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.Location = new System.Drawing.Point(34, 106);
            this.lblNombreMateria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreMateria.Name = "lblNombreMateria";
            this.lblNombreMateria.Size = new System.Drawing.Size(61, 17);
            this.lblNombreMateria.TabIndex = 2;
            this.lblNombreMateria.Text = "Nombre:";
            // 
            // txtCodigoMateria
            // 
            this.txtCodigoMateria.Location = new System.Drawing.Point(113, 72);
            this.txtCodigoMateria.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoMateria.Name = "txtCodigoMateria";
            this.txtCodigoMateria.Size = new System.Drawing.Size(124, 23);
            this.txtCodigoMateria.TabIndex = 1;
            // 
            // lblCodigoMateria
            // 
            this.lblCodigoMateria.AutoSize = true;
            this.lblCodigoMateria.Location = new System.Drawing.Point(34, 72);
            this.lblCodigoMateria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoMateria.Name = "lblCodigoMateria";
            this.lblCodigoMateria.Size = new System.Drawing.Size(55, 17);
            this.lblCodigoMateria.TabIndex = 0;
            this.lblCodigoMateria.Text = "Codigo:";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "idMateria";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 150;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 8;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "nombre";
            this.codigo.HeaderText = "Codigo";
            this.codigo.MinimumWidth = 8;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 150;
            // 
            // Unidad
            // 
            this.Unidad.DataPropertyName = "uv";
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.MinimumWidth = 8;
            this.Unidad.Name = "Unidad";
            this.Unidad.ReadOnly = true;
            // 
            // frmMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 416);
            this.Controls.Add(this.grbBusquedaMateria);
            this.Controls.Add(this.grbEdicionAlumno);
            this.Controls.Add(this.grbNavegacionAlumno);
            this.Controls.Add(this.grbDatosMateria);
            this.Name = "frmMaterias";
            this.Text = "frmMaterias";
            this.Load += new System.EventHandler(this.frmMaterias_Load);
            this.grbBusquedaMateria.ResumeLayout(false);
            this.grbBusquedaMateria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMateria)).EndInit();
            this.grbEdicionAlumno.ResumeLayout(false);
            this.grbNavegacionAlumno.ResumeLayout(false);
            this.grbNavegacionAlumno.PerformLayout();
            this.grbDatosMateria.ResumeLayout(false);
            this.grbDatosMateria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBusquedaMateria;
        private System.Windows.Forms.DataGridView grdMateria;
        private System.Windows.Forms.TextBox txtBuscarMateria;
        private System.Windows.Forms.GroupBox grbEdicionAlumno;
        private System.Windows.Forms.Button btnEliminarMateria;
        private System.Windows.Forms.Button btnModificarMateria;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.GroupBox grbNavegacionAlumno;
        private System.Windows.Forms.Label lblnRegistrosMateria;
        private System.Windows.Forms.Button btnUltimoMateria;
        private System.Windows.Forms.Button btnSiguienteMateria;
        private System.Windows.Forms.Button btnAnteriorMateria;
        private System.Windows.Forms.Button btnPrimeroMateria;
        private System.Windows.Forms.GroupBox grbDatosMateria;
        private System.Windows.Forms.Label idMateria;
        private System.Windows.Forms.Label lblIdlMateria;
        private System.Windows.Forms.TextBox txtUvMateria;
        private System.Windows.Forms.Label lblUvMateria;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.Label lblNombreMateria;
        private System.Windows.Forms.TextBox txtCodigoMateria;
        private System.Windows.Forms.Label lblCodigoMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
    }
}