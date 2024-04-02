using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class Producto
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strVariables str = new strVariables();

        #region gets sets struct
        private struct strVariables
        {
            public int idProducto;
            public int idLaboratorio;
            public int idPresentacion;
            public string nombre;
            public string descripcion;
            public decimal precioCompra;
            public decimal precioVenta;
            public int stock;
            public string usuarioRegistro;
        }

        public int IdProducto
        {
            get { return (str.idProducto); }
            set { str.idProducto = value; }
        }

        public int IdLaboratorio
        {
            get { return (str.idLaboratorio); }
            set { str.idLaboratorio = value; }
        }

        public int IdPresentacion
        {
            get { return (str.idPresentacion); }
            set { str.idPresentacion = value; }
        }

        public string Nombre
        {
            get { return (str.nombre); }
            set { str.nombre = value; }
        }

        public string Descripcion
        {
            get { return (str.descripcion); }
            set { str.descripcion = value; }
        }

        public decimal PrecioCompra
        {
            get { return (str.precioCompra); }
            set { str.precioCompra = value; }
        }

        public decimal PrecioVenta
        {
            get { return (str.precioVenta); }
            set { str.precioVenta = value; }
        }

        public int Stock
        {
            get { return (str.stock); }
            set { str.stock = value; }
        }

        public string UsuarioRegistro
        {
            get { return (str.usuarioRegistro); }
            set { str.usuarioRegistro = value; }
        }
        #endregion

        public Producto()
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

                    sqlCmd.CommandText = "PaProductoListar";
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

                    sqlCmd.Parameters.AddWithValue("@idProducto", IdProducto);

                    sqlCmd.CommandText = "PaProductoSeleccionar";

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

                    sqlCmd.Parameters.AddWithValue("@idLaboratorio", IdLaboratorio);
                    sqlCmd.Parameters.AddWithValue("@idPresentacion", IdPresentacion);
                    sqlCmd.Parameters.AddWithValue("@nombre", Nombre);
                    sqlCmd.Parameters.AddWithValue("@descripcion", Descripcion);
                    sqlCmd.Parameters.AddWithValue("@precioCompra", PrecioCompra);
                    sqlCmd.Parameters.AddWithValue("@precioVenta", PrecioVenta);
                    sqlCmd.Parameters.AddWithValue("@stock", Stock);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", UsuarioRegistro);

                    sqlCmd.CommandText = "PaProductoInsertar";

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

                    sqlCmd.Parameters.AddWithValue("@idProducto", IdProducto);
                    sqlCmd.Parameters.AddWithValue("@idLaboratorio", IdLaboratorio);
                    sqlCmd.Parameters.AddWithValue("@idPresentacion", IdPresentacion);
                    sqlCmd.Parameters.AddWithValue("@nombre", Nombre);
                    sqlCmd.Parameters.AddWithValue("@descripcion", Descripcion);
                    sqlCmd.Parameters.AddWithValue("@precioCompra", PrecioCompra);
                    sqlCmd.Parameters.AddWithValue("@precioVenta", PrecioVenta);
                    sqlCmd.Parameters.AddWithValue("@stock", Stock);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", UsuarioRegistro);

                    sqlCmd.CommandText = "PaProductoActualizar";

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

                    sqlCmd.Parameters.AddWithValue("@idProducto", IdProducto);

                    sqlCmd.CommandText = "PaProductoEliminar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }

        public DataTable Buscar(string consulta)
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


                    sqlCmd.Parameters.AddWithValue("@consulta", consulta);

                    sqlCmd.CommandText = "PaProductoBuscar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtConsulta);
                }
            }
            return dtConsulta;
        }
    }
}
