using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDeDatos;

namespace capaDeNegocio
{
    public class OperacionesNegocio
    {
        private Operaciones_db operacionesDb;

        public OperacionesNegocio()
        {
            operacionesDb = new Operaciones_db();
        }

        // Métodos para la tabla Chofer
        public void CrearChofer(string nombre, string telefono, string cedula, DateTime fechaNacimiento)
        {
            string query = "CrearChofer";
            operacionesDb.EjecutarProcedimientoSinRetorno(query, new SqlParameter[]
            {
                new SqlParameter("@nombre", nombre),
                new SqlParameter("@telefono", telefono),
                new SqlParameter("@cedula", cedula),
                new SqlParameter("@fecha_nacimiento", fechaNacimiento)
            });
        }

        public DataTable ObtenerChofer(int id)
        {
            string query = "ObtenerChofer";
            return operacionesDb.EjecutarProcedimientoConRetorno(query, new SqlParameter[]
            {
                new SqlParameter("@id", id)
            });
        }

        public void ActualizarChofer(int id, string nombre, string telefono, string cedula, DateTime fechaNacimiento)
        {
            string query = "ActualizarChofer";
            operacionesDb.EjecutarProcedimientoSinRetorno(query, new SqlParameter[]
            {
                new SqlParameter("@id", id),
                new SqlParameter("@nombre", nombre),
                new SqlParameter("@telefono", telefono),
                new SqlParameter("@cedula", cedula),
                new SqlParameter("@fecha_nacimiento", fechaNacimiento)
            });
        }

        public void EliminarChofer(string nombre, bool activo)
        {
            string query = "ActualizarEstadoChoferPorNombre";
            operacionesDb.EjecutarProcedimientoSinRetorno(query, new SqlParameter[]
            {
                new SqlParameter("@nombre", nombre),
                 new SqlParameter("@activo", activo)
            });
        }

        public DataTable ObtenerTodosLosChoferes()
        {
            string query = "choferesDisponiblesAndActivos";
            return operacionesDb.EjecutarProcedimientoConRetorno(query, null);
        }

        // Métodos para la tabla Ruta
        public void CrearRuta(string nombre)
        {
            string query = "CrearRuta";
            operacionesDb.EjecutarProcedimientoSinRetorno(query, new SqlParameter[]
            {
                new SqlParameter("@nombre", nombre)
            });
        }

        public DataTable ObtenerRuta(int id)
        {
            string query = "ObtenerRuta";
            return operacionesDb.EjecutarProcedimientoConRetorno(query, new SqlParameter[]
            {
                new SqlParameter("@id", id)
            });
        }

        public void ActualizarRuta(int id, string nombre)
        {
            string query = "ActualizarRuta";
            operacionesDb.EjecutarProcedimientoSinRetorno(query, new SqlParameter[]
            {
                new SqlParameter("@id", id),
                new SqlParameter("@nombre", nombre)
            });
        }

        public void EliminarRuta(String nombre)
        {
            string query = "ActualizarEstadoRutas";
            operacionesDb.EjecutarProcedimientoSinRetorno(query, new SqlParameter[]
            {
                new SqlParameter(" @nombre", nombre),
                new SqlParameter(" @activo", false)
            });
        }

        public DataTable ObtenerTodasLasRutas()
        {
            string query = "rutasDisponiblesAndActivos";
            return operacionesDb.EjecutarProcedimientoConRetorno(query, null);
        }

        // Métodos para la tabla Guagua
        public void CrearGuagua(string marca, string modelo, string placa, string color, int aro)
        {
            string query = "CrearGuagua";
            operacionesDb.EjecutarProcedimientoSinRetorno(query, new SqlParameter[]
            {
                new SqlParameter("@marca", marca),
                new SqlParameter("@modelo", modelo),
                new SqlParameter("@placa", placa),
                new SqlParameter("@color", color),
                new SqlParameter("@aro", aro)
            });
        }

        public DataTable ObtenerGuagua(int id)
        {
            string query = "guaguasDisponibles";
            return operacionesDb.EjecutarProcedimientoConRetorno(query, new SqlParameter[]
            {
                new SqlParameter("@id", id)
            });
        }

        public void ActualizarGuagua(int id, string marca, string modelo, string placa, string color, int aro)
        {
            string query = "ActualizarGuagua";
            operacionesDb.EjecutarProcedimientoSinRetorno(query, new SqlParameter[]
            {
                new SqlParameter("@id", id),
                new SqlParameter("@marca", marca),
                new SqlParameter("@modelo", modelo),
                new SqlParameter("@placa", placa),
                new SqlParameter("@color", color),
                new SqlParameter("@aro", aro)
            });
        }

        public void EliminarGuagua(String marca)
        {
            string query = "ActualizarEstadoGuaguasDl";
            operacionesDb.EjecutarProcedimientoSinRetorno(query, new SqlParameter[]
            {
                new SqlParameter(" @marca", marca),
                new SqlParameter(" @activo", false)
            });
        }

        public DataTable ObtenerTodasLasGuaguas()
        {
            string query = "ObtenerTodasLasGuaguas";
            return operacionesDb.EjecutarProcedimientoConRetorno(query, null);
        }

        // Método para la tabla Viajes
        public void CrearViaje(int choferId, int guaguaId, int rutaId)
        {
            string query = "CrearViaje";
            operacionesDb.EjecutarProcedimientoSinRetorno(query, new SqlParameter[]
            {
                new SqlParameter("@chofer_id", choferId),
                new SqlParameter("@guagua_id", guaguaId),
                new SqlParameter("@ruta_id", rutaId)
            });
        }

        // Método para obtener los datos de viajes
        public DataTable ObtenerViajes()
        {
            string query = "ObtenerViajes";
            return operacionesDb.EjecutarProcedimientoConRetorno(query, null);
        }

        // Método para actualizar el estado de viaje_completado
        public void ActualizarEstadoViaje(int viajeId, bool nuevoEstado)
        {
            string query = "ActualizarEstadoViajes";
            operacionesDb.EjecutarProcedimientoSinRetorno(query, new SqlParameter[]
            {
        new SqlParameter("@viaje_id", viajeId),
        new SqlParameter("@nuevo_estado", nuevoEstado)
            });
        }
        public DataTable listadoChoferes()
        {
            string query = "choferesGeneral";
            return operacionesDb.EjecutarProcedimientoConRetorno(query, null);
        }

        public DataTable listadoRutas()
        {
            string query = "rutasGeneral";
            return operacionesDb.EjecutarProcedimientoConRetorno(query, null);
        }

        public DataTable listadoGuaguas()
        {
            string query = "guaguasGeneral";
            return operacionesDb.EjecutarProcedimientoConRetorno(query, null);
        }
    }
}
