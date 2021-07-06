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
    public partial class frmInicio : Form {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void boxConfiguracion_Click(object sender, EventArgs e)
        {
            frmConfiguracion form5 = new frmConfiguracion();
            form5.Show();
            this.Close();
        }

        private void boxAgregar_Click(object sender, EventArgs e)
        {
            frmSuscripciones form7 = new frmSuscripciones();
            form7.Show();
            this.Close();
        }
    }
}
