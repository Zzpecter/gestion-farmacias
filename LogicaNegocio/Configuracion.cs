using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Configuracion
    {
        private Controladora ctrl = new Controladora();
        private strVariables str = new strVariables();
        private AccesoDatos.Configuracion adt = new AccesoDatos.Configuracion();
        public DataTable dtt = new DataTable();

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

        public DataTable Listar()
        {
            return (adt.Listar());
        }

        public int Actualizar()
        {
            adt.TasaVenta = this.TasaVenta;
            adt.Iva = this.Iva;
            adt.It = this.It;
            adt.UsuarioRegistro = this.UsuarioRegistro;

            return adt.Actualizar();
        }
    }
}
