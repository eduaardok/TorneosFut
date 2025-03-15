namespace TorneosFut
{
    partial class Estadio
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
            this.txtBuscarJugador = new System.Windows.Forms.TextBox();
            this.panelDgv = new System.Windows.Forms.Panel();
            this.dgvJugador = new System.Windows.Forms.DataGridView();
            this.btnAgregarJugador = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarJugador
            // 
            this.txtBuscarJugador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarJugador.Font = new System.Drawing.Font("Onest Light", 20F);
            this.txtBuscarJugador.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscarJugador.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBuscarJugador.Location = new System.Drawing.Point(232, 124);
            this.txtBuscarJugador.Multiline = true;
            this.txtBuscarJugador.Name = "txtBuscarJugador";
            this.txtBuscarJugador.Size = new System.Drawing.Size(463, 48);
            this.txtBuscarJugador.TabIndex = 20;
            this.txtBuscarJugador.Text = "Buscar por nombre del Estadio";
            // 
            // panelDgv
            // 
            this.panelDgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelDgv.Controls.Add(this.dgvJugador);
            this.panelDgv.Location = new System.Drawing.Point(176, 272);
            this.panelDgv.Name = "panelDgv";
            this.panelDgv.Size = new System.Drawing.Size(1186, 601);
            this.panelDgv.TabIndex = 19;
            // 
            // dgvJugador
            // 
            this.dgvJugador.AllowUserToAddRows = false;
            this.dgvJugador.AllowUserToDeleteRows = false;
            this.dgvJugador.AllowUserToResizeColumns = false;
            this.dgvJugador.AllowUserToResizeRows = false;
            this.dgvJugador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJugador.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJugador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJugador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvJugador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJugador.EnableHeadersVisualStyles = false;
            this.dgvJugador.Location = new System.Drawing.Point(0, 0);
            this.dgvJugador.MultiSelect = false;
            this.dgvJugador.Name = "dgvJugador";
            this.dgvJugador.ReadOnly = true;
            this.dgvJugador.RowHeadersVisible = false;
            this.dgvJugador.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.dgvJugador.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJugador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJugador.ShowCellToolTips = false;
            this.dgvJugador.ShowEditingIcon = false;
            this.dgvJugador.Size = new System.Drawing.Size(1186, 601);
            this.dgvJugador.TabIndex = 5;
            // 
            // btnAgregarJugador
            // 
            this.btnAgregarJugador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarJugador.BackColor = System.Drawing.Color.White;
            this.btnAgregarJugador.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAgregarJugador.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnAgregarJugador.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnAgregarJugador.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarJugador.CustomBorderColor = System.Drawing.Color.White;
            this.btnAgregarJugador.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnAgregarJugador.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarJugador.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarJugador.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarJugador.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarJugador.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnAgregarJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarJugador.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarJugador.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnAgregarJugador.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnAgregarJugador.Location = new System.Drawing.Point(247, 178);
            this.btnAgregarJugador.Name = "btnAgregarJugador";
            this.btnAgregarJugador.Size = new System.Drawing.Size(222, 59);
            this.btnAgregarJugador.TabIndex = 18;
            this.btnAgregarJugador.Text = "AGREGAR ESTADIO";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.CheckedState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Button1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(481, 178);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(214, 59);
            this.guna2Button1.TabIndex = 17;
            this.guna2Button1.Text = "EDITAR  ESTADIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Onest Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 34);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lista de Estadios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::TorneosFut.Properties.Resources.IconoLupa;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(176, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 49);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Estadio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1490, 911);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBuscarJugador);
            this.Controls.Add(this.panelDgv);
            this.Controls.Add(this.btnAgregarJugador);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estadio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Estadio";
            this.Load += new System.EventHandler(this.Estadio_Load);
            this.panelDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscarJugador;
        private System.Windows.Forms.Panel panelDgv;
        public System.Windows.Forms.DataGridView dgvJugador;
        private Guna.UI2.WinForms.Guna2Button btnAgregarJugador;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        public System.Windows.Forms.Label label2;
    }
}