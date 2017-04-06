namespace sistemaEscritorio.Vistas
{
    partial class frmRegistroCandidata
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
            this.components = new System.ComponentModel.Container();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.txtNivelEstudios = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpAñoConvocatoria = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbMunicipio = new System.Windows.Forms.ComboBox();
            this.btnTomarFoto = new System.Windows.Forms.Button();
            this.cmbCamara = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Correo Electronico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Año Convocatoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "CURP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nivel Estudios";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Municipio";
            // 
            // picImagen
            // 
            this.picImagen.Location = new System.Drawing.Point(422, 12);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(150, 168);
            this.picImagen.TabIndex = 82;
            this.picImagen.TabStop = false;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(112, 12);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(293, 20);
            this.txtNombreCompleto.TabIndex = 0;
            this.txtNombreCompleto.TextChanged += new System.EventHandler(this.txtNombreCompleto_TextChanged);
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(112, 64);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(293, 20);
            this.txtCorreoElectronico.TabIndex = 2;
            this.txtCorreoElectronico.TextChanged += new System.EventHandler(this.txtCorreoElectronico_TextChanged);
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(112, 116);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(293, 20);
            this.txtCurp.TabIndex = 4;
            this.txtCurp.TextChanged += new System.EventHandler(this.txtCurp_TextChanged);
            // 
            // txtNivelEstudios
            // 
            this.txtNivelEstudios.Location = new System.Drawing.Point(112, 142);
            this.txtNivelEstudios.Name = "txtNivelEstudios";
            this.txtNivelEstudios.Size = new System.Drawing.Size(293, 20);
            this.txtNivelEstudios.TabIndex = 5;
            this.txtNivelEstudios.TextChanged += new System.EventHandler(this.txtNivelEstudios_TextChanged);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(112, 38);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(293, 20);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // dtpAñoConvocatoria
            // 
            this.dtpAñoConvocatoria.Location = new System.Drawing.Point(112, 90);
            this.dtpAñoConvocatoria.Name = "dtpAñoConvocatoria";
            this.dtpAñoConvocatoria.Size = new System.Drawing.Size(293, 20);
            this.dtpAñoConvocatoria.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(112, 195);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(293, 53);
            this.txtDescripcion.TabIndex = 7;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // cmbMunicipio
            // 
            this.cmbMunicipio.FormattingEnabled = true;
            this.cmbMunicipio.Location = new System.Drawing.Point(112, 168);
            this.cmbMunicipio.Name = "cmbMunicipio";
            this.cmbMunicipio.Size = new System.Drawing.Size(293, 21);
            this.cmbMunicipio.TabIndex = 6;
            // 
            // btnTomarFoto
            // 
            this.btnTomarFoto.Image = global::sistemaEscritorio.Properties.Resources.btnPhoto;
            this.btnTomarFoto.Location = new System.Drawing.Point(422, 186);
            this.btnTomarFoto.Name = "btnTomarFoto";
            this.btnTomarFoto.Size = new System.Drawing.Size(150, 36);
            this.btnTomarFoto.TabIndex = 10;
            this.btnTomarFoto.Text = "Tomar foto";
            this.btnTomarFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTomarFoto.UseVisualStyleBackColor = true;
            this.btnTomarFoto.Click += new System.EventHandler(this.btnTomarFoto_Click);
            // 
            // cmbCamara
            // 
            this.cmbCamara.FormattingEnabled = true;
            this.cmbCamara.Location = new System.Drawing.Point(422, 228);
            this.cmbCamara.Name = "cmbCamara";
            this.cmbCamara.Size = new System.Drawing.Size(150, 21);
            this.cmbCamara.TabIndex = 11;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::sistemaEscritorio.Properties.Resources.btnSearch;
            this.btnBuscar.Location = new System.Drawing.Point(215, 255);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 37);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::sistemaEscritorio.Properties.Resources.btnSave;
            this.btnAgregar.Location = new System.Drawing.Point(117, 254);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 37);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::sistemaEscritorio.Properties.Resources.btnExit;
            this.btnCancelar.Location = new System.Drawing.Point(313, 255);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 37);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmRegistroCandidata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 305);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbCamara);
            this.Controls.Add(this.btnTomarFoto);
            this.Controls.Add(this.cmbMunicipio);
            this.Controls.Add(this.dtpAñoConvocatoria);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNivelEstudios);
            this.Controls.Add(this.txtCurp);
            this.Controls.Add(this.txtCorreoElectronico);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 344);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 344);
            this.Name = "frmRegistroCandidata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Candidatas";
            this.Load += new System.EventHandler(this.frmRegistroCandidata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.DateTimePicker dtpAñoConvocatoria;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtNivelEstudios;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMunicipio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbCamara;
        private System.Windows.Forms.Button btnTomarFoto;
    }
}