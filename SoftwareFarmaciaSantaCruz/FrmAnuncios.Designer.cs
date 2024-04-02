namespace SoftwareFarmaciaSantaCruz
{
    partial class FrmAnuncios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnuncios));
            this.dgvAnuncios = new System.Windows.Forms.DataGridView();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnuncios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAnuncios
            // 
            this.dgvAnuncios.AllowUserToAddRows = false;
            this.dgvAnuncios.AllowUserToDeleteRows = false;
            this.dgvAnuncios.AllowUserToResizeColumns = false;
            this.dgvAnuncios.AllowUserToResizeRows = false;
            this.dgvAnuncios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnuncios.BackgroundColor = System.Drawing.Color.White;
            this.dgvAnuncios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAnuncios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnuncios.Location = new System.Drawing.Point(12, 41);
            this.dgvAnuncios.MultiSelect = false;
            this.dgvAnuncios.Name = "dgvAnuncios";
            this.dgvAnuncios.ReadOnly = true;
            this.dgvAnuncios.RowTemplate.Height = 24;
            this.dgvAnuncios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnuncios.Size = new System.Drawing.Size(574, 257);
            this.dgvAnuncios.TabIndex = 43;
            this.dgvAnuncios.SelectionChanged += new System.EventHandler(this.dgvAnuncios_SelectionChanged);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Impact", 14.2F);
            this.lblValorTotal.Location = new System.Drawing.Point(7, 9);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(276, 29);
            this.lblValorTotal.TabIndex = 54;
            this.lblValorTotal.Text = "Notificaciones del Sistema:";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(12, 333);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.ReadOnly = true;
            this.tbDescripcion.Size = new System.Drawing.Size(573, 112);
            this.tbDescripcion.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.2F);
            this.label1.Location = new System.Drawing.Point(7, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 56;
            this.label1.Text = "Descripcion:";
            // 
            // bVolver
            // 
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.ForeColor = System.Drawing.Color.Green;
            this.bVolver.Location = new System.Drawing.Point(239, 451);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(134, 54);
            this.bVolver.TabIndex = 57;
            this.bVolver.Text = "Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // FrmAnuncios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(601, 512);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.dgvAnuncios);
            this.Font = new System.Drawing.Font("Impact", 10.2F);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmAnuncios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anuncios";
            this.Load += new System.EventHandler(this.FrmAnuncios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnuncios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAnuncios;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bVolver;
    }
}