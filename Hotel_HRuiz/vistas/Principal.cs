using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_HRuiz.bbdd;

namespace Hotel_HRuiz.vistas
{
    public partial class Principal: Form
    {
        public Principal()
        {
            InitializeComponent();
            Conexion.GuardarNombreApellidos(labelBienvenida, Login.miNombre);
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void botonReservaHabitacion_Click(object sender, EventArgs e)
        {
            ReservaHabitaciones ra = new ReservaHabitaciones();
            ra.Show();
        }

        private void botonReservaSalon_Click(object sender, EventArgs e)
        {
            ReservaSalones rs = new ReservaSalones();   
            rs.Show();  
        }

        private void botonAltaEmpleado_Click(object sender, EventArgs e)
        {
            AltaEmpleado ae = new AltaEmpleado();
            ae.Show();
        }

        private void botonVerReservaHabitacion_Click(object sender, EventArgs e)
        {
            VerReservaHabitaciones vra = new VerReservaHabitaciones();
            vra.Show();
        }

        private void botonVerReservaSalones_Click(object sender, EventArgs e)
        {
            VerReservaSalones vrs = new VerReservaSalones();
            vrs.Show();
        }

        private void botonListadoEmpleados_Click(object sender, EventArgs e)
        {
            VerEmpleados ve = new VerEmpleados();
            ve.Show();
        }
    }
}
