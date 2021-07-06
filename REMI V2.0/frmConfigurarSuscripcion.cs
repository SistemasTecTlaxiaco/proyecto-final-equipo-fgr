using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMI_V2._0 {
    public partial class frmConfigurarSuscripcion : Form {
        public frmConfigurarSuscripcion()
        {
            InitializeComponent();
        }
        
        private void boxImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes|*.jpg; *.png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionar.Title = "Seleccionar Imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK) {
                boxImagen.Image = Image.FromFile(ofdSeleccionar.FileName);
            }
        }

        private void btnGuardarSuscripcion_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            boxImagen.Image.Save(ms, ImageFormat.Png);
            
            
            Suscripciones suscripcion = new Suscripciones();
            suscripcion.NombreSuscripcion = txtNombreApp.Text;
            suscripcion.Descripcion = txtDescripcion.Text;
            suscripcion.PrimerFactura = txtFecha.Text;
            suscripcion.Ciclo = ((int)numMes.Value);
            suscripcion.Precio = ((int)numPrecio.Value);
            suscripcion.Recordar = ((int)numDia.Value);
            suscripcion.Moneda = txtMoneda.Text;
            suscripcion.Imagen = ms.ToArray();

            try
            {
                Control ctrl = new Control();
                string repuesta = ctrl.ctrlSuscripcion(suscripcion);
                if (repuesta.Length > 0)
                {
                    MessageBox.Show(repuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Suscripcion agregada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmInicioConSuscripciones form8 = new frmInicioConSuscripciones();
                    form8.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK);
            }
        }

        private void boxVolverInicio_Click(object sender, EventArgs e)
        {
            frmInicio form9 = new frmInicio();
            form9.Show();
            this.Close();
        }
    }
}
