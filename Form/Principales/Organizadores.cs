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
    public partial class Organizadores: Form
    {
        csConexion conexion;
        csDGV csDGV;
        public Organizadores(string u, string c)
        {
            conexion = new csConexion(u,c);
            csDGV= new csDGV(u,c);
            InitializeComponent();
            
        }

        private void Organizadores_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            csDGV.MostrarOrganizadores(dgvOrganizador);
        }

        private void btnAggOrganizador_Click(object sender, EventArgs e)
        {
            AggEditOrganizador aggEditOrganizador = new AggEditOrganizador(dgvOrganizador.Rows[dgvOrganizador.CurrentRow.Index].Cells["IDOrganizador"].Value.ToString(), conexion.Usuario, conexion.Clave, true);
            aggEditOrganizador.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AggEditOrganizador aggEditOrganizador = new AggEditOrganizador(dgvOrganizador.Rows[dgvOrganizador.CurrentRow.Index].Cells["IDOrganizador"].Value.ToString(), conexion.Usuario, conexion.Clave, false);
            aggEditOrganizador.ShowDialog();
        }

        private void txtFiltro_Click(object sender, EventArgs e)
        {
            if (txtFiltro.Text == "Buscar por nombre del Organizador")
            {
                txtFiltro.Text = "";
                txtFiltro.ForeColor = Color.Black;
            }
        }
    }
}
