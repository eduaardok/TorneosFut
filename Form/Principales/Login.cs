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
using System.Media;
using System.Xml.Linq;
using System.Runtime.Remoting.Contexts;
using Guna.UI2.WinForms;
using System.Web.UI.WebControls;
using TorneosFut.Class;
namespace TorneosFut
{
    public partial class Login : Form
    {
        static csConexion conec;
        static csEncriptar encrip;
        csDatos csDatos;
        Guna.UI2.WinForms.Guna2MessageDialog msg = new Guna.UI2.WinForms.Guna2MessageDialog();

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
        [DllImport("user32.dll")] private static extern void ReleaseCapture();
        [DllImport("user32.dll")] private static extern void SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        public Login()
        {
            conec = new csConexion();
            encrip = new csEncriptar();
            csDatos = new csDatos(conec.Usuario, conec.Clave);
            InitializeComponent();
        }
        private void X_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            panel1.Tag = "NoCambiar";
            panel2.Tag = "NoCambiar";
            panel3.Tag = "NoCambiar";
            panel4.Tag = "NoCambiar";
            panel5.Tag = "NoCambiar";
            panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
            panel1.Location = new Point(
                
                (this.ClientSize.Width - panel1.Width) / 2,
                (this.ClientSize.Height - panel1.Height) / 2
            );
            this.Resize += (s, ev) => {
                panel1.Location = new Point(
                    (this.ClientSize.Width - panel1.Width) / 2,
                    (this.ClientSize.Height - panel1.Height) / 2
                );
            };
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, panel2.Width, panel2.Height, 5, 5));
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
            this.Region= Region.FromHrgn(CreateRoundRectRgn(1, 1, this.Width, this.Height, 20, 20));
            Txtclave.PasswordChar = default;
            this.Tag= "NoCambiar";
            msg.Buttons = MessageDialogButtons.OK;
            msg.Icon = MessageDialogIcon.Information;
            msg.Style = MessageDialogStyle.Dark;
        }

        private void X_MouseLeave(object sender, EventArgs e)
        {
            //X.BackgroundImage = Properties.Resources.delete;
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
            msg.Buttons = MessageDialogButtons.OK;
            msg.Icon = MessageDialogIcon.Information;
            if (CamposVacios())
            {

                msg.Caption = "FALTA DE CREDENCIALES";
                msg.Text = "Ingrese un usuario y contraseña para acceder.";
                msg.Parent= this;
                msg.Show();
            }
            else
            {
                string password = encrip.Encriptar(Txtclave.Text, "futxpert");
                if (!csDatos.Login(txtUsuario.Text, password))
                {
                    msg.Caption = "CREDENCIALES INCORRECTAS";
                    msg.Text = "Credenciales incorrectas.";
                    msg.Parent = this;
                    msg.Show();
                }
                else
                {
                    msg.Caption = "INICIO DE SESION EXITOSO";
                    msg.Text = "Se inició sesión de forma correcta.";
                    msg.Parent = this;
                    msg.Show();
                    Principal n = new Principal(csDatos.ObtenerUsuarioBD(txtUsuario.Text), encrip.Desencriptar(csDatos.ObtenerClaveBD(txtUsuario.Text), "futxpert"), txtUsuario.Text);
                    this.Hide();
                    n.ShowDialog();
                    txtUsuario.Text = "";
                    Txtclave.Text = "";
                    this.Show();
                }
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
            //X.BackgroundImage = Properties.Resources.multiply;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left) // Verifica si el botón izquierdo del mouse está presionado
            //{
            //    // Mueve el formulario a la nueva posición
            //    this.Location = new Point(
            //        this.Location.X + e.X - (c.Width / 2),
            //        this.Location.Y + e.Y - (c.Height / 2));
            //}
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
        bool CamposVacios()
        {
            txtUsuario.Text = txtUsuario.Text.Trim();
            Txtclave.Text = Txtclave.Text.Trim();
            if (txtUsuario.Text == "" || txtUsuario.Text == "Usuario")
                return true;
            if (Txtclave.Text == "" || Txtclave.Text == "Contraseña")
                return true;
            return false;
        }
        private void Login_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Txtclave_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtclave_MouseClick(object sender, MouseEventArgs e)
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


        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            Color color = Color.FromArgb(80, 0, 0, 0);
            using (SolidBrush brush = new SolidBrush(color))
            {
                e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            this.WindowState = FormWindowState.Maximized;
        }

        private void panel5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}