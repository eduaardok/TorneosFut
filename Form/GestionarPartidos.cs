using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut;

namespace pruebas
{
    public partial class GestionarPartidos : Form
    {
        csConexion conexion;
        Goles gol;
        string ID;
        Torneo tr;
        Principal r;
        public GestionarPartidos(string u, string c, Torneo t, Principal te)
        {
            conexion = new csConexion(u, c);
            InitializeComponent();
            tr = t;
            r = te;
        }

        private void txtBuscador_KeyUp(object sender, KeyEventArgs e)
        {
            string filtro = txtBuscarPartido.Text.Trim().ToString();
            if (string.IsNullOrWhiteSpace(filtro))
            {
                dgvPartido.DataSource = conexion.ListDGV("select * from Partido");
            }
            else
            {
                string consulta = $"select * from Jugador where " +
                    $"EquipoLocal like '%{filtro}%' or EquipoVisitante like '%{filtro}%' or Jornada like '%{filtro}%'";

                DataTable dt = conexion.ListDGV(consulta);
                dgvPartido.DataSource = dt;
            }
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
        private void dgvJugador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void verjugadores_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void btnGol_Click(object sender, EventArgs e)
        {
            gol = new Goles();
            gol.ShowDialog();
        }

        private void dgvPartido_SelectionChanged(object sender, EventArgs e)
        {
            int fila = dgvPartido.SelectedRows[0].Index;
            ID = dgvPartido.Rows[fila].Cells["IDPartido"].Value.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            tr.panelmodul.Hide();
            r.Show();
            Close();
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
    }
}