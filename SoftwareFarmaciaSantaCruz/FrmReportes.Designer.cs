namespace SoftwareFarmaciaSantaCruz
{
    partial class FrmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PaReporteComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsCV = new SoftwareFarmaciaSantaCruz.dtsCV();
            this.PaReporteVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PaReporteCompletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BDDFarmaciaDataSet = new SoftwareFarmaciaSantaCruz.BDDFarmaciaDataSet();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.gbTemporada = new System.Windows.Forms.GroupBox();
            this.rbDiario = new System.Windows.Forms.RadioButton();
            this.dtpDia = new System.Windows.Forms.DateTimePicker();
            this.rbAnual = new System.Windows.Forms.RadioButton();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbAnho = new System.Windows.Forms.ComboBox();
            this.rbMensual = new System.Windows.Forms.RadioButton();
            this.rptvCompra = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PaReporteCompletoTableAdapter = new SoftwareFarmaciaSantaCruz.BDDFarmaciaDataSetTableAdapters.PaReporteCompletoTableAdapter();
            this.BDDFarmaciaDataSet1 = new SoftwareFarmaciaSantaCruz.BDDFarmaciaDataSet1();
            this.rbCompra = new System.Windows.Forms.RadioButton();
            this.rbVenta = new System.Windows.Forms.RadioButton();
            this.PaReporteComprasTableAdapter = new SoftwareFarmaciaSantaCruz.dtsCVTableAdapters.PaReporteComprasTableAdapter();
            this.rptvVenta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PaReporteVentasTableAdapter = new SoftwareFarmaciaSantaCruz.dtsCVTableAdapters.PaReporteVentasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PaReporteComprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaReporteVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaReporteCompletoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDDFarmaciaDataSet)).BeginInit();
            this.gbTemporada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BDDFarmaciaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // PaReporteComprasBindingSource
            // 
            this.PaReporteComprasBindingSource.DataMember = "PaReporteCompras";
            this.PaReporteComprasBindingSource.DataSource = this.dtsCV;
            // 
            // dtsCV
            // 
            this.dtsCV.DataSetName = "dtsCV";
            this.dtsCV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PaReporteVentasBindingSource
            // 
            this.PaReporteVentasBindingSource.DataMember = "PaReporteVentas";
            this.PaReporteVentasBindingSource.DataSource = this.dtsCV;
            // 
            // PaReporteCompletoBindingSource
            // 
            this.PaReporteCompletoBindingSource.DataMember = "PaReporteCompleto";
            this.PaReporteCompletoBindingSource.DataSource = this.BDDFarmaciaDataSet;
            // 
            // BDDFarmaciaDataSet
            // 
            this.BDDFarmaciaDataSet.DataSetName = "BDDFarmaciaDataSet";
            this.BDDFarmaciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonVolver
            // 
            resources.ApplyResources(this.buttonVolver, "buttonVolver");
            this.buttonVolver.ForeColor = System.Drawing.Color.Green;
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // gbTemporada
            // 
            this.gbTemporada.Controls.Add(this.rbDiario);
            this.gbTemporada.Controls.Add(this.dtpDia);
            this.gbTemporada.Controls.Add(this.rbAnual);
            this.gbTemporada.Controls.Add(this.cmbMes);
            this.gbTemporada.Controls.Add(this.cmbAnho);
            this.gbTemporada.Controls.Add(this.rbMensual);
            this.gbTemporada.ForeColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.gbTemporada, "gbTemporada");
            this.gbTemporada.Name = "gbTemporada";
            this.gbTemporada.TabStop = false;
            // 
            // rbDiario
            // 
            resources.ApplyResources(this.rbDiario, "rbDiario");
            this.rbDiario.Checked = true;
            this.rbDiario.ForeColor = System.Drawing.Color.Navy;
            this.rbDiario.Name = "rbDiario";
            this.rbDiario.TabStop = true;
            this.rbDiario.UseVisualStyleBackColor = true;
            this.rbDiario.CheckedChanged += new System.EventHandler(this.AccionRealizada);
            // 
            // dtpDia
            // 
            this.dtpDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtpDia, "dtpDia");
            this.dtpDia.Name = "dtpDia";
            this.dtpDia.ValueChanged += new System.EventHandler(this.AccionRealizada);
            // 
            // rbAnual
            // 
            resources.ApplyResources(this.rbAnual, "rbAnual");
            this.rbAnual.ForeColor = System.Drawing.Color.Navy;
            this.rbAnual.Name = "rbAnual";
            this.rbAnual.UseVisualStyleBackColor = true;
            this.rbAnual.CheckedChanged += new System.EventHandler(this.AccionRealizada);
            // 
            // cmbMes
            // 
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.FormattingEnabled = true;
            resources.ApplyResources(this.cmbMes, "cmbMes");
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.SelectedIndexChanged += new System.EventHandler(this.AccionRealizada);
            // 
            // cmbAnho
            // 
            this.cmbAnho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnho.FormattingEnabled = true;
            resources.ApplyResources(this.cmbAnho, "cmbAnho");
            this.cmbAnho.Name = "cmbAnho";
            this.cmbAnho.SelectedIndexChanged += new System.EventHandler(this.AccionRealizada);
            // 
            // rbMensual
            // 
            resources.ApplyResources(this.rbMensual, "rbMensual");
            this.rbMensual.ForeColor = System.Drawing.Color.Navy;
            this.rbMensual.Name = "rbMensual";
            this.rbMensual.UseVisualStyleBackColor = true;
            this.rbMensual.CheckedChanged += new System.EventHandler(this.AccionRealizada);
            // 
            // rptvCompra
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PaReporteComprasBindingSource;
            this.rptvCompra.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvCompra.LocalReport.ReportEmbeddedResource = "SoftwareFarmaciaSantaCruz.rptCompra.rdlc";
            resources.ApplyResources(this.rptvCompra, "rptvCompra");
            this.rptvCompra.Name = "rptvCompra";
            this.rptvCompra.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // PaReporteCompletoTableAdapter
            // 
            this.PaReporteCompletoTableAdapter.ClearBeforeFill = true;
            // 
            // BDDFarmaciaDataSet1
            // 
            this.BDDFarmaciaDataSet1.DataSetName = "BDDFarmaciaDataSet1";
            this.BDDFarmaciaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rbCompra
            // 
            resources.ApplyResources(this.rbCompra, "rbCompra");
            this.rbCompra.Checked = true;
            this.rbCompra.ForeColor = System.Drawing.Color.Navy;
            this.rbCompra.Name = "rbCompra";
            this.rbCompra.TabStop = true;
            this.rbCompra.UseVisualStyleBackColor = true;
            this.rbCompra.CheckedChanged += new System.EventHandler(this.AccionRealizada);
            // 
            // rbVenta
            // 
            resources.ApplyResources(this.rbVenta, "rbVenta");
            this.rbVenta.ForeColor = System.Drawing.Color.Navy;
            this.rbVenta.Name = "rbVenta";
            this.rbVenta.UseVisualStyleBackColor = true;
            this.rbVenta.CheckedChanged += new System.EventHandler(this.AccionRealizada);
            // 
            // PaReporteComprasTableAdapter
            // 
            this.PaReporteComprasTableAdapter.ClearBeforeFill = true;
            // 
            // rptvVenta
            // 
            reportDataSource2.Name = "dtsVenta";
            reportDataSource2.Value = this.PaReporteVentasBindingSource;
            this.rptvVenta.LocalReport.DataSources.Add(reportDataSource2);
            this.rptvVenta.LocalReport.ReportEmbeddedResource = "SoftwareFarmaciaSantaCruz.rptVenta.rdlc";
            resources.ApplyResources(this.rptvVenta, "rptvVenta");
            this.rptvVenta.Name = "rptvVenta";
            this.rptvVenta.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // PaReporteVentasTableAdapter
            // 
            this.PaReporteVentasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rptvVenta);
            this.Controls.Add(this.rbVenta);
            this.Controls.Add(this.rbCompra);
            this.Controls.Add(this.rptvCompra);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.gbTemporada);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "FrmReportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaReporteComprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaReporteVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaReporteCompletoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDDFarmaciaDataSet)).EndInit();
            this.gbTemporada.ResumeLayout(false);
            this.gbTemporada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BDDFarmaciaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.GroupBox gbTemporada;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbAnho;
        private System.Windows.Forms.RadioButton rbAnual;
        private System.Windows.Forms.RadioButton rbMensual;
        private System.Windows.Forms.DateTimePicker dtpDia;
        private Microsoft.Reporting.WinForms.ReportViewer rptvCompra;
        private System.Windows.Forms.BindingSource PaReporteCompletoBindingSource;
        private BDDFarmaciaDataSet BDDFarmaciaDataSet;
        private BDDFarmaciaDataSetTableAdapters.PaReporteCompletoTableAdapter PaReporteCompletoTableAdapter;
        private BDDFarmaciaDataSet1 BDDFarmaciaDataSet1;
        private System.Windows.Forms.RadioButton rbDiario;
        private System.Windows.Forms.RadioButton rbCompra;
        private System.Windows.Forms.RadioButton rbVenta;
        private System.Windows.Forms.BindingSource PaReporteComprasBindingSource;
        private dtsCV dtsCV;
        private dtsCVTableAdapters.PaReporteComprasTableAdapter PaReporteComprasTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rptvVenta;
        private System.Windows.Forms.BindingSource PaReporteVentasBindingSource;
        private dtsCVTableAdapters.PaReporteVentasTableAdapter PaReporteVentasTableAdapter;
    }
}