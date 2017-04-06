using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using sistemaEscritorio.Controlador;
using sistemaEscritorio.Comun;
using sistemaLibreria.Modelo;

namespace sistemaEscritorio.Vistas
{
    public partial class frmActualizarMunicipio : Form
    {
        frmBuscarMunicipio vMain;
        public String ImagenString { get; set; }
        public Bitmap ImagenBitmap { get; set; }

        private frmBuscarMunicipio frmBuscarMunicipio;

        public frmActualizarMunicipio(frmBuscarMunicipio vmain)
        {
            InitializeComponent();
            vMain = vmain;
            vMain.cargarMunicipios();
        }

        private void frmActualizarMunicipio_Load(object sender, EventArgs e)
        {
            Municipio nMunicipio = MunicipioManager.getById(frmBuscarMunicipio.PKMUNICIPIO);
            txtNombreMunicipio.Text = nMunicipio.sNombre;
            txtDescripcion.Text = nMunicipio.sDescripcion;           
            pcbLogo.Image = ToolImagen.Base64StringToBitmap(nMunicipio.sLogotipo);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (this.txtNombreMunicipio.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtNombreMunicipio, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtNombreMunicipio, "Campo necesario");
                this.txtNombreMunicipio.Focus();
            }
            else if (this.txtDescripcion.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtDescripcion, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtDescripcion, "Campo necesario");
                this.txtDescripcion.Focus();
            }
            else
            {
                Municipio nMunicipio = new Municipio();
                nMunicipio.pkMunicipio = frmBuscarMunicipio.PKMUNICIPIO;
                nMunicipio.sNombre = txtNombreMunicipio.Text;
                nMunicipio.sDescripcion = txtDescripcion.Text;
                nMunicipio.sLogotipo = ImagenString;
                MunicipioManager.Modificar(nMunicipio);

                vMain.cargarMunicipios();

                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog BuscarImagen = new OpenFileDialog();
                BuscarImagen.Filter = "Archivos de Imagen|*.jpg;*.png;*gif;*.bmp";
                //Aquí incluiremos los filtros que queramos.
                BuscarImagen.FileName = "";
                BuscarImagen.Title = "Seleccione una imagen";
                if (BuscarImagen.ShowDialog() == DialogResult.OK)
                {
                    string logo = BuscarImagen.FileName;
                    this.pcbLogo.ImageLocation = logo;
                    ImagenBitmap = new System.Drawing.Bitmap(logo);
                    ImagenString = ToolImagen.ToBase64String(ImagenBitmap, ImageFormat.Jpeg);
                    pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido" + ex.Message);
            }
        }

        private void txtNombreMunicipio_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }
    }
}
