using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemaEscritorio.Controlador;
using sistemaLibreria.Modelo;

namespace sistemaEscritorio.Vistas
{
    public partial class frmBuscarUsuario : Form
    {
        public static int PKUSU;
        public void cargarUsuario()
        {
            List<Usuario> nLista = new List<Usuario>();
            foreach (var item in UsuarioManager.BuscarporIDLi(chkStatus.Checked))
            {
                nLista.Add(item);
            }
            this.dtgDatos.DataSource = nLista;
        }

        public frmBuscarUsuario()
        {
            InitializeComponent();
            this.dtgDatos.AutoGenerateColumns = false;
            chkStatus.Checked = true;
        }

        private void frmBuscarUsuario_Load(object sender, EventArgs e)
        {
            this.cargarUsuario();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.dtgDatos.RowCount >= 1)
            {
                PKUSU = Convert.ToInt32(this.dtgDatos.CurrentRow.Cells[0].Value);

                frmActualizarUsuario frm = new frmActualizarUsuario(this);
                frm.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.dtgDatos.RowCount >= 1)
            {
                if (MessageBox.Show("Realmente quiere elimar este registro?", "Aviso...!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    UsuarioManager.Eliminar(Convert.ToInt32(this.dtgDatos.CurrentRow.Cells[0].Value));
                    this.cargarUsuario();
                }
            }
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            lblRegistros.Text = "Registros: " + this.dtgDatos.Rows.Count;
        }

        private void ckbStatus_CheckedChanged(object sender, EventArgs e)
        {
            this.cargarUsuario();
        }
    }
}
