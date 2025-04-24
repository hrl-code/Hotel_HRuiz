using System;
using System.Windows.Forms;
using System.Data;
using Hotel_HRuiz.bbdd;
using Hotel_HRuiz.modelo;
using MySqlConnector;

namespace bbdd
{
    public class ConsultasEmpleados
    {
        public static string GuardarDNI(string usuario)
        {
            string dni = "";
            string consulta = "select dniEmpleado from empleados where usuario = ?usuario";
            MySqlConnection conn = new MySqlConnection(Conexion.url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("?usuario", usuario);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    dni = reader.GetString("dniEmpleado");
                }
            }
            catch (MySqlException ex) 
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dni;
        }

        public static bool RegistrarEmpleado(Empleado e)
        {
            string consulta = "Insert into empleados (dniEmpleado, nombre, apellidos, telefono, email, fechaContrato, turno, salarioBase, usuario, contrasenya) " +
                              "Values (?dni, ?nombre, ?apellidos, ?telefono, ?email, ?fechaContrato, ?turno, ?salarioBase, ?usuario, ?contrasenya)";
            MySqlConnection conn = new MySqlConnection(Conexion.url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("?dni", e.Dni);
                comando.Parameters.AddWithValue("?nombre", e.Nombre);
                comando.Parameters.AddWithValue("?apellidos", e.Apellidos);
                comando.Parameters.AddWithValue("?telefono", e.Telefono);
                comando.Parameters.AddWithValue("?email", e.Email);
                comando.Parameters.AddWithValue("?fechaContrato", e.FechaContrato);
                comando.Parameters.AddWithValue("?turno", e.Turno);
                comando.Parameters.AddWithValue("?salarioBase", e.SalarioBase);
                comando.Parameters.AddWithValue("?usuario", e.Usuario);
                comando.Parameters.AddWithValue("?contrasenya", e.Pass);

                comando.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex) // Renamed 'e' to 'ex' to avoid conflict  
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable ListadoEmpleadosTodos()
        {
            DataTable dt = new DataTable();
            string consulta = "select dniEmpleado, nombre, apellidos, telefono, email, turno from empleados";
            MySqlConnection conn = new MySqlConnection(Conexion.url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                adapter.Fill(dt);
            }
            catch (MySqlException ex) // Renamed 'e' to 'ex' to avoid conflict  
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public static DataTable ListadoEmpleadosMañanas()
        {
            DataTable dt = new DataTable();
            string consulta = "select dniEmpleado, nombre, apellidos, telefono, email, turno from empleados where turno = 'mañanas'";
            MySqlConnection conn = new MySqlConnection(Conexion.url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                adapter.Fill(dt);
            }
            catch (MySqlException ex) // Renamed 'e' to 'ex' to avoid conflict  
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public static DataTable ListadoEmpleadosTardes()
        {
            DataTable dt = new DataTable();
            string consulta = "select dniEmpleado, nombre, apellidos, telefono, email, turno from empleados where turno = 'tardes'";
            MySqlConnection conn = new MySqlConnection(Conexion.url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                adapter.Fill(dt);
            }
            catch (MySqlException ex) // Renamed 'e' to 'ex' to avoid conflict  
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public static DataTable ListadoEmpleadosNoches()
        {
            DataTable dt = new DataTable();
            string consulta = "select dniEmpleado, nombre, apellidos, telefono, email, turno from empleados where turno = 'noches'";
            MySqlConnection conn = new MySqlConnection(Conexion.url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                adapter.Fill(dt);
            }
            catch (MySqlException ex) // Renamed 'e' to 'ex' to avoid conflict  
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public static DataTable ListadoEmpleadosPartido()
        {
            DataTable dt = new DataTable();
            string consulta = "select dniEmpleado, nombre, apellidos, telefono, email, turno from empleados where turno = 'partido'";
            MySqlConnection conn = new MySqlConnection(Conexion.url);

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);

                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                adapter.Fill(dt);
            }
            catch (MySqlException ex) // Renamed 'e' to 'ex' to avoid conflict  
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
    }
}