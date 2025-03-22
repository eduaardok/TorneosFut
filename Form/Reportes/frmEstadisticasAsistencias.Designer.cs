namespace TorneosFut
{
    partial class frmEstadisticasAsistencias
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
            this.rvwAsistidres = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsDataGame = new TorneosFut.Class.dsDataGame();
            this.dtAsistidoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsDataGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAsistidoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvwAsistidres
            // 
            this.rvwAsistidres.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsAsistencia";
            reportDataSource1.Value = this.dtAsistidoresBindingSource;
            this.rvwAsistidres.LocalReport.DataSources.Add(reportDataSource1);
            this.rvwAsistidres.LocalReport.ReportEmbeddedResource = "TorneosFut.Form.Reportes.rptAsistidor.rdlc";
            this.rvwAsistidres.Location = new System.Drawing.Point(0, 0);
            this.rvwAsistidres.Name = "rvwAsistidres";
            this.rvwAsistidres.ServerReport.BearerToken = null;
            this.rvwAsistidres.Size = new System.Drawing.Size(1030, 492);
            this.rvwAsistidres.TabIndex = 0;
            // 
            // dsDataGame
            // 
            this.dsDataGame.DataSetName = "dsDataGame";
            this.dsDataGame.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtAsistidoresBindingSource
            // 
            this.dtAsistidoresBindingSource.DataMember = "dtAsistidores";
            this.dtAsistidoresBindingSource.DataSource = this.dsDataGame;
            // 
            // frmEstadisticasAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 492);
            this.Controls.Add(this.rvwAsistidres);
            this.Name = "frmEstadisticasAsistencias";
            this.Text = "frmEstadisticasAsistencias";
            this.Load += new System.EventHandler(this.frmEstadisticasAsistencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDataGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAsistidoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvwAsistidres;
        private System.Windows.Forms.BindingSource dtAsistidoresBindingSource;
        private Class.dsDataGame dsDataGame;
    }
}