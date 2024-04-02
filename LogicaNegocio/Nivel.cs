using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Nivel
    {
        private Controladora ctrl = new Controladora();
        private strVariables str = new strVariables();
        private AccesoDatos.Nivel adt = new AccesoDatos.Nivel();
        public DataTable dtt = new DataTable();

        #region gets sets struct
        private struct strVariables
        {
            public int idNivel;
            public string nivelUsuario;
            public string usuarioRegistro;
        }

        public int IdNivel
        {
            get { return (str.idNivel); }
            set { str.idNivel = value; }
        }

        public string NivelUsuario
        {
            get { return (str.nivelUsuario); }
            set { str.nivelUsuario = value; }
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
            adt.IdNivel = this.IdNivel;
            dtt = adt.Seleccionar();
            if (dtt.Rows.Count == 1)
            {
                this.IdNivel = Convert.ToInt32(dtt.Rows[0].ItemArray[0]);
                this.NivelUsuario = dtt.Rows[0].ItemArray[1].ToString();
            }

        }

        public void Insertar()
        {
            adt.NivelUsuario = this.NivelUsuario;
            adt.UsuarioRegistro = this.UsuarioRegistro;

            this.IdNivel = adt.Insertar();
        }

        public int Eliminar()
        {
            adt.IdNivel = this.IdNivel;

            return adt.Eliminar();
        }

        public int Actualizar()
        {
            adt.IdNivel = this.IdNivel;
            adt.NivelUsuario = this.NivelUsuario;
            adt.UsuarioRegistro = this.UsuarioRegistro;

            return adt.Actualizar();
        }

        public string ControlCampos()
        {
            string errores = string.Empty;

            //Verificar que los campos no esten vacios
            if (!ctrl.CampoVacio(NivelUsuario.ToString()))
                errores += "Ingrese el nivel\n";

            return errores;
        }
    }
}
