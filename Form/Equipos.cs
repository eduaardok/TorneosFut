using pruebas;
using PruebasTorneos;
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
    public partial class Equipos: Form
    {
        csConexion conexion ;
        AggEquipo aggEquipo;
        csEquipo equipo;
        Jugador ju;
        Entrenador entre;
        public Equipos(string u, string c)
        {
            conexion = new csConexion();
            conexion.Usuario = u;
            conexion.Clave = c;
            InitializeComponent();
            equipo = new csEquipo(conexion.Usuario,conexion.Clave);
            ju= new Jugador(conexion.Usuario, conexion.Clave);
            entre = new Entrenador (conexion.Usuario, conexion.Clave);
        }
        private void addUserControl(UserControl userControll)
        {
            userControll.Dock = DockStyle.Fill;
            userControll.BringToFront();
        }
        void AdaptarDGV()
        {
            dgvEquipos.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#14191D");
            dgvEquipos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvEquipos.EnableHeadersVisualStyles = false;
            //ActualizarTabla();
            dgvEquipos.Width = panelDgv.Width;
            dgvEquipos.Height = panelDgv.Height;

            int filas, columnas;
            filas = dgvEquipos.RowCount;
            columnas = dgvEquipos.ColumnCount;
            dgvEquipos.ColumnHeadersHeight = 50;//dgvUsuarios.Height / (1+filas);
            for (int i = 0; i < filas; i++)
            {
                dgvEquipos.Rows[i].Height = 60;//dgvUsuarios.Height / (1+filas);
            }
            for (int i = 0; i < columnas; i++)
            {
                dgvEquipos.Columns[i].Width = dgvEquipos.Width / columnas;
            }
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Equipos_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            dgvEquipos.DataSource = equipo.mostrarequipo();
            AdaptarDGV();
            panelmodul.Hide();
        }

        private void btngMostrar_Click(object sender, EventArgs e)
        {
            aggEquipo = new AggEquipo(conexion.Usuario, conexion.Clave);
            aggEquipo.lblEntregarVisi(false, true);
            aggEquipo.ShowDialog();
        }

        private void btngEditar_Click(object sender, EventArgs e)
        {

            aggEquipo = new AggEquipo(conexion.Usuario, conexion.Clave);
            aggEquipo.txtId.Text = dgvEquipos[0, dgvEquipos.CurrentRow.Index].Value.ToString();
            aggEquipo.txtNombreClub.Text = dgvEquipos[1, dgvEquipos.CurrentRow.Index].Value.ToString();
            aggEquipo.txtPresidente.Text = dgvEquipos[2, dgvEquipos.CurrentRow.Index].Value.ToString();
            aggEquipo.cmbGenero.Text = dgvEquipos[3, dgvEquipos.CurrentRow.Index].Value.ToString();
            aggEquipo.cmbEstadio.Text = dgvEquipos[4, dgvEquipos.CurrentRow.Index].Value.ToString();
            aggEquipo.cmbEntrenador.Text = dgvEquipos[5, dgvEquipos.CurrentRow.Index].Value.ToString();
            aggEquipo.ShowDialog();

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
        private void txtBuscarJugador_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBuscarEquipo.Text == "Buscar por nombre del Equipo")
            {
                txtBuscarEquipo.Text = "";
                txtBuscarEquipo.ForeColor = Color.Black;
            }
        }
        public void filtro(string filtro, DataGridView dgvEquipos)
        {
            if (string.IsNullOrWhiteSpace(filtro))
            {
                dgvEquipos.DataSource = equipo.mostrarequipo();
                AdaptarDGV();
            }
            else
            {
                string consulta = $"SELECT * FROM Equipo " +
                  $"WHERE NombreClub LIKE '%{filtro}%'";
                DataTable dt = conexion.ListDGV(consulta);
                dgvEquipos.DataSource = dt;
            }
        }
        private void txtBuscarJugador_KeyUp(object sender, KeyEventArgs e)
        {
            filtro(txtBuscarEquipo.Text.Trim(), dgvEquipos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelmodul.Hide();
        }

        private void btnJugador_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(panelmodul,ju);
        }

        private void btnEntrenador_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(panelmodul, entre);
        }
    }

}

