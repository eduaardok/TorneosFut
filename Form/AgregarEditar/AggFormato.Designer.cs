namespace TorneosFut
{
    partial class AggFormato
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numGrupos = new System.Windows.Forms.NumericUpDown();
            this.numEquipos = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIdaVuelta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numJornadas = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbIdaVueltaPlayoff = new System.Windows.Forms.ComboBox();
            this.cmbPlayoff = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJornadas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.panel2.Controls.Add(this.lblEncabezado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 50);
            this.panel2.TabIndex = 55;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Onest Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblEncabezado.Location = new System.Drawing.Point(15, 9);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(223, 26);
            this.lblEncabezado.TabIndex = 33;
            this.lblEncabezado.Text = "AGREGAR FORMATO";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(16, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(200, 24);
            this.lblNombre.TabIndex = 86;
            this.lblNombre.Text = "Nombre del formato:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Onest Light", 12F);
            this.txtNombre.Location = new System.Drawing.Point(20, 91);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 28);
            this.txtNombre.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 87;
            this.label1.Text = "Cantidad de grupos:";
            // 
            // numGrupos
            // 
            this.numGrupos.Font = new System.Drawing.Font("Onest Bold", 10.25F, System.Drawing.FontStyle.Bold);
            this.numGrupos.Location = new System.Drawing.Point(20, 170);
            this.numGrupos.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numGrupos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGrupos.Name = "numGrupos";
            this.numGrupos.Size = new System.Drawing.Size(120, 25);
            this.numGrupos.TabIndex = 88;
            this.numGrupos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGrupos.ValueChanged += new System.EventHandler(this.numGrupos_ValueChanged);
            // 
            // numEquipos
            // 
            this.numEquipos.Font = new System.Drawing.Font("Onest Bold", 10.25F, System.Drawing.FontStyle.Bold);
            this.numEquipos.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numEquipos.Location = new System.Drawing.Point(324, 97);
            this.numEquipos.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numEquipos.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numEquipos.Name = "numEquipos";
            this.numEquipos.Size = new System.Drawing.Size(120, 25);
            this.numEquipos.TabIndex = 90;
            this.numEquipos.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numEquipos.ValueChanged += new System.EventHandler(this.numEquipos_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 24);
            this.label2.TabIndex = 89;
            this.label2.Text = "Cantidad de equipos (total):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 24);
            this.label3.TabIndex = 91;
            this.label3.Text = "Partidos de ida y vuelta:";
            // 
            // cmbIdaVuelta
            // 
            this.cmbIdaVuelta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdaVuelta.Font = new System.Drawing.Font("Onest Light", 11F);
            this.cmbIdaVuelta.FormattingEnabled = true;
            this.cmbIdaVuelta.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbIdaVuelta.Location = new System.Drawing.Point(324, 165);
            this.cmbIdaVuelta.Name = "cmbIdaVuelta";
            this.cmbIdaVuelta.Size = new System.Drawing.Size(120, 31);
            this.cmbIdaVuelta.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 93;
            this.label4.Text = "Playoff:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 24);
            this.label6.TabIndex = 97;
            this.label6.Text = "Playoff de ida y vuelta:";
            // 
            // numJornadas
            // 
            this.numJornadas.Font = new System.Drawing.Font("Onest Bold", 10.25F, System.Drawing.FontStyle.Bold);
            this.numJornadas.Location = new System.Drawing.Point(20, 344);
            this.numJornadas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numJornadas.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numJornadas.Name = "numJornadas";
            this.numJornadas.Size = new System.Drawing.Size(120, 25);
            this.numJornadas.TabIndex = 100;
            this.numJornadas.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 24);
            this.label7.TabIndex = 99;
            this.label7.Text = "Días entre jornadas:";
            // 
            // cmbIdaVueltaPlayoff
            // 
            this.cmbIdaVueltaPlayoff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdaVueltaPlayoff.Font = new System.Drawing.Font("Onest Light", 11F);
            this.cmbIdaVueltaPlayoff.FormattingEnabled = true;
            this.cmbIdaVueltaPlayoff.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbIdaVueltaPlayoff.Location = new System.Drawing.Point(324, 250);
            this.cmbIdaVueltaPlayoff.Name = "cmbIdaVueltaPlayoff";
            this.cmbIdaVueltaPlayoff.Size = new System.Drawing.Size(120, 31);
            this.cmbIdaVueltaPlayoff.TabIndex = 101;
            this.cmbIdaVueltaPlayoff.SelectedIndexChanged += new System.EventHandler(this.cmbIdaVueltaPlayoff_SelectedIndexChanged);
            // 
            // cmbPlayoff
            // 
            this.cmbPlayoff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayoff.Font = new System.Drawing.Font("Onest Light", 11F);
            this.cmbPlayoff.FormattingEnabled = true;
            this.cmbPlayoff.Items.AddRange(new object[] {
            "No",
            "Octavos de final",
            "Cuartos de final",
            "Semifinales",
            "Final"});
            this.cmbPlayoff.Location = new System.Drawing.Point(20, 250);
            this.cmbPlayoff.Name = "cmbPlayoff";
            this.cmbPlayoff.Size = new System.Drawing.Size(178, 31);
            this.cmbPlayoff.TabIndex = 102;
            this.cmbPlayoff.SelectedIndexChanged += new System.EventHandler(this.cmbPlayoff_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Animated = true;
            this.btnAgregar.BorderRadius = 20;
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnAgregar.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnAgregar.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(479, 344);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(134, 39);
            this.btnAgregar.TabIndex = 103;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderRadius = 20;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnCancelar.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnCancelar.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(339, 344);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 39);
            this.btnCancelar.TabIndex = 104;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AggFormato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 420);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbPlayoff);
            this.Controls.Add(this.cmbIdaVueltaPlayoff);
            this.Controls.Add(this.numJornadas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbIdaVuelta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numEquipos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numGrupos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AggFormato";
            this.Text = "AggFormato";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJornadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numGrupos;
        private System.Windows.Forms.NumericUpDown numEquipos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmbIdaVuelta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numJornadas;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cmbIdaVueltaPlayoff;
        public System.Windows.Forms.ComboBox cmbPlayoff;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
    }
}