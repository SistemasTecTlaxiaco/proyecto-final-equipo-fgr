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
    public partial class frmNuevoUsuario : Form {
        public frmNuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.Nombre = txtNombreR.Text;
            usuario.Usuario = txtUsuarioR.Text;
            usuario.Email = txtEmailR.Text;
            usuario.PalabraSeguridad = txtPalabraR.Text;
            usuario.Password = txtPasswordR.Text;
            usuario.ConPassword = txtPasswordCR.Text;

            try
            {
                Control control = new Control();
                string respuesta = control.ctrlRegistro(usuario);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario registrado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmRegistro form3 = new frmRegistro();
                    form3.Show();
                    this.Close();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
