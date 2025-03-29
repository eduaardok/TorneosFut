namespace TorneosFut
{
    partial class frmEquiposEstadisticas
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
            this.rvwEquipos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvwEquipos
            // 
            this.rvwEquipos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvwEquipos.LocalReport.ReportEmbeddedResource = "TorneosFut.Form.Reportes.rptEquipos.rdlc";
            this.rvwEquipos.Location = new System.Drawing.Point(0, 0);
            this.rvwEquipos.Name = "rvwEquipos";
            this.rvwEquipos.ServerReport.BearerToken = null;
            this.rvwEquipos.Size = new System.Drawing.Size(800, 450);
            this.rvwEquipos.TabIndex = 0;
            // 
            // frmEquiposEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvwEquipos);
            this.Name = "frmEquiposEstadisticas";
            this.Text = "frmEquiposEstadisticas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEquiposEstadisticas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvwEquipos;
    }
}