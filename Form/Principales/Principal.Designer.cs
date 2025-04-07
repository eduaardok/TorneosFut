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
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnCorreos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAuditorias = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnEquipos = new System.Windows.Forms.Button();
            this.btnTorneos = new System.Windows.Forms.Button();
            this.tmopen = new System.Windows.Forms.Timer(this.components);
            this.timeclose = new System.Windows.Forms.Timer(this.components);
            this.btnCerrar = new System.Windows.Forms.Button();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tstSuperior = new System.Windows.Forms.ToolStrip();
            this.ddbtnOpcionesU = new System.Windows.Forms.ToolStripDropDownButton();
            this.ttmiCambiarClave = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmiCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelModulos = new System.Windows.Forms.Panel();
            this.panelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tstSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.panelOpciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelOpciones.Controls.Add(this.btnCorreos);
            this.panelOpciones.Controls.Add(this.button3);
            this.panelOpciones.Controls.Add(this.pictureBox1);
            this.panelOpciones.Controls.Add(this.btnAuditorias);
            this.panelOpciones.Controls.Add(this.btnUsuarios);
            this.panelOpciones.Controls.Add(this.btnEquipos);
            this.panelOpciones.Controls.Add(this.btnTorneos);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOpciones.Location = new System.Drawing.Point(0, 50);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(294, 618);
            this.panelOpciones.TabIndex = 8;
            // 
            // btnCorreos
            // 
            this.btnCorreos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnCorreos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCorreos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorreos.ForeColor = System.Drawing.Color.White;
            this.btnCorreos.Image = global::TorneosFut.Properties.Resources.gmail_icon_icons_com_59877__1_;
            this.btnCorreos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCorreos.Location = new System.Drawing.Point(0, 407);
            this.btnCorreos.Name = "btnCorreos";
            this.btnCorreos.Size = new System.Drawing.Size(294, 79);
            this.btnCorreos.TabIndex = 16;
            this.btnCorreos.Text = "CORREOS";
            this.btnCorreos.UseVisualStyleBackColor = false;
            this.btnCorreos.Click += new System.EventHandler(this.btnCorreos_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::TorneosFut.Properties.Resources.icons8_patrocinador_50;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(294, 79);
            this.button3.TabIndex = 15;
            this.button3.Text = "GESTIÓN FINANCIERA";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::TorneosFut.Properties.Resources.logoFX;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 334);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 284);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnAuditorias
            // 
            this.btnAuditorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnAuditorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAuditorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuditorias.ForeColor = System.Drawing.Color.White;
            this.btnAuditorias.Image = global::TorneosFut.Properties.Resources.icons8_audit_50;
            this.btnAuditorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuditorias.Location = new System.Drawing.Point(0, 249);
            this.btnAuditorias.Name = "btnAuditorias";
            this.btnAuditorias.Size = new System.Drawing.Size(294, 79);
            this.btnAuditorias.TabIndex = 13;
            this.btnAuditorias.Text = "AUDITORIAS";
            this.btnAuditorias.UseVisualStyleBackColor = false;
            this.btnAuditorias.Click += new System.EventHandler(this.button3_Click);
            this.btnAuditorias.MouseEnter += new System.EventHandler(this.btnAuditorias_MouseEnter);
            this.btnAuditorias.MouseLeave += new System.EventHandler(this.btnAuditorias_MouseLeave);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = global::TorneosFut.Properties.Resources.icons8_usuario_50;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 170);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(294, 79);
            this.btnUsuarios.TabIndex = 11;
            this.btnUsuarios.Text = "USUARIOS";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            this.btnUsuarios.MouseEnter += new System.EventHandler(this.btnUsuarios_MouseEnter);
            this.btnUsuarios.MouseLeave += new System.EventHandler(this.btnUsuarios_MouseLeave);
            // 
            // btnEquipos
            // 
            this.btnEquipos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnEquipos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipos.ForeColor = System.Drawing.Color.White;
            this.btnEquipos.Image = global::TorneosFut.Properties.Resources.icons8_llamada_de_conferencia_64;
            this.btnEquipos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnTorneos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTorneos.ForeColor = System.Drawing.Color.White;
            this.btnTorneos.Image = global::TorneosFut.Properties.Resources.icons8_trofeo_50;
            this.btnTorneos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(9, 15);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(1199, 50);
            this.miniToolStrip.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tstSuperior);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1330, 50);
            this.panel1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = global::TorneosFut.Properties.Resources.icons8_cucha_50;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.button2.Location = new System.Drawing.Point(120, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 50);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::TorneosFut.Properties.Resources.icons8_luna_creciente_50__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(60, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 50);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tstSuperior
            // 
            this.tstSuperior.BackColor = System.Drawing.Color.Transparent;
            this.tstSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tstSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddbtnOpcionesU});
            this.tstSuperior.Location = new System.Drawing.Point(60, 0);
            this.tstSuperior.Name = "tstSuperior";
            this.tstSuperior.Size = new System.Drawing.Size(1196, 50);
            this.tstSuperior.TabIndex = 10;
            this.tstSuperior.Text = "toolStrip1";
            // 
            // ddbtnOpcionesU
            // 
            this.ddbtnOpcionesU.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ddbtnOpcionesU.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddbtnOpcionesU.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttmiCambiarClave,
            this.ttmiCerrarSesion});
            this.ddbtnOpcionesU.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.ddbtnOpcionesU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.ddbtnOpcionesU.Image = ((System.Drawing.Image)(resources.GetObject("ddbtnOpcionesU.Image")));
            this.ddbtnOpcionesU.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbtnOpcionesU.Name = "ddbtnOpcionesU";
            this.ddbtnOpcionesU.Size = new System.Drawing.Size(159, 47);
            this.ddbtnOpcionesU.Text = "USUARIO";
            // 
            // ttmiCambiarClave
            // 
            this.ttmiCambiarClave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ttmiCambiarClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ttmiCambiarClave.Name = "ttmiCambiarClave";
            this.ttmiCambiarClave.Size = new System.Drawing.Size(207, 22);
            this.ttmiCambiarClave.Text = "CAMBIAR CLAVE";
            this.ttmiCambiarClave.Click += new System.EventHandler(this.ttmiCambiarClave_Click);
            // 
            // ttmiCerrarSesion
            // 
            this.ttmiCerrarSesion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ttmiCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ttmiCerrarSesion.Name = "ttmiCerrarSesion";
            this.ttmiCerrarSesion.Size = new System.Drawing.Size(207, 22);
            this.ttmiCerrarSesion.Text = "CERRAR SESION";
            this.ttmiCerrarSesion.Click += new System.EventHandler(this.ttmiCerrarSesion_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::TorneosFut.Properties.Resources.userr;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Location = new System.Drawing.Point(1256, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 50);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
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
            this.panelModulos.Size = new System.Drawing.Size(1036, 618);
            this.panelModulos.TabIndex = 9;
            this.panelModulos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelModulos_Paint);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1330, 668);
            this.Controls.Add(this.panelModulos);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Principal";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FUTXPERT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Resize += new System.EventHandler(this.Principal_Resize);
            this.panelOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tstSuperior.ResumeLayout(false);
            this.tstSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Button btnTorneos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Timer tmopen;
        private System.Windows.Forms.Timer timeclose;
        private System.Windows.Forms.Button btnEquipos;
        private System.Windows.Forms.Button btnAuditorias;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.ToolStripDropDownButton ddbtnOpcionesU;
        private System.Windows.Forms.ToolStripMenuItem ttmiCambiarClave;
        private System.Windows.Forms.ToolStripMenuItem ttmiCerrarSesion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip tstSuperior;
        private System.Windows.Forms.Panel panelModulos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCorreos;
    }
}