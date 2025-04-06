namespace TorneosFut
{
    partial class frmListaDeJugadores
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
            this.rvwListaEqu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvwListaEqu
            // 
            this.rvwListaEqu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvwListaEqu.Location = new System.Drawing.Point(0, 0);
            this.rvwListaEqu.Name = "rvwListaEqu";
            this.rvwListaEqu.ServerReport.BearerToken = null;
            this.rvwListaEqu.Size = new System.Drawing.Size(800, 450);
            this.rvwListaEqu.TabIndex = 0;
            this.rvwListaEqu.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // frmListaDeJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvwListaEqu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmListaDeJugadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListaDeJugadores";
            this.Load += new System.EventHandler(this.frmListaDeJugadores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvwListaEqu;
    }
}