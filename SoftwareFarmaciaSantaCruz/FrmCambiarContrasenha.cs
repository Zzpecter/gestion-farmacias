using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareFarmaciaSantaCruz
{
    public partial class FrmCambiarContrasenha : Form
    {
        private LogicaNegocio.Controladora ctrl = new LogicaNegocio.Controladora();
        private LogicaNegocio.Usuario usr = new LogicaNegocio.Usuario();
        private LogicaNegocio.Autenticacion aut = new LogicaNegocio.Autenticacion();

        public FrmCambiarContrasenha()
        {
            InitializeComponent();
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            string errores = string.Empty;
            if (!ctrl.CampoVacio(tbPass2.Text) || !ctrl.CampoVacio(tbPass1.Text))
                errores = "Llene todos los campos \n";
            if (!ctrl.CamposIguales(tbPass1.Text, tbPass2.Text))
                errores = "Las contraseñas no coinciden \n";

            if (errores.Equals(string.Empty))
            {
                usr.IdUsuario = LogicaNegocio.SesionActual.IdUsuario;
                usr.Seleccionar();
                usr.UsuarioRegistro = LogicaNegocio.SesionActual.Login;
                usr.Password = aut.HashPassword(tbPass1.Text);
                usr.Actualizar();

                MessageBox.Show("Contraseña actualizada correctamente!");
                this.Hide();
            }
            else
            {
                tbPass1.Text = string.Empty;
                tbPass2.Text = string.Empty;
                MessageBox.Show(errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
