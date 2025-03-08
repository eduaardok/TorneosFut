using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TorneosFut.BotonesEquipos
{
    public partial class UC_TodosEquipos: UserControl
    {
        public int equ = 0;
        csConexion conexion;
        DataTable dt = new DataTable();
        public UC_TodosEquipos(string u, string c)
        {
            conexion = new csConexion();
            conexion.Usuario = u;
            conexion.Clave = c;
            InitializeComponent();
            dgvTodosEquipos.RowHeadersVisible = false;
            dt = conexion.ListDGV("Select * from Equipo");
            DataView dv = new DataView(dt);
            dgvTodosEquipos.DataSource = dv;
            AdaptarDGV(dgvTodosEquipos);
        }
        void AdaptarDGV(DataGridView dgvEntrenador)
        {
            int filas = dgvEntrenador.RowCount;
            for (int i = 0; i < filas; i++)
            {
                dgvEntrenador.Rows[i].Height = dgvEntrenador.Height / filas;
            }
            dgvEntrenador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void lbBorde_Paint(object sender, PaintEventArgs e)
        {
            lbBorde.BackColor = Color.Transparent;
            using (Pen pen = new Pen(ColorTranslator.FromHtml("#FB038C"), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, lbBorde.Width - 1, lbBorde.Height - 1);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbBorde.Paint += lbBorde_Paint;
        }
        //barra buscar equipo
        private void txtBuscarTodosEquipos_Click_1(object sender, EventArgs e)
        {
            if (txtBuscarTodosEquipos.Text == "Buscar por nombre del equipo")
            {
                txtBuscarTodosEquipos.Text = "";
                txtBuscarTodosEquipos.ForeColor = Color.Black;
            }
        }
        private void txtBuscarTodosEquipos_Leave(object sender, EventArgs e)
        {
            if (txtBuscarTodosEquipos.Text == "")
            {
                txtBuscarTodosEquipos.Text = "Buscar por nombre del equipo";
                txtBuscarTodosEquipos.ForeColor = Color.Gray;
            }
        }
        private void dgvTodosEquipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRow filaSeleccionada = ((DataView)dgvTodosEquipos.DataSource).ToTable().Rows[e.RowIndex];
                equ = int.Parse(filaSeleccionada["IDEquipo"].ToString());
            }
        }

        private void txtBuscarTodosEquipos_KeyUp(object sender, KeyEventArgs e)
        {
            filtro(txtBuscarTodosEquipos.Text.Trim(), dgvTodosEquipos);
        }
        public void filtro(string filtro, DataGridView dgvTodosEquipos)
        {
            if (string.IsNullOrWhiteSpace(filtro))
            {
                dgvTodosEquipos.DataSource = conexion.ListDGV("Select * from Equipo");
                AdaptarDGV(dgvTodosEquipos);
            }
            else
            {
                string consulta = $"Select * from Equipo where NombreClub like '%{filtro}%'";
                DataTable dt = conexion.ListDGV(consulta);
                dgvTodosEquipos.DataSource = dt;
            }
        }

        private void btnVerTodosEquipos_Click(object sender, EventArgs e)
        {
        }
    }
}
