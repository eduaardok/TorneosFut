namespace TorneosFut
{
    partial class Auditoria
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.btngLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.panelDgv = new System.Windows.Forms.Panel();
            this.dgvAuditoria = new System.Windows.Forms.DataGridView();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btngMostrar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::TorneosFut.Properties.Resources.IconoLupa;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(58, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 49);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Onest Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 34);
            this.label2.TabIndex = 24;
            this.label2.Text = "Lista de Auditorías";
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblBusqueda.Location = new System.Drawing.Point(114, 146);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(81, 18);
            this.lblBusqueda.TabIndex = 23;
            this.lblBusqueda.Text = "BUSCAR:";
            // 
            // btngLimpiar
            // 
            this.btngLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btngLimpiar.Animated = true;
            this.btngLimpiar.BorderRadius = 15;
            this.btngLimpiar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngLimpiar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngLimpiar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngLimpiar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngLimpiar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btngLimpiar.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngLimpiar.ForeColor = System.Drawing.Color.White;
            this.btngLimpiar.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btngLimpiar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btngLimpiar.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btngLimpiar.Location = new System.Drawing.Point(515, 170);
            this.btngLimpiar.Name = "btngLimpiar";
            this.btngLimpiar.Size = new System.Drawing.Size(180, 36);
            this.btngLimpiar.TabIndex = 20;
            this.btngLimpiar.Text = "LIMPIAR";
            this.btngLimpiar.Click += new System.EventHandler(this.btngLimpiar_Click);
            // 
            // panelDgv
            // 
            this.panelDgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelDgv.Controls.Add(this.dgvAuditoria);
            this.panelDgv.Location = new System.Drawing.Point(41, 230);
            this.panelDgv.Name = "panelDgv";
            this.panelDgv.Size = new System.Drawing.Size(1415, 642);
            this.panelDgv.TabIndex = 17;
            // 
            // dgvAuditoria
            // 
            this.dgvAuditoria.AllowUserToAddRows = false;
            this.dgvAuditoria.AllowUserToDeleteRows = false;
            this.dgvAuditoria.AllowUserToResizeColumns = false;
            this.dgvAuditoria.AllowUserToResizeRows = false;
            this.dgvAuditoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuditoria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAuditoria.BackgroundColor = System.Drawing.Color.White;
            this.dgvAuditoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAuditoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAuditoria.ColumnHeadersHeight = 40;
            this.dgvAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAuditoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAuditoria.EnableHeadersVisualStyles = false;
            this.dgvAuditoria.Location = new System.Drawing.Point(0, 0);
            this.dgvAuditoria.MultiSelect = false;
            this.dgvAuditoria.Name = "dgvAuditoria";
            this.dgvAuditoria.ReadOnly = true;
            this.dgvAuditoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAuditoria.RowHeadersVisible = false;
            this.dgvAuditoria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.dgvAuditoria.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAuditoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuditoria.ShowCellToolTips = false;
            this.dgvAuditoria.ShowEditingIcon = false;
            this.dgvAuditoria.Size = new System.Drawing.Size(1415, 642);
            this.dgvAuditoria.TabIndex = 5;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFiltro.ForeColor = System.Drawing.Color.Gray;
            this.txtFiltro.Location = new System.Drawing.Point(117, 175);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(392, 20);
            this.txtFiltro.TabIndex = 21;
            this.txtFiltro.Text = "Buscar por nombre de Usuario";
            this.txtFiltro.Click += new System.EventHandler(this.txtFiltro_Click);
            this.txtFiltro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFiltro_MouseClick);
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btngMostrar
            // 
            this.btngMostrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btngMostrar.Animated = true;
            this.btngMostrar.BorderRadius = 20;
            this.btngMostrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngMostrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngMostrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngMostrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngMostrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btngMostrar.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngMostrar.ForeColor = System.Drawing.Color.White;
            this.btngMostrar.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btngMostrar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btngMostrar.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btngMostrar.Location = new System.Drawing.Point(720, 157);
            this.btngMostrar.Name = "btngMostrar";
            this.btngMostrar.Size = new System.Drawing.Size(268, 59);
            this.btngMostrar.TabIndex = 26;
            this.btngMostrar.Text = "AUDITORIA INICIO DE SESION";
            this.btngMostrar.Click += new System.EventHandler(this.btngMostrar_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.guna2Button1.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(1016, 157);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(268, 59);
            this.guna2Button1.TabIndex = 27;
            this.guna2Button1.Text = "AUDITORIA  DE CAMBIOS";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Auditoria
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1490, 911);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btngMostrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.btngLimpiar);
            this.Controls.Add(this.panelDgv);
            this.Controls.Add(this.txtFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Auditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Auditoria";
            this.Load += new System.EventHandler(this.Auditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblBusqueda;
        private Guna.UI2.WinForms.Guna2Button btngLimpiar;
        private System.Windows.Forms.Panel panelDgv;
        public System.Windows.Forms.DataGridView dgvAuditoria;
        private System.Windows.Forms.TextBox txtFiltro;
        private Guna.UI2.WinForms.Guna2Button btngMostrar;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}