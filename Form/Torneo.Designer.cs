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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnArbitros = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnJugador = new System.Windows.Forms.Button();
            this.btnOrganizador = new System.Windows.Forms.Button();
            this.btnCrear = new Guna.UI2.WinForms.Guna2Button();
            this.btnPatrocinadores = new Guna.UI2.WinForms.Guna2Button();
            this.btnEquipos = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.btnPartidos = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscarTorneo = new System.Windows.Forms.TextBox();
            this.dgvOrganizador = new System.Windows.Forms.DataGridView();
            this.panelmodul = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnArbitros
            // 
            this.btnArbitros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnArbitros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArbitros.Font = new System.Drawing.Font("Onest Bold", 20F, System.Drawing.FontStyle.Bold);
            this.btnArbitros.ForeColor = System.Drawing.Color.White;
            this.btnArbitros.Location = new System.Drawing.Point(651, 3);
            this.btnArbitros.Name = "btnArbitros";
            this.btnArbitros.Size = new System.Drawing.Size(294, 85);
            this.btnArbitros.TabIndex = 6;
            this.btnArbitros.Text = "ÁRBITROS";
            this.btnArbitros.UseVisualStyleBackColor = false;
            this.btnArbitros.Click += new System.EventHandler(this.btnArbitros_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Onest Bold", 20F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(21, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 85);
            this.button1.TabIndex = 7;
            this.button1.Text = "<--";
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
            this.btnJugador.Location = new System.Drawing.Point(312, 3);
            this.btnJugador.Name = "btnJugador";
            this.btnJugador.Size = new System.Drawing.Size(319, 85);
            this.btnJugador.TabIndex = 3;
            this.btnJugador.Text = "PATROCINADORES";
            this.btnJugador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnJugador.UseVisualStyleBackColor = false;
            this.btnJugador.Click += new System.EventHandler(this.btnJugadores_Click);
            // 
            // btnOrganizador
            // 
            this.btnOrganizador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnOrganizador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrganizador.Font = new System.Drawing.Font("Onest Bold", 20F, System.Drawing.FontStyle.Bold);
            this.btnOrganizador.ForeColor = System.Drawing.Color.White;
            this.btnOrganizador.Image = global::TorneosFut.Properties.Resources.icons8_organizador_80;
            this.btnOrganizador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrganizador.Location = new System.Drawing.Point(966, 3);
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
            this.btnCrear.BackColor = System.Drawing.Color.White;
            this.btnCrear.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCrear.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnCrear.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnCrear.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnCrear.CustomBorderColor = System.Drawing.Color.White;
            this.btnCrear.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnCrear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCrear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCrear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCrear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCrear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnCrear.Font = new System.Drawing.Font("Onest Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.Black;
            this.btnCrear.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnCrear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnCrear.Location = new System.Drawing.Point(357, 211);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(180, 59);
            this.btnCrear.TabIndex = 64;
            this.btnCrear.Text = "CREAR TORNEO";
            // 
            // btnPatrocinadores
            // 
            this.btnPatrocinadores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPatrocinadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnPatrocinadores.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPatrocinadores.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnPatrocinadores.CheckedState.FillColor = System.Drawing.Color.Black;
            this.btnPatrocinadores.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnPatrocinadores.CustomBorderColor = System.Drawing.Color.White;
            this.btnPatrocinadores.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnPatrocinadores.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPatrocinadores.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPatrocinadores.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPatrocinadores.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPatrocinadores.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnPatrocinadores.Font = new System.Drawing.Font("Onest Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatrocinadores.ForeColor = System.Drawing.Color.White;
            this.btnPatrocinadores.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnPatrocinadores.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnPatrocinadores.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnPatrocinadores.Location = new System.Drawing.Point(942, 211);
            this.btnPatrocinadores.Name = "btnPatrocinadores";
            this.btnPatrocinadores.Size = new System.Drawing.Size(180, 59);
            this.btnPatrocinadores.TabIndex = 63;
            this.btnPatrocinadores.Text = "ASIGNAR PATROCINADORES";
            // 
            // btnEquipos
            // 
            this.btnEquipos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEquipos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnEquipos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEquipos.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnEquipos.CheckedState.FillColor = System.Drawing.Color.Black;
            this.btnEquipos.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnEquipos.CustomBorderColor = System.Drawing.Color.White;
            this.btnEquipos.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnEquipos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEquipos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEquipos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEquipos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEquipos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnEquipos.Font = new System.Drawing.Font("Onest Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipos.ForeColor = System.Drawing.Color.White;
            this.btnEquipos.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnEquipos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnEquipos.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnEquipos.Location = new System.Drawing.Point(730, 211);
            this.btnEquipos.Name = "btnEquipos";
            this.btnEquipos.Size = new System.Drawing.Size(180, 59);
            this.btnEquipos.TabIndex = 62;
            this.btnEquipos.Text = "INSCRIBIR EQUIPOS";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEditar.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnEditar.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnEditar.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnEditar.CustomBorderColor = System.Drawing.Color.White;
            this.btnEditar.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnEditar.Font = new System.Drawing.Font("Onest Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnEditar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnEditar.Location = new System.Drawing.Point(150, 211);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(180, 59);
            this.btnEditar.TabIndex = 61;
            this.btnEditar.Text = "EDITAR TORNEO";
            // 
            // btnPartidos
            // 
            this.btnPartidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPartidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnPartidos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPartidos.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnPartidos.CheckedState.FillColor = System.Drawing.Color.Black;
            this.btnPartidos.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnPartidos.CustomBorderColor = System.Drawing.Color.White;
            this.btnPartidos.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnPartidos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPartidos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPartidos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPartidos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPartidos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnPartidos.Font = new System.Drawing.Font("Onest Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartidos.ForeColor = System.Drawing.Color.White;
            this.btnPartidos.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnPartidos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnPartidos.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnPartidos.Location = new System.Drawing.Point(1161, 211);
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.Size = new System.Drawing.Size(180, 59);
            this.btnPartidos.TabIndex = 60;
            this.btnPartidos.Text = "GESTIONAR PARTIDOS";
            this.btnPartidos.Click += new System.EventHandler(this.btnPartidos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::TorneosFut.Properties.Resources.IconoLupa;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(152, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 49);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // txtBuscarTorneo
            // 
            this.txtBuscarTorneo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarTorneo.Font = new System.Drawing.Font("Onest Light", 20F);
            this.txtBuscarTorneo.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscarTorneo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBuscarTorneo.Location = new System.Drawing.Point(313, 107);
            this.txtBuscarTorneo.Multiline = true;
            this.txtBuscarTorneo.Name = "txtBuscarTorneo";
            this.txtBuscarTorneo.Size = new System.Drawing.Size(633, 48);
            this.txtBuscarTorneo.TabIndex = 58;
            this.txtBuscarTorneo.Text = "Buscar por nombre del Torneo";
            // 
            // dgvOrganizador
            // 
            this.dgvOrganizador.AllowUserToAddRows = false;
            this.dgvOrganizador.AllowUserToDeleteRows = false;
            this.dgvOrganizador.AllowUserToResizeColumns = false;
            this.dgvOrganizador.AllowUserToResizeRows = false;
            this.dgvOrganizador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvOrganizador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrganizador.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Onest Bold", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrganizador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvOrganizador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Onest Bold", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrganizador.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvOrganizador.EnableHeadersVisualStyles = false;
            this.dgvOrganizador.Location = new System.Drawing.Point(152, 304);
            this.dgvOrganizador.Name = "dgvOrganizador";
            this.dgvOrganizador.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Onest Bold", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrganizador.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvOrganizador.RowHeadersVisible = false;
            this.dgvOrganizador.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOrganizador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrganizador.Size = new System.Drawing.Size(1189, 501);
            this.dgvOrganizador.TabIndex = 57;
            // 
            // panelmodul
            // 
            this.panelmodul.BackColor = System.Drawing.Color.White;
            this.panelmodul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmodul.Location = new System.Drawing.Point(0, 100);
            this.panelmodul.Name = "panelmodul";
            this.panelmodul.Size = new System.Drawing.Size(1490, 811);
            this.panelmodul.TabIndex = 65;
            // 
            // Torneo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1490, 911);
            this.ControlBox = false;
            this.Controls.Add(this.panelmodul);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnPatrocinadores);
            this.Controls.Add(this.btnEquipos);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnPartidos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBuscarTorneo);
            this.Controls.Add(this.dgvOrganizador);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizador)).EndInit();
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
        private Guna.UI2.WinForms.Guna2Button btnEquipos;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2Button btnPartidos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscarTorneo;
        public System.Windows.Forms.DataGridView dgvOrganizador;
        public System.Windows.Forms.Panel panelmodul;
    }
}