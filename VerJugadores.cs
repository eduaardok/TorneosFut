using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneosFut;

namespace pruebas
{
    public partial class VerJugadores: Form
    {
        csConexion conexion = new csConexion();
        public VerJugadores()
        {
            InitializeComponent();
            AdaptarDGV();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void AdaptarDGV()
        {
            int filas, columnas;
            filas = dgvjugadores.RowCount;
            columnas = dgvjugadores.ColumnCount;
            for (int i = 0; i < filas; i++)
            {
                dgvjugadores.Rows[i].Height = dgvjugadores.Height / filas;
            }
            for (int i = 0; i < columnas; i++)
            {
                dgvjugadores.Columns[i].Width = dgvjugadores.Width / columnas;
            }
            dgvjugadores.DataSource = conexion.ListDGV("Select * from Jugador");


        }
        private void VerJugadores_Load(object sender, EventArgs e)
        {
            
        }

        private void btneditarjuga_Click(object sender, EventArgs e)
        {


            if (dgvjugadores.RowCount > 0)
            {
                if (dgvjugadores.CurrentRow.Index >= 0)
                {
                    string id = dgvjugadores.Rows[dgvjugadores.CurrentRow.Index].Cells[0].Value.ToString();
                    EditarJugador edi = new EditarJugador(id);
                    edi.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seleccione el usuario que desea editar");
                }
            }
            else
            {
                MessageBox.Show("La tabla está vacía");
            }
            AdaptarDGV();

        }
    }
}
