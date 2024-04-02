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
    public partial class frmAutenticacion : Form
    {
        #region Variables
        private LogicaNegocio.Autenticacion aut = new LogicaNegocio.Autenticacion();
        private LogicaNegocio.Controladora ctrl = new LogicaNegocio.Controladora();
        private LogicaNegocio.Usuario usr = new LogicaNegocio.Usuario();
        private DataTable dtUsuario = new DataTable();
        #endregion

        #region Carga
        public frmAutenticacion()
        {
            InitializeComponent();
        }

        private void frmAutenticacion_Load(object sender, EventArgs e)
        {
            string estado = aut.ConexionActual();
            LogicaNegocio.SesionActual.NumNotificaciones = 0;
            LogicaNegocio.SesionActual.PrimerLogin = true;
            if (estado.Equals("Conexion BDD: OK"))
                lblConectado.Text = estado;
            else
            {
                lblConectado.Text = "Conexion BDD: Fallida";
                MessageBox.Show(estado);
                bEntrar.Enabled = false;
            }
        }
        #endregion

        #region Botones
        private void bSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bEntrar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }
        #endregion

        #region Otros Métodos
        private void Ingresar()
        {
            if (ctrl.CampoVacio(tbUsuario.Text) && ctrl.CampoVacio(tbPassword.Text))
            {
                string pass = aut.HashPassword(tbPassword.Text);
                string res = aut.BuscarUsuario(tbUsuario.Text, pass);

                if (res.Equals(string.Empty))
                {
                    dtUsuario = usr.Listar();

                    foreach (DataRow dtr in dtUsuario.Rows)
                        if (dtr.ItemArray[2].ToString().Equals(tbUsuario.Text))
                        {
                            LogicaNegocio.SesionActual.IdUsuario = Convert.ToInt32(dtr.ItemArray[0].ToString());
                            LogicaNegocio.SesionActual.IdNivel = Convert.ToInt32(dtr.ItemArray[1].ToString());
                            LogicaNegocio.SesionActual.Login = dtr.ItemArray[2].ToString();
                            break;
                        }

                    frmMenuPrincipal menu = new frmMenuPrincipal();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(res, "Error", MessageBoxButtons.OK);
                }
            }
            else if (!ctrl.CampoVacio(tbUsuario.Text) || !ctrl.CampoVacio(tbPassword.Text))
                MessageBox.Show("Llene los campos!", "Error", MessageBoxButtons.OK);
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                Ingresar();
        }
        #endregion
    }
}
