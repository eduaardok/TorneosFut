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
            this.Txtnombre = new System.Windows.Forms.TextBox();
            this.cmbsexo = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.CmbPosicion = new System.Windows.Forms.ComboBox();
            this.cmbpierna = new System.Windows.Forms.ComboBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.LblPierna = new System.Windows.Forms.Label();
            this.lblpeso = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNacionalidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btngCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDJugador = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCargarimagen = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txtnombre
            // 
            this.Txtnombre.Location = new System.Drawing.Point(50, 153);
            this.Txtnombre.Name = "Txtnombre";
            this.Txtnombre.Size = new System.Drawing.Size(178, 20);
            this.Txtnombre.TabIndex = 0;
            // 
            // cmbsexo
            // 
            this.cmbsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsexo.FormattingEnabled = true;
            this.cmbsexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbsexo.Location = new System.Drawing.Point(50, 203);
            this.cmbsexo.Name = "cmbsexo";
            this.cmbsexo.Size = new System.Drawing.Size(121, 21);
            this.cmbsexo.TabIndex = 1;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Location = new System.Drawing.Point(245, 299);
            this.dtpNacimiento.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.dtpNacimiento.MinDate = new System.DateTime(1983, 1, 1, 0, 0, 0, 0);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpNacimiento.TabIndex = 4;
            this.dtpNacimiento.Value = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(244, 104);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(178, 20);
            this.txtapellido.TabIndex = 5;
            // 
            // CmbPosicion
            // 
            this.CmbPosicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.CmbPosicion.Location = new System.Drawing.Point(51, 248);
            this.CmbPosicion.Name = "CmbPosicion";
            this.CmbPosicion.Size = new System.Drawing.Size(121, 21);
            this.CmbPosicion.TabIndex = 6;
            // 
            // cmbpierna
            // 
            this.cmbpierna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpierna.FormattingEnabled = true;
            this.cmbpierna.Items.AddRange(new object[] {
            "Derecha",
            "Izquierda"});
            this.cmbpierna.Location = new System.Drawing.Point(244, 153);
            this.cmbpierna.Name = "cmbpierna";
            this.cmbpierna.Size = new System.Drawing.Size(178, 21);
            this.cmbpierna.TabIndex = 7;
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(244, 204);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(111, 20);
            this.txtpeso.TabIndex = 8;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(244, 252);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 20);
            this.txtaltura.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(46, 126);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(103, 24);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombres*";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellido.Location = new System.Drawing.Point(241, 77);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(103, 24);
            this.lblapellido.TabIndex = 12;
            this.lblapellido.Text = "Apellidos*";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsexo.Location = new System.Drawing.Point(47, 176);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(63, 24);
            this.lblsexo.TabIndex = 13;
            this.lblsexo.Text = "Sexo*";
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.Location = new System.Drawing.Point(47, 224);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(97, 24);
            this.lblPosicion.TabIndex = 14;
            this.lblPosicion.Text = "Posicion*";
            this.lblPosicion.Click += new System.EventHandler(this.lblPosicion_Click);
            // 
            // LblPierna
            // 
            this.LblPierna.AutoSize = true;
            this.LblPierna.BackColor = System.Drawing.Color.Transparent;
            this.LblPierna.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPierna.Location = new System.Drawing.Point(240, 127);
            this.LblPierna.Name = "LblPierna";
            this.LblPierna.Size = new System.Drawing.Size(131, 24);
            this.LblPierna.TabIndex = 15;
            this.LblPierna.Text = "Pierna Hábil*";
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpeso.Location = new System.Drawing.Point(240, 177);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(100, 24);
            this.lblpeso.TabIndex = 16;
            this.lblpeso.Text = "Peso/KG*";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(241, 272);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(214, 24);
            this.lblfecha.TabIndex = 17;
            this.lblfecha.Text = "Fecha de Nacimiento*";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaltura.Location = new System.Drawing.Point(240, 227);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(75, 24);
            this.lblaltura.TabIndex = 18;
            this.lblaltura.Text = "Altura*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nacionalidad*";
            // 
            // TxtNacionalidad
            // 
            this.TxtNacionalidad.Location = new System.Drawing.Point(50, 299);
            this.TxtNacionalidad.Name = "TxtNacionalidad";
            this.TxtNacionalidad.Size = new System.Drawing.Size(178, 20);
            this.TxtNacionalidad.TabIndex = 20;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(278, 335);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(144, 59);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btngCancelar
            // 
            this.btngCancelar.BackColor = System.Drawing.Color.White;
            this.btngCancelar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btngCancelar.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btngCancelar.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btngCancelar.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btngCancelar.CustomBorderColor = System.Drawing.Color.White;
            this.btngCancelar.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btngCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btngCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngCancelar.ForeColor = System.Drawing.Color.Black;
            this.btngCancelar.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btngCancelar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btngCancelar.Location = new System.Drawing.Point(51, 335);
            this.btngCancelar.Name = "btngCancelar";
            this.btngCancelar.Size = new System.Drawing.Size(127, 59);
            this.btngCancelar.TabIndex = 23;
            this.btngCancelar.Text = "CANCELAR";
            this.btngCancelar.Click += new System.EventHandler(this.btngCancelar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.panel2.Controls.Add(this.lblEncabezado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 50);
            this.panel2.TabIndex = 49;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblEncabezado.Location = new System.Drawing.Point(12, 8);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(239, 25);
            this.lblEncabezado.TabIndex = 33;
            this.lblEncabezado.Text = "AGREGAR JUGADOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 24);
            this.label2.TabIndex = 51;
            this.label2.Text = "ID*";
            // 
            // txtIDJugador
            // 
            this.txtIDJugador.Location = new System.Drawing.Point(50, 104);
            this.txtIDJugador.Name = "txtIDJugador";
            this.txtIDJugador.Size = new System.Drawing.Size(178, 20);
            this.txtIDJugador.TabIndex = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(476, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 242);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // btnCargarimagen
            // 
            this.btnCargarimagen.BackColor = System.Drawing.Color.White;
            this.btnCargarimagen.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCargarimagen.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnCargarimagen.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnCargarimagen.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnCargarimagen.CustomBorderColor = System.Drawing.Color.White;
            this.btnCargarimagen.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnCargarimagen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCargarimagen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCargarimagen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCargarimagen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCargarimagen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnCargarimagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarimagen.ForeColor = System.Drawing.Color.Black;
            this.btnCargarimagen.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnCargarimagen.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnCargarimagen.Location = new System.Drawing.Point(536, 325);
            this.btnCargarimagen.Name = "btnCargarimagen";
            this.btnCargarimagen.Size = new System.Drawing.Size(152, 44);
            this.btnCargarimagen.TabIndex = 53;
            this.btnCargarimagen.Text = "Cargar Imagen";
            // 
            // AggJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 422);
            this.ControlBox = false;
            this.Controls.Add(this.btnCargarimagen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDJugador);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btngCancelar);
            this.Controls.Add(this.btnAgregar);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtnombre;
        private System.Windows.Forms.ComboBox cmbsexo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.ComboBox CmbPosicion;
        private System.Windows.Forms.ComboBox cmbpierna;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Label LblPierna;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNacionalidad;
        private System.Windows.Forms.Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btngCancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDJugador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnCargarimagen;
    }
}

