namespace SoftwareFarmaciaSantaCruz
{
    partial class FrmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfig));
            this.tbTasaVenta = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPorcientoVenta = new System.Windows.Forms.Label();
            this.lblTasaVenta = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPorcientoIt = new System.Windows.Forms.Label();
            this.lblTasaIt = new System.Windows.Forms.Label();
            this.tbIt = new System.Windows.Forms.TrackBar();
            this.lblPorcientoIva = new System.Windows.Forms.Label();
            this.lblTasaIva = new System.Windows.Forms.Label();
            this.tbIva = new System.Windows.Forms.TrackBar();
            this.bVolver = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbTasaVenta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbIt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIva)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTasaVenta
            // 
            this.tbTasaVenta.Location = new System.Drawing.Point(6, 37);
            this.tbTasaVenta.Maximum = 100;
            this.tbTasaVenta.Name = "tbTasaVenta";
            this.tbTasaVenta.Size = new System.Drawing.Size(633, 56);
            this.tbTasaVenta.TabIndex = 0;
            this.tbTasaVenta.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbTasaVenta.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPorcientoVenta);
            this.groupBox1.Controls.Add(this.lblTasaVenta);
            this.groupBox1.Controls.Add(this.tbTasaVenta);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Porcentaje de Incremento al precio de Venta";
            // 
            // lblPorcientoVenta
            // 
            this.lblPorcientoVenta.AutoSize = true;
            this.lblPorcientoVenta.Font = new System.Drawing.Font("Impact", 12F);
            this.lblPorcientoVenta.Location = new System.Drawing.Point(6, 96);
            this.lblPorcientoVenta.Name = "lblPorcientoVenta";
            this.lblPorcientoVenta.Size = new System.Drawing.Size(37, 25);
            this.lblPorcientoVenta.TabIndex = 2;
            this.lblPorcientoVenta.Text = "0%";
            // 
            // lblTasaVenta
            // 
            this.lblTasaVenta.AutoSize = true;
            this.lblTasaVenta.Location = new System.Drawing.Point(160, 100);
            this.lblTasaVenta.Name = "lblTasaVenta";
            this.lblTasaVenta.Size = new System.Drawing.Size(264, 21);
            this.lblTasaVenta.TabIndex = 1;
            this.lblTasaVenta.Text = "Ej. Precio Compra/Venta: 100/100 Bs.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblPorcientoIt);
            this.groupBox2.Controls.Add(this.lblTasaIt);
            this.groupBox2.Controls.Add(this.tbIt);
            this.groupBox2.Controls.Add(this.lblPorcientoIva);
            this.groupBox2.Controls.Add(this.lblTasaIva);
            this.groupBox2.Controls.Add(this.tbIva);
            this.groupBox2.Location = new System.Drawing.Point(13, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 295);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Porcentaje de Impuestos";
            this.groupBox2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 12F);
            this.label6.Location = new System.Drawing.Point(6, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "IT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 12F);
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "IVA";
            // 
            // lblPorcientoIt
            // 
            this.lblPorcientoIt.AutoSize = true;
            this.lblPorcientoIt.Font = new System.Drawing.Font("Impact", 12F);
            this.lblPorcientoIt.Location = new System.Drawing.Point(6, 253);
            this.lblPorcientoIt.Name = "lblPorcientoIt";
            this.lblPorcientoIt.Size = new System.Drawing.Size(37, 25);
            this.lblPorcientoIt.TabIndex = 5;
            this.lblPorcientoIt.Text = "0%";
            // 
            // lblTasaIt
            // 
            this.lblTasaIt.AutoSize = true;
            this.lblTasaIt.Location = new System.Drawing.Point(160, 257);
            this.lblTasaIt.Name = "lblTasaIt";
            this.lblTasaIt.Size = new System.Drawing.Size(198, 21);
            this.lblTasaIt.TabIndex = 4;
            this.lblTasaIt.Text = "Ej. Tasa IT por 100 Bs: 3.0Bs.";
            // 
            // tbIt
            // 
            this.tbIt.Location = new System.Drawing.Point(6, 194);
            this.tbIt.Maximum = 20;
            this.tbIt.Name = "tbIt";
            this.tbIt.Size = new System.Drawing.Size(633, 56);
            this.tbIt.TabIndex = 3;
            this.tbIt.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbIt.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // lblPorcientoIva
            // 
            this.lblPorcientoIva.AutoSize = true;
            this.lblPorcientoIva.Font = new System.Drawing.Font("Impact", 12F);
            this.lblPorcientoIva.Location = new System.Drawing.Point(6, 134);
            this.lblPorcientoIva.Name = "lblPorcientoIva";
            this.lblPorcientoIva.Size = new System.Drawing.Size(37, 25);
            this.lblPorcientoIva.TabIndex = 2;
            this.lblPorcientoIva.Text = "0%";
            // 
            // lblTasaIva
            // 
            this.lblTasaIva.AutoSize = true;
            this.lblTasaIva.Location = new System.Drawing.Point(160, 138);
            this.lblTasaIva.Name = "lblTasaIva";
            this.lblTasaIva.Size = new System.Drawing.Size(199, 21);
            this.lblTasaIva.TabIndex = 1;
            this.lblTasaIva.Text = "Ej. Tasa IVA por 100Bs: 16Bs.";
            // 
            // tbIva
            // 
            this.tbIva.Location = new System.Drawing.Point(6, 75);
            this.tbIva.Maximum = 40;
            this.tbIva.Name = "tbIva";
            this.tbIva.Size = new System.Drawing.Size(633, 56);
            this.tbIva.TabIndex = 0;
            this.tbIva.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbIva.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // bVolver
            // 
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.ForeColor = System.Drawing.Color.Green;
            this.bVolver.Location = new System.Drawing.Point(177, 476);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(134, 54);
            this.bVolver.TabIndex = 34;
            this.bVolver.Text = "Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.Enabled = false;
            this.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGuardar.ForeColor = System.Drawing.Color.Green;
            this.bGuardar.Location = new System.Drawing.Point(339, 476);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(134, 54);
            this.bGuardar.TabIndex = 35;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(670, 550);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Impact", 10.2F);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbTasaVenta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbIt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar tbTasaVenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPorcientoVenta;
        private System.Windows.Forms.Label lblTasaVenta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPorcientoIt;
        private System.Windows.Forms.Label lblTasaIt;
        private System.Windows.Forms.TrackBar tbIt;
        private System.Windows.Forms.Label lblPorcientoIva;
        private System.Windows.Forms.Label lblTasaIva;
        private System.Windows.Forms.TrackBar tbIva;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bGuardar;
    }
}