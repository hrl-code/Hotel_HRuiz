using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_HRuiz.vistas;

namespace Hotel_HRuiz
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void botonEntrar_L_Click(object sender, EventArgs e)
        {
            Entrar();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
