namespace TorneosFut
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.guna2NotificationPaint1 = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.llblRecuperarClave = new System.Windows.Forms.LinkLabel();
            this.Ptbhide = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtclave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptbhide)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.llblRecuperarClave);
            this.panel1.Controls.Add(this.Ptbhide);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Txtclave);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnEntrar);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Location = new System.Drawing.Point(306, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 678);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Onest Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 34);
            this.label1.TabIndex = 29;
            this.label1.Text = "INICIAR SESIÓN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::TorneosFut.Properties.Resources.logoFXblanco;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(37, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 296);
            this.panel2.TabIndex = 28;
            // 
            // llblRecuperarClave
            // 
            this.llblRecuperarClave.AutoSize = true;
            this.llblRecuperarClave.BackColor = System.Drawing.Color.Transparent;
            this.llblRecuperarClave.Font = new System.Drawing.Font("Onest Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblRecuperarClave.ForeColor = System.Drawing.Color.Black;
            this.llblRecuperarClave.LinkColor = System.Drawing.Color.Silver;
            this.llblRecuperarClave.Location = new System.Drawing.Point(123, 507);
            this.llblRecuperarClave.Name = "llblRecuperarClave";
            this.llblRecuperarClave.Size = new System.Drawing.Size(122, 17);
            this.llblRecuperarClave.TabIndex = 27;
            this.llblRecuperarClave.TabStop = true;
            this.llblRecuperarClave.Text = "Recuperar contraseña";
            this.llblRecuperarClave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRecuperarClave_LinkClicked);
            // 
            // Ptbhide
            // 
            this.Ptbhide.BackColor = System.Drawing.Color.Transparent;
            this.Ptbhide.BackgroundImage = global::TorneosFut.Properties.Resources.hide1;
            this.Ptbhide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Ptbhide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ptbhide.Location = new System.Drawing.Point(307, 423);
            this.Ptbhide.Name = "Ptbhide";
            this.Ptbhide.Size = new System.Drawing.Size(21, 22);
            this.Ptbhide.TabIndex = 26;
            this.Ptbhide.TabStop = false;
            this.Ptbhide.Click += new System.EventHandler(this.Ptbhide_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::TorneosFut.Properties.Resources.key__1_;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(63, 409);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(38, 36);
            this.panel4.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::TorneosFut.Properties.Resources.userr;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(63, 342);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(38, 36);
            this.panel3.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(133, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 28);
            this.label4.TabIndex = 23;
            this.label4.Text = "Contraseña";
            this.label4.Visible = false;
            // 
            // Txtclave
            // 
            this.Txtclave.BackColor = System.Drawing.Color.Black;
            this.Txtclave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtclave.Font = new System.Drawing.Font("Onest Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtclave.ForeColor = System.Drawing.Color.White;
            this.Txtclave.Location = new System.Drawing.Point(107, 423);
            this.Txtclave.Multiline = true;
            this.Txtclave.Name = "Txtclave";
            this.Txtclave.PasswordChar = '*';
            this.Txtclave.Size = new System.Drawing.Size(196, 22);
            this.Txtclave.TabIndex = 22;
            this.Txtclave.Text = "             Contraseña";
            this.Txtclave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txtclave_MouseClick);
            this.Txtclave.TextChanged += new System.EventHandler(this.Txtclave_TextChanged);
            this.Txtclave.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtclave_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(147, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "Usuario";
            this.label3.Visible = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Red;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(63, 466);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(265, 38);
            this.btnEntrar.TabIndex = 18;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Black;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Onest Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(107, 355);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(196, 23);
            this.txtUsuario.TabIndex = 19;
            this.txtUsuario.Text = "              Usuario";
            this.txtUsuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUsuario_MouseClick);
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyUp);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Onest Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCerrar.Location = new System.Drawing.Point(-9, -13);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(60, 59);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TorneosFut.Properties.Resources.futxpert_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 698);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Login";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN FUTXPERT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptbhide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Guna.UI2.WinForms.Guna2NotificationPaint guna2NotificationPaint1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llblRecuperarClave;
        private System.Windows.Forms.PictureBox Ptbhide;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txtclave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
    }
}

