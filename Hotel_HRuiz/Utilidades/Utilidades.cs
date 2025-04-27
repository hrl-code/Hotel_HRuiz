using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_HRuiz
{
    class Utilidades
    {
        public static bool CampoVacio(TextBox campo)
        {
            return "".Equals(campo.Text);
        }

        public static void LanzaAlertaCampoVacio(Control ventanaPadre, string mensaje)
        {
            MessageBox.Show(ventanaPadre, mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool EnteroCorrecto(TextBox campo)
        {
            try
            {
                string texto = campo.Text;
                int numero = int.Parse(texto);
                if (numero > 0)
                {
                    return true;
                }
            }
            catch (FormatException)
            {
            }
            return false;
        }

        public static void LanzarAlertaEntero(Control ventanaPadre, string mensaje)
        {
            MessageBox.Show(ventanaPadre, mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool ComboSinSeleccionar(ComboBox combo)
        {
            return combo.SelectedIndex == 0;
        }

        public static void LanzaAlertaComboVacio(Control ventanaPadre, ComboBox combo)
        {
            MessageBox.Show(ventanaPadre, "El combo " + combo.Name + " es obligatoria");
        }

        public static bool FormatoDNI(string compruebaFormatoDNI)
        {
            string patronDNI = "[0-9]{8}[A-Z]{1}";
            return Regex.IsMatch(compruebaFormatoDNI, patronDNI);
        }

        public static void LanzarFormatoDni(Control ventanaPadre, string mensaje)
        {
            MessageBox.Show(ventanaPadre, mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool DniValido(string validacionDNI)
        {
            char[] letra = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
            if (FormatoDNI(validacionDNI))
            {
                string numeroDNI = validacionDNI.Substring(0, 8);
                int indiceLetra = int.Parse(numeroDNI) % 23;
                return validacionDNI[8] == letra[indiceLetra];
            }
            return false;
        }

        public static void LanzarFormatoDniValido(Control ventanaPadre, string mensaje)
        {
            MessageBox.Show(ventanaPadre, mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool FormatoTelefono(string compruebaFormatoTelefono)
        {
            string patronTelefono = "[6-9]{1}[0-9]{8}";
            return Regex.IsMatch(compruebaFormatoTelefono, patronTelefono);
        }

        public static void LanzarTelefono(Control ventanaPadre, string mensaje)
        {
            MessageBox.Show(ventanaPadre, mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool FormatoTelefonoFijo(string compruebaFormatoTelefonoFijo)
        {
            string patronTelefonoFijo = "[8-9]{1}[0-8]{2}[0-9]{6}";
            return Regex.IsMatch(compruebaFormatoTelefonoFijo, patronTelefonoFijo);
        }

        public static void LanzarTelefonoFijo(Control ventanaPadre, string mensaje)
        {
            MessageBox.Show(ventanaPadre, mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool CorreoCorrecto(TextBox campo)
        {
            string patronEmail = "[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\\.[a-zA-Z0-9-]+)*";
            return Regex.IsMatch(campo.Text, patronEmail);
        }

        public static void LanzaAlertaCorreo(Control ventanaPadre, string mensaje)
        {
            MessageBox.Show(ventanaPadre, mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool FormatoCP(string compruebaFormatoCP)
        {
            string patronCP = "^[0-5]{1}[0-9]{1}[0]{1}[0-9]{2}$";
            return Regex.IsMatch(compruebaFormatoCP, patronCP);
        }

        public static void LanzaAlertaCp(Control ventanaPadre, string mensaje)
        {
            MessageBox.Show(ventanaPadre, mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void LanzaAlerta(Control ventanaPadre, string mensaje)
        {
            MessageBox.Show(ventanaPadre, mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
