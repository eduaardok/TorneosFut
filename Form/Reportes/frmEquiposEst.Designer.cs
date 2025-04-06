namespace TorneosFut
{
    partial class frmEquiposEst
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
            this.rvwEquipos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rvwEquipos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvwEquipos.LocalReport.ReportEmbeddedResource = "TorneosFut.rptEstatsEquipo.rdlc";
            this.rvwEquipos.Location = new System.Drawing.Point(0, 0);
            this.rvwEquipos.Name = "rvwEquipos";
            this.rvwEquipos.ServerReport.BearerToken = null;
            this.rvwEquipos.Size = new System.Drawing.Size(800, 450);
            this.rvwEquipos.TabIndex = 0;
            this.rvwEquipos.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // frmEquiposEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvwEquipos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmEquiposEst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEquiposEst";
            this.Load += new System.EventHandler(this.frmEquiposEst_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvwEquipos;
    }
}