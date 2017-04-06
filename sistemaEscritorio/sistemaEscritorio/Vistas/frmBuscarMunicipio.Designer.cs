namespace sistemaEscritorio.Vistas
{
    partial class frmBuscarMunicipio
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
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvMunicipios = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMunicipios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Municipio";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(106, 21);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(466, 20);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkStatus.Location = new System.Drawing.Point(516, 237);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(56, 17);
            this.chkStatus.TabIndex = 3;
            this.chkStatus.Text = "Status";
            this.chkStatus.UseVisualStyleBackColor = true;
            this.chkStatus.CheckedChanged += new System.EventHandler(this.ckbStatus_CheckedChanged);
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(12, 234);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(51, 13);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "Registros";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::sistemaEscritorio.Properties.Resources.btnDelete;
            this.btnBorrar.Location = new System.Drawing.Point(281, 273);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(93, 41);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::sistemaEscritorio.Properties.Resources.btnUpdate;
            this.btnActualizar.Location = new System.Drawing.Point(380, 273);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(93, 41);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::sistemaEscritorio.Properties.Resources.btnExit;
            this.btnSalir.Location = new System.Drawing.Point(479, 271);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 41);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvMunicipios
            // 
            this.dgvMunicipios.AllowUserToAddRows = false;
            this.dgvMunicipios.AllowUserToDeleteRows = false;
            this.dgvMunicipios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMunicipios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.sNombre,
            this.sDescripcion});
            this.dgvMunicipios.Location = new System.Drawing.Point(12, 47);
            this.dgvMunicipios.Name = "dgvMunicipios";
            this.dgvMunicipios.ReadOnly = true;
            this.dgvMunicipios.RowHeadersVisible = false;
            this.dgvMunicipios.Size = new System.Drawing.Size(560, 184);
            this.dgvMunicipios.TabIndex = 2;
            this.dgvMunicipios.DataSourceChanged += new System.EventHandler(this.dgvMunicipios_DataSourceChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "pkMunicipio";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // sNombre
            // 
            this.sNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sNombre.DataPropertyName = "sNombre";
            this.sNombre.HeaderText = "Nombre";
            this.sNombre.Name = "sNombre";
            this.sNombre.ReadOnly = true;
            // 
            // sDescripcion
            // 
            this.sDescripcion.DataPropertyName = "sDescripcion";
            this.sDescripcion.HeaderText = "Descripcion";
            this.sDescripcion.Name = "sDescripcion";
            this.sDescripcion.ReadOnly = true;
            // 
            // frmBuscarMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 326);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.dgvMunicipios);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.label1);
            this.Name = "frmBuscarMunicipio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Municipios";
            this.Load += new System.EventHandler(this.frmBuscarMunicipio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMunicipios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvMunicipios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDescripcion;
    }
}