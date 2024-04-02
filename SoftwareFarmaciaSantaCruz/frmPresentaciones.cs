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
    public partial class frmPresentaciones : Form
    {


        #region variables
        private DataTable dtPresentacion = new DataTable();
        private LogicaNegocio.Presentacion pre = new LogicaNegocio.Presentacion();
        private LogicaNegocio.Controladora ctrl = new LogicaNegocio.Controladora();

        private int index = 0;
        private bool cargado = false;
        private bool error = false;
        private string accionActual = string.Empty;

        #endregion

        public frmPresentaciones()
        {
            InitializeComponent();
        }

        private void Cargar()
        {
            cargado = false;
            dgvPresentaciones.DataSource = null;
            dtPresentacion = pre.Listar();
            dgvPresentaciones.DataSource = dtPresentacion;
            dgvPresentaciones.Refresh();

            //dar formato al datagreed
            dgvPresentaciones.Columns.Remove("idPresentacion");
            dgvPresentaciones.ClearSelection();
            cargado = true;
            HabilitarControles(false);
        }


        private void HabilitarControles(bool editar)
        {
            dgvPresentaciones.Enabled = !editar;

            tbNombre.ReadOnly = !editar;

            bGuardar.Visible = editar;
            bCancelar.Visible = editar;

            bAgregar.Enabled = !editar;
            bEditar.Enabled = !editar;
            bEliminar.Enabled = !editar;

            if (accionActual == "agregar")
            {
                tbNombre.Text = string.Empty;
            }
        }


        private void bVolver_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frm = new frmMenuPrincipal();
            frm.Show();
            this.Hide();
        }

        private void frmPresentaciones_Load(object sender, EventArgs e)
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

                        if (error)
                        {
                            pre.PresentacionProducto = tbNombre.Text;
                            pre.UsuarioRegistro = LogicaNegocio.SesionActual.Login;

                            pre.Insertar();
                        }

                        else
                            MessageBox.Show("Ingrese una nombre");
                    } break;
                case "editar":
                    {
                        error = ctrl.CampoVacio(tbNombre.Text);

                        if (error)
                        {
                            pre.PresentacionProducto = tbNombre.Text;
                            pre.UsuarioRegistro = LogicaNegocio.SesionActual.Login;
                            pre.Actualizar();

                        }

                        else
                            MessageBox.Show("Ingrese un nombre");


                    } break;
                default: break;

            }

            cargado = false;
            Cargar();
            HabilitarControles(false);
        
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPresentaciones.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Esta seguro de eliminar la presentacion?", "ADVERTENCIA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    pre.Eliminar();

                    cargado = false;
                    Cargar();
                }
            }
        }

        private void dgvPresentaciones_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                index = dgvPresentaciones.SelectedRows[0].Index;
                pre.IdPresentacion = Convert.ToInt32(dtPresentacion.Rows[index].ItemArray[0].ToString());
                pre.Seleccionar();

                tbNombre.Text = pre.PresentacionProducto;
            }
        }


    }
}
