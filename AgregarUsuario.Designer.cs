namespace agregarUsuario
{
    partial class AgregarUsuario
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCorreos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(104, 558);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(218, 59);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(795, 558);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(218, 59);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(341, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "AGREGAR NUEVO USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.label2.Location = new System.Drawing.Point(96, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(104, 183);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(386, 40);
            this.txtNombre.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(104, 319);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(386, 40);
            this.txtUsuario.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.label3.Location = new System.Drawing.Point(96, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre de usuario:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(104, 450);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(386, 40);
            this.txtCorreo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.label4.Location = new System.Drawing.Point(96, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "Correo:";
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(627, 319);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(386, 40);
            this.txtClave.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.label5.Location = new System.Drawing.Point(619, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "Clave:";
            // 
            // cmbCorreos
            // 
            this.cmbCorreos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCorreos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.cmbCorreos.FormattingEnabled = true;
            this.cmbCorreos.Items.AddRange(new object[] {
            "@gmail.com",
            "@outlook.com",
            "@yahoo.com",
            "@hotmail.com"});
            this.cmbCorreos.Location = new System.Drawing.Point(627, 441);
            this.cmbCorreos.Name = "cmbCorreos";
            this.cmbCorreos.Size = new System.Drawing.Size(386, 41);
            this.cmbCorreos.TabIndex = 14;
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1115, 672);
            this.Controls.Add(this.cmbCorreos);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AgregarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCorreos;
    }
}

