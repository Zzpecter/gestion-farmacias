namespace SoftwareFarmaciaSantaCruz
{
    partial class FrmReporteLotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteLotes));
            this.buttonVolver = new System.Windows.Forms.Button();
            this.rptvLotes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtsLotes = new SoftwareFarmaciaSantaCruz.dtsLotes();
            this.PaReporteLotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PaReporteLotesTableAdapter = new SoftwareFarmaciaSantaCruz.dtsLotesTableAdapters.PaReporteLotesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtsLotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaReporteLotesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonVolver.ForeColor = System.Drawing.Color.Green;
            this.buttonVolver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonVolver.Location = new System.Drawing.Point(13, 18);
            this.buttonVolver.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(180, 121);
            this.buttonVolver.TabIndex = 53;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // rptvLotes
            // 
            reportDataSource1.Name = "dtsReporteLotes";
            reportDataSource1.Value = this.PaReporteLotesBindingSource;
            this.rptvLotes.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvLotes.LocalReport.ReportEmbeddedResource = "SoftwareFarmaciaSantaCruz.Report3.rdlc";
            this.rptvLotes.Location = new System.Drawing.Point(12, 150);
            this.rptvLotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rptvLotes.Name = "rptvLotes";
            this.rptvLotes.Size = new System.Drawing.Size(746, 476);
            this.rptvLotes.TabIndex = 58;
            this.rptvLotes.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.rptvLotes.ZoomPercent = 170;
            // 
            // dtsLotes
            // 
            this.dtsLotes.DataSetName = "dtsLotes";
            this.dtsLotes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PaReporteLotesBindingSource
            // 
            this.PaReporteLotesBindingSource.DataMember = "PaReporteLotes";
            this.PaReporteLotesBindingSource.DataSource = this.dtsLotes;
            // 
            // PaReporteLotesTableAdapter
            // 
            this.PaReporteLotesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 638);
            this.Controls.Add(this.rptvLotes);
            this.Controls.Add(this.buttonVolver);
            this.Font = new System.Drawing.Font("Impact", 10.2F);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmReporteLotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte De Lotes y Vencimientos";
            this.Load += new System.EventHandler(this.FrmReporteLotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsLotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaReporteLotesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private Microsoft.Reporting.WinForms.ReportViewer rptvLotes;
        private System.Windows.Forms.BindingSource PaReporteLotesBindingSource;
        private dtsLotes dtsLotes;
        private dtsLotesTableAdapters.PaReporteLotesTableAdapter PaReporteLotesTableAdapter;
    }
}