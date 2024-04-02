using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareFarmaciaSantaCruz
{

    public partial class FrmReciboVenta : Form
    {
        LogicaNegocio.Cliente cliente = new LogicaNegocio.Cliente();
        LogicaNegocio.Venta venta = new LogicaNegocio.Venta();
        LogicaNegocio.Producto producto = new LogicaNegocio.Producto();
        List<LogicaNegocio.ProductoVenta> productoVentas = new List<LogicaNegocio.ProductoVenta>();
        List<Point> coordenadas = new List<Point>();
        List<string> valores = new List<string>();

        public FrmReciboVenta()
        {
            InitializeComponent();
        }

        public FrmReciboVenta(LogicaNegocio.Cliente cliente, LogicaNegocio.Venta venta, List<LogicaNegocio.ProductoVenta> productoVentas)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.venta = venta;
            this.productoVentas = productoVentas;
        }

        private void FrmReciboVenta_Load(object sender, EventArgs e)
        {
            coordenadas.Add(new Point(340, 112));coordenadas.Add(new Point(595, 121)); coordenadas.Add(new Point(155, 155));
            coordenadas.Add(new Point(612, 182)); coordenadas.Add(new Point(23, 232)); coordenadas.Add(new Point(70, 232));
            coordenadas.Add(new Point(545, 232)); coordenadas.Add(new Point(645, 232)); coordenadas.Add(new Point(23, 260));
            coordenadas.Add(new Point(70, 260)); coordenadas.Add(new Point(545, 260)); coordenadas.Add(new Point(645, 260));
            coordenadas.Add(new Point(23, 286)); coordenadas.Add(new Point(70, 286)); coordenadas.Add(new Point(545, 286));
            coordenadas.Add(new Point(645, 286)); coordenadas.Add(new Point(23, 315)); coordenadas.Add(new Point(70, 315));
            coordenadas.Add(new Point(545, 315)); coordenadas.Add(new Point(645, 315)); coordenadas.Add(new Point(23, 340));
            coordenadas.Add(new Point(70, 340)); coordenadas.Add(new Point(545, 340)); coordenadas.Add(new Point(645, 340));
            coordenadas.Add(new Point(23, 370)); coordenadas.Add(new Point(70, 370)); coordenadas.Add(new Point(545, 370));
            coordenadas.Add(new Point(645, 370)); coordenadas.Add(new Point(645, 396)); coordenadas.Add(new Point(645, 422));
            coordenadas.Add(new Point(645, 475));


            LogicaNegocio.Venta v2 = new LogicaNegocio.Venta();
            v2.SeleccionarUltimo();
            string codigoVenta = (v2.IdVenta + 1).ToString();
            while (codigoVenta.Length < 6)
                codigoVenta = "0" + codigoVenta;


            valores.Add(DateTime.Now.ToShortDateString()); valores.Add(codigoVenta);
            valores.Add(cliente.Nombre); valores.Add(cliente.Nit);

            foreach (LogicaNegocio.ProductoVenta pv in productoVentas)
            {
                producto.IdProducto = pv.IdProducto;
                producto.Seleccionar();

                valores.Add(pv.Cantidad.ToString());
                valores.Add(producto.Nombre);
                valores.Add(producto.PrecioVenta.ToString());
                valores.Add((pv.Cantidad * producto.PrecioVenta).ToString());
            }

            while (valores.Count < 28)
                valores.Add(string.Empty);


            decimal montoBase = venta.MontoTotal - (venta.MontoTotal * 0.16m);
            decimal impuestos = (venta.MontoTotal * 0.16m);

            valores.Add(montoBase.ToString());
            valores.Add(impuestos.ToString());
            valores.Add(venta.MontoTotal.ToString());

            Dibujar();
        }

        private void Dibujar()
        {
            pbRecibo.Image = SoftwareFarmaciaSantaCruz.Properties.Resources.recibo2;
            Graphics g = Graphics.FromImage(pbRecibo.Image);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            Font f = new Font("Arial", 12);

            var coordsValores = coordenadas.Zip(valores, (c, v) => new { Coordenada = c, Valor = v });
            foreach (var cv in coordsValores)
            {
                g.DrawString(cv.Valor, f, Brushes.Black, cv.Coordenada);
            }
        }

        private void bImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument printRecibo = new PrintDocument();
            printRecibo.PrintPage += new PrintPageEventHandler(printRecibo_PrintPage);
            printRecibo.Print();
        }

        private void printRecibo_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pbRecibo.BackgroundImage, 0, 0);
        }

        private void bTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
