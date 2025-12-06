namespace TorneosFut
{
    partial class Organizadores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgvOrganizador = new System.Windows.Forms.DataGridView();
            this.btnAggOrganizador = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizador)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::TorneosFut.Properties.Resources.IconoLupa;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(189, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 49);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtFiltro.ForeColor = System.Drawing.Color.Gray;
            this.txtFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtFiltro.Location = new System.Drawing.Point(245, 83);
            this.txtFiltro.Multiline = true;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(633, 48);
            this.txtFiltro.TabIndex = 41;
            this.txtFiltro.Text = "Buscar por nombre del Organizador";
            this.txtFiltro.Click += new System.EventHandler(this.txtFiltro_Click);
            // 
            // dgvOrganizador
            // 
            this.dgvOrganizador.AllowUserToAddRows = false;
            this.dgvOrganizador.AllowUserToDeleteRows = false;
            this.dgvOrganizador.AllowUserToResizeColumns = false;
            this.dgvOrganizador.AllowUserToResizeRows = false;
            this.dgvOrganizador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrganizador.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrganizador.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrganizador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOrganizador.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrganizador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvOrganizador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrganizador.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvOrganizador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrganizador.EnableHeadersVisualStyles = false;
            this.dgvOrganizador.Location = new System.Drawing.Point(0, 0);
            this.dgvOrganizador.Name = "dgvOrganizador";
            this.dgvOrganizador.ReadOnly = true;
            this.dgvOrganizador.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrganizador.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvOrganizador.RowHeadersVisible = false;
            this.dgvOrganizador.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.dgvOrganizador.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvOrganizador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrganizador.Size = new System.Drawing.Size(1191, 494);
            this.dgvOrganizador.TabIndex = 39;
            // 
            // btnAggOrganizador
            // 
            this.btnAggOrganizador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAggOrganizador.Animated = true;
            this.btnAggOrganizador.BackColor = System.Drawing.Color.Transparent;
            this.btnAggOrganizador.BorderRadius = 20;
            this.btnAggOrganizador.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAggOrganizador.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAggOrganizador.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAggOrganizador.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAggOrganizador.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnAggOrganizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggOrganizador.ForeColor = System.Drawing.Color.Black;
            this.btnAggOrganizador.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnAggOrganizador.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnAggOrganizador.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAggOrganizador.Location = new System.Drawing.Point(189, 199);
            this.btnAggOrganizador.Name = "btnAggOrganizador";
            this.btnAggOrganizador.Size = new System.Drawing.Size(184, 52);
            this.btnAggOrganizador.TabIndex = 35;
            this.btnAggOrganizador.Text = "Agregar Organizador";
            this.btnAggOrganizador.Click += new System.EventHandler(this.btnAggOrganizador_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.Animated = true;
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BorderColor = System.Drawing.Color.Empty;
            this.btnEditar.BorderRadius = 20;
            this.btnEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnEditar.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(379, 199);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(184, 52);
            this.btnEditar.TabIndex = 102;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 31);
            this.label1.TabIndex = 103;
            this.label1.Text = "Lista de Organizadores";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvOrganizador);
            this.panel1.Location = new System.Drawing.Point(138, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 494);
            this.panel1.TabIndex = 104;
            // 
            // Organizadores
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1476, 873);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnAggOrganizador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(12, 23);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Organizadores";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Organizadores";
            this.Load += new System.EventHandler(this.Organizadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizador)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFiltro;
        public System.Windows.Forms.DataGridView dgvOrganizador;
        private Guna.UI2.WinForms.Guna2Button btnAggOrganizador;
        public Guna.UI2.WinForms.Guna2Button btnEditar;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}