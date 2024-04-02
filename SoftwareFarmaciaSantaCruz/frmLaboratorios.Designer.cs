namespace SoftwareFarmaciaSantaCruz
{
    partial class frmLaboratorios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLaboratorios));
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.dgvLaboratorios = new System.Windows.Forms.DataGridView();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratorios)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(307, 21);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(215, 28);
            this.tbNombre.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nombre:";
            // 
            // bCancelar
            // 
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelar.ForeColor = System.Drawing.Color.Green;
            this.bCancelar.Location = new System.Drawing.Point(622, 21);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(134, 54);
            this.bCancelar.TabIndex = 48;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bVolver
            // 
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.ForeColor = System.Drawing.Color.Green;
            this.bVolver.Location = new System.Drawing.Point(18, 346);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(134, 54);
            this.bVolver.TabIndex = 47;
            this.bVolver.Text = "Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGuardar.ForeColor = System.Drawing.Color.Green;
            this.bGuardar.Location = new System.Drawing.Point(18, 286);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(134, 54);
            this.bGuardar.TabIndex = 46;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEliminar.ForeColor = System.Drawing.Color.Green;
            this.bEliminar.Location = new System.Drawing.Point(18, 142);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(134, 54);
            this.bEliminar.TabIndex = 45;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bEditar
            // 
            this.bEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEditar.ForeColor = System.Drawing.Color.Green;
            this.bEditar.Location = new System.Drawing.Point(18, 82);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(134, 54);
            this.bEditar.TabIndex = 44;
            this.bEditar.Text = "Editar";
            this.bEditar.UseVisualStyleBackColor = true;
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAgregar.ForeColor = System.Drawing.Color.Green;
            this.bAgregar.Location = new System.Drawing.Point(18, 22);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(134, 54);
            this.bAgregar.TabIndex = 43;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // dgvLaboratorios
            // 
            this.dgvLaboratorios.AllowUserToAddRows = false;
            this.dgvLaboratorios.AllowUserToDeleteRows = false;
            this.dgvLaboratorios.AllowUserToResizeColumns = false;
            this.dgvLaboratorios.AllowUserToResizeRows = false;
            this.dgvLaboratorios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLaboratorios.BackgroundColor = System.Drawing.Color.White;
            this.dgvLaboratorios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLaboratorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaboratorios.Location = new System.Drawing.Point(194, 130);
            this.dgvLaboratorios.MultiSelect = false;
            this.dgvLaboratorios.Name = "dgvLaboratorios";
            this.dgvLaboratorios.ReadOnly = true;
            this.dgvLaboratorios.RowTemplate.Height = 24;
            this.dgvLaboratorios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLaboratorios.Size = new System.Drawing.Size(574, 270);
            this.dgvLaboratorios.TabIndex = 42;
            this.dgvLaboratorios.SelectionChanged += new System.EventHandler(this.dgvLaboratorios_SelectionChanged);
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(307, 55);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(153, 28);
            this.tbTelefono.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 52;
            this.label1.Text = "Telefono:";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(307, 89);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(215, 28);
            this.tbCorreo.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 54;
            this.label3.Text = "Correo:";
            // 
            // frmLaboratorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 417);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bEditar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.dgvLaboratorios);
            this.Font = new System.Drawing.Font("Impact", 10.2F);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmLaboratorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Laboratorios";
            this.Load += new System.EventHandler(this.frmLaboratorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratorios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.DataGridView dgvLaboratorios;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Label label3;
    }
}