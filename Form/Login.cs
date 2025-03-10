﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Xml.Linq;
using System.Runtime.Remoting.Contexts;
namespace TorneosFut
{
    public partial class Login : Form
    {
        static csConexion conec = new csConexion();
        static csEncriptar encrip = new csEncriptar();
        int click;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
          (
             int nleft,
             int nTop,
             int nRight,
             int nBottom,
             int nWidhtEllipse,
             int nHeightEllipse
          );
        public Login()
        {
            InitializeComponent();

        }
        private void X_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Start();
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 15;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
            Txtclave.UseSystemPasswordChar = false;
            Txtclave.PasswordChar = '*';
            txtUsuario.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, txtUsuario.Width, txtUsuario.Height, 5, 5));
            Txtclave.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, Txtclave.Width, Txtclave.Height, 5, 5));
            btnEntrar.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnEntrar.Width, btnEntrar.Height, 20, 20));
            Txtclave.PasswordChar = default;
        }

        private void X_MouseLeave(object sender, EventArgs e)
        {
            X.BackgroundImage = Properties.Resources.delete;
        }
        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
        }
        private void Ptbhide_Click(object sender, EventArgs e)
        {
            if (Txtclave.PasswordChar == '*')
            {
                Ptbhide.BackgroundImage = Properties.Resources.eyes;
                Txtclave.PasswordChar = default;
            }
            else if (Txtclave.PasswordChar == default)
            {
                Ptbhide.BackgroundImage = Properties.Resources.hide1;
                Txtclave.PasswordChar = '*';
            }
        }

        private void btnEntrar_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer Media = new SoundPlayer();
            Media.SoundLocation = "media\\door.wav";
            Media.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += .07;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Logeo();
        }
        void Logeo()
        {
            string password = encrip.Encriptar(Txtclave.Text, "futxpert");
            if (!conec.Login(txtUsuario.Text, password))
            { 
                MessageBox.Show("Credenciales incorrectas", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Se inició sesión de forma correcta");
                conec.RegistrarAuditoriaInicioSesion(conec.RetornaUser(txtUsuario.Text), true);
                bool admin = false;
                if (txtUsuario.Text == "admin")
                    admin = true; //para saber si el que ingresa es el admin
                //Inicio n = new Inicio(admin);
                Principal n = new Principal(conec.RetornaUser(txtUsuario.Text), encrip.Desencriptar(conec.RetornaClave(txtUsuario.Text), "futxpert"), txtUsuario.Text);
                this.Hide();
                n.ShowDialog();
                txtUsuario.Text = "";
                Txtclave.Text = "";
                this.Show();
            }
        }

        private void Txtclave_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Logeo();
        }

        private void txtUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Logeo();
        }

        private void X_MouseEnter(object sender, EventArgs e)
        {
            X.BackgroundImage = Properties.Resources.multiply;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Verifica si el botón izquierdo del mouse está presionado
            {
                // Mueve el formulario a la nueva posición
                this.Location = new Point(
                    this.Location.X + e.X - (c.Width / 2),
                    this.Location.Y + e.Y - (c.Height / 2));
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            click++;
            if (click == 1)
            {
                label3.Visible = true;
                label4.Visible = true;
                txtUsuario.Clear();
                Txtclave.Clear();
                Txtclave.PasswordChar = '*';
            }
        }

        private void Login_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}