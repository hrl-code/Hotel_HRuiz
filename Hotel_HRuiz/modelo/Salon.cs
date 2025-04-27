using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_HRuiz.modelo
{
    public class Salon
    {
        private string dniCliente;
        private DateTime fecha;
        private int numPersonas;
        private string caterin;
        private double precio;
        private string dniEmpleado;
        private const double PrecioFijo = 475.00;
        private const double PrecioconAlmuerzo = 60.00;
        private const double PrecioconComida = 90.00;
        private const double PrecioconDesayuno = 75.00;
        private const double PrecioconCena = 80.00;

        public Salon(string dniCliente, DateTime fecha, int numPersonas, string caterin, string dniEmpleado)
        {
            this.dniCliente = dniCliente;
            this.fecha = fecha;
            this.numPersonas = numPersonas;
            this.caterin = caterin;
            if (caterin == "Almuerzo")
            {
                this.precio = PrecioFijo + (PrecioconAlmuerzo * numPersonas);
            }
            else if (caterin == "Comida")
            {
                this.precio = PrecioFijo + (PrecioconComida * numPersonas);
            }
            else if (caterin == "Desayuno")
            {
                this.precio = PrecioFijo + (PrecioconDesayuno * numPersonas);
            }
            else if (caterin == "Cena")
            {
                this.precio = PrecioFijo + (PrecioconCena * numPersonas);
            }
            this.dniEmpleado = dniEmpleado;
        }

        public string DniCliente
        {
            get { return dniCliente; }
            set { dniCliente = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public int NumPersonas
        {
            get { return numPersonas; }
            set { numPersonas = value; }
        }

        public string Caterin
        {
            get { return caterin; }
            set { caterin = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string DniEmpleado
        {
            get { return dniEmpleado; }
            set { dniEmpleado = value; }
        }

        public override string ToString()
        {
            return "Dni Cliente: " + dniCliente + Environment.NewLine
                + "Fecha: " + fecha + Environment.NewLine
                + "Número de Personas: " + numPersonas + Environment.NewLine
                + "Catering: " + caterin + Environment.NewLine
                + "Total de factura: " + precio + "€" + Environment.NewLine
                + "Dni Empleado: " + dniEmpleado + Environment.NewLine;
        }
    }
}
