using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_HRuiz.Utilidades
{
    class Utilidades
    {
        public static Boolean Validaormulario(GroupBox g)
        {
            foreach (Control c in g.Controls)
            {
                if (c is TextBox micampo && micampo.Text.Trim() == "")
                {
                    MessageBox.Show("El campo " + c.Tag + " es obligatorio.");
                    return false;
                }
                if (c is ComboBox combo && combo.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un elemento en " + c.Tag);
                    return false;
                }
            }
            return true;
        }

        public static void LimpiarFormulario(GroupBox g)
        {
            foreach (Control c in g.Controls)
            {
                if (c is TextBox micampo)
                {
                    micampo.Clear();
                }
                if (c is ComboBox com)
                {
                    com.SelectedItem = null;
                }
            }
        }
    }
}
