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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscarEntrenador = new System.Windows.Forms.TextBox();
            this.ptbIMGOrganizador = new System.Windows.Forms.PictureBox();
            this.dgvOrganizador = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAggOrganizador = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIMGOrganizador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizador)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::TorneosFut.Properties.Resources.IconoLupa;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(196, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 49);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // txtBuscarEntrenador
            // 
            this.txtBuscarEntrenador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarEntrenador.Font = new System.Drawing.Font("Onest Light", 20F);
            this.txtBuscarEntrenador.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscarEntrenador.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBuscarEntrenador.Location = new System.Drawing.Point(252, 101);
            this.txtBuscarEntrenador.Multiline = true;
            this.txtBuscarEntrenador.Name = "txtBuscarEntrenador";
            this.txtBuscarEntrenador.Size = new System.Drawing.Size(633, 48);
            this.txtBuscarEntrenador.TabIndex = 41;
            this.txtBuscarEntrenador.Text = "Buscar por nombre del Entrenador";
            // 
            // ptbIMGOrganizador
            // 
            this.ptbIMGOrganizador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbIMGOrganizador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbIMGOrganizador.Location = new System.Drawing.Point(926, 131);
            this.ptbIMGOrganizador.Name = "ptbIMGOrganizador";
            this.ptbIMGOrganizador.Size = new System.Drawing.Size(166, 141);
            this.ptbIMGOrganizador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbIMGOrganizador.TabIndex = 40;
            this.ptbIMGOrganizador.TabStop = false;
            // 
            // dgvOrganizador
            // 
            this.dgvOrganizador.AllowUserToAddRows = false;
            this.dgvOrganizador.AllowUserToDeleteRows = false;
            this.dgvOrganizador.AllowUserToResizeColumns = false;
            this.dgvOrganizador.AllowUserToResizeRows = false;
            this.dgvOrganizador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvOrganizador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrganizador.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Onest Bold", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrganizador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrganizador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Onest Bold", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrganizador.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrganizador.EnableHeadersVisualStyles = false;
            this.dgvOrganizador.Location = new System.Drawing.Point(179, 278);
            this.dgvOrganizador.Name = "dgvOrganizador";
            this.dgvOrganizador.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Onest Bold", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrganizador.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrganizador.RowHeadersVisible = false;
            this.dgvOrganizador.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOrganizador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrganizador.Size = new System.Drawing.Size(1186, 601);
            this.dgvOrganizador.TabIndex = 39;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(365, 193);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(123, 52);
            this.btnEditar.TabIndex = 38;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.Font = new System.Drawing.Font("Onest Bold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticas.ForeColor = System.Drawing.Color.Black;
            this.btnEstadisticas.Location = new System.Drawing.Point(196, 193);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(123, 52);
            this.btnEstadisticas.TabIndex = 37;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Onest Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 34);
            this.label1.TabIndex = 36;
            this.label1.Text = "Lista de Organizadores";
            // 
            // btnAggOrganizador
            // 
            this.btnAggOrganizador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAggOrganizador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnAggOrganizador.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAggOrganizador.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnAggOrganizador.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAggOrganizador.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnAggOrganizador.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAggOrganizador.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAggOrganizador.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAggOrganizador.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAggOrganizador.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnAggOrganizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggOrganizador.ForeColor = System.Drawing.Color.Black;
            this.btnAggOrganizador.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnAggOrganizador.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAggOrganizador.Location = new System.Drawing.Point(558, 193);
            this.btnAggOrganizador.Name = "btnAggOrganizador";
            this.btnAggOrganizador.Size = new System.Drawing.Size(184, 52);
            this.btnAggOrganizador.TabIndex = 35;
            this.btnAggOrganizador.Text = "Agregar Organizador";
            // 
            // Organizadores
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1490, 911);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBuscarEntrenador);
            this.Controls.Add(this.ptbIMGOrganizador);
            this.Controls.Add(this.dgvOrganizador);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAggOrganizador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Organizadores";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Organizadores";
            this.Load += new System.EventHandler(this.Organizadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIMGOrganizador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscarEntrenador;
        private System.Windows.Forms.PictureBox ptbIMGOrganizador;
        public System.Windows.Forms.DataGridView dgvOrganizador;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEstadisticas;
        public System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAggOrganizador;
    }
}