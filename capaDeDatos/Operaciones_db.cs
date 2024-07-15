 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace capaDeDatos
{
    public class Operaciones_db
    {
        private Conexion conexion;

        public Operaciones_db()
        {
            conexion = new Conexion();
        }

        public void EjecutarProcedimientoSinRetorno(string query, SqlParameter[] parametros)
        {
            try
            {
                conexion.AbrirConexion();
                using (SqlCommand comando = new SqlCommand(query, conexion.ObtenerConexion()))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    if (parametros != null)
                    {
                        comando.Parameters.AddRange(parametros);
                    }
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar el procedimiento: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public DataTable EjecutarProcedimientoConRetorno(string query, SqlParameter[] parametros)
        {
            DataTable dataTable = new DataTable();
            try
            {
                conexion.AbrirConexion();
                using (SqlCommand comando = new SqlCommand(query, conexion.ObtenerConexion()))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    if (parametros != null)
                    {
                        comando.Parameters.AddRange(parametros);
                    }
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(comando))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar el procedimiento: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return dataTable;
        }
    }
}