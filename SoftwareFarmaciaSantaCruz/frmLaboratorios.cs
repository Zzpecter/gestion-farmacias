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
    public partial class frmLaboratorios : Form
    {

        #region variables
        private DataTable dtLaboratorio = new DataTable();
        private LogicaNegocio.Laboratorio lab = new LogicaNegocio.Laboratorio();
        private LogicaNegocio.Controladora ctrl = new LogicaNegocio.Controladora();

        private int idLaboratorio = 0;
        private int laboratorio = 0;
        private int index = 0;
        private bool cargado = false;
        private bool error = false;
        private string accionActual = string.Empty;
        private bool secundario = false;

        #endregion


        public frmLaboratorios()
        {
            InitializeComponent();
        }


        private void Cargar()
        {
            cargado = false;
            dgvLaboratorios.DataSource = null;
            dtLaboratorio = lab.Listar();
            dgvLaboratorios.DataSource = dtLaboratorio;
            dgvLaboratorios.Refresh();

            dgvLaboratorios.Columns.Remove("idLaboratorio");
            dgvLaboratorios.ClearSelection();

            cargado = true;
            HabilitarControles(false);
        }


        private void HabilitarControles(bool editar)
        {
            dgvLaboratorios.Enabled = !editar;

            tbNombre.ReadOnly = !editar;
            tbTelefono.ReadOnly = !editar;
            tbCorreo.ReadOnly = !editar;

            bGuardar.Visible = editar;
            bCancelar.Visible = editar;

            bAgregar.Enabled = !editar;
            bEditar.Enabled = !editar;
            bEliminar.Enabled = !editar;

            if (accionActual == "agregar")
            {
                tbNombre.Text = string.Empty;
                tbTelefono.Text = string.Empty;
                tbCorreo.Text = string.Empty;
            }
        }



        private void bVolver_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frm = new frmMenuPrincipal();
            frm.Show();
            this.Hide();
        }

        private void frmLaboratorios_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            accionActual = "agregar";
            HabilitarControles(true);
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            accionActual = "editar";
            HabilitarControles(true);
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            HabilitarControles(false);
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            switch (accionActual)
            {
                case "agregar":
                    //mandando variables para controlar el valor de los campos
                    {
                        string err = string.Empty;
                        if (!ctrl.CampoVacio(tbNombre.Text))
                            err += "Ingrese un nonmbre";
                        if (!ctrl.CampoVacio(tbTelefono.Text))
                            err += "Ingrese un telefono";
                        if (!ctrl.CampoVacio(tbCorreo.Text))
                            err += "Ingrese un correo";

                        if (err.Equals(string.Empty))
                        {
                            lab.Lab = tbNombre.Text;
                            lab.Telefono = tbTelefono.Text;
                            lab.Correo = tbCorreo.Text;
                            lab.UsuarioRegistro = LogicaNegocio.SesionActual.Login;

                            lab.Insertar();
                        }

                        else
                            MessageBox.Show("Ingrese un nombre");
                    } break;
                case "editar":
                    {
                        error = ctrl.CampoVacio(tbNombre.Text);
                        error = ctrl.CampoVacio(tbTelefono.Text);
                        error = ctrl.CampoVacio(tbCorreo.Text);

                        if (error)
                        {
                            lab.Lab = tbNombre.Text;
                            lab.Telefono = tbTelefono.Text;
                            lab.Correo = tbCorreo.Text;
                            lab.UsuarioRegistro = LogicaNegocio.SesionActual.Login;

                            lab.Actualizar();
                        }

                        else
                            MessageBox.Show("Ingrese un nombre");


                    } break;
                default: break;
            }

            cargado = false;
            Cargar();
            HabilitarControles(false);
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLaboratorios.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Esta seguro de eliminar el laboratorio?", "ADVERTENCIA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lab.Eliminar();

                    cargado = false;
                    Cargar();
                }
            }
        }

        private void dgvLaboratorios_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                index = dgvLaboratorios.SelectedRows[0].Index;
                lab.IdLaboratorio = Convert.ToInt32(dtLaboratorio.Rows[index].ItemArray[0].ToString());
                lab.Seleccionar();

                //Llena el textbox
                tbNombre.Text = lab.Lab;
                tbTelefono.Text = lab.Telefono;
                tbCorreo.Text = lab.Correo;
               


            }
        }
    }
}
