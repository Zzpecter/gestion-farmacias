using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Usuario
    {
        private Controladora ctrl = new Controladora();
        private strVariables str = new strVariables();
        private AccesoDatos.Usuario adt = new AccesoDatos.Usuario();
        public DataTable dtt = new DataTable();

        #region gets sets struct
        private struct strVariables
        {
            public int idUsuario;
            public int idNivel;
            public string login;
            public string password;
            public string usuarioRegistro;
        }

        public int IdUsuario
        {
            get { return (str.idUsuario); }
            set { str.idUsuario = value; }
        }

        public int IdNivel
        {
            get { return (str.idNivel); }
            set { str.idNivel = value; }
        }

        public string Login
        {
            get { return (str.login); }
            set { str.login = value; }
        }

        public string Password
        {
            get { return (str.password); }
            set { str.password = value; }
        }

        public string UsuarioRegistro
        {
            get { return (str.usuarioRegistro); }
            set { str.usuarioRegistro = value; }
        }
        #endregion

        public DataTable Listar()
        {
            return (adt.Listar());
        }

        public void Seleccionar()
        {
            adt.IdUsuario = this.IdUsuario;
            dtt = adt.Seleccionar();
            if (dtt.Rows.Count == 1)
            {
                this.IdUsuario = Convert.ToInt32(dtt.Rows[0].ItemArray[0]);
                this.IdNivel = Convert.ToInt32(dtt.Rows[0].ItemArray[1]);
                this.Login = dtt.Rows[0].ItemArray[2].ToString();
                this.Password = dtt.Rows[0].ItemArray[3].ToString();
            }

        }

        public void Insertar()
        {
            adt.IdNivel = this.IdNivel;
            adt.Login = this.Login;
            adt.Password = this.Password;
            adt.UsuarioRegistro = this.UsuarioRegistro;

            this.IdUsuario = adt.Insertar();
        }

        public int Eliminar()
        {
            adt.IdUsuario = this.IdUsuario;

            return adt.Eliminar();
        }

        public int Actualizar()
        {
            adt.IdUsuario = this.IdUsuario;
            adt.IdNivel = this.IdNivel;
            adt.Login = this.Login;
            adt.Password = this.Password;
            adt.UsuarioRegistro = this.UsuarioRegistro;

            return adt.Actualizar();
        }

        public string ControlCampos()
        {
            string errores = string.Empty;

            //Verificar que los campos no esten vacios
            if (!ctrl.CampoVacio(Login))
                errores += "Ingrese el Login\n";
            if (!ctrl.CampoVacio(Password))
                errores += "Ingrese la contraseña\n";

            return errores;
        }
    }
}
