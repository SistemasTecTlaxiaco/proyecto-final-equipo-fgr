using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REMI_V2._0 {
    class Control {

        public string ctrlRegistro(Usuarios usuario) {
            Modelo modelo = new Modelo();
            string respuesta = "";
            if (string.IsNullOrEmpty(usuario.Nombre) || string.IsNullOrEmpty(usuario.Usuario) ||
                string.IsNullOrEmpty(usuario.Email) || string.IsNullOrEmpty(usuario.PalabraSeguridad) ||
                string.IsNullOrEmpty(usuario.Password) || string.IsNullOrEmpty(usuario.ConPassword))
            {
                respuesta = "Debe llenar todos los campos";
            } else {
                if (usuario.Password == usuario.ConPassword)
                {
                    if (modelo.existeUsuario(usuario.Usuario))
                    {
                        respuesta = "El usuario ya existe";
                    } else if (modelo.existeUsuario(usuario.Email)) {
                        respuesta = "El correo ya existe";
                    }
                    else
                    {
                        modelo.registro(usuario);
                    }
                }
                else {
                    respuesta = "Las contraseñas no coinciden";
                }
            }
            return respuesta;
        }

        public string ctrlLogin(string usuario, string password) {
            Modelo modelo = new Modelo();
            string respuesta = "";

            Usuarios datosUsuario, datosEmail = null;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else {
                datosUsuario = modelo.porUsuario(usuario);
                datosEmail = modelo.porEmail(usuario);
                if (datosUsuario != null)
                {
                    if (datosUsuario.Password != password)
                    {
                        respuesta = "El usuario y/o contraseña no coinciden";
                    }
                }
                else if (datosEmail != null)
                {
                    if (datosEmail.Password != password)
                    {
                        respuesta = "El email y/o contraseña no coinciden";
                    }
                }
                else {
                    respuesta = "El usuario o email no estan registrados";
                }
            }
            return respuesta;
        }

        public string ctrlSuscripcion(Suscripciones suscripcion)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            if (string.IsNullOrEmpty(suscripcion.NombreSuscripcion) || string.IsNullOrEmpty(suscripcion.Descripcion) ||
                string.IsNullOrEmpty(suscripcion.PrimerFactura) || string.IsNullOrEmpty(suscripcion.Ciclo.ToString()) ||
                string.IsNullOrEmpty(suscripcion.Precio.ToString()) || string.IsNullOrEmpty(suscripcion.Recordar.ToString()) ||
                string.IsNullOrEmpty(suscripcion.Moneda))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                modelo.suscripciones(suscripcion); 
            }
            return respuesta;
        }

    }
}
