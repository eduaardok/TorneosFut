﻿namespace TorneosFut
{
    partial class FrmEditarjugador
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblpeso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(314, 244);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 82);
            this.btnEditar.TabIndex = 65;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblequipo
            // 
            this.lblequipo.AutoSize = true;
            this.lblequipo.Location = new System.Drawing.Point(14, 94);
            this.lblequipo.Name = "lblequipo";
            this.lblequipo.Size = new System.Drawing.Size(40, 13);
            this.lblequipo.TabIndex = 62;
            this.lblequipo.Text = "Equipo";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Location = new System.Drawing.Point(209, 93);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(34, 13);
            this.lblaltura.TabIndex = 61;
            this.lblaltura.Text = "Altura";
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Location = new System.Drawing.Point(14, 54);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(47, 13);
            this.lblPosicion.TabIndex = 57;
            this.lblPosicion.Text = "Posicion";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(209, 9);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(49, 13);
            this.lblapellido.TabIndex = 55;
            this.lblapellido.Text = "Apellidos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(49, 13);
            this.lblNombre.TabIndex = 54;
            this.lblNombre.Text = "Nombres";
            // 
            // Cmbequipo
            // 
            this.Cmbequipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbequipo.FormattingEnabled = true;
            this.Cmbequipo.Items.AddRange(new object[] {
            "Ninguno"});
            this.Cmbequipo.Location = new System.Drawing.Point(17, 110);
            this.Cmbequipo.Name = "Cmbequipo";
            this.Cmbequipo.Size = new System.Drawing.Size(121, 21);
            this.Cmbequipo.TabIndex = 53;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(212, 108);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 20);
            this.txtaltura.TabIndex = 52;
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(212, 70);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(111, 20);
            this.txtpeso.TabIndex = 51;
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
            this.CmbPosicion.Location = new System.Drawing.Point(17, 70);
            this.CmbPosicion.Name = "CmbPosicion";
            this.CmbPosicion.Size = new System.Drawing.Size(121, 21);
            this.CmbPosicion.TabIndex = 49;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(208, 25);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(178, 20);
            this.txtapellido.TabIndex = 48;
            // 
            // Txtnombre
            // 
            this.Txtnombre.Location = new System.Drawing.Point(12, 25);
            this.Txtnombre.Name = "Txtnombre";
            this.Txtnombre.Size = new System.Drawing.Size(178, 20);
            this.Txtnombre.TabIndex = 45;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(39, 244);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 82);
            this.btnCancelar.TabIndex = 66;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(440, 6);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(72, 16);
            this.dgv.TabIndex = 67;
            this.dgv.Visible = false;
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Location = new System.Drawing.Point(209, 54);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(51, 13);
            this.lblpeso.TabIndex = 59;
            this.lblpeso.Text = "Peso/KG";
            // 
            // FrmEditarjugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 358);
            this.Controls.Add(this.dgv);
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
            this.Name = "FrmEditarjugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editarjugador";
            this.Load += new System.EventHandler(this.FrmEditarjugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblequipo;
        private System.Windows.Forms.Label lblaltura;
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
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblpeso;
    }
}