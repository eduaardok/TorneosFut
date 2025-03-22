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
        csDGV csDGV;
        csDatos CsDatos;
        csEntrenador csEntrenador;
        public Entrenador(string u, string c)
        {
            conexion = new csConexion(u, c);
            csDGV= new csDGV(u, c);
            CsDatos = new csDatos(u, c);
            csEntrenador = new csEntrenador(u, c);
            InitializeComponent();
        }

        private void Padre_Load(object sender, EventArgs e)
        {
            this.Dock= DockStyle.Fill;
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            csEntrenador.Cargar(dgvEntrenador, ptbIMG);
            dgvEntrenador.CellFormatting += dgvEntrenador_CellFormatting;
        }

        private void btnAggDT_Click(object sender, EventArgs e)
        {
            AggEditEntrenador agg = new AggEditEntrenador(conexion.Usuario, conexion.Clave, true, "-1");
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
            
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {

        }

 
        private void dgvEntrenador_SelectionChanged(object sender, EventArgs e)
        {
        
        }

        private void txtBuscarEquipo_KeyUp(object sender, KeyEventArgs e)
        {
            ActualizarTabla();
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
            string id = CsDatos.ObtenerIDEntrenadorDesdeDGV(dgvEntrenador);
            AggEditEntrenador edit = new AggEditEntrenador(conexion.Usuario, conexion.Clave, false, id);
            edit.ShowDialog();
            ActualizarTabla();

            /* AggEditEntrenador ent = new AggEditEntrenador(conexion.Usuario, conexion.Clave, false);
             ent.txtID.Text = dgvEntrenador[0, dgvEntrenador.CurrentRow.Index].Value.ToString();
             ent.txtNombre.Text = dgvEntrenador[1, dgvEntrenador.CurrentRow.Index].Value.ToString();
             ent.txtApellido.Text = dgvEntrenador[2, dgvEntrenador.CurrentRow.Index].Value.ToString();
             ent.cmbSexo.Text = dgvEntrenador[3, dgvEntrenador.CurrentRow.Index].Value.ToString();
             var fechaNacimiento = dgvEntrenador[4, dgvEntrenador.CurrentRow.Index].Value;
             if (fechaNacimiento != DBNull.Value)
             {
                 DateTime fecha;
                 if (DateTime.TryParse(fechaNacimiento.ToString(), out fecha))
                 {
                     if (fecha >= ent.dtpNacimiento.MinDate && fecha <= ent.dtpNacimiento.MaxDate)
                     {
                         ent.dtpNacimiento.Value = fecha;
                     }
                     else
                     {
                         ent.dtpNacimiento.Value = ent.dtpNacimiento.MaxDate;
                     }
                 }
                 else
                 {
                     ent.dtpNacimiento.Value = DateTime.Today;
                 }
             }
             else
             {
                 ent.dtpNacimiento.Value = DateTime.Today;
             }

             ent.ShowDialog();*/
        }

        private void btnAggDT_Click_1(object sender, EventArgs e)
        {
            AggEditEntrenador ent = new AggEditEntrenador(conexion.Usuario, conexion.Clave,true, "-1");
            ent.ShowDialog();
            ActualizarTabla();
        }

        private void dgvEntrenador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscarEntrenador_TextChanged(object sender, EventArgs e)
        {
            ActualizarTabla();

        }
        void ActualizarTabla()
        {
            if (txtBuscarEntrenador.Text == "Buscar por nombre del Entrenador")
            {
                txtBuscarEntrenador.Text = "";
                txtBuscarEntrenador.ForeColor = Color.Black;
            }
            csDGV.MostrarEntrenadoresFiltro(dgvEntrenador, txtBuscarEntrenador.Text);
            csDGV.AdaptarDGV(dgvEntrenador);
        }
        private void txtBuscarEntrenador_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBuscarEntrenador.Text == "Buscar por nombre del Entrenador")
            {
                txtBuscarEntrenador.Text = "";
                txtBuscarEntrenador.ForeColor = Color.Black;
            }
        }

        private void dgvEntrenador_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvEntrenador.CurrentRow.Index >= 0)
            {
                string id = dgvEntrenador.Rows[dgvEntrenador.CurrentRow.Index].Cells[0].Value.ToString();
                CsDatos.MostrarImagenEntrenador(id, ptbIMG);
            }
        }

        private void Entrenador_Shown(object sender, EventArgs e)
        {

        }
    }
}