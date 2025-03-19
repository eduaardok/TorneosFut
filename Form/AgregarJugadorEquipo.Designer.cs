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
            this.btnguardar = new System.Windows.Forms.Button();
            this.tblequiposder = new System.Windows.Forms.DataGridView();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblequipoder = new System.Windows.Forms.Label();
            this.lblequipoizq = new System.Windows.Forms.Label();
            this.tblequiposizq = new System.Windows.Forms.DataGridView();
            this.btngCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.lblDorsal = new System.Windows.Forms.Label();
            this.numDorsal = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuitar = new Guna.UI2.WinForms.Guna2Button();
            this.lbBorde = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblequiposder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblequiposizq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDorsal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Onest Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(290, 387);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(107, 52);
            this.btnguardar.TabIndex = 20;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // tblequiposder
            // 
            this.tblequiposder.AllowUserToAddRows = false;
            this.tblequiposder.AllowUserToDeleteRows = false;
            this.tblequiposder.AllowUserToResizeColumns = false;
            this.tblequiposder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblequiposder.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tblequiposder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblequiposder.Location = new System.Drawing.Point(407, 49);
            this.tblequiposder.Margin = new System.Windows.Forms.Padding(2);
            this.tblequiposder.Name = "tblequiposder";
            this.tblequiposder.ReadOnly = true;
            this.tblequiposder.RowHeadersVisible = false;
            this.tblequiposder.RowTemplate.Height = 24;
            this.tblequiposder.Size = new System.Drawing.Size(180, 317);
            this.tblequiposder.TabIndex = 19;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(99, 371);
            this.btnnuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(56, 19);
            this.btnnuevo.TabIndex = 17;
            this.btnnuevo.Text = "Nuevo equipo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(404, 371);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(37, 13);
            this.lbltotal.TabIndex = 14;
            this.lbltotal.Text = "Total: ";
            // 
            // lblequipoder
            // 
            this.lblequipoder.AutoSize = true;
            this.lblequipoder.BackColor = System.Drawing.Color.Transparent;
            this.lblequipoder.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblequipoder.Location = new System.Drawing.Point(405, 32);
            this.lblequipoder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblequipoder.Name = "lblequipoder";
            this.lblequipoder.Size = new System.Drawing.Size(133, 16);
            this.lblequipoder.TabIndex = 13;
            this.lblequipoder.Text = "Jugadores en el Equipo";
            // 
            // lblequipoizq
            // 
            this.lblequipoizq.AutoSize = true;
            this.lblequipoizq.BackColor = System.Drawing.Color.Transparent;
            this.lblequipoizq.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblequipoizq.Location = new System.Drawing.Point(97, 32);
            this.lblequipoizq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblequipoizq.Name = "lblequipoizq";
            this.lblequipoizq.Size = new System.Drawing.Size(122, 16);
            this.lblequipoizq.TabIndex = 12;
            this.lblequipoizq.Text = "Jugadores sin equipo";
            // 
            // tblequiposizq
            // 
            this.tblequiposizq.AllowUserToAddRows = false;
            this.tblequiposizq.AllowUserToDeleteRows = false;
            this.tblequiposizq.AllowUserToResizeColumns = false;
            this.tblequiposizq.AllowUserToResizeRows = false;
            this.tblequiposizq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblequiposizq.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tblequiposizq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblequiposizq.Location = new System.Drawing.Point(99, 49);
            this.tblequiposizq.Margin = new System.Windows.Forms.Padding(2);
            this.tblequiposizq.Name = "tblequiposizq";
            this.tblequiposizq.ReadOnly = true;
            this.tblequiposizq.RowHeadersVisible = false;
            this.tblequiposizq.RowTemplate.Height = 24;
            this.tblequiposizq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblequiposizq.Size = new System.Drawing.Size(180, 317);
            this.tblequiposizq.TabIndex = 21;
            // 
            // btngCancelar
            // 
            this.btngCancelar.BackColor = System.Drawing.Color.White;
            this.btngCancelar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btngCancelar.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btngCancelar.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btngCancelar.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btngCancelar.CustomBorderColor = System.Drawing.Color.White;
            this.btngCancelar.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btngCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btngCancelar.Font = new System.Drawing.Font("Onest Bold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngCancelar.ForeColor = System.Drawing.Color.Black;
            this.btngCancelar.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btngCancelar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            this.btngCancelar.Location = new System.Drawing.Point(-1, 409);
            this.btngCancelar.Name = "btngCancelar";
            this.btngCancelar.Size = new System.Drawing.Size(132, 41);
            this.btngCancelar.TabIndex = 32;
            this.btngCancelar.Text = "CANCELAR";
            this.btngCancelar.Click += new System.EventHandler(this.btngCancelar_Click);
            // 
            // lblDorsal
            // 
            this.lblDorsal.AutoSize = true;
            this.lblDorsal.BackColor = System.Drawing.Color.Transparent;
            this.lblDorsal.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDorsal.Location = new System.Drawing.Point(319, 264);
            this.lblDorsal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDorsal.Name = "lblDorsal";
            this.lblDorsal.Size = new System.Drawing.Size(44, 16);
            this.lblDorsal.TabIndex = 34;
            this.lblDorsal.Text = "Dorsal:";
            // 
            // numDorsal
            // 
            this.numDorsal.Location = new System.Drawing.Point(302, 293);
            this.numDorsal.Name = "numDorsal";
            this.numDorsal.Size = new System.Drawing.Size(84, 20);
            this.numDorsal.TabIndex = 35;
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
            this.btnAgregar.Location = new System.Drawing.Point(306, 121);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(72, 36);
            this.btnAgregar.TabIndex = 54;
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
            this.btnQuitar.Location = new System.Drawing.Point(306, 182);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(72, 36);
            this.btnQuitar.TabIndex = 53;
            this.btnQuitar.Text = "<<";
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lbBorde
            // 
            this.lbBorde.Location = new System.Drawing.Point(0, 0);
            this.lbBorde.Name = "lbBorde";
            this.lbBorde.Size = new System.Drawing.Size(684, 450);
            this.lbBorde.TabIndex = 55;
            this.lbBorde.Paint += new System.Windows.Forms.PaintEventHandler(this.lbBorde_Paint);
            // 
            // AgregarJugadorEquipo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.numDorsal);
            this.Controls.Add(this.lblDorsal);
            this.Controls.Add(this.btngCancelar);
            this.Controls.Add(this.tblequiposizq);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.tblequiposder);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblequipoder);
            this.Controls.Add(this.lblequipoizq);
            this.Controls.Add(this.lbBorde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarJugadorEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AgregarJugadorEquipo";
            this.Load += new System.EventHandler(this.AgregarJugadorEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblequiposder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblequiposizq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDorsal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView tblequiposder;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblequipoder;
        private System.Windows.Forms.Label lblequipoizq;
        private System.Windows.Forms.DataGridView tblequiposizq;
        private Guna.UI2.WinForms.Guna2Button btngCancelar;
        private System.Windows.Forms.Label lblDorsal;
        private System.Windows.Forms.NumericUpDown numDorsal;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnQuitar;
        private System.Windows.Forms.Label lbBorde;
    }
}