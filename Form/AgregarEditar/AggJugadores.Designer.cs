namespace pruebas
{
    partial class AggJugadores
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDJugador = new System.Windows.Forms.TextBox();
            this.btngCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNacionalidad = new System.Windows.Forms.TextBox();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblpeso = new System.Windows.Forms.Label();
            this.LblPierna = new System.Windows.Forms.Label();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.cmbpierna = new System.Windows.Forms.ComboBox();
            this.CmbPosicion = new System.Windows.Forms.ComboBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbsexo = new System.Windows.Forms.ComboBox();
            this.Txtnombre = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCargarimagen = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.panel2.Controls.Add(this.lblEncabezado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 50);
            this.panel2.TabIndex = 49;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Onest Bold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblEncabezado.Location = new System.Drawing.Point(12, 8);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(222, 26);
            this.lblEncabezado.TabIndex = 33;
            this.lblEncabezado.Text = "AGREGAR JUGADOR";
            // 
            // ptbImagen
            // 
            this.ptbImagen.BackColor = System.Drawing.Color.White;
            this.ptbImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbImagen.Location = new System.Drawing.Point(513, 77);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(264, 242);
            this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagen.TabIndex = 100;
            this.ptbImagen.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 24);
            this.label2.TabIndex = 99;
            this.label2.Text = "ID";
            // 
            // txtIDJugador
            // 
            this.txtIDJugador.Font = new System.Drawing.Font("Onest Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDJugador.Location = new System.Drawing.Point(77, 80);
            this.txtIDJugador.Name = "txtIDJugador";
            this.txtIDJugador.Size = new System.Drawing.Size(178, 28);
            this.txtIDJugador.TabIndex = 98;
            // 
            // btngCancelar
            // 
            this.btngCancelar.Animated = true;
            this.btngCancelar.BackColor = System.Drawing.Color.White;
            this.btngCancelar.BorderRadius = 20;
            this.btngCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btngCancelar.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btngCancelar.ForeColor = System.Drawing.Color.Black;
            this.btngCancelar.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btngCancelar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btngCancelar.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btngCancelar.Location = new System.Drawing.Point(268, 486);
            this.btngCancelar.Name = "btngCancelar";
            this.btngCancelar.Size = new System.Drawing.Size(139, 52);
            this.btngCancelar.TabIndex = 97;
            this.btngCancelar.Text = "CANCELAR";
            this.btngCancelar.Click += new System.EventHandler(this.btngCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 95;
            this.label1.Text = "Nacionalidad";
            // 
            // TxtNacionalidad
            // 
            this.TxtNacionalidad.Font = new System.Drawing.Font("Onest Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNacionalidad.Location = new System.Drawing.Point(77, 341);
            this.TxtNacionalidad.Name = "TxtNacionalidad";
            this.TxtNacionalidad.Size = new System.Drawing.Size(178, 28);
            this.TxtNacionalidad.TabIndex = 94;
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.BackColor = System.Drawing.Color.Transparent;
            this.lblaltura.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaltura.Location = new System.Drawing.Point(306, 295);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(66, 24);
            this.lblaltura.TabIndex = 93;
            this.lblaltura.Text = "Altura";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.lblfecha.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(73, 376);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(205, 24);
            this.lblfecha.TabIndex = 92;
            this.lblfecha.Text = "Fecha de Nacimiento";
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.BackColor = System.Drawing.Color.Transparent;
            this.lblpeso.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpeso.Location = new System.Drawing.Point(306, 232);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(91, 24);
            this.lblpeso.TabIndex = 91;
            this.lblpeso.Text = "Peso/KG";
            // 
            // LblPierna
            // 
            this.LblPierna.AutoSize = true;
            this.LblPierna.BackColor = System.Drawing.Color.Transparent;
            this.LblPierna.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPierna.Location = new System.Drawing.Point(303, 172);
            this.LblPierna.Name = "LblPierna";
            this.LblPierna.Size = new System.Drawing.Size(122, 24);
            this.LblPierna.TabIndex = 90;
            this.LblPierna.Text = "Pierna Hábil";
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.BackColor = System.Drawing.Color.Transparent;
            this.lblPosicion.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.Location = new System.Drawing.Point(73, 245);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(89, 24);
            this.lblPosicion.TabIndex = 89;
            this.lblPosicion.Text = "Posición";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.BackColor = System.Drawing.Color.Transparent;
            this.lblsexo.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsexo.Location = new System.Drawing.Point(73, 172);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(54, 24);
            this.lblsexo.TabIndex = 88;
            this.lblsexo.Text = "Sexo";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.BackColor = System.Drawing.Color.Transparent;
            this.lblapellido.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellido.Location = new System.Drawing.Point(303, 114);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(94, 24);
            this.lblapellido.TabIndex = 87;
            this.lblapellido.Text = "Apellidos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(73, 109);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 24);
            this.lblNombre.TabIndex = 86;
            this.lblNombre.Text = "Nombres";
            // 
            // txtaltura
            // 
            this.txtaltura.Font = new System.Drawing.Font("Onest Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaltura.Location = new System.Drawing.Point(307, 324);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 28);
            this.txtaltura.TabIndex = 85;
            // 
            // txtpeso
            // 
            this.txtpeso.Font = new System.Drawing.Font("Onest Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpeso.Location = new System.Drawing.Point(307, 259);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(111, 28);
            this.txtpeso.TabIndex = 84;
            // 
            // cmbpierna
            // 
            this.cmbpierna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpierna.Font = new System.Drawing.Font("Onest Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpierna.FormattingEnabled = true;
            this.cmbpierna.Items.AddRange(new object[] {
            "Derecha",
            "Izquierda"});
            this.cmbpierna.Location = new System.Drawing.Point(307, 200);
            this.cmbpierna.Name = "cmbpierna";
            this.cmbpierna.Size = new System.Drawing.Size(178, 29);
            this.cmbpierna.TabIndex = 83;
            // 
            // CmbPosicion
            // 
            this.CmbPosicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPosicion.Font = new System.Drawing.Font("Onest Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPosicion.FormattingEnabled = true;
            this.CmbPosicion.Items.AddRange(new object[] {
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
            this.CmbPosicion.Location = new System.Drawing.Point(77, 282);
            this.CmbPosicion.Name = "CmbPosicion";
            this.CmbPosicion.Size = new System.Drawing.Size(174, 29);
            this.CmbPosicion.TabIndex = 82;
            // 
            // txtapellido
            // 
            this.txtapellido.Font = new System.Drawing.Font("Onest Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.Location = new System.Drawing.Point(307, 141);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(178, 28);
            this.txtapellido.TabIndex = 81;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Font = new System.Drawing.Font("Onest Light", 12F);
            this.dtpNacimiento.Location = new System.Drawing.Point(77, 403);
            this.dtpNacimiento.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.dtpNacimiento.MinDate = new System.DateTime(1983, 1, 1, 0, 0, 0, 0);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(295, 28);
            this.dtpNacimiento.TabIndex = 80;
            this.dtpNacimiento.Value = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            // 
            // cmbsexo
            // 
            this.cmbsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsexo.Font = new System.Drawing.Font("Onest Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsexo.FormattingEnabled = true;
            this.cmbsexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbsexo.Location = new System.Drawing.Point(77, 199);
            this.cmbsexo.Name = "cmbsexo";
            this.cmbsexo.Size = new System.Drawing.Size(175, 29);
            this.cmbsexo.TabIndex = 79;
            // 
            // Txtnombre
            // 
            this.Txtnombre.Font = new System.Drawing.Font("Onest Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtnombre.Location = new System.Drawing.Point(77, 141);
            this.Txtnombre.Name = "Txtnombre";
            this.Txtnombre.Size = new System.Drawing.Size(178, 28);
            this.Txtnombre.TabIndex = 78;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(846, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 497);
            this.panel4.TabIndex = 104;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 547);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(846, 10);
            this.panel3.TabIndex = 103;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 507);
            this.panel1.TabIndex = 102;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Animated = true;
            this.btnAgregar.BorderColor = System.Drawing.Color.Empty;
            this.btnAgregar.BorderRadius = 20;
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnAgregar.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnAgregar.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(417, 486);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 52);
            this.btnAgregar.TabIndex = 105;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCargarimagen
            // 
            this.btnCargarimagen.Animated = true;
            this.btnCargarimagen.BackColor = System.Drawing.Color.White;
            this.btnCargarimagen.BorderRadius = 14;
            this.btnCargarimagen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCargarimagen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCargarimagen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCargarimagen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCargarimagen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnCargarimagen.Font = new System.Drawing.Font("Onest Bold", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarimagen.ForeColor = System.Drawing.Color.White;
            this.btnCargarimagen.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnCargarimagen.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnCargarimagen.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnCargarimagen.Location = new System.Drawing.Point(513, 327);
            this.btnCargarimagen.Name = "btnCargarimagen";
            this.btnCargarimagen.Size = new System.Drawing.Size(264, 25);
            this.btnCargarimagen.TabIndex = 106;
            this.btnCargarimagen.Text = "Selccionar imagen";
            this.btnCargarimagen.Click += new System.EventHandler(this.btnCargarimagen_Click);
            // 
            // AggJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 557);
            this.ControlBox = false;
            this.Controls.Add(this.btnCargarimagen);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptbImagen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDJugador);
            this.Controls.Add(this.btngCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNacionalidad);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.LblPierna);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.cmbpierna);
            this.Controls.Add(this.CmbPosicion);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.cmbsexo);
            this.Controls.Add(this.Txtnombre);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AggJugadores";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblEncabezado;
        public System.Windows.Forms.PictureBox ptbImagen;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtIDJugador;
        public Guna.UI2.WinForms.Guna2Button btngCancelar;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtNacionalidad;
        public System.Windows.Forms.Label lblaltura;
        public System.Windows.Forms.Label lblfecha;
        public System.Windows.Forms.Label lblpeso;
        public System.Windows.Forms.Label LblPierna;
        public System.Windows.Forms.Label lblPosicion;
        public System.Windows.Forms.Label lblsexo;
        public System.Windows.Forms.Label lblapellido;
        public System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.TextBox txtaltura;
        public System.Windows.Forms.TextBox txtpeso;
        public System.Windows.Forms.ComboBox cmbpierna;
        public System.Windows.Forms.ComboBox CmbPosicion;
        public System.Windows.Forms.TextBox txtapellido;
        public System.Windows.Forms.DateTimePicker dtpNacimiento;
        public System.Windows.Forms.ComboBox cmbsexo;
        public System.Windows.Forms.TextBox Txtnombre;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        public Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnCargarimagen;
    }
}

