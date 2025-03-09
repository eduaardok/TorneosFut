namespace PruebasTorneos
{
    partial class Entrenador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscarEntrenador = new System.Windows.Forms.TextBox();
            this.ptbIMG = new System.Windows.Forms.PictureBox();
            this.dgvEntrenador = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAggDT = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenador)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::TorneosFut.Properties.Resources.IconoLupa;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(141, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 49);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // txtBuscarEntrenador
            // 
            this.txtBuscarEntrenador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarEntrenador.Font = new System.Drawing.Font("Onest Light", 20F);
            this.txtBuscarEntrenador.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscarEntrenador.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBuscarEntrenador.Location = new System.Drawing.Point(197, 96);
            this.txtBuscarEntrenador.Multiline = true;
            this.txtBuscarEntrenador.Name = "txtBuscarEntrenador";
            this.txtBuscarEntrenador.Size = new System.Drawing.Size(633, 48);
            this.txtBuscarEntrenador.TabIndex = 25;
            this.txtBuscarEntrenador.Text = "Buscar por nombre del Entrenador";
            // 
            // ptbIMG
            // 
            this.ptbIMG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbIMG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbIMG.Location = new System.Drawing.Point(871, 126);
            this.ptbIMG.Name = "ptbIMG";
            this.ptbIMG.Size = new System.Drawing.Size(166, 141);
            this.ptbIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbIMG.TabIndex = 24;
            this.ptbIMG.TabStop = false;
            // 
            // dgvEntrenador
            // 
            this.dgvEntrenador.AllowUserToAddRows = false;
            this.dgvEntrenador.AllowUserToDeleteRows = false;
            this.dgvEntrenador.AllowUserToResizeColumns = false;
            this.dgvEntrenador.AllowUserToResizeRows = false;
            this.dgvEntrenador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvEntrenador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntrenador.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Onest Bold", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntrenador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEntrenador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Onest Bold", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEntrenador.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEntrenador.EnableHeadersVisualStyles = false;
            this.dgvEntrenador.Location = new System.Drawing.Point(124, 273);
            this.dgvEntrenador.Name = "dgvEntrenador";
            this.dgvEntrenador.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Onest Bold", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntrenador.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEntrenador.RowHeadersVisible = false;
            this.dgvEntrenador.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEntrenador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntrenador.Size = new System.Drawing.Size(1186, 601);
            this.dgvEntrenador.TabIndex = 23;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(310, 188);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(123, 52);
            this.btnEditar.TabIndex = 22;
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
            this.btnEstadisticas.Location = new System.Drawing.Point(141, 188);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(123, 52);
            this.btnEstadisticas.TabIndex = 21;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Onest Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 34);
            this.label1.TabIndex = 20;
            this.label1.Text = "Lista de Entrenadores";
            // 
            // btnAggDT
            // 
            this.btnAggDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAggDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnAggDT.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAggDT.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnAggDT.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAggDT.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnAggDT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAggDT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAggDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAggDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAggDT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnAggDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggDT.ForeColor = System.Drawing.Color.Black;
            this.btnAggDT.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnAggDT.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAggDT.Location = new System.Drawing.Point(503, 188);
            this.btnAggDT.Name = "btnAggDT";
            this.btnAggDT.Size = new System.Drawing.Size(184, 52);
            this.btnAggDT.TabIndex = 19;
            this.btnAggDT.Text = "Agregar Entrenadores";
            // 
            // Entrenador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1490, 911);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBuscarEntrenador);
            this.Controls.Add(this.ptbIMG);
            this.Controls.Add(this.dgvEntrenador);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAggDT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Entrenador";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Padre";
            this.Load += new System.EventHandler(this.Padre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscarEntrenador;
        private System.Windows.Forms.PictureBox ptbIMG;
        public System.Windows.Forms.DataGridView dgvEntrenador;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEstadisticas;
        public System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAggDT;
    }
}