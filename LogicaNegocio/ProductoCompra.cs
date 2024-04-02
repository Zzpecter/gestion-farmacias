using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class ProductoCompra
    {
        private Controladora ctrl = new Controladora();
        private strVariables str = new strVariables();
        private AccesoDatos.ProductoCompra adt = new AccesoDatos.ProductoCompra();
        public DataTable dtt = new DataTable();

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

        public DataTable Listar()
        {
            return (adt.Listar());
        }

        public void Seleccionar()
        {
            adt.IdProductoCompra = this.IdProductoCompra;
            dtt = adt.Seleccionar();
            if (dtt.Rows.Count == 1)
            {
                this.IdProductoCompra = Convert.ToInt32(dtt.Rows[0].ItemArray[0]);
                this.IdProducto = Convert.ToInt32(dtt.Rows[0].ItemArray[1]);
                this.IdCompra = Convert.ToInt32(dtt.Rows[0].ItemArray[2]);
                this.FechaVencimiento = Convert.ToDateTime(dtt.Rows[0].ItemArray[3]);
                this.Cantidad = Convert.ToInt32(dtt.Rows[0].ItemArray[4]);
            }

        }

        public DataTable SeleccionarVenc()
        {
            adt.IdProducto = this.IdProducto;
            return (adt.SeleccionarVenc());
        }

        public void Insertar()
        {
            adt.IdProducto = this.IdProducto;
            adt.IdCompra = this.IdCompra;
            adt.FechaVencimiento = this.FechaVencimiento;
            adt.Cantidad = this.Cantidad;
            adt.UsuarioRegistro = this.UsuarioRegistro;

            this.IdProductoCompra = adt.Insertar();
        }

        public int Eliminar()
        {
            adt.IdProductoCompra = this.IdProductoCompra;

            return adt.Eliminar();
        }

        public int Actualizar()
        {
            adt.IdProductoCompra = this.IdProductoCompra;
            adt.IdProducto = this.IdProducto;
            adt.IdCompra = this.IdCompra;
            adt.FechaVencimiento = this.FechaVencimiento;
            adt.Cantidad = this.Cantidad;
            adt.UsuarioRegistro = this.UsuarioRegistro;

            return adt.Actualizar();
        }

        public string ControlCampos()
        {
            string errores = string.Empty;

            //Verificar que los campos no esten vacios
            if (!ctrl.CampoNumerico(Cantidad.ToString()))
                errores += "Ingrese el monto total\n";

            return errores;
        }
    }
}
