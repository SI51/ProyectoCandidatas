namespace sistemaEscritorio.Vistas
{
    partial class frmBuscarUsuario
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
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.pkUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iEmpleadoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDatos
            // 
            this.dtgDatos.AllowUserToAddRows = false;
            this.dtgDatos.AllowUserToDeleteRows = false;
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkUsuario,
            this.iEmpleadoUsuario});
            this.dtgDatos.Location = new System.Drawing.Point(13, 15);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.ReadOnly = true;
            this.dtgDatos.RowHeadersVisible = false;
            this.dtgDatos.Size = new System.Drawing.Size(312, 150);
            this.dtgDatos.TabIndex = 0;
            this.dtgDatos.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            // 
            // pkUsuario
            // 
            this.pkUsuario.DataPropertyName = "pkUsuario";
            this.pkUsuario.HeaderText = "ID";
            this.pkUsuario.Name = "pkUsuario";
            this.pkUsuario.ReadOnly = true;
            // 
            // iEmpleadoUsuario
            // 
            this.iEmpleadoUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iEmpleadoUsuario.DataPropertyName = "iEmpleadoUsuario";
            this.iEmpleadoUsuario.HeaderText = "No. Empleado";
            this.iEmpleadoUsuario.Name = "iEmpleadoUsuario";
            this.iEmpleadoUsuario.ReadOnly = true;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkStatus.Location = new System.Drawing.Point(269, 171);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(56, 17);
            this.chkStatus.TabIndex = 0;
            this.chkStatus.Text = "Status";
            this.chkStatus.UseVisualStyleBackColor = true;
            this.chkStatus.CheckedChanged += new System.EventHandler(this.ckbStatus_CheckedChanged);
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Location = new System.Drawing.Point(12, 168);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(51, 13);
            this.lblRegistros.TabIndex = 2;
            this.lblRegistros.Text = "Registros";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::sistemaEscritorio.Properties.Resources.btnUpdate;
            this.btnActualizar.Location = new System.Drawing.Point(136, 213);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(94, 38);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::sistemaEscritorio.Properties.Resources.btnExit;
            this.btnSalir.Location = new System.Drawing.Point(236, 213);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 38);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::sistemaEscritorio.Properties.Resources.btnDelete;
            this.btnBorrar.Location = new System.Drawing.Point(38, 213);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(92, 38);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 261);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.dtgDatos);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(358, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(358, 300);
            this.Name = "frmBuscarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmBuscarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn iEmpleadoUsuario;
    }
}