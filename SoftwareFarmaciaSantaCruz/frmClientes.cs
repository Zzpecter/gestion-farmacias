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
    public partial class frmClientes : Form
    {

        #region variables
        private DataTable dtCliente = new DataTable();
        private LogicaNegocio.Cliente cli = new LogicaNegocio.Cliente();
        private LogicaNegocio.Controladora ctrl = new LogicaNegocio.Controladora();

        private int index = 0;
        private bool cargado = false;
        private bool error = false;
        private string accionActual = string.Empty;

        #endregion


        public frmClientes()
        {
            InitializeComponent();
        }

        private void Cargar()
        {
            cargado = false;
            dgvClientes.DataSource = null;
            dtCliente = cli.Listar();
            dgvClientes.DataSource = dtCliente;
            dgvClientes.Refresh();

            dgvClientes.Columns.Remove("idCliente");
            dgvClientes.ClearSelection();


            cargado = true;
            HabilitarControles(false);
        }

        private void HabilitarControles(bool editar)
        {
            dgvClientes.Enabled = !editar;
            dgvClientes.ReadOnly = !editar;

            tbNit.ReadOnly = !editar;
            tbNombre.ReadOnly = !editar;

            bGuardar.Visible = editar;
            bCancelar.Visible = editar;

            bAgregar.Enabled = !editar;
            bEditar.Enabled = !editar;
            bEliminar.Enabled = !editar;

            if (accionActual == "agregar")
            {
                tbNombre.Text = string.Empty;
                tbNit.Text = string.Empty;

            }
        }



        private void bVolver_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frm = new frmMenuPrincipal();
            frm.Show();
            this.Hide();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            accionActual = "agregar";
            HabilitarControles(true);
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            accionActual = "editar";
            HabilitarControles(true);
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            HabilitarControles(false);
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            switch (accionActual)
            {
                case "agregar":
                    {
                        error = ctrl.CampoVacio(tbNombre.Text);
                        error = ctrl.CampoVacio(tbNit.Text);

                        if (error)
                        {
                            cli.Nombre = tbNombre.Text;
                            cli.Nit = tbNit.Text;
                            cli.UsuarioRegistro = LogicaNegocio.SesionActual.Login;
                            cli.Insertar();

                        }

                        else
                            MessageBox.Show("LLene el campo vacio");
                    } break;
                case "editar":
                    {
                        error = ctrl.CampoVacio(tbNombre.Text);
                        error = ctrl.CampoVacio(tbNit.Text);

                        if (error)
                        {
                            cli.Nombre = tbNombre.Text;
                            cli.Nit = tbNit.Text;
                            cli.UsuarioRegistro = LogicaNegocio.SesionActual.Login;
                            cli.Actualizar();

                        }

                        else
                            MessageBox.Show("Llene el campo vacio");


                    } break;
                default: break;

            }

            cargado = false;
            Cargar();
            HabilitarControles(false);
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Esta seguro de eliminar el Cliente?", "ADVERTENCIA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cli.Eliminar();

                    cargado = false;
                    Cargar();
                }
            }
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                index = dgvClientes.SelectedRows[0].Index;
                cli.IdCliente = Convert.ToInt32(dtCliente.Rows[index].ItemArray[0].ToString());
                cli.Seleccionar();

                //Llena el textbox
                tbNombre.Text = cli.Nombre;
                tbNit.Text = cli.Nit.ToString();
            }
        }
    }
}
