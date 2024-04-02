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
    public partial class frmCompra : Form
    {
        #region Variables
        private DataTable dtProductos = new DataTable();
        private DataTable dtCompra = new DataTable();
        private DataTable dtLaboratorio = new DataTable();

        private LogicaNegocio.Producto producto = new LogicaNegocio.Producto();
        private LogicaNegocio.Laboratorio lab = new LogicaNegocio.Laboratorio();
        private LogicaNegocio.ProductoCompra productoCompra = new LogicaNegocio.ProductoCompra();
        private LogicaNegocio.Compra compra = new LogicaNegocio.Compra();
        private FrmVencimiento frmVencimiento = new FrmVencimiento();

        private decimal costoTotal = 0;
        private bool cargado = false;
        private DateTime fechaV;
        #endregion

        #region Carga
        public frmCompra()
        {
            InitializeComponent();
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            PrimeraCarga();
            CargarGrids();
        }

        private void PrimeraCarga()
        {
            dtProductos = producto.Listar();
            dtCompra = dtProductos.Clone();
            dtCompra.Clear();
            dtCompra.Columns[7].ColumnName = "cantidad";
            dtCompra.Columns.Add("fechaVencimiento");
        }

        private void CargarGrids()
        {
            cargado = false;

            dgvProductos.DataSource = null;
            dgvCompraActual.DataSource = null;

            dgvProductos.DataSource = dtProductos;
            dgvCompraActual.DataSource = dtCompra;


            dgvProductos.Columns.Remove("idProducto");
            dgvProductos.Columns.Remove("idLaboratorio");
            dgvProductos.Columns.Remove("idPresentacion");
            dgvProductos.Columns.Remove("descripcion");
            dgvProductos.Columns.Remove("precioVenta");

            dgvCompraActual.Columns.Remove("idProducto");
            dgvCompraActual.Columns.Remove("idLaboratorio");
            dgvCompraActual.Columns.Remove("idPresentacion");
            dgvCompraActual.Columns.Remove("descripcion");
            dgvCompraActual.Columns.Remove("precioVenta");

            dgvProductos.Refresh();
            dgvCompraActual.Refresh();
            dgvProductos.ClearSelection();
            dgvCompraActual.ClearSelection();

            tbCantidad.Value = 1;

            DeshabilitarOrdenamiento();
            cargado = true;
            CalcularPrecio();
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvProductos.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;

            foreach (DataGridViewColumn dgvc in dgvCompraActual.Columns)
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
                frmVencimiento.ShowDialog();
                fechaV = frmVencimiento.FechaV;

                int index = dgvProductos.SelectedRows[0].Index;

                DataRow dtr = dtProductos.Rows[index];
                producto.IdProducto = Convert.ToInt32(dtProductos.Rows[index].ItemArray[0].ToString());
                bool repetido = false;

                foreach (DataRow dtr2 in dtCompra.Rows)
                    if (dtr.ItemArray[0].ToString().Equals(dtr2.ItemArray[0].ToString()))
                        repetido = true;
                if (repetido)
                    MessageBox.Show("El producto ya fue agregado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    DataRow dtrAux = dtCompra.NewRow();
                    for (int i = 0; i < dtr.ItemArray.Length; ++i)
                        dtrAux.SetField(i, dtr.ItemArray[i]);
                    dtrAux[7] = tbCantidad.Value;
                    dtrAux[dtrAux.ItemArray.Length - 1] = fechaV;
                    dtCompra.Rows.Add(dtrAux);
                }
                CargarGrids();
            }
        }

        private void bQuitar_Click(object sender, EventArgs e)
        {
            if (dgvCompraActual.SelectedRows.Count == 1)
            {
                int index = dgvCompraActual.SelectedRows[0].Index;
                DataRow dtr = dtCompra.Rows[index];
                dtCompra.Rows.Remove(dtr);
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

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            dtCompra.Clear();
            CargarGrids();
        }

        private void bComprar_Click(object sender, EventArgs e)
        {
            string errores = string.Empty;

            if (dtCompra.Rows.Count < 1)
                errores += "Se debe agregar al menos un producto\n";

            if (errores.Equals(string.Empty))
            {
                compra.IdUsuario = LogicaNegocio.SesionActual.IdUsuario;
                compra.Fecha = DateTime.Now;
                compra.MontoTotal = Math.Round(Convert.ToDecimal(costoTotal), 2, MidpointRounding.AwayFromZero);
                compra.UsuarioRegistro = LogicaNegocio.SesionActual.Login;
                compra.Insertar();

                foreach (DataRow dtr in dtCompra.Rows)
                {
                    productoCompra.IdProducto = Convert.ToInt32(dtr.ItemArray[0]);
                    productoCompra.IdCompra = compra.IdCompra;
                    productoCompra.FechaVencimiento = Convert.ToDateTime(dtr.ItemArray[dtr.ItemArray.Length - 1]);
                    productoCompra.Cantidad = Convert.ToInt32(dtr.ItemArray[7]);
                    productoCompra.UsuarioRegistro = LogicaNegocio.SesionActual.Login;
                    productoCompra.Insertar();

                    producto.IdProducto = productoCompra.IdProducto;
                    producto.UsuarioRegistro = LogicaNegocio.SesionActual.Login;
                    producto.Seleccionar();
                    producto.Stock += productoCompra.Cantidad;
                    producto.Actualizar();
                }
                PrimeraCarga();
                CargarGrids();
            }
            else
                MessageBox.Show(errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void bNuevoProducto_Click(object sender, EventArgs e)
        {
            frmProductos frm = new frmProductos();
            frm.ShowDialog();
            dtProductos = producto.Listar();
            CargarGrids();
        }
        #endregion

        #region Otros Metodos
        private void CalcularPrecio()
        {
            costoTotal = 0;
            if (dgvCompraActual.Rows.Count.Equals(0))
                lblCosto.Text = "Total: 0 Bs.";
            else
            {
                foreach (DataGridViewRow d in dgvCompraActual.Rows)
                {
                    decimal cant, pr;

                    cant = Convert.ToDecimal(d.Cells[2].Value.ToString());
                    pr = Convert.ToDecimal(d.Cells[1].Value.ToString());

                    costoTotal += (cant * pr);
                }

                lblCosto.Text = "Total: " + costoTotal.ToString() + " Bs.";
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
        #endregion
    }
}
