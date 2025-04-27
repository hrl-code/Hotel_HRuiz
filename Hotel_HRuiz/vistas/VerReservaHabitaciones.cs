using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_HRuiz.vistas
{
    public partial class VerReservaHabitaciones: Form
    {
        public VerReservaHabitaciones()
        {
            InitializeComponent();
        }

        private void botonMostrar_Click(object sender, EventArgs e)
        {
            CargarReservasPorFecha();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarReservasActuales();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarReservasHistorico();
        }

        private void fecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
