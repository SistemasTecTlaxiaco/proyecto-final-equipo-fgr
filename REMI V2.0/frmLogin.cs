using MySql.Data.MySqlClient;
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
    public partial class frmLogin : Form {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void labelRegistro_Click(object sender, EventArgs e)
        {
            frmNuevoUsuario form2 = new frmNuevoUsuario();
            form2.Show();
            this.Close();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioEmail.Text;
            string email = txtUsuarioEmail.Text;
            string password = txtPassword.Text;

            try
            {
                Control ctrl = new Control();
                string repuesta = ctrl.ctrlLogin(usuario, password);
                if (repuesta.Length > 0)
                {
                    MessageBox.Show(repuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MySqlDataReader reader;
                    MySqlConnection conexion = Conexion.getConexion();
                    conexion.Open();
                    string sql = "SELECT * FROM suscripciones";
                              
                    MySqlCommand comando = new MySqlCommand(sql, conexion);
                    reader = comando.ExecuteReader();

                    if (reader.HasRows){
                            frmInicioConSuscripciones form5 = new frmInicioConSuscripciones();
                            form5.Show();
                            this.Close();
                    }else { 
                            frmInicio form4 = new frmInicio();
                            form4.Show();
                            this.Close();
                    }
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK);   
            }
         
        }
    }
}
