using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut;

namespace PruebasTorneos
{
    public partial class Entrenador: Form
    {
        csConexion conexion;
        csEntrenador dts;
        public Entrenador(string u, string c)
        {
            conexion = new csConexion();
            conexion.Usuario = u;
            conexion.Clave = c;
            InitializeComponent();
            dts = new csEntrenador(u, c);

        }

        private void Padre_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            dts.Cargar(dgvEntrenador);
            dgvEntrenador.CellFormatting += dgvEntrenador_CellFormatting;
        }

        private void btnAggDT_Click(object sender, EventArgs e)
        {
            AggEntrenador agg = new AggEntrenador(conexion.Usuario, conexion.Clave);
            agg.ShowDialog();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvEntrenador_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvEntrenador.Columns[e.ColumnIndex].Name == "PartidosGanados")
            {
                e.CellStyle.ForeColor = Color.Green;
            }
            if (dgvEntrenador.Columns[e.ColumnIndex].Name == "PartidosEmpatados")
            {
                e.CellStyle.ForeColor = Color.Orange;
            }
            if (dgvEntrenador.Columns[e.ColumnIndex].Name == "PartidosPerdidos")
            {
                e.CellStyle.ForeColor = Color.Red;
            }
            if (dgvEntrenador.Columns[e.ColumnIndex].Name == "Sexo" && e.Value != null)
            {
                string valor = e.Value.ToString().Trim().ToLower();
                if (valor == "masculino")
                {
                    e.CellStyle.ForeColor = Color.Blue;
                }
                else if (valor == "femenino")
                {
                    e.CellStyle.ForeColor = Color.Magenta;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditEntrenador edit = new EditEntrenador(conexion.Usuario, conexion.Clave);
            edit.ShowDialog();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {

        }

 
        private void dgvEntrenador_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvEntrenador.Rows.Count == 0 || dgvEntrenador.SelectedRows.Count == 0)
                    return;

                int fila = dgvEntrenador.SelectedRows[0].Index;
                string celda = dgvEntrenador.Rows[fila].Cells["IDEntrenador"].Value.ToString();

                string consulta = $"select ImagenEntrenador from Entrenador where IDEntrenador = {celda}";

                byte[] imagenBytes = conexion.ObtenerImagen(consulta, "ImagenEntrenador");

                if (imagenBytes != null && imagenBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imagenBytes))
                    {
                        ptbIMG.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    ptbIMG.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }
        }

        private void txtBuscarEquipo_KeyUp(object sender, KeyEventArgs e)
        {
            dts.filtro(txtBuscarEntrenador.Text.Trim(), dgvEntrenador);
        }

        private void txtBuscarEquipo_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBuscarEntrenador.Text == "Buscar por nombre del entrenador")
            {
                txtBuscarEntrenador.Text = "";
                txtBuscarEntrenador.ForeColor = Color.Black;
            }
        }
    }
}
