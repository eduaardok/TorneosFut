﻿namespace TorneosFut
{
    partial class AggEditEquipo
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
            this.lbBorde = new System.Windows.Forms.Label();
            this.Eq = new System.Windows.Forms.Label();
            this.cmbEquipacionLocal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbequipacionvisitante = new System.Windows.Forms.ComboBox();
            this.btnSeleccionarIMG = new Guna.UI2.WinForms.Guna2Button();
            this.lbl = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbEstadio = new System.Windows.Forms.ComboBox();
            this.txtPresidente = new System.Windows.Forms.TextBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.txtNombreClub = new System.Windows.Forms.TextBox();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.panel2.Controls.Add(this.lblEncabezado);
            this.panel2.Controls.Add(this.lbBorde);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 50);
            this.panel2.TabIndex = 54;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblEncabezado.Location = new System.Drawing.Point(15, 9);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(216, 25);
            this.lblEncabezado.TabIndex = 33;
            this.lblEncabezado.Text = "AGREGAR EQUIPO";
            // 
            // lbBorde
            // 
            this.lbBorde.Location = new System.Drawing.Point(0, 0);
            this.lbBorde.Name = "lbBorde";
            this.lbBorde.Size = new System.Drawing.Size(561, 470);
            this.lbBorde.TabIndex = 62;
            this.lbBorde.Paint += new System.Windows.Forms.PaintEventHandler(this.lbBorde_Paint);
            // 
            // Eq
            // 
            this.Eq.AutoSize = true;
            this.Eq.BackColor = System.Drawing.Color.Transparent;
            this.Eq.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eq.Location = new System.Drawing.Point(32, 267);
            this.Eq.Name = "Eq";
            this.Eq.Size = new System.Drawing.Size(161, 24);
            this.Eq.TabIndex = 97;
            this.Eq.Text = "Equipación local";
            // 
            // cmbEquipacionLocal
            // 
            this.cmbEquipacionLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipacionLocal.FormattingEnabled = true;
            this.cmbEquipacionLocal.Items.AddRange(new object[] {
            "Rojo",
            "Verde",
            "Azul",
            "Amarillo",
            "Naranja",
            "Morado",
            "Rosa",
            "Marrón",
            "Gris",
            "Negro",
            "Blanco",
            "Turquesa",
            "Cyan",
            "Magenta",
            "Beige",
            "Coral",
            "Oro",
            "Plata",
            "Verde lima",
            "Oliva",
            "Azul marino",
            "Azul cielo",
            "Violeta",
            "Índigo",
            "Salmón",
            "Carmesí",
            "Burdeos",
            "Granate",
            "Esmeralda",
            "Jade",
            "Aguamarina",
            "Lavanda",
            "Lila",
            "Fucsia",
            "Melocotón",
            "Menta",
            "Mostaza",
            "Ocre",
            "Caqui",
            "Chocolate",
            "Canela",
            "Crema",
            "Blanco roto",
            "Gris perla",
            "Azul eléctrico",
            "Verde menta",
            "Verde bosque",
            "Azul turquesa",
            "Rosa pastel",
            "Azul pastel",
            "Amarillo pastel",
            "Verde pastel",
            "Morado pastel",
            "Coral pastel",
            "Gris oscuro",
            "Gris claro",
            "Negro azabache",
            "Blanco nieve",
            "Rojo oscuro",
            "Verde oscuro",
            "Azul oscuro",
            "Amarillo oscuro",
            "Rosa oscuro",
            "Morado oscuro",
            "Rojo claro",
            "Verde claro",
            "Azul claro",
            "Amarillo claro",
            "Rosa claro",
            "Morado claro"});
            this.cmbEquipacionLocal.Location = new System.Drawing.Point(36, 299);
            this.cmbEquipacionLocal.Name = "cmbEquipacionLocal";
            this.cmbEquipacionLocal.Size = new System.Drawing.Size(178, 21);
            this.cmbEquipacionLocal.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 24);
            this.label2.TabIndex = 95;
            this.label2.Text = "Equipación visitante";
            // 
            // cmbequipacionvisitante
            // 
            this.cmbequipacionvisitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbequipacionvisitante.FormattingEnabled = true;
            this.cmbequipacionvisitante.Items.AddRange(new object[] {
            "Rojo",
            "Verde",
            "Azul",
            "Amarillo",
            "Naranja",
            "Morado",
            "Rosa",
            "Marrón",
            "Gris",
            "Negro",
            "Blanco",
            "Turquesa",
            "Cyan",
            "Magenta",
            "Beige",
            "Coral",
            "Oro",
            "Plata",
            "Verde lima",
            "Oliva",
            "Azul marino",
            "Azul cielo",
            "Violeta",
            "Índigo",
            "Salmón",
            "Carmesí",
            "Burdeos",
            "Granate",
            "Esmeralda",
            "Jade",
            "Aguamarina",
            "Lavanda",
            "Lila",
            "Fucsia",
            "Melocotón",
            "Menta",
            "Mostaza",
            "Ocre",
            "Caqui",
            "Chocolate",
            "Canela",
            "Crema",
            "Blanco roto",
            "Gris perla",
            "Azul eléctrico",
            "Verde menta",
            "Verde bosque",
            "Azul turquesa",
            "Rosa pastel",
            "Azul pastel",
            "Amarillo pastel",
            "Verde pastel",
            "Morado pastel",
            "Coral pastel",
            "Gris oscuro",
            "Gris claro",
            "Negro azabache",
            "Blanco nieve",
            "Rojo oscuro",
            "Verde oscuro",
            "Azul oscuro",
            "Amarillo oscuro",
            "Rosa oscuro",
            "Morado oscuro",
            "Rojo claro",
            "Verde claro",
            "Azul claro",
            "Amarillo claro",
            "Rosa claro",
            "Morado claro"});
            this.cmbequipacionvisitante.Location = new System.Drawing.Point(36, 350);
            this.cmbequipacionvisitante.Name = "cmbequipacionvisitante";
            this.cmbequipacionvisitante.Size = new System.Drawing.Size(178, 21);
            this.cmbequipacionvisitante.TabIndex = 94;
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
            this.btnSeleccionarIMG.Location = new System.Drawing.Point(346, 242);
            this.btnSeleccionarIMG.Name = "btnSeleccionarIMG";
            this.btnSeleccionarIMG.Size = new System.Drawing.Size(163, 25);
            this.btnSeleccionarIMG.TabIndex = 93;
            this.btnSeleccionarIMG.Text = "Selccionar imagen";
            this.btnSeleccionarIMG.Click += new System.EventHandler(this.btnSeleccionarIMG_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(33, 66);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 24);
            this.lbl.TabIndex = 92;
            this.lbl.Text = "ID ";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(36, 93);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 90;
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
            this.btnCancelar.Location = new System.Drawing.Point(358, 377);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 54);
            this.btnCancelar.TabIndex = 89;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnAgregar.Location = new System.Drawing.Point(358, 323);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(138, 54);
            this.btnAgregar.TabIndex = 88;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.BackColor = System.Drawing.Color.Transparent;
            this.lblPosicion.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.Location = new System.Drawing.Point(32, 374);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(79, 24);
            this.lblPosicion.TabIndex = 87;
            this.lblPosicion.Text = "Estadio";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.BackColor = System.Drawing.Color.Transparent;
            this.lblsexo.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsexo.Location = new System.Drawing.Point(33, 215);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(78, 24);
            this.lblsexo.TabIndex = 86;
            this.lblsexo.Text = "Género";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.BackColor = System.Drawing.Color.Transparent;
            this.lblapellido.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellido.Location = new System.Drawing.Point(33, 162);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(111, 24);
            this.lblapellido.TabIndex = 85;
            this.lblapellido.Text = "Presidente";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(33, 115);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(84, 24);
            this.lblNombre.TabIndex = 84;
            this.lblNombre.Text = "Nombre";
            // 
            // cmbEstadio
            // 
            this.cmbEstadio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadio.FormattingEnabled = true;
            this.cmbEstadio.Location = new System.Drawing.Point(36, 401);
            this.cmbEstadio.Name = "cmbEstadio";
            this.cmbEstadio.Size = new System.Drawing.Size(178, 21);
            this.cmbEstadio.TabIndex = 83;
            // 
            // txtPresidente
            // 
            this.txtPresidente.Location = new System.Drawing.Point(36, 192);
            this.txtPresidente.Name = "txtPresidente";
            this.txtPresidente.Size = new System.Drawing.Size(178, 20);
            this.txtPresidente.TabIndex = 82;
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(36, 242);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(178, 21);
            this.cmbGenero.TabIndex = 81;
            // 
            // txtNombreClub
            // 
            this.txtNombreClub.Location = new System.Drawing.Point(36, 139);
            this.txtNombreClub.Name = "txtNombreClub";
            this.txtNombreClub.Size = new System.Drawing.Size(178, 20);
            this.txtNombreClub.TabIndex = 80;
            // 
            // ptbImagen
            // 
            this.ptbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbImagen.Location = new System.Drawing.Point(346, 56);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(163, 180);
            this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagen.TabIndex = 91;
            this.ptbImagen.TabStop = false;
            // 
            // AggEditEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 470);
            this.Controls.Add(this.Eq);
            this.Controls.Add(this.cmbEquipacionLocal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbequipacionvisitante);
            this.Controls.Add(this.btnSeleccionarIMG);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.ptbImagen);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cmbEstadio);
            this.Controls.Add(this.txtPresidente);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.txtNombreClub);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AggEditEquipo";
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Label lbBorde;
        private System.Windows.Forms.Label Eq;
        public System.Windows.Forms.ComboBox cmbEquipacionLocal;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbequipacionvisitante;
        private Guna.UI2.WinForms.Guna2Button btnSeleccionarIMG;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox ptbImagen;
        public System.Windows.Forms.TextBox txtId;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.ComboBox cmbEstadio;
        public System.Windows.Forms.TextBox txtPresidente;
        public System.Windows.Forms.ComboBox cmbGenero;
        public System.Windows.Forms.TextBox txtNombreClub;
    }
}