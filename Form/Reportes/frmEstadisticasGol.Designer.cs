namespace TorneosFut
{
    partial class frmEstadisticasGol
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
            this.dtGoleadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDataGame = new TorneosFut.Class.dsDataGame();
            this.rvwGoleadores = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dtGoleadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataGame)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGoleadoresBindingSource
            // 
            this.dtGoleadoresBindingSource.DataMember = "dtGoleadores";
            this.dtGoleadoresBindingSource.DataSource = this.dsDataGame;
            // 
            // dsDataGame
            // 
            this.dsDataGame.DataSetName = "dsDataGame";
            this.dsDataGame.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvwGoleadores
            // 
            this.rvwGoleadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvwGoleadores.LocalReport.ReportEmbeddedResource = "TorneosFut.Form.Reportes.rptGoleador.rdlc";
            this.rvwGoleadores.Location = new System.Drawing.Point(0, 0);
            this.rvwGoleadores.Name = "rvwGoleadores";
            this.rvwGoleadores.ServerReport.BearerToken = null;
            this.rvwGoleadores.Size = new System.Drawing.Size(1184, 679);
            this.rvwGoleadores.TabIndex = 0;
            // 
            // frmEstadisticasGol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 679);
            this.Controls.Add(this.rvwGoleadores);
            this.MaximumSize = new System.Drawing.Size(1200, 718);
            this.MinimumSize = new System.Drawing.Size(1200, 718);
            this.Name = "frmEstadisticasGol";
            this.Text = "frmEstadisticasGol";
            this.Load += new System.EventHandler(this.frmEstadisticasGol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGoleadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvwGoleadores;
        private System.Windows.Forms.BindingSource dtGoleadoresBindingSource;
        private Class.dsDataGame dsDataGame;
    }
}