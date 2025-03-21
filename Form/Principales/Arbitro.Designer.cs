namespace TorneosFut
{
    partial class Arbitro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscarArbitro = new System.Windows.Forms.TextBox();
            this.panelDgv = new System.Windows.Forms.Panel();
            this.dgvArbitro = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPagoArbitro = new Guna.UI2.WinForms.Guna2Button();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbitro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarArbitro
            // 
            this.txtBuscarArbitro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarArbitro.Font = new System.Drawing.Font("Onest Light", 20F);
            this.txtBuscarArbitro.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscarArbitro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBuscarArbitro.Location = new System.Drawing.Point(288, 140);
            this.txtBuscarArbitro.Multiline = true;
            this.txtBuscarArbitro.Name = "txtBuscarArbitro";
            this.txtBuscarArbitro.Size = new System.Drawing.Size(795, 48);
            this.txtBuscarArbitro.TabIndex = 21;
            this.txtBuscarArbitro.Text = "Buscar por nombre del Arbitro";
            // 
            // panelDgv
            // 
            this.panelDgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelDgv.Controls.Add(this.dgvArbitro);
            this.panelDgv.Location = new System.Drawing.Point(200, 286);
            this.panelDgv.Name = "panelDgv";
            this.panelDgv.Size = new System.Drawing.Size(1142, 573);
            this.panelDgv.TabIndex = 20;
            // 
            // dgvArbitro
            // 
            this.dgvArbitro.AllowUserToAddRows = false;
            this.dgvArbitro.AllowUserToDeleteRows = false;
            this.dgvArbitro.AllowUserToResizeColumns = false;
            this.dgvArbitro.AllowUserToResizeRows = false;
            this.dgvArbitro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArbitro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArbitro.BackgroundColor = System.Drawing.Color.White;
            this.dgvArbitro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArbitro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArbitro.ColumnHeadersHeight = 40;
            this.dgvArbitro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvArbitro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArbitro.EnableHeadersVisualStyles = false;
            this.dgvArbitro.Location = new System.Drawing.Point(0, 0);
            this.dgvArbitro.MultiSelect = false;
            this.dgvArbitro.Name = "dgvArbitro";
            this.dgvArbitro.ReadOnly = true;
            this.dgvArbitro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvArbitro.RowHeadersVisible = false;
            this.dgvArbitro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.dgvArbitro.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArbitro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArbitro.ShowCellToolTips = false;
            this.dgvArbitro.ShowEditingIcon = false;
            this.dgvArbitro.Size = new System.Drawing.Size(1142, 573);
            this.dgvArbitro.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.Animated = true;
            this.btnAgregar.BorderRadius = 20;
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnAgregar.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnAgregar.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(200, 221);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(222, 59);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "AGREGAR ARBITRO";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.Animated = true;
            this.btnEditar.BorderRadius = 20;
            this.btnEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnEditar.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnEditar.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(459, 221);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(214, 59);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "EDITAR ARBITRO";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Onest Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 34);
            this.label2.TabIndex = 17;
            this.label2.Text = "Lista de Arbitros";
            // 
            // btnPagoArbitro
            // 
            this.btnPagoArbitro.Animated = true;
            this.btnPagoArbitro.BorderRadius = 20;
            this.btnPagoArbitro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPagoArbitro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPagoArbitro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPagoArbitro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPagoArbitro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnPagoArbitro.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagoArbitro.ForeColor = System.Drawing.Color.White;
            this.btnPagoArbitro.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnPagoArbitro.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnPagoArbitro.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnPagoArbitro.Location = new System.Drawing.Point(12, 758);
            this.btnPagoArbitro.Name = "btnPagoArbitro";
            this.btnPagoArbitro.Size = new System.Drawing.Size(176, 84);
            this.btnPagoArbitro.TabIndex = 89;
            this.btnPagoArbitro.Text = "Pagar Arbitro";
            this.btnPagoArbitro.Click += new System.EventHandler(this.btnPagoArbitro_Click);
            // 
            // ptbImagen
            // 
            this.ptbImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbImagen.Location = new System.Drawing.Point(1105, 48);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(207, 193);
            this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagen.TabIndex = 23;
            this.ptbImagen.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::TorneosFut.Properties.Resources.IconoLupa;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(200, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 49);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Arbitro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1414, 920);
            this.Controls.Add(this.btnPagoArbitro);
            this.Controls.Add(this.ptbImagen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBuscarArbitro);
            this.Controls.Add(this.panelDgv);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Arbitro";
            this.Text = "Arbitro";
            this.Load += new System.EventHandler(this.Arbitro_Load);
            this.panelDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbitro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbImagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscarArbitro;
        private System.Windows.Forms.Panel panelDgv;
        public System.Windows.Forms.DataGridView dgvArbitro;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        public System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnPagoArbitro;
    }
}