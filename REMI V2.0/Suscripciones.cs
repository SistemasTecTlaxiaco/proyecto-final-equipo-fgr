using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REMI_V2._0 {
    class Suscripciones {
        int idSuscripcion, ciclo, precio, recordar;
        string nombreSuscripcion, descripcion, primerFactura, moneda;
        byte[] imagen;

        public int IdSuscripcion { get => idSuscripcion; set => idSuscripcion = value; }
        public int Ciclo { get => ciclo; set => ciclo = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Recordar { get => recordar; set => recordar = value; }
        public string NombreSuscripcion { get => nombreSuscripcion; set => nombreSuscripcion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string PrimerFactura { get => primerFactura; set => primerFactura = value; }
        public string Moneda { get => moneda; set => moneda = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }
    }
}
