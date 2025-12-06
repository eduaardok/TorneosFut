using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneosFut
{
    public partial class Patrocinadores: Form
    {
        csConexion conexion;
        csDGV csDGV;
        AsignarPatrocinio asignarPatrocinio;

        public Patrocinadores(string u, string c)
        {
            conexion = new csConexion(u,c);
            csDGV = new csDGV(u, c);
            asignarPatrocinio = new AsignarPatrocinio(u, c);
            InitializeComponent();
            Modo_oscuro.EstiloDGV(dgvPatrocinador);
        }

        private void Patrocinadores_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvPatrocinador.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
        }
        void ActualizarTabla()
        {
            csDGV.MostrarPatrocinadoresFiltro(dgvPatrocinador, txtFiltro.Text);
            csDGV.AdaptarDGV(dgvPatrocinador);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void txtFiltro_Click(object sender, EventArgs e)
        {
            if (txtFiltro.Text == "Buscar por nombre de Patrocinador")
            {
                txtFiltro.Text = "";
                txtFiltro.ForeColor = Color.Black;
            }
        }

        private void Patrocinadores_Shown(object sender, EventArgs e)
        {
            csDGV.MostrarPatrocinadores(dgvPatrocinador);
        }

        private void btnAggPatrocinador_Click(object sender, EventArgs e)
        {
            AggEditPatrocinador aggEditPatrocinador = new AggEditPatrocinador(conexion.Usuario, conexion.Clave, true, "");
            aggEditPatrocinador.ShowDialog();
            csDGV.MostrarPatrocinadores(dgvPatrocinador);
        }

        private void btnEditarPatrocinador_Click_1(object sender, EventArgs e)
        {
            AggEditPatrocinador aggEditPatrocinador = new AggEditPatrocinador(conexion.Usuario, conexion.Clave, false, dgvPatrocinador.Rows[dgvPatrocinador.CurrentRow.Index].Cells["IDPatrocinador"].Value.ToString());
            aggEditPatrocinador.ShowDialog();
            csDGV.MostrarPatrocinadores(dgvPatrocinador);
        }

        private void btnPatrocinador_Click(object sender, EventArgs e)
        {
            asignarPatrocinio.ShowDialog();
        }
    }
}
