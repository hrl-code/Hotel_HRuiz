using System;
using System.Windows.Forms;
using System.Data;
using Hotel_HRuiz.bbdd;
using Hotel_HRuiz.modelo;
using MySqlConnector;

namespace bbdd
{
    public class ConsultasHabitaciones
    {
        public static bool RegistrarHabitacion(Habitacion h)
        {
            string consulta = "Insert into reserva_habitacion (dniCliente, fechaentrada, fechasalida, tipohabitacion, noches, preciototal, dniEmpleado) " +
                              "Values (?dniCliente, ?fechaEntrada, ?fechaSalida, ?tipoHabitacion, ?noches, ?precioTotal, ?dniEmpleado)";
            MySqlConnection conn = new MySqlConnection(Conexion.url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("?dniCliente", h.DniCliente);
                comando.Parameters.AddWithValue("?fechaEntrada", h.FechaEntrada);
                comando.Parameters.AddWithValue("?fechaSalida", h.FachaSalida);
                comando.Parameters.AddWithValue("?tipoHabitacion", h.TiposHabitacion);
                comando.Parameters.AddWithValue("?noches", h.Noches);
                comando.Parameters.AddWithValue("?precioTotal", h.PrecioTotal);
                comando.Parameters.AddWithValue("?dniEmpleado", h.DniEmpleado);

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

        public static DataTable ListadoHabitacionesHis()
        {
            DataTable dt = new DataTable();
            string consulta = "select idReserva, dniCliente, fechaentrada, fechasalida, tipohabitacion, noches, preciototal from reserva_habitacion where fechaentrada < ?fecha";
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

        public static DataTable ListadoHabitacionesActual()
        {
            DataTable dt = new DataTable();
            string consulta = "select idReserva, dniCliente, fechaentrada, fechasalida, tipohabitacion, noches, preciototal from reserva_habitacion where fechaentrada >= ?fecha";
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

        public static DataTable ListadoHabitacionesFecha(DateTime fecha)
        {
            DataTable dt = new DataTable();
            string consulta = "select idReserva, dniCliente, fechaentrada, fechasalida, tipohabitacion, noches, preciototal from reserva_habitacion where fechaentrada = ?fecha";
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