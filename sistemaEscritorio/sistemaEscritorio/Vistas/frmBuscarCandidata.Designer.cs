namespace sistemaEscritorio.Vistas
{
    partial class frmBuscarCandidata
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.dtAnioConvocatoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCorreoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCurp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNivelEstudios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Candidata ";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(112, 14);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(788, 20);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dtgDatos
            // 
            this.dtgDatos.AllowUserToAddRows = false;
            this.dtgDatos.AllowUserToDeleteRows = false;
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtAnioConvocatoria,
            this.sNombreCompleto,
            this.dtFechaNacimiento,
            this.sDescripcion,
            this.sCorreoElectronico,
            this.sCurp,
            this.sNivelEstudios});
            this.dtgDatos.Location = new System.Drawing.Point(15, 40);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.ReadOnly = true;
            this.dtgDatos.Size = new System.Drawing.Size(888, 229);
            this.dtgDatos.TabIndex = 2;
            this.dtgDatos.DataSourceChanged += new System.EventHandler(this.dtgDatos_DataSourceChanged);
            // 
            // dtAnioConvocatoria
            // 
            this.dtAnioConvocatoria.DataPropertyName = "dtAnioConvocatoria";
            this.dtAnioConvocatoria.HeaderText = "Convocatoria";
            this.dtAnioConvocatoria.Name = "dtAnioConvocatoria";
            this.dtAnioConvocatoria.ReadOnly = true;
            // 
            // sNombreCompleto
            // 
            this.sNombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sNombreCompleto.DataPropertyName = "sNombreCompleto";
            this.sNombreCompleto.HeaderText = "Nombre";
            this.sNombreCompleto.Name = "sNombreCompleto";
            this.sNombreCompleto.ReadOnly = true;
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.DataPropertyName = "dtFechaNacimiento";
            this.dtFechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.ReadOnly = true;
            // 
            // sDescripcion
            // 
            this.sDescripcion.DataPropertyName = "sDescripcion";
            this.sDescripcion.HeaderText = "Descripcion";
            this.sDescripcion.Name = "sDescripcion";
            this.sDescripcion.ReadOnly = true;
            // 
            // sCorreoElectronico
            // 
            this.sCorreoElectronico.DataPropertyName = "sCorreoElectronico";
            this.sCorreoElectronico.HeaderText = "Correo";
            this.sCorreoElectronico.Name = "sCorreoElectronico";
            this.sCorreoElectronico.ReadOnly = true;
            // 
            // sCurp
            // 
            this.sCurp.DataPropertyName = "sCurp";
            this.sCurp.HeaderText = "Curp";
            this.sCurp.Name = "sCurp";
            this.sCurp.ReadOnly = true;
            // 
            // sNivelEstudios
            // 
            this.sNivelEstudios.DataPropertyName = "sNivelEstudios";
            this.sNivelEstudios.HeaderText = "Nivel Estudios";
            this.sNivelEstudios.Name = "sNivelEstudios";
            this.sNivelEstudios.ReadOnly = true;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(847, 275);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(56, 17);
            this.chkStatus.TabIndex = 3;
            this.chkStatus.Text = "Status";
            this.chkStatus.UseVisualStyleBackColor = true;
            this.chkStatus.CheckedChanged += new System.EventHandler(this.chkStatus_CheckedChanged);
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Location = new System.Drawing.Point(12, 272);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(51, 13);
            this.lblRegistros.TabIndex = 0;
            this.lblRegistros.Text = "Registros";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::sistemaEscritorio.Properties.Resources.btnDelete;
            this.btnEliminar.Location = new System.Drawing.Point(591, 312);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 40);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::sistemaEscritorio.Properties.Resources.btnUpdate;
            this.btnActualizar.Location = new System.Drawing.Point(697, 312);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 40);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::sistemaEscritorio.Properties.Resources.btnExit;
            this.btnSalir.Location = new System.Drawing.Point(803, 312);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 40);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmBuscarCandidata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 367);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.dtgDatos);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(931, 406);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(931, 406);
            this.Name = "frmBuscarCandidata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Candidatas";
            this.Load += new System.EventHandler(this.frmBuscarCandidata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtAnioConvocatoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCorreoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCurp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNivelEstudios;
    }
}