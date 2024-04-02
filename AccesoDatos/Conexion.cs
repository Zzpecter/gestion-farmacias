using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class Conexion
    {
        private SqlCommand sqlCmd;
        private SqlConnection conexion;
        private static string cadena = @"server=.\SQLEXPRESS;DataBase=BDDFarmacia;Trusted_Connection=True";
        public Conexion()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
        }
        /// <summary>
        /// Inicializa la cadena de conexion.
        /// </summary>
        /// <param name="con"></param>
        public void init()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = cadena;
        }

        /// <summary>
        /// Prueba el estado de la conexion con el servidor.
        /// </summary>
        /// <returns>Cadena que indica si hay errores</returns>
        public string probarConexion()
        {
            string error = string.Empty;
            try
            {
                conexion.Open();
            }
            catch (Exception e)
            {
                error = "Ocurrio un error al conectar con la Base de datos, Reporte:\n" + e;
            }
            return error;
        }

        public string getConexion()
        {
            init();
            return conexion.ConnectionString;
        }
    }
}
