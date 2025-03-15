using pruebas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut.Class;
using Usuarios;

namespace TorneosFut
{
    public partial class Torneo: Form
    {
        csConexion conexion;
        Patrocinadores patro;
        Organizadores orga;
        GestionarPartidos partidos;
        Principal T;
        public Torneo(string u, string c, Principal r)
        {
            conexion = new csConexion();
            conexion.Usuario = u;
            conexion.Clave = c;
            InitializeComponent();
            patro = new Patrocinadores(u,c);
            orga = new Organizadores(u,c);
            T = r;

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
            panel.Show();
        }
        private void btnJugadores_Click(object sender, EventArgs e)
        {
               AbrirFormEnPanel(panelmodul, patro);
        }

        private void btnArbitros_Click(object sender, EventArgs e)
        {

        }

        private void btnEstadios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(panelmodul,orga);
        }

        private void Torneo_Load(object sender, EventArgs e)
        {
            panelmodul.Hide();
            //if (BackColor == Color.White)
            //{
            //    ju.label2.ForeColor = Color.Black;
            //    ju.BackColor = Color.White;
            //    ju.dgvJugador.BackgroundColor = Color.White;
            //    ju.dgvJugador.ForeColor = Color.Black;
            //    ju.dgvJugador.DefaultCellStyle.BackColor = Color.White;
            //    ju.dgvJugador.DefaultCellStyle.ForeColor = Color.Black;
            //    ju.dgvJugador.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            //    ju.dgvJugador.DefaultCellStyle.SelectionForeColor = Color.Black;
            //}
            //else
            //{
            //    ju.BackColor = Color.FromArgb(20, 25, 29);
            //    ju.label2.ForeColor = Color.White;
            //    ju.dgvJugador.BackgroundColor = Color.FromArgb(20, 25, 29);
            //    ju.dgvJugador.ForeColor = Color.White;
            //    ju.dgvJugador.DefaultCellStyle.BackColor = Color.FromArgb(30, 35, 40);
            //    ju.dgvJugador.DefaultCellStyle.ForeColor = Color.White;
            //    ju.dgvJugador.DefaultCellStyle.SelectionBackColor = Color.FromArgb(50, 55, 60);
            //    ju.dgvJugador.DefaultCellStyle.SelectionForeColor = Color.White;
            //}

            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelmodul.Hide();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int id = -1;
            AggTorneo a = new AggTorneo(true, id, conexion.Usuario, conexion.Clave);
            //AbrirFormEnPanel(panelDgv, a);
            a.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = 1;
            AggTorneo a = new AggTorneo(false, id, conexion.Usuario, conexion.Clave);
            //AbrirFormEnPanel(panelDgv, a);
            a.ShowDialog();
        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {
            partidos = new GestionarPartidos(conexion.Usuario, conexion.Clave,this,T);
            panelmodul.Show();
            T.Hide();
            partidos.ShowDialog();
           
        }
    }
}
