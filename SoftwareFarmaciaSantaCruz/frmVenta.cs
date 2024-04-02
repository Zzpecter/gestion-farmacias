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
    public partial class frmVenta : Form
    {
        #region Variables
        private DataTable dtProductos = new DataTable();
        private DataTable dtVenta = new DataTable();
        private DataTable dtCliente = new DataTable();

        private LogicaNegocio.Producto producto = new LogicaNegocio.Producto();
        private LogicaNegocio.Laboratorio lab = new LogicaNegocio.Laboratorio();
        private LogicaNegocio.ProductoVenta productoVenta = new LogicaNegocio.ProductoVenta();
        private LogicaNegocio.Venta venta = new LogicaNegocio.Venta();
        private LogicaNegocio.Cliente cliente = new LogicaNegocio.Cliente();

        private bool nuevoCliente = false;
        private decimal costoTotal = 0;
        private bool cargado = false;
        #endregion

        #region Carga
        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            PrimeraCarga();
            CargarGrids();
        }

        private void PrimeraCarga()
        {
            dtProductos = producto.Listar();
            dtVenta = dtProductos.Clone();
            dtVenta.Clear();
            dtVenta.Columns[7].ColumnName = "cantidad";
            dtCliente = cliente.Listar();

            bNuevoCliente.Visible = true;
            tbNit.Text = string.Empty;
            tbNombre.Text = string.Empty;
            nuevoCliente = false;
            tbNombre.Visible = false;
            lblNombre.Text = "Nombre:";
        }

        private void CargarGrids()
        {
            cargado = false;

            dgvProductos.DataSource = null;
            dgvVentaActual.DataSource = null;

            dgvProductos.DataSource = dtProductos;
            dgvVentaActual.DataSource = dtVenta;


            dgvProductos.Columns.Remove("idProducto");
            dgvProductos.Columns.Remove("idLaboratorio");
            dgvProductos.Columns.Remove("idPresentacion");
            dgvProductos.Columns.Remove("descripcion");
            dgvProductos.Columns.Remove("precioCompra");

            dgvVentaActual.Columns.Remove("idProducto");
            dgvVentaActual.Columns.Remove("idLaboratorio");
            dgvVentaActual.Columns.Remove("idPresentacion");
            dgvVentaActual.Columns.Remove("descripcion");
            dgvVentaActual.Columns.Remove("precioCompra");

            dgvProductos.Refresh();
            dgvVentaActual.Refresh();
            dgvProductos.ClearSelection();
            dgvVentaActual.ClearSelection();

            tbCantidad.Value = 1;
            DeshabilitarOrdenamiento();
            cargado = true;
            CalcularPrecio();
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvProductos.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;

            foreach (DataGridViewColumn dgvc in dgvVentaActual.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            if (dgvProductos.SelectedRows.Count == 1)
            {
                int index = dgvProductos.SelectedRows[0].Index;

                DataRow dtr = dtProductos.Rows[index];
                producto.IdProducto = Convert.ToInt32(dtProductos.Rows[index].ItemArray[0].ToString());
                bool repetido = false;

                foreach (DataRow dtr2 in dtVenta.Rows)
                    if (dtr.ItemArray[0].ToString().Equals(dtr2.ItemArray[0].ToString()))
                        repetido = true;
                if (repetido)
                    MessageBox.Show("El producto ya fue agregado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    DataRow dtrAux = dtVenta.NewRow();
                    for (int i = 0; i < dtr.ItemArray.Length; ++i)
                        dtrAux.SetField(i, dtr.ItemArray[i]);
                    dtrAux[7] = tbCantidad.Value;
                    dtVenta.Rows.Add(dtrAux);
                }
                CargarGrids();
            }
        }

        private void bQuitar_Click(object sender, EventArgs e)
        {
            if (dgvVentaActual.SelectedRows.Count == 1)
            {
                int index = dgvVentaActual.SelectedRows[0].Index;
                DataRow dtr = dtVenta.Rows[index];
                dtVenta.Rows.Remove(dtr);
                CargarGrids();
            }
        }

        private void bLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            tbBusqueda.Text = string.Empty;
            cargado = false;
            dtProductos = producto.Listar();
            CargarGrids();
        }

        private void bNuevoCliente_Click(object sender, EventArgs e)
        {
            nuevoCliente = true;
            tbNombre.Visible = true;
            bNuevoCliente.Visible = false;
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            dtVenta.Clear();
            CargarGrids();
        }

        private void bVender_Click(object sender, EventArgs e)
        {
            string errores = string.Empty;

            if (dtVenta.Rows.Count < 1)
                errores += "Se debe agregar al menos un producto\n";
            if (tbNit.Text.Equals(string.Empty))
                errores += "Se debe agregar un NIT\n";
            if (nuevoCliente && tbNombre.Text.Equals(string.Empty))
                errores += "Se debe agregar un Nombre\n";

            venta.SeleccionarUltimo();
            int idUltimaVenta = venta.IdVenta;

            if (errores.Equals(string.Empty))
            {
                if (nuevoCliente)
                {
                    cliente.Nombre = tbNombre.Text;
                    cliente.Nit = tbNit.Text;
                    cliente.UsuarioRegistro = LogicaNegocio.SesionActual.Login;
                    cliente.Insertar();
                }

                venta.IdUsuario = LogicaNegocio.SesionActual.IdUsuario;
                venta.IdCliente = cliente.IdCliente;
                venta.Fecha = DateTime.Now;
                venta.MontoTotal = Math.Round(Convert.ToDecimal(costoTotal), 2, MidpointRounding.AwayFromZero);
                venta.UsuarioRegistro = LogicaNegocio.SesionActual.Login;

                List<LogicaNegocio.ProductoVenta> productoVentas = new List<LogicaNegocio.ProductoVenta>();

                foreach (DataRow dtr in dtVenta.Rows)
                {
                    LogicaNegocio.ProductoVenta pv = new LogicaNegocio.ProductoVenta();
                    pv.IdProducto = Convert.ToInt32(dtr.ItemArray[0]);
                    pv.IdVenta = idUltimaVenta + 1;
                    pv.Cantidad = Convert.ToInt32(dtr.ItemArray[7]);
                    pv.UsuarioRegistro = LogicaNegocio.SesionActual.Login;
                    productoVentas.Add(pv);
                }

                FrmReciboVenta frm = new FrmReciboVenta(cliente, venta, productoVentas);
                frm.ShowDialog();

                venta.Insertar();

                foreach (var pv in productoVentas)
                {
                    pv.IdVenta = venta.IdVenta;
                    pv.Insertar();

                    producto.IdProducto = pv.IdProducto;
                    producto.UsuarioRegistro = LogicaNegocio.SesionActual.Login;
                    producto.Seleccionar();
                    producto.Stock -= pv.Cantidad;
                    producto.Actualizar();
                }

                PrimeraCarga();
                CargarGrids();
            }
            else
                MessageBox.Show(errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion

        #region Otros Metodos
        private void CalcularPrecio()
        {
            costoTotal = 0;
            if (dgvVentaActual.Rows.Count.Equals(0))
                lblPrecioTotal.Text = "Total: 0 Bs.";
            else
            {
                foreach (DataGridViewRow d in dgvVentaActual.Rows)
                {
                    decimal cant, pr;

                    cant = Convert.ToDecimal(d.Cells[2].Value.ToString());
                    pr = Convert.ToDecimal(d.Cells[1].Value.ToString());

                    costoTotal += (cant * pr);
                }

                lblPrecioTotal.Text = "Total: " + costoTotal.ToString() + " Bs.";
            }
        }

        private void tbBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (!tbBusqueda.Text.Equals(string.Empty))
            {
                cargado = false;
                dtProductos = producto.Buscar(tbBusqueda.Text);
                CargarGrids();
            }
        }

        private void tbNit_TextChanged(object sender, EventArgs e)
        {
            foreach (DataRow dtr in dtCliente.Rows)
            {
                cliente.IdCliente = Convert.ToInt32(dtr.ItemArray[0]);
                cliente.Seleccionar();

                if (cliente.Nit.Equals(tbNit.Text))
                {
                    lblNombre.Text = "Nombre: " + dtr.ItemArray[2].ToString();
                    break;
                }
            }
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                int index = dgvProductos.SelectedRows[0].Index;
                producto.IdProducto = Convert.ToInt32(dtProductos.Rows[index].ItemArray[0].ToString());
                producto.Seleccionar();
                if (producto.Stock > 0)
                    tbCantidad.Maximum = producto.Stock;
                else
                    bAgregar.Enabled = false;
            }
        }
        #endregion
    }
}
