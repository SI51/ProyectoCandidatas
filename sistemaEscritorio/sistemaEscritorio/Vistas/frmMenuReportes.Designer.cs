namespace sistemaEscritorio.Vistas
{
    partial class frmMenuReportes
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
            this.btnConvocadoria = new System.Windows.Forms.Button();
            this.btnPorMunicipios = new System.Windows.Forms.Button();
            this.btnGanadorasPorMunicipio = new System.Windows.Forms.Button();
            this.btnCapturadas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConvocadoria
            // 
            this.btnConvocadoria.Location = new System.Drawing.Point(12, 12);
            this.btnConvocadoria.Name = "btnConvocadoria";
            this.btnConvocadoria.Size = new System.Drawing.Size(144, 81);
            this.btnConvocadoria.TabIndex = 0;
            this.btnConvocadoria.Text = "Candidatas por convocatoria";
            this.btnConvocadoria.UseVisualStyleBackColor = true;
            this.btnConvocadoria.Click += new System.EventHandler(this.btnConvocadoria_Click);
            // 
            // btnPorMunicipios
            // 
            this.btnPorMunicipios.Location = new System.Drawing.Point(162, 12);
            this.btnPorMunicipios.Name = "btnPorMunicipios";
            this.btnPorMunicipios.Size = new System.Drawing.Size(144, 81);
            this.btnPorMunicipios.TabIndex = 1;
            this.btnPorMunicipios.Text = "Candidatas por municipios";
            this.btnPorMunicipios.UseVisualStyleBackColor = true;
            // 
            // btnGanadorasPorMunicipio
            // 
            this.btnGanadorasPorMunicipio.Location = new System.Drawing.Point(12, 99);
            this.btnGanadorasPorMunicipio.Name = "btnGanadorasPorMunicipio";
            this.btnGanadorasPorMunicipio.Size = new System.Drawing.Size(144, 81);
            this.btnGanadorasPorMunicipio.TabIndex = 2;
            this.btnGanadorasPorMunicipio.Text = "Ganadoras por municipio";
            this.btnGanadorasPorMunicipio.UseVisualStyleBackColor = true;
            // 
            // btnCapturadas
            // 
            this.btnCapturadas.Location = new System.Drawing.Point(162, 99);
            this.btnCapturadas.Name = "btnCapturadas";
            this.btnCapturadas.Size = new System.Drawing.Size(144, 81);
            this.btnCapturadas.TabIndex = 3;
            this.btnCapturadas.Text = "Capturadas por capturista";
            this.btnCapturadas.UseVisualStyleBackColor = true;
            // 
            // frmMenuReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 191);
            this.Controls.Add(this.btnCapturadas);
            this.Controls.Add(this.btnGanadorasPorMunicipio);
            this.Controls.Add(this.btnPorMunicipios);
            this.Controls.Add(this.btnConvocadoria);
            this.Name = "frmMenuReportes";
            this.Text = "Menu Reportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConvocadoria;
        private System.Windows.Forms.Button btnPorMunicipios;
        private System.Windows.Forms.Button btnGanadorasPorMunicipio;
        private System.Windows.Forms.Button btnCapturadas;
    }
}