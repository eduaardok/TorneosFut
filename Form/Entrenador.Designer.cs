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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscarEntrenador = new System.Windows.Forms.TextBox();
            this.ptbIMG = new System.Windows.Forms.PictureBox();
            this.dgvEntrenador = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
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
            this.pictureBox1.Location = new System.Drawing.Point(171, 103);
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
            this.txtBuscarEntrenador.Location = new System.Drawing.Point(227, 103);
            this.txtBuscarEntrenador.Multiline = true;
            this.txtBuscarEntrenador.Name = "txtBuscarEntrenador";
            this.txtBuscarEntrenador.Size = new System.Drawing.Size(633, 48);
            this.txtBuscarEntrenador.TabIndex = 25;
            this.txtBuscarEntrenador.Text = "Buscar por nombre del Entrenador";
            this.txtBuscarEntrenador.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscarEntrenador_MouseClick);
            this.txtBuscarEntrenador.TextChanged += new System.EventHandler(this.txtBuscarEntrenador_TextChanged);
            // 
            // ptbIMG
            // 
            this.ptbIMG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbIMG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbIMG.Location = new System.Drawing.Point(896, 53);
            this.ptbIMG.Name = "ptbIMG";
            this.ptbIMG.Size = new System.Drawing.Size(247, 202);
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
            this.dgvEntrenador.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEntrenador.BackgroundColor = System.Drawing.Color.White;
            this.dgvEntrenador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEntrenador.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Onest Bold", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntrenador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEntrenador.ColumnHeadersHeight = 40;
            this.dgvEntrenador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Onest Bold", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEntrenador.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEntrenador.EnableHeadersVisualStyles = false;
            this.dgvEntrenador.Location = new System.Drawing.Point(151, 271);
            this.dgvEntrenador.MultiSelect = false;
            this.dgvEntrenador.Name = "dgvEntrenador";
            this.dgvEntrenador.ReadOnly = true;
            this.dgvEntrenador.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Onest Bold", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntrenador.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEntrenador.RowHeadersVisible = false;
            this.dgvEntrenador.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEntrenador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntrenador.Size = new System.Drawing.Size(1186, 601);
            this.dgvEntrenador.TabIndex = 23;
            this.dgvEntrenador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntrenador_CellContentClick);
            this.dgvEntrenador.SelectionChanged += new System.EventHandler(this.dgvEntrenador_SelectionChanged_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(519, 185);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(123, 52);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
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
            this.btnAggDT.Location = new System.Drawing.Point(663, 185);
            this.btnAggDT.Name = "btnAggDT";
            this.btnAggDT.Size = new System.Drawing.Size(184, 52);
            this.btnAggDT.TabIndex = 19;
            this.btnAggDT.Text = "Agregar Entrenadores";
            this.btnAggDT.Click += new System.EventHandler(this.btnAggDT_Click_1);
            // 
            // Entrenador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1447, 919);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBuscarEntrenador);
            this.Controls.Add(this.ptbIMG);
            this.Controls.Add(this.dgvEntrenador);
            this.Controls.Add(this.btnEditar);
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
        public System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAggDT;
    }
}