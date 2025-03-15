namespace TorneosFut
{
    partial class AggEquipo
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
            this.lblequipo = new System.Windows.Forms.Label();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbEntrenador = new System.Windows.Forms.ComboBox();
            this.cmbEstadio = new System.Windows.Forms.ComboBox();
            this.txtPresidente = new System.Windows.Forms.TextBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.txtNombreClub = new System.Windows.Forms.TextBox();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.lblAggEquipo = new System.Windows.Forms.Label();
            this.lblBodr2 = new System.Windows.Forms.Label();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionarIMG = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblequipo
            // 
            this.lblequipo.AutoSize = true;
            this.lblequipo.BackColor = System.Drawing.Color.White;
            this.lblequipo.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblequipo.Location = new System.Drawing.Point(51, 378);
            this.lblequipo.Name = "lblequipo";
            this.lblequipo.Size = new System.Drawing.Size(114, 24);
            this.lblequipo.TabIndex = 40;
            this.lblequipo.Text = "Entrenador";
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.BackColor = System.Drawing.Color.White;
            this.lblPosicion.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.Location = new System.Drawing.Point(51, 325);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(79, 24);
            this.lblPosicion.TabIndex = 35;
            this.lblPosicion.Text = "Estadio";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.BackColor = System.Drawing.Color.White;
            this.lblsexo.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsexo.Location = new System.Drawing.Point(51, 275);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(77, 24);
            this.lblsexo.TabIndex = 34;
            this.lblsexo.Text = "Genero";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.BackColor = System.Drawing.Color.White;
            this.lblapellido.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellido.Location = new System.Drawing.Point(51, 224);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(111, 24);
            this.lblapellido.TabIndex = 33;
            this.lblapellido.Text = "Presidente";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(50, 177);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 24);
            this.lblNombre.TabIndex = 32;
            this.lblNombre.Text = "Nombres";
            // 
            // cmbEntrenador
            // 
            this.cmbEntrenador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntrenador.FormattingEnabled = true;
            this.cmbEntrenador.Items.AddRange(new object[] {
            "Ninguno"});
            this.cmbEntrenador.Location = new System.Drawing.Point(207, 382);
            this.cmbEntrenador.Name = "cmbEntrenador";
            this.cmbEntrenador.Size = new System.Drawing.Size(121, 21);
            this.cmbEntrenador.TabIndex = 31;
            // 
            // cmbEstadio
            // 
            this.cmbEstadio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadio.FormattingEnabled = true;
            this.cmbEstadio.Items.AddRange(new object[] {
            "Portero (Guardameta)",
            "Defensa central",
            "Lateral derecho",
            "Lateral izquierdo",
            "Carrilero derecho",
            "Carrilero izquierdo",
            "Mediocentro defensivo",
            "Mediocentro",
            "Mediocentro ofensivo",
            "Interior derecho",
            "Interior izquierdo",
            "Extremo derecho",
            "Extremo izquierdo",
            "Mediapunta",
            "Delantero centro",
            "Segunda punta",
            "Falso nueve"});
            this.cmbEstadio.Location = new System.Drawing.Point(208, 329);
            this.cmbEstadio.Name = "cmbEstadio";
            this.cmbEstadio.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadio.TabIndex = 27;
            // 
            // txtPresidente
            // 
            this.txtPresidente.Location = new System.Drawing.Point(207, 228);
            this.txtPresidente.Name = "txtPresidente";
            this.txtPresidente.Size = new System.Drawing.Size(178, 20);
            this.txtPresidente.TabIndex = 26;
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(208, 279);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero.TabIndex = 24;
            // 
            // txtNombreClub
            // 
            this.txtNombreClub.Location = new System.Drawing.Point(207, 181);
            this.txtNombreClub.Name = "txtNombreClub";
            this.txtNombreClub.Size = new System.Drawing.Size(178, 20);
            this.txtNombreClub.TabIndex = 23;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Window;
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnAgregar.Font = new System.Drawing.Font("Onest Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnAgregar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnAgregar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(662, 348);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(138, 54);
            this.btnAgregar.TabIndex = 46;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnCancelar.Font = new System.Drawing.Font("Onest Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnCancelar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnCancelar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(662, 468);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 54);
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblAggEquipo
            // 
            this.lblAggEquipo.BackColor = System.Drawing.Color.White;
            this.lblAggEquipo.Font = new System.Drawing.Font("Onest Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggEquipo.Location = new System.Drawing.Point(229, 50);
            this.lblAggEquipo.Name = "lblAggEquipo";
            this.lblAggEquipo.Size = new System.Drawing.Size(458, 50);
            this.lblAggEquipo.TabIndex = 0;
            this.lblAggEquipo.Text = "AGREGAR NUEVO EQUIPO";
            // 
            // lblBodr2
            // 
            this.lblBodr2.BackColor = System.Drawing.Color.White;
            this.lblBodr2.Location = new System.Drawing.Point(0, 0);
            this.lblBodr2.Name = "lblBodr2";
            this.lblBodr2.Size = new System.Drawing.Size(800, 100);
            this.lblBodr2.TabIndex = 50;
            this.lblBodr2.Paint += new System.Windows.Forms.PaintEventHandler(this.lblBodr2_Paint);
            // 
            // btnEditar
            // 
            this.btnEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnEditar.Font = new System.Drawing.Font("Onest Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnEditar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnEditar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(662, 408);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(138, 54);
            this.btnEditar.TabIndex = 52;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(208, 430);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 53;
            this.txtId.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.panel2.Controls.Add(this.lblEncabezado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 50);
            this.panel2.TabIndex = 54;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblEncabezado.Location = new System.Drawing.Point(12, 8);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(320, 25);
            this.lblEncabezado.TabIndex = 33;
            this.lblEncabezado.Text = "AGREGAR/EDITAR USUARIO";
            // 
            // ptbImagen
            // 
            this.ptbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbImagen.Location = new System.Drawing.Point(653, 110);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(163, 180);
            this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagen.TabIndex = 55;
            this.ptbImagen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 56;
            this.label1.Text = "ID Entrenador";
            // 
            // btnSeleccionarIMG
            // 
            this.btnSeleccionarIMG.BackColor = System.Drawing.SystemColors.Window;
            this.btnSeleccionarIMG.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeleccionarIMG.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeleccionarIMG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeleccionarIMG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeleccionarIMG.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnSeleccionarIMG.Font = new System.Drawing.Font("Onest Bold", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarIMG.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarIMG.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnSeleccionarIMG.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnSeleccionarIMG.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarIMG.Location = new System.Drawing.Point(653, 296);
            this.btnSeleccionarIMG.Name = "btnSeleccionarIMG";
            this.btnSeleccionarIMG.Size = new System.Drawing.Size(163, 25);
            this.btnSeleccionarIMG.TabIndex = 57;
            this.btnSeleccionarIMG.Text = "Selccionar imagen";
            this.btnSeleccionarIMG.Click += new System.EventHandler(this.btnSeleccionarIMG_Click);
            // 
            // AggEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(916, 542);
            this.Controls.Add(this.btnSeleccionarIMG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbImagen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblAggEquipo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblequipo);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cmbEntrenador);
            this.Controls.Add(this.cmbEstadio);
            this.Controls.Add(this.txtPresidente);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.txtNombreClub);
            this.Controls.Add(this.lblBodr2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AggEquipo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarEquipo";
            this.Load += new System.EventHandler(this.AggEquipo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblequipo;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblNombre;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private System.Windows.Forms.Label lblAggEquipo;
        private System.Windows.Forms.Label lblBodr2;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.ComboBox cmbEntrenador;
        public System.Windows.Forms.ComboBox cmbEstadio;
        public System.Windows.Forms.TextBox txtPresidente;
        public System.Windows.Forms.ComboBox cmbGenero;
        public System.Windows.Forms.TextBox txtNombreClub;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.PictureBox ptbImagen;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnSeleccionarIMG;
    }
}