using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneosFut
{
    public partial class Login : Form
    {
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
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 15; // Adjust the value to change the roundness of the corners

            // Create a rounded rectangle path using the form's size and radius
            path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90); // Top-right corner
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90); // Bottom-right corner
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90); // Bottom-left corner

            path.CloseFigure();
            // Create a region with the rounded rectangle path and apply it to the form
            this.Region = new Region(path);
            Txtclave.UseSystemPasswordChar = false;
            Txtclave.PasswordChar= '*';
            txtUsuario.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, txtUsuario.Width, txtUsuario.Height, 5, 5));
            Txtclave.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, Txtclave.Width, Txtclave.Height, 5, 5));
            btnEntrar.Region= Region.FromHrgn(CreateRoundRectRgn(1, 1, btnEntrar.Width, btnEntrar.Height, 20, 20));
        }
        private void X_MouseHover(object sender, EventArgs e)
        {
                X.BackgroundImage = Properties.Resources.multiply;
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

                Ptbhide.BackgroundImage = Properties.Resources.show;
                Txtclave.PasswordChar = default;
            }
            else if (Txtclave.PasswordChar == default)
            {
                Ptbhide.BackgroundImage = Properties.Resources.hide;
                Txtclave.PasswordChar = '*';
            } 
        }
    }
}



