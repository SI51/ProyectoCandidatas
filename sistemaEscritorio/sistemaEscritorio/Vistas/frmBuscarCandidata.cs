using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemaLibreria.Modelo;
using sistemaEscritorio.Controlador;


namespace sistemaEscritorio.Vistas
{
    public partial class frmBuscarCandidata : Form
    {
        public static int PKCANDIDATA;
        public frmBuscarCandidata()
        {
            InitializeComponent();
            this.dtgDatos.AutoGenerateColumns = false;
            chkStatus.Checked = true;
        }
        public void cargarCandidatas()
        {
            this.dtgDatos.DataSource = CandidataManager.Buscar(txtBuscar.Text, chkStatus.Checked);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBuscarCandidata_Load(object sender, EventArgs e)
        {
            this.cargarCandidatas();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.dtgDatos.RowCount >= 1)
            {
                PKCANDIDATA = Convert.ToInt32(this.dtgDatos.CurrentRow.Cells[0].Value);
                frmActualizarCandidata v = new frmActualizarCandidata(this);
                v.ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dtgDatos.RowCount >= 1)
            {
                if (MessageBox.Show("Realmente quiere elimar este registro?", "Aviso...!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CandidataManager.Eliminar(Convert.ToInt32(this.dtgDatos.CurrentRow.Cells[0].Value));
                    this.cargarCandidatas();
                }
            }
        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {
            this.cargarCandidatas();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.cargarCandidatas();
        }

        private void dtgDatos_DataSourceChanged(object sender, EventArgs e)
        {
            lblRegistros.Text = "Registros: " + this.dtgDatos.Rows.Count;
        }
    }
}
