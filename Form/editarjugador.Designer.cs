namespace pruebas
{
    partial class editarjugador
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblequipo = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lblpeso = new System.Windows.Forms.Label();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.Cmbequipo = new System.Windows.Forms.ComboBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.CmbPosicion = new System.Windows.Forms.ComboBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.Txtnombre = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditarIMG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(242, 188);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 82);
            this.btnEditar.TabIndex = 43;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblequipo
            // 
            this.lblequipo.AutoSize = true;
            this.lblequipo.Location = new System.Drawing.Point(46, 126);
            this.lblequipo.Name = "lblequipo";
            this.lblequipo.Size = new System.Drawing.Size(40, 13);
            this.lblequipo.TabIndex = 40;
            this.lblequipo.Text = "Equipo";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Location = new System.Drawing.Point(239, 125);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(34, 13);
            this.lblaltura.TabIndex = 39;
            this.lblaltura.Text = "Altura";
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Location = new System.Drawing.Point(239, 86);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(51, 13);
            this.lblpeso.TabIndex = 37;
            this.lblpeso.Text = "Peso/KG";
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Location = new System.Drawing.Point(46, 86);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(47, 13);
            this.lblPosicion.TabIndex = 35;
            this.lblPosicion.Text = "Posicion";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(243, 41);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(49, 13);
            this.lblapellido.TabIndex = 33;
            this.lblapellido.Text = "Apellidos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(46, 41);
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
            this.Cmbequipo.Location = new System.Drawing.Point(49, 142);
            this.Cmbequipo.Name = "Cmbequipo";
            this.Cmbequipo.Size = new System.Drawing.Size(121, 21);
            this.Cmbequipo.TabIndex = 31;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(242, 141);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 20);
            this.txtaltura.TabIndex = 30;
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(242, 102);
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
            this.CmbPosicion.Location = new System.Drawing.Point(49, 102);
            this.CmbPosicion.Name = "CmbPosicion";
            this.CmbPosicion.Size = new System.Drawing.Size(121, 21);
            this.CmbPosicion.TabIndex = 27;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(242, 57);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(178, 20);
            this.txtapellido.TabIndex = 26;
            // 
            // Txtnombre
            // 
            this.Txtnombre.Location = new System.Drawing.Point(46, 57);
            this.Txtnombre.Name = "Txtnombre";
            this.Txtnombre.Size = new System.Drawing.Size(178, 20);
            this.Txtnombre.TabIndex = 23;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnCancelar.Location = new System.Drawing.Point(49, 188);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 82);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(634, 12);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(11, 14);
            this.dgvDatos.TabIndex = 45;
            this.dgvDatos.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(437, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 112);
            this.panel1.TabIndex = 46;
            // 
            // btnEditarIMG
            // 
            this.btnEditarIMG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnEditarIMG.Font = new System.Drawing.Font("Onest Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarIMG.Location = new System.Drawing.Point(427, 171);
            this.btnEditarIMG.Name = "btnEditarIMG";
            this.btnEditarIMG.Size = new System.Drawing.Size(191, 35);
            this.btnEditarIMG.TabIndex = 47;
            this.btnEditarIMG.Text = "Editar Imagen";
            this.btnEditarIMG.UseVisualStyleBackColor = false;
            this.btnEditarIMG.Visible = false;
            this.btnEditarIMG.Click += new System.EventHandler(this.btnEditarIMG_Click);
            // 
            // editarjugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 415);
            this.ControlBox = false;
            this.Controls.Add(this.btnEditarIMG);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblequipo);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.Cmbequipo);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.CmbPosicion);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.Txtnombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editarjugador";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editarjugador";
            this.Load += new System.EventHandler(this.editarjugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblequipo;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox Cmbequipo;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.ComboBox CmbPosicion;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox Txtnombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditarIMG;
    }
}