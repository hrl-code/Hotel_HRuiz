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
    public partial class ReservaSalones: Form
    {
        private Salon s;

        public ReservaSalones()
        {
            InitializeComponent();
            comboCatering_RS.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string htexto = s.ToString();
            Factura.Text = htexto;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BotonComDni();
        }

        private void botonRegistrarCliente_RS_Click(object sender, EventArgs e)
        {
            BotonRegistrarCliente();
        }

        private void botonRegistrarReserva_RS_Click(object sender, EventArgs e)
        {
            BotonReserva();
        }
    }
}
