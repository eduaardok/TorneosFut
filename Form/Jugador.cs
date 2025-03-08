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
using TorneosFut.Class;

namespace pruebas
{
    public partial class Jugador: Form
    {
        csConexion conexion;
        AggJugadores agregaJu;
        csJugador jugador;
        public Jugador(string u, string c)
        {
            conexion = new csConexion();
            jugador = new csJugador(u,c);
            conexion.Usuario = u;
            conexion.Clave = c;
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void VerJugadores_Load(object sender, EventArgs e)
        {
            dgvJugador.DataSource = jugador.mostrarJugador();
            AdaptarDGV();
        }
        void AdaptarDGV()
        {
            dgvJugador.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#14191D");
            dgvJugador.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvJugador.EnableHeadersVisualStyles = false;
            //ActualizarTabla();
            dgvJugador.Width = panelDgv.Width;
            dgvJugador.Height = panelDgv.Height;

            int filas, columnas;
            filas = dgvJugador.RowCount;
            columnas = dgvJugador.ColumnCount;
            dgvJugador.ColumnHeadersHeight = 50;//dgvUsuarios.Height / (1+filas);
            for (int i = 0; i < filas; i++)
            {
                dgvJugador.Rows[i].Height = 60;//dgvUsuarios.Height / (1+filas);
            }
            for (int i = 0; i < columnas; i++)
            {
                dgvJugador.Columns[i].Width = dgvJugador.Width / columnas;
            }
        }

        private void gnjugadores_Click(object sender, EventArgs e)
        {

        }

        private void gnAgregarJu_Click(object sender, EventArgs e)
        {

        }

        private void dgvJugador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvJugador.RowCount > 0)
                {
                    if (dgvJugador.CurrentRow.Index >= 0)
                    {

                        string id = dgvJugador.Rows[dgvJugador.CurrentRow.Index].Cells[0].Value.ToString();
                        Editjugador edi = new Editjugador(id, this, conexion.Usuario, conexion.Clave);
                        edi.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione el usuario que desea editar");
                    }
                }
                else
                {
                    MessageBox.Show("La tabla está vacía");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            AggJugadores aggju = new AggJugadores(this,conexion.Usuario, conexion.Clave);
            aggju.ShowDialog();
        }
        public void filtro(string filtro, DataGridView dgvEquipos)
        {
            if (string.IsNullOrWhiteSpace(filtro))
            {
                dgvEquipos.DataSource = jugador.mostrarJugador();
                AdaptarDGV();
            }
            else
            {
                string consulta = $"SELECT IDJugador, Nombres, Apellidos, Sexo, FechaNacimiento, Posicion, EquipoActual, Goles, " +
                  $"Disponibilidad, PartidosJugados, Nacionalidad, Peso, Altura, PiernaHabil " +
                  $"FROM Jugador " +
                  $"WHERE Nombres LIKE '%{filtro}%' OR Apellidos LIKE '%{filtro}%' OR CONCAT(Nombres, ' ', Apellidos) LIKE '%{filtro}%'";
                DataTable dt = conexion.ListDGV(consulta);
                dgvEquipos.DataSource = dt;
            }
        }
        private void txtBuscarMisEquipos_KeyUp(object sender, KeyEventArgs e)
        {
            filtro(txtBuscarJugador.Text.Trim(), dgvJugador);
        }

        private void txtBuscarJugador_Click(object sender, EventArgs e)
        {
            if (txtBuscarJugador.Text == "Buscar por nombre del Jugador")
            {
                txtBuscarJugador.Text = "";
                txtBuscarJugador.ForeColor = Color.Black;
            }
        }
    }
}
