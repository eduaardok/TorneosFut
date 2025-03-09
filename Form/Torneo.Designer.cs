namespace TorneosFut
{
    partial class Torneo
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
            this.btnJugadores = new System.Windows.Forms.Button();
            this.btnEstadios = new System.Windows.Forms.Button();
            this.btnArbitros = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelmodul = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnJugadores
            // 
            this.btnJugadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnJugadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJugadores.Font = new System.Drawing.Font("Onest Bold", 20F, System.Drawing.FontStyle.Bold);
            this.btnJugadores.ForeColor = System.Drawing.Color.White;
            this.btnJugadores.Location = new System.Drawing.Point(337, 3);
            this.btnJugadores.Name = "btnJugadores";
            this.btnJugadores.Size = new System.Drawing.Size(294, 85);
            this.btnJugadores.TabIndex = 3;
            this.btnJugadores.Text = "JUGADORES";
            this.btnJugadores.UseVisualStyleBackColor = false;
            this.btnJugadores.Click += new System.EventHandler(this.btnJugadores_Click);
            // 
            // btnEstadios
            // 
            this.btnEstadios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnEstadios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadios.Font = new System.Drawing.Font("Onest Bold", 20F, System.Drawing.FontStyle.Bold);
            this.btnEstadios.ForeColor = System.Drawing.Color.White;
            this.btnEstadios.Location = new System.Drawing.Point(966, 3);
            this.btnEstadios.Name = "btnEstadios";
            this.btnEstadios.Size = new System.Drawing.Size(294, 85);
            this.btnEstadios.TabIndex = 5;
            this.btnEstadios.Text = "ESTADIOS";
            this.btnEstadios.UseVisualStyleBackColor = false;
            this.btnEstadios.Click += new System.EventHandler(this.btnEstadios_Click);
            // 
            // btnArbitros
            // 
            this.btnArbitros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnArbitros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArbitros.Font = new System.Drawing.Font("Onest Bold", 20F, System.Drawing.FontStyle.Bold);
            this.btnArbitros.ForeColor = System.Drawing.Color.White;
            this.btnArbitros.Location = new System.Drawing.Point(651, 3);
            this.btnArbitros.Name = "btnArbitros";
            this.btnArbitros.Size = new System.Drawing.Size(294, 85);
            this.btnArbitros.TabIndex = 6;
            this.btnArbitros.Text = "ÁRBITROS";
            this.btnArbitros.UseVisualStyleBackColor = false;
            this.btnArbitros.Click += new System.EventHandler(this.btnArbitros_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.btnJugadores);
            this.panel1.Controls.Add(this.btnArbitros);
            this.panel1.Controls.Add(this.btnEstadios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1490, 100);
            this.panel1.TabIndex = 7;
            // 
            // panelmodul
            // 
            this.panelmodul.BackColor = System.Drawing.Color.White;
            this.panelmodul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmodul.Location = new System.Drawing.Point(0, 100);
            this.panelmodul.Name = "panelmodul";
            this.panelmodul.Size = new System.Drawing.Size(1490, 811);
            this.panelmodul.TabIndex = 8;
            // 
            // Torneo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1490, 911);
            this.ControlBox = false;
            this.Controls.Add(this.panelmodul);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Torneo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Torneo";
            this.Load += new System.EventHandler(this.Torneo_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJugadores;
        private System.Windows.Forms.Button btnEstadios;
        private System.Windows.Forms.Button btnArbitros;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panelmodul;
    }
}