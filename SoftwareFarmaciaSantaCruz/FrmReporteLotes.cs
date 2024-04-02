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
    public partial class FrmReporteLotes : Form
    {
        public FrmReporteLotes()
        {
            InitializeComponent();
        }

        private void FrmReporteLotes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsLotes.PaReporteLotes' table. You can move, or remove it, as needed.
            this.PaReporteLotesTableAdapter.Fill(this.dtsLotes.PaReporteLotes);
            this.rptvLotes.RefreshReport();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frm = new frmMenuPrincipal();
            this.Hide();
            frm.Show();
        }
    }
}
