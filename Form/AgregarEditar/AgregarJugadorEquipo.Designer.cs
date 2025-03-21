namespace TorneosFut
{
    partial class AgregarJugadorEquipo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuitar = new Guna.UI2.WinForms.Guna2Button();
            this.numDorsal = new System.Windows.Forms.NumericUpDown();
            this.lblDorsal = new System.Windows.Forms.Label();
            this.btngCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.tblequiposizq = new System.Windows.Forms.DataGridView();
            this.btnguardar = new System.Windows.Forms.Button();
            this.tblequiposder = new System.Windows.Forms.DataGridView();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblequipoder = new System.Windows.Forms.Label();
            this.lblequipoizq = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDorsal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblequiposizq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblequiposder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.lblEncabezado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 31);
            this.panel1.TabIndex = 56;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Onest Bold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblEncabezado.Location = new System.Drawing.Point(3, 0);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(330, 26);
            this.lblEncabezado.TabIndex = 34;
            this.lblEncabezado.Text = "AGREGAR JUGADOR A EQUIPO";
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.White;
            this.btnAgregar.Font = new System.Drawing.Font("Onest Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnAgregar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnAgregar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(321, 99);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(72, 36);
            this.btnAgregar.TabIndex = 78;
            this.btnAgregar.Text = ">>";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuitar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuitar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuitar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuitar.FillColor = System.Drawing.Color.White;
            this.btnQuitar.Font = new System.Drawing.Font("Onest Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.Color.Black;
            this.btnQuitar.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnQuitar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btnQuitar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnQuitar.Location = new System.Drawing.Point(321, 160);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(72, 36);
            this.btnQuitar.TabIndex = 77;
            this.btnQuitar.Text = "<<";
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // numDorsal
            // 
            this.numDorsal.Location = new System.Drawing.Point(321, 283);
            this.numDorsal.Name = "numDorsal";
            this.numDorsal.Size = new System.Drawing.Size(84, 20);
            this.numDorsal.TabIndex = 76;
            // 
            // lblDorsal
            // 
            this.lblDorsal.AutoSize = true;
            this.lblDorsal.BackColor = System.Drawing.Color.Transparent;
            this.lblDorsal.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDorsal.Location = new System.Drawing.Point(317, 256);
            this.lblDorsal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDorsal.Name = "lblDorsal";
            this.lblDorsal.Size = new System.Drawing.Size(74, 24);
            this.lblDorsal.TabIndex = 75;
            this.lblDorsal.Text = "Dorsal:";
            // 
            // btngCancelar
            // 
            this.btngCancelar.Animated = true;
            this.btngCancelar.BackColor = System.Drawing.Color.White;
            this.btngCancelar.BorderRadius = 20;
            this.btngCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btngCancelar.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btngCancelar.ForeColor = System.Drawing.Color.Black;
            this.btngCancelar.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btngCancelar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btngCancelar.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btngCancelar.Location = new System.Drawing.Point(26, 393);
            this.btngCancelar.Name = "btngCancelar";
            this.btngCancelar.Size = new System.Drawing.Size(141, 41);
            this.btngCancelar.TabIndex = 74;
            this.btngCancelar.Text = "CANCELAR";
            this.btngCancelar.Click += new System.EventHandler(this.btngCancelar_Click);
            // 
            // tblequiposizq
            // 
            this.tblequiposizq.AllowUserToAddRows = false;
            this.tblequiposizq.AllowUserToDeleteRows = false;
            this.tblequiposizq.AllowUserToResizeColumns = false;
            this.tblequiposizq.AllowUserToResizeRows = false;
            this.tblequiposizq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblequiposizq.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblequiposizq.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tblequiposizq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblequiposizq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblequiposizq.Location = new System.Drawing.Point(69, 61);
            this.tblequiposizq.Margin = new System.Windows.Forms.Padding(2);
            this.tblequiposizq.Name = "tblequiposizq";
            this.tblequiposizq.ReadOnly = true;
            this.tblequiposizq.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblequiposizq.RowHeadersVisible = false;
            this.tblequiposizq.RowTemplate.Height = 24;
            this.tblequiposizq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblequiposizq.Size = new System.Drawing.Size(180, 317);
            this.tblequiposizq.TabIndex = 73;
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnguardar.Location = new System.Drawing.Point(298, 382);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(107, 52);
            this.btnguardar.TabIndex = 72;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // tblequiposder
            // 
            this.tblequiposder.AllowUserToAddRows = false;
            this.tblequiposder.AllowUserToDeleteRows = false;
            this.tblequiposder.AllowUserToResizeColumns = false;
            this.tblequiposder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblequiposder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblequiposder.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tblequiposder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblequiposder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblequiposder.Location = new System.Drawing.Point(451, 61);
            this.tblequiposder.Margin = new System.Windows.Forms.Padding(2);
            this.tblequiposder.Name = "tblequiposder";
            this.tblequiposder.ReadOnly = true;
            this.tblequiposder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblequiposder.RowHeadersVisible = false;
            this.tblequiposder.RowTemplate.Height = 24;
            this.tblequiposder.Size = new System.Drawing.Size(180, 317);
            this.tblequiposder.TabIndex = 71;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbltotal.Location = new System.Drawing.Point(447, 380);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(65, 24);
            this.lbltotal.TabIndex = 69;
            this.lbltotal.Text = "Total: ";
            // 
            // lblequipoder
            // 
            this.lblequipoder.AutoSize = true;
            this.lblequipoder.BackColor = System.Drawing.Color.Transparent;
            this.lblequipoder.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblequipoder.Location = new System.Drawing.Point(434, 35);
            this.lblequipoder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblequipoder.Name = "lblequipoder";
            this.lblequipoder.Size = new System.Drawing.Size(224, 24);
            this.lblequipoder.TabIndex = 68;
            this.lblequipoder.Text = "Jugadores en el Equipo";
            // 
            // lblequipoizq
            // 
            this.lblequipoizq.AutoSize = true;
            this.lblequipoizq.BackColor = System.Drawing.Color.Transparent;
            this.lblequipoizq.Font = new System.Drawing.Font("Onest Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblequipoizq.Location = new System.Drawing.Point(65, 35);
            this.lblequipoizq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblequipoizq.Name = "lblequipoizq";
            this.lblequipoizq.Size = new System.Drawing.Size(206, 24);
            this.lblequipoizq.TabIndex = 67;
            this.lblequipoizq.Text = "Jugadores sin equipo";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(681, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 409);
            this.panel4.TabIndex = 100;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 440);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(681, 10);
            this.panel3.TabIndex = 99;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 419);
            this.panel2.TabIndex = 98;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // AgregarJugadorEquipo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.tblequiposizq);
            this.Controls.Add(this.numDorsal);
            this.Controls.Add(this.lblequipoizq);
            this.Controls.Add(this.lblDorsal);
            this.Controls.Add(this.lblequipoder);
            this.Controls.Add(this.btngCancelar);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.tblequiposder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarJugadorEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AgregarJugadorEquipo";
            this.Load += new System.EventHandler(this.AgregarJugadorEquipo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDorsal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblequiposizq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblequiposder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblEncabezado;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnQuitar;
        private System.Windows.Forms.NumericUpDown numDorsal;
        private System.Windows.Forms.Label lblDorsal;
        private Guna.UI2.WinForms.Guna2Button btngCancelar;
        private System.Windows.Forms.DataGridView tblequiposizq;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView tblequiposder;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblequipoder;
        private System.Windows.Forms.Label lblequipoizq;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}