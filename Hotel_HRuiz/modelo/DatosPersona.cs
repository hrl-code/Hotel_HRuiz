using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_HRuiz.modelo
{
   public abstract class DatosPersona
    {
        private string dni, nombre, apellidos;
        private int telefono;
        private string email;

        public DatosPersona(string dni, string nombre, string apellidos, int telefono, string email)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.email = email;
        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
    }
}
