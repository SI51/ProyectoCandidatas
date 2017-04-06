namespace sistemaEscritorio.Vistas
{
    partial class frmActualizarUsuario
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
            this.btbAceptarAgregarUsuario = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtEmailAgregarUsuario = new System.Windows.Forms.TextBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Empleado";
            // 
            // btbAceptarAgregarUsuario
            // 
            this.btbAceptarAgregarUsuario.Image = global::sistemaEscritorio.Properties.Resources.btnSave;
            this.btbAceptarAgregarUsuario.Location = new System.Drawing.Point(138, 70);
            this.btbAceptarAgregarUsuario.Name = "btbAceptarAgregarUsuario";
            this.btbAceptarAgregarUsuario.Size = new System.Drawing.Size(95, 40);
            this.btbAceptarAgregarUsuario.TabIndex = 1;
            this.btbAceptarAgregarUsuario.Text = "Actualizar";
            this.btbAceptarAgregarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btbAceptarAgregarUsuario.UseVisualStyleBackColor = true;
            this.btbAceptarAgregarUsuario.Click += new System.EventHandler(this.btbAceptarAgregarUsuario_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::sistemaEscritorio.Properties.Resources.btnExit;
            this.btnCancelar.Location = new System.Drawing.Point(239, 70);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 40);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtEmailAgregarUsuario
            // 
            this.txtEmailAgregarUsuario.Location = new System.Drawing.Point(92, 22);
            this.txtEmailAgregarUsuario.Name = "txtEmailAgregarUsuario";
            this.txtEmailAgregarUsuario.Size = new System.Drawing.Size(237, 20);
            this.txtEmailAgregarUsuario.TabIndex = 0;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // frmActualizarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 125);
            this.Controls.Add(this.txtEmailAgregarUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btbAceptarAgregarUsuario);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(357, 164);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(357, 164);
            this.Name = "frmActualizarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Usuario";
            this.Load += new System.EventHandler(this.frmActualizarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btbAceptarAgregarUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtEmailAgregarUsuario;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}