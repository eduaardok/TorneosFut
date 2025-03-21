﻿namespace TorneosFut
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscarJugador = new System.Windows.Forms.TextBox();
            this.panelDgv = new System.Windows.Forms.Panel();
            this.dgvEstadio = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarJugador
            // 
            this.txtBuscarJugador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarJugador.Font = new System.Drawing.Font("Onest Light", 20F);
            this.txtBuscarJugador.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscarJugador.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBuscarJugador.Location = new System.Drawing.Point(180, 63);
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
            this.panelDgv.Controls.Add(this.dgvEstadio);
            this.panelDgv.Location = new System.Drawing.Point(124, 211);
            this.panelDgv.Name = "panelDgv";
            this.panelDgv.Size = new System.Drawing.Size(1186, 601);
            this.panelDgv.TabIndex = 19;
            // 
            // dgvEstadio
            // 
            this.dgvEstadio.AllowUserToAddRows = false;
            this.dgvEstadio.AllowUserToDeleteRows = false;
            this.dgvEstadio.AllowUserToResizeColumns = false;
            this.dgvEstadio.AllowUserToResizeRows = false;
            this.dgvEstadio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstadio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEstadio.BackgroundColor = System.Drawing.Color.White;
            this.dgvEstadio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstadio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEstadio.ColumnHeadersHeight = 40;
            this.dgvEstadio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEstadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstadio.EnableHeadersVisualStyles = false;
            this.dgvEstadio.Location = new System.Drawing.Point(0, 0);
            this.dgvEstadio.MultiSelect = false;
            this.dgvEstadio.Name = "dgvEstadio";
            this.dgvEstadio.ReadOnly = true;
            this.dgvEstadio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvEstadio.RowHeadersVisible = false;
            this.dgvEstadio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.dgvEstadio.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEstadio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstadio.ShowCellToolTips = false;
            this.dgvEstadio.ShowEditingIcon = false;
            this.dgvEstadio.Size = new System.Drawing.Size(1186, 601);
            this.dgvEstadio.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAgregar.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnAgregar.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnAgregar.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.CustomBorderColor = System.Drawing.Color.White;
            this.btnAgregar.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnAgregar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btnAgregar.Location = new System.Drawing.Point(195, 117);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(222, 59);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "AGREGAR ESTADIO";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnEditar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEditar.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnEditar.CheckedState.FillColor = System.Drawing.Color.Black;
            this.btnEditar.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnEditar.CustomBorderColor = System.Drawing.Color.White;
            this.btnEditar.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnEditar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btnEditar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(429, 117);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(214, 59);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "EDITAR  ESTADIO";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            // ptbImagen
            // 
            this.ptbImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbImagen.Location = new System.Drawing.Point(1136, 41);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(174, 164);
            this.ptbImagen.TabIndex = 22;
            this.ptbImagen.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::TorneosFut.Properties.Resources.IconoLupa;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(124, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 49);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Estadio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.ptbImagen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBuscarJugador);
            this.Controls.Add(this.panelDgv);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estadio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Estadio";
            this.Load += new System.EventHandler(this.Estadio_Load);
            this.panelDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscarJugador;
        private System.Windows.Forms.Panel panelDgv;
        public System.Windows.Forms.DataGridView dgvEstadio;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptbImagen;
    }
}