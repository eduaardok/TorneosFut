namespace TorneosFut
{
    partial class GestionInscripcion
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
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.dgvEquiposInscri = new System.Windows.Forms.DataGridView();
            this.btnIncribir = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuitar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAbonar = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btngSalir = new Guna.UI2.WinForms.Guna2Button();
            this.lblEncabezado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquiposInscri)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.Location = new System.Drawing.Point(74, 171);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.Size = new System.Drawing.Size(527, 508);
            this.dgvEquipos.TabIndex = 0;
            // 
            // dgvEquiposInscri
            // 
            this.dgvEquiposInscri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquiposInscri.Location = new System.Drawing.Point(893, 171);
            this.dgvEquiposInscri.Name = "dgvEquiposInscri";
            this.dgvEquiposInscri.Size = new System.Drawing.Size(527, 508);
            this.dgvEquiposInscri.TabIndex = 1;
            // 
            // btnIncribir
            // 
            this.btnIncribir.BackColor = System.Drawing.SystemColors.Window;
            this.btnIncribir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIncribir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIncribir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIncribir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIncribir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnIncribir.Font = new System.Drawing.Font("Onest Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncribir.ForeColor = System.Drawing.Color.White;
            this.btnIncribir.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnIncribir.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnIncribir.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnIncribir.Location = new System.Drawing.Point(661, 359);
            this.btnIncribir.Name = "btnIncribir";
            this.btnIncribir.Size = new System.Drawing.Size(173, 54);
            this.btnIncribir.TabIndex = 90;
            this.btnIncribir.Text = "INSCRIBIR";
            // 
            // btnQuitar
            // 
            this.btnQuitar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuitar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuitar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuitar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuitar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnQuitar.Font = new System.Drawing.Font("Onest Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.Color.Black;
            this.btnQuitar.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnQuitar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnQuitar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnQuitar.Location = new System.Drawing.Point(661, 442);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(173, 54);
            this.btnQuitar.TabIndex = 91;
            this.btnQuitar.Text = "QUITAR";
            // 
            // btnAbonar
            // 
            this.btnAbonar.BackColor = System.Drawing.Color.White;
            this.btnAbonar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAbonar.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnAbonar.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnAbonar.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnAbonar.CustomBorderColor = System.Drawing.Color.White;
            this.btnAbonar.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnAbonar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAbonar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAbonar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAbonar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAbonar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnAbonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbonar.ForeColor = System.Drawing.Color.Black;
            this.btnAbonar.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnAbonar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnAbonar.Location = new System.Drawing.Point(1293, 703);
            this.btnAbonar.Name = "btnAbonar";
            this.btnAbonar.Size = new System.Drawing.Size(127, 52);
            this.btnAbonar.TabIndex = 92;
            this.btnAbonar.Text = "ABONAR ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.panel2.Controls.Add(this.btngSalir);
            this.panel2.Controls.Add(this.lblEncabezado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Onest Bold", 15.75F, System.Drawing.FontStyle.Bold);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1490, 72);
            this.panel2.TabIndex = 93;
            // 
            // btngSalir
            // 
            this.btngSalir.BackColor = System.Drawing.Color.White;
            this.btngSalir.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btngSalir.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btngSalir.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btngSalir.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btngSalir.CustomBorderColor = System.Drawing.Color.White;
            this.btngSalir.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btngSalir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngSalir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngSalir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngSalir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btngSalir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btngSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngSalir.ForeColor = System.Drawing.Color.Black;
            this.btngSalir.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btngSalir.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btngSalir.Location = new System.Drawing.Point(1356, 0);
            this.btngSalir.Name = "btngSalir";
            this.btngSalir.Size = new System.Drawing.Size(134, 72);
            this.btngSalir.TabIndex = 34;
            this.btngSalir.Text = "X";
            this.btngSalir.Click += new System.EventHandler(this.btngSalir_Click);
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Onest Bold", 20F, System.Drawing.FontStyle.Bold);
            this.lblEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblEncabezado.Location = new System.Drawing.Point(37, 21);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(530, 34);
            this.lblEncabezado.TabIndex = 33;
            this.lblEncabezado.Text = "INSCRIPCION DE EQUIPOS A TORNEOS";
            // 
            // GestionInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 811);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAbonar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnIncribir);
            this.Controls.Add(this.dgvEquiposInscri);
            this.Controls.Add(this.dgvEquipos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionInscripcion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquiposInscri)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.DataGridView dgvEquiposInscri;
        private Guna.UI2.WinForms.Guna2Button btnIncribir;
        private Guna.UI2.WinForms.Guna2Button btnQuitar;
        public Guna.UI2.WinForms.Guna2Button btnAbonar;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btngSalir;
        private System.Windows.Forms.Label lblEncabezado;
    }
}