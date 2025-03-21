namespace TorneosFut
{
    partial class PagoArbitro
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
            this.c = new System.Windows.Forms.Panel();
            this.btnSalir = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.c.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.c.Controls.Add(this.label1);
            this.c.Controls.Add(this.btnSalir);
            this.c.Dock = System.Windows.Forms.DockStyle.Top;
            this.c.Location = new System.Drawing.Point(0, 0);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(711, 73);
            this.c.TabIndex = 66;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSalir.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnSalir.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnSalir.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnSalir.CustomBorderColor = System.Drawing.Color.White;
            this.btnSalir.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnSalir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnSalir.Font = new System.Drawing.Font("Onest Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnSalir.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnSalir.Location = new System.Drawing.Point(795, 8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(180, 59);
            this.btnSalir.TabIndex = 61;
            this.btnSalir.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Onest Bold", 17.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 29);
            this.label1.TabIndex = 62;
            this.label1.Text = "Formulario de Pago - Árbitros";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Fuchsia;
            this.guna2Panel1.BorderRadius = 3;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Location = new System.Drawing.Point(20, 98);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(668, 434);
            this.guna2Panel1.TabIndex = 67;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(469, 368);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "guna2Button1";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // PagoArbitro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 557);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.c);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PagoArbitro";
            this.Text = "PagoArbitro";
            this.c.ResumeLayout(false);
            this.c.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel c;
        private Guna.UI2.WinForms.Guna2Button btnSalir;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}