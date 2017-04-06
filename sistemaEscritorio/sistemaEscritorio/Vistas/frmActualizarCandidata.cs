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
using sistemaEscritorio.Controlador;
using sistemaEscritorio.Comun;
using sistemaLibreria.Modelo;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;


namespace sistemaEscritorio.Vistas
{
    public partial class frmActualizarCandidata : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        public String ImagenString { get; set; }
        public Bitmap ImagenBitmap { get; set; }

        frmBuscarCandidata vMain;
        private frmBuscarCandidata frmBuscarCandidata;

        public frmActualizarCandidata(frmBuscarCandidata vmain)
        {
            InitializeComponent();
            vMain = vmain;
            vMain.cargarCandidatas();
        }
        public void cargarMunicipios()
        {
            int indexrol = 0;
            //llenar combo
            cmbMunicipio.DataSource = MunicipioManager.getAll(true);
            cmbMunicipio.DisplayMember = "sNombre";
            cmbMunicipio.ValueMember = "pkMunicipio";

            cmbMunicipio.SelectedIndex = indexrol;
        }

        private void frmActualizarCandidata_Load(object sender, EventArgs e)
        {
            this.cargarMunicipios();

            Candidata nCandidata = CandidataManager.getById(frmBuscarCandidata.PKCANDIDATA);
            txtNombreCompleto.Text = nCandidata.sNombreCompleto;
            txtDescripcion.Text = nCandidata.sDescripcion;
            txtCorreoElectronico.Text = nCandidata.sCorreoElectronico;
            txtCurp.Text = nCandidata.sCurp;
            txtNivelEstudios.Text = nCandidata.sNivelEstudios;

            picImagen.Image = ToolImagen.Base64StringToBitmap(nCandidata.sFotografiaRostro);

            dtpAñoConvocatoria.Value = nCandidata.dtAnioConvocatoria;
            dtpFechaNacimiento.Value = nCandidata.dtFechaNacimiento;

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

        private void btnRegistrar_Click(object sender, EventArgs e)
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
            else if (this.txtDescripcion.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtDescripcion, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtDescripcion, "Campo necesario");
                this.txtDescripcion.Focus();
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
            else
            {
                Candidata nCandidata = new Candidata();
                nCandidata.pkCandidata = frmBuscarCandidata.PKCANDIDATA;
                nCandidata.dtAnioConvocatoria = dtpAñoConvocatoria.Value;
                nCandidata.sNombreCompleto = txtNombreCompleto.Text;
                nCandidata.dtFechaNacimiento = dtpFechaNacimiento.Value;
                nCandidata.sDescripcion = txtDescripcion.Text;
                nCandidata.sCorreoElectronico = txtCorreoElectronico.Text;
                nCandidata.sCurp = txtCurp.Text;
                nCandidata.sNivelEstudios = txtNivelEstudios.Text;
                nCandidata.sFotografiaRostro = ImagenString;
                int fkMunicipio = Convert.ToInt32(cmbMunicipio.SelectedValue.ToString());
                int fkUsuario = 1;

                CandidataManager.Modificar(nCandidata);

                vMain.cargarCandidatas();

                this.Close();
            }
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
        private void videoSource_newFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ImagenBitmap = (Bitmap)eventArgs.Frame.Clone();
            ImagenString = ToolImagen.ToBase64String(ImagenBitmap, ImageFormat.Jpeg);
            picImagen.Image = ImagenBitmap;
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

        private void txtNombreCompleto_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtCorreoElectronico_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtCurp_TextChanged(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static bool ValidarEmail(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool ValidarCurp(string curp)
        {
            string expresion = "^.*(?=.{18})(?=.*[0-9])(?=.*[A-ZÑ]).*$";
            if (Regex.IsMatch(curp, expresion))
            {
                if (Regex.Replace(curp, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void txtCurp_Leave(object sender, EventArgs e)
        {
            if (ValidarCurp(txtCurp.Text))
            {

            }
            else
            {
                MessageBox.Show("Curp No Valida Debe de tener el formato : BOMC870421HDGRLS05, " +
                    "Favor Sellecione Un Curp Valido", "Validacion De Curp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCorreoElectronico.SelectAll();
                txtCorreoElectronico.Focus();
            }
        }

        private void txtCorreoElectronico_Leave(object sender, EventArgs e)
        {
            if (ValidarEmail(txtCorreoElectronico.Text))
            {

            }
            else
            {
                MessageBox.Show("Direccion De Correo Electronico No Valido Debe de tener el formato : correo@gmail.com, " +
                    "Favor Sellecione Un Correo Valido", "Validacion De Correo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCorreoElectronico.SelectAll();
                txtCorreoElectronico.Focus();
            }
        }
    }
}
