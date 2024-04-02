namespace SoftwareFarmaciaSantaCruz
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.bVolver = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.cmbPresentacion = new System.Windows.Forms.ComboBox();
            this.tbMedicamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrecioCompra = new System.Windows.Forms.TextBox();
            this.bNuevoLaboratorio = new System.Windows.Forms.Button();
            this.cmbLaboratorio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bNuevaPresentacion = new System.Windows.Forms.Button();
            this.tbPrecioVenta = new System.Windows.Forms.TextBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.bConfig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(190, 211);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(822, 394);
            this.dgvProductos.TabIndex = 19;
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // bVolver
            // 
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.ForeColor = System.Drawing.Color.Green;
            this.bVolver.Location = new System.Drawing.Point(12, 532);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(134, 54);
            this.bVolver.TabIndex = 33;
            this.bVolver.Text = "Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGuardar.ForeColor = System.Drawing.Color.Green;
            this.bGuardar.Location = new System.Drawing.Point(12, 472);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(134, 54);
            this.bGuardar.TabIndex = 32;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEliminar.ForeColor = System.Drawing.Color.Green;
            this.bEliminar.Location = new System.Drawing.Point(12, 132);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(134, 54);
            this.bEliminar.TabIndex = 31;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bEditar
            // 
            this.bEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEditar.ForeColor = System.Drawing.Color.Green;
            this.bEditar.Location = new System.Drawing.Point(12, 72);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(134, 54);
            this.bEditar.TabIndex = 30;
            this.bEditar.Text = "Editar";
            this.bEditar.UseVisualStyleBackColor = true;
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAgregar.ForeColor = System.Drawing.Color.Green;
            this.bAgregar.Location = new System.Drawing.Point(12, 12);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(134, 54);
            this.bAgregar.TabIndex = 29;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // cmbPresentacion
            // 
            this.cmbPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPresentacion.FormattingEnabled = true;
            this.cmbPresentacion.Location = new System.Drawing.Point(305, 60);
            this.cmbPresentacion.Name = "cmbPresentacion";
            this.cmbPresentacion.Size = new System.Drawing.Size(212, 29);
            this.cmbPresentacion.TabIndex = 50;
            this.cmbPresentacion.SelectedIndexChanged += new System.EventHandler(this.cmbPresentacion_SelectedIndexChanged);
            // 
            // tbMedicamento
            // 
            this.tbMedicamento.Location = new System.Drawing.Point(305, 26);
            this.tbMedicamento.Name = "tbMedicamento";
            this.tbMedicamento.Size = new System.Drawing.Size(215, 28);
            this.tbMedicamento.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Medicamento:";
            // 
            // tbPrecioCompra
            // 
            this.tbPrecioCompra.Location = new System.Drawing.Point(725, 60);
            this.tbPrecioCompra.Name = "tbPrecioCompra";
            this.tbPrecioCompra.Size = new System.Drawing.Size(103, 28);
            this.tbPrecioCompra.TabIndex = 45;
            this.tbPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecioCompra_KeyPress);
            this.tbPrecioCompra.Leave += new System.EventHandler(this.tbPrecioCompra_Leave);
            // 
            // bNuevoLaboratorio
            // 
            this.bNuevoLaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNuevoLaboratorio.ForeColor = System.Drawing.Color.Green;
            this.bNuevoLaboratorio.Location = new System.Drawing.Point(523, 94);
            this.bNuevoLaboratorio.Name = "bNuevoLaboratorio";
            this.bNuevoLaboratorio.Size = new System.Drawing.Size(66, 28);
            this.bNuevoLaboratorio.TabIndex = 56;
            this.bNuevoLaboratorio.Text = "Nuevo";
            this.bNuevoLaboratorio.UseVisualStyleBackColor = true;
            this.bNuevoLaboratorio.Click += new System.EventHandler(this.bNuevoLaboratorio_Click);
            // 
            // cmbLaboratorio
            // 
            this.cmbLaboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLaboratorio.FormattingEnabled = true;
            this.cmbLaboratorio.Location = new System.Drawing.Point(305, 95);
            this.cmbLaboratorio.Name = "cmbLaboratorio";
            this.cmbLaboratorio.Size = new System.Drawing.Size(212, 29);
            this.cmbLaboratorio.TabIndex = 55;
            this.cmbLaboratorio.SelectedIndexChanged += new System.EventHandler(this.cmbLaboratorio_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Precio Compra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 54;
            this.label6.Text = "Laboratorio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 49;
            this.label4.Text = "Presentacion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(609, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 21);
            this.label5.TabIndex = 53;
            this.label5.Text = "Precio Venta:";
            // 
            // bNuevaPresentacion
            // 
            this.bNuevaPresentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNuevaPresentacion.ForeColor = System.Drawing.Color.Green;
            this.bNuevaPresentacion.Location = new System.Drawing.Point(523, 59);
            this.bNuevaPresentacion.Name = "bNuevaPresentacion";
            this.bNuevaPresentacion.Size = new System.Drawing.Size(66, 28);
            this.bNuevaPresentacion.TabIndex = 51;
            this.bNuevaPresentacion.Text = "Nuevo";
            this.bNuevaPresentacion.UseVisualStyleBackColor = true;
            this.bNuevaPresentacion.Click += new System.EventHandler(this.bNuevaPresentacion_Click);
            // 
            // tbPrecioVenta
            // 
            this.tbPrecioVenta.Location = new System.Drawing.Point(725, 91);
            this.tbPrecioVenta.Name = "tbPrecioVenta";
            this.tbPrecioVenta.ReadOnly = true;
            this.tbPrecioVenta.Size = new System.Drawing.Size(103, 28);
            this.tbPrecioVenta.TabIndex = 52;
            this.tbPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecioVenta_KeyPress);
            this.tbPrecioVenta.Leave += new System.EventHandler(this.tbPrecioVenta_Leave);
            // 
            // bCancelar
            // 
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelar.ForeColor = System.Drawing.Color.Green;
            this.bCancelar.Location = new System.Drawing.Point(878, 12);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(134, 54);
            this.bCancelar.TabIndex = 57;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 21);
            this.label7.TabIndex = 59;
            this.label7.Text = "Descripcion:";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(305, 130);
            this.tbDescripcion.MaxLength = 200;
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(523, 75);
            this.tbDescripcion.TabIndex = 60;
            // 
            // bConfig
            // 
            this.bConfig.BackgroundImage = global::SoftwareFarmaciaSantaCruz.Properties.Resources.config;
            this.bConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConfig.ForeColor = System.Drawing.Color.Green;
            this.bConfig.Location = new System.Drawing.Point(834, 86);
            this.bConfig.Name = "bConfig";
            this.bConfig.Size = new System.Drawing.Size(36, 36);
            this.bConfig.TabIndex = 61;
            this.bConfig.UseVisualStyleBackColor = true;
            this.bConfig.Click += new System.EventHandler(this.bConfig_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 616);
            this.Controls.Add(this.bConfig);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.cmbPresentacion);
            this.Controls.Add(this.tbMedicamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPrecioCompra);
            this.Controls.Add(this.bNuevoLaboratorio);
            this.Controls.Add(this.cmbLaboratorio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bNuevaPresentacion);
            this.Controls.Add(this.tbPrecioVenta);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bEditar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.dgvProductos);
            this.Font = new System.Drawing.Font("Impact", 10.2F);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.ComboBox cmbPresentacion;
        private System.Windows.Forms.TextBox tbMedicamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrecioCompra;
        private System.Windows.Forms.Button bNuevoLaboratorio;
        private System.Windows.Forms.ComboBox cmbLaboratorio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bNuevaPresentacion;
        private System.Windows.Forms.TextBox tbPrecioVenta;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Button bConfig;
    }
}