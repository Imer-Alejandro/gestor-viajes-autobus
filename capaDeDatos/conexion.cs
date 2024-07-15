using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace capaDeDatos
{
    public class Conexion
    {
        // Define la cadena de conexión con autenticación de Windows
        private readonly string connectionString = "Server=DESKTOP-SQM854D;Database=practicasP2;Integrated Security=True;";
        private SqlConnection sqlConnection;

        // Constructor
        public Conexion()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        // Método para abrir la conexión
        public void AbrirConexion()
        {
            try
            {
                if (sqlConnection.State == System.Data.ConnectionState.Closed)
                {
                    sqlConnection.Open();
                    Console.WriteLine("Conexión abierta exitosamente.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            }
        }

        // Método para cerrar la conexión
        public void CerrarConexion()
        {
            try
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                    Console.WriteLine("Conexión cerrada exitosamente.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            }
        }

        // Propiedad para obtener la conexión
        public SqlConnection ObtenerConexion()
        {
            return sqlConnection;
        }
    }

}
