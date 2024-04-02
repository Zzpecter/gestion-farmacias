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
    public partial class FrmReportes2 : Form
    {
        public FrmReportes2()
        {
            InitializeComponent();
        }

        private void FrmReportes2_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }

        public void CargarReporte()
        {
            if (rbClientes.Checked)
            {
                rptvClientes.Visible = true;
                rptvProveedores.Visible = false;
                this.PaReporteClientesTableAdapter.Fill(this.dtsClientesLab.PaReporteClientes);
                this.rptvClientes.RefreshReport();
            }
            else
            {
                rptvClientes.Visible = false;
                rptvProveedores.Visible = true;
                this.PaReporteLaboratoriosTableAdapter.Fill(this.dtsClientesLab.PaReporteLaboratorios);
                this.rptvProveedores.RefreshReport();
            }
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frm = new frmMenuPrincipal();
            this.Hide();
            frm.Show();
        }
    }
}
