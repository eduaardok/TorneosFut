namespace TorneosFut.Class
{
    partial class frmJugadoreEsts
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
            this.rvwEstadisticaJug = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvwEstadisticaJug
            // 
            this.rvwEstadisticaJug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvwEstadisticaJug.Location = new System.Drawing.Point(0, 0);
            this.rvwEstadisticaJug.Name = "rvwEstadisticaJug";
            this.rvwEstadisticaJug.ServerReport.BearerToken = null;
            this.rvwEstadisticaJug.Size = new System.Drawing.Size(800, 450);
            this.rvwEstadisticaJug.TabIndex = 0;
            this.rvwEstadisticaJug.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // frmJugadoreEsts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvwEstadisticaJug);
            this.Name = "frmJugadoreEsts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmJugadoreEsts";
            this.Load += new System.EventHandler(this.frmJugadoreEsts_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvwEstadisticaJug;
    }
}