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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.lblArchi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbCuerpo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Onest Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Onest Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asunto:";
            // 
            // txtPara
            // 
            this.txtPara.Font = new System.Drawing.Font("Onest Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPara.Location = new System.Drawing.Point(83, 30);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(488, 34);
            this.txtPara.TabIndex = 2;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Font = new System.Drawing.Font("Onest Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsunto.Location = new System.Drawing.Point(110, 79);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(461, 34);
            this.txtAsunto.TabIndex = 3;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(577, 266);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(165, 62);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnArchivo
            // 
            this.btnArchivo.Location = new System.Drawing.Point(577, 334);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(165, 62);
            this.btnArchivo.TabIndex = 6;
            this.btnArchivo.Text = "Adjuntar archivo";
            this.btnArchivo.UseVisualStyleBackColor = true;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // lblArchi
            // 
            this.lblArchi.AutoSize = true;
            this.lblArchi.Font = new System.Drawing.Font("Onest Light", 9.749998F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchi.Location = new System.Drawing.Point(577, 399);
            this.lblArchi.Name = "lblArchi";
            this.lblArchi.Size = new System.Drawing.Size(163, 17);
            this.lblArchi.TabIndex = 7;
            this.lblArchi.Text = "Se adjuntaron () archivos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Onest Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(500, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Para enviar a varios correos debe serparar cada correo por coma o punto y coma, s" +
    "in espacios";
            // 
            // rtbCuerpo
            // 
            this.rtbCuerpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCuerpo.Location = new System.Drawing.Point(12, 227);
            this.rtbCuerpo.Name = "rtbCuerpo";
            this.rtbCuerpo.Size = new System.Drawing.Size(554, 211);
            this.rtbCuerpo.TabIndex = 9;
            this.rtbCuerpo.Text = "";
            // 
            // frmCorreos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbCuerpo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblArchi);
            this.Controls.Add(this.btnArchivo);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCorreos";
            this.Text = "frmCorreos";
            this.Load += new System.EventHandler(this.frmCorreos_Load);
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
    }
}