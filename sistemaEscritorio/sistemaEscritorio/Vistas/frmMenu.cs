using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaEscritorio.Vistas
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCandidatas_Click(object sender, EventArgs e)
        {
            Vistas.frmRegistroCandidata verCandidatas = new frmRegistroCandidata();
            verCandidatas.ShowDialog();
        }

        private void btnMunicipios_Click(object sender, EventArgs e)
        {
            Vistas.frmRegistroMunicipio verMunicipio = new frmRegistroMunicipio();
            verMunicipio.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Vistas.frmRegistrarUsuario verUsuarios = new frmRegistrarUsuario();
            verUsuarios.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Vistas.frmMenuReportes verReportes = new frmMenuReportes();
            verReportes.Show();
        }
    }
}
