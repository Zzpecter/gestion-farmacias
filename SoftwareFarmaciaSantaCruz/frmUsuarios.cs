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
    public partial class frmUsuarios : Form
    {
        #region Variables
        private LogicaNegocio.Usuario usr = new LogicaNegocio.Usuario();
        private LogicaNegocio.Nivel nivel = new LogicaNegocio.Nivel();
        private LogicaNegocio.Controladora ctrl = new LogicaNegocio.Controladora();
        private LogicaNegocio.Autenticacion aut = new LogicaNegocio.Autenticacion();

        private DataTable dtUsuario = new DataTable();
        private DataTable dtNivel = new DataTable();

        private string accionActual = string.Empty;
        private bool cargado = false;
        private int index = 0;
        private string pass = string.Empty;
        #endregion

        #region Carga
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            cargado = false;
            dgvUsuarios.DataSource = null;
            dtUsuario = usr.Listar();
            dgvUsuarios.DataSource = dtUsuario;

            cmbNivel.Items.Clear();
            dtNivel = nivel.Listar();
            foreach (DataRow dtr in dtNivel.Rows)
                cmbNivel.Items.Add(dtr.ItemArray[1]);

            dgvUsuarios.Columns.Remove("idUsuario");
            dgvUsuarios.Columns.Remove("idNivel");
            dgvUsuarios.Columns.Remove("password");


            ActivarControles(false);

            DeshabilitarOrdenamiento();
            dgvUsuarios.ClearSelection();
            cargado = true;
            cmbNivel.SelectedIndex = 0;
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvUsuarios.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        public void ActivarControles(bool editando)
        {
            bCancelar.Enabled = editando;
            tbNombre.ReadOnly = !editando;
            tbPass.ReadOnly = !editando;
            cmbNivel.Enabled = editando;
            bGuardar.Enabled = editando;
            bCancelar.Enabled = editando;
            bAgregar.Enabled = !editando;
            bEditar.Enabled = !editando;
            bEliminar.Enabled = !editando;
            dgvUsuarios.Enabled = !editando;

            if (accionActual.Equals("agregar"))
            {
                tbNombre.Text = string.Empty;
                tbPass.Text = string.Empty;
                cmbNivel.SelectedIndex = 0;
            }
        }
        #endregion

        #region Botones
        private void bVolver_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frm = new frmMenuPrincipal();
            frm.Show();
            this.Hide();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            accionActual = "agregar";
            ActivarControles(true);  
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            accionActual = "editar";
            ActivarControles(true);
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Esta seguro que desea eliminar el usuario seleccionado?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    usr.Eliminar();
                    Cargar();
                }
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            ActivarControles(false);
            dgvUsuarios.ClearSelection();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            string error = string.Empty;
            usr.UsuarioRegistro = LogicaNegocio.SesionActual.Login;
            switch (accionActual)
            {
                case "agregar":
                    {
                        string err = string.Empty;
                        if (!ctrl.CampoVacio(tbNombre.Text))
                            err += "Ingrese un Login";
                        if (!ctrl.CampoVacio(tbPass.Text))
                            err += "Ingrese una Constraseña";

                        if (error == string.Empty)
                        {
                            //inserta en la base de datos
                            usr.Login = tbNombre.Text;
                            usr.Password = aut.HashPassword(tbPass.Text);
                            usr.Insertar();
                        }
                        else
                        {
                            MessageBox.Show(error, "Error", MessageBoxButtons.OK);
                        }
                    } break;

                case "editar":
                    {
                        string err = string.Empty;
                        if (!ctrl.CampoVacio(tbNombre.Text))
                            err += "Ingrese un Login";
                        if (!ctrl.CampoVacio(tbPass.Text))
                            err += "Ingrese una Constraseña";

                        if (err == string.Empty)
                        {
                            //inserta en la base de datos
                            usr.Login = tbNombre.Text;
                            if(!tbPass.Text.Equals( "******"))
                                usr.Password = aut.HashPassword(tbPass.Text);
                            usr.Actualizar();
                        }
                        else
                        {
                            MessageBox.Show(error, "Error", MessageBoxButtons.OK);
                        }

                    } break;

                default: break;
            }
            cargado = false;
            Cargar();
            ActivarControles(false);
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                index = dgvUsuarios.SelectedRows[0].Index;
                usr.IdUsuario = Convert.ToInt32(dtUsuario.Rows[index].ItemArray[0].ToString());
                usr.Seleccionar();

                //Llena el textbox
                tbNombre.Text = usr.Login;
                tbPass.Text = "******";

                cmbNivel.SelectedText = dtUsuario.Rows[index].ItemArray[4].ToString();
            }
        }

        private void cmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                index = cmbNivel.SelectedIndex;
                usr.IdNivel = Convert.ToInt32(dtNivel.Rows[index].ItemArray[0].ToString());
            }
        }
        #endregion

        
    }
}
