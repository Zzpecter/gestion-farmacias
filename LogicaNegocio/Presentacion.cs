using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Presentacion
    {
        private Controladora ctrl = new Controladora();
        private strVariables str = new strVariables();
        private AccesoDatos.Presentacion adt = new AccesoDatos.Presentacion();
        public DataTable dtt = new DataTable();

        #region gets sets struct
        private struct strVariables
        {
            public int idPresentacion;
            public string presentacion;
            public string usuarioRegistro;
        }

        public int IdPresentacion
        {
            get { return (str.idPresentacion); }
            set { str.idPresentacion = value; }
        }

        public string PresentacionProducto
        {
            get { return (str.presentacion); }
            set { str.presentacion = value; }
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
            adt.IdPresentacion = this.IdPresentacion;
            dtt = adt.Seleccionar();
            if (dtt.Rows.Count == 1)
            {
                this.IdPresentacion = Convert.ToInt32(dtt.Rows[0].ItemArray[0]);
                this.PresentacionProducto = dtt.Rows[0].ItemArray[1].ToString();
            }
        }

        public void Insertar()
        {
            adt.PresentacionProducto = this.PresentacionProducto;
            adt.UsuarioRegistro = this.UsuarioRegistro;

            this.IdPresentacion = adt.Insertar();
        }

        public int Eliminar()
        {
            adt.IdPresentacion = this.IdPresentacion;

            return adt.Eliminar();
        }

        public int Actualizar()
        {
            adt.IdPresentacion = this.IdPresentacion;
            adt.PresentacionProducto = this.PresentacionProducto;
            adt.UsuarioRegistro = this.UsuarioRegistro;

            return adt.Actualizar();
        }

        public string ControlCampos()
        {
            string errores = string.Empty;

            //Verificar que los campos no esten vacios
            if (!ctrl.CampoVacio(PresentacionProducto.ToString()))
                errores += "Ingrese la presentacion\n";

            return errores;
        }
    }
}
