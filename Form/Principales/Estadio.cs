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
    public partial class Estadio: Form
    {
        csConexion conexion;
        csDGV csDGV;
        public Estadio(string u, string c)
        {
            conexion = new csConexion(u,c);
            csDGV = new csDGV(u, c);
            InitializeComponent();
        }

        private void Estadio_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AggEditEstadio agg= new AggEditEstadio(conexion.Usuario,conexion.Clave,false);
            agg.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AggEditEstadio agg = new AggEditEstadio(conexion.Usuario, conexion.Clave, true);
            agg.ShowDialog();
        
        }

        private void Estadio_Shown(object sender, EventArgs e)
        {
            csDGV.MostrarEstadios(dgvEstadio);
        }
        void ActualizarTabla()
        {
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
    }
}
