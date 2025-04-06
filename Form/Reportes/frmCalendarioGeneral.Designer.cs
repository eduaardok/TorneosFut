namespace TorneosFut
{
    partial class frmCalendarioGeneral
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
            this.rvwCalendarioGen = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvwCalendarioGen
            // 
            this.rvwCalendarioGen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvwCalendarioGen.Location = new System.Drawing.Point(0, 0);
            this.rvwCalendarioGen.Name = "rvwCalendarioGen";
            this.rvwCalendarioGen.ServerReport.BearerToken = null;
            this.rvwCalendarioGen.Size = new System.Drawing.Size(800, 450);
            this.rvwCalendarioGen.TabIndex = 0;
            this.rvwCalendarioGen.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // frmCalendarioGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvwCalendarioGen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCalendarioGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCalendarioGeneral";
            this.Load += new System.EventHandler(this.frmCalendarioGeneral_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvwCalendarioGen;
    }
}