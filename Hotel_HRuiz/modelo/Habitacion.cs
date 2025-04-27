using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_HRuiz.modelo
{


    public class Habitacion
    {
        private string dniCliente;
        private DateTime fechaEntrada;
        private DateTime fechaSalida;
        private string tiposHabitacion;
        private int noches;
        private double precioTotal;
        private string dniEmpleado;
        private const double PrecioNocheSencilla = 60.00;
        private const double PrecioNocheDoble = 100.00;

        public Habitacion(string dniCliente, DateTime fechaEntrada, DateTime fechaSalida, string tiposHabitacion, int noches, string dniEmpleado)
        {
            this.dniCliente = dniCliente;
            this.fechaEntrada = fechaEntrada;
            this.fechaSalida = fechaSalida;
            this.tiposHabitacion = tiposHabitacion;
            this.noches = noches;
            if (this.tiposHabitacion.Equals("sencilla"))
            {
                this.precioTotal = noches * PrecioNocheSencilla;
            }
            else
            {
                this.precioTotal = noches * PrecioNocheDoble;
            }
            this.dniEmpleado = dniEmpleado;
        }

        public string DniCliente
        {
            get { return dniCliente; }
            set { dniCliente = value; }
        }

        public DateTime FechaEntrada
        {
            get { return fechaEntrada; }
            set { fechaEntrada = value; }
        }

        public DateTime FechaSalida
        {
            get { return fechaSalida; }
            set { fechaSalida = value; }
        }

        public string TiposHabitacion
        {
            get { return tiposHabitacion; }
            set { tiposHabitacion = value; }
        }

        public int Noches
        {
            get { return noches; }
            set { noches = value; }
        }

        public double PrecioTotal
        {
            get { return precioTotal; }
            set { precioTotal = value; }
        }

        public string DniEmpleado
        {
            get { return dniEmpleado; }
            set { dniEmpleado = value; }
        }

        public override string ToString()
        {
            return "Dni Cliente: " + dniCliente + Environment.NewLine + "FechaEntrada: " + fechaEntrada + "\nFechaSalida: " + fechaSalida + Environment.NewLine + "Noches Reservadas: " + noches + Environment.NewLine + "Tipo de Habitacion: " + tiposHabitacion + Environment.NewLine + "Total de factura: " + precioTotal + Environment.NewLine;
        }
    }
}

