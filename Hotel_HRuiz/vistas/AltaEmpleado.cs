﻿using System;
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
    public partial class AltaEmpleado: Form
    {
        public AltaEmpleado()
        {
            InitializeComponent();
            comboTurno_RE.SelectedIndex = 0;
        }

        private void botonRegistrarEmpleado_RE_Click(object sender, EventArgs e)
        {
            RegistrarEmp();
        }
    }
}
