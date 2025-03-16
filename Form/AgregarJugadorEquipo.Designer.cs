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
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnquitar = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblequipoder = new System.Windows.Forms.Label();
            this.lblequipoizq = new System.Windows.Forms.Label();
            this.tblequiposizq = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblequiposder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblequiposizq)).BeginInit();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(305, 302);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(63, 27);
            this.btnguardar.TabIndex = 20;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // tblequiposder
            // 
            this.tblequiposder.AllowUserToAddRows = false;
            this.tblequiposder.AllowUserToDeleteRows = false;
            this.tblequiposder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblequiposder.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tblequiposder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblequiposder.Location = new System.Drawing.Point(407, 49);
            this.tblequiposder.Margin = new System.Windows.Forms.Padding(2);
            this.tblequiposder.Name = "tblequiposder";
            this.tblequiposder.ReadOnly = true;
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
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(305, 122);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(63, 27);
            this.btnagregar.TabIndex = 16;
            this.btnagregar.Text = "<<";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnquitar
            // 
            this.btnquitar.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquitar.Location = new System.Drawing.Point(305, 98);
            this.btnquitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(63, 27);
            this.btnquitar.TabIndex = 15;
            this.btnquitar.Text = ">>";
            this.btnquitar.UseVisualStyleBackColor = true;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
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
            this.lblequipoizq.Size = new System.Drawing.Size(116, 16);
            this.lblequipoizq.TabIndex = 12;
            this.lblequipoizq.Text = "Todos los Jugadores";
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
            // AgregarJugadorEquipo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.tblequiposizq);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.tblequiposder);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnquitar);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblequipoder);
            this.Controls.Add(this.lblequipoizq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarJugadorEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AgregarJugadorEquipo";
            this.Load += new System.EventHandler(this.AgregarJugadorEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblequiposder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblequiposizq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView tblequiposder;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnquitar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblequipoder;
        private System.Windows.Forms.Label lblequipoizq;
        private System.Windows.Forms.DataGridView tblequiposizq;
    }
}