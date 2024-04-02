using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Mobiliaria
    {
        private Controladora ctrl = new Controladora();
        private strVariables str = new strVariables();
        private AccesoDatos.Mobiliaria adt = new AccesoDatos.Mobiliaria();
        public DataTable dtt = new DataTable();

        #region gets sets struct
        private struct strVariables
        {
            public int idMobiliaria;
            public string mueble;
            public float valor;
            public int cantidad;
            public string usuarioRegistro;
        }

        public int IdMobiliaria
        {
            get { return (str.idMobiliaria); }
            set { str.idMobiliaria = value; }
        }

        public string Mueble
        {
            get { return (str.mueble); }
            set { str.mueble = value; }
        }

        public float Valor
        {
            get { return (str.valor); }
            set { str.valor = value; }
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
            adt.IdMobiliaria = this.IdMobiliaria;
            dtt = adt.Seleccionar();
            if (dtt.Rows.Count == 1)
            {
                this.IdMobiliaria = Convert.ToInt32(dtt.Rows[0].ItemArray[0]);
                this.Mueble = dtt.Rows[0].ItemArray[1].ToString();
                this.Valor = Convert.ToSingle(dtt.Rows[0].ItemArray[2]);
                this.Cantidad = Convert.ToInt32(dtt.Rows[0].ItemArray[3]);
            }

        }

        public void Insertar()
        {
            adt.Mueble = this.Mueble;
            adt.Valor = this.Valor;
            adt.Cantidad = this.Cantidad;
            adt.UsuarioRegistro = this.UsuarioRegistro;

            this.IdMobiliaria = adt.Insertar();
        }

        public int Eliminar()
        {
            adt.IdMobiliaria = this.IdMobiliaria;

            return adt.Eliminar();
        }

        public int Actualizar()
        {
            adt.IdMobiliaria = this.IdMobiliaria;
            adt.Mueble = this.Mueble;
            adt.Valor = this.Valor;
            adt.Cantidad = this.Cantidad;
            adt.UsuarioRegistro = this.UsuarioRegistro;

            return adt.Actualizar();
        }

        public string ControlCampos()
        {
            string errores = string.Empty;

            //Verificar que los campos no esten vacios
            if (!ctrl.CampoVacio(Mueble.ToString()))
                errores += "Ingrese el nombre del mueble\n";

            return errores;
        }
    }
}
