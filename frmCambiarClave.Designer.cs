namespace TorneosFut
{
    partial class frmCambiarClave
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
            this.btngEnviar = new Guna.UI2.WinForms.Guna2Button();
            this.lblClaveAct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClaveApp = new System.Windows.Forms.TextBox();
            this.lblNueva = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btngEnviar
            // 
            this.btngEnviar.BackColor = System.Drawing.Color.White;
            this.btngEnviar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btngEnviar.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btngEnviar.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btngEnviar.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btngEnviar.CustomBorderColor = System.Drawing.Color.White;
            this.btngEnviar.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btngEnviar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngEnviar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngEnviar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngEnviar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngEnviar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btngEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngEnviar.ForeColor = System.Drawing.Color.Black;
            this.btngEnviar.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btngEnviar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btngEnviar.Location = new System.Drawing.Point(252, 217);
            this.btngEnviar.Name = "btngEnviar";
            this.btngEnviar.Size = new System.Drawing.Size(134, 50);
            this.btngEnviar.TabIndex = 40;
            this.btngEnviar.Text = "ENVIAR";
            this.btngEnviar.Click += new System.EventHandler(this.btngEnviar_Click);
            // 
            // lblClaveAct
            // 
            this.lblClaveAct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClaveAct.AutoSize = true;
            this.lblClaveAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveAct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.lblClaveAct.Location = new System.Drawing.Point(247, 82);
            this.lblClaveAct.Name = "lblClaveAct";
            this.lblClaveAct.Size = new System.Drawing.Size(68, 25);
            this.lblClaveAct.TabIndex = 39;
            this.lblClaveAct.Text = "clave";
            this.lblClaveAct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.label1.Location = new System.Drawing.Point(80, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Clave actual:";
            // 
            // txtClaveApp
            // 
            this.txtClaveApp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtClaveApp.BackColor = System.Drawing.Color.White;
            this.txtClaveApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtClaveApp.Location = new System.Drawing.Point(252, 147);
            this.txtClaveApp.Name = "txtClaveApp";
            this.txtClaveApp.Size = new System.Drawing.Size(279, 32);
            this.txtClaveApp.TabIndex = 37;
            // 
            // lblNueva
            // 
            this.lblNueva.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNueva.AutoSize = true;
            this.lblNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNueva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.lblNueva.Location = new System.Drawing.Point(80, 154);
            this.lblNueva.Name = "lblNueva";
            this.lblNueva.Size = new System.Drawing.Size(149, 25);
            this.lblNueva.TabIndex = 36;
            this.lblNueva.Text = "Nueva clave:";
            // 
            // frmCambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 349);
            this.Controls.Add(this.btngEnviar);
            this.Controls.Add(this.lblClaveAct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClaveApp);
            this.Controls.Add(this.lblNueva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCambiarClave";
            this.Text = "CAMBIO DE CLAVE";
            this.Load += new System.EventHandler(this.frmCambiarClave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btngEnviar;
        private System.Windows.Forms.Label lblClaveAct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClaveApp;
        private System.Windows.Forms.Label lblNueva;
    }
}