using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Cliente
    {
        private Controladora ctrl = new Controladora();
        private strVariables str = new strVariables();
        private AccesoDatos.Cliente adt = new AccesoDatos.Cliente();
        public DataTable dtt = new DataTable();

        #region gets sets struct
        private struct strVariables
        {
            public int idCliente;
            public string nit;
            public string nombre;
            public string usuarioRegistro;
        }

        public int IdCliente
        {
            get { return (str.idCliente); }
            set { str.idCliente = value; }
        }

        public string Nit
        {
            get { return (str.nit); }
            set { str.nit = value; }
        }

        public string Nombre
        {
            get { return (str.nombre); }
            set { str.nombre = value; }
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
            adt.IdCliente = this.IdCliente;
            dtt = adt.Seleccionar();
            if (dtt.Rows.Count == 1)
            {
                this.IdCliente = Convert.ToInt32(dtt.Rows[0].ItemArray[0]);
                this.Nit = dtt.Rows[0].ItemArray[1].ToString();
                this.Nombre = dtt.Rows[0].ItemArray[2].ToString();
            }

        }

        public void Insertar()
        {
            adt.Nit = this.Nit;
            adt.Nombre = this.Nombre;
            adt.UsuarioRegistro = this.UsuarioRegistro;

            this.IdCliente = adt.Insertar();
        }

        public int Eliminar()
        {
            adt.IdCliente = this.IdCliente;

            return adt.Eliminar();
        }

        public int Actualizar()
        {
            adt.IdCliente = this.IdCliente;
            adt.Nit = this.Nit;
            adt.Nombre = this.Nombre;
            adt.UsuarioRegistro = this.UsuarioRegistro;

            return adt.Actualizar();
        }

        public string ControlCampos()
        {
            string errores = string.Empty;

            //Verificar que los campos no esten vacios
            if (!ctrl.CampoVacio(Nombre.ToString()))
                errores += "Ingrese el nombre del cliente\n";
            if (!ctrl.CampoVacio(Nit.ToString()))
                errores += "Ingrese el nit del cliente\n";

            return errores;
        }
    }
}
