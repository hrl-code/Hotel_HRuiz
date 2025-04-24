using System;
using System.Windows.Forms;
using System.Data;
using Hotel_HRuiz.bbdd;
using Hotel_HRuiz.modelo;
using MySqlConnector;

namespace bbdd
{
    public class ConsultasClientes
    {
        public static bool ComprobarDni(string dniCliente)
        {
            bool resultado = false;
            string consulta = "SELECT dniCliente FROM clientes WHERE dniCliente = ?dni";
            MySqlConnection conn = new MySqlConnection(Conexion.url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("?dni", dniCliente);

                MySqlDataReader reader = comando.ExecuteReader();
                resultado = reader.HasRows;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                conn.Close();
            }

            return resultado;
        }

        public static Cliente RescataDatosCliente(string dniCliente)
        {
            Cliente c = null;
            string consulta = "select dniCliente, nombre, apellidos, telefono, email, direccion, cp, localidad from clientes where dniCliente = ?dni";
            MySqlConnection conn = new MySqlConnection(Conexion.url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("?dni", dniCliente);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    c = new Cliente(
                        reader.GetString("dniCliente"),
                        reader.GetString("nombre"),
                        reader.GetString("apellidos"),
                        reader.GetInt32("telefono"),
                        reader.GetString("email"),
                        reader.GetString("direccion"),
                        reader.GetInt32("cp"),
                        reader.GetString("localidad")
                    );
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                conn.Close();
            }

            return c;
        }

        public static bool RegistrarCliente(Cliente c)
        {
            string consulta = "Insert into clientes (dniCliente, nombre, apellidos, telefono, email, direccion, cp, localidad) " +
                              "Values (?dni, ?nombre, ?apellidos, ?telefono, ?email, ?direccion, ?cp, ?localidad)";
            MySqlConnection conn = new MySqlConnection(Conexion.url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("?dni", c.Dni);
                comando.Parameters.AddWithValue("?nombre", c.Nombre);
                comando.Parameters.AddWithValue("?apellidos", c.Apellidos);
                comando.Parameters.AddWithValue("?telefono", c.Telefono);
                comando.Parameters.AddWithValue("?email", c.Email);
                comando.Parameters.AddWithValue("?direccion", c.Direccion);
                comando.Parameters.AddWithValue("?cp", c.Cp);
                comando.Parameters.AddWithValue("?localidad", c.Localidad);

                comando.ExecuteNonQuery();
                return true;
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

        public static DataTable ListadoClientes()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT dniCliente, nombre, apellidos, telefono, email, direccion, cp, localidad FROM clientes";
            MySqlConnection conn = new MySqlConnection(Conexion.url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                adapter.Fill(dt);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
    }
}