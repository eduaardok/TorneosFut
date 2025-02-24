namespace TorneosFut
{
    partial class FrmEditarCorreo
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCambiarCorreo = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblEditarCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.cmbCorreos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(38, 231);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 55);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "SALIR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCambiarCorreo
            // 
            this.btnCambiarCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarCorreo.Location = new System.Drawing.Point(358, 231);
            this.btnCambiarCorreo.Name = "btnCambiarCorreo";
            this.btnCambiarCorreo.Size = new System.Drawing.Size(140, 55);
            this.btnCambiarCorreo.TabIndex = 10;
            this.btnCambiarCorreo.Text = "CONFIRMAR";
            this.btnCambiarCorreo.UseVisualStyleBackColor = true;
            this.btnCambiarCorreo.Click += new System.EventHandler(this.btnCambiarCorreo_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(34, 39);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(79, 24);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "usuario";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(34, 15);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(196, 24);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "Editando correo de:";
            // 
            // lblEditarCorreo
            // 
            this.lblEditarCorreo.AutoSize = true;
            this.lblEditarCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarCorreo.Location = new System.Drawing.Point(34, 109);
            this.lblEditarCorreo.Name = "lblEditarCorreo";
            this.lblEditarCorreo.Size = new System.Drawing.Size(80, 24);
            this.lblEditarCorreo.TabIndex = 7;
            this.lblEditarCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(38, 146);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(237, 29);
            this.txtCorreo.TabIndex = 6;
            // 
            // cmbCorreos
            // 
            this.cmbCorreos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCorreos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cmbCorreos.FormattingEnabled = true;
            this.cmbCorreos.Items.AddRange(new object[] {
            "@gmail.com",
            "@outlook.com",
            "@yahoo.com",
            "@hotmail.com"});
            this.cmbCorreos.Location = new System.Drawing.Point(299, 146);
            this.cmbCorreos.Name = "cmbCorreos";
            this.cmbCorreos.Size = new System.Drawing.Size(199, 32);
            this.cmbCorreos.TabIndex = 13;
            this.cmbCorreos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // EditarCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 301);
            this.Controls.Add(this.cmbCorreos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCambiarCorreo);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblEditarCorreo);
            this.Controls.Add(this.txtCorreo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarCorreo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditarCorreo";
            this.Load += new System.EventHandler(this.EditarCorreo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCambiarCorreo;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblEditarCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.ComboBox cmbCorreos;
    }
}