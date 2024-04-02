using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace SoftwareFarmaciaSantaCruz
{
    public partial class FrmConfig : Form
    {
        private bool cargado = false;
        private LogicaNegocio.Producto producto = new LogicaNegocio.Producto();
        private DataTable dtProductos = new DataTable();
        private LogicaNegocio.Configuracion cnf = new LogicaNegocio.Configuracion();
        private DataTable dtConf = new DataTable();
        private bool cambio = false;

        public FrmConfig()
        {
            InitializeComponent();
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            dtConf = cnf.Listar();
            tbTasaVenta.Value = Convert.ToInt32(dtConf.Rows[0].ItemArray[1]);
            tbIva.Value = Convert.ToInt32(dtConf.Rows[0].ItemArray[2]);
            tbIt.Value = Convert.ToInt32(dtConf.Rows[0].ItemArray[3]);

            Actualizar();
            cargado = true;
        }

        private void Actualizar()
        {
            lblPorcientoVenta.Text = (tbTasaVenta.Value + 100).ToString() + "%";
            lblPorcientoIva.Text = (tbIva.Value).ToString() + "%";
            lblPorcientoIt.Text = (tbIt.Value).ToString() + "%";

            lblTasaVenta.Text = "Ej. Precio Compra/Venta: 100/" + (tbTasaVenta.Value + 100).ToString() + "Bs.";
            lblTasaIva.Text = "Ej. Tasa IVA por 100Bs: " + (tbIva.Value).ToString() + "Bs.";
            lblTasaIt.Text = "Ej. Tasa IT por 100Bs: " + (tbIt.Value).ToString() + "Bs.";
        }

        private void tb_Scroll(object sender, EventArgs e)
        {
            if (cargado)
            {
                Actualizar();
                cambio = true;
                bGuardar.Enabled = cambio;
            }
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("A continuación se relizara la actualizacion de precios del inventario, esto puede tardar unos momentos.", "Advertencia", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                dtProductos = producto.Listar();

                cnf.TasaVenta = tbTasaVenta.Value;
                cnf.Iva = tbIva.Value;
                cnf.It = tbIt.Value;
                cnf.UsuarioRegistro = LogicaNegocio.SesionActual.Login;
                cnf.Actualizar();

                producto.UsuarioRegistro = LogicaNegocio.SesionActual.Login;

                foreach (DataRow dtr in dtProductos.Rows)
                {
                    producto.IdProducto = Convert.ToInt32(dtr.ItemArray[0]);
                    producto.Seleccionar();
                    decimal tasa = (Convert.ToDecimal(tbTasaVenta.Value) / 100m) + 1m;
                    producto.PrecioVenta = Math.Round(Convert.ToDecimal(producto.PrecioCompra * tasa), 2, MidpointRounding.AwayFromZero);
                    producto.Actualizar();
                }
                MessageBox.Show("Se guardaron los cambios!");
            }
            else
                MessageBox.Show("No se guardaron los cambios");

            Cursor.Current = Cursors.Default;
            this.Close();
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("No se guardaran los cambios realizados, esta seguro que desea volver?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }
    }
}
