using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REMI_V2._0 {
    class Usuarios {
        int idUsuario;
        string nombre, usuario, email, palabraSeguridad, password, conPassword;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Email { get => email; set => email = value; }
        public string PalabraSeguridad { get => palabraSeguridad; set => palabraSeguridad = value; }
        public string Password { get => password; set => password = value; }
        public string ConPassword { get => conPassword; set => conPassword = value; }
    }
}
