namespace TorneosFut
{
    partial class Equipos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panelDgv = new System.Windows.Forms.Panel();
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.btngMostrar = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscarEquipo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btngEditar = new Guna.UI2.WinForms.Guna2Button();
            this.ptbIMG = new System.Windows.Forms.PictureBox();
            this.panelDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Onest Bold", 25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "Equipos";
            // 
            // panelDgv
            // 
            this.panelDgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelDgv.Controls.Add(this.dgvEquipos);
            this.panelDgv.Location = new System.Drawing.Point(43, 247);
            this.panelDgv.Name = "panelDgv";
            this.panelDgv.Size = new System.Drawing.Size(1415, 642);
            this.panelDgv.TabIndex = 5;
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.AllowUserToAddRows = false;
            this.dgvEquipos.AllowUserToDeleteRows = false;
            this.dgvEquipos.AllowUserToResizeColumns = false;
            this.dgvEquipos.AllowUserToResizeRows = false;
            this.dgvEquipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquipos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEquipos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEquipos.EnableHeadersVisualStyles = false;
            this.dgvEquipos.Location = new System.Drawing.Point(0, 0);
            this.dgvEquipos.MultiSelect = false;
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.ReadOnly = true;
            this.dgvEquipos.RowHeadersVisible = false;
            this.dgvEquipos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.dgvEquipos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipos.ShowCellToolTips = false;
            this.dgvEquipos.ShowEditingIcon = false;
            this.dgvEquipos.Size = new System.Drawing.Size(1415, 642);
            this.dgvEquipos.TabIndex = 5;
            // 
            // btngMostrar
            // 
            this.btngMostrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btngMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btngMostrar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btngMostrar.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btngMostrar.CheckedState.FillColor = System.Drawing.Color.Black;
            this.btngMostrar.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btngMostrar.CustomBorderColor = System.Drawing.Color.White;
            this.btngMostrar.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btngMostrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngMostrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngMostrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngMostrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngMostrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btngMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngMostrar.ForeColor = System.Drawing.Color.White;
            this.btngMostrar.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btngMostrar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btngMostrar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btngMostrar.Location = new System.Drawing.Point(404, 145);
            this.btngMostrar.Name = "btngMostrar";
            this.btngMostrar.Size = new System.Drawing.Size(271, 59);
            this.btngMostrar.TabIndex = 11;
            this.btngMostrar.Text = "AGREGAR UN NUEVO EQUIPO";
            this.btngMostrar.Click += new System.EventHandler(this.btngMostrar_Click);
            // 
            // txtBuscarEquipo
            // 
            this.txtBuscarEquipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarEquipo.Font = new System.Drawing.Font("Onest Light", 20F);
            this.txtBuscarEquipo.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscarEquipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBuscarEquipo.Location = new System.Drawing.Point(161, 75);
            this.txtBuscarEquipo.Multiline = true;
            this.txtBuscarEquipo.Name = "txtBuscarEquipo";
            this.txtBuscarEquipo.Size = new System.Drawing.Size(635, 48);
            this.txtBuscarEquipo.TabIndex = 16;
            this.txtBuscarEquipo.Text = "Buscar por nombre del Equipo";
            this.txtBuscarEquipo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscarJugador_MouseClick);
            this.txtBuscarEquipo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarJugador_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::TorneosFut.Properties.Resources.IconoLupa;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(105, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 49);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btngEditar
            // 
            this.btngEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btngEditar.BackColor = System.Drawing.Color.White;
            this.btngEditar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btngEditar.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btngEditar.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btngEditar.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btngEditar.CustomBorderColor = System.Drawing.Color.White;
            this.btngEditar.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btngEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngEditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btngEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngEditar.ForeColor = System.Drawing.Color.Black;
            this.btngEditar.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btngEditar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btngEditar.Location = new System.Drawing.Point(196, 145);
            this.btngEditar.Name = "btngEditar";
            this.btngEditar.Size = new System.Drawing.Size(180, 59);
            this.btngEditar.TabIndex = 10;
            this.btngEditar.Text = "EDITAR EQUIPO";
            this.btngEditar.Click += new System.EventHandler(this.btngEditar_Click);
            // 
            // ptbIMG
            // 
            this.ptbIMG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbIMG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbIMG.Location = new System.Drawing.Point(855, 100);
            this.ptbIMG.Name = "ptbIMG";
            this.ptbIMG.Size = new System.Drawing.Size(166, 141);
            this.ptbIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbIMG.TabIndex = 25;
            this.ptbIMG.TabStop = false;
            // 
            // Equipos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1490, 911);
            this.ControlBox = false;
            this.Controls.Add(this.ptbIMG);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBuscarEquipo);
            this.Controls.Add(this.btngMostrar);
            this.Controls.Add(this.btngEditar);
            this.Controls.Add(this.panelDgv);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(293, 73);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Equipos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Equipos";
            this.Load += new System.EventHandler(this.Equipos_Load);
            this.panelDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panelDgv;
        public System.Windows.Forms.DataGridView dgvEquipos;
        private Guna.UI2.WinForms.Guna2Button btngMostrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscarEquipo;
        public System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btngEditar;
        private System.Windows.Forms.PictureBox ptbIMG;
    }
}