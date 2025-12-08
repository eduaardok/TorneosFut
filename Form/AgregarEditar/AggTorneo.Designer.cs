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
            this.label7 = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.numEdadmin = new System.Windows.Forms.NumericUpDown();
            this.numEdadmax = new System.Windows.Forms.NumericUpDown();
            this.lblEdadMin = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdadmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEdadmax)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.panel2.Controls.Add(this.btngSalir);
            this.panel2.Controls.Add(this.lblEncabezado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 62);
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
            this.btngSalir.Location = new System.Drawing.Point(666, 0);
            this.btngSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btngSalir.Name = "btngSalir";
            this.btngSalir.Size = new System.Drawing.Size(179, 62);
            this.btngSalir.TabIndex = 34;
            this.btngSalir.Text = "X";
            this.btngSalir.Click += new System.EventHandler(this.btngSalir_Click);
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblEncabezado.Location = new System.Drawing.Point(16, 10);
            this.lblEncabezado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(269, 25);
            this.lblEncabezado.TabIndex = 33;
            this.lblEncabezado.Text = "CREACIÓN DE TORNEO";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(59, 290);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(155, 24);
            this.lblfecha.TabIndex = 59;
            this.lblfecha.Text = "Fecha de Inicio";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Location = new System.Drawing.Point(59, 325);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpInicio.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpInicio.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(312, 26);
            this.dtpInicio.TabIndex = 58;
            this.dtpInicio.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // cmbOrganizador
            // 
            this.cmbOrganizador.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbOrganizador.BackColor = System.Drawing.Color.White;
            this.cmbOrganizador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrganizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbOrganizador.FormattingEnabled = true;
            this.cmbOrganizador.Location = new System.Drawing.Point(437, 125);
            this.cmbOrganizador.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOrganizador.Name = "cmbOrganizador";
            this.cmbOrganizador.Size = new System.Drawing.Size(307, 28);
            this.cmbOrganizador.TabIndex = 57;
            // 
            // cmbModoFutbol
            // 
            this.cmbModoFutbol.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbModoFutbol.BackColor = System.Drawing.Color.White;
            this.cmbModoFutbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModoFutbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbModoFutbol.FormattingEnabled = true;
            this.cmbModoFutbol.Items.AddRange(new object[] {
            "Fútbol 11",
            "Fútbol 7",
            "Fútbol 5",
            "Fútbol sala"});
            this.cmbModoFutbol.Location = new System.Drawing.Point(437, 225);
            this.cmbModoFutbol.Margin = new System.Windows.Forms.Padding(4);
            this.cmbModoFutbol.Name = "cmbModoFutbol";
            this.cmbModoFutbol.Size = new System.Drawing.Size(307, 28);
            this.cmbModoFutbol.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.label1.Location = new System.Drawing.Point(431, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "Tipo Fútbol:";
            // 
            // cmbFormato
            // 
            this.cmbFormato.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbFormato.BackColor = System.Drawing.Color.White;
            this.cmbFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbFormato.FormattingEnabled = true;
            this.cmbFormato.Location = new System.Drawing.Point(59, 225);
            this.cmbFormato.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFormato.Name = "cmbFormato";
            this.cmbFormato.Size = new System.Drawing.Size(312, 28);
            this.cmbFormato.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.label4.Location = new System.Drawing.Point(59, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 52;
            this.label4.Text = "Formato:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.label3.Location = new System.Drawing.Point(431, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "Organizador:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombre.Location = new System.Drawing.Point(59, 125);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(312, 26);
            this.txtNombre.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.label2.Location = new System.Drawing.Point(59, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Nombre:";
            // 
            // btnCrear
            // 
            this.btnCrear.Animated = true;
            this.btnCrear.BackColor = System.Drawing.Color.Transparent;
            this.btnCrear.BorderRadius = 20;
            this.btnCrear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCrear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCrear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCrear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCrear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCrear.ForeColor = System.Drawing.Color.Black;
            this.btnCrear.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnCrear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnCrear.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnCrear.Location = new System.Drawing.Point(653, 617);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(179, 68);
            this.btnCrear.TabIndex = 60;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.Click += new System.EventHandler(this.btngEnviar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(841, 62);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 631);
            this.panel4.TabIndex = 100;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(4, 693);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(841, 12);
            this.panel3.TabIndex = 99;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 643);
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
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 390);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 24);
            this.label5.TabIndex = 102;
            this.label5.Text = "Fecha de Fin";
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Location = new System.Drawing.Point(59, 425);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFin.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpFin.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(312, 26);
            this.dtpFin.TabIndex = 101;
            this.dtpFin.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // txtCosto
            // 
            this.txtCosto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCosto.BackColor = System.Drawing.Color.White;
            this.txtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCosto.Location = new System.Drawing.Point(437, 425);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(282, 26);
            this.txtCosto.TabIndex = 104;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.label6.Location = new System.Drawing.Point(431, 390);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 25);
            this.label6.TabIndex = 103;
            this.label6.Text = "Costo de inscripción:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.label7.Location = new System.Drawing.Point(431, 290);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 105;
            this.label7.Text = "Genero:";
            // 
            // cmbGenero
            // 
            this.cmbGenero.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbGenero.BackColor = System.Drawing.Color.White;
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(431, 325);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(307, 28);
            this.cmbGenero.TabIndex = 106;
            // 
            // numEdadmin
            // 
            this.numEdadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numEdadmin.Location = new System.Drawing.Point(59, 525);
            this.numEdadmin.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numEdadmin.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numEdadmin.Name = "numEdadmin";
            this.numEdadmin.ReadOnly = true;
            this.numEdadmin.Size = new System.Drawing.Size(165, 26);
            this.numEdadmin.TabIndex = 107;
            this.numEdadmin.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numEdadmax
            // 
            this.numEdadmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numEdadmax.Location = new System.Drawing.Point(251, 525);
            this.numEdadmax.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numEdadmax.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numEdadmax.Name = "numEdadmax";
            this.numEdadmax.ReadOnly = true;
            this.numEdadmax.Size = new System.Drawing.Size(165, 26);
            this.numEdadmax.TabIndex = 108;
            this.numEdadmax.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblEdadMin
            // 
            this.lblEdadMin.AutoSize = true;
            this.lblEdadMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadMin.Location = new System.Drawing.Point(59, 490);
            this.lblEdadMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdadMin.Name = "lblEdadMin";
            this.lblEdadMin.Size = new System.Drawing.Size(132, 24);
            this.lblEdadMin.TabIndex = 109;
            this.lblEdadMin.Text = "Edad minima";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(246, 490);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 24);
            this.label8.TabIndex = 110;
            this.label8.Text = "Edad máxima";
            // 
            // AggTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 705);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblEdadMin);
            this.Controls.Add(this.numEdadmax);
            this.Controls.Add(this.numEdadmin);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.label7);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
            ((System.ComponentModel.ISupportInitialize)(this.numEdadmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEdadmax)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.NumericUpDown numEdadmax;
        private System.Windows.Forms.NumericUpDown numEdadmin;
        private System.Windows.Forms.Label lblEdadMin;
        private System.Windows.Forms.Label label8;
    }
}