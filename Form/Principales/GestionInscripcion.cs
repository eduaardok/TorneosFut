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
    public partial class GestionInscripcion: Form
    {
        csDatos csDatos;
        csConexion conexion;
        csDGV csDGV;
        PagoInscripcion PagoInscripcion;
        string IdTorneo;
        string fecha;
        decimal costo;
        public GestionInscripcion(string IDtorneo, string u, string c)
        {

            csDatos = new csDatos(u, c);
            IdTorneo = IDtorneo;
            csDGV = new csDGV(u, c);
            conexion = new csConexion(u, c);
            InitializeComponent();
        }

        private void btngSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Verifica si el botón izquierdo del mouse está presionado
            {
                // Mueve el formulario a la nueva posición
                this.Location = new Point(
                    this.Location.X + e.X - (c.Width / 2),
                    this.Location.Y + e.Y - (c.Height / 2));
            }
        }

        private void GestionInscripcion_Load(object sender, EventArgs e)
        {
            DataTable torneo = conexion.ListDGV($"Select FechaInicio, CostoInscripcion from Torneo where IDTorneo = {IdTorneo}");
            fecha = torneo.Rows[0]["FechaInicio"].ToString();
            costo = decimal.Parse(torneo.Rows[0]["CostoInscripcion"].ToString());

            csDGV.MostrarNameEquipos(dgvEquipos);
            AdaptarDGV();
            csDGV.MostrarEquiposInsc(IdTorneo, dgvEquiposIns);
            AdaptarDGV();


            c.Tag = "NoCambiar";
            panel1.Tag = "NoCambiar";
            panel3.Tag = "NoCambiar";
            panel4.Tag = "NoCambiar";
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
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

            dgvEquiposIns.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#14191D");
            dgvEquiposIns.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvEquiposIns.EnableHeadersVisualStyles = false;
            //ActualizarTabla();
            dgvEquiposIns.Width = panelDgv2.Width;
            dgvEquiposIns.Height = panelDgv2.Height;

            int filas1, columnas1;
            filas1 = dgvEquiposIns.RowCount;
            columnas1 = dgvEquiposIns.ColumnCount;
            dgvEquiposIns.ColumnHeadersHeight = 50;//dgvUsuarios.Height / (1+filas);
            for (int i = 0; i < filas1; i++)
            {
                dgvEquiposIns.Rows[i].Height = 60;//dgvUsuarios.Height / (1+filas);
            }
            for (int i = 0; i < columnas1; i++)
            {
                dgvEquiposIns.Columns[i].Width = dgvEquiposIns.Width / columnas1;
            }
        }

        private void txtBuscarEquipo_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBuscarEquipo.Text == "Buscar por nombre del Equipo")
            {
                txtBuscarEquipo.Text = "";
                txtBuscarEquipo.ForeColor = Color.Black;
            }
        }
        void ActualizarTabla()
        {
            csDGV.MostrarNameEquiposFiltro(dgvEquipos, txtBuscarEquipo.Text);
            csDGV.AdaptarDGV(dgvEquipos, panelDgv);
            csDGV.MostrarEquiposInsc(IdTorneo, dgvEquiposIns);
            csDGV.AdaptarDGV(dgvEquiposIns, panelDgv2);
        }

        private void txtBuscarEquipo_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarEquipo.Text == "Buscar por nombre del Equipo")
                txtBuscarEquipo.Text = "";
            ActualizarTabla();
        }

        private void btnIncribir_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvEquipos.SelectedRows[0];
                string idequipo = row.Cells["IDEquipo"].Value.ToString();
                if (csDatos.InsertarIncripcion(int.Parse(IdTorneo), idequipo, costo, fecha))
                {
                    MessageBox.Show("Se inscribió el equipo correctamente");
                }
                else
                {
                    MessageBox.Show("Error al inscribir el equipo");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un equipo.");
            }
            ActualizarTabla();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvEquiposIns.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvEquiposIns.SelectedRows[0];

                string idequipo = row.Cells["IDEquipo"].Value.ToString();
                if (csDatos.QuitarIncripcion(idequipo))
                {
                    MessageBox.Show("Se quito el equipo correctamente");
                }
                else
                {
                    MessageBox.Show("Error al quitar el equipo");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un equipo.");
            }
            ActualizarTabla();
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvEquiposIns.SelectedRows[0];
            string idequipo = row.Cells["IDEquipo"].Value.ToString();
            PagoInscripcion = new PagoInscripcion(IdTorneo, idequipo, conexion.Usuario, conexion.Clave, true);
            PagoInscripcion.ShowDialog();
        }
    }
}
