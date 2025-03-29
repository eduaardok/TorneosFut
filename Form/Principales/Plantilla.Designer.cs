namespace TorneosFut
{
    partial class Plantilla
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbFormacionVisitante = new System.Windows.Forms.ComboBox();
            this.cmbFormacionLocal = new System.Windows.Forms.ComboBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlCancha = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.cmbFormacionVisitante);
            this.panel1.Controls.Add(this.cmbFormacionLocal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 39);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 88;
            this.label1.Text = "Alineación visitante";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(56, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(161, 24);
            this.lblNombre.TabIndex = 87;
            this.lblNombre.Text = "Alineación Local";
            // 
            // cmbFormacionVisitante
            // 
            this.cmbFormacionVisitante.FormattingEnabled = true;
            this.cmbFormacionVisitante.Location = new System.Drawing.Point(582, 8);
            this.cmbFormacionVisitante.Name = "cmbFormacionVisitante";
            this.cmbFormacionVisitante.Size = new System.Drawing.Size(121, 21);
            this.cmbFormacionVisitante.TabIndex = 1;
            this.cmbFormacionVisitante.SelectedIndexChanged += new System.EventHandler(this.CmbFormacion_SelectedIndexChanged);
            // 
            // cmbFormacionLocal
            // 
            this.cmbFormacionLocal.FormattingEnabled = true;
            this.cmbFormacionLocal.Location = new System.Drawing.Point(223, 8);
            this.cmbFormacionLocal.Name = "cmbFormacionLocal";
            this.cmbFormacionLocal.Size = new System.Drawing.Size(121, 21);
            this.cmbFormacionLocal.TabIndex = 0;
            this.cmbFormacionLocal.SelectedIndexChanged += new System.EventHandler(this.CmbFormacion_SelectedIndexChanged);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Onest Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCerrar.Location = new System.Drawing.Point(12, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 36);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // pnlCancha
            // 
            this.pnlCancha.BackgroundImage = global::TorneosFut.Properties.Resources.soccer_field_background__1_;
            this.pnlCancha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCancha.Location = new System.Drawing.Point(0, 40);
            this.pnlCancha.Name = "pnlCancha";
            this.pnlCancha.Size = new System.Drawing.Size(865, 901);
            this.pnlCancha.TabIndex = 7;
            // 
            // Plantilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 941);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCancha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Plantilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Plantilla";
            this.Load += new System.EventHandler(this.Plantilla_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbFormacionVisitante;
        private System.Windows.Forms.ComboBox cmbFormacionLocal;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel pnlCancha;
        private System.Windows.Forms.Button btnCerrar;
    }
}