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
    public partial class FrmVencimiento : Form
    {
        private DateTime fechaV;
        public FrmVencimiento()
        {
            InitializeComponent();
        }

        public DateTime FechaV
        {
            get { return (this.fechaV); }
            set { this.fechaV = value; }
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            fechaV = dateTimePicker1.Value;
            this.Hide();
        }
    }
}
