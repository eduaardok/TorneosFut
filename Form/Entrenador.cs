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
            dts = new csEntrenador(u, c);
            InitializeComponent();

        }

        private void Padre_Load(object sender, EventArgs e)
        {
            this.Dock= DockStyle.Fill;
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            dts.Cargar(dgvEntrenador, ptbIMG);
            dgvEntrenador.CellFormatting += dgvEntrenador_CellFormatting;
        }

        private void btnAggDT_Click(object sender, EventArgs e)
        {
            AggEditEntrenador agg = new AggEditEntrenador(conexion.Usuario, conexion.Clave, true);
            agg.ShowDialog();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvEntrenador_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            AggEditEntrenador edit = new AggEditEntrenador(conexion.Usuario, conexion.Clave, false);
            edit.ShowDialog();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {

        }

 
        private void dgvEntrenador_SelectionChanged(object sender, EventArgs e)
        {
        
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

        private void btnEditar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAggDT_Click_1(object sender, EventArgs e)
        {
            AggEditEntrenador ent = new AggEntrenador(conexion.Usuario, conexion.Clave);
            ent.ShowDialog();
        }

        private void dgvEntrenador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
