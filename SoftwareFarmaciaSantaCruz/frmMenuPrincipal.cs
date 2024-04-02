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
    public partial class frmMenuPrincipal : Form
    {
        #region Variables
        private DataTable dtProductos = new DataTable();
        private DataTable dtProductoCompra = new DataTable();
        private LogicaNegocio.Producto producto = new LogicaNegocio.Producto();
        private LogicaNegocio.ProductoCompra productoCompra = new LogicaNegocio.ProductoCompra();

        private int index = 0;
        private DateTime fechaLimite = DateTime.Now.AddDays(7);
        #endregion

        #region Carga
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void ControlPermisos()
        {
            if (LogicaNegocio.SesionActual.IdNivel == 1)
            {
                bUsuarios.Enabled = false;
                bReporte0.Enabled = false;
                bReporte1.Enabled = false;
            }
        }

        private void CargarNotificaciones()
        {
            LogicaNegocio.SesionActual.PrimerLogin = false;
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
                    stockRestante -= Convert.ToInt32(dtr.ItemArray[4]);


                    if (Convert.ToDateTime(dtr.ItemArray[3]) <= fechaLimite.AddDays(-8))
                    {
                        producto.IdProducto = Convert.ToInt32(dtr.ItemArray[1]);
                        producto.Seleccionar();
                        producto.Stock -= stockRestante;
                        producto.UsuarioRegistro = "Vencimiento";
                        producto.Actualizar();
                    }
                    else if (Convert.ToDateTime(dtr.ItemArray[3]) <= fechaLimite)
                    {
                        LogicaNegocio.SesionActual.NumNotificaciones++;
                    }

                    if (stockRestante <= 0)
                        break;
                }
            }
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Bienvenido, " + LogicaNegocio.SesionActual.Login + "!";
            ControlPermisos();

            if (LogicaNegocio.SesionActual.PrimerLogin)
                CargarNotificaciones();

            if (LogicaNegocio.SesionActual.NumNotificaciones == 0)
            {
                lblAdvertencia.Text = "No tiene mensajes nuevos";
                bAnuncios.BackgroundImage = SoftwareFarmaciaSantaCruz.Properties.Resources.ok;
            }
            else
            {
                lblAdvertencia.Text = "<= Hay notificacion(es)!";
                bAnuncios.BackgroundImage = SoftwareFarmaciaSantaCruz.Properties.Resources.advertencia;
            }

        }
        #endregion

        #region Botones
        private void bCerrarSesion_Click(object sender, EventArgs e)
        {
            frmAutenticacion frm = new frmAutenticacion();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bCompra_Click(object sender, EventArgs e)
        {
            frmCompra frm = new frmCompra();
            frm.Show();
            this.Hide();
        }

        private void bVenta_Click(object sender, EventArgs e)
        {
            frmVenta frm = new frmVenta();
            frm.Show();
            this.Hide();
        }

        private void bProductos_Click(object sender, EventArgs e)
        {
            frmProductos frm = new frmProductos();
            frm.Show();
            this.Hide();
        }

        private void bPresentaciones_Click(object sender, EventArgs e)
        {
            frmPresentaciones frm = new frmPresentaciones();
            frm.Show();
            this.Hide();
        }

        private void bActivosTangibles_Click(object sender, EventArgs e)
        {
            frmActivosTangibles frm = new frmActivosTangibles();
            frm.Show();
            this.Hide();
        }

        private void bLaboratorios_Click(object sender, EventArgs e)
        {
            frmLaboratorios frm = new frmLaboratorios();
            frm.Show();
            this.Hide();
        }

        private void bClientes_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.Show();
            this.Hide();
        }

        private void bUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            frm.Show();
            this.Hide();
        }

        private void bAnuncios_Click(object sender, EventArgs e)
        {
            FrmAnuncios frm = new FrmAnuncios();
            this.Hide();
            frm.Show();
        }

        private void bReporte0_Click(object sender, EventArgs e)
        {
            FrmReportes frm = new FrmReportes();
            this.Hide();
            frm.Show();
        }

        private void bReporte1_Click_1(object sender, EventArgs e)
        {
            FrmReportes2 frm = new FrmReportes2();
            this.Hide();
            frm.Show();
        }

        private void bCambiarContrasenha_Click(object sender, EventArgs e)
        {
            FrmCambiarContrasenha frm = new FrmCambiarContrasenha();
            frm.ShowDialog();
        }

        private void bConfig_Click(object sender, EventArgs e)
        {
            FrmConfig frm = new FrmConfig();
            frm.ShowDialog();
        }

        private void bReporteLotes_Click(object sender, EventArgs e)
        {
            FrmReporteLotes frm = new FrmReporteLotes();
            this.Hide();
            frm.Show();
        }
        #endregion
    }
}
