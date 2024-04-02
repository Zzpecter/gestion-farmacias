using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Venta
    {
        private Controladora ctrl = new Controladora();
        private strVariables str = new strVariables();
        private AccesoDatos.Venta adt = new AccesoDatos.Venta();
        public DataTable dtt = new DataTable();

        #region gets sets struct
        private struct strVariables
        {
            public int idVenta;
            public int idCliente;
            public int idUsuario;
            public DateTime fecha;
            public decimal montoTotal;
            public string usuarioRegistro;
        }

        public int IdVenta
        {
            get { return (str.idVenta); }
            set { str.idVenta = value; }
        }

        public int IdCliente
        {
            get { return (str.idCliente); }
            set { str.idCliente = value; }
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
            adt.IdVenta = this.IdVenta;
            dtt = adt.Seleccionar();
            if (dtt.Rows.Count == 1)
            {
                this.IdVenta = Convert.ToInt32(dtt.Rows[0].ItemArray[0]);
                this.IdCliente = Convert.ToInt32(dtt.Rows[0].ItemArray[1]);
                this.IdUsuario = Convert.ToInt32(dtt.Rows[0].ItemArray[2]);
                this.Fecha = Convert.ToDateTime(dtt.Rows[0].ItemArray[3]);
                this.MontoTotal = Convert.ToDecimal(dtt.Rows[0].ItemArray[4]);
            }

        }

        public void SeleccionarUltimo()
        {
            dtt = adt.SeleccionarUltimo();
            if (dtt.Rows.Count == 1)
            {
                this.IdVenta = Convert.ToInt32(dtt.Rows[0].ItemArray[0]);
                this.IdCliente = Convert.ToInt32(dtt.Rows[0].ItemArray[1]);
                this.IdUsuario = Convert.ToInt32(dtt.Rows[0].ItemArray[2]);
                this.Fecha = Convert.ToDateTime(dtt.Rows[0].ItemArray[3]);
                this.MontoTotal = Convert.ToDecimal(dtt.Rows[0].ItemArray[4]);
            }

        }

        public void Insertar()
        {
            adt.IdCliente = this.IdCliente;
            adt.IdUsuario = this.IdUsuario;
            adt.Fecha = this.Fecha;
            adt.MontoTotal = this.MontoTotal;
            adt.UsuarioRegistro = this.UsuarioRegistro;

            this.IdVenta = adt.Insertar();
        }

        public int Eliminar()
        {
            adt.IdVenta = this.IdVenta;

            return adt.Eliminar();
        }

        public int Actualizar()
        {
            adt.IdVenta = this.IdVenta;
            adt.IdCliente = this.IdCliente;
            adt.IdUsuario = this.IdUsuario;
            adt.Fecha = this.Fecha;
            adt.MontoTotal = this.MontoTotal;
            adt.UsuarioRegistro = this.UsuarioRegistro;

            return adt.Actualizar();
        }

        public string ControlCampos()
        {
            string errores = string.Empty;

            //Verificar que los campos no esten vacios
            if (!ctrl.CampoNumerico(MontoTotal.ToString()))
                errores += "Ingrese el monto total\n";

            return errores;
        }
    }
}
