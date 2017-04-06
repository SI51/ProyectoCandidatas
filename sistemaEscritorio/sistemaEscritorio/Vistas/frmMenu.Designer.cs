namespace sistemaEscritorio.Vistas
{
    partial class frmMenu
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnMunicipios = new System.Windows.Forms.Button();
            this.btnCandidatas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Candidatas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Municipios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Usuarios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(708, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reportes";
            // 
            // btnReportes
            // 
            this.btnReportes.Image = global::sistemaEscritorio.Properties.Resources._1491505745_Artboard_1;
            this.btnReportes.Location = new System.Drawing.Point(711, 24);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(226, 263);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Image = global::sistemaEscritorio.Properties.Resources.usuarios;
            this.btnUsuarios.Location = new System.Drawing.Point(479, 24);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(226, 263);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnMunicipios
            // 
            this.btnMunicipios.Image = global::sistemaEscritorio.Properties.Resources.municipios;
            this.btnMunicipios.Location = new System.Drawing.Point(247, 24);
            this.btnMunicipios.Name = "btnMunicipios";
            this.btnMunicipios.Size = new System.Drawing.Size(226, 263);
            this.btnMunicipios.TabIndex = 0;
            this.btnMunicipios.UseVisualStyleBackColor = true;
            this.btnMunicipios.Click += new System.EventHandler(this.btnMunicipios_Click);
            // 
            // btnCandidatas
            // 
            this.btnCandidatas.Image = global::sistemaEscritorio.Properties.Resources.candidatas;
            this.btnCandidatas.Location = new System.Drawing.Point(15, 24);
            this.btnCandidatas.Name = "btnCandidatas";
            this.btnCandidatas.Size = new System.Drawing.Size(226, 263);
            this.btnCandidatas.TabIndex = 0;
            this.btnCandidatas.UseVisualStyleBackColor = true;
            this.btnCandidatas.Click += new System.EventHandler(this.btnCandidatas_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 321);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnMunicipios);
            this.Controls.Add(this.btnCandidatas);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCandidatas;
        private System.Windows.Forms.Button btnMunicipios;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Label label4;
    }
}