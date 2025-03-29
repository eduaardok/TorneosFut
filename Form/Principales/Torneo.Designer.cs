namespace TorneosFut
{
    partial class Torneo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReglas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnJugador = new System.Windows.Forms.Button();
            this.btnArbitros = new System.Windows.Forms.Button();
            this.btnOrganizador = new System.Windows.Forms.Button();
            this.btnCrear = new Guna.UI2.WinForms.Guna2Button();
            this.btnPatrocinadores = new Guna.UI2.WinForms.Guna2Button();
            this.btnInscripcionEquipos = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.btnPartidos = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscarTorneo = new System.Windows.Forms.TextBox();
            this.dgvTorneo = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnasistidores = new Guna.UI2.WinForms.Guna2Button();
            this.btngoleadores = new Guna.UI2.WinForms.Guna2Button();
            this.panelmodul = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTorneo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.btnReglas);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnJugador);
            this.panel1.Controls.Add(this.btnArbitros);
            this.panel1.Controls.Add(this.btnOrganizador);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1490, 100);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnReglas
            // 
            this.btnReglas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnReglas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReglas.Font = new System.Drawing.Font("Onest Bold", 20F, System.Drawing.FontStyle.Bold);
            this.btnReglas.ForeColor = System.Drawing.Color.White;
            this.btnReglas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReglas.Location = new System.Drawing.Point(1275, 9);
            this.btnReglas.Name = "btnReglas";
            this.btnReglas.Size = new System.Drawing.Size(183, 85);
            this.btnReglas.TabIndex = 8;
            this.btnReglas.Text = "FORMATO";
            this.btnReglas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReglas.UseVisualStyleBackColor = false;
            this.btnReglas.Visible = false;
            this.btnReglas.Click += new System.EventHandler(this.btnReglas_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Onest Bold", 20F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::TorneosFut.Properties.Resources.icons8_trofeo_50;
            this.button1.Location = new System.Drawing.Point(21, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 85);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnJugador
            // 
            this.btnJugador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnJugador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJugador.Font = new System.Drawing.Font("Onest Bold", 20F, System.Drawing.FontStyle.Bold);
            this.btnJugador.ForeColor = System.Drawing.Color.White;
            this.btnJugador.Image = global::TorneosFut.Properties.Resources.icons8_patrocinador_50;
            this.btnJugador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJugador.Location = new System.Drawing.Point(218, 9);
            this.btnJugador.Name = "btnJugador";
            this.btnJugador.Size = new System.Drawing.Size(319, 85);
            this.btnJugador.TabIndex = 3;
            this.btnJugador.Text = "PATROCINADORES";
            this.btnJugador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnJugador.UseVisualStyleBackColor = false;
            this.btnJugador.Click += new System.EventHandler(this.btnJugadores_Click);
            // 
            // btnArbitros
            // 
            this.btnArbitros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnArbitros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArbitros.Font = new System.Drawing.Font("Onest Bold", 20F, System.Drawing.FontStyle.Bold);
            this.btnArbitros.ForeColor = System.Drawing.Color.White;
            this.btnArbitros.Image = global::TorneosFut.Properties.Resources.icons8_silbato_50;
            this.btnArbitros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArbitros.Location = new System.Drawing.Point(628, 9);
            this.btnArbitros.Name = "btnArbitros";
            this.btnArbitros.Size = new System.Drawing.Size(221, 85);
            this.btnArbitros.TabIndex = 6;
            this.btnArbitros.Text = "ÁRBITROS";
            this.btnArbitros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnArbitros.UseVisualStyleBackColor = false;
            this.btnArbitros.Click += new System.EventHandler(this.btnArbitros_Click);
            // 
            // btnOrganizador
            // 
            this.btnOrganizador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnOrganizador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrganizador.Font = new System.Drawing.Font("Onest Bold", 20F, System.Drawing.FontStyle.Bold);
            this.btnOrganizador.ForeColor = System.Drawing.Color.White;
            this.btnOrganizador.Image = global::TorneosFut.Properties.Resources.icons8_organizador_80;
            this.btnOrganizador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrganizador.Location = new System.Drawing.Point(907, 9);
            this.btnOrganizador.Name = "btnOrganizador";
            this.btnOrganizador.Size = new System.Drawing.Size(318, 85);
            this.btnOrganizador.TabIndex = 5;
            this.btnOrganizador.Text = "ORGANIZADORES";
            this.btnOrganizador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrganizador.UseVisualStyleBackColor = false;
            this.btnOrganizador.Click += new System.EventHandler(this.btnEstadios_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCrear.Animated = true;
            this.btnCrear.BorderRadius = 20;
            this.btnCrear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCrear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCrear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCrear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCrear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnCrear.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.Black;
            this.btnCrear.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnCrear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnCrear.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnCrear.Location = new System.Drawing.Point(357, 211);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(180, 59);
            this.btnCrear.TabIndex = 64;
            this.btnCrear.Text = "CREAR TORNEO";
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click_1);
            // 
            // btnPatrocinadores
            // 
            this.btnPatrocinadores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPatrocinadores.Animated = true;
            this.btnPatrocinadores.BorderRadius = 20;
            this.btnPatrocinadores.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPatrocinadores.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPatrocinadores.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPatrocinadores.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPatrocinadores.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnPatrocinadores.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatrocinadores.ForeColor = System.Drawing.Color.White;
            this.btnPatrocinadores.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnPatrocinadores.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnPatrocinadores.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnPatrocinadores.Location = new System.Drawing.Point(930, 211);
            this.btnPatrocinadores.Name = "btnPatrocinadores";
            this.btnPatrocinadores.Size = new System.Drawing.Size(213, 59);
            this.btnPatrocinadores.TabIndex = 63;
            this.btnPatrocinadores.Text = "ASIGNAR PATROCINADORES";
            this.btnPatrocinadores.Visible = false;
            // 
            // btnInscripcionEquipos
            // 
            this.btnInscripcionEquipos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInscripcionEquipos.Animated = true;
            this.btnInscripcionEquipos.BorderRadius = 20;
            this.btnInscripcionEquipos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInscripcionEquipos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInscripcionEquipos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInscripcionEquipos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInscripcionEquipos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnInscripcionEquipos.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscripcionEquipos.ForeColor = System.Drawing.Color.White;
            this.btnInscripcionEquipos.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnInscripcionEquipos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnInscripcionEquipos.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnInscripcionEquipos.Location = new System.Drawing.Point(963, 211);
            this.btnInscripcionEquipos.Name = "btnInscripcionEquipos";
            this.btnInscripcionEquipos.Size = new System.Drawing.Size(180, 59);
            this.btnInscripcionEquipos.TabIndex = 62;
            this.btnInscripcionEquipos.Text = "INSCRIBIR EQUIPOS";
            this.btnInscripcionEquipos.Click += new System.EventHandler(this.btnInscripcionEquipos_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.Animated = true;
            this.btnEditar.BorderRadius = 20;
            this.btnEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnEditar.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnEditar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnEditar.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(150, 211);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(180, 59);
            this.btnEditar.TabIndex = 61;
            this.btnEditar.Text = "EDITAR TORNEO";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnPartidos
            // 
            this.btnPartidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPartidos.Animated = true;
            this.btnPartidos.BorderRadius = 20;
            this.btnPartidos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPartidos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPartidos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPartidos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPartidos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnPartidos.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartidos.ForeColor = System.Drawing.Color.White;
            this.btnPartidos.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnPartidos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnPartidos.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnPartidos.Location = new System.Drawing.Point(1161, 211);
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.Size = new System.Drawing.Size(180, 59);
            this.btnPartidos.TabIndex = 60;
            this.btnPartidos.Text = "GESTIONAR PARTIDOS";
            this.btnPartidos.Click += new System.EventHandler(this.btnPartidos_Click);
            // 
            // txtBuscarTorneo
            // 
            this.txtBuscarTorneo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarTorneo.Font = new System.Drawing.Font("Onest Light", 20F);
            this.txtBuscarTorneo.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscarTorneo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBuscarTorneo.Location = new System.Drawing.Point(277, 131);
            this.txtBuscarTorneo.Multiline = true;
            this.txtBuscarTorneo.Name = "txtBuscarTorneo";
            this.txtBuscarTorneo.Size = new System.Drawing.Size(633, 48);
            this.txtBuscarTorneo.TabIndex = 58;
            this.txtBuscarTorneo.Text = "Buscar por nombre del Torneo";
            this.txtBuscarTorneo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscarTorneo_MouseClick);
            this.txtBuscarTorneo.TextChanged += new System.EventHandler(this.txtBuscarTorneo_TextChanged);
            // 
            // dgvTorneo
            // 
            this.dgvTorneo.AllowUserToAddRows = false;
            this.dgvTorneo.AllowUserToDeleteRows = false;
            this.dgvTorneo.AllowUserToResizeColumns = false;
            this.dgvTorneo.AllowUserToResizeRows = false;
            this.dgvTorneo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTorneo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTorneo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTorneo.BackgroundColor = System.Drawing.Color.White;
            this.dgvTorneo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTorneo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Onest Bold", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTorneo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTorneo.ColumnHeadersHeight = 40;
            this.dgvTorneo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Onest Bold", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTorneo.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTorneo.EnableHeadersVisualStyles = false;
            this.dgvTorneo.Location = new System.Drawing.Point(150, 295);
            this.dgvTorneo.MultiSelect = false;
            this.dgvTorneo.Name = "dgvTorneo";
            this.dgvTorneo.ReadOnly = true;
            this.dgvTorneo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Onest Bold", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTorneo.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTorneo.RowHeadersVisible = false;
            this.dgvTorneo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.dgvTorneo.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTorneo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTorneo.Size = new System.Drawing.Size(1191, 501);
            this.dgvTorneo.TabIndex = 57;
            this.dgvTorneo.SelectionChanged += new System.EventHandler(this.dgvTorneo_SelectionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::TorneosFut.Properties.Resources.IconoLupa;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(221, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 49);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // btnasistidores
            // 
            this.btnasistidores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnasistidores.Animated = true;
            this.btnasistidores.BorderRadius = 20;
            this.btnasistidores.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnasistidores.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnasistidores.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnasistidores.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnasistidores.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnasistidores.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnasistidores.ForeColor = System.Drawing.Color.White;
            this.btnasistidores.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnasistidores.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnasistidores.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnasistidores.Location = new System.Drawing.Point(1128, 798);
            this.btnasistidores.Name = "btnasistidores";
            this.btnasistidores.Size = new System.Drawing.Size(213, 59);
            this.btnasistidores.TabIndex = 66;
            this.btnasistidores.Text = "ASISTIDORES";
            this.btnasistidores.Visible = false;
            this.btnasistidores.Click += new System.EventHandler(this.btnasistidores_Click);
            // 
            // btngoleadores
            // 
            this.btngoleadores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btngoleadores.Animated = true;
            this.btngoleadores.BorderRadius = 20;
            this.btngoleadores.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngoleadores.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngoleadores.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngoleadores.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngoleadores.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btngoleadores.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngoleadores.ForeColor = System.Drawing.Color.White;
            this.btngoleadores.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.btngoleadores.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btngoleadores.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btngoleadores.Location = new System.Drawing.Point(162, 802);
            this.btngoleadores.Name = "btngoleadores";
            this.btngoleadores.Size = new System.Drawing.Size(192, 55);
            this.btngoleadores.TabIndex = 67;
            this.btngoleadores.Text = "GOLEADORES";
            this.btngoleadores.Visible = false;
            this.btngoleadores.Click += new System.EventHandler(this.btngoleadores_Click);
            // 
            // panelmodul
            // 
            this.panelmodul.BackColor = System.Drawing.Color.White;
            this.panelmodul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmodul.Location = new System.Drawing.Point(0, 100);
            this.panelmodul.Name = "panelmodul";
            this.panelmodul.Size = new System.Drawing.Size(1490, 811);
            this.panelmodul.TabIndex = 68;
            // 
            // Torneo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1490, 911);
            this.ControlBox = false;
            this.Controls.Add(this.panelmodul);
            this.Controls.Add(this.btngoleadores);
            this.Controls.Add(this.btnasistidores);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnPatrocinadores);
            this.Controls.Add(this.btnInscripcionEquipos);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnPartidos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBuscarTorneo);
            this.Controls.Add(this.dgvTorneo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Torneo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Torneo";
            this.Load += new System.EventHandler(this.Torneo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTorneo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJugador;
        private System.Windows.Forms.Button btnOrganizador;
        private System.Windows.Forms.Button btnArbitros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2Button btnCrear;
        private Guna.UI2.WinForms.Guna2Button btnPatrocinadores;
        private Guna.UI2.WinForms.Guna2Button btnInscripcionEquipos;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2Button btnPartidos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscarTorneo;
        public System.Windows.Forms.DataGridView dgvTorneo;
        private System.Windows.Forms.Button btnReglas;
        private Guna.UI2.WinForms.Guna2Button btnasistidores;
        private Guna.UI2.WinForms.Guna2Button btngoleadores;
        public System.Windows.Forms.Panel panelmodul;
    }
}