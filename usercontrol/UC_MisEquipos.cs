using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using PruebasTorneos;
namespace TorneosFut.BotonesEquipos
{
    public partial class UC_MisEquipos: UserControl
    {
        AgregarEquipo agregarEquipo;
        csConexion conexion;
        VerEquipo equipo;
        public int equ = 0;
        DataTable dt = new DataTable();
        public UC_MisEquipos(string u, string c)
        {
            conexion = new csConexion();
            conexion.Usuario = u;
            conexion.Clave = c;
            InitializeComponent();
            dgvEquipos.RowHeadersVisible = false;
            dt = conexion.ListDGV("Select * from Equipo");
            DataView dv = new DataView(dt);
            dgvEquipos.DataSource = dv;
            AdaptarDGV(dgvEquipos);
        }
        private void label1_Paint(object sender, PaintEventArgs e)
        {
            label1.BackColor = Color.Transparent;
            using (Pen pen = new Pen(ColorTranslator.FromHtml("#FB038C"), 1)) 
            {
                e.Graphics.DrawRectangle(pen, 0, 0, label1.Width - 1, label1.Height - 1);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AdaptarDGV(dgvEquipos);
            label1.Paint += label1_Paint; 
        }
        void AdaptarDGV(DataGridView dgv)
        {
            dt = conexion.ListDGV("Select * from Equipo");
            DataView dv = new DataView(dt);
            dgv.DataSource = dv;
            int filas = dgv.RowCount;
            for (int i = 0; i < filas; i++)
            {
                dgv.Rows[i].Height = 40;//dgv.Height / filas;
            }
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //barra buscar equipo
        private void txtBarraBuscar_Click(object sender, EventArgs e)
        {
            if(txtBuscarMisEquipos.Text == "Buscar por nombre del equipo")
            {
                txtBuscarMisEquipos.Text = "";
                txtBuscarMisEquipos.ForeColor = Color.Black;
            }
        }
        private void txtBarraBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscarMisEquipos.Text == "")
            {
                txtBuscarMisEquipos.Text = "Buscar por nombre del equipo";
                txtBuscarMisEquipos.ForeColor = Color.Gray; 
            }
        }
        private void txtBuscarMisEquipos_KeyUp(object sender, KeyEventArgs e)
        {
            filtro(txtBuscarMisEquipos.Text.Trim(), dgvEquipos);
        }
        public void filtro(string filtro, DataGridView dgvEquipos)
        {
            if (string.IsNullOrWhiteSpace(filtro))
            {
                dgvEquipos.DataSource = conexion.ListDGV("Select * from Equipo");
                AdaptarDGV(dgvEquipos);
            }
            else
            {
                string consulta = $"Select * from Equipo where NombreClub like '%{filtro}%'";
                DataTable dt = conexion.ListDGV(consulta);
                dgvEquipos.DataSource = dt;
            }
        }
        private void dgvEquipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRow filaSeleccionada = ((DataView)dgvEquipos.DataSource).ToTable().Rows[e.RowIndex];
                equ = int.Parse(filaSeleccionada["IDEquipo"].ToString());
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //editar
            agregarEquipo = new AgregarEquipo(conexion.Usuario, conexion.Clave);
            agregarEquipo.txtId.Text = dgvEquipos[0, dgvEquipos.CurrentRow.Index].Value.ToString();
            agregarEquipo.txtNombreClub.Text = dgvEquipos[1, dgvEquipos.CurrentRow.Index].Value.ToString();
            agregarEquipo.txtPresidente.Text = dgvEquipos[2, dgvEquipos.CurrentRow.Index].Value.ToString();
            agregarEquipo.cmbGenero.Text = dgvEquipos[3, dgvEquipos.CurrentRow.Index].Value.ToString();
            agregarEquipo.cmbEstadio.Text = dgvEquipos[4, dgvEquipos.CurrentRow.Index].Value.ToString();
            agregarEquipo.cmbEntrenador.Text = dgvEquipos[5, dgvEquipos.CurrentRow.Index].Value.ToString();
            agregarEquipo.lblEntregarVisi(true, false);
            agregarEquipo.ShowDialog();
            AdaptarDGV(dgvEquipos);
        }
        private void btnVerEquipo_Click(object sender, EventArgs e)
        {
            //conexion = new csConexion();

            if (dgvEquipos.CurrentRow != null)
            {
                equipo = new VerEquipo(equ);
                equipo.txtNombrever.Text = dgvEquipos[1, dgvEquipos.CurrentRow.Index]?.Value?.ToString() ?? "";
                equipo.txtPresidentever.Text = dgvEquipos[2, dgvEquipos.CurrentRow.Index]?.Value?.ToString() ?? "";
                equipo.txtGenerover.Text = dgvEquipos[3, dgvEquipos.CurrentRow.Index]?.Value?.ToString() ?? "";
                DataTable dtEntrenador = conexion.ListDGV($"SELECT Nombres FROM Entrenador WHERE IDEntrenador = {int.Parse(dgvEquipos[5, dgvEquipos.CurrentRow.Index]?.Value?.ToString())}");
                if (dtEntrenador.Rows.Count > 0)
                {
                    equipo.txtEntrenadorver.Text = dtEntrenador.Rows[0]["Nombres"].ToString();
                }
                DataTable dtEstadio = conexion.ListDGV($"SELECT Nombre FROM Estadio WHERE IDEstadio = {int.Parse(dgvEquipos[4, dgvEquipos.CurrentRow.Index]?.Value?.ToString())}");
                if (dtEstadio.Rows.Count > 0)
                {
                    equipo.txtEstadiover.Text = dtEstadio.Rows[0]["Nombre"].ToString();
                }
                equipo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un equipo antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
