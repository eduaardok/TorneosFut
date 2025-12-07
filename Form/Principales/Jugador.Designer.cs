namespace pruebas
{
    partial class Jugador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregarJugador = new Guna.UI2.WinForms.Guna2Button();
            this.panelDgv = new System.Windows.Forms.Panel();
            this.dgvJugador = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscarJugador = new System.Windows.Forms.TextBox();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.btnEstadistica = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.panelDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(353, 196);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(214, 59);
            this.guna2Button1.TabIndex = 11;
            this.guna2Button1.Text = "EDITAR JUGADOR";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnAgregarJugador
            // 
            this.btnAgregarJugador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarJugador.Animated = true;
            this.btnAgregarJugador.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarJugador.BorderRadius = 20;
            this.btnAgregarJugador.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAgregarJugador.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarJugador.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarJugador.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarJugador.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarJugador.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnAgregarJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarJugador.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarJugador.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarJugador.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnAgregarJugador.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarJugador.Location = new System.Drawing.Point(109, 196);
            this.btnAgregarJugador.Name = "btnAgregarJugador";
            this.btnAgregarJugador.Size = new System.Drawing.Size(222, 59);
            this.btnAgregarJugador.TabIndex = 12;
            this.btnAgregarJugador.Text = "AGREGAR JUGADOR";
            this.btnAgregarJugador.Click += new System.EventHandler(this.btnAgregarJugador_Click);
            // 
            // panelDgv
            // 
            this.panelDgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelDgv.Controls.Add(this.dgvJugador);
            this.panelDgv.Location = new System.Drawing.Point(109, 261);
            this.panelDgv.Name = "panelDgv";
            this.panelDgv.Size = new System.Drawing.Size(1186, 601);
            this.panelDgv.TabIndex = 13;
            // 
            // dgvJugador
            // 
            this.dgvJugador.AllowUserToAddRows = false;
            this.dgvJugador.AllowUserToDeleteRows = false;
            this.dgvJugador.AllowUserToResizeColumns = false;
            this.dgvJugador.AllowUserToResizeRows = false;
            this.dgvJugador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJugador.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvJugador.BackgroundColor = System.Drawing.Color.White;
            this.dgvJugador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJugador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvJugador.ColumnHeadersHeight = 40;
            this.dgvJugador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvJugador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJugador.EnableHeadersVisualStyles = false;
            this.dgvJugador.Location = new System.Drawing.Point(0, 0);
            this.dgvJugador.MultiSelect = false;
            this.dgvJugador.Name = "dgvJugador";
            this.dgvJugador.ReadOnly = true;
            this.dgvJugador.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvJugador.RowHeadersVisible = false;
            this.dgvJugador.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.dgvJugador.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvJugador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJugador.ShowCellToolTips = false;
            this.dgvJugador.ShowEditingIcon = false;
            this.dgvJugador.Size = new System.Drawing.Size(1186, 601);
            this.dgvJugador.TabIndex = 5;
            this.dgvJugador.SelectionChanged += new System.EventHandler(this.dgvJugador_SelectionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::TorneosFut.Properties.Resources.IconoLupa;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(65, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 49);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txtBuscarJugador
            // 
            this.txtBuscarJugador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtBuscarJugador.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscarJugador.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBuscarJugador.Location = new System.Drawing.Point(121, 115);
            this.txtBuscarJugador.Multiline = true;
            this.txtBuscarJugador.Name = "txtBuscarJugador";
            this.txtBuscarJugador.Size = new System.Drawing.Size(841, 48);
            this.txtBuscarJugador.TabIndex = 14;
            this.txtBuscarJugador.Text = "Buscar por nombre del Jugador";
            this.txtBuscarJugador.Click += new System.EventHandler(this.txtBuscarJugador_Click);
            this.txtBuscarJugador.TextChanged += new System.EventHandler(this.txtBuscarJugador_TextChanged);
            this.txtBuscarJugador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarMisEquipos_KeyUp);
            // 
            // ptbImagen
            // 
            this.ptbImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbImagen.Location = new System.Drawing.Point(1077, 106);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(173, 149);
            this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagen.TabIndex = 16;
            this.ptbImagen.TabStop = false;
            // 
            // btnEstadistica
            // 
            this.btnEstadistica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEstadistica.Animated = true;
            this.btnEstadistica.BackColor = System.Drawing.Color.Transparent;
            this.btnEstadistica.BorderRadius = 20;
            this.btnEstadistica.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEstadistica.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEstadistica.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEstadistica.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEstadistica.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnEstadistica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadistica.ForeColor = System.Drawing.Color.White;
            this.btnEstadistica.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnEstadistica.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnEstadistica.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnEstadistica.Location = new System.Drawing.Point(693, 196);
            this.btnEstadistica.Name = "btnEstadistica";
            this.btnEstadistica.Size = new System.Drawing.Size(214, 59);
            this.btnEstadistica.TabIndex = 17;
            this.btnEstadistica.Text = "ESTADISTICAS";
            this.btnEstadistica.Click += new System.EventHandler(this.btnEstadistica_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Lista de Jugadores";
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblBusqueda.Location = new System.Drawing.Point(118, 94);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(81, 18);
            this.lblBusqueda.TabIndex = 24;
            this.lblBusqueda.Text = "BUSCAR:";
            // 
            // Jugador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1414, 920);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEstadistica);
            this.Controls.Add(this.ptbImagen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBuscarJugador);
            this.Controls.Add(this.panelDgv);
            this.Controls.Add(this.btnAgregarJugador);
            this.Controls.Add(this.guna2Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Jugador";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "VerJugadores";
            this.Load += new System.EventHandler(this.VerJugadores_Load);
            this.panelDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnAgregarJugador;
        private System.Windows.Forms.Panel panelDgv;
        public System.Windows.Forms.DataGridView dgvJugador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscarJugador;
        private System.Windows.Forms.PictureBox ptbImagen;
        private Guna.UI2.WinForms.Guna2Button btnEstadistica;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblBusqueda;
    }
}