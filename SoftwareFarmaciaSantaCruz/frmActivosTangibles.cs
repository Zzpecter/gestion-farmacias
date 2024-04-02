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
    public partial class frmActivosTangibles : Form
    {

        #region variables
        private DataTable dtActivos = new DataTable();
        private LogicaNegocio.Mobiliaria mob = new LogicaNegocio.Mobiliaria();
        private LogicaNegocio.Controladora ctrl = new LogicaNegocio.Controladora();

        private int index = 0;
        private bool cargado = false;
        private string accionActual = string.Empty;
        private float total = 0;

        #endregion

        public frmActivosTangibles()
        {
            InitializeComponent();
        }

        //public frmActivosTangibles(bool secundario)
        //{
        //    InitializeComponent();
        //    this.secundario = secundario;
        //}


        private void Cargar()
        {
            cargado = false;
            dgvActivosTangibles.DataSource = null;
            dtActivos = mob.Listar();
            dgvActivosTangibles.DataSource = dtActivos;
            dgvActivosTangibles.Refresh();

            //dar formato al datagreed
            dgvActivosTangibles.Columns.Remove("idMobiliaria");
            dgvActivosTangibles.ClearSelection();

            total = 0;
            foreach (DataRow dtr in dtActivos.Rows)
                total += Convert.ToInt32(dtr.ItemArray[3]) * Convert.ToSingle(dtr.ItemArray[2]);

            lblValorTotal.Text = "Total: " + total.ToString() + " Bs.";

            cargado = true;
            HabilitarControles(false);
        }


        private void HabilitarControles(bool editar)
        {
            dgvActivosTangibles.Enabled = !editar;

            tbNombre.ReadOnly = !editar;
            tbValor.ReadOnly = !editar;
            tbCantidad.ReadOnly = !editar;

            bGuardar.Visible = editar;
            bCancelar.Visible = editar;

            bAgregar.Enabled = !editar;
            bEditar.Enabled = !editar;
            bEliminar.Enabled = !editar;

            if (accionActual == "agregar")
            {
                tbNombre.Text = string.Empty;
                tbValor.Text = string.Empty;
                tbCantidad.Text = string.Empty;
            }
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frm = new frmMenuPrincipal();
            frm.Show();
            this.Hide();
        }

        private void frmActivosTangibles_Load(object sender, EventArgs e)
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
            string error = string.Empty;
            switch (accionActual)
            {
                case "agregar":
                    {

                        if (!ctrl.CampoVacio(tbNombre.Text))
                            error += "Ingrese un Nombre";
                        if (!ctrl.CampoVacio(tbCantidad.Text))
                            error += "Ingrese una Cantidad";
                        if (!ctrl.CampoVacio(tbValor.Text))
                            error += "Ingrese el Valor";

                        if (error == string.Empty)
                        {
                            mob.Mueble = tbNombre.Text;
                            mob.Valor = Convert.ToSingle(tbValor.Text);
                            mob.Cantidad = Convert.ToInt32(tbCantidad.Text);
                            mob.UsuarioRegistro = LogicaNegocio.SesionActual.Login;
                            mob.Insertar();
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
                            error += "Ingrese un Nombre";
                        if (!ctrl.CampoVacio(tbCantidad.Text))
                            error += "Ingrese una Cantidad";
                        if (!ctrl.CampoVacio(tbValor.Text))
                            error += "Ingrese el Valor";

                        if (err == string.Empty)
                        {
                            mob.Mueble = tbNombre.Text;
                            mob.Valor = Convert.ToInt32(tbValor.Text);
                            mob.Cantidad = Convert.ToInt32(tbCantidad.Text);
                            mob.UsuarioRegistro = LogicaNegocio.SesionActual.Login;
                            
                            mob.Actualizar();
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
            HabilitarControles(false);
        
        }

        private void dgvActivosTangibles_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                index = dgvActivosTangibles.SelectedRows[0].Index;
                mob.IdMobiliaria = Convert.ToInt32(dtActivos.Rows[index].ItemArray[0].ToString());
                mob.Seleccionar();

                tbNombre.Text = mob.Mueble;
                tbValor.Text = mob.Valor.ToString();
                tbCantidad.Text = mob.Cantidad.ToString();
            }
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (dgvActivosTangibles.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Esta seguro de eliminar el Mueble?", "ADVERTENCIA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    mob.Eliminar();

                    cargado = false;
                    Cargar();
                }
            }
        }



    }
}
