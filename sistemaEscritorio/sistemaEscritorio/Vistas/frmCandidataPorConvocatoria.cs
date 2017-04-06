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
using CrystalDecisions.CrystalReports.Engine;

namespace sistemaEscritorio.Reportes
{
    public partial class frmCandidataPorConvocatoria : Form
    {
        ReportDocument crpDocument;
        public void GenerarReporte()
        {
            crpDocument = new ReportDocument();
            crpDocument.Load(@"C:\Users\Luis-PC\Desktop\sistemaEscritorio\sistemaEscritorio\Reportes\CandidataPorConvocatoria.rpt");
            crpDocument.SetDataSource(CandidataManager.getAll());            
            this.crystalReportViewer1.ReportSource = crpDocument;
        }

        public frmCandidataPorConvocatoria()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            GenerarReporte();
        }
    }
}
