using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_HRuiz.modelo
{
    public class Habitacion
    {
        String dniCliente;
        DateTime fechaEntrada;
        DateTime fachaSalida;
        String tiposHabitacion;
        int noches;
        double precioTotal;
        String dniEmpleado;

        public Habitacion(string dniCliente, DateTime fechaEntrada, DateTime fachaSalida, string tiposHabitacion, int noches, double precioTotal, string dniEmpleado)
        {
            this.DniCliente = dniCliente;
            this.FechaEntrada = fechaEntrada;
            this.FachaSalida = fachaSalida;
            this.TiposHabitacion = tiposHabitacion;
            this.Noches = noches;
            this.PrecioTotal = precioTotal;
            this.DniEmpleado = dniEmpleado;
        }

        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public DateTime FechaEntrada { get => fechaEntrada; set => fechaEntrada = value; }
        public DateTime FachaSalida { get => fachaSalida; set => fachaSalida = value; }
        public string TiposHabitacion { get => tiposHabitacion; set => tiposHabitacion = value; }
        public int Noches { get => noches; set => noches = value; }
        public double PrecioTotal { get => precioTotal; set => precioTotal = value; }
        public string DniEmpleado { get => dniEmpleado; set => dniEmpleado = value; }
    }
}
