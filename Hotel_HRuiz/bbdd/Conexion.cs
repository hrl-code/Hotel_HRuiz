using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Hotel_HRuiz.bbdd
{
    class Conexion
    {
        public static readonly string url = "Server=susan.hidencloud.com;" +
                    "Database=hoteles;" +
                    "User ID=destro;" +
                    "Port=24651;" +
                    "Password=DestroXD;" +
                    "Convert Zero Datetime=True;";

        public static bool Acceder(string user, string pass)
        {
            string consulta = "SELECT * FROM empleados WHERE usuario = ?user AND contrasenya = ?pass";
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("?user", user);
                comando.Parameters.AddWithValue("?pass", pass);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static bool GuardarNombreApellidos(Label lb, string usuario)
        {
            string consulta = "SELECT CONCAT(nombre, ' ', apellidos) FROM empleados WHERE usuario = ?user";
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("?user", usuario);

                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    lb.Text = "Bienvenid@ " + reader.GetString(0);
                    return reader.Read(); // Comprueba si hay más registros
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }


    }
}
