namespace SoftwareFarmaciaSantaCruz
{
    partial class FrmReportes2
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes2));
            this.PaReporteLaboratoriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsClientesLab = new SoftwareFarmaciaSantaCruz.dtsClientesLab();
            this.PaReporteClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonVolver = new System.Windows.Forms.Button();
            this.rptvProveedores = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rbProveedores = new System.Windows.Forms.RadioButton();
            this.rbClientes = new System.Windows.Forms.RadioButton();
            this.rptvClientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PaReporteLaboratoriosTableAdapter = new SoftwareFarmaciaSantaCruz.dtsClientesLabTableAdapters.PaReporteLaboratoriosTableAdapter();
            this.PaReporteClientesTableAdapter = new SoftwareFarmaciaSantaCruz.dtsClientesLabTableAdapters.PaReporteClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PaReporteLaboratoriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsClientesLab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaReporteClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PaReporteLaboratoriosBindingSource
            // 
            this.PaReporteLaboratoriosBindingSource.DataMember = "PaReporteLaboratorios";
            this.PaReporteLaboratoriosBindingSource.DataSource = this.dtsClientesLab;
            // 
            // dtsClientesLab
            // 
            this.dtsClientesLab.DataSetName = "dtsClientesLab";
            this.dtsClientesLab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PaReporteClientesBindingSource
            // 
            this.PaReporteClientesBindingSource.DataMember = "PaReporteClientes";
            this.PaReporteClientesBindingSource.DataSource = this.dtsClientesLab;
            // 
            // buttonVolver
            // 
            this.buttonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonVolver.ForeColor = System.Drawing.Color.Green;
            this.buttonVolver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonVolver.Location = new System.Drawing.Point(13, 14);
            this.buttonVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(180, 92);
            this.buttonVolver.TabIndex = 52;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // rptvProveedores
            // 
            reportDataSource1.Name = "dtsLab";
            reportDataSource1.Value = this.PaReporteLaboratoriosBindingSource;
            this.rptvProveedores.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvProveedores.LocalReport.ReportEmbeddedResource = "SoftwareFarmaciaSantaCruz.rptLabs.rdlc";
            this.rptvProveedores.Location = new System.Drawing.Point(12, 123);
            this.rptvProveedores.Name = "rptvProveedores";
            this.rptvProveedores.Size = new System.Drawing.Size(746, 363);
            this.rptvProveedores.TabIndex = 53;
            this.rptvProveedores.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.rptvProveedores.ZoomPercent = 200;
            // 
            // rbProveedores
            // 
            this.rbProveedores.AutoSize = true;
            this.rbProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rbProveedores.ForeColor = System.Drawing.Color.Navy;
            this.rbProveedores.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbProveedores.Location = new System.Drawing.Point(492, 15);
            this.rbProveedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbProveedores.Name = "rbProveedores";
            this.rbProveedores.Size = new System.Drawing.Size(266, 29);
            this.rbProveedores.TabIndex = 56;
            this.rbProveedores.Text = "Reporte de Proveedores";
            this.rbProveedores.UseVisualStyleBackColor = true;
            this.rbProveedores.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbClientes
            // 
            this.rbClientes.AutoSize = true;
            this.rbClientes.Checked = true;
            this.rbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rbClientes.ForeColor = System.Drawing.Color.Navy;
            this.rbClientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbClientes.Location = new System.Drawing.Point(211, 15);
            this.rbClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbClientes.Name = "rbClientes";
            this.rbClientes.Size = new System.Drawing.Size(223, 29);
            this.rbClientes.TabIndex = 55;
            this.rbClientes.TabStop = true;
            this.rbClientes.Text = "Reporte de Clientes";
            this.rbClientes.UseVisualStyleBackColor = true;
            this.rbClientes.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rptvClientes
            // 
            reportDataSource2.Name = "dtsCliente";
            reportDataSource2.Value = this.PaReporteClientesBindingSource;
            this.rptvClientes.LocalReport.DataSources.Add(reportDataSource2);
            this.rptvClientes.LocalReport.ReportEmbeddedResource = "SoftwareFarmaciaSantaCruz.rptClientes.rdlc";
            this.rptvClientes.Location = new System.Drawing.Point(12, 123);
            this.rptvClientes.Name = "rptvClientes";
            this.rptvClientes.Size = new System.Drawing.Size(746, 363);
            this.rptvClientes.TabIndex = 57;
            this.rptvClientes.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.rptvClientes.ZoomPercent = 170;
            // 
            // PaReporteLaboratoriosTableAdapter
            // 
            this.PaReporteLaboratoriosTableAdapter.ClearBeforeFill = true;
            // 
            // PaReporteClientesTableAdapter
            // 
            this.PaReporteClientesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportes2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 498);
            this.Controls.Add(this.rptvClientes);
            this.Controls.Add(this.rbProveedores);
            this.Controls.Add(this.rbClientes);
            this.Controls.Add(this.rptvProveedores);
            this.Controls.Add(this.buttonVolver);
            this.Font = new System.Drawing.Font("Impact", 10.2F);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmReportes2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Clientes y Proveedores";
            this.Load += new System.EventHandler(this.FrmReportes2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaReporteLaboratoriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsClientesLab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaReporteClientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private Microsoft.Reporting.WinForms.ReportViewer rptvProveedores;
        private System.Windows.Forms.RadioButton rbProveedores;
        private System.Windows.Forms.RadioButton rbClientes;
        private Microsoft.Reporting.WinForms.ReportViewer rptvClientes;
        private System.Windows.Forms.BindingSource PaReporteLaboratoriosBindingSource;
        private dtsClientesLab dtsClientesLab;
        private dtsClientesLabTableAdapters.PaReporteLaboratoriosTableAdapter PaReporteLaboratoriosTableAdapter;
        private System.Windows.Forms.BindingSource PaReporteClientesBindingSource;
        private dtsClientesLabTableAdapters.PaReporteClientesTableAdapter PaReporteClientesTableAdapter;
    }
}