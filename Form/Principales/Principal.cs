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
        [DllImport("user32.dll")] private static extern void ReleaseCapture();
        [DllImport("user32.dll")] private static extern void SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        frmCorreos correo;
        static csConexion conexion;
        static bool esAdmin;
        static csEncriptar encriptar;
        GestionUsuario Usuario;
        Entrenador entre;
        Equipos equi;
        Torneo tor;
        Patrocinadores Patro;
        Organizadores Orga;
        Auditoria auditoria;
        csDatos csDatos;
        GestionFinanciera financiera;
        public Principal(string u, string c,string name)
        {
            esAdmin =(u == "FutXpert");
            conexion = new csConexion(u, c);
            encriptar = new csEncriptar();
            csDatos = new csDatos(u, c);
            conexion.RegistrarAuditoriaInicioSesion();
            InitializeComponent();
            Usuario=new GestionUsuario(u, c);
            ddbtnOpcionesU.Text = name;
            entre= new Entrenador(u, c);
            equi = new Equipos(u, c);
            tor = new Torneo(u, c, this);
            Patro = new Patrocinadores(u, c);
            Orga = new Organizadores(u, c);
            auditoria = new Auditoria(u,c);
            financiera = new GestionFinanciera(u,c);

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

        private void btnTorneos_MouseLeave(object sender, EventArgs e)
        {
            btnTorneos.BackColor = Color.FromArgb(20, 25, 29);
        }

        private void btnEquipos_MouseLeave(object sender, EventArgs e)
        {
            btnEquipos.BackColor = Color.FromArgb(20, 25, 29);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.Dock= DockStyle.Fill;
            this.StartPosition = FormStartPosition.Manual;
            this.Bounds = Screen.PrimaryScreen.WorkingArea;
            AccesoAdmin();
            this.Text = $"FUTXPERT - Conectado a la base de datos como: {conexion.Usuario}";
            panel1.Tag = "NoCambiar";
            panelModulos.Tag= "NoCambiar";
        }
        void AccesoAdmin()
        {
            btnUsuarios.Enabled = esAdmin;
            btnUsuarios.Visible = esAdmin;
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
                btnUsuarios.Text = "";
                btnEquipos.Text = "";
                btnAuditorias.Text = "";
                button3.Text = "";
                btnCorreos.Text = "";
            }
            else
            {
                tmopen.Start();
                btnTorneos.Text = "TORNEO";
                btnUsuarios.Text = "USUARIOS";
                btnEquipos.Text = "EQUIPOS";
                btnAuditorias.Text = "AUDITORÍAS";
                button3.Text = "GESTIÓN FINANCIERA";
                btnCorreos.Text = "CORREOS";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += .07;
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(panelModulos, Usuario);
            equi.Close();
            tor.Close();
            
        }
  

        private void btnTorneos_Click(object sender, EventArgs e)
        {
            if (tor != null)
            {
                tor = new Torneo(conexion.Usuario, conexion.Clave,this);
            }
            AbrirFormEnPanel(panelModulos, tor);
            equi.Close();
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            if (equi != null)
            {
                equi = new Equipos(conexion.Usuario, conexion.Clave);
            }
            AbrirFormEnPanel(panelModulos, equi);
            tor.Close();
            
        }

        private void panelModulos_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

                if (this.BackColor == Color.White)
                {
                panelModulos.BackColor = Color.Black;
                panelModulos.BackgroundImage = Resources.fxfutxpertblanco;
                pictureBox1.BackgroundImage= Resources.logoFXblanco;
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
                pictureBox1.BackgroundImage = Resources.logoFX;
                btnCerrar.BackColor = Color.White;
                button1.BackColor= Color.White;
                button1.BackgroundImage = Resources.icons8_luna_creciente_50__1_;
                button2.BackColor= Color.White;
                button2.BackgroundImage = Resources.icons8_cucha_50;
                //Torneo
                tor.BackColor = Color.White;
                    tor.panelmodul.BackColor = Color.White;
                }
            panel1.Tag = "NoCambiar";
            panelModulos.Tag = "NoCambiar";
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
            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
                {
                    form.Hide(); 
                }
            }
            panelModulos.BringToFront();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(panelModulos, auditoria);
        }

        private void ttmiCambiarClave_Click(object sender, EventArgs e)
        {
            CambiarClave cambiarClave = new CambiarClave(conexion.Usuario, conexion.Clave, 
                                        encriptar.Desencriptar(csDatos.ObtenerClaveUsuario(ddbtnOpcionesU.Text), "futxpert"), csDatos.ObtenerIDUsuario(ddbtnOpcionesU.Text).ToString());
            cambiarClave.ShowDialog();
        }

        private void ttmiCerrarSesion_Click(object sender, EventArgs e)
        {
            conexion.RegistrarAuditoriaCierreSesion();
            Close();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexion.RegistrarAuditoriaCierreSesion();
        }

        private void btnAuditorias_MouseEnter(object sender, EventArgs e)
        {
            btnAuditorias.BackColor = ColorTranslator.FromHtml("#FB038C");
        }

        private void btnAuditorias_MouseLeave(object sender, EventArgs e)
        {
            btnAuditorias.BackColor = Color.FromArgb(20, 25, 29);
        }

    

        private void button3_Click_2(object sender, EventArgs e)
        {
            AbrirFormEnPanel(panelModulos, financiera);

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = ColorTranslator.FromHtml("#FB038C");

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(20, 25, 29);

        }

        private void btnCorreos_Click(object sender, EventArgs e)
        {
            if (correo == null || correo.IsDisposed)
            {
                correo = new frmCorreos();
                correo.Show();
            }
            else
            {
                correo.BringToFront();
            }
        }

        private void btnCorreos_MouseEnter(object sender, EventArgs e)
        {
            btnCorreos.BackColor = ColorTranslator.FromHtml("#FB038C");
        }

        private void btnCorreos_MouseLeave(object sender, EventArgs e)
        {
            btnCorreos.BackColor = Color.FromArgb(20, 25, 29);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void tstSuperior_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tstSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            this.WindowState = FormWindowState.Maximized;
        }
        private void tstSuperior_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
    }
}