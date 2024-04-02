namespace SoftwareFarmaciaSantaCruz
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.bCerrarSesion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bCompra = new System.Windows.Forms.Button();
            this.bVenta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bProductos = new System.Windows.Forms.Button();
            this.bActivosTangibles = new System.Windows.Forms.Button();
            this.bPresentaciones = new System.Windows.Forms.Button();
            this.bLaboratorios = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bClientes = new System.Windows.Forms.Button();
            this.bUsuarios = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bReporte1 = new System.Windows.Forms.Button();
            this.bReporte0 = new System.Windows.Forms.Button();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.bCambiarContrasenha = new System.Windows.Forms.Button();
            this.bReporteLotes = new System.Windows.Forms.Button();
            this.bConfig = new System.Windows.Forms.Button();
            this.bAnuncios = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Navy;
            this.lblUsuario.Location = new System.Drawing.Point(12, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(296, 41);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Bienvenido, usuario!";
            // 
            // bCerrarSesion
            // 
            this.bCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCerrarSesion.ForeColor = System.Drawing.Color.Green;
            this.bCerrarSesion.Location = new System.Drawing.Point(744, 16);
            this.bCerrarSesion.Name = "bCerrarSesion";
            this.bCerrarSesion.Size = new System.Drawing.Size(93, 54);
            this.bCerrarSesion.TabIndex = 6;
            this.bCerrarSesion.Text = "Cerar Sesión";
            this.bCerrarSesion.UseVisualStyleBackColor = true;
            this.bCerrarSesion.Click += new System.EventHandler(this.bCerrarSesion_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(744, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bCompra
            // 
            this.bCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCompra.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCompra.ForeColor = System.Drawing.Color.Green;
            this.bCompra.Location = new System.Drawing.Point(19, 128);
            this.bCompra.Name = "bCompra";
            this.bCompra.Size = new System.Drawing.Size(160, 87);
            this.bCompra.TabIndex = 8;
            this.bCompra.Text = "Compra";
            this.bCompra.UseVisualStyleBackColor = true;
            this.bCompra.Click += new System.EventHandler(this.bCompra_Click);
            // 
            // bVenta
            // 
            this.bVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVenta.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVenta.ForeColor = System.Drawing.Color.Green;
            this.bVenta.Location = new System.Drawing.Point(205, 128);
            this.bVenta.Name = "bVenta";
            this.bVenta.Size = new System.Drawing.Size(160, 87);
            this.bVenta.TabIndex = 9;
            this.bVenta.Text = "Venta";
            this.bVenta.UseVisualStyleBackColor = true;
            this.bVenta.Click += new System.EventHandler(this.bVenta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bProductos);
            this.groupBox1.Controls.Add(this.bActivosTangibles);
            this.groupBox1.Controls.Add(this.bPresentaciones);
            this.groupBox1.Controls.Add(this.bLaboratorios);
            this.groupBox1.Location = new System.Drawing.Point(19, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 176);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // bProductos
            // 
            this.bProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bProductos.ForeColor = System.Drawing.Color.Green;
            this.bProductos.Location = new System.Drawing.Point(6, 27);
            this.bProductos.Name = "bProductos";
            this.bProductos.Size = new System.Drawing.Size(134, 54);
            this.bProductos.TabIndex = 14;
            this.bProductos.Text = "Almacen";
            this.bProductos.UseVisualStyleBackColor = true;
            this.bProductos.Click += new System.EventHandler(this.bProductos_Click);
            // 
            // bActivosTangibles
            // 
            this.bActivosTangibles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bActivosTangibles.ForeColor = System.Drawing.Color.Green;
            this.bActivosTangibles.Location = new System.Drawing.Point(6, 96);
            this.bActivosTangibles.Name = "bActivosTangibles";
            this.bActivosTangibles.Size = new System.Drawing.Size(134, 54);
            this.bActivosTangibles.TabIndex = 13;
            this.bActivosTangibles.Text = "Gestión activos Tangibles";
            this.bActivosTangibles.UseVisualStyleBackColor = true;
            this.bActivosTangibles.Click += new System.EventHandler(this.bActivosTangibles_Click);
            // 
            // bPresentaciones
            // 
            this.bPresentaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPresentaciones.ForeColor = System.Drawing.Color.Green;
            this.bPresentaciones.Location = new System.Drawing.Point(146, 27);
            this.bPresentaciones.Name = "bPresentaciones";
            this.bPresentaciones.Size = new System.Drawing.Size(134, 54);
            this.bPresentaciones.TabIndex = 12;
            this.bPresentaciones.Text = "Gestión Presentaciones";
            this.bPresentaciones.UseVisualStyleBackColor = true;
            this.bPresentaciones.Click += new System.EventHandler(this.bPresentaciones_Click);
            // 
            // bLaboratorios
            // 
            this.bLaboratorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLaboratorios.ForeColor = System.Drawing.Color.Green;
            this.bLaboratorios.Location = new System.Drawing.Point(146, 96);
            this.bLaboratorios.Name = "bLaboratorios";
            this.bLaboratorios.Size = new System.Drawing.Size(134, 54);
            this.bLaboratorios.TabIndex = 11;
            this.bLaboratorios.Text = "Gestión Laboratorios";
            this.bLaboratorios.UseVisualStyleBackColor = true;
            this.bLaboratorios.Click += new System.EventHandler(this.bLaboratorios_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bClientes);
            this.groupBox2.Controls.Add(this.bUsuarios);
            this.groupBox2.Location = new System.Drawing.Point(386, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 96);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personas";
            // 
            // bClientes
            // 
            this.bClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClientes.ForeColor = System.Drawing.Color.Green;
            this.bClientes.Location = new System.Drawing.Point(146, 27);
            this.bClientes.Name = "bClientes";
            this.bClientes.Size = new System.Drawing.Size(134, 54);
            this.bClientes.TabIndex = 15;
            this.bClientes.Text = "Gestión de Clientes";
            this.bClientes.UseVisualStyleBackColor = true;
            this.bClientes.Click += new System.EventHandler(this.bClientes_Click);
            // 
            // bUsuarios
            // 
            this.bUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUsuarios.ForeColor = System.Drawing.Color.Green;
            this.bUsuarios.Location = new System.Drawing.Point(6, 27);
            this.bUsuarios.Name = "bUsuarios";
            this.bUsuarios.Size = new System.Drawing.Size(134, 54);
            this.bUsuarios.TabIndex = 14;
            this.bUsuarios.Text = "Gestión de Usuarios";
            this.bUsuarios.UseVisualStyleBackColor = true;
            this.bUsuarios.Click += new System.EventHandler(this.bUsuarios_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bReporteLotes);
            this.groupBox3.Controls.Add(this.bReporte1);
            this.groupBox3.Controls.Add(this.bReporte0);
            this.groupBox3.Location = new System.Drawing.Point(386, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 161);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reportes";
            // 
            // bReporte1
            // 
            this.bReporte1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReporte1.Font = new System.Drawing.Font("Impact", 8F);
            this.bReporte1.ForeColor = System.Drawing.Color.Green;
            this.bReporte1.Location = new System.Drawing.Point(154, 27);
            this.bReporte1.Name = "bReporte1";
            this.bReporte1.Size = new System.Drawing.Size(142, 57);
            this.bReporte1.TabIndex = 15;
            this.bReporte1.Text = "Reportes de Clientes y Proveedores";
            this.bReporte1.UseVisualStyleBackColor = true;
            this.bReporte1.Click += new System.EventHandler(this.bReporte1_Click_1);
            // 
            // bReporte0
            // 
            this.bReporte0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReporte0.ForeColor = System.Drawing.Color.Green;
            this.bReporte0.Location = new System.Drawing.Point(6, 27);
            this.bReporte0.Name = "bReporte0";
            this.bReporte0.Size = new System.Drawing.Size(142, 57);
            this.bReporte0.TabIndex = 14;
            this.bReporte0.Text = "Reportes de Compras/Ventas";
            this.bReporte0.UseVisualStyleBackColor = true;
            this.bReporte0.Click += new System.EventHandler(this.bReporte0_Click);
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Italic);
            this.lblAdvertencia.ForeColor = System.Drawing.Color.Navy;
            this.lblAdvertencia.Location = new System.Drawing.Point(466, 35);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(272, 29);
            this.lblAdvertencia.TabIndex = 20;
            this.lblAdvertencia.Text = "No tiene mensajes nuevos.";
            // 
            // bCambiarContrasenha
            // 
            this.bCambiarContrasenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCambiarContrasenha.Font = new System.Drawing.Font("Impact", 9F);
            this.bCambiarContrasenha.ForeColor = System.Drawing.Color.Green;
            this.bCambiarContrasenha.Location = new System.Drawing.Point(744, 76);
            this.bCambiarContrasenha.Name = "bCambiarContrasenha";
            this.bCambiarContrasenha.Size = new System.Drawing.Size(93, 54);
            this.bCambiarContrasenha.TabIndex = 22;
            this.bCambiarContrasenha.Text = "Cambiar Contraseña";
            this.bCambiarContrasenha.UseVisualStyleBackColor = true;
            this.bCambiarContrasenha.Click += new System.EventHandler(this.bCambiarContrasenha_Click);
            // 
            // bReporteLotes
            // 
            this.bReporteLotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReporteLotes.Font = new System.Drawing.Font("Impact", 8F);
            this.bReporteLotes.ForeColor = System.Drawing.Color.Green;
            this.bReporteLotes.Location = new System.Drawing.Point(85, 90);
            this.bReporteLotes.Name = "bReporteLotes";
            this.bReporteLotes.Size = new System.Drawing.Size(142, 57);
            this.bReporteLotes.TabIndex = 16;
            this.bReporteLotes.Text = "Reporte de Lotes/Vencimientos";
            this.bReporteLotes.UseVisualStyleBackColor = true;
            this.bReporteLotes.Click += new System.EventHandler(this.bReporteLotes_Click);
            // 
            // bConfig
            // 
            this.bConfig.BackgroundImage = global::SoftwareFarmaciaSantaCruz.Properties.Resources.config;
            this.bConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConfig.ForeColor = System.Drawing.Color.Green;
            this.bConfig.Location = new System.Drawing.Point(801, 139);
            this.bConfig.Name = "bConfig";
            this.bConfig.Size = new System.Drawing.Size(36, 36);
            this.bConfig.TabIndex = 62;
            this.bConfig.UseVisualStyleBackColor = true;
            this.bConfig.Click += new System.EventHandler(this.bConfig_Click);
            // 
            // bAnuncios
            // 
            this.bAnuncios.BackgroundImage = global::SoftwareFarmaciaSantaCruz.Properties.Resources.ok;
            this.bAnuncios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAnuncios.ForeColor = System.Drawing.Color.Green;
            this.bAnuncios.Location = new System.Drawing.Point(375, 9);
            this.bAnuncios.Name = "bAnuncios";
            this.bAnuncios.Size = new System.Drawing.Size(85, 85);
            this.bAnuncios.TabIndex = 21;
            this.bAnuncios.UseVisualStyleBackColor = true;
            this.bAnuncios.Click += new System.EventHandler(this.bAnuncios_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 428);
            this.Controls.Add(this.bConfig);
            this.Controls.Add(this.bCambiarContrasenha);
            this.Controls.Add(this.bAnuncios);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bVenta);
            this.Controls.Add(this.bCompra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bCerrarSesion);
            this.Controls.Add(this.lblUsuario);
            this.Font = new System.Drawing.Font("Impact", 10.2F);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal - Gestión de Farmacia Santa Cruz";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button bCerrarSesion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bCompra;
        private System.Windows.Forms.Button bVenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bProductos;
        private System.Windows.Forms.Button bActivosTangibles;
        private System.Windows.Forms.Button bPresentaciones;
        private System.Windows.Forms.Button bLaboratorios;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bClientes;
        private System.Windows.Forms.Button bUsuarios;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bReporte0;
        private System.Windows.Forms.Label lblAdvertencia;
        private System.Windows.Forms.Button bAnuncios;
        private System.Windows.Forms.Button bCambiarContrasenha;
        private System.Windows.Forms.Button bReporte1;
        private System.Windows.Forms.Button bConfig;
        private System.Windows.Forms.Button bReporteLotes;
    }
}