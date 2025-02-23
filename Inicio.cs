using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneosFut
{
    public partial class Inicio : Form
    {
        static bool esAdmin;
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
        Equipos equi;
        Usuarios usu;
        public Inicio(bool a) //parametro booleano para saber si el usuario que accedio es admin
        {
            esAdmin = a; //guardado en una variable estatica 
            InitializeComponent();
            equi = new Equipos();

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
        private void btnTorneo_Click(object sender, EventArgs e)
        {
            SubPanelTorneo.Visible = true;
            SubPanelEquipos.Visible = false;
            SubPanelJugadores.Visible = false;
            SubPanelArbitros.Visible = false;
            SubPanelEstadios.Visible = false;
            SubPanelReportes.Visible = false;
            SubPanelUsuarios.Visible = false;
            SubPanelCaja.Visible = false;

            btnTorneo.Visible = false;
            btnEquipos.Visible = true;
            btnJugadores.Visible = true;
            btnArbitros.Visible = true;
            btnEstadios.Visible = true;
            btnReportes.Visible = true;
            btnUsuarios.Visible = true;
            btnCaja.Visible = true;

            equi.Hide();
        }

        private void btnTor_Click(object sender, EventArgs e)
        {
            btnTorneo.Visible = true;
            SubPanelTorneo.Visible = false;
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            btnEquipos.Visible = false;
            SubPanelTorneo.Visible = false;
            SubPanelEquipos.Visible = true;
            SubPanelJugadores.Visible = false;
            SubPanelArbitros.Visible = false;
            SubPanelEstadios.Visible = false;
            SubPanelReportes.Visible = false;
            SubPanelUsuarios.Visible = false;
            SubPanelCaja.Visible = false;

            btnTorneo.Visible = true;
            btnEquipos.Visible = false;
            btnJugadores.Visible = true;
            btnArbitros.Visible = true;
            btnEstadios.Visible = true;
            btnReportes.Visible = true;
            btnUsuarios.Visible = true;
            btnCaja.Visible = true;

        }

        private void btnEqui_Click(object sender, EventArgs e)
        {
            btnEquipos.Visible = true;
            SubPanelEquipos.Visible = false;
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            btnJugadores.Visible = false;
            SubPanelTorneo.Visible = false;
            SubPanelEquipos.Visible = false;
            SubPanelJugadores.Visible = true;
            SubPanelArbitros.Visible = false;
            SubPanelEstadios.Visible = false;
            SubPanelReportes.Visible = false;
            SubPanelUsuarios.Visible = false;
            SubPanelCaja.Visible = false;

            btnTorneo.Visible = true;
            btnEquipos.Visible = true;
            btnJugadores.Visible = false;
            btnArbitros.Visible = true;
            btnEstadios.Visible = true;
            btnReportes.Visible = true;
            btnUsuarios.Visible = true;
            btnCaja.Visible = true;
        }

        private void btnJug_Click(object sender, EventArgs e)
        {
            btnJugadores.Visible = true;
            SubPanelJugadores.Visible = false;
        }

        private void btnArbitros_Click(object sender, EventArgs e)
        {
            btnArbitros.Visible = false;
            SubPanelTorneo.Visible = false;
            SubPanelEquipos.Visible = false;
            SubPanelJugadores.Visible = false;
            SubPanelArbitros.Visible = true;
            SubPanelEstadios.Visible = false;
            SubPanelReportes.Visible = false;
            SubPanelUsuarios.Visible = false;
            SubPanelCaja.Visible = false;

            btnTorneo.Visible = true;
            btnEquipos.Visible = true;
            btnJugadores.Visible = true;
            btnArbitros.Visible = false;
            btnEstadios.Visible = true;
            btnReportes.Visible = true;
            btnUsuarios.Visible = true;
            btnCaja.Visible = true;
        }

        private void btnArb_Click(object sender, EventArgs e)
        {
            btnArbitros.Visible = true;
            SubPanelArbitros.Visible = false;
        }

        private void btnEstadios_Click(object sender, EventArgs e)
        {
            btnEstadios.Visible = false;
            SubPanelTorneo.Visible = false;
            SubPanelEquipos.Visible = false;
            SubPanelJugadores.Visible = false;
            SubPanelArbitros.Visible = false;
            SubPanelEstadios.Visible = true;
            SubPanelReportes.Visible = false;
            SubPanelUsuarios.Visible = false;
            SubPanelCaja.Visible = false;

            btnTorneo.Visible = true;
            btnEquipos.Visible = true;
            btnJugadores.Visible = true;
            btnArbitros.Visible = true;
            btnEstadios.Visible = false;
            btnReportes.Visible = true;
            btnUsuarios.Visible = true;
            btnCaja.Visible = true;
        }

        private void btnEst_Click(object sender, EventArgs e)
        {
            btnEstadios.Visible = true;
            SubPanelEstadios.Visible = false;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            btnReportes.Visible = false;
            SubPanelTorneo.Visible = false;
            SubPanelEquipos.Visible = false;
            SubPanelJugadores.Visible = false;
            SubPanelArbitros.Visible = false;
            SubPanelEstadios.Visible = false;
            SubPanelReportes.Visible = true;
            SubPanelUsuarios.Visible = false;
            SubPanelCaja.Visible = false;

            btnTorneo.Visible = true;
            btnEquipos.Visible = true;
            btnJugadores.Visible = true;
            btnArbitros.Visible = true;
            btnEstadios.Visible = true;
            btnReportes.Visible = false;
            btnUsuarios.Visible = true;
            btnCaja.Visible = true;
        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            btnReportes.Visible = true;
            SubPanelReportes.Visible = false;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            btnUsuarios.Visible = false;
            SubPanelTorneo.Visible = false;
            SubPanelEquipos.Visible = false;
            SubPanelJugadores.Visible = false;
            SubPanelArbitros.Visible = false;
            SubPanelEstadios.Visible = false;
            SubPanelReportes.Visible = false;
            SubPanelUsuarios.Visible = true;
            SubPanelCaja.Visible = false;

            btnTorneo.Visible = true;
            btnEquipos.Visible = true;
            btnJugadores.Visible = true;
            btnArbitros.Visible = true;
            btnEstadios.Visible = true;
            btnReportes.Visible = true;
            btnUsuarios.Visible = false;
            btnCaja.Visible = true;
        }

        private void btnUsu_Click(object sender, EventArgs e)
        {
            btnUsuarios.Visible = true;
            SubPanelUsuarios.Visible = false;
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            btnCaja.Visible = false;
            SubPanelTorneo.Visible = false;
            SubPanelEquipos.Visible = false;
            SubPanelJugadores.Visible = false;
            SubPanelArbitros.Visible = false;
            SubPanelEstadios.Visible = false;
            SubPanelReportes.Visible = false;
            SubPanelUsuarios.Visible = false;
            SubPanelCaja.Visible = true;

            btnTorneo.Visible = true;
            btnEquipos.Visible = true;
            btnJugadores.Visible = true;
            btnArbitros.Visible = true;
            btnEstadios.Visible = true;
            btnReportes.Visible = true;
            btnUsuarios.Visible = true;
            btnCaja.Visible = false;
        }

        private void btnCj_Click(object sender, EventArgs e)
        {
            btnCaja.Visible = true;
            SubPanelCaja.Visible = false;
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            btnCaja.Visible = false;
            SubPanelTorneo.Visible = false;
            SubPanelEquipos.Visible = false;
            SubPanelJugadores.Visible = false;
            SubPanelArbitros.Visible = false;
            SubPanelEstadios.Visible = false;
            SubPanelReportes.Visible = false;
            SubPanelUsuarios.Visible = false;
            SubPanelCaja.Visible = false;

            btnTorneo.Visible = true;
            btnEquipos.Visible = true;
            btnJugadores.Visible = true;
            btnArbitros.Visible = true;
            btnEstadios.Visible = true;
            btnReportes.Visible = true;
            btnUsuarios.Visible = true;
            btnCaja.Visible = true;
        }

        private void btnAggEquipo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(PanelAggEquipo, equi);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += .07;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Maximized;
            this.FormBorderStyle= FormBorderStyle.None;
            timer1.Start();
            btnTorneo.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnTorneo.Width, btnTorneo.Height, 50, 50));
            btnTor.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnTor.Width, btnTor.Height, 10, 10));
            btnEquipos.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnEquipos.Width, btnEquipos.Height, 50, 50));
            btnEqui.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnEqui.Width, btnEqui.Height, 10, 10));
            btnJugadores.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnJugadores.Width, btnJugadores.Height, 50, 50));
            btnJug.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnJug.Width, btnJug.Height, 10, 10));
            btnArbitros.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnArbitros.Width, btnArbitros.Height, 50, 50));
            btnArb.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnArb.Width, btnArb.Height, 10, 10));
            btnEstadios.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnEstadios.Width, btnEstadios.Height, 50, 50));
            btnEst.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnEst.Width, btnEst.Height, 10, 10));
            btnReportes.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnReportes.Width, btnReportes.Height, 50, 50));
            btnRep.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnRep.Width, btnRep.Height, 10, 10));
            btnUsuarios.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnUsuarios.Width, btnUsuarios.Height, 50, 50));
            btnUsu.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnUsu.Width, btnUsu.Height, 10, 10));
            btnCaja.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnCaja.Width, btnCaja.Height, 50, 50));
            btnCj.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnCj.Width, btnCj.Height, 10, 10));
            btnConfiguracion.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnConfiguracion.Width, btnConfiguracion.Height, 50, 50));
            AccesoAdmin();
        }
        private void btnTorneo_MouseLeave(object sender, EventArgs e)
        {
            btnTorneo.BackColor = ColorTranslator.FromHtml("#FB0E8C");
        }


        private void btnEquipos_MouseLeave(object sender, EventArgs e)
        {
            btnEquipos.BackColor = ColorTranslator.FromHtml("#FB0E8C");
        }


        private void btnJugadores_MouseLeave(object sender, EventArgs e)
        {
            btnJugadores.BackColor = ColorTranslator.FromHtml("#FB0E8C");
        }
        private void btnArbitros_MouseLeave(object sender, EventArgs e)
        {
            btnArbitros.BackColor = ColorTranslator.FromHtml("#FB0E8C");
        }
        private void btnEstadios_MouseLeave(object sender, EventArgs e)
        {
            btnEstadios.BackColor = ColorTranslator.FromHtml("#FB0E8C");
        }

        private void btnReportes_MouseLeave(object sender, EventArgs e)
        {
            btnReportes.BackColor = ColorTranslator.FromHtml("#FB0E8C");
        }

        private void btnUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = ColorTranslator.FromHtml("#FB0E8C");
        }

        private void btnCaja_MouseLeave(object sender, EventArgs e)
        {
            btnCaja.BackColor = ColorTranslator.FromHtml("#FB0E8C");
        }

        private void btnCaja_MouseEnter(object sender, EventArgs e)
        {
            btnCaja.BackColor = ColorTranslator.FromHtml("#7C7C7C");
        }

        private void btnReportes_MouseEnter(object sender, EventArgs e)
        {
            btnReportes.BackColor = ColorTranslator.FromHtml("#7C7C7C");
        }

        private void btnEstadios_MouseEnter(object sender, EventArgs e)
        {
            btnEstadios.BackColor = ColorTranslator.FromHtml("#7C7C7C");

        }

        private void btnArbitros_MouseEnter(object sender, EventArgs e)
        {
            btnArbitros.BackColor = ColorTranslator.FromHtml("#7C7C7C");

        }

        private void btnJugadores_MouseEnter(object sender, EventArgs e)
        {
            btnJugadores.BackColor = ColorTranslator.FromHtml("#7C7C7C")   ;
        }

        private void btnEquipos_MouseEnter(object sender, EventArgs e)
        {
            btnEquipos.BackColor = ColorTranslator.FromHtml("#7C7C7C");
        }

        private void btnTorneo_MouseEnter(object sender, EventArgs e)
        {
            btnTorneo.BackColor = ColorTranslator.FromHtml("#7C7C7C");
        }
        private void btnUsuarios_MouseEnter(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = ColorTranslator.FromHtml("#7C7C7C");
        }

        private void btnConfiguracion_MouseLeave(object sender, EventArgs e)
        {
            btnConfiguracion.BackColor = ColorTranslator.FromHtml("#FB0E8C");
        }

        private void btnConfiguracion_MouseEnter(object sender, EventArgs e)
        {
            btnConfiguracion.BackColor = ColorTranslator.FromHtml("#7C7C7C");
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            //manejo de usuarios
            usu = new Usuarios();

            AbrirFormEnPanel(PanelAggEquipo, usu);

        }
        void AccesoAdmin()
        {
            btnUsuarios.Enabled = esAdmin;
            btnUsuario.Enabled = esAdmin;
            btnAggUsuario.Enabled = esAdmin;
        }
    }
}
