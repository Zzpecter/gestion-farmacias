namespace SoftwareFarmaciaSantaCruz
{
    partial class frmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bNuevoCliente = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbNit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bQuitar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.dgvVentaActual = new System.Windows.Forms.DataGridView();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.bVolver = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.bVender = new System.Windows.Forms.Button();
            this.tbCantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.bLimpiarBusqueda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentaActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(32, 42);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(571, 308);
            this.dgvProductos.TabIndex = 22;
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bNuevoCliente);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.tbNit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(762, 387);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 93);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente:";
            // 
            // bNuevoCliente
            // 
            this.bNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNuevoCliente.ForeColor = System.Drawing.Color.Green;
            this.bNuevoCliente.Location = new System.Drawing.Point(249, 21);
            this.bNuevoCliente.Name = "bNuevoCliente";
            this.bNuevoCliente.Size = new System.Drawing.Size(86, 28);
            this.bNuevoCliente.TabIndex = 58;
            this.bNuevoCliente.Text = "Nuevo";
            this.bNuevoCliente.UseVisualStyleBackColor = true;
            this.bNuevoCliente.Click += new System.EventHandler(this.bNuevoCliente_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(120, 56);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(215, 28);
            this.tbNombre.TabIndex = 24;
            this.tbNombre.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 21);
            this.lblNombre.TabIndex = 25;
            this.lblNombre.Text = "Nombre:";
            // 
            // tbNit
            // 
            this.tbNit.Location = new System.Drawing.Point(120, 22);
            this.tbNit.Name = "tbNit";
            this.tbNit.Size = new System.Drawing.Size(103, 28);
            this.tbNit.TabIndex = 26;
            this.tbNit.TextChanged += new System.EventHandler(this.tbNit_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "NIT:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 14.2F);
            this.label9.Location = new System.Drawing.Point(800, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 29);
            this.label9.TabIndex = 48;
            this.label9.Text = "Venta Actual:";
            // 
            // bQuitar
            // 
            this.bQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bQuitar.ForeColor = System.Drawing.Color.Green;
            this.bQuitar.Location = new System.Drawing.Point(609, 224);
            this.bQuitar.Name = "bQuitar";
            this.bQuitar.Size = new System.Drawing.Size(86, 28);
            this.bQuitar.TabIndex = 47;
            this.bQuitar.Text = "Quitar";
            this.bQuitar.UseVisualStyleBackColor = true;
            this.bQuitar.Click += new System.EventHandler(this.bQuitar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAgregar.ForeColor = System.Drawing.Color.Green;
            this.bAgregar.Location = new System.Drawing.Point(609, 190);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(86, 28);
            this.bAgregar.TabIndex = 46;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // dgvVentaActual
            // 
            this.dgvVentaActual.AllowUserToAddRows = false;
            this.dgvVentaActual.AllowUserToDeleteRows = false;
            this.dgvVentaActual.AllowUserToResizeColumns = false;
            this.dgvVentaActual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentaActual.BackgroundColor = System.Drawing.Color.White;
            this.dgvVentaActual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVentaActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentaActual.Location = new System.Drawing.Point(701, 41);
            this.dgvVentaActual.MultiSelect = false;
            this.dgvVentaActual.Name = "dgvVentaActual";
            this.dgvVentaActual.ReadOnly = true;
            this.dgvVentaActual.RowTemplate.Height = 24;
            this.dgvVentaActual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentaActual.Size = new System.Drawing.Size(571, 308);
            this.dgvVentaActual.TabIndex = 45;
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Impact", 14.2F);
            this.lblPrecioTotal.Location = new System.Drawing.Point(1127, 353);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(145, 29);
            this.lblPrecioTotal.TabIndex = 49;
            this.lblPrecioTotal.Text = "Total: 0.00 Bs.";
            // 
            // bVolver
            // 
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVolver.ForeColor = System.Drawing.Color.Green;
            this.bVolver.Location = new System.Drawing.Point(32, 394);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(160, 87);
            this.bVolver.TabIndex = 52;
            this.bVolver.Text = "Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bLimpiar
            // 
            this.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLimpiar.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLimpiar.ForeColor = System.Drawing.Color.Green;
            this.bLimpiar.Location = new System.Drawing.Point(596, 394);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(160, 87);
            this.bLimpiar.TabIndex = 51;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // bVender
            // 
            this.bVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVender.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVender.ForeColor = System.Drawing.Color.Green;
            this.bVender.Location = new System.Drawing.Point(1112, 394);
            this.bVender.Name = "bVender";
            this.bVender.Size = new System.Drawing.Size(160, 87);
            this.bVender.TabIndex = 50;
            this.bVender.Text = "Realizar Venta";
            this.bVender.UseVisualStyleBackColor = true;
            this.bVender.Click += new System.EventHandler(this.bVender_Click);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(609, 144);
            this.tbCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(82, 28);
            this.tbCantidad.TabIndex = 54;
            this.tbCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 11F);
            this.label1.Location = new System.Drawing.Point(605, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 53;
            this.label1.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 11F);
            this.label4.Location = new System.Drawing.Point(32, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 23);
            this.label4.TabIndex = 57;
            this.label4.Text = "Buscar Producto:";
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Location = new System.Drawing.Point(183, 9);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(215, 28);
            this.tbBusqueda.TabIndex = 56;
            this.tbBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbBusqueda_KeyUp);
            // 
            // bLimpiarBusqueda
            // 
            this.bLimpiarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLimpiarBusqueda.ForeColor = System.Drawing.Color.Green;
            this.bLimpiarBusqueda.Location = new System.Drawing.Point(428, 8);
            this.bLimpiarBusqueda.Name = "bLimpiarBusqueda";
            this.bLimpiarBusqueda.Size = new System.Drawing.Size(86, 28);
            this.bLimpiarBusqueda.TabIndex = 55;
            this.bLimpiarBusqueda.Text = "Limpiar";
            this.bLimpiarBusqueda.UseVisualStyleBackColor = true;
            this.bLimpiarBusqueda.Click += new System.EventHandler(this.bLimpiarBusqueda_Click);
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1290, 488);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbBusqueda);
            this.Controls.Add(this.bLimpiarBusqueda);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bVender);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bQuitar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.dgvVentaActual);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProductos);
            this.Font = new System.Drawing.Font("Impact", 10.2F);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta de productos";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentaActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbNit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bQuitar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.DataGridView dgvVentaActual;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button bVender;
        private System.Windows.Forms.NumericUpDown tbCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bNuevoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Button bLimpiarBusqueda;
    }
}