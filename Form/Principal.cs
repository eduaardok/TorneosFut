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
using Usuarios;
using pruebas;
using PruebasTorneos;
using TorneosFut.Properties;
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
        static csConexion conexion;
        static bool esAdmin;
        GestionUsuario Usuario;
        Entrenador entre;
        Equipos equi;
        static csEncriptar encriptar;
        Torneo tor;
        public Principal(string u, string c,string name)
        {
            if (u == "FutXpert")
                esAdmin = true;
            else
                esAdmin = false;
            conexion = new csConexion();
            conexion.Usuario = u;
            conexion.Clave = c;
            encriptar = new csEncriptar();
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
            //this.StartPosition = FormStartPosition.Manual;
            //this.Bounds = Screen.PrimaryScreen.WorkingArea;
            Usuario=new GestionUsuario(conexion.Usuario, conexion.Clave);
            ddbtnOpcionesU.Text = name;
            entre= new Entrenador(conexion.Usuario, conexion.Clave);
            equi = new Equipos(conexion.Usuario, conexion.Clave);
           tor = new Torneo(conexion.Usuario, conexion.Clave);
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


        private void btnPartidos_MouseEnter(object sender, EventArgs e)
        {
            btnOrganizador.BackColor = ColorTranslator.FromHtml("#FB038C");
        }


        private void btnArbitros_MouseEnter(object sender, EventArgs e)
        {
        }

        private void btnCaja_MouseEnter(object sender, EventArgs e)
        {
            btnPatrocinador.BackColor = ColorTranslator.FromHtml("#FB038C");
        }

        

        private void btnTorneos_MouseLeave(object sender, EventArgs e)
        {
            btnTorneos.BackColor = Color.FromArgb(20, 25, 29);
        }

        private void btnEquipos_MouseLeave(object sender, EventArgs e)
        {
            btnEquipos.BackColor = Color.FromArgb(20, 25, 29);

        }


        private void btnPartidos_MouseLeave(object sender, EventArgs e)
        {
            btnOrganizador.BackColor = Color.FromArgb(20, 25, 29);

        }
        private void btnCaja_MouseLeave(object sender, EventArgs e)
        {
            btnPatrocinador.BackColor = Color.FromArgb(20, 25, 29);

        }
        private void Principal_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.Dock= DockStyle.Fill;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.Manual;
            this.Bounds = Screen.PrimaryScreen.WorkingArea;
            AccesoAdmin();
        }
        void AccesoAdmin()
        {
            btnUsuarios.Enabled = esAdmin;
            btnUsuarios.Visible = esAdmin;
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
        private void tmopen_Tick(object sender, EventArgs e)
        {
            if (panelOpciones.Width < 294)
            {
                panelOpciones.Width = panelOpciones.Width + 20;
                btnCerrar.Enabled = false;

            }
            else
            {

                tmopen.Stop();
                btnCerrar.Enabled = true;
            }
        }

        private void timeclose_Tick(object sender, EventArgs e)
        {
            if (panelOpciones.Width > 90)
            {
                    panelOpciones.Width = panelOpciones.Width - 20;
                btnCerrar.Enabled = false;

            }
            else
            {
                btnCerrar.Enabled = true;

                timeclose.Stop();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (panelOpciones.Width > 90)
            {
                timeclose.Start();
                btnTorneos.Text = "";
                btnPatrocinador.Text = "";
                btnUsuarios.Text = "";
                btnEquipos.Text = "";
                btnOrganizador.Text = "";
                btnEntrenadores.Text = "";
            }
            else
            {
                tmopen.Start();
                btnTorneos.Text = "TORNEO";
                btnPatrocinador.Text = "PATROCINADORES";
                btnUsuarios.Text = "USUARIOS";
                btnEquipos.Text = "EQUIPOS";
                btnOrganizador.Text = "ORGANIZADORES";
                btnEntrenadores.Text = "ENTRENADORES";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += .07;
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(panelModulos, Usuario);
            
        }
        private void btnEntrenadores_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(panelModulos, entre);
        }

        private void btnTorneos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(panelModulos, tor);
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(panelModulos, equi);
        }

        private void cAMBIARCLAVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = conexion.ListDGV($"select ClaveUsuario, IDUsuario from Usuario where NombreUsuario='{ddbtnOpcionesU.Text}'");
           CambiarClave cambiarClave = new CambiarClave(conexion.Usuario, conexion.Clave, encriptar.Desencriptar(dt.Rows[0][0].ToString(), "futxpert"), dt.Rows[0][1].ToString());
            cambiarClave.ShowDialog();

        }
        private void cERRARSESIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelModulos_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
                if (tor.panelmodul.BackColor == Color.White)
                {
                panelModulos.BackColor = Color.Black;
                panelModulos.BackgroundImage = Resources.fxfutxpertblanco;
                button2.BackColor= Color.FromArgb(20, 25, 29);
                btnCerrar.BackColor= Color.FromArgb(20, 25, 29);
                button1.BackColor = Color.FromArgb(20, 25, 29);
                button1.BackgroundImage = Resources.icons8_luna_creciente_50;
                button2.BackgroundImage = Resources.icons8_cucha_50__1_;
                    //Torneo
                    tor.BackColor = Color.FromArgb(20, 25, 29);
                    tor.panelmodul.BackColor = Color.FromArgb(20, 25, 29);
                }
                else
                {
                panelModulos.BackColor = Color.White;
                panelModulos.BackgroundImage = Resources.fxfutxpert;
                btnCerrar.BackColor = Color.White;
                button1.BackColor= Color.White;
                button1.BackgroundImage = Resources.icons8_luna_creciente_50__1_;
                button2.BackColor= Color.White;
                button2.BackgroundImage = Resources.icons8_cucha_50;
                //Torneo
                tor.BackColor = Color.White;
                    tor.panelmodul.BackColor = Color.White;
                }
            // Cambiar el estado del modo oscuro (activar o desactivar)
            GlobalSettings.ModoOscuro = !GlobalSettings.ModoOscuro;
            // Guardar el estado en los settings para que persista entre sesiones
            Properties.Settings.Default.ModoOscuro = GlobalSettings.ModoOscuro.ToString();
            Properties.Settings.Default.Save();
            // Aplicar el tema a todos los formularios abiertos
            foreach (Form form in Application.OpenForms)
            {
                // Aplicar el modo oscuro o claro a cada formulario
                Modo_oscuro.AplicarModoOscuro(form, GlobalSettings.ModoOscuro);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Cerrar (ocultar) todos los formularios abiertos
            foreach (Form form in Application.OpenForms)
            {
                // Solo ocultar los formularios secundarios, no el formulario principal
                if (form != this)
                {
                    form.Hide();  // Esto oculta el formulario
                }
            }
            // Mostrar solo el panel (si no está ya visible)
            panelModulos.BringToFront();  // Asegura que el panel sea el que se muestre
        }
    }
}
