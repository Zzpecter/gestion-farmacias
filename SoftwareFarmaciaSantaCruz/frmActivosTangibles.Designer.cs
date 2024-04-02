namespace SoftwareFarmaciaSantaCruz
{
    partial class frmActivosTangibles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivosTangibles));
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.dgvActivosTangibles = new System.Windows.Forms.DataGridView();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivosTangibles)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(304, 21);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(215, 28);
            this.tbNombre.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nombre:";
            // 
            // bCancelar
            // 
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelar.ForeColor = System.Drawing.Color.Green;
            this.bCancelar.Location = new System.Drawing.Point(619, 21);
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
            this.bVolver.Location = new System.Drawing.Point(15, 375);
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
            this.bGuardar.Location = new System.Drawing.Point(15, 315);
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
            this.bEliminar.Location = new System.Drawing.Point(15, 142);
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
            this.bEditar.Location = new System.Drawing.Point(15, 82);
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
            this.bAgregar.Location = new System.Drawing.Point(15, 22);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(134, 54);
            this.bAgregar.TabIndex = 43;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // dgvActivosTangibles
            // 
            this.dgvActivosTangibles.AllowUserToAddRows = false;
            this.dgvActivosTangibles.AllowUserToDeleteRows = false;
            this.dgvActivosTangibles.AllowUserToResizeColumns = false;
            this.dgvActivosTangibles.AllowUserToResizeRows = false;
            this.dgvActivosTangibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActivosTangibles.BackgroundColor = System.Drawing.Color.White;
            this.dgvActivosTangibles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvActivosTangibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivosTangibles.Location = new System.Drawing.Point(191, 131);
            this.dgvActivosTangibles.MultiSelect = false;
            this.dgvActivosTangibles.Name = "dgvActivosTangibles";
            this.dgvActivosTangibles.ReadOnly = true;
            this.dgvActivosTangibles.RowTemplate.Height = 24;
            this.dgvActivosTangibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivosTangibles.Size = new System.Drawing.Size(574, 257);
            this.dgvActivosTangibles.TabIndex = 42;
            this.dgvActivosTangibles.SelectionChanged += new System.EventHandler(this.dgvActivosTangibles_SelectionChanged);
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(304, 55);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(101, 28);
            this.tbValor.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 52;
            this.label1.Text = "Valor:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Impact", 14.2F);
            this.lblValorTotal.Location = new System.Drawing.Point(620, 394);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(145, 29);
            this.lblValorTotal.TabIndex = 53;
            this.lblValorTotal.Text = "Total: 0.00 Bs.";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(304, 89);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(101, 28);
            this.tbCantidad.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 55;
            this.label3.Text = "Cantidad:";
            // 
            // frmActivosTangibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(785, 453);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bEditar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.dgvActivosTangibles);
            this.Font = new System.Drawing.Font("Impact", 10.2F);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmActivosTangibles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Activos Tangibles";
            this.Load += new System.EventHandler(this.frmActivosTangibles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivosTangibles)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvActivosTangibles;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label label3;
    }
}