namespace pruebas
{
    partial class VerJugadores
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
            this.dgvjugadores = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btneditarjuga = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvjugadores)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvjugadores
            // 
            this.dgvjugadores.AllowUserToAddRows = false;
            this.dgvjugadores.AllowUserToDeleteRows = false;
            this.dgvjugadores.AllowUserToResizeColumns = false;
            this.dgvjugadores.AllowUserToResizeRows = false;
            this.dgvjugadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvjugadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvjugadores.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvjugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvjugadores.ColumnHeadersVisible = false;
            this.dgvjugadores.EnableHeadersVisualStyles = false;
            this.dgvjugadores.Location = new System.Drawing.Point(3, -2);
            this.dgvjugadores.MultiSelect = false;
            this.dgvjugadores.Name = "dgvjugadores";
            this.dgvjugadores.RowHeadersVisible = false;
            this.dgvjugadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvjugadores.ShowCellErrors = false;
            this.dgvjugadores.ShowCellToolTips = false;
            this.dgvjugadores.ShowEditingIcon = false;
            this.dgvjugadores.ShowRowErrors = false;
            this.dgvjugadores.Size = new System.Drawing.Size(722, 449);
            this.dgvjugadores.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btneditarjuga);
            this.panel1.Location = new System.Drawing.Point(731, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 449);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btneditarjuga
            // 
            this.btneditarjuga.Location = new System.Drawing.Point(3, 14);
            this.btneditarjuga.Name = "btneditarjuga";
            this.btneditarjuga.Size = new System.Drawing.Size(65, 45);
            this.btneditarjuga.TabIndex = 0;
            this.btneditarjuga.Text = "Editar";
            this.btneditarjuga.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(3, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VerJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvjugadores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerJugadores";
            this.Text = "VerJugadores";
            this.Load += new System.EventHandler(this.VerJugadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvjugadores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvjugadores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btneditarjuga;
        private System.Windows.Forms.Button button1;
    }
}