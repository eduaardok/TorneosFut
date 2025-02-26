namespace pruebas
{
    partial class Jugador
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
            this.gnjugadores = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gnAgregarJu = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gnjugadores
            // 
            this.gnjugadores.BackColor = System.Drawing.SystemColors.Control;
            this.gnjugadores.Checked = true;
            this.gnjugadores.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.gnjugadores.CheckedState.FillColor = System.Drawing.Color.White;
            this.gnjugadores.CustomBorderColor = System.Drawing.Color.White;
            this.gnjugadores.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.gnjugadores.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnjugadores.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnjugadores.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnjugadores.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnjugadores.FillColor = System.Drawing.Color.White;
            this.gnjugadores.Font = new System.Drawing.Font("Onest Bold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnjugadores.ForeColor = System.Drawing.Color.Black;
            this.gnjugadores.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.gnjugadores.Location = new System.Drawing.Point(0, 2);
            this.gnjugadores.Name = "gnjugadores";
            this.gnjugadores.Size = new System.Drawing.Size(484, 59);
            this.gnjugadores.TabIndex = 0;
            this.gnjugadores.Text = "Jugadores";
            this.gnjugadores.Click += new System.EventHandler(this.gnjugadores_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gnAgregarJu);
            this.panel1.Controls.Add(this.gnjugadores);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1488, 64);
            this.panel1.TabIndex = 1;
            // 
            // gnAgregarJu
            // 
            this.gnAgregarJu.BackColor = System.Drawing.SystemColors.Control;
            this.gnAgregarJu.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.gnAgregarJu.CheckedState.FillColor = System.Drawing.Color.White;
            this.gnAgregarJu.CustomBorderColor = System.Drawing.Color.White;
            this.gnAgregarJu.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.gnAgregarJu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnAgregarJu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnAgregarJu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnAgregarJu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnAgregarJu.FillColor = System.Drawing.Color.White;
            this.gnAgregarJu.Font = new System.Drawing.Font("Onest Bold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnAgregarJu.ForeColor = System.Drawing.Color.Black;
            this.gnAgregarJu.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.gnAgregarJu.Location = new System.Drawing.Point(490, 0);
            this.gnAgregarJu.Name = "gnAgregarJu";
            this.gnAgregarJu.Size = new System.Drawing.Size(516, 59);
            this.gnAgregarJu.TabIndex = 1;
            this.gnAgregarJu.Text = "AgregarJugador";
            this.gnAgregarJu.Click += new System.EventHandler(this.gnAgregarJu_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Location = new System.Drawing.Point(2, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1488, 911);
            this.panel2.TabIndex = 2;
            // 
            // Jugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 911);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Jugador";
            this.Text = "VerJugadores";
            this.Load += new System.EventHandler(this.VerJugadores_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button gnjugadores;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button gnAgregarJu;
        private System.Windows.Forms.Panel panel2;
    }
}