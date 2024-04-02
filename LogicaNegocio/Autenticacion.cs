using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;

namespace LogicaNegocio
{
    public class Autenticacion
    {
        private AccesoDatos.Usuario usuario = new AccesoDatos.Usuario();
        private DataTable dtUsuario = new DataTable();

        public string HashPassword(string pass)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(pass);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
                sb.Append(hash[i].ToString("X2"));
            return sb.ToString();
        }

        public string ComprobarPass(int index, string pass)
        {
            string correcto = "incorrecto";

            if (dtUsuario.Rows[index].ItemArray[3].ToString().Equals(pass))
                correcto = "correcto";

            return correcto;
        }

        public string BuscarUsuario(string login, string pass)
        {
            dtUsuario = usuario.Listar();
            string error = string.Empty;
            bool existe = false;

            for (int i = 0; i < dtUsuario.Rows.Count; ++i)
                if (dtUsuario.Rows[i].ItemArray[2].ToString().Equals(login))
                {
                    error = ComprobarPass(i, pass);
                    if (error != "incorrecto")
                    {
                        error = string.Empty;
                    }
                    existe = true;
                    break;
                }

            if (!existe)
                error = "El usuario no existe!";
            else if (error.Equals("incorrecto"))
                error = "Contraseña incorrecta!";

            return error;
        }

        public string ConexionActual()
        {
            AccesoDatos.Conexion con = new AccesoDatos.Conexion();
            string cadena = con.getConexion();
            string error = con.probarConexion();
            if (error.Equals(string.Empty))
                return ("Conexion BDD: OK");
            else
                return (error);
        }
    }
}
