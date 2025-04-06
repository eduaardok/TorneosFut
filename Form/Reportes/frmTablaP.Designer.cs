namespace TorneosFut.Class
{
    partial class frmTablaP
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
            this.rvwTablaPos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsDataGame = new TorneosFut.Class.dsDataGame();
            this.dtTablaPosicionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsDataGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTablaPosicionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvwTablaPos
            // 
            this.rvwTablaPos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvwTablaPos.LocalReport.ReportEmbeddedResource = "TorneosFut.rptPosiciones.rdlc";
            this.rvwTablaPos.Location = new System.Drawing.Point(0, 0);
            this.rvwTablaPos.Name = "rvwTablaPos";
            this.rvwTablaPos.ServerReport.BearerToken = null;
            this.rvwTablaPos.Size = new System.Drawing.Size(800, 450);
            this.rvwTablaPos.TabIndex = 0;
            this.rvwTablaPos.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // dsDataGame
            // 
            this.dsDataGame.DataSetName = "dsDataGame";
            this.dsDataGame.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtTablaPosicionBindingSource
            // 
            this.dtTablaPosicionBindingSource.DataMember = "dtTablaPosicion";
            this.dtTablaPosicionBindingSource.DataSource = this.dsDataGame;
            // 
            // frmTablaP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvwTablaPos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmTablaP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTablaP";
            this.Load += new System.EventHandler(this.frmTablaP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDataGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTablaPosicionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvwTablaPos;
        private dsDataGame dsDataGame;
        private System.Windows.Forms.BindingSource dtTablaPosicionBindingSource;
    }
}