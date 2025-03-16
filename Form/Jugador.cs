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
using TorneosFut.Class;
using TorneosFut.Properties;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace pruebas
{
    public partial class Jugador: Form
    {
        csConexion conexion;
        AggJugadores agregaJu;
        csJugador csJugador;
        csDGV csDGV;
        public Jugador(string u, string c)
        {
            conexion = new csConexion(u,c);
            csJugador = new csJugador(u,c);
            csDGV = new csDGV(u, c);
            InitializeComponent();
        }
        public static void AbrirFormEnPanel(Panel panel, Form formHijo)
        {
            if (panel.Controls.Count > 0)
                panel.Controls.Clear(); // Limpia cualquier contenido previo
            formHijo.TopLevel = false;  // Indica que no es un formulario independiente
            formHijo.Dock = DockStyle.Fill; // Ajusta al tamaño del panel
            panel.Controls.Add(formHijo); // Agrega el formulario al panel
            panel.Tag = formHijo; // Asocia el formulario con el panel
            formHijo.BringToFront(); // Lo trae al frente
            formHijo.Show(); // Muestra el formulario dentro del panel
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void VerJugadores_Load(object sender, EventArgs e)
        {
            Modo_oscuro.AplicarModoOscuro(this, GlobalSettings.ModoOscuro);
            //dgvJugador.DataSource = csJugador.mostrarJugador();
            csDGV.MostrarJugadores(dgvJugador);
            csDGV.AdaptarDGV(dgvJugador, panelDgv);
        }
       

        private void gnjugadores_Click(object sender, EventArgs e)
        {

        }

        private void gnAgregarJu_Click(object sender, EventArgs e)
        {

        }

        private void dgvJugador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
             try
            {

                if (dgvJugador.RowCount > 0)
                {
                    if (dgvJugador.CurrentRow.Index >= 0)
                    {

                        string id = dgvJugador.Rows[dgvJugador.CurrentRow.Index].Cells[0].Value.ToString();
                        AggJugadores edi = new AggJugadores(conexion.Usuario, conexion.Clave, true);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            AggJugadores aggju = new AggJugadores(conexion.Usuario, conexion.Clave,true);
            aggju.ShowDialog();
        }
      
        private void txtBuscarMisEquipos_KeyUp(object sender, KeyEventArgs e)
        {
            ActualizarTabla();
        }
        void ActualizarTabla()
        {
            csDGV.MostrarJugadoresFiltro(dgvJugador, txtBuscarJugador.Text);
            csDGV.AdaptarDGV(dgvJugador, panelDgv);
        }
        private void txtBuscarJugador_Click(object sender, EventArgs e)
        {
            if (txtBuscarJugador.Text == "Buscar por nombre del Jugador")
            {
                txtBuscarJugador.Text = "";
                txtBuscarJugador.ForeColor = Color.Black;
            }
        }

        private void txtBuscarJugador_TextChanged(object sender, EventArgs e)
        {
            ActualizarTabla();
        }
    }
}
