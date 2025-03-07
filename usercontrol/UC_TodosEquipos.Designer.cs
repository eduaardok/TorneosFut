namespace TorneosFut.BotonesEquipos
{
    partial class UC_TodosEquipos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_TodosEquipos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscarTodosEquipos = new System.Windows.Forms.TextBox();
            this.btnVerTodosEquipos = new System.Windows.Forms.Button();
            this.lbBorde = new System.Windows.Forms.Label();
            this.dgvTodosEquipos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(143, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtBuscarTodosEquipos
            // 
            this.txtBuscarTodosEquipos.Font = new System.Drawing.Font("Onest Light", 20F);
            this.txtBuscarTodosEquipos.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscarTodosEquipos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBuscarTodosEquipos.Location = new System.Drawing.Point(199, 44);
            this.txtBuscarTodosEquipos.Multiline = true;
            this.txtBuscarTodosEquipos.Name = "txtBuscarTodosEquipos";
            this.txtBuscarTodosEquipos.Size = new System.Drawing.Size(1084, 49);
            this.txtBuscarTodosEquipos.TabIndex = 6;
            this.txtBuscarTodosEquipos.Text = "Buscar por nombre del equipo";
            this.txtBuscarTodosEquipos.Click += new System.EventHandler(this.txtBuscarTodosEquipos_Click_1);
            this.txtBuscarTodosEquipos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarTodosEquipos_KeyUp);
            this.txtBuscarTodosEquipos.Leave += new System.EventHandler(this.txtBuscarTodosEquipos_Leave);
            // 
            // btnVerTodosEquipos
            // 
            this.btnVerTodosEquipos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnVerTodosEquipos.Font = new System.Drawing.Font("Onest Bold", 20F, System.Drawing.FontStyle.Bold);
            this.btnVerTodosEquipos.ForeColor = System.Drawing.Color.White;
            this.btnVerTodosEquipos.Location = new System.Drawing.Point(155, 256);
            this.btnVerTodosEquipos.Name = "btnVerTodosEquipos";
            this.btnVerTodosEquipos.Size = new System.Drawing.Size(152, 58);
            this.btnVerTodosEquipos.TabIndex = 9;
            this.btnVerTodosEquipos.Text = "VER";
            this.btnVerTodosEquipos.UseVisualStyleBackColor = false;
            this.btnVerTodosEquipos.Click += new System.EventHandler(this.btnVerTodosEquipos_Click);
            // 
            // lbBorde
            // 
            this.lbBorde.Location = new System.Drawing.Point(91, 0);
            this.lbBorde.Name = "lbBorde";
            this.lbBorde.Size = new System.Drawing.Size(1315, 524);
            this.lbBorde.TabIndex = 11;
            this.lbBorde.Paint += new System.Windows.Forms.PaintEventHandler(this.lbBorde_Paint);
            // 
            // dgvTodosEquipos
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTodosEquipos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTodosEquipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTodosEquipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTodosEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodosEquipos.EnableHeadersVisualStyles = false;
            this.dgvTodosEquipos.Location = new System.Drawing.Point(461, 110);
            this.dgvTodosEquipos.Name = "dgvTodosEquipos";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTodosEquipos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTodosEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodosEquipos.Size = new System.Drawing.Size(822, 381);
            this.dgvTodosEquipos.TabIndex = 12;
            this.dgvTodosEquipos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTodosEquipos_CellClick);
            // 
            // UC_TodosEquipos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvTodosEquipos);
            this.Controls.Add(this.btnVerTodosEquipos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBuscarTodosEquipos);
            this.Controls.Add(this.lbBorde);
            this.Name = "UC_TodosEquipos";
            this.Size = new System.Drawing.Size(1490, 558);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscarTodosEquipos;
        private System.Windows.Forms.Button btnVerTodosEquipos;
        private System.Windows.Forms.Label lbBorde;
        private System.Windows.Forms.DataGridView dgvTodosEquipos;
    }
}
