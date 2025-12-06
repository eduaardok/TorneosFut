namespace TorneosFut
{
    partial class frmCorreos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.lblArchi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbCuerpo = new System.Windows.Forms.RichTextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asunto:";
            // 
            // txtPara
            // 
            this.txtPara.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPara.Location = new System.Drawing.Point(78, 57);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(488, 33);
            this.txtPara.TabIndex = 2;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsunto.Location = new System.Drawing.Point(105, 106);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(461, 33);
            this.txtAsunto.TabIndex = 3;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(572, 90);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(165, 62);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnArchivo
            // 
            this.btnArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnArchivo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchivo.ForeColor = System.Drawing.Color.Black;
            this.btnArchivo.Location = new System.Drawing.Point(572, 330);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(165, 62);
            this.btnArchivo.TabIndex = 6;
            this.btnArchivo.Text = "ADJUNTAR ARCHIVO";
            this.btnArchivo.UseVisualStyleBackColor = false;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // lblArchi
            // 
            this.lblArchi.AutoSize = true;
            this.lblArchi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchi.Location = new System.Drawing.Point(593, 395);
            this.lblArchi.Name = "lblArchi";
            this.lblArchi.Size = new System.Drawing.Size(184, 21);
            this.lblArchi.TabIndex = 7;
            this.lblArchi.Text = "Se adjuntaron () archivos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(492, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Para enviar a varios correos debe serparar cada correo por coma o punto y coma, s" +
    "in espacios";
            // 
            // rtbCuerpo
            // 
            this.rtbCuerpo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.rtbCuerpo.Location = new System.Drawing.Point(12, 181);
            this.rtbCuerpo.Name = "rtbCuerpo";
            this.rtbCuerpo.Size = new System.Drawing.Size(554, 211);
            this.rtbCuerpo.TabIndex = 9;
            this.rtbCuerpo.Text = "";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "CERRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(790, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 404);
            this.panel4.TabIndex = 180;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 440);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 10);
            this.panel3.TabIndex = 179;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 414);
            this.panel1.TabIndex = 178;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.panel2.Controls.Add(this.lblEncabezado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 36);
            this.panel2.TabIndex = 177;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblEncabezado.Location = new System.Drawing.Point(21, 11);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(124, 25);
            this.lblEncabezado.TabIndex = 33;
            this.lblEncabezado.Text = "CORREOS";
            // 
            // frmCorreos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbCuerpo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblArchi);
            this.Controls.Add(this.btnArchivo);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCorreos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCorreos";
            this.Load += new System.EventHandler(this.frmCorreos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.Label lblArchi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbCuerpo;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblEncabezado;
    }
}