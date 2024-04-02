using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ProductoCompra
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strVariables str = new strVariables();

        #region gets sets struct
        private struct strVariables
        {
            public int idProductoCompra;
            public int idProducto;
            public int idCompra;
            public DateTime fechaVencimiento;
            public int cantidad;
            public string usuarioRegistro;
        }

        public int IdProductoCompra
        {
            get { return (str.idProductoCompra); }
            set { str.idProductoCompra = value; }
        }

        public int IdProducto
        {
            get { return (str.idProducto); }
            set { str.idProducto = value; }
        }

        public int IdCompra
        {
            get { return (str.idCompra); }
            set { str.idCompra = value; }
        }

        public DateTime FechaVencimiento
        {
            get { return (str.fechaVencimiento); }
            set { str.fechaVencimiento = value; }
        }

        public int Cantidad
        {
            get { return (str.cantidad); }
            set { str.cantidad = value; }
        }

        public string UsuarioRegistro
        {
            get { return (str.usuarioRegistro); }
            set { str.usuarioRegistro = value; }
        }
        #endregion

        public ProductoCompra()
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

                    sqlCmd.CommandText = "PaProductoCompraListar";
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

                    sqlCmd.Parameters.AddWithValue("@idProductoCompra", IdProductoCompra);

                    sqlCmd.CommandText = "PaProductoCompraSeleccionar";

                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtConsulta);
                }
            }
            return dtConsulta;
        }


        public DataTable SeleccionarVenc()
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

                    sqlCmd.Parameters.AddWithValue("@idProducto", IdProducto);

                    sqlCmd.CommandText = "PaProductoCompraSeleccionarVenc";

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

                    sqlCmd.Parameters.AddWithValue("@idProducto", IdProducto);
                    sqlCmd.Parameters.AddWithValue("@idCompra", IdCompra);
                    sqlCmd.Parameters.AddWithValue("@fechaVencimiento", FechaVencimiento);
                    sqlCmd.Parameters.AddWithValue("@cantidad", Cantidad);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", UsuarioRegistro);

                    sqlCmd.CommandText = "PaProductoCompraInsertar";

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

                    sqlCmd.Parameters.AddWithValue("@idProductoCompra", IdProductoCompra);
                    sqlCmd.Parameters.AddWithValue("@idProducto", IdProducto);
                    sqlCmd.Parameters.AddWithValue("@idCompra", IdCompra);
                    sqlCmd.Parameters.AddWithValue("@fechaVencimiento", FechaVencimiento);
                    sqlCmd.Parameters.AddWithValue("@cantidad", Cantidad);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", UsuarioRegistro);
                    sqlCmd.CommandText = "PaProductoCompraActualizar";

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

                    sqlCmd.Parameters.AddWithValue("@idProductoCompra", IdProductoCompra);

                    sqlCmd.CommandText = "PaProductoCompraEliminar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }
    }
}
