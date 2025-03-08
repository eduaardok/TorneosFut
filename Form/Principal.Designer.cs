namespace TorneosFut
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tstSuperior = new System.Windows.Forms.ToolStrip();
            this.ddbtnOpcionesU = new System.Windows.Forms.ToolStripDropDownButton();
            this.cAMBIARCLAVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cERRARSESIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnEntrenadores = new System.Windows.Forms.Button();
            this.btnCaja = new System.Windows.Forms.Button();
            this.btnArbitros = new System.Windows.Forms.Button();
            this.btnEstadios = new System.Windows.Forms.Button();
            this.btnPartidos = new System.Windows.Forms.Button();
            this.btnJugadores = new System.Windows.Forms.Button();
            this.btnEquipos = new System.Windows.Forms.Button();
            this.btnTorneos = new System.Windows.Forms.Button();
            this.tmopen = new System.Windows.Forms.Timer(this.components);
            this.timeclose = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelModulos = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tstSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.tstSuperior);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 50);
            this.panel1.TabIndex = 6;
            // 
            // tstSuperior
            // 
            this.tstSuperior.BackColor = System.Drawing.Color.Transparent;
            this.tstSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tstSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddbtnOpcionesU});
            this.tstSuperior.Location = new System.Drawing.Point(60, 0);
            this.tstSuperior.Name = "tstSuperior";
            this.tstSuperior.Size = new System.Drawing.Size(1236, 50);
            this.tstSuperior.TabIndex = 10;
            this.tstSuperior.Text = "toolStrip1";
            // 
            // ddbtnOpcionesU
            // 
            this.ddbtnOpcionesU.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ddbtnOpcionesU.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddbtnOpcionesU.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cAMBIARCLAVEToolStripMenuItem,
            this.cERRARSESIONToolStripMenuItem});
            this.ddbtnOpcionesU.Font = new System.Drawing.Font("Onest Bold", 20F, System.Drawing.FontStyle.Bold);
            this.ddbtnOpcionesU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.ddbtnOpcionesU.Image = ((System.Drawing.Image)(resources.GetObject("ddbtnOpcionesU.Image")));
            this.ddbtnOpcionesU.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbtnOpcionesU.Name = "ddbtnOpcionesU";
            this.ddbtnOpcionesU.Size = new System.Drawing.Size(151, 47);
            this.ddbtnOpcionesU.Text = "USUARIO";
            // 
            // cAMBIARCLAVEToolStripMenuItem
            // 
            this.cAMBIARCLAVEToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cAMBIARCLAVEToolStripMenuItem.Font = new System.Drawing.Font("Onest Bold", 10F, System.Drawing.FontStyle.Bold);
            this.cAMBIARCLAVEToolStripMenuItem.Name = "cAMBIARCLAVEToolStripMenuItem";
            this.cAMBIARCLAVEToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.cAMBIARCLAVEToolStripMenuItem.Text = "CAMBIAR CLAVE";
            this.cAMBIARCLAVEToolStripMenuItem.Click += new System.EventHandler(this.cAMBIARCLAVEToolStripMenuItem_Click);
            // 
            // cERRARSESIONToolStripMenuItem
            // 
            this.cERRARSESIONToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cERRARSESIONToolStripMenuItem.Font = new System.Drawing.Font("Onest Bold", 10F, System.Drawing.FontStyle.Bold);
            this.cERRARSESIONToolStripMenuItem.Name = "cERRARSESIONToolStripMenuItem";
            this.cERRARSESIONToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.cERRARSESIONToolStripMenuItem.Text = "CERRAR SESION";
            this.cERRARSESIONToolStripMenuItem.Click += new System.EventHandler(this.cERRARSESIONToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::TorneosFut.Properties.Resources.userr;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Location = new System.Drawing.Point(1296, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 50);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnCerrar.Location = new System.Drawing.Point(0, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(60, 50);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "-";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.panelOpciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelOpciones.Controls.Add(this.pictureBox1);
            this.panelOpciones.Controls.Add(this.btnUsuarios);
            this.panelOpciones.Controls.Add(this.btnEntrenadores);
            this.panelOpciones.Controls.Add(this.btnCaja);
            this.panelOpciones.Controls.Add(this.btnArbitros);
            this.panelOpciones.Controls.Add(this.btnEstadios);
            this.panelOpciones.Controls.Add(this.btnPartidos);
            this.panelOpciones.Controls.Add(this.btnJugadores);
            this.panelOpciones.Controls.Add(this.btnEquipos);
            this.panelOpciones.Controls.Add(this.btnTorneos);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOpciones.Location = new System.Drawing.Point(0, 50);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(294, 699);
            this.panelOpciones.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::TorneosFut.Properties.Resources.logoFX;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 765);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 0);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.Font = new System.Drawing.Font("Onest Bold", 20F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 680);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(294, 85);
            this.btnUsuarios.TabIndex = 11;
            this.btnUsuarios.Text = "USUARIOS";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            this.btnUsuarios.MouseEnter += new System.EventHandler(this.btnUsuarios_MouseEnter);
            this.btnUsuarios.MouseLeave += new System.EventHandler(this.btnUsuarios_MouseLeave);
            // 
            // btnEntrenadores
            // 
            this.btnEntrenadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnEntrenadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntrenadores.Font = new System.Drawing.Font("Onest Bold", 20F, System.Drawing.FontStyle.Bold);
            this.btnEntrenadores.ForeColor = System.Drawing.Color.White;
            this.btnEntrenadores.Location = new System.Drawing.Point(0, 595);
            this.btnEntrenadores.Name = "btnEntrenadores";
            this.btnEntrenadores.Size = new System.Drawing.Size(294, 85);
            this.btnEntrenadores.TabIndex = 9;
            this.btnEntrenadores.Text = "ENTRENADORES";
            this.btnEntrenadores.UseVisualStyleBackColor = false;
            this.btnEntrenadores.Click += new System.EventHandler(this.btnEntrenadores_Click);
            this.btnEntrenadores.MouseEnter += new System.EventHandler(this.btnEntrenadores_MouseEnter);
            this.btnEntrenadores.MouseLeave += new System.EventHandler(this.btnEntrenadores_MouseLeave);
            // 
            // btnCaja
            // 
            this.btnCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnCaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaja.Font = new System.Drawing.Font("Onest Bold", 20F, System.Drawing.FontStyle.Bold);
            this.btnCaja.ForeColor = System.Drawing.Color.White;
            this.btnCaja.Location = new System.Drawing.Point(0, 510);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(294, 85);
            this.btnCaja.TabIndex = 6;
            this.btnCaja.Text = "CAJA";
            this.btnCaja.UseVisualStyleBackColor = false;
            this.btnCaja.MouseEnter += new System.EventHandler(this.btnCaja_MouseEnter);
            this.btnCaja.MouseLeave += new System.EventHandler(this.btnCaja_MouseLeave);
            // 
            // btnArbitros
            // 
            this.btnArbitros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnArbitros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArbitros.Font = new System.Drawing.Font("Onest Bold", 20F, System.Drawing.FontStyle.Bold);
            this.btnArbitros.ForeColor = System.Drawing.Color.White;
            this.btnArbitros.Location = new System.Drawing.Point(0, 425);
            this.btnArbitros.Name = "btnArbitros";
            this.btnArbitros.Size = new System.Drawing.Size(294, 85);
            this.btnArbitros.TabIndex = 5;
            this.btnArbitros.Text = "ÁRBITROS";
            this.btnArbitros.UseVisualStyleBackColor = false;
            this.btnArbitros.MouseEnter += new System.EventHandler(this.btnArbitros_MouseEnter);
            this.btnArbitros.MouseLeave += new System.EventHandler(this.btnArbitros_MouseLeave);
            // 
            // btnEstadios
            // 
            this.btnEstadios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnEstadios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstadios.Font = new System.Drawing.Font("Onest Bold", 20F, System.Drawing.FontStyle.Bold);
            this.btnEstadios.ForeColor = System.Drawing.Color.White;
            this.btnEstadios.Location = new System.Drawing.Point(0, 340);
            this.btnEstadios.Name = "btnEstadios";
            this.btnEstadios.Size = new System.Drawing.Size(294, 85);
            this.btnEstadios.TabIndex = 4;
            this.btnEstadios.Text = "ESTADIOS";
            this.btnEstadios.UseVisualStyleBackColor = false;
            this.btnEstadios.MouseEnter += new System.EventHandler(this.btnEstadios_MouseEnter);
            this.btnEstadios.MouseLeave += new System.EventHandler(this.btnEstadios_MouseLeave);
            // 
            // btnPartidos
            // 
            this.btnPartidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnPartidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPartidos.Font = new System.Drawing.Font("Onest Bold", 20F, System.Drawing.FontStyle.Bold);
            this.btnPartidos.ForeColor = System.Drawing.Color.White;
            this.btnPartidos.Location = new System.Drawing.Point(0, 255);
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.Size = new System.Drawing.Size(294, 85);
            this.btnPartidos.TabIndex = 3;
            this.btnPartidos.Text = "PARTIDOS";
            this.btnPartidos.UseVisualStyleBackColor = false;
            this.btnPartidos.MouseEnter += new System.EventHandler(this.btnPartidos_MouseEnter);
            this.btnPartidos.MouseLeave += new System.EventHandler(this.btnPartidos_MouseLeave);
            // 
            // btnJugadores
            // 
            this.btnJugadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnJugadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJugadores.Font = new System.Drawing.Font("Onest Bold", 20F, System.Drawing.FontStyle.Bold);
            this.btnJugadores.ForeColor = System.Drawing.Color.White;
            this.btnJugadores.Location = new System.Drawing.Point(0, 170);
            this.btnJugadores.Name = "btnJugadores";
            this.btnJugadores.Size = new System.Drawing.Size(294, 85);
            this.btnJugadores.TabIndex = 2;
            this.btnJugadores.Text = "JUGADORES";
            this.btnJugadores.UseVisualStyleBackColor = false;
            this.btnJugadores.Click += new System.EventHandler(this.btnJugadores_Click);
            this.btnJugadores.MouseEnter += new System.EventHandler(this.btnJugadores_MouseEnter);
            this.btnJugadores.MouseLeave += new System.EventHandler(this.btnJugadores_MouseLeave);
            // 
            // btnEquipos
            // 
            this.btnEquipos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnEquipos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEquipos.Font = new System.Drawing.Font("Onest Bold", 20F, System.Drawing.FontStyle.Bold);
            this.btnEquipos.ForeColor = System.Drawing.Color.White;
            this.btnEquipos.Location = new System.Drawing.Point(0, 85);
            this.btnEquipos.Name = "btnEquipos";
            this.btnEquipos.Size = new System.Drawing.Size(294, 85);
            this.btnEquipos.TabIndex = 1;
            this.btnEquipos.Text = "EQUIPOS";
            this.btnEquipos.UseVisualStyleBackColor = false;
            this.btnEquipos.Click += new System.EventHandler(this.btnEquipos_Click);
            this.btnEquipos.MouseEnter += new System.EventHandler(this.btnEquipos_MouseEnter);
            this.btnEquipos.MouseLeave += new System.EventHandler(this.btnEquipos_MouseLeave);
            // 
            // btnTorneos
            // 
            this.btnTorneos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnTorneos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTorneos.Font = new System.Drawing.Font("Onest Bold", 20F, System.Drawing.FontStyle.Bold);
            this.btnTorneos.ForeColor = System.Drawing.Color.White;
            this.btnTorneos.Location = new System.Drawing.Point(0, 0);
            this.btnTorneos.Name = "btnTorneos";
            this.btnTorneos.Size = new System.Drawing.Size(294, 85);
            this.btnTorneos.TabIndex = 0;
            this.btnTorneos.Text = " TORNEOS";
            this.btnTorneos.UseVisualStyleBackColor = false;
            this.btnTorneos.Click += new System.EventHandler(this.btnTorneos_Click);
            this.btnTorneos.MouseEnter += new System.EventHandler(this.btnTorneos_MouseEnter);
            this.btnTorneos.MouseLeave += new System.EventHandler(this.btnTorneos_MouseLeave);
            // 
            // tmopen
            // 
            this.tmopen.Interval = 1;
            this.tmopen.Tick += new System.EventHandler(this.tmopen_Tick);
            // 
            // timeclose
            // 
            this.timeclose.Interval = 1;
            this.timeclose.Tick += new System.EventHandler(this.timeclose_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelModulos
            // 
            this.panelModulos.BackColor = System.Drawing.Color.White;
            this.panelModulos.BackgroundImage = global::TorneosFut.Properties.Resources.fxfutxpert;
            this.panelModulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelModulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelModulos.Location = new System.Drawing.Point(294, 50);
            this.panelModulos.Name = "panelModulos";
            this.panelModulos.Size = new System.Drawing.Size(1076, 699);
            this.panelModulos.TabIndex = 9;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panelModulos);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Onest Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Principal";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FUTXPERT";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Resize += new System.EventHandler(this.Principal_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tstSuperior.ResumeLayout(false);
            this.tstSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Button btnArbitros;
        private System.Windows.Forms.Button btnEstadios;
        private System.Windows.Forms.Button btnPartidos;
        private System.Windows.Forms.Button btnJugadores;
        private System.Windows.Forms.Button btnEquipos;
        private System.Windows.Forms.Button btnTorneos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelModulos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnEntrenadores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmopen;
        private System.Windows.Forms.Timer timeclose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip tstSuperior;
        private System.Windows.Forms.ToolStripDropDownButton ddbtnOpcionesU;
        private System.Windows.Forms.ToolStripMenuItem cAMBIARCLAVEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cERRARSESIONToolStripMenuItem;
    }
}