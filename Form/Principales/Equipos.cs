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
        AggEditEquipo aggEquipo;
        csEquipo equipo;
        Jugador ju;
        Entrenador entre;
        csDGV csDGV;
        Estadio esta;
        AgregarJugadorEquipo aggjugadorEquipo;
        public Equipos(string u, string c)
        {
            conexion = new csConexion(u,c);
            equipo = new csEquipo(u, c);
            ju = new Jugador(u, c);
            entre = new Entrenador(u, c);
            csDGV = new csDGV(u, c);
            esta = new Estadio(u, c);
            InitializeComponent();
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
            //dgvEquipos.DataSource = dgvEquipo¿();
            csDGV.MostrarEquipos(dgvEquipos);
            AdaptarDGV();
            panelmodul.Hide();
        }

        private void btngMostrar_Click(object sender, EventArgs e)
        {
            aggEquipo = new AggEditEquipo(conexion.Usuario, conexion.Clave,true);
            aggEquipo.ShowDialog();
            ActualizarTabla();

        }

        private void btngEditar_Click(object sender, EventArgs e)
        {
            aggEquipo = new AggEditEquipo(conexion.Usuario, conexion.Clave, false);
            aggEquipo.txtId.Text = dgvEquipos[0, dgvEquipos.CurrentRow.Index].Value.ToString();
            csDGV.LlenarcmbEstadio(aggEquipo.cmbEstadio);
            //aggEquipo.cmbEstadio.Text = dgvEquipos[1,dgvEquipos.CurrentRow.Index].ToString();
            aggEquipo.txtNombreClub.Text = dgvEquipos[2, dgvEquipos.CurrentRow.Index].Value.ToString();
            aggEquipo.cmbGenero.Text = dgvEquipos[4, dgvEquipos.CurrentRow.Index].Value.ToString();
            aggEquipo.cmbEstadio.Text = dgvEquipos[1, dgvEquipos.CurrentRow.Index].Value.ToString();
            aggEquipo.cmbEquipacionLocal.Text = dgvEquipos[5, dgvEquipos.CurrentRow.Index].Value.ToString();
            aggEquipo.cmbequipacionvisitante.Text = dgvEquipos[6, dgvEquipos.CurrentRow.Index].Value.ToString();
            aggEquipo.txtPresidente.Text= dgvEquipos[3, dgvEquipos.CurrentRow.Index].Value.ToString();
            aggEquipo.ShowDialog();
            ActualizarTabla();

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
            ActualizarTabla();
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

        private void btnEstadio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(panelmodul, esta);
        }
        void ActualizarTabla()
        {
            if (txtBuscarEquipo.Text == "Buscar por nombre del Equipo")
                txtBuscarEquipo.Text = "";
            csDGV.MostrarEquiposFiltro(dgvEquipos, txtBuscarEquipo.Text);
            csDGV.AdaptarDGV(dgvEquipos, panelDgv);
        }
        private void txtBuscarEquipo_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarEquipo.Text == "Buscar por nombre del Equipo")
                txtBuscarEquipo.Text = "";
            ActualizarTabla();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            aggjugadorEquipo = new AgregarJugadorEquipo(conexion.Usuario, conexion.Clave, dgvEquipos.CurrentRow.Cells[0].Value.ToString());
            aggjugadorEquipo.ShowDialog();
            ActualizarTabla();
        }

        private void dgvEquipos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvEquipos.CurrentRow.Index >= 0)
            {
                string id = dgvEquipos.Rows[dgvEquipos.CurrentRow.Index].Cells[0].Value.ToString();
                equipo.MostrarIMG(id, ptbIMG);
            }
        }

        private void panelmodul_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            string IDEquipo = dgvEquipos.SelectedRows[0].Cells["IDEquipo"].Value.ToString();
            frmEquiposEst estadisticaEQUIPO = new frmEquiposEst(IDEquipo);
            estadisticaEQUIPO.Show(); 
        }

        private void btnListas_Click(object sender, EventArgs e)
        {
            string IDEquipo = dgvEquipos.SelectedRows[0].Cells["IDEquipo"].Value.ToString();
            frmListaDeJugadores lista = new frmListaDeJugadores(IDEquipo);
            lista.Show();
        }
    }
}