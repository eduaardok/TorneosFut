namespace TorneosFut
{
    partial class Patrocinadores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPatrocinador = new System.Windows.Forms.DataGridView();
            this.btnAggPatrocinador = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditarPatrocinador = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPatrocinador = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatrocinador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFiltro.Font = new System.Drawing.Font("Onest Light", 20F);
            this.txtFiltro.ForeColor = System.Drawing.Color.Gray;
            this.txtFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtFiltro.Location = new System.Drawing.Point(252, 102);
            this.txtFiltro.Multiline = true;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(633, 48);
            this.txtFiltro.TabIndex = 33;
            this.txtFiltro.Text = "Buscar por nombre de Patrocinador";
            this.txtFiltro.Click += new System.EventHandler(this.txtFiltro_Click);
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Onest Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 34);
            this.label1.TabIndex = 28;
            this.label1.Text = "Lista de Patrocinadores";
            // 
            // dgvPatrocinador
            // 
            this.dgvPatrocinador.AllowUserToAddRows = false;
            this.dgvPatrocinador.AllowUserToDeleteRows = false;
            this.dgvPatrocinador.AllowUserToResizeColumns = false;
            this.dgvPatrocinador.AllowUserToResizeRows = false;
            this.dgvPatrocinador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPatrocinador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatrocinador.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPatrocinador.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatrocinador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPatrocinador.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Onest Bold", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatrocinador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatrocinador.ColumnHeadersHeight = 40;
            this.dgvPatrocinador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Onest Bold", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatrocinador.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatrocinador.EnableHeadersVisualStyles = false;
            this.dgvPatrocinador.Location = new System.Drawing.Point(145, 276);
            this.dgvPatrocinador.Name = "dgvPatrocinador";
            this.dgvPatrocinador.ReadOnly = true;
            this.dgvPatrocinador.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Onest Bold", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatrocinador.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPatrocinador.RowHeadersVisible = false;
            this.dgvPatrocinador.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.dgvPatrocinador.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPatrocinador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatrocinador.Size = new System.Drawing.Size(1186, 601);
            this.dgvPatrocinador.TabIndex = 31;
            // 
            // btnAggPatrocinador
            // 
            this.btnAggPatrocinador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAggPatrocinador.Animated = true;
            this.btnAggPatrocinador.AutoRoundedCorners = true;
            this.btnAggPatrocinador.BorderColor = System.Drawing.Color.Empty;
            this.btnAggPatrocinador.BorderRadius = 25;
            this.btnAggPatrocinador.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAggPatrocinador.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAggPatrocinador.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAggPatrocinador.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAggPatrocinador.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnAggPatrocinador.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggPatrocinador.ForeColor = System.Drawing.Color.Black;
            this.btnAggPatrocinador.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnAggPatrocinador.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnAggPatrocinador.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAggPatrocinador.Location = new System.Drawing.Point(196, 199);
            this.btnAggPatrocinador.Name = "btnAggPatrocinador";
            this.btnAggPatrocinador.Size = new System.Drawing.Size(184, 52);
            this.btnAggPatrocinador.TabIndex = 103;
            this.btnAggPatrocinador.Text = "Agregar Patrocinador";
            this.btnAggPatrocinador.Click += new System.EventHandler(this.btnAggPatrocinador_Click);
            // 
            // btnEditarPatrocinador
            // 
            this.btnEditarPatrocinador.Animated = true;
            this.btnEditarPatrocinador.BorderColor = System.Drawing.Color.Empty;
            this.btnEditarPatrocinador.BorderRadius = 20;
            this.btnEditarPatrocinador.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnEditarPatrocinador.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnEditarPatrocinador.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarPatrocinador.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarPatrocinador.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditarPatrocinador.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditarPatrocinador.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnEditarPatrocinador.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPatrocinador.ForeColor = System.Drawing.Color.White;
            this.btnEditarPatrocinador.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnEditarPatrocinador.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnEditarPatrocinador.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnEditarPatrocinador.Location = new System.Drawing.Point(481, 182);
            this.btnEditarPatrocinador.Name = "btnEditarPatrocinador";
            this.btnEditarPatrocinador.Size = new System.Drawing.Size(184, 52);
            this.btnEditarPatrocinador.TabIndex = 104;
            this.btnEditarPatrocinador.Text = "EDITAR";
            this.btnEditarPatrocinador.Click += new System.EventHandler(this.btnEditarPatrocinador_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::TorneosFut.Properties.Resources.IconoLupa;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(196, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 49);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // btnPatrocinador
            // 
            this.btnPatrocinador.Animated = true;
            this.btnPatrocinador.BackColor = System.Drawing.Color.White;
            this.btnPatrocinador.BorderColor = System.Drawing.Color.Empty;
            this.btnPatrocinador.BorderRadius = 20;
            this.btnPatrocinador.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPatrocinador.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPatrocinador.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPatrocinador.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPatrocinador.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnPatrocinador.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnPatrocinador.ForeColor = System.Drawing.Color.Black;
            this.btnPatrocinador.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnPatrocinador.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnPatrocinador.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnPatrocinador.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnPatrocinador.Location = new System.Drawing.Point(698, 182);
            this.btnPatrocinador.Name = "btnPatrocinador";
            this.btnPatrocinador.Size = new System.Drawing.Size(263, 52);
            this.btnPatrocinador.TabIndex = 146;
            this.btnPatrocinador.Text = "Asignar patrocinador a Torneo";
            this.btnPatrocinador.Click += new System.EventHandler(this.btnPatrocinador_Click);
            // 
            // Patrocinadores
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1490, 911);
            this.ControlBox = false;
            this.Controls.Add(this.btnPatrocinador);
            this.Controls.Add(this.btnEditarPatrocinador);
            this.Controls.Add(this.btnAggPatrocinador);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.dgvPatrocinador);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Patrocinadores";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Patrocinadores";
            this.Load += new System.EventHandler(this.Patrocinadores_Load);
            this.Shown += new System.EventHandler(this.Patrocinadores_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatrocinador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFiltro;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvPatrocinador;
        private Guna.UI2.WinForms.Guna2Button btnAggPatrocinador;
        public Guna.UI2.WinForms.Guna2Button btnEditarPatrocinador;
        public Guna.UI2.WinForms.Guna2Button btnPatrocinador;
    }
}