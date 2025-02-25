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
    public partial class Principal: Form
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
        static bool esAdmin;
        public Principal(bool a=true)
        {
            esAdmin = a;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.Manual;
            this.Bounds = Screen.PrimaryScreen.WorkingArea;
        }
        public static void AbrirFormEnPanel(Panel panel, Form formHijo)
        {
            if (panel.Controls.Count > 0)
                panel.Controls.Clear(); // Limpia cualquier contenido previo

            formHijo.TopLevel = false;  // Indica que no es un formulario independiente
            formHijo.Dock = DockStyle.Fill; // Ajusta al tamaño del panel
            panel.Controls.Add(formHijo); // Agrega el formulario al panel
            panel.Tag = formHijo; // Asocia el formulario con el panel
            formHijo.BringToFront(); // Lo trae al frente
            formHijo.Show(); // Muestra el formulario dentro del panel
        }
        private void Principal_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.Manual;
            this.Bounds = Screen.PrimaryScreen.WorkingArea;
        }
        private void btnEquipos_MouseEnter(object sender, EventArgs e)
        {
            btnEquipos.BackColor = ColorTranslator.FromHtml("#FB038C");
        }

        private void btnTorneos_MouseEnter(object sender, EventArgs e)
        {
            btnTorneos.BackColor = ColorTranslator.FromHtml("#FB038C");
        }

        private void btnJugadores_MouseEnter(object sender, EventArgs e)
        {
            btnJugadores.BackColor = ColorTranslator.FromHtml("#FB038C");
        }

        private void btnPartidos_MouseEnter(object sender, EventArgs e)
        {
            btnPartidos.BackColor = ColorTranslator.FromHtml("#FB038C");
        }

        private void btnEstadios_MouseEnter(object sender, EventArgs e)
        {
            btnEstadios.BackColor = ColorTranslator.FromHtml("#FB038C");
        }

        private void btnArbitros_MouseEnter(object sender, EventArgs e)
        {
            btnArbitros.BackColor = ColorTranslator.FromHtml("#FB038C");
        }

        private void btnCaja_MouseEnter(object sender, EventArgs e)
        {
            btnCaja.BackColor = ColorTranslator.FromHtml("#FB038C");
        }

        

        private void btnTorneos_MouseLeave(object sender, EventArgs e)
        {
            btnTorneos.BackColor = Color.FromArgb(20, 25, 29);
        }

        private void btnEquipos_MouseLeave(object sender, EventArgs e)
        {
            btnEquipos.BackColor = Color.FromArgb(20, 25, 29);

        }

        private void btnJugadores_MouseLeave(object sender, EventArgs e)
        {
            btnJugadores.BackColor = Color.FromArgb(20, 25, 29);

        }

        private void btnPartidos_MouseLeave(object sender, EventArgs e)
        {
            btnPartidos.BackColor = Color.FromArgb(20, 25, 29);

        }

        private void btnEstadios_MouseLeave(object sender, EventArgs e)
        {
            btnEstadios.BackColor = Color.FromArgb(20, 25, 29);

        }

        private void btnArbitros_MouseLeave(object sender, EventArgs e)
        {
            btnArbitros.BackColor = Color.FromArgb(20, 25, 29);

        }

        private void btnCaja_MouseLeave(object sender, EventArgs e)
        {
            btnCaja.BackColor = Color.FromArgb(20, 25, 29);

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.Manual;
            this.Bounds = Screen.PrimaryScreen.WorkingArea;
             //this.WindowState = FormWindowState.Maximized;
             //this.FormBorderStyle = FormBorderStyle.None;
           //  timer1.Start();
            btnTorneos.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnTorneos.Width, btnTorneos.Height, 50, 50));
            btnPartidos.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnPartidos.Width, btnPartidos.Height, 50, 50));

            btnEquipos.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnEquipos.Width, btnEquipos.Height, 50, 50));
             btnJugadores.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnJugadores.Width, btnJugadores.Height, 50, 50));
           //  btnEntrenador.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnEntrenador.Width, btnEntrenador.Height, 50, 50));
             btnEstadios.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnEstadios.Width, btnEstadios.Height, 50, 50));
            // btnReportes.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnReportes.Width, btnReportes.Height, 50, 50));
             btnUsuarios.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnUsuarios.Width, btnUsuarios.Height, 50, 50));
             btnCaja.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnCaja.Width, btnCaja.Height, 50, 50));
            // btnEntrenador.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnEntrenador.Width, btnEntrenador.Height, 50, 50));
            // btnConfiguracion.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnConfiguracion.Width, btnConfiguracion.Height, 50, 50));
             btnArbitros.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnArbitros.Width, btnArbitros.Height, 50, 50));
            btnEntrenadores.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnEntrenadores.Width, btnEntrenadores.Height, 50, 50));

            // AccesoAdmin();
        }
        void AccesoAdmin()
        {
            btnUsuarios.Enabled = esAdmin;
        }

        private void btnEntrenadores_MouseLeave(object sender, EventArgs e)
        {
            btnEntrenadores.BackColor = Color.FromArgb(20, 25, 29);
        }

        private void btnEntrenadores_MouseEnter(object sender, EventArgs e)
        {
            btnEntrenadores.BackColor = ColorTranslator.FromHtml("#FB038C");
        }

        private void btnUsuarios_MouseEnter(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = ColorTranslator.FromHtml("#FB038C");
        }

        private void btnUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = Color.FromArgb(20, 25, 29);

        }
    }
}
