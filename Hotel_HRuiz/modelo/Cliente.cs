using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_HRuiz.modelo
{
    public class Cliente : DatosPersona
    {
        private string direccion;
        private int cp;
        private string localidad;

        public Cliente(string dni, string nombre, string apellidos, int telefono, string email, string direccion, int cp, string localidad)
        : base (dni, nombre, apellidos, telefono,email)
        {
            this.direccion = direccion;
            this.cp = cp;
            this.localidad = localidad;
        }

        public string Direccion { get => direccion; set => direccion = value; }
        public int Cp { get => cp; set => cp = value; }
        public string Localidad { get => localidad; set => localidad = value; }
    }
}
