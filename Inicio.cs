using pruebas;
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
        VerJugadores verJu;
        AgregarJugadores aggJu;
        public Inicio(bool a) //parametro booleano para saber si el usuario que accedio es admin
        {
            esAdmin = a; //guardado en una variable estatica 
            InitializeComponent();
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
            rjDropdownMenu1.Show(btnTorneo, btnTorneo.Width, 0);

        }

        private void btnTor_Click(object sender, EventArgs e)
        {
            btnTorneo.Visible = true;
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            rjDropdownMenu2.Show(btnEquipos, btnEquipos.Width, 0);

        }

        private void btnEqui_Click(object sender, EventArgs e)
        {
            btnEquipos.Visible = true;
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            rjDropdownMenu3.Show(btnJugadores, btnJugadores.Width, 0);

        }

        private void btnJug_Click(object sender, EventArgs e)
        {
            btnJugadores.Visible = true;
        }

        private void btnArbitros_Click(object sender, EventArgs e)
        {
            rjDropdownMenu4.Show(btnArbitros, btnArbitros.Width, 0);
        }

        private void btnArb_Click(object sender, EventArgs e)
        {
            btnEntrenador.Visible = true;
        }

        private void btnEstadios_Click(object sender, EventArgs e)
        {
            rjDropdownMenu5.Show(btnEstadios, btnEstadios.Width, 0);
        }

        private void btnEst_Click(object sender, EventArgs e)
        {
            btnEstadios.Visible = true;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            rjDropdownMenu6.Show(btnReportes, btnReportes.Width, 0);
        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            btnReportes.Visible = true;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            rjDropdownMenu7.Show(btnUsuarios, btnUsuarios.Width, 0);
        }

        private void btnUsu_Click(object sender, EventArgs e)
        {
            btnUsuarios.Visible = true;
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            rjDropdownMenu8.Show(btnCaja, btnCaja.Width, 0);

        }

        private void btnCj_Click(object sender, EventArgs e)
        {
            btnCaja.Visible = true;
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {


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
            rjDropdownMenu1.IsMainMenu = true;
            rjDropdownMenu2.IsMainMenu = true;
            rjDropdownMenu3.IsMainMenu = true;
            rjDropdownMenu4.IsMainMenu = true;
            rjDropdownMenu5.IsMainMenu = true;
            rjDropdownMenu6.IsMainMenu = true;
            rjDropdownMenu7.IsMainMenu = true;
            rjDropdownMenu8.IsMainMenu = true;
            rjDropdownMenu9.IsMainMenu = true;
            rjDropdownMenu1.PrimaryColor = ColorTranslator.FromHtml("#FB0E8C");
            rjDropdownMenu2.PrimaryColor = ColorTranslator.FromHtml("#FB0E8C");
            rjDropdownMenu3.PrimaryColor = ColorTranslator.FromHtml("#FB0E8C");
            rjDropdownMenu4.PrimaryColor = ColorTranslator.FromHtml("#FB0E8C");
            rjDropdownMenu5.PrimaryColor = ColorTranslator.FromHtml("#FB0E8C");
            rjDropdownMenu6.PrimaryColor = ColorTranslator.FromHtml("#FB0E8C");
            rjDropdownMenu7.PrimaryColor = ColorTranslator.FromHtml("#FB0E8C");
            rjDropdownMenu8.PrimaryColor = ColorTranslator.FromHtml("#FB0E8C");
            rjDropdownMenu9.PrimaryColor = ColorTranslator.FromHtml("#FB0E8C");
            this.WindowState= FormWindowState.Maximized;
            this.FormBorderStyle= FormBorderStyle.None;
            timer1.Start();
            btnTorneo.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnTorneo.Width, btnTorneo.Height, 50, 50));
            btnEquipos.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnEquipos.Width, btnEquipos.Height, 50, 50));
            btnJugadores.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnJugadores.Width, btnJugadores.Height, 50, 50));
            btnEntrenador.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnEntrenador.Width, btnEntrenador.Height, 50, 50));
            btnEstadios.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnEstadios.Width, btnEstadios.Height, 50, 50));
            btnReportes.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnReportes.Width, btnReportes.Height, 50, 50));
            btnUsuarios.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnUsuarios.Width, btnUsuarios.Height, 50, 50));
            btnCaja.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnCaja.Width, btnCaja.Height, 50, 50));
            btnEntrenador.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnEntrenador.Width, btnEntrenador.Height, 50, 50));
            btnConfiguracion.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnConfiguracion.Width, btnConfiguracion.Height, 50, 50));
            btnArbitros.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, btnArbitros.Width, btnArbitros.Height, 50, 50));
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
      

        }
        void AccesoAdmin()
        {
            btnUsuarios.Enabled = esAdmin;
        }

        private void btnEntrenador_MouseLeave(object sender, EventArgs e)
        {
            btnEntrenador.BackColor = ColorTranslator.FromHtml("#FB0E8C");
        }

        private void btnEntrenador_MouseEnter(object sender, EventArgs e)
        {
            btnEntrenador.BackColor = ColorTranslator.FromHtml("#7C7C7C");
        }

        private void btnEntrenador_Click(object sender, EventArgs e)
        {
            rjDropdownMenu9.Show(btnEntrenador, btnEntrenador.Width, 0);
        }

        private void agregarArbitroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarJugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aggJu = new AgregarJugadores();

            AbrirFormEnPanel(PanelAggEquipo, aggJu);
        }

        private void jugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verJu = new VerJugadores();
            AbrirFormEnPanel(PanelAggEquipo, verJu);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usu = new Usuarios();
            AbrirFormEnPanel(PanelAggEquipo, usu);
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            equi = new Equipos();
            AbrirFormEnPanel(PanelAggEquipo, equi);
        }
    }
}
