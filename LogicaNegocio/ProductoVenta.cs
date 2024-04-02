using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class ProductoVenta
    {
        private Controladora ctrl = new Controladora();
        private strVariables str = new strVariables();
        private AccesoDatos.ProductoVenta adt = new AccesoDatos.ProductoVenta();
        public DataTable dtt = new DataTable();

        #region gets sets struct
        private struct strVariables
        {
            public int idProductoVenta;
            public int idProducto;
            public int idVenta;
            public int cantidad;
            public string usuarioRegistro;
        }

        public int IdProductoVenta
        {
            get { return (str.idProductoVenta); }
            set { str.idProductoVenta = value; }
        }

        public int IdProducto
        {
            get { return (str.idProducto); }
            set { str.idProducto = value; }
        }

        public int IdVenta
        {
            get { return (str.idVenta); }
            set { str.idVenta = value; }
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
            adt.IdProductoVenta = this.IdProductoVenta;
            dtt = adt.Seleccionar();
            if (dtt.Rows.Count == 1)
            {
                this.IdProductoVenta = Convert.ToInt32(dtt.Rows[0].ItemArray[0]);
                this.IdProducto = Convert.ToInt32(dtt.Rows[0].ItemArray[1]);
                this.IdVenta = Convert.ToInt32(dtt.Rows[0].ItemArray[2]);
                this.Cantidad = Convert.ToInt32(dtt.Rows[0].ItemArray[3]);
            }

        }

        public void Insertar()
        {
            adt.IdProducto = this.IdProducto;
            adt.IdVenta = this.IdVenta;
            adt.Cantidad = this.Cantidad;
            adt.UsuarioRegistro = this.UsuarioRegistro;

            this.IdProductoVenta = adt.Insertar();
        }

        public int Eliminar()
        {
            adt.IdProductoVenta = this.IdProductoVenta;

            return adt.Eliminar();
        }

        public int Actualizar()
        {
            adt.IdProductoVenta = this.IdProductoVenta;
            adt.IdProducto = this.IdProducto;
            adt.IdVenta = this.IdVenta;
            adt.Cantidad = this.Cantidad;
            adt.UsuarioRegistro = this.UsuarioRegistro;

            return adt.Actualizar();
        }

        public string ControlCampos()
        {
            string errores = string.Empty;

            //Verificar que los campos no esten vacios
            if (!ctrl.CampoNumerico(Cantidad.ToString()))
                errores += "Ingrese la cantidad\n";

            return errores;
        }
    }
}
