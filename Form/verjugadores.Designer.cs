namespace pruebas
{
    partial class verjugadores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvJugador = new System.Windows.Forms.DataGridView();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbIMG = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIMG)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvJugador
            // 
            this.dgvJugador.AllowUserToAddRows = false;
            this.dgvJugador.AllowUserToDeleteRows = false;
            this.dgvJugador.AllowUserToResizeColumns = false;
            this.dgvJugador.AllowUserToResizeRows = false;
            this.dgvJugador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJugador.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJugador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJugador.EnableHeadersVisualStyles = false;
            this.dgvJugador.Location = new System.Drawing.Point(3, 272);
            this.dgvJugador.MultiSelect = false;
            this.dgvJugador.Name = "dgvJugador";
            this.dgvJugador.ReadOnly = true;
            this.dgvJugador.RowHeadersVisible = false;
            this.dgvJugador.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.dgvJugador.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJugador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJugador.ShowCellErrors = false;
            this.dgvJugador.ShowCellToolTips = false;
            this.dgvJugador.ShowEditingIcon = false;
            this.dgvJugador.ShowRowErrors = false;
            this.dgvJugador.Size = new System.Drawing.Size(974, 562);
            this.dgvJugador.TabIndex = 0;
            this.dgvJugador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJugador_CellContentClick);
            this.dgvJugador.SelectionChanged += new System.EventHandler(this.dgvJugador_SelectionChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(681, 187);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(244, 66);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "EditarJugador";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Font = new System.Drawing.Font("Onest Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscador.Location = new System.Drawing.Point(38, 187);
            this.txtBuscador.Multiline = true;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(374, 37);
            this.txtBuscador.TabIndex = 3;
            this.txtBuscador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscador_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Onest Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscador";
            // 
            // ptbIMG
            // 
            this.ptbIMG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbIMG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbIMG.Location = new System.Drawing.Point(0, 0);
            this.ptbIMG.Name = "ptbIMG";
            this.ptbIMG.Size = new System.Drawing.Size(138, 109);
            this.ptbIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbIMG.TabIndex = 8;
            this.ptbIMG.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Onest Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 34);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lista de Jugadores";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptbIMG);
            this.panel1.Location = new System.Drawing.Point(429, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 112);
            this.panel1.TabIndex = 10;
            this.panel1.Visible = false;
            // 
            // verjugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 846);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.dgvJugador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "verjugadores";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "verjugadores";
            this.Load += new System.EventHandler(this.verjugadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIMG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        public System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvJugador;
        private System.Windows.Forms.PictureBox ptbIMG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}