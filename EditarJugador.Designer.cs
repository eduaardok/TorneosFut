namespace TorneosFut
{
    partial class EditarJugador
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblequipo = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.Cmbequipo = new System.Windows.Forms.ComboBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.CmbPosicion = new System.Windows.Forms.ComboBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.Txtnombre = new System.Windows.Forms.TextBox();
            this.lblpeso = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(430, 210);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 82);
            this.btnAgregar.TabIndex = 43;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblequipo
            // 
            this.lblequipo.AutoSize = true;
            this.lblequipo.Location = new System.Drawing.Point(121, 114);
            this.lblequipo.Name = "lblequipo";
            this.lblequipo.Size = new System.Drawing.Size(40, 13);
            this.lblequipo.TabIndex = 40;
            this.lblequipo.Text = "Equipo";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Location = new System.Drawing.Point(321, 114);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(34, 13);
            this.lblaltura.TabIndex = 39;
            this.lblaltura.Text = "Altura";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(321, 152);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(108, 13);
            this.lblfecha.TabIndex = 38;
            this.lblfecha.Text = "Fecha de Nacimiento";
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Location = new System.Drawing.Point(121, 74);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(47, 13);
            this.lblPosicion.TabIndex = 35;
            this.lblPosicion.Text = "Posicion";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(321, 35);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(49, 13);
            this.lblapellido.TabIndex = 33;
            this.lblapellido.Text = "Apellidos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(124, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(49, 13);
            this.lblNombre.TabIndex = 32;
            this.lblNombre.Text = "Nombres";
            // 
            // Cmbequipo
            // 
            this.Cmbequipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbequipo.FormattingEnabled = true;
            this.Cmbequipo.Items.AddRange(new object[] {
            "Ninguno"});
            this.Cmbequipo.Location = new System.Drawing.Point(124, 130);
            this.Cmbequipo.Name = "Cmbequipo";
            this.Cmbequipo.Size = new System.Drawing.Size(121, 21);
            this.Cmbequipo.TabIndex = 31;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(324, 129);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 20);
            this.txtaltura.TabIndex = 30;
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(324, 90);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(111, 20);
            this.txtpeso.TabIndex = 29;
            // 
            // CmbPosicion
            // 
            this.CmbPosicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPosicion.FormattingEnabled = true;
            this.CmbPosicion.Items.AddRange(new object[] {
            "Portero (Guardameta)",
            "",
            "Defensa central",
            "",
            "Lateral derecho",
            "",
            "Lateral izquierdo",
            "",
            "Carrilero derecho",
            "",
            "Carrilero izquierdo",
            "",
            "Mediocentro defensivo",
            "",
            "Mediocentro",
            "",
            "Mediocentro ofensivo",
            "",
            "Interior derecho",
            "",
            "Interior izquierdo",
            "",
            "Extremo derecho",
            "",
            "Extremo izquierdo",
            "",
            "Mediapunta",
            "",
            "Delantero centro",
            "",
            "Segunda punta",
            "",
            "Falso nueve"});
            this.CmbPosicion.Location = new System.Drawing.Point(124, 90);
            this.CmbPosicion.Name = "CmbPosicion";
            this.CmbPosicion.Size = new System.Drawing.Size(121, 21);
            this.CmbPosicion.TabIndex = 27;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(320, 51);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(178, 20);
            this.txtapellido.TabIndex = 26;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Location = new System.Drawing.Point(324, 168);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpNacimiento.TabIndex = 25;
            // 
            // Txtnombre
            // 
            this.Txtnombre.Location = new System.Drawing.Point(124, 51);
            this.Txtnombre.Name = "Txtnombre";
            this.Txtnombre.Size = new System.Drawing.Size(178, 20);
            this.Txtnombre.TabIndex = 23;
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Location = new System.Drawing.Point(321, 74);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(51, 13);
            this.lblpeso.TabIndex = 37;
            this.lblpeso.Text = "Peso/KG";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(127, 210);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(94, 82);
            this.btncancelar.TabIndex = 44;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // EditarJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 386);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblequipo);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.Cmbequipo);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.CmbPosicion);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.Txtnombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarJugador";
            this.Text = "EditarJugador";
            this.Load += new System.EventHandler(this.EditarJugador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblequipo;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox Cmbequipo;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.ComboBox CmbPosicion;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.TextBox Txtnombre;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.Button btncancelar;
    }
}