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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TorneosFut
{
    public partial class GestionFinanciera : Form
    {
        csDatos csDatos;
        csConexion conexion;
        csDGV csDGV;
        PagoInscripcion PagoInscripcion;
        AsignarPatrocinio patrocinio;
        int idtorneroSelec = 0;
        public GestionFinanciera(string u, string c)
        {
            csDatos = new csDatos(u, c);
            csDGV = new csDGV(u, c);
            conexion = new csConexion(u, c);
            InitializeComponent();
        }
        private void GestionFinanciera_Load(object sender, EventArgs e)
        {
            dgvPagos.GridColor = Color.FromArgb(251, 3, 140);
            dgvPagos.GridColor = Color.FromArgb(251, 3, 140);

            csDGV.MostrarMovimieentos(dgvPagos, idtorneroSelec);
            AdaptarDGV();
            btnAbonar.Visible = false;
            btnPagar.Visible = false;

            DataTable torneooo = conexion.ListDGV($"SELECT NombreTorneo, CostoInscripcion, FechaInicio, IDTorneo FROM Torneo");

            cmbTorneos.Items.Clear();
            torneos.Clear();
            foreach (DataRow row in torneooo.Rows)
            {
                int idTorneo = Convert.ToInt32(row["IDTorneo"]);
                string nombreTorneo = row["NombreTorneo"].ToString();
                torneos.Add(idTorneo, nombreTorneo);

                cmbTorneos.Items.Add(nombreTorneo);
            }
        }
        Dictionary<int, string> torneos = new Dictionary<int, string>();
        void ActualizarTablaM()
        {
            csDGV.MostrarMovimieentos(dgvPagos, idtorneroSelec);
            AdaptarDGV();
        }
        void ActualizarTablaE()
        {
            csDGV.MostrarMovimieentosE(dgvPagos, idtorneroSelec);
            AdaptarDGV();
        }

        void AdaptarDGV()
        {
            dgvPagos.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#14191D");
            dgvPagos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPagos.EnableHeadersVisualStyles = false;
            dgvPagos.Width = panel1.Width;
            dgvPagos.Height = panel1.Height;

            if (dgvPagos.RowCount > 0)
            {
                dgvPagos.ColumnHeadersHeight = 50;

                for (int i = 0; i < dgvPagos.RowCount; i++)
                {
                    dgvPagos.Rows[i].Height = 35;
                }
            }

            for (int i = 0; i < dgvPagos.ColumnCount; i++)
            {
                dgvPagos.Columns[i].Width = dgvPagos.Width / dgvPagos.ColumnCount;
            }
        }

        private void btnMovimiento_Click(object sender, EventArgs e)
        {
            btnAbonar.Visible = false;
            btnPagar.Visible = false;
            csDGV.MostrarMovimieentos(dgvPagos, idtorneroSelec);
            AdaptarDGV();
            ActualizarTablaM();
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            btnAbonar.Visible = true;
            btnPagar.Visible = false;
            csDGV.MostrarMovimieentosE(dgvPagos, idtorneroSelec);
            AdaptarDGV();
            ActualizarTablaE();
        }

        private void btnArbitros_Click(object sender, EventArgs e)
        {
            btnAbonar.Visible = false;
            btnPagar.Visible = false;
            csDGV.MostrarMovimieentosA(dgvPagos, idtorneroSelec);
            AdaptarDGV();
        }

        private void btnPatrocinador_Click(object sender, EventArgs e)
        {
            btnAbonar.Visible = false;
            btnPagar.Visible = true;
            csDGV.MostrarMovimieentosP(dgvPagos, idtorneroSelec);
            AdaptarDGV();
            patrocinio = new AsignarPatrocinio(conexion.Usuario, conexion.Clave);
            patrocinio.Show();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvPagos.SelectedRows[0];
            string idequipo = row.Cells["IDEquipo"].Value.ToString();
            string IdTorneo = row.Cells["IDTorneo"].Value.ToString();
            PagoInscripcion = new PagoInscripcion(IdTorneo, idequipo, conexion.Usuario, conexion.Clave);
            PagoInscripcion.ShowDialog();
            ActualizarTablaE();
        }

        private void cmbTorneos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTorneos.Text == "")
            {
                idtorneroSelec = 0;
            }
            else
            {
                string nombreTorneoSeleccionado = cmbTorneos.SelectedItem.ToString();
                idtorneroSelec = torneos.FirstOrDefault(x => x.Value == nombreTorneoSeleccionado).Key;
            }
        }

        private void GestionFinanciera_TextChanged(object sender, EventArgs e)
        {
            string filterText = cmbTorneos.Text.ToLower();

            var filteredTorneos = torneos.Values.Where(t => t.ToLower().Contains(filterText)).ToList();

            cmbTorneos.Items.Clear();

            foreach (string torneo in filteredTorneos)
            {
                cmbTorneos.Items.Add(torneo);
            }

            if (filteredTorneos.Count > 0)
            {
                cmbTorneos.SelectedIndex = 0;
            }
        }
        private void btnAbonar_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvPagos.SelectedRows[0];
            string idequipo = row.Cells["IDEquipo"].Value.ToString();
            string IdTorneo = row.Cells["IDTorneo"].Value.ToString();
            PagoInscripcion = new PagoInscripcion(IdTorneo, idequipo, conexion.Usuario, conexion.Clave);
            PagoInscripcion.ShowDialog();
            ActualizarTablaE();
        }
    }
}
