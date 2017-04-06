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
    public partial class frmMenuReportes : Form
    {
        public frmMenuReportes()
        {
            InitializeComponent();
        }

        private void btnConvocadoria_Click(object sender, EventArgs e)
        {
            Reportes.frmCandidataPorConvocatoria s = new Reportes.frmCandidataPorConvocatoria();
            s.Show();
        }
    }
}
