using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut;

namespace PruebasTorneos
{
    public partial class FrmEntrenadores : Form
    {
        csEntrenador dt = new csEntrenador();
        csConexion conec= new csConexion();
        public FrmEntrenadores()
        {
            InitializeComponent();
            string consulta = "select sum(PartidosGanados) as TotalGanados, sum(PartidosEmpatados) as TotalEmpatados, " +
                  "sum(PartidosPerdidos) as TotalPerdidos from Entrenador";
            DataTable dt = conec.ListDGV(consulta);
            if (dt.Rows.Count > 0)
            {
                lblGanados.Text = dt.Rows[0]["TotalGanados"].ToString();
                lblEmpatados.Text = dt.Rows[0]["TotalEmpatados"].ToString();
                lblPerdidos.Text = dt.Rows[0]["TotalPerdidos"].ToString();
            }

        }

        private void FrmEntrenadores_Load(object sender, EventArgs e)
        {
            dt.Cargar(dgvEntrenador);
            dgvEntrenador.CellFormatting += dgvEntrenador_CellFormatting;
        }

        private void dgvEntrenador_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvEntrenador.Columns[e.ColumnIndex].Name == "PartidosGanados")
            {
                e.CellStyle.BackColor = Color.LightGreen; 
            }
            if (dgvEntrenador.Columns[e.ColumnIndex].Name == "PartidosPerdidos")
            {
                e.CellStyle.BackColor = Color.Red;
            }
            if (dgvEntrenador.Columns[e.ColumnIndex].Name == "PartidosEmpatados")
            {
                e.CellStyle.BackColor = Color.Orange;
            }
            if (dgvEntrenador.Columns[e.ColumnIndex].Name == "Sexo" && e.Value != null)
            {
                string valor = e.Value.ToString().Trim().ToLower();
                if(valor == "masculino")
                {
                    e.CellStyle.ForeColor = Color.Blue;
                } 
                else if (valor == "femenino")
                {
                    e.CellStyle.ForeColor = Color.Magenta;
                }
            }
        }

        private void txtBuscador_KeyUp(object sender, KeyEventArgs e)
        {
            filtro();
        }

        public void filtro()
        {
            string filtro = txtBuscador.Text.Trim().ToString();
            if (string.IsNullOrWhiteSpace(filtro))
            {
                dgvEntrenador.DataSource = conec.ListDGV("select * from Entrenador");
            }
            else
            {
                string consulta = $"select * from Entrenador where IDEntrenador like '%{filtro}%' or " +
                    $"Nombres like '%{filtro}%' or Apellidos like '%{filtro}%' or EquipoActual like '%{filtro}%'";

                DataTable dt = conec.ListDGV(consulta);
                dgvEntrenador.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}