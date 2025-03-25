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
    public partial class frmConfiguracion : Form {
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void boxVolverInicio_Click(object sender, EventArgs e)
        {
            frmInicio form4 = new frmInicio();
            form4.Show();
            this.Close();
        }

        private void boxCerrarSesion_Click(object sender, EventArgs e)
        {
            frmLogin form5 = new frmLogin();
            form5.Show();
            this.Close();
        }
    }
}
