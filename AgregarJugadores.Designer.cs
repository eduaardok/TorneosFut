namespace pruebas
{
    partial class AgregarJugadores
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
            this.Cmbequipo = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.LblPierna = new System.Windows.Forms.Label();
            this.lblpeso = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lblequipo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNacionalidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txtnombre
            // 
            this.Txtnombre.Location = new System.Drawing.Point(174, 83);
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
            this.cmbsexo.Location = new System.Drawing.Point(174, 128);
            this.cmbsexo.Name = "cmbsexo";
            this.cmbsexo.Size = new System.Drawing.Size(121, 21);
            this.cmbsexo.TabIndex = 1;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Location = new System.Drawing.Point(370, 255);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpNacimiento.TabIndex = 4;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(370, 83);
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
            this.CmbPosicion.Location = new System.Drawing.Point(174, 168);
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
            this.cmbpierna.Location = new System.Drawing.Point(370, 138);
            this.cmbpierna.Name = "cmbpierna";
            this.cmbpierna.Size = new System.Drawing.Size(178, 21);
            this.cmbpierna.TabIndex = 7;
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(370, 178);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(111, 20);
            this.txtpeso.TabIndex = 8;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(370, 216);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 20);
            this.txtaltura.TabIndex = 9;
            // 
            // Cmbequipo
            // 
            this.Cmbequipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbequipo.FormattingEnabled = true;
            this.Cmbequipo.Items.AddRange(new object[] {
            "Ninguno"});
            this.Cmbequipo.Location = new System.Drawing.Point(174, 208);
            this.Cmbequipo.Name = "Cmbequipo";
            this.Cmbequipo.Size = new System.Drawing.Size(121, 21);
            this.Cmbequipo.TabIndex = 10;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(174, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(49, 13);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombres";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(371, 67);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(49, 13);
            this.lblapellido.TabIndex = 12;
            this.lblapellido.Text = "Apellidos";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(174, 112);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(31, 13);
            this.lblsexo.TabIndex = 13;
            this.lblsexo.Text = "Sexo";
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Location = new System.Drawing.Point(171, 152);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(47, 13);
            this.lblPosicion.TabIndex = 14;
            this.lblPosicion.Text = "Posicion";
            this.lblPosicion.Click += new System.EventHandler(this.lblPosicion_Click);
            // 
            // LblPierna
            // 
            this.LblPierna.AutoSize = true;
            this.LblPierna.BackColor = System.Drawing.SystemColors.Control;
            this.LblPierna.Location = new System.Drawing.Point(367, 112);
            this.LblPierna.Name = "LblPierna";
            this.LblPierna.Size = new System.Drawing.Size(64, 13);
            this.LblPierna.TabIndex = 15;
            this.LblPierna.Text = "Pierna Hábil";
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Location = new System.Drawing.Point(367, 162);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(51, 13);
            this.lblpeso.TabIndex = 16;
            this.lblpeso.Text = "Peso/KG";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(367, 239);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(108, 13);
            this.lblfecha.TabIndex = 17;
            this.lblfecha.Text = "Fecha de Nacimiento";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Location = new System.Drawing.Point(367, 201);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(34, 13);
            this.lblaltura.TabIndex = 18;
            this.lblaltura.Text = "Altura";
            // 
            // lblequipo
            // 
            this.lblequipo.AutoSize = true;
            this.lblequipo.Location = new System.Drawing.Point(171, 192);
            this.lblequipo.Name = "lblequipo";
            this.lblequipo.Size = new System.Drawing.Size(40, 13);
            this.lblequipo.TabIndex = 19;
            this.lblequipo.Text = "Equipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nacionalidad";
            // 
            // TxtNacionalidad
            // 
            this.TxtNacionalidad.Location = new System.Drawing.Point(174, 248);
            this.TxtNacionalidad.Name = "TxtNacionalidad";
            this.TxtNacionalidad.Size = new System.Drawing.Size(100, 20);
            this.TxtNacionalidad.TabIndex = 20;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(476, 302);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 82);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // AgregarJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNacionalidad);
            this.Controls.Add(this.lblequipo);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.LblPierna);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.Cmbequipo);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.cmbpierna);
            this.Controls.Add(this.CmbPosicion);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.cmbsexo);
            this.Controls.Add(this.Txtnombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarJugadores";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ComboBox Cmbequipo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Label LblPierna;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lblequipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNacionalidad;
        private System.Windows.Forms.Button btnAgregar;
    }
}

