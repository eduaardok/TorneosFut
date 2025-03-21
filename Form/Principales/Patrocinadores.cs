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

        public Patrocinadores(string u, string c)
        {
            conexion = new csConexion(u,c);
            csDGV = new csDGV(u, c);
            InitializeComponent();
        }

        private void Patrocinadores_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
        }

        private void btnAggDT_Click(object sender, EventArgs e)
        {
            AggEditPatrocinador aggEditPatrocinador= new AggEditPatrocinador(conexion.Usuario,conexion.Clave,true);
            aggEditPatrocinador.ShowDialog();
        }

        private void btnEditarPatrocinador_Click(object sender, EventArgs e)
        {
            AggEditPatrocinador aggEditPatrocinador = new AggEditPatrocinador(conexion.Usuario, conexion.Clave, false);
            aggEditPatrocinador.ShowDialog();
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
    }
}
