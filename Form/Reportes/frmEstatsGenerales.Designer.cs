namespace TorneosFut
{
    partial class frmEstatsGenerales
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
            this.rvwEstadisticas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvwEstadisticas
            // 
            this.rvwEstadisticas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvwEstadisticas.Location = new System.Drawing.Point(0, 0);
            this.rvwEstadisticas.Name = "rvwEstadisticas";
            this.rvwEstadisticas.ServerReport.BearerToken = null;
            this.rvwEstadisticas.Size = new System.Drawing.Size(1184, 679);
            this.rvwEstadisticas.TabIndex = 0;
            // 
            // frmEstatsGenerales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 679);
            this.Controls.Add(this.rvwEstadisticas);
            this.MaximumSize = new System.Drawing.Size(1200, 718);
            this.MinimumSize = new System.Drawing.Size(1200, 718);
            this.Name = "frmEstatsGenerales";
            this.Text = "frmEstatsGenerales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEstatsGenerales_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvwEstadisticas;
    }
}