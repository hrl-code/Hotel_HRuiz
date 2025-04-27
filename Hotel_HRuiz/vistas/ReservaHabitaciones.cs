using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_HRuiz.modelo;

namespace Hotel_HRuiz.vistas
{
    public partial class ReservaHabitaciones: Form
    {
        
        public ReservaHabitaciones()
        {
            InitializeComponent();
            comboTipo_RH.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void botonDNI_Click(object sender, EventArgs e)
        {
            ComprobarDni();
        }

        private void botonRegistrarCliente_RH_Click(object sender, EventArgs e)
        {
            RegistrarCliente();
        }

        private void botonRegistrar_Click_1(object sender, EventArgs e)
        {
            RealizarReserva();
        }

        private void botonFactura_Click(object sender, EventArgs e)
        {
            ImprimirFactura();
        }
    }
}
