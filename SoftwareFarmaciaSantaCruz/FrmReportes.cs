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
    public partial class FrmReportes : Form
    {
        private bool cargado = false;
        private DateTime fechaInicial = Convert.ToDateTime("01/01/1900");
        private DateTime fechaFinal = DateTime.Now;

        public FrmReportes()
        {
            InitializeComponent();
        }

        public void CargarReporte()
        {
            if (rbDiario.Checked)
            {
                fechaInicial = dtpDia.Value.Date;
                fechaFinal = fechaInicial.AddDays(1);
            }
            else if (rbMensual.Checked)
            {
                fechaInicial = Convert.ToDateTime("01/" + (cmbMes.SelectedIndex + 1).ToString() + "/" + (cmbAnho.SelectedItem).ToString());
                fechaFinal = fechaInicial.AddMonths(1);
            }
            else
            {
                fechaInicial = Convert.ToDateTime("01/01/" + (cmbAnho.SelectedItem).ToString());
                fechaFinal = fechaInicial.AddYears(1);
            }

            if (rbCompra.Checked)
            {
                rptvCompra.Visible = true;
                rptvVenta.Visible = false;
                this.PaReporteComprasTableAdapter.Fill(this.dtsCV.PaReporteCompras, fechaInicial, fechaFinal);
                this.rptvCompra.RefreshReport();
            }
            else
            {
                rptvCompra.Visible = false;
                rptvVenta.Visible = true;
                this.PaReporteVentasTableAdapter.Fill(this.dtsCV.PaReporteVentas, fechaInicial, fechaFinal);
                this.rptvVenta.RefreshReport();
            }
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            cmbAnho.Items.Add("2018");cmbAnho.Items.Add("2019");cmbAnho.Items.Add("2020");
            cmbAnho.Items.Add("2021");cmbAnho.Items.Add("2022");cmbAnho.Items.Add("2023");

            cmbMes.Items.Add("Enero"); cmbMes.Items.Add("Febrero"); cmbMes.Items.Add("Marzo");
            cmbMes.Items.Add("Abril"); cmbMes.Items.Add("Mayo"); cmbMes.Items.Add("Junio");
            cmbMes.Items.Add("Julio"); cmbMes.Items.Add("Agosto"); cmbMes.Items.Add("Septiembre");
            cmbMes.Items.Add("Octubre"); cmbMes.Items.Add("Noviembre"); cmbMes.Items.Add("Diciembre");

            cmbAnho.SelectedIndex = 0;
            cmbMes.SelectedIndex = 0;
            cargado = true;
            CargarReporte();
        }

        private void AccionRealizada(object sender, EventArgs e)
        {
            if (cargado)
            {
                if (rbDiario.Checked)
                {
                    dtpDia.Visible = true;
                    cmbMes.Visible = false;
                    cmbAnho.Visible = false;
                }
                else if (rbMensual.Checked)
                {
                    dtpDia.Visible = false;
                    cmbMes.Visible = true;
                    cmbAnho.Visible = true;
                }
                else
                {
                    dtpDia.Visible = false;
                    cmbMes.Visible = false;
                    cmbAnho.Visible = true;
                }

                CargarReporte();
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frm = new frmMenuPrincipal();
            this.Hide();
            frm.Show();
        }
    }
}
