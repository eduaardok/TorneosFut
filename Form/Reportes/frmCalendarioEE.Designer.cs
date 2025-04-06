namespace TorneosFut
{
    partial class frmCalendarioEE
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
            this.rvwCalendarioClub = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvwCalendarioClub
            // 
            this.rvwCalendarioClub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvwCalendarioClub.Location = new System.Drawing.Point(0, 0);
            this.rvwCalendarioClub.Name = "rvwCalendarioClub";
            this.rvwCalendarioClub.ServerReport.BearerToken = null;
            this.rvwCalendarioClub.Size = new System.Drawing.Size(800, 450);
            this.rvwCalendarioClub.TabIndex = 0;
            this.rvwCalendarioClub.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // frmCalendarioEE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvwCalendarioClub);
            this.Name = "frmCalendarioEE";
            this.Text = "frmCalendarioEE";
            this.Load += new System.EventHandler(this.frmCalendarioEE_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvwCalendarioClub;
    }
}