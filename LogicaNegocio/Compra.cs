using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Compra
    {
        private Controladora ctrl = new Controladora();
        private strVariables str = new strVariables();
        private AccesoDatos.Compra adt = new AccesoDatos.Compra();
        public DataTable dtt = new DataTable();

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

        public DataTable Listar()
        {
            return (adt.Listar());
        }

        public void Seleccionar()
        {
            adt.IdCompra = this.IdCompra;
            dtt = adt.Seleccionar();
            if (dtt.Rows.Count == 1)
            {
                this.IdCompra = Convert.ToInt32(dtt.Rows[0].ItemArray[0]);
                this.IdUsuario = Convert.ToInt32(dtt.Rows[0].ItemArray[1]);
                this.Fecha = Convert.ToDateTime(dtt.Rows[0].ItemArray[2]);
                this.MontoTotal = Convert.ToDecimal(dtt.Rows[0].ItemArray[3]);
            }

        }

        public void Insertar()
        {
            adt.IdUsuario = this.IdUsuario;
            adt.Fecha = this.Fecha;
            adt.MontoTotal = this.MontoTotal;
            adt.UsuarioRegistro = this.UsuarioRegistro;

            this.IdCompra = adt.Insertar();
        }

        public int Eliminar()
        {
            adt.IdCompra = this.IdCompra;

            return adt.Eliminar();
        }

        public int Actualizar()
        {
            adt.IdCompra = this.IdCompra;
            adt.IdUsuario = this.IdUsuario;
            adt.Fecha = this.Fecha;
            adt.MontoTotal = this.MontoTotal;
            adt.UsuarioRegistro = this.UsuarioRegistro;

            return adt.Actualizar();
        }

        public string ControlCampos()
        {
            string errores = string.Empty;


            return errores;
        }
    }
}
