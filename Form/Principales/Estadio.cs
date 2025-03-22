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
    public partial class Estadio: Form
    {
        csConexion conexion;
        csDatos csDatos;
        csDGV csDGV;
        csEstadio csEstadio;
        public Estadio(string u, string c)
        {
            conexion = new csConexion(u,c);
            csDGV = new csDGV(u, c);
            csDatos = new csDatos(u, c);
            csEstadio = new csEstadio(u, c);
            InitializeComponent();
        }

        private void Estadio_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            csEstadio.Cargar(dgvEstadio, pictureBox1);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dgvEstadio.RowCount > 0)
            {
                if (dgvEstadio.CurrentRow.Index >= 0)
                {
                    AggEditEstadio agg = new AggEditEstadio(conexion.Usuario, conexion.Clave, false, csDatos.ObtenerIDEstadioDesdeDGV(dgvEstadio));
                    agg.ShowDialog();
                    ActualizarTabla();

                }
                else
                {
                    MessageBox.Show("Seleccione el estadio que desea editar");
                }
            }
            else
            {
                MessageBox.Show("La tabla está vacía");
            }
            txtFiltro.Text = "";
            ActualizarTabla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AggEditEstadio agg = new AggEditEstadio(conexion.Usuario, conexion.Clave, true, "-1");
            agg.ShowDialog();
            ActualizarTabla();


        }

        private void Estadio_Shown(object sender, EventArgs e)
        {
            csDGV.MostrarEstadios(dgvEstadio);
        }
        void ActualizarTabla()
        {
            if (txtFiltro.Text == "Buscar por nombre de Estadio")
            {
                txtFiltro.Text = "";
                txtFiltro.ForeColor = Color.Black;
            }
            csDGV.MostrarEstadiosFiltro(dgvEstadio, txtFiltro.Text);
            csDGV.AdaptarDGV(dgvEstadio, panelDgv);
        }

        private void txtFiltro_Click(object sender, EventArgs e)
        {
            if (txtFiltro.Text == "Buscar por nombre de Estadio")
            {
                txtFiltro.Text = "";
                txtFiltro.ForeColor = Color.Black;
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void dgvEstadio_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEstadio.CurrentRow.Index >= 0)
            {
                string id = dgvEstadio.Rows[dgvEstadio.CurrentRow.Index].Cells[0].Value.ToString();
                csDatos.MostrarImagenEstadio(id, pictureBox1);
            }
        }
    }
}
