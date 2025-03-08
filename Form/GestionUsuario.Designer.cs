namespace Usuarios
{
    partial class GestionUsuario
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDgv = new System.Windows.Forms.Panel();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btngLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.btngCrear = new Guna.UI2.WinForms.Guna2Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btngEditar = new Guna.UI2.WinForms.Guna2Button();
            this.btngMostrar = new Guna.UI2.WinForms.Guna2Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.panelDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDgv
            // 
            this.panelDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelDgv.Controls.Add(this.dgvUsuarios);
            this.panelDgv.Location = new System.Drawing.Point(29, 200);
            this.panelDgv.Name = "panelDgv";
            this.panelDgv.Size = new System.Drawing.Size(1415, 642);
            this.panelDgv.TabIndex = 4;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 3);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.ShowCellToolTips = false;
            this.dgvUsuarios.ShowEditingIcon = false;
            this.dgvUsuarios.Size = new System.Drawing.Size(1415, 642);
            this.dgvUsuarios.TabIndex = 5;
            this.dgvUsuarios.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsuarios_ColumnHeaderMouseClick);
            // 
            // btngLimpiar
            // 
            this.btngLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btngLimpiar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btngLimpiar.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btngLimpiar.CheckedState.FillColor = System.Drawing.Color.Black;
            this.btngLimpiar.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btngLimpiar.CustomBorderColor = System.Drawing.Color.White;
            this.btngLimpiar.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btngLimpiar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngLimpiar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngLimpiar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngLimpiar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngLimpiar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btngLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngLimpiar.ForeColor = System.Drawing.Color.White;
            this.btngLimpiar.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btngLimpiar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btngLimpiar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btngLimpiar.Location = new System.Drawing.Point(1264, 142);
            this.btngLimpiar.Name = "btngLimpiar";
            this.btngLimpiar.Size = new System.Drawing.Size(180, 36);
            this.btngLimpiar.TabIndex = 6;
            this.btngLimpiar.Text = "LIMPIAR";
            this.btngLimpiar.Click += new System.EventHandler(this.btngLimpiar_Click);
            // 
            // btngCrear
            // 
            this.btngCrear.BackColor = System.Drawing.Color.White;
            this.btngCrear.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btngCrear.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btngCrear.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btngCrear.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btngCrear.CustomBorderColor = System.Drawing.Color.White;
            this.btngCrear.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btngCrear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngCrear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngCrear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngCrear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngCrear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btngCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngCrear.ForeColor = System.Drawing.Color.Black;
            this.btngCrear.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btngCrear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btngCrear.Location = new System.Drawing.Point(30, 119);
            this.btngCrear.Name = "btngCrear";
            this.btngCrear.Size = new System.Drawing.Size(180, 59);
            this.btngCrear.TabIndex = 4;
            this.btngCrear.Text = "CREAR";
            this.btngCrear.Click += new System.EventHandler(this.btngCrear_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(831, 144);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(392, 31);
            this.txtFiltro.TabIndex = 7;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btngEditar
            // 
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
            this.btngEditar.Location = new System.Drawing.Point(290, 119);
            this.btngEditar.Name = "btngEditar";
            this.btngEditar.Size = new System.Drawing.Size(180, 59);
            this.btngEditar.TabIndex = 5;
            this.btngEditar.Text = "EDITAR";
            this.btngEditar.Click += new System.EventHandler(this.btngEditar_Click);
            // 
            // btngMostrar
            // 
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
            this.btngMostrar.Location = new System.Drawing.Point(535, 119);
            this.btngMostrar.Name = "btngMostrar";
            this.btngMostrar.Size = new System.Drawing.Size(180, 59);
            this.btngMostrar.TabIndex = 8;
            this.btngMostrar.Text = "MOSTRAR CLAVE";
            this.btngMostrar.Click += new System.EventHandler(this.btngMostrar_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblBusqueda.Location = new System.Drawing.Point(827, 118);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(81, 18);
            this.lblBusqueda.TabIndex = 9;
            this.lblBusqueda.Text = "BUSCAR:";
            // 
            // GestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1490, 911);
            this.ControlBox = false;
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.btngMostrar);
            this.Controls.Add(this.btngLimpiar);
            this.Controls.Add(this.panelDgv);
            this.Controls.Add(this.btngCrear);
            this.Controls.Add(this.btngEditar);
            this.Controls.Add(this.txtFiltro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1490, 911);
            this.MinimizeBox = false;
            this.Name = "GestionUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GestionUsuario_Load);
            this.panelDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelDgv;
        private Guna.UI2.WinForms.Guna2Button btngLimpiar;
        private Guna.UI2.WinForms.Guna2Button btngCrear;
        private System.Windows.Forms.TextBox txtFiltro;
        private Guna.UI2.WinForms.Guna2Button btngEditar;
        private Guna.UI2.WinForms.Guna2Button btngMostrar;
        private System.Windows.Forms.Label lblBusqueda;
        public System.Windows.Forms.DataGridView dgvUsuarios;
    }
}

