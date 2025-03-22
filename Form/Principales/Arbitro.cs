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
    
    public partial class Arbitro: Form
    {
        PagoArbitro PagoArbitro;
        csDGV csDGV;
        csConexion csConexion;
        public Arbitro(string u, string c)
        {
            PagoArbitro = new PagoArbitro(u, c);
            csConexion = new csConexion(u,c);
            csDGV = new csDGV(u,c);
            InitializeComponent();
        }

        private void Arbitro_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            csDGV.MostrarArbitros(dgvArbitro);
        }

        private void btnPagoArbitro_Click(object sender, EventArgs e)
        {
            PagoArbitro.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AggEditArbitro AggEditArbitro = new AggEditArbitro(csConexion.Usuario,csConexion.Clave,true);
            AggEditArbitro.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AggEditArbitro AggEditArbitro = new AggEditArbitro(csConexion.Usuario, csConexion.Clave, true);
            AggEditArbitro.ShowDialog();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            ActualizarTabla();
        }
        void ActualizarTabla()
        {
            csDGV.MostrarArbitrosFiltro(dgvArbitro, txtFiltro.Text);
            csDGV.AdaptarDGV(dgvArbitro);
        }
        private void txtFiltro_Click(object sender, EventArgs e)
        {
            if (txtFiltro.Text == "Buscar por nombre del Arbitro")
            {
                txtFiltro.Text = "";
                txtFiltro.ForeColor = Color.Black;
            }
        }

        private void Arbitro_Shown(object sender, EventArgs e)
        {
            csDGV.MostrarArbitros(dgvArbitro);
        }
    }
}
