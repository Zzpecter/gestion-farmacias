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
    public partial class FrmAnuncios : Form
    {
        #region Variables
        private DataTable dtAnuncios = new DataTable();
        private DataTable dtProductos = new DataTable();
        private DataTable dtProductoCompra = new DataTable();
        private LogicaNegocio.Producto producto = new LogicaNegocio.Producto();
        private LogicaNegocio.ProductoCompra productoCompra = new LogicaNegocio.ProductoCompra();

        private int index = 0;
        private DateTime fechaLimite = DateTime.Now.AddDays(7);
        private bool cargado = false;
        private string accionActual = string.Empty;
        private float total = 0;
        #endregion

        #region Carga
        public FrmAnuncios()
        {
            InitializeComponent();
        }

        private void FrmAnuncios_Load(object sender, EventArgs e)
        {
            CargarNotificaciones();
        }

        private void CargarNotificaciones()
        {
            dtAnuncios.Clear();
            dtAnuncios.Columns.Add("Anuncio");
            dtAnuncios.Columns.Add("Descripcion");

            dtProductos = producto.Listar();
            List<int> listaIDs = new List<int>();
            foreach (DataRow dtr in dtProductos.Rows)
                listaIDs.Add(Convert.ToInt32(dtr.ItemArray[0]));

            foreach (int id in listaIDs)
            {
                dtProductoCompra.Clear();
                productoCompra.IdProducto = id;
                dtProductoCompra = productoCompra.SeleccionarVenc();

                producto.IdProducto = id;
                producto.Seleccionar();
                int stockRestante = producto.Stock;


                foreach (DataRow dtr in dtProductoCompra.Rows)
                {
                    stockRestante = Convert.ToInt32(dtr.ItemArray[4]);
                    
                    if (Convert.ToDateTime(dtr.ItemArray[3]) <= fechaLimite)
                    {
                        string anuncio = "Vencimiento de Producto: " + producto.Nombre;
                        string descripcion = stockRestante.ToString() + " Unidad(es) del medicamento " + producto.Nombre + " Estan proximos a cumplir su fecha de vencimiento: " + Convert.ToDateTime(dtr.ItemArray[3]).ToString("dd.MM.yy") + "\nEstos productos seran automaticamente eliminados del almacén cuando esta fecha expire.";
                        stockRestante = producto.Stock - stockRestante;

                        DataRow dtrAux = dtAnuncios.NewRow();
                        dtrAux.SetField(0, anuncio);
                        dtrAux.SetField(1, descripcion);
                        dtAnuncios.Rows.Add(dtrAux);
                        break;
                    }
                    if (stockRestante <= 0)
                        break;
                }
            }
            dgvAnuncios.DataSource = dtAnuncios;
            dgvAnuncios.Columns.RemoveAt(1);
            dgvAnuncios.Refresh();
            dgvAnuncios.ClearSelection();
            cargado = true;
        }
        #endregion

        private void dgvAnuncios_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                index = dgvAnuncios.SelectedRows[0].Index;
                tbDescripcion.Text = dtAnuncios.Rows[index].ItemArray[1].ToString();
            }
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frm = new frmMenuPrincipal();
            this.Hide();
            frm.Show();
        }
    }
}
