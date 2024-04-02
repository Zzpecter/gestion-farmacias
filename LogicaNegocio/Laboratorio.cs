using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Laboratorio
    {
        private Controladora ctrl = new Controladora();
        private strVariables str = new strVariables();
        private AccesoDatos.Laboratorio adt = new AccesoDatos.Laboratorio();
        public DataTable dtt = new DataTable();

        #region gets sets struct
        private struct strVariables
        {
            public int idLaboratorio;
            public string laboratorio;
            public string telefono;
            public string correo;
            public string usuarioRegistro;
        }

        public int IdLaboratorio
        {
            get { return (str.idLaboratorio); }
            set { str.idLaboratorio = value; }
        }

        public string Lab
        {
            get { return (str.laboratorio); }
            set { str.laboratorio = value; }
        }

        public string Telefono
        {
            get { return (str.telefono); }
            set { str.telefono = value; }
        }

        public string Correo
        {
            get { return (str.correo); }
            set { str.correo = value; }
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
            adt.IdLaboratorio = this.IdLaboratorio;
            dtt = adt.Seleccionar();
            if (dtt.Rows.Count == 1)
            {
                this.IdLaboratorio = Convert.ToInt32(dtt.Rows[0].ItemArray[0]);
                this.Lab = dtt.Rows[0].ItemArray[1].ToString();
                this.Telefono = dtt.Rows[0].ItemArray[2].ToString();
                this.Correo = dtt.Rows[0].ItemArray[3].ToString();
            }

        }

        public void Insertar()
        {
            adt.Lab = this.Lab;
            adt.Telefono = this.Telefono;
            adt.Correo = this.Correo;
            adt.UsuarioRegistro = this.UsuarioRegistro;

            this.IdLaboratorio = adt.Insertar();
        }

        public int Eliminar()
        {
            adt.IdLaboratorio = this.IdLaboratorio;

            return adt.Eliminar();
        }

        public int Actualizar()
        {
            adt.IdLaboratorio = this.IdLaboratorio;
            adt.Lab = this.Lab;
            adt.Telefono = this.Telefono;
            adt.Correo = this.Correo;
            adt.UsuarioRegistro = this.UsuarioRegistro;

            return adt.Actualizar();
        }

        public string ControlCampos()
        {
            string errores = string.Empty;

            //Verificar que los campos no esten vacios
            if (!ctrl.CampoVacio(Lab.ToString()))
                errores += "Ingrese el nombre del laboratorio\n";

            return errores;
        }
    }
}
