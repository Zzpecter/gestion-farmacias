namespace SoftwareFarmaciaSantaCruz
{
    partial class FrmReciboVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReciboVenta));
            this.pbRecibo = new System.Windows.Forms.PictureBox();
            this.bImprimir = new System.Windows.Forms.Button();
            this.bTerminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecibo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRecibo
            // 
            this.pbRecibo.Location = new System.Drawing.Point(12, 12);
            this.pbRecibo.Name = "pbRecibo";
            this.pbRecibo.Size = new System.Drawing.Size(800, 506);
            this.pbRecibo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRecibo.TabIndex = 0;
            this.pbRecibo.TabStop = false;
            // 
            // bImprimir
            // 
            this.bImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bImprimir.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bImprimir.ForeColor = System.Drawing.Color.Green;
            this.bImprimir.Location = new System.Drawing.Point(652, 524);
            this.bImprimir.Name = "bImprimir";
            this.bImprimir.Size = new System.Drawing.Size(160, 87);
            this.bImprimir.TabIndex = 51;
            this.bImprimir.Text = "Imprimir";
            this.bImprimir.UseVisualStyleBackColor = true;
            this.bImprimir.Click += new System.EventHandler(this.bImprimir_Click);
            // 
            // bTerminar
            // 
            this.bTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTerminar.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTerminar.ForeColor = System.Drawing.Color.Green;
            this.bTerminar.Location = new System.Drawing.Point(12, 524);
            this.bTerminar.Name = "bTerminar";
            this.bTerminar.Size = new System.Drawing.Size(160, 87);
            this.bTerminar.TabIndex = 53;
            this.bTerminar.Text = "Listo";
            this.bTerminar.UseVisualStyleBackColor = true;
            this.bTerminar.Click += new System.EventHandler(this.bTerminar_Click);
            // 
            // FrmReciboVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 618);
            this.Controls.Add(this.bTerminar);
            this.Controls.Add(this.bImprimir);
            this.Controls.Add(this.pbRecibo);
            this.Font = new System.Drawing.Font("Impact", 10.2F);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmReciboVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recibo Venta";
            this.Load += new System.EventHandler(this.FrmReciboVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRecibo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRecibo;
        private System.Windows.Forms.Button bImprimir;
        private System.Windows.Forms.Button bTerminar;
    }
}