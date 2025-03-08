namespace PruebasTorneos
{
    partial class Entrenador
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAggDT = new Guna.UI2.WinForms.Guna2Button();
            this.btnVerDT = new Guna.UI2.WinForms.Guna2Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAggDT);
            this.panel1.Controls.Add(this.btnVerDT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(940, 60);
            this.panel1.TabIndex = 0;
            // 
            // btnAggDT
            // 
            this.btnAggDT.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAggDT.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnAggDT.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAggDT.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnAggDT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAggDT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAggDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAggDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAggDT.FillColor = System.Drawing.Color.White;
            this.btnAggDT.Font = new System.Drawing.Font("Onest Bold", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.btnAggDT.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnAggDT.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAggDT.Location = new System.Drawing.Point(177, 0);
            this.btnAggDT.Name = "btnAggDT";
            this.btnAggDT.Size = new System.Drawing.Size(180, 60);
            this.btnAggDT.TabIndex = 1;
            this.btnAggDT.Text = "Agregar Entrenadores";
            this.btnAggDT.Click += new System.EventHandler(this.btnAggDT_Click);
            // 
            // btnVerDT
            // 
            this.btnVerDT.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnVerDT.Checked = true;
            this.btnVerDT.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnVerDT.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnVerDT.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnVerDT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVerDT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVerDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVerDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVerDT.FillColor = System.Drawing.Color.White;
            this.btnVerDT.Font = new System.Drawing.Font("Onest Bold", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.btnVerDT.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnVerDT.Location = new System.Drawing.Point(0, 0);
            this.btnVerDT.Name = "btnVerDT";
            this.btnVerDT.Size = new System.Drawing.Size(180, 60);
            this.btnVerDT.TabIndex = 0;
            this.btnVerDT.Text = "Ver Entrenadores";
            this.btnVerDT.Click += new System.EventHandler(this.btnVerDT_Click_1);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 60);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(940, 457);
            this.panelContenedor.TabIndex = 1;
            // 
            // Entrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 517);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Entrenador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Padre";
            this.Load += new System.EventHandler(this.Padre_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContenedor;
        private Guna.UI2.WinForms.Guna2Button btnVerDT;
        private Guna.UI2.WinForms.Guna2Button btnAggDT;
    }
}