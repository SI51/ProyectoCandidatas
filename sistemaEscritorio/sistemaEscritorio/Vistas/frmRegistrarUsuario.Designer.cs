namespace sistemaEscritorio.Vistas
{
    partial class frmRegistrarUsuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailAgregarUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenaAgregarUsuario = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btbAceptarAgregarUsuario = new System.Windows.Forms.Button();
            this.btnCancelarAgregarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rol";
            // 
            // txtEmailAgregarUsuario
            // 
            this.txtEmailAgregarUsuario.Location = new System.Drawing.Point(91, 20);
            this.txtEmailAgregarUsuario.Name = "txtEmailAgregarUsuario";
            this.txtEmailAgregarUsuario.Size = new System.Drawing.Size(285, 20);
            this.txtEmailAgregarUsuario.TabIndex = 0;
            // 
            // txtContrasenaAgregarUsuario
            // 
            this.txtContrasenaAgregarUsuario.Location = new System.Drawing.Point(91, 46);
            this.txtContrasenaAgregarUsuario.Name = "txtContrasenaAgregarUsuario";
            this.txtContrasenaAgregarUsuario.Size = new System.Drawing.Size(285, 20);
            this.txtContrasenaAgregarUsuario.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(285, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Image = global::sistemaEscritorio.Properties.Resources.btnSearch;
            this.button1.Location = new System.Drawing.Point(91, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btbAceptarAgregarUsuario
            // 
            this.btbAceptarAgregarUsuario.Image = global::sistemaEscritorio.Properties.Resources.btnSave;
            this.btbAceptarAgregarUsuario.Location = new System.Drawing.Point(190, 111);
            this.btbAceptarAgregarUsuario.Name = "btbAceptarAgregarUsuario";
            this.btbAceptarAgregarUsuario.Size = new System.Drawing.Size(91, 42);
            this.btbAceptarAgregarUsuario.TabIndex = 4;
            this.btbAceptarAgregarUsuario.Text = "Agregar";
            this.btbAceptarAgregarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btbAceptarAgregarUsuario.UseVisualStyleBackColor = true;
            this.btbAceptarAgregarUsuario.Click += new System.EventHandler(this.btbAceptarAgregarUsuario_Click);
            // 
            // btnCancelarAgregarUsuario
            // 
            this.btnCancelarAgregarUsuario.Image = global::sistemaEscritorio.Properties.Resources.btnExit;
            this.btnCancelarAgregarUsuario.Location = new System.Drawing.Point(287, 111);
            this.btnCancelarAgregarUsuario.Name = "btnCancelarAgregarUsuario";
            this.btnCancelarAgregarUsuario.Size = new System.Drawing.Size(91, 42);
            this.btnCancelarAgregarUsuario.TabIndex = 5;
            this.btnCancelarAgregarUsuario.Text = "Cancelar";
            this.btnCancelarAgregarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelarAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnCancelarAgregarUsuario.Click += new System.EventHandler(this.btnCancelarAgregarUsuario_Click);
            // 
            // frmRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 167);
            this.Controls.Add(this.btnCancelarAgregarUsuario);
            this.Controls.Add(this.btbAceptarAgregarUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtContrasenaAgregarUsuario);
            this.Controls.Add(this.txtEmailAgregarUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(404, 206);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(404, 206);
            this.Name = "frmRegistrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Usuarios";
            this.Load += new System.EventHandler(this.frmRegistrarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailAgregarUsuario;
        private System.Windows.Forms.TextBox txtContrasenaAgregarUsuario;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btbAceptarAgregarUsuario;
        private System.Windows.Forms.Button btnCancelarAgregarUsuario;
    }
}