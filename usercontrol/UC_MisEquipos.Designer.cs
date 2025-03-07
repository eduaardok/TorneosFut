namespace TorneosFut.BotonesEquipos
{
    partial class UC_MisEquipos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_MisEquipos));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.btnVerEquipo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBuscarMisEquipos = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(91, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1315, 524);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.label1_Paint);
            // 
            // dgvEquipos
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEquipos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEquipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.EnableHeadersVisualStyles = false;
            this.dgvEquipos.Location = new System.Drawing.Point(461, 112);
            this.dgvEquipos.Name = "dgvEquipos";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEquipos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipos.Size = new System.Drawing.Size(822, 381);
            this.dgvEquipos.TabIndex = 1;
            this.dgvEquipos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipos_CellClick);
            // 
            // btnVerEquipo
            // 
            this.btnVerEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnVerEquipo.Font = new System.Drawing.Font("Onest Bold", 20F, System.Drawing.FontStyle.Bold);
            this.btnVerEquipo.ForeColor = System.Drawing.Color.White;
            this.btnVerEquipo.Location = new System.Drawing.Point(156, 211);
            this.btnVerEquipo.Name = "btnVerEquipo";
            this.btnVerEquipo.Size = new System.Drawing.Size(152, 58);
            this.btnVerEquipo.TabIndex = 2;
            this.btnVerEquipo.Text = "VER";
            this.btnVerEquipo.UseVisualStyleBackColor = false;
            this.btnVerEquipo.Click += new System.EventHandler(this.btnVerEquipo_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.button2.Font = new System.Drawing.Font("Onest Bold", 20F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(156, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 58);
            this.button2.TabIndex = 3;
            this.button2.Text = "EDITAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBuscarMisEquipos
            // 
            this.txtBuscarMisEquipos.Font = new System.Drawing.Font("Onest Light", 20F);
            this.txtBuscarMisEquipos.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscarMisEquipos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBuscarMisEquipos.Location = new System.Drawing.Point(199, 44);
            this.txtBuscarMisEquipos.Multiline = true;
            this.txtBuscarMisEquipos.Name = "txtBuscarMisEquipos";
            this.txtBuscarMisEquipos.Size = new System.Drawing.Size(1084, 49);
            this.txtBuscarMisEquipos.TabIndex = 4;
            this.txtBuscarMisEquipos.Text = "Buscar por nombre del equipo";
            this.txtBuscarMisEquipos.Click += new System.EventHandler(this.txtBarraBuscar_Click);
            this.txtBuscarMisEquipos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarMisEquipos_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(143, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // UC_MisEquipos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBuscarMisEquipos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnVerEquipo);
            this.Controls.Add(this.dgvEquipos);
            this.Controls.Add(this.label1);
            this.Name = "UC_MisEquipos";
            this.Size = new System.Drawing.Size(1490, 558);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.Button btnVerEquipo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBuscarMisEquipos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
