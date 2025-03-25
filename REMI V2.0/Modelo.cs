using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMI_V2._0 {
    class Modelo {

        public int registro(Usuarios usuario) {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();
            string sql = "INSERT INTO usuarios(nombre, usuario, email, palabraSeguridad, contraseña) " +
                "VALUES(@nombre, @usuario, @email, @palabraSeguridad, @contraseña)";
            
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("@email", usuario.Email);
            comando.Parameters.AddWithValue("@palabraSeguridad", usuario.PalabraSeguridad);
            comando.Parameters.AddWithValue("@contraseña", usuario.Password);
            
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public bool existeUsuario(string usuario) {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT idUsuario FROM usuarios WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }

        public Usuarios porUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT idUsuario, nombre, contraseña FROM usuarios WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            Usuarios user = null;

            while (reader.Read())
            {
                user = new Usuarios();
                user.IdUsuario = int.Parse(reader["idUsuario"].ToString());
                user.Nombre = (reader["nombre"].ToString());
                user.Password = (reader["contraseña"].ToString());

            }
            return user;
        }
        
        public Usuarios porEmail(string email)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT idUsuario, email, contraseña FROM usuarios WHERE email LIKE @email";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@email", email);

            reader = comando.ExecuteReader();

            Usuarios user = null;

            while (reader.Read())
            {
                user = new Usuarios();
                user.IdUsuario = int.Parse(reader["idUsuario"].ToString());
                user.Email = (reader["email"].ToString());
                user.Password = (reader["contraseña"].ToString());

            }
            return user;
        }

        public int suscripciones(Suscripciones suscripcion)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();
            string sql = "INSERT INTO suscripciones(nombreSuscripcion, descripcion, primerFactura, ciclo, precio, recordar, moneda, imagenes) " +
                "VALUES(@nombre, @descripcion, @factura, @ciclo, @precio, @recordar, @moneda, @imagenes)";

            MySqlCommand comando = new MySqlCommand(sql, conexion);

            comando.Parameters.AddWithValue("@nombre", suscripcion.NombreSuscripcion);
            comando.Parameters.AddWithValue("@descripcion", suscripcion.Descripcion);
            comando.Parameters.AddWithValue("@factura", suscripcion.PrimerFactura);
            comando.Parameters.AddWithValue("@ciclo", suscripcion.Ciclo);
            comando.Parameters.AddWithValue("@precio", suscripcion.Precio);
            comando.Parameters.AddWithValue("@recordar", suscripcion.Recordar);
            comando.Parameters.AddWithValue("@moneda", suscripcion.Moneda);
            comando.Parameters.AddWithValue("@imagenes", suscripcion.Imagen);

            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public void cargarImagen(PictureBox boxSus, Label lblNombre, Label lblPrecio) {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();
            string sql = "SELECT nombreSuscripcion, precio, imagenes FROM suscripciones WHERE idSuscripcion ='1'";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    MemoryStream ms = new MemoryStream((byte[])reader["imagenes"]);
                    Bitmap bm = new Bitmap(ms);
                    boxSus.Image = bm;
                    lblNombre.Text = reader["nombreSuscripcion"].ToString();
                    lblPrecio.Text = "$" + reader["precio"].ToString();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
