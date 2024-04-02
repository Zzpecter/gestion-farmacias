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
    public partial class frmProductos : Form
    {
        #region Variables
        private DataTable dtProductos = new DataTable();
        private DataTable dtLab = new DataTable();
        private DataTable dtPresentacion = new DataTable();
        private LogicaNegocio.Producto producto = new LogicaNegocio.Producto();
        private LogicaNegocio.Laboratorio lab = new LogicaNegocio.Laboratorio();
        private LogicaNegocio.Presentacion presentacion = new LogicaNegocio.Presentacion();
        private LogicaNegocio.Controladora ctrl = new LogicaNegocio.Controladora();

        private int index = 0;
        private bool cargado = false;
        private string error = string.Empty;
        private string accionActual = string.Empty;
        #endregion

        #region Carga
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            cargado = false;
            dgvProductos.DataSource = null;
            dtProductos = producto.Listar();
            dgvProductos.DataSource = dtProductos;
            dgvProductos.Refresh();

            dtLab = lab.Listar();
            dtPresentacion = presentacion.Listar();

            cmbLaboratorio.Items.Clear();
            cmbPresentacion.Items.Clear();

            foreach (DataRow dtr in dtLab.Rows)
                cmbLaboratorio.Items.Add(dtr.ItemArray[1]);
            foreach (DataRow dtr in dtPresentacion.Rows)
                cmbPresentacion.Items.Add(dtr.ItemArray[1]);

            dgvProductos.Columns.Remove("idLaboratorio");
            dgvProductos.Columns.Remove("idPresentacion");
            dgvProductos.Columns.Remove("descripcion");

            dgvProductos.Columns[0].HeaderText = "Codigo Inventario";

            dgvProductos.ClearSelection();


            cargado = true;
            HabilitarControles(false);
        }

        private void HabilitarControles(bool editar)
        {
            dgvProductos.Enabled = !editar;

            tbPrecioCompra.ReadOnly = !editar;
            tbPrecioVenta.ReadOnly = !editar;
            tbMedicamento.ReadOnly = !editar;
            tbDescripcion.ReadOnly = !editar;

            cmbPresentacion.Enabled = editar;
            cmbLaboratorio.Enabled = editar;

            bGuardar.Visible = editar;
            bCancelar.Visible = editar;

            bAgregar.Enabled = !editar;
            bEditar.Enabled = !editar;
            bEliminar.Enabled = !editar;

            if (accionActual == "agregar")
            {
                tbMedicamento.Text = string.Empty;
                tbPrecioCompra.Text = string.Empty;
                tbPrecioVenta.Text = string.Empty;
                tbDescripcion.Text = string.Empty;
                cmbPresentacion.SelectedIndex = 0;
                cmbLaboratorio.SelectedIndex = 0;
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
            HabilitarControles(true);  
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            accionActual = "editar";
            HabilitarControles(true);
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Esta seguro que desea eliminar el producto seleccionado? El Stock del mismo sera perdido sin registro de compra o venta", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    producto.Eliminar();
                    Cargar();
                }
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            HabilitarControles(false);
            cargado = false;
            dgvProductos.ClearSelection();
            cargado = true;
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            switch (accionActual)
            {
                case "agregar":
                    {
                        string err = string.Empty;
                        if (!ctrl.CampoVacio(tbMedicamento.Text))
                            err += "Ingrese el nombre del Medicamento";
                        if (!ctrl.CampoVacio(tbPrecioCompra.Text))
                            err += "Ingrese el precio de Compra";
                        if (!ctrl.CampoVacio(tbPrecioVenta.Text))
                            err += "Ingrese el precio de venta";

                        if (err == string.Empty)
                        {
                            //inserta en la base de datos
                            producto.Nombre = tbMedicamento.Text;
                            producto.Descripcion = tbDescripcion.Text;

                            producto.PrecioCompra = Math.Round(Convert.ToDecimal(tbPrecioCompra.Text), 2, MidpointRounding.AwayFromZero);
                            producto.PrecioVenta = Math.Round(Convert.ToDecimal(tbPrecioVenta.Text), 2, MidpointRounding.AwayFromZero);
                            producto.Stock = 0;
                            producto.UsuarioRegistro = LogicaNegocio.SesionActual.Login;
                            producto.Insertar();
                        }
                        else
                        {
                            MessageBox.Show(err, "Error", MessageBoxButtons.OK);
                        }
                    } break;

                case "editar":
                    {
                        string err = string.Empty;
                        if (!ctrl.CampoVacio(tbMedicamento.Text))
                            err += "Ingrese el nombre del Medicamento";
                        if (!ctrl.CampoVacio(tbPrecioCompra.Text))
                            err += "Ingrese el precio de Compra";
                        if (!ctrl.CampoVacio(tbPrecioVenta.Text))
                            err += "Ingrese el precio de venta";

                        if (err == string.Empty)
                        {
                            producto.Nombre = tbMedicamento.Text;
                            producto.Descripcion = tbDescripcion.Text;
                            producto.PrecioCompra = Math.Round(Convert.ToDecimal(tbPrecioCompra.Text), 2, MidpointRounding.AwayFromZero);
                            producto.PrecioVenta = Math.Round(Convert.ToDecimal(tbPrecioVenta.Text), 2, MidpointRounding.AwayFromZero);
                            producto.UsuarioRegistro = LogicaNegocio.SesionActual.Login;
                            producto.Actualizar();
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

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                index = dgvProductos.SelectedRows[0].Index;
                producto.IdProducto = Convert.ToInt32(dtProductos.Rows[index].ItemArray[0].ToString());
                producto.Seleccionar();

                //Llena el textbox
                tbMedicamento.Text = producto.Nombre;
                tbPrecioCompra.Text = producto.PrecioCompra.ToString();
                tbPrecioVenta.Text = producto.PrecioVenta.ToString();
                tbDescripcion.Text = producto.Descripcion;


                int i = 0;
                foreach (DataRow dtr in dtLab.Rows)
                {
                    if (dtr.ItemArray[0].ToString().Equals(producto.IdLaboratorio.ToString()))
                        cmbLaboratorio.SelectedIndex = i;
                    i++;
                }

                i = 0;
                foreach (DataRow dtr in dtPresentacion.Rows)
                {
                    if (dtr.ItemArray[0].ToString().Equals(producto.IdPresentacion.ToString()))
                        cmbPresentacion.SelectedIndex = i;
                    i++;
                }
            }
        }

        private void cmbPresentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargado)
                producto.IdPresentacion = Convert.ToInt32(dtPresentacion.Rows[cmbPresentacion.SelectedIndex].ItemArray[0]);
        }

        private void cmbLaboratorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargado)
                producto.IdLaboratorio = Convert.ToInt32(dtLab.Rows[cmbLaboratorio.SelectedIndex].ItemArray[0]);
        }

        private void tbPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void tbPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void tbPrecioVenta_Leave(object sender, EventArgs e)
        {
            tbPrecioVenta.Text = ctrl.CampoPrecio(tbPrecioVenta.Text);
        }

        private void tbPrecioCompra_Leave(object sender, EventArgs e)
        {
            tbPrecioCompra.Text = ctrl.CampoPrecio(tbPrecioCompra.Text);
        }

        private void bNuevaPresentacion_Click(object sender, EventArgs e)
        {
            frmPresentaciones frm = new frmPresentaciones();
            frm.ShowDialog();
            dtPresentacion = presentacion.Listar();
            Cargar();
        }

        private void bNuevoLaboratorio_Click(object sender, EventArgs e)
        {
            frmLaboratorios frm = new frmLaboratorios();
            frm.ShowDialog();
            dtLab = lab.Listar();
            Cargar();
        }

        private void bConfig_Click(object sender, EventArgs e)
        {
            FrmConfig frm = new FrmConfig();
            frm.ShowDialog();
            cargado = false;
            Cargar();
            HabilitarControles(false);
        }
        #endregion
    }
}
