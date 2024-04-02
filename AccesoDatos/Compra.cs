using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class Compra
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strVariables str = new strVariables();

        #region gets sets struct
        private struct strVariables
        {
            public int idCompra;
            public int idUsuario;
            public DateTime fecha;
            public decimal montoTotal;
            public string usuarioRegistro;
        }

        public int IdCompra
        {
            get { return (str.idCompra); }
            set { str.idCompra = value; }
        }

        public int IdUsuario
        {
            get { return (str.idUsuario); }
            set { str.idUsuario = value; }
        }

        public DateTime Fecha
        {
            get { return (str.fecha); }
            set { str.fecha = value; }
        }

        public decimal MontoTotal
        {
            get { return (str.montoTotal); }
            set { str.montoTotal = value; }
        }

        public string UsuarioRegistro
        {
            get { return (str.usuarioRegistro); }
            set { str.usuarioRegistro = value; }
        }
        #endregion

        public Compra()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
        }

        public DataTable Listar()
        {
            DataTable dtConsulta = new DataTable();
            Conexion con = new Conexion();
            string cadena = con.getConexion();
            string error = con.probarConexion();

            if (error.Equals(string.Empty))
            {
                using (conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    sqlCmd.Connection = conexion;
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    sqlCmd.Parameters.Clear();

                    sqlCmd.CommandText = "PaCompraListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtConsulta);
                }
            }
            return dtConsulta;
        }

        public DataTable Seleccionar()
        {
            DataTable dtConsulta = new DataTable();
            Conexion con = new Conexion();
            string cadena = con.getConexion();
            string error = con.probarConexion();

            if (error.Equals(string.Empty))
            {
                using (conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Connection = conexion;

                    sqlCmd.Parameters.Clear();

                    sqlCmd.Parameters.AddWithValue("@idCompra", IdCompra);

                    sqlCmd.CommandText = "PaCompraSeleccionar";

                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtConsulta);
                }
            }
            return dtConsulta;
        }

        public int Insertar()
        {
            int valores = 0;
            Conexion con = new Conexion();
            string cadena = con.getConexion();
            string error = con.probarConexion();

            if (error.Equals(string.Empty))
            {
                using (conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Connection = conexion;

                    sqlCmd.Parameters.Clear();

                    sqlCmd.Parameters.AddWithValue("@idUsuario", IdUsuario);
                    sqlCmd.Parameters.AddWithValue("@fecha", Fecha);
                    sqlCmd.Parameters.AddWithValue("@montoTotal", MontoTotal);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", UsuarioRegistro);

                    sqlCmd.CommandText = "PaCompraInsertar";

                    valores = Convert.ToInt32(sqlCmd.ExecuteScalar());
                }
            }
            return valores;
        }

        public int Actualizar()
        {
            int valores = 0;
            Conexion con = new Conexion();
            string cadena = con.getConexion();
            string error = con.probarConexion();

            if (error.Equals(string.Empty))
            {
                using (conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Connection = conexion;

                    sqlCmd.Parameters.Clear();

                    sqlCmd.Parameters.AddWithValue("@idCompra", IdCompra);
                    sqlCmd.Parameters.AddWithValue("@idUsuario", IdUsuario);
                    sqlCmd.Parameters.AddWithValue("@fecha", Fecha);
                    sqlCmd.Parameters.AddWithValue("@montoTotal", MontoTotal);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", UsuarioRegistro);

                    sqlCmd.CommandText = "PaCompraActualizar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }

        public int Eliminar()
        {
            int valores = 0;
            Conexion con = new Conexion();
            string cadena = con.getConexion();
            string error = con.probarConexion();

            if (error.Equals(string.Empty))
            {
                using (conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    sqlCmd.Connection = conexion;
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    sqlCmd.Parameters.Clear();

                    sqlCmd.Parameters.AddWithValue("@idCompra", IdCompra);

                    sqlCmd.CommandText = "PaCompraEliminar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }
    }
}
