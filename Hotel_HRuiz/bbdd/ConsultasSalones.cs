using System;
using System.Windows.Forms;
using System.Data;
using Hotel_HRuiz.bbdd;
using Hotel_HRuiz.modelo;
using MySqlConnector;

namespace bbdd
{
    public class ConsultasSalones
    {
        public static void CargarComboCatering(ComboBox.ObjectCollection items)
        {
            string consulta = "SELECT caterin FROM reserva_salon";
            MySqlConnection conn = new MySqlConnection(Conexion.url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                MySqlDataReader reader = comando.ExecuteReader();

                items.Add("SELECCIONE");

                while (reader.Read())
                {
                    items.Add(reader.GetString("caterin"));
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
        }

        public static bool RegistrarSalon(Salon s)
        {
            string consulta = "Insert into reserva_salon (dniCliente, fecha, numPersonas, caterin, precio, dniEmpleado) " +
                              "Values (?dniCliente, ?fecha, ?numPersonas, ?caterin, ?precio, ?dniEmpleado)";
            MySqlConnection conn = new MySqlConnection(Conexion.url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("?dniCliente", s.DniCliente);
                comando.Parameters.AddWithValue("?fecha", s.Fecha);
                comando.Parameters.AddWithValue("?numPersonas", s.NumPersonas);
                comando.Parameters.AddWithValue("?caterin", s.Caterin);
                comando.Parameters.AddWithValue("?precio", s.Precio);
                comando.Parameters.AddWithValue("?dniEmpleado", s.DniEmpleado);

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

        public static DataTable ListadoSalonesActual()
        {
            DataTable dt = new DataTable();
            string consulta = "select idReserva, dniCliente, fecha, numPersonas, caterin, precio from reserva_salon where fecha >= ?fecha";
            MySqlConnection conn = new MySqlConnection(Conexion.url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("?fecha", DateTime.Now.Date);

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

        public static DataTable ListadoSalonesHis()
        {
            DataTable dt = new DataTable();
            string consulta = "select idReserva, dniCliente, fecha, numPersonas, caterin, precio from reserva_salon where fecha < ?fecha";
            MySqlConnection conn = new MySqlConnection(Conexion.url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("?fecha", DateTime.Now.Date);

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

        public static DataTable ListadoSalonesFecha(DateTime fecha)
        {
            DataTable dt = new DataTable();
            string consulta = "select idReserva, dniCliente, fecha, numPersonas, caterin, precio from reserva_salon where fecha = ?fecha";
            MySqlConnection conn = new MySqlConnection(Conexion.url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("?fecha", fecha.Date);

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