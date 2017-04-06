using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using sistemaEscritorio.Controlador;
using sistemaLibreria.Modelo;
using sistemaEscritorio.Comun;

namespace sistemaEscritorio.Vistas
{
    public partial class frmRegistroCandidata : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public String ImagenString { get; set; }
        public Bitmap ImagenBitmap { get; set; }
        int indexrol;
        public frmRegistroCandidata()
        {
            InitializeComponent();
        }

        private void frmRegistroCandidata_Load(object sender, EventArgs e)
        {
            this.cargarMunicipios();

            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo device in videoDevices)
            {
                cmbCamara.Items.Add(device.Name);
            }
            if (cmbCamara.Items.Count > 0)
            {
                cmbCamara.SelectedIndex = 0;
                videoSource = new VideoCaptureDevice();
            }
            else
            {
                //lblError.Visible = true;
                btnTomarFoto.Enabled = false;
            }
        }

        public void cargarMunicipios()
        {
            //llenar combo
            cmbMunicipio.DataSource = MunicipioManager.getAll(true);
            cmbMunicipio.DisplayMember = "sNombre";
            cmbMunicipio.ValueMember = "pkMunicipio";
            try
            {
                cmbMunicipio.SelectedIndex = indexrol;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Vistas.frmBuscarCandidata v = new Vistas.frmBuscarCandidata();
            v.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.txtNombreCompleto.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtNombreCompleto, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtNombreCompleto, "Campo necesario");
                this.txtNombreCompleto.Focus();
            }
            else if (this.txtCurp.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtCurp, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtCurp, "Campo necesario");
                this.txtCurp.Focus();
            }
            else if (this.txtCorreoElectronico.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtCorreoElectronico, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtCorreoElectronico, "Campo necesario");
                this.txtCorreoElectronico.Focus();
            }
            else if (this.txtNivelEstudios.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtNivelEstudios, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtNivelEstudios, "Campo necesario");
                this.txtNivelEstudios.Focus();
            }
            else if (this.txtDescripcion.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtDescripcion, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtDescripcion, "Campo necesario");
                this.txtDescripcion.Focus();
            }
            else
            {
                Candidata nCandidata = new Candidata();

                nCandidata.dtAnioConvocatoria = dtpAñoConvocatoria.Value.Date;
                nCandidata.sNombreCompleto = txtNombreCompleto.Text;
                nCandidata.dtFechaNacimiento = dtpFechaNacimiento.Value.Date;
                nCandidata.sDescripcion = txtDescripcion.Text;
                nCandidata.sCorreoElectronico = txtCorreoElectronico.Text;
                nCandidata.sCurp = txtCurp.Text;
                nCandidata.sNivelEstudios = txtNivelEstudios.Text;
                nCandidata.sFotografiaRostro = ImagenString;
                int fkMunicipio = Convert.ToInt32(cmbMunicipio.SelectedValue.ToString());
                int fkUsuario = 1;
                CandidataManager.Guardar(nCandidata, fkMunicipio, fkUsuario);

                MessageBox.Show("!Candidata Registrada¡");
                txtCorreoElectronico.Clear();
                txtCurp.Clear();
                txtDescripcion.Clear();
                txtNivelEstudios.Clear();
                txtNombreCompleto.Clear();
                txtNombreCompleto.Focus();
                picImagen.Image = null;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombreCompleto_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtCurp_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtCorreoElectronico_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtNivelEstudios_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void videoSource_newFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ImagenBitmap = (Bitmap)eventArgs.Frame.Clone();
            ImagenString = ToolImagen.ToBase64String(ImagenBitmap, ImageFormat.Jpeg);
            picImagen.Image = ImagenBitmap;
        }

        private void btnTomarFoto_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
                //this.picImagen.Image = null;
                this.picImagen.Image = ImagenBitmap;
                picImagen.Invalidate();
            }
            else
            {
                videoSource = new VideoCaptureDevice(videoDevices[cmbCamara.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_newFrame);
                videoSource.Start();
            }
        }
        public void FinalizarControles()
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
            }
        }
        public void PonerFotografia(String pathImagen)
        {
            ImagenBitmap = new System.Drawing.Bitmap(pathImagen);
            ImagenString = ToolImagen.ToBase64String(ImagenBitmap, ImageFormat.Jpeg);
            picImagen.Image = ImagenBitmap;
        }
    }
}
