using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class Configuracion
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strVariables str = new strVariables();

        #region gets sets struct
        private struct strVariables
        {
            public int tasaVenta;
            public int iva;
            public int it;
            public string usuarioRegistro;
        }

        public int TasaVenta
        {
            get { return (str.tasaVenta); }
            set { str.tasaVenta = value; }
        }

        public int Iva
        {
            get { return (str.iva); }
            set { str.iva = value; }
        }

        public int It
        {
            get { return (str.it); }
            set { str.it = value; }
        }

        public string UsuarioRegistro
        {
            get { return (str.usuarioRegistro); }
            set { str.usuarioRegistro = value; }
        }
        #endregion

        public Configuracion()
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

                    sqlCmd.CommandText = "PaConfiguracionListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtConsulta);
                }
            }
            return dtConsulta;
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

                    sqlCmd.Parameters.AddWithValue("@tasaVenta", TasaVenta);
                    sqlCmd.Parameters.AddWithValue("@iva", Iva);
                    sqlCmd.Parameters.AddWithValue("@it", It);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", UsuarioRegistro);

                    sqlCmd.CommandText = "PaConfiguracionActualizar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }
    }
}
