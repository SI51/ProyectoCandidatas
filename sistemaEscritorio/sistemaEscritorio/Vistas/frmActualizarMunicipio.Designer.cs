namespace sistemaEscritorio.Vistas
{
    partial class frmActualizarMunicipio
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreMunicipio = new System.Windows.Forms.TextBox();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Municipio";
            // 
            // txtNombreMunicipio
            // 
            this.txtNombreMunicipio.Location = new System.Drawing.Point(110, 17);
            this.txtNombreMunicipio.Name = "txtNombreMunicipio";
            this.txtNombreMunicipio.Size = new System.Drawing.Size(234, 20);
            this.txtNombreMunicipio.TabIndex = 0;
            this.txtNombreMunicipio.TextChanged += new System.EventHandler(this.txtNombreMunicipio_TextChanged);
            // 
            // pcbLogo
            // 
            this.pcbLogo.Location = new System.Drawing.Point(361, 17);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(123, 119);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 47;
            this.pcbLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(110, 43);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(234, 88);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Image = global::sistemaEscritorio.Properties.Resources.btnSave;
            this.btnRegistro.Location = new System.Drawing.Point(53, 142);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(93, 37);
            this.btnRegistro.TabIndex = 2;
            this.btnRegistro.Text = "Agregar";
            this.btnRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::sistemaEscritorio.Properties.Resources.btnExit;
            this.btnCancelar.Location = new System.Drawing.Point(251, 142);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 37);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::sistemaEscritorio.Properties.Resources.btnSearch;
            this.btnBuscar.Location = new System.Drawing.Point(152, 142);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 37);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Image = global::sistemaEscritorio.Properties.Resources.btnSearch;
            this.btnExaminar.Location = new System.Drawing.Point(361, 142);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(123, 37);
            this.btnExaminar.TabIndex = 5;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // frmActualizarMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 196);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombreMunicipio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(512, 235);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(512, 235);
            this.Name = "frmActualizarMunicipio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Municipio";
            this.Load += new System.EventHandler(this.frmActualizarMunicipio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreMunicipio;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}