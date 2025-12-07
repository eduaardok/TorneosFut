using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut.Class;

namespace TorneosFut
{
    public partial class GestionInscripcion : Form
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
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(
                    this.Location.X + e.X - (c.Width / 2),
                    this.Location.Y + e.Y - (c.Height / 2));
            }
        }

        private void GestionInscripcion_Load(object sender, EventArgs e)
        {
            dgvEquipos.ClearSelection();
            dgvEquipos.CurrentCell = null;
            dgvEquiposIns.ClearSelection();
            dgvEquiposIns.CurrentCell = null;

            dgvEquipos.GridColor = Color.FromArgb(251, 3, 140);
            dgvEquiposIns.GridColor = Color.FromArgb(251, 3, 140);

            DataTable torneo = conexion.ListDGV($"Select FechaInicio, CostoInscripcion from Torneo where IDTorneo = {IdTorneo}");
            fecha = torneo.Rows[0]["FechaInicio"].ToString();
            costo = decimal.Parse(torneo.Rows[0]["CostoInscripcion"].ToString());

            csDGV.MostrarNameEquipos(IdTorneo, dgvEquipos);
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
            dgvEquipos.Width = panelDgv.Width;
            dgvEquipos.Height = panelDgv.Height;

            if (dgvEquipos.RowCount > 0)
            {
                dgvEquipos.ColumnHeadersHeight = 50;

                for (int i = 0; i < dgvEquipos.RowCount; i++)
                {
                    dgvEquipos.Rows[i].Height = 35;
                }
            }

            for (int i = 0; i < dgvEquipos.ColumnCount; i++)
            {
                dgvEquipos.Columns[i].Width = dgvEquipos.Width / dgvEquipos.ColumnCount;
            }

            dgvEquiposIns.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#14191D");
            dgvEquiposIns.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvEquiposIns.EnableHeadersVisualStyles = false;
            dgvEquiposIns.Width = panelDgv2.Width;
            dgvEquiposIns.Height = panelDgv2.Height;

            if (dgvEquiposIns.RowCount > 0)
            {
                dgvEquiposIns.ColumnHeadersHeight = 50;

                for (int i = 0; i < dgvEquiposIns.RowCount; i++)
                {
                    dgvEquiposIns.Rows[i].Height = 35;
                }
            }

            for (int i = 0; i < dgvEquiposIns.ColumnCount; i++)
            {
                dgvEquiposIns.Columns[i].Width = dgvEquiposIns.Width / dgvEquiposIns.ColumnCount;
            }
            Modo_oscuro.EstiloDGV(dgvEquipos);
            Modo_oscuro.EstiloDGV(dgvEquiposIns);
        }

        private void txtBuscarEquipo_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBuscarEquipo.Text == "Buscar por nombre del Equipo")
            {
                txtBuscarEquipo.Text = "";
                txtBuscarEquipo.ForeColor = Color.Black;
            }
            AdaptarDGV();
        }
        void ActualizarTabla()
        {
            csDGV.MostrarNameEquiposFiltro(dgvEquipos, txtBuscarEquipo.Text, IdTorneo);
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

        List<string> ObtenerJugadoresElegibles(int idTorneo)
        {
            List<string> lista = new List<string>();

            string query = @"
                SELECT j.IDJugador, j.NombreJugador, j.ApellidoJugador
                FROM Jugador j
                JOIN Jugador_Equipo ej ON ej.IDJugador = j.IDJugador
                JOIN Equipo e ON e.IDEquipo = ej.IDEquipo
                JOIN Torneo t ON t.IDTorneo = @idTorneo
                WHERE dbo.CalcularEdad(j.FechaNacimiento, t.FechaInicio)
                      BETWEEN t.EdadMin AND t.EdadMax
            ";

            SqlConnection cn = new SqlConnection(conexion.CadenaConexion);
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.Add(new SqlParameter("@idTorneo", idTorneo));

            cn.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string linea = rd["IDJugador"].ToString() + " - " +
                               rd["NombreJugador"].ToString() + " " +
                               rd["ApellidoJugador"].ToString();

                lista.Add(linea);
            }

            cn.Close();
            return lista;
        }

        void GuardarJugadoresElegibles(int idTorneo)
        {
            SqlConnection cn = new SqlConnection(conexion.CadenaConexion);

            SqlCommand cmd = new SqlCommand("dbo.InsertarJugadoresElegibles", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@IDTorneo", idTorneo));

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void btnIncribir_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos un equipo.");
                return;
            }

            List<string> listaEquipos = new List<string>();

            foreach (DataGridViewRow row in dgvEquipos.SelectedRows)
            {
                string idequipo = row.Cells["IDEquipo"].Value.ToString();
                listaEquipos.Add(idequipo);
            }

            int idT = int.Parse(IdTorneo);

            List<string> jugadoresOK = ObtenerJugadoresElegibles(idT);

            if (jugadoresOK.Count > 0)
            {
                string msg = "Jugadores que PUEDEN entrar al torneo:\n\n";

                for (int i = 0; i < jugadoresOK.Count; i++)
                {
                    msg += "• " + jugadoresOK[i] + "\n";
                }

                MessageBox.Show(msg, "Jugadores elegibles");
            }
            else
            {
                MessageBox.Show("Ningún jugador cumple la edad mínima/máxima.\nNo se puede inscribir.");
                return;
            }

            GuardarJugadoresElegibles(idT);

            if (csDatos.InsertarIncripcion(idT, listaEquipos, costo, fecha))
            {
                MessageBox.Show($"Se inscribieron correctamente {listaEquipos.Count} equipos.");
                ActualizarTabla();
            }
            else
            {
                MessageBox.Show("Hubo un error al inscribir algunos equipos.");
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvEquiposIns.SelectedRows.Count > 0)
            {
                int equiposQuitados = 0;
                foreach (DataGridViewRow row in dgvEquiposIns.SelectedRows)
                {
                    string idequipo = row.Cells["IDEquipo"].Value.ToString();

                    if (csDatos.QuitarIncripcion(idequipo))
                    {
                        equiposQuitados++;
                    }
                    else
                    {
                        //errores++;
                    }
                }
                MessageBox.Show($"Se quitaron {equiposQuitados} equipos correctamente.");
                ActualizarTabla();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione al menos un equipo.");
            }
        }

        public bool VerificarInscripcion(int idTorneo, string idEquipo)
        {
            string query = $"select * from InscripcionEquipo where IDTorneo = {idTorneo} and IDEquipo = '{idEquipo}'";
            DataTable dt = conexion.ListDGV(query);
            return dt.Rows.Count > 0;
        }
        private void btnAbonar_Click(object sender, EventArgs e)
        {
            //DataGridViewRow row = dgvEquiposIns.SelectedRows[0];
            //string idequipo = row.Cells["IDEquipo"].Value.ToString();
            //PagoInscripcion = new PagoInscripcion(IdTorneo, idequipo, conexion.Usuario, conexion.Clave);
            //PagoInscripcion.ShowDialog();
        }
    }
}