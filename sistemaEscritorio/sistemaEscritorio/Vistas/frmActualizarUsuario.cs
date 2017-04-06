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
    public partial class frmActualizarUsuario : Form
    {
        frmBuscarUsuario m;
        public frmActualizarUsuario(frmBuscarUsuario n)
        {
            InitializeComponent();
        }

        private void frmActualizarUsuario_Load(object sender, EventArgs e)
        {
            Usuario nUsuario = UsuarioManager.getById(frmBuscarUsuario.PKUSU);
            txtEmailAgregarUsuario.Text = Convert.ToInt32(nUsuario.iEmpleadoUsuario).ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btbAceptarAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (this.txtEmailAgregarUsuario.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtEmailAgregarUsuario, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtEmailAgregarUsuario, "Campo necesario");
                this.txtEmailAgregarUsuario.Focus();
            }
            else
            {
                Usuario nusuario = new Usuario();
                nusuario.pkUsuario = frmBuscarUsuario.PKUSU;
                nusuario.iEmpleadoUsuario = Convert.ToInt32(txtEmailAgregarUsuario.Text);
                UsuarioManager.Modificar(nusuario);

                m.cargarUsuario();
                this.Close();
            }
        }
    }
}
