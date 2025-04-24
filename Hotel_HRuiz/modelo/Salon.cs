using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_HRuiz.modelo
{
    public class Salon
    {
         string dniCliente;
         DateTime fecha;
         int numPersonas;
         string caterin;
         double precio;
         string dniEmpleado;
         const double PrecioconAlmuerzo = 60.00;
         const double PrecioconComida = 90.00;
         const double PrecioconDesayuno = 75.00;
         const double PrecioconCena = 80.00;

        public Salon(string dniCliente, DateTime fecha, int numPersonas, string caterin, double precio, string dniEmpleado)
        {
            this.dniCliente = dniCliente;
            this.fecha = fecha;
            this.numPersonas = numPersonas;
            this.caterin = caterin;
            this.precio = precio;
            this.dniEmpleado = dniEmpleado;
        }

        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int NumPersonas { get => numPersonas; set => numPersonas = value; }
        public string Caterin { get => caterin; set => caterin = value; }
        public double Precio { get => precio; set => precio = value; }
        public string DniEmpleado { get => dniEmpleado; set => dniEmpleado = value; }

        public static double PrecioconAlmuerzo1 => PrecioconAlmuerzo;

        public static double PrecioconComida1 => PrecioconComida;

        public static double PrecioconDesayuno1 => PrecioconDesayuno;

        public static double PrecioconCena1 => PrecioconCena;
    }
}
