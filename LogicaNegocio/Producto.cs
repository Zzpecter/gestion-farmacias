using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Producto
    {
        private Controladora ctrl = new Controladora();
        private strVariables str = new strVariables();
        private AccesoDatos.Producto adt = new AccesoDatos.Producto();
        public DataTable dtt = new DataTable();

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

        public DataTable Listar()
        {
            return (adt.Listar());
        }

        public DataTable Buscar(string consulta)
        {
            return (adt.Buscar(consulta));
        }

        public void Seleccionar()
        {
            adt.IdProducto = this.IdProducto;
            dtt = adt.Seleccionar();
            if (dtt.Rows.Count == 1)
            {
                this.IdProducto = Convert.ToInt32(dtt.Rows[0].ItemArray[0]);
                this.IdLaboratorio = Convert.ToInt32(dtt.Rows[0].ItemArray[1]);
                this.IdPresentacion = Convert.ToInt32(dtt.Rows[0].ItemArray[2]);
                this.Nombre = dtt.Rows[0].ItemArray[3].ToString();
                this.Descripcion = dtt.Rows[0].ItemArray[4].ToString();
                this.PrecioCompra = Convert.ToDecimal(dtt.Rows[0].ItemArray[5]);
                this.PrecioVenta = Convert.ToDecimal(dtt.Rows[0].ItemArray[6]);
                this.Stock = Convert.ToInt32(dtt.Rows[0].ItemArray[7]);
            }
        }

        public void Insertar()
        {
            adt.IdLaboratorio = this.IdLaboratorio;
            adt.IdPresentacion = this.IdPresentacion;
            adt.Nombre = this.Nombre;
            adt.Descripcion = this.Descripcion;
            adt.PrecioCompra = this.PrecioCompra;
            adt.PrecioVenta = this.PrecioVenta;
            adt.Stock = this.Stock;
            adt.UsuarioRegistro = this.UsuarioRegistro;

            this.IdProducto = adt.Insertar();
        }

        public int Eliminar()
        {
            adt.IdProducto = this.IdProducto;

            return adt.Eliminar();
        }

        public int Actualizar()
        {
            adt.IdProducto = this.IdProducto; 
            adt.IdLaboratorio = this.IdLaboratorio;
            adt.IdPresentacion = this.IdPresentacion;
            adt.Nombre = this.Nombre;
            adt.Descripcion = this.Descripcion;
            adt.PrecioCompra = this.PrecioCompra;
            adt.PrecioVenta = this.PrecioVenta;
            adt.Stock = this.Stock;
            adt.UsuarioRegistro = this.UsuarioRegistro;

            return adt.Actualizar();
        }

        public string ControlCampos()
        {
            string errores = string.Empty;

            //Verificar que los campos no esten vacios
            if (!ctrl.CampoVacio(Nombre.ToString()))
                errores += "Ingrese el nombre\n";

            return errores;
        }
    }
}
