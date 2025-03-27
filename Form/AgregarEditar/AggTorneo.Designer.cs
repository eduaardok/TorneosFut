namespace TorneosFut
{
    partial class AggTorneo
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btngSalir = new Guna.UI2.WinForms.Guna2Button();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.cmbOrganizador = new System.Windows.Forms.ComboBox();
            this.cmbModoFutbol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFormato = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrear = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(634, 50);
            this.panel2.TabIndex = 29;
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
            this.btngSalir.Location = new System.Drawing.Point(500, 0);
            this.btngSalir.Name = "btngSalir";
            this.btngSalir.Size = new System.Drawing.Size(134, 50);
            this.btngSalir.TabIndex = 34;
            this.btngSalir.Text = "X";
            this.btngSalir.Click += new System.EventHandler(this.btngSalir_Click);
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Onest Bold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblEncabezado.Location = new System.Drawing.Point(12, 8);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(251, 26);
            this.lblEncabezado.TabIndex = 33;
            this.lblEncabezado.Text = "CREACIÓN DE TORNEO";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(48, 287);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(149, 24);
            this.lblfecha.TabIndex = 59;
            this.lblfecha.Text = "Fecha de Inicio";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Onest Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Location = new System.Drawing.Point(48, 314);
            this.dtpInicio.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpInicio.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(235, 28);
            this.dtpInicio.TabIndex = 58;
            this.dtpInicio.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // cmbOrganizador
            // 
            this.cmbOrganizador.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbOrganizador.BackColor = System.Drawing.Color.White;
            this.cmbOrganizador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrganizador.Font = new System.Drawing.Font("Onest Light", 12F);
            this.cmbOrganizador.FormattingEnabled = true;
            this.cmbOrganizador.Location = new System.Drawing.Point(328, 135);
            this.cmbOrganizador.Name = "cmbOrganizador";
            this.cmbOrganizador.Size = new System.Drawing.Size(231, 29);
            this.cmbOrganizador.TabIndex = 57;
            // 
            // cmbModoFutbol
            // 
            this.cmbModoFutbol.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbModoFutbol.BackColor = System.Drawing.Color.White;
            this.cmbModoFutbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModoFutbol.Font = new System.Drawing.Font("Onest Light", 12F);
            this.cmbModoFutbol.FormattingEnabled = true;
            this.cmbModoFutbol.Items.AddRange(new object[] {
            "Fútbol 11",
            "Fútbol 7",
            "Fútbol 5",
            "Fútbol sala"});
            this.cmbModoFutbol.Location = new System.Drawing.Point(328, 229);
            this.cmbModoFutbol.Name = "cmbModoFutbol";
            this.cmbModoFutbol.Size = new System.Drawing.Size(231, 29);
            this.cmbModoFutbol.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Onest Bold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.label1.Location = new System.Drawing.Point(322, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 55;
            this.label1.Text = "Tipo Fútbol:";
            // 
            // cmbFormato
            // 
            this.cmbFormato.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbFormato.BackColor = System.Drawing.Color.White;
            this.cmbFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormato.Font = new System.Drawing.Font("Onest Light", 12F);
            this.cmbFormato.FormattingEnabled = true;
            this.cmbFormato.Location = new System.Drawing.Point(52, 229);
            this.cmbFormato.Name = "cmbFormato";
            this.cmbFormato.Size = new System.Drawing.Size(231, 29);
            this.cmbFormato.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Onest Bold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.label4.Location = new System.Drawing.Point(46, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 26);
            this.label4.TabIndex = 52;
            this.label4.Text = "Formato:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Onest Bold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.label3.Location = new System.Drawing.Point(331, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 26);
            this.label3.TabIndex = 51;
            this.label3.Text = "Organizador:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Onest Light", 12F);
            this.txtNombre.Location = new System.Drawing.Point(49, 136);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(220, 28);
            this.txtNombre.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Onest Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.label2.Location = new System.Drawing.Point(43, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 26);
            this.label2.TabIndex = 49;
            this.label2.Text = "Nombre:";
            // 
            // btnCrear
            // 
            this.btnCrear.Animated = true;
            this.btnCrear.BackColor = System.Drawing.Color.White;
            this.btnCrear.BorderRadius = 20;
            this.btnCrear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCrear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCrear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCrear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCrear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnCrear.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCrear.ForeColor = System.Drawing.Color.Black;
            this.btnCrear.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnCrear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnCrear.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnCrear.Location = new System.Drawing.Point(491, 421);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(134, 55);
            this.btnCrear.TabIndex = 60;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.Click += new System.EventHandler(this.btngEnviar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(631, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 432);
            this.panel4.TabIndex = 100;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 482);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(631, 10);
            this.panel3.TabIndex = 99;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 442);
            this.panel1.TabIndex = 98;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 24);
            this.label5.TabIndex = 102;
            this.label5.Text = "Fecha de Fin";
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Onest Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Location = new System.Drawing.Point(48, 386);
            this.dtpFin.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpFin.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(235, 28);
            this.dtpFin.TabIndex = 101;
            this.dtpFin.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // txtCosto
            // 
            this.txtCosto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCosto.BackColor = System.Drawing.Color.White;
            this.txtCosto.Font = new System.Drawing.Font("Onest Light", 12F);
            this.txtCosto.Location = new System.Drawing.Point(328, 315);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(149, 28);
            this.txtCosto.TabIndex = 104;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Onest Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.label6.Location = new System.Drawing.Point(331, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 26);
            this.label6.TabIndex = 103;
            this.label6.Text = "Costo de inscripción:";
            // 
            // AggTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 492);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.cmbOrganizador);
            this.Controls.Add(this.cmbModoFutbol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFormato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AggTorneo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AggTorneo";
            this.Load += new System.EventHandler(this.AggTorneo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btngSalir;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.ComboBox cmbOrganizador;
        private System.Windows.Forms.ComboBox cmbModoFutbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFormato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnCrear;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFin;
    }
}