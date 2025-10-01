namespace primerProyecto
{
    partial class FormDocente
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
            this.grbBusquedaDocente = new System.Windows.Forms.GroupBox();
            this.grdDocentes = new System.Windows.Forms.DataGridView();
            this.txtBuscarDocentes = new System.Windows.Forms.TextBox();
            this.grbEdicionDocentes = new System.Windows.Forms.GroupBox();
            this.btnEliminarDocentes = new System.Windows.Forms.Button();
            this.btnModificarDocentes = new System.Windows.Forms.Button();
            this.btnAgregarDocentes = new System.Windows.Forms.Button();
            this.grbNavegacionDocentes = new System.Windows.Forms.GroupBox();
            this.lblnRegistrosDocentes = new System.Windows.Forms.Label();
            this.btnUltimoDocentes = new System.Windows.Forms.Button();
            this.btnSiguienteDocentes = new System.Windows.Forms.Button();
            this.btnAnteriorDocentes = new System.Windows.Forms.Button();
            this.btnPrimeroDocentes = new System.Windows.Forms.Button();
            this.grbDatosDocentes = new System.Windows.Forms.GroupBox();
            this.idDocente = new System.Windows.Forms.Label();
            this.txtTelefonoDocentes = new System.Windows.Forms.TextBox();
            this.lblTelefonoDocentes = new System.Windows.Forms.Label();
            this.lblIdlDocentes = new System.Windows.Forms.Label();
            this.txtDireccionDocentes = new System.Windows.Forms.TextBox();
            this.lblDireccionDocentes = new System.Windows.Forms.Label();
            this.txtNombreDocentes = new System.Windows.Forms.TextBox();
            this.lblNombreDocentes = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbBusquedaDocente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocentes)).BeginInit();
            this.grbEdicionDocentes.SuspendLayout();
            this.grbNavegacionDocentes.SuspendLayout();
            this.grbDatosDocentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBusquedaDocente
            // 
            this.grbBusquedaDocente.Controls.Add(this.grdDocentes);
            this.grbBusquedaDocente.Controls.Add(this.txtBuscarDocentes);
            this.grbBusquedaDocente.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBusquedaDocente.Location = new System.Drawing.Point(373, 23);
            this.grbBusquedaDocente.Margin = new System.Windows.Forms.Padding(2);
            this.grbBusquedaDocente.Name = "grbBusquedaDocente";
            this.grbBusquedaDocente.Padding = new System.Windows.Forms.Padding(2);
            this.grbBusquedaDocente.Size = new System.Drawing.Size(577, 260);
            this.grbBusquedaDocente.TabIndex = 13;
            this.grbBusquedaDocente.TabStop = false;
            this.grbBusquedaDocente.Text = "Busqueda Docentes";
            // 
            // grdDocentes
            // 
            this.grdDocentes.AllowUserToAddRows = false;
            this.grdDocentes.AllowUserToDeleteRows = false;
            this.grdDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nombre,
            this.direccion,
            this.telefono,
            this.codigo});
            this.grdDocentes.Location = new System.Drawing.Point(4, 53);
            this.grdDocentes.Margin = new System.Windows.Forms.Padding(2);
            this.grdDocentes.Name = "grdDocentes";
            this.grdDocentes.ReadOnly = true;
            this.grdDocentes.RowHeadersWidth = 62;
            this.grdDocentes.RowTemplate.Height = 28;
            this.grdDocentes.Size = new System.Drawing.Size(550, 173);
            this.grdDocentes.TabIndex = 11;
            this.grdDocentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDocentes_CellClick);
            this.grdDocentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDocentes_CellContentClick);
            // 
            // txtBuscarDocentes
            // 
            this.txtBuscarDocentes.Location = new System.Drawing.Point(7, 29);
            this.txtBuscarDocentes.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarDocentes.Name = "txtBuscarDocentes";
            this.txtBuscarDocentes.Size = new System.Drawing.Size(546, 23);
            this.txtBuscarDocentes.TabIndex = 10;
            this.txtBuscarDocentes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarDocentes_KeyUp);
            // 
            // grbEdicionDocentes
            // 
            this.grbEdicionDocentes.Controls.Add(this.btnEliminarDocentes);
            this.grbEdicionDocentes.Controls.Add(this.btnModificarDocentes);
            this.grbEdicionDocentes.Controls.Add(this.btnAgregarDocentes);
            this.grbEdicionDocentes.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEdicionDocentes.Location = new System.Drawing.Point(364, 300);
            this.grbEdicionDocentes.Margin = new System.Windows.Forms.Padding(2);
            this.grbEdicionDocentes.Name = "grbEdicionDocentes";
            this.grbEdicionDocentes.Padding = new System.Windows.Forms.Padding(2);
            this.grbEdicionDocentes.Size = new System.Drawing.Size(326, 65);
            this.grbEdicionDocentes.TabIndex = 12;
            this.grbEdicionDocentes.TabStop = false;
            this.grbEdicionDocentes.Text = "Edicion";
            // 
            // btnEliminarDocentes
            // 
            this.btnEliminarDocentes.Location = new System.Drawing.Point(228, 23);
            this.btnEliminarDocentes.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarDocentes.Name = "btnEliminarDocentes";
            this.btnEliminarDocentes.Size = new System.Drawing.Size(94, 32);
            this.btnEliminarDocentes.TabIndex = 2;
            this.btnEliminarDocentes.Text = "Eliminar";
            this.btnEliminarDocentes.UseVisualStyleBackColor = true;
            this.btnEliminarDocentes.Click += new System.EventHandler(this.btnEliminarDocentes_Click);
            // 
            // btnModificarDocentes
            // 
            this.btnModificarDocentes.Location = new System.Drawing.Point(123, 23);
            this.btnModificarDocentes.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarDocentes.Name = "btnModificarDocentes";
            this.btnModificarDocentes.Size = new System.Drawing.Size(95, 32);
            this.btnModificarDocentes.TabIndex = 1;
            this.btnModificarDocentes.Text = "Modificar";
            this.btnModificarDocentes.UseVisualStyleBackColor = true;
            this.btnModificarDocentes.Click += new System.EventHandler(this.btnModificarDocentes_Click);
            // 
            // btnAgregarDocentes
            // 
            this.btnAgregarDocentes.Location = new System.Drawing.Point(16, 23);
            this.btnAgregarDocentes.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarDocentes.Name = "btnAgregarDocentes";
            this.btnAgregarDocentes.Size = new System.Drawing.Size(103, 32);
            this.btnAgregarDocentes.TabIndex = 0;
            this.btnAgregarDocentes.Text = "Nuevo";
            this.btnAgregarDocentes.UseVisualStyleBackColor = true;
            this.btnAgregarDocentes.Click += new System.EventHandler(this.btnAgregarDocentes_Click);
            // 
            // grbNavegacionDocentes
            // 
            this.grbNavegacionDocentes.Controls.Add(this.lblnRegistrosDocentes);
            this.grbNavegacionDocentes.Controls.Add(this.btnUltimoDocentes);
            this.grbNavegacionDocentes.Controls.Add(this.btnSiguienteDocentes);
            this.grbNavegacionDocentes.Controls.Add(this.btnAnteriorDocentes);
            this.grbNavegacionDocentes.Controls.Add(this.btnPrimeroDocentes);
            this.grbNavegacionDocentes.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNavegacionDocentes.Location = new System.Drawing.Point(10, 300);
            this.grbNavegacionDocentes.Margin = new System.Windows.Forms.Padding(2);
            this.grbNavegacionDocentes.Name = "grbNavegacionDocentes";
            this.grbNavegacionDocentes.Padding = new System.Windows.Forms.Padding(2);
            this.grbNavegacionDocentes.Size = new System.Drawing.Size(326, 86);
            this.grbNavegacionDocentes.TabIndex = 11;
            this.grbNavegacionDocentes.TabStop = false;
            this.grbNavegacionDocentes.Text = "Navegacion";
            // 
            // lblnRegistrosDocentes
            // 
            this.lblnRegistrosDocentes.AutoSize = true;
            this.lblnRegistrosDocentes.Location = new System.Drawing.Point(123, 64);
            this.lblnRegistrosDocentes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnRegistrosDocentes.Name = "lblnRegistrosDocentes";
            this.lblnRegistrosDocentes.Size = new System.Drawing.Size(49, 17);
            this.lblnRegistrosDocentes.TabIndex = 10;
            this.lblnRegistrosDocentes.Text = "X de N";
            // 
            // btnUltimoDocentes
            // 
            this.btnUltimoDocentes.Location = new System.Drawing.Point(231, 23);
            this.btnUltimoDocentes.Margin = new System.Windows.Forms.Padding(2);
            this.btnUltimoDocentes.Name = "btnUltimoDocentes";
            this.btnUltimoDocentes.Size = new System.Drawing.Size(61, 32);
            this.btnUltimoDocentes.TabIndex = 3;
            this.btnUltimoDocentes.Text = "Ultimo";
            this.btnUltimoDocentes.UseVisualStyleBackColor = true;
            this.btnUltimoDocentes.Click += new System.EventHandler(this.btnUltimoDocentes_Click);
            // 
            // btnSiguienteDocentes
            // 
            this.btnSiguienteDocentes.Location = new System.Drawing.Point(158, 23);
            this.btnSiguienteDocentes.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiguienteDocentes.Name = "btnSiguienteDocentes";
            this.btnSiguienteDocentes.Size = new System.Drawing.Size(69, 32);
            this.btnSiguienteDocentes.TabIndex = 2;
            this.btnSiguienteDocentes.Text = "Siguiente";
            this.btnSiguienteDocentes.UseVisualStyleBackColor = true;
            this.btnSiguienteDocentes.Click += new System.EventHandler(this.btnSiguienteDocentes_Click);
            // 
            // btnAnteriorDocentes
            // 
            this.btnAnteriorDocentes.Location = new System.Drawing.Point(93, 23);
            this.btnAnteriorDocentes.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnteriorDocentes.Name = "btnAnteriorDocentes";
            this.btnAnteriorDocentes.Size = new System.Drawing.Size(61, 32);
            this.btnAnteriorDocentes.TabIndex = 1;
            this.btnAnteriorDocentes.Text = "Anterior";
            this.btnAnteriorDocentes.UseVisualStyleBackColor = true;
            this.btnAnteriorDocentes.Click += new System.EventHandler(this.btnAnteriorDocentes_Click);
            // 
            // btnPrimeroDocentes
            // 
            this.btnPrimeroDocentes.Location = new System.Drawing.Point(22, 23);
            this.btnPrimeroDocentes.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrimeroDocentes.Name = "btnPrimeroDocentes";
            this.btnPrimeroDocentes.Size = new System.Drawing.Size(63, 32);
            this.btnPrimeroDocentes.TabIndex = 0;
            this.btnPrimeroDocentes.Text = "Primero";
            this.btnPrimeroDocentes.UseVisualStyleBackColor = true;
            this.btnPrimeroDocentes.Click += new System.EventHandler(this.btnPrimeroDocentes_Click);
            // 
            // grbDatosDocentes
            // 
            this.grbDatosDocentes.Controls.Add(this.idDocente);
            this.grbDatosDocentes.Controls.Add(this.txtTelefonoDocentes);
            this.grbDatosDocentes.Controls.Add(this.lblTelefonoDocentes);
            this.grbDatosDocentes.Controls.Add(this.lblIdlDocentes);
            this.grbDatosDocentes.Controls.Add(this.txtDireccionDocentes);
            this.grbDatosDocentes.Controls.Add(this.lblDireccionDocentes);
            this.grbDatosDocentes.Controls.Add(this.txtNombreDocentes);
            this.grbDatosDocentes.Controls.Add(this.lblNombreDocentes);
            this.grbDatosDocentes.Enabled = false;
            this.grbDatosDocentes.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosDocentes.Location = new System.Drawing.Point(10, 13);
            this.grbDatosDocentes.Margin = new System.Windows.Forms.Padding(2);
            this.grbDatosDocentes.Name = "grbDatosDocentes";
            this.grbDatosDocentes.Padding = new System.Windows.Forms.Padding(2);
            this.grbDatosDocentes.Size = new System.Drawing.Size(326, 270);
            this.grbDatosDocentes.TabIndex = 10;
            this.grbDatosDocentes.TabStop = false;
            this.grbDatosDocentes.Text = "Datos";
            // 
            // idDocente
            // 
            this.idDocente.AutoSize = true;
            this.idDocente.Location = new System.Drawing.Point(91, 44);
            this.idDocente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idDocente.Name = "idDocente";
            this.idDocente.Size = new System.Drawing.Size(24, 17);
            this.idDocente.TabIndex = 9;
            this.idDocente.Text = "ID";
            // 
            // txtTelefonoDocentes
            // 
            this.txtTelefonoDocentes.Location = new System.Drawing.Point(103, 155);
            this.txtTelefonoDocentes.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefonoDocentes.Name = "txtTelefonoDocentes";
            this.txtTelefonoDocentes.Size = new System.Drawing.Size(124, 23);
            this.txtTelefonoDocentes.TabIndex = 8;
            // 
            // lblTelefonoDocentes
            // 
            this.lblTelefonoDocentes.AutoSize = true;
            this.lblTelefonoDocentes.Location = new System.Drawing.Point(24, 155);
            this.lblTelefonoDocentes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefonoDocentes.Name = "lblTelefonoDocentes";
            this.lblTelefonoDocentes.Size = new System.Drawing.Size(65, 17);
            this.lblTelefonoDocentes.TabIndex = 7;
            this.lblTelefonoDocentes.Text = "Telefono:";
            // 
            // lblIdlDocentes
            // 
            this.lblIdlDocentes.AutoSize = true;
            this.lblIdlDocentes.Location = new System.Drawing.Point(33, 44);
            this.lblIdlDocentes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdlDocentes.Name = "lblIdlDocentes";
            this.lblIdlDocentes.Size = new System.Drawing.Size(29, 17);
            this.lblIdlDocentes.TabIndex = 6;
            this.lblIdlDocentes.Text = "ID:";
            // 
            // txtDireccionDocentes
            // 
            this.txtDireccionDocentes.Location = new System.Drawing.Point(103, 118);
            this.txtDireccionDocentes.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccionDocentes.Name = "txtDireccionDocentes";
            this.txtDireccionDocentes.Size = new System.Drawing.Size(124, 23);
            this.txtDireccionDocentes.TabIndex = 5;
            // 
            // lblDireccionDocentes
            // 
            this.lblDireccionDocentes.AutoSize = true;
            this.lblDireccionDocentes.Location = new System.Drawing.Point(24, 118);
            this.lblDireccionDocentes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccionDocentes.Name = "lblDireccionDocentes";
            this.lblDireccionDocentes.Size = new System.Drawing.Size(71, 17);
            this.lblDireccionDocentes.TabIndex = 4;
            this.lblDireccionDocentes.Text = "Direccion:";
            // 
            // txtNombreDocentes
            // 
            this.txtNombreDocentes.Location = new System.Drawing.Point(103, 80);
            this.txtNombreDocentes.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreDocentes.Name = "txtNombreDocentes";
            this.txtNombreDocentes.Size = new System.Drawing.Size(124, 23);
            this.txtNombreDocentes.TabIndex = 3;
            // 
            // lblNombreDocentes
            // 
            this.lblNombreDocentes.AutoSize = true;
            this.lblNombreDocentes.Location = new System.Drawing.Point(24, 80);
            this.lblNombreDocentes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreDocentes.Name = "lblNombreDocentes";
            this.lblNombreDocentes.Size = new System.Drawing.Size(61, 17);
            this.lblNombreDocentes.TabIndex = 2;
            this.lblNombreDocentes.Text = "Nombre:";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "idDocentes";
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
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Direccion";
            this.direccion.MinimumWidth = 8;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 200;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.MinimumWidth = 8;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 150;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // FormDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbBusquedaDocente);
            this.Controls.Add(this.grbEdicionDocentes);
            this.Controls.Add(this.grbNavegacionDocentes);
            this.Controls.Add(this.grbDatosDocentes);
            this.Name = "FormDocente";
            this.Text = "Administracion Docente";
            this.Load += new System.EventHandler(this.FormDocente_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormDocente_KeyUp);
            this.grbBusquedaDocente.ResumeLayout(false);
            this.grbBusquedaDocente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocentes)).EndInit();
            this.grbEdicionDocentes.ResumeLayout(false);
            this.grbNavegacionDocentes.ResumeLayout(false);
            this.grbNavegacionDocentes.PerformLayout();
            this.grbDatosDocentes.ResumeLayout(false);
            this.grbDatosDocentes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBusquedaDocente;
        private System.Windows.Forms.DataGridView grdDocentes;
        private System.Windows.Forms.TextBox txtBuscarDocentes;
        private System.Windows.Forms.GroupBox grbEdicionDocentes;
        private System.Windows.Forms.Button btnEliminarDocentes;
        private System.Windows.Forms.Button btnModificarDocentes;
        private System.Windows.Forms.Button btnAgregarDocentes;
        private System.Windows.Forms.GroupBox grbNavegacionDocentes;
        private System.Windows.Forms.Label lblnRegistrosDocentes;
        private System.Windows.Forms.Button btnUltimoDocentes;
        private System.Windows.Forms.Button btnSiguienteDocentes;
        private System.Windows.Forms.Button btnAnteriorDocentes;
        private System.Windows.Forms.Button btnPrimeroDocentes;
        private System.Windows.Forms.GroupBox grbDatosDocentes;
        private System.Windows.Forms.Label idDocente;
        private System.Windows.Forms.TextBox txtTelefonoDocentes;
        private System.Windows.Forms.Label lblTelefonoDocentes;
        private System.Windows.Forms.Label lblIdlDocentes;
        private System.Windows.Forms.TextBox txtDireccionDocentes;
        private System.Windows.Forms.Label lblDireccionDocentes;
        private System.Windows.Forms.TextBox txtNombreDocentes;
        private System.Windows.Forms.Label lblNombreDocentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
    }
}