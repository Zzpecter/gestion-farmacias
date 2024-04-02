namespace SoftwareFarmaciaSantaCruz
{
    partial class frmCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompra));
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.bLimpiarBusqueda = new System.Windows.Forms.Button();
            this.dgvCompraActual = new System.Windows.Forms.DataGridView();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bQuitar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.bComprar = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.bNuevoProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompraActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidad)).BeginInit();
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
            this.dgvProductos.Location = new System.Drawing.Point(12, 55);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(550, 391);
            this.dgvProductos.TabIndex = 0;
            // 
            // bLimpiarBusqueda
            // 
            this.bLimpiarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLimpiarBusqueda.ForeColor = System.Drawing.Color.Green;
            this.bLimpiarBusqueda.Location = new System.Drawing.Point(404, 10);
            this.bLimpiarBusqueda.Name = "bLimpiarBusqueda";
            this.bLimpiarBusqueda.Size = new System.Drawing.Size(86, 28);
            this.bLimpiarBusqueda.TabIndex = 17;
            this.bLimpiarBusqueda.Text = "Limpiar";
            this.bLimpiarBusqueda.UseVisualStyleBackColor = true;
            this.bLimpiarBusqueda.Click += new System.EventHandler(this.bLimpiarBusqueda_Click);
            // 
            // dgvCompraActual
            // 
            this.dgvCompraActual.AllowUserToAddRows = false;
            this.dgvCompraActual.AllowUserToDeleteRows = false;
            this.dgvCompraActual.AllowUserToResizeColumns = false;
            this.dgvCompraActual.AllowUserToResizeRows = false;
            this.dgvCompraActual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompraActual.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompraActual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCompraActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompraActual.Location = new System.Drawing.Point(660, 55);
            this.dgvCompraActual.MultiSelect = false;
            this.dgvCompraActual.Name = "dgvCompraActual";
            this.dgvCompraActual.ReadOnly = true;
            this.dgvCompraActual.RowTemplate.Height = 24;
            this.dgvCompraActual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompraActual.Size = new System.Drawing.Size(550, 391);
            this.dgvCompraActual.TabIndex = 18;
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Location = new System.Drawing.Point(159, 11);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(215, 28);
            this.tbBusqueda.TabIndex = 21;
            this.tbBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbBusqueda_KeyUp);
            // 
            // bAgregar
            // 
            this.bAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAgregar.ForeColor = System.Drawing.Color.Green;
            this.bAgregar.Location = new System.Drawing.Point(568, 248);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(86, 28);
            this.bAgregar.TabIndex = 22;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bQuitar
            // 
            this.bQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bQuitar.ForeColor = System.Drawing.Color.Green;
            this.bQuitar.Location = new System.Drawing.Point(568, 282);
            this.bQuitar.Name = "bQuitar";
            this.bQuitar.Size = new System.Drawing.Size(86, 28);
            this.bQuitar.TabIndex = 23;
            this.bQuitar.Text = "Quitar";
            this.bQuitar.UseVisualStyleBackColor = true;
            this.bQuitar.Click += new System.EventHandler(this.bQuitar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 14.2F);
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(655, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 29);
            this.label9.TabIndex = 43;
            this.label9.Text = "Compra Actual:";
            // 
            // bComprar
            // 
            this.bComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bComprar.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bComprar.ForeColor = System.Drawing.Color.Green;
            this.bComprar.Location = new System.Drawing.Point(1050, 452);
            this.bComprar.Name = "bComprar";
            this.bComprar.Size = new System.Drawing.Size(160, 87);
            this.bComprar.TabIndex = 44;
            this.bComprar.Text = "Realizar Compra";
            this.bComprar.UseVisualStyleBackColor = true;
            this.bComprar.Click += new System.EventHandler(this.bComprar_Click);
            // 
            // bLimpiar
            // 
            this.bLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLimpiar.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLimpiar.ForeColor = System.Drawing.Color.Green;
            this.bLimpiar.Location = new System.Drawing.Point(660, 453);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(160, 87);
            this.bLimpiar.TabIndex = 45;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // bVolver
            // 
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVolver.ForeColor = System.Drawing.Color.Green;
            this.bVolver.Location = new System.Drawing.Point(12, 452);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(160, 87);
            this.bVolver.TabIndex = 46;
            this.bVolver.Text = "Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bNuevoProducto
            // 
            this.bNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNuevoProducto.ForeColor = System.Drawing.Color.Green;
            this.bNuevoProducto.Location = new System.Drawing.Point(496, 10);
            this.bNuevoProducto.Name = "bNuevoProducto";
            this.bNuevoProducto.Size = new System.Drawing.Size(66, 28);
            this.bNuevoProducto.TabIndex = 44;
            this.bNuevoProducto.Text = "Nuevo";
            this.bNuevoProducto.UseVisualStyleBackColor = true;
            this.bNuevoProducto.Click += new System.EventHandler(this.bNuevoProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 11F);
            this.label1.Location = new System.Drawing.Point(564, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 47;
            this.label1.Text = "Cantidad:";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(568, 196);
            this.tbCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(82, 28);
            this.tbCantidad.TabIndex = 48;
            this.tbCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 11F);
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 23);
            this.label2.TabIndex = 49;
            this.label2.Text = "Buscar Producto:";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Impact", 14.2F);
            this.lblCosto.Location = new System.Drawing.Point(826, 510);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(70, 29);
            this.lblCosto.TabIndex = 50;
            this.lblCosto.Text = "Total: ";
            // 
            // frmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1226, 552);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bNuevoProducto);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bComprar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bQuitar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.tbBusqueda);
            this.Controls.Add(this.dgvCompraActual);
            this.Controls.Add(this.bLimpiarBusqueda);
            this.Controls.Add(this.dgvProductos);
            this.Font = new System.Drawing.Font("Impact", 10.2F);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra de productos";
            this.Load += new System.EventHandler(this.frmCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompraActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button bLimpiarBusqueda;
        private System.Windows.Forms.DataGridView dgvCompraActual;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bQuitar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bComprar;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bNuevoProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tbCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCosto;
    }
}