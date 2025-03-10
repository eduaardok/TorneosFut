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

namespace TorneosFut
{
    public partial class Torneo: Form
    {
        csConexion conexion;
        Jugador ju;

        public Torneo(string u, string c)
        {
            conexion = new csConexion();
            conexion.Usuario = u;
            conexion.Clave = c;
            InitializeComponent();
            ju = new Jugador(conexion.Usuario, conexion.Clave);


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
        private void btnJugadores_Click(object sender, EventArgs e)
        {
               AbrirFormEnPanel(panelmodul, ju);
        }

        private void btnArbitros_Click(object sender, EventArgs e)
        {

        }

        private void btnEstadios_Click(object sender, EventArgs e)
        {

        }

        private void Torneo_Load(object sender, EventArgs e)
        {
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
    }
}
