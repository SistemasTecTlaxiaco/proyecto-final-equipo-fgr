﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REMI_V2._0 {
    class Conexion {
        public static MySqlConnection getConexion()
        {
            string servidor = "localhost";
            string puerto = "3306";
            string usuario = "root";
            string password = "";
            string bd = "remi";

            string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id="
                + usuario + "; password=" + password + "; database=" + bd;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            return conexion;
        }
    }
}
