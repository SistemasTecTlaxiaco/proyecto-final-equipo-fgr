using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMI_V2._0 {
    public partial class frmSuscripciones : Form {
        public frmSuscripciones()
        {
            InitializeComponent();
        }

        private void boxVolverInicio_Click(object sender, EventArgs e)
        {
            frmInicio form6 = new frmInicio();
            form6.Show();
            this.Close();
        }

        private void boxAgregarNuevo_Click(object sender, EventArgs e)
        {
            frmConfigurarSuscripcion form7 = new frmConfigurarSuscripcion();
            form7.Show();
            this.Close();
        }
    }
}
