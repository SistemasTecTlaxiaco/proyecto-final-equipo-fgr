using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMI_V2._0 {
    public partial class frmInicioConSuscripciones : Form {
        public frmInicioConSuscripciones()
        {
            InitializeComponent();
        }

        private void frmInicioConSuscripciones_Load(object sender, EventArgs e)
        {
            Modelo modelo = new Modelo();
            modelo.cargarImagen(boxSus, lblNombre, lblPrecio);
        }

        private void boxConfiguracion_Click(object sender, EventArgs e)
        {
            frmConfiguracion form = new frmConfiguracion();
            form.Show();
            this.Close();
        }
    }
}
